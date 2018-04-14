using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPE__Lab_5__
{
    public partial class Form1 : Form
    {
        private Snake snake;

        private Direction startDirection;
        private int circleWidth;
        private int circleHeight;
        private int speed;
        SolidBrush foodBrush;

        private Circle food;

        private int gridWidth;
        private int gridHeight;
        int score = 0, bonus = 0;

        SoundPlayer snakaEats = new SoundPlayer(@"crunch.wav");
        SoundPlayer startMusic = new SoundPlayer(@"bckgMusic.wav");

        public Form1()
        {
            InitializeComponent();
            startDirection = Direction.Down;
            circleWidth = 16;
            circleHeight = 16;
            speed = 7;
            snake = new Snake(speed,startDirection);
            timer.Interval = 1000/speed;
            gridWidth = this.Canvas.Width / circleWidth;
            gridHeight = this.Canvas.Height / circleHeight;

            this.RulesLabel.Text = "Press P\nfor pausing \nthe GAME";
            this.RulesLabel.Font = new Font("Ravie", 12, FontStyle.Bold);
            this.DoubleBuffered = true;
            startMusic.Play();
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            MenuPanel.Dispose();
            startMusic.Stop();
            Start();
        }

        public void Start()
        {
            // create new snake 
            snake = new Snake(speed, startDirection);
            this.GameOverlabel.Visible = false; 
            this.ScoreLabel.Text = "Score : " + snake.Body.Count;
            this.ScoreLabel.Font= new Font("Ravie", 14, FontStyle.Bold);
            // create head of the snake and add it to body
            Circle head = new Circle(5,5,circleWidth,circleHeight);
            snake.Body.Add(head);

            GenerateFood();
        }

        public void GenerateFood()
        {
            bonus = 0;
            snake.foodBonus = false;
            Random random = new Random();
            food = new Circle(random.Next(0,gridWidth),random.Next(0,gridHeight),circleWidth,circleHeight);
        }

        public void GenerateBonusFood()
        {
            bonus = 10;
            snake.foodBonus = true;
            Random random = new Random();
            food = new Circle(random.Next(0, gridWidth), random.Next(0, gridHeight), circleWidth*2, circleHeight*2);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (snake.Move(gridWidth, gridHeight, food)) // return true if snake get food
            {
                snakaEats.Play();
                score += 10 + bonus;

                if (snake.Body.Count % 5 == 0)
                {
                    GenerateBonusFood();
                }
                else
                {
                    GenerateFood();
                }

                this.ScoreLabel.Text = "Score : " + score;

                // increase speed when snake eats 2 (apples)
                if (snake.Body.Count % 2 == 0)
                {
                    snake.Speed++;
                }
            }
                Canvas.Invalidate();            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //this.timer.Enabled = true; // need to start the game at any key INPUT

            if (e.KeyCode == Keys.P)
            {
                if (this.timer.Enabled)
                {
                    this.timer.Enabled = false;
                }
                else
                {
                    this.timer.Enabled = true;
                }
            }

            if (this.timer.Enabled) // Player can not change the snake direction when he pauses the game
            {
                if (snake.Dead)
                {
                    if (e.KeyCode == Keys.Enter)
                    {
                        Start();
                    }
                }
                else
                {
                    switch (e.KeyCode)
                    {
                        case Keys.Right:
                            if (snake.SnakeDirection != Direction.Left)
                                snake.SnakeDirection = Direction.Right;
                            break;
                        case Keys.Left:
                            if (snake.SnakeDirection != Direction.Right)
                                snake.SnakeDirection = Direction.Left;
                            break;
                        case Keys.Up:
                            if (snake.SnakeDirection != Direction.Down)
                                snake.SnakeDirection = Direction.Up;
                            break;
                        case Keys.Down:
                            if (snake.SnakeDirection != Direction.Up)
                                snake.SnakeDirection = Direction.Down;
                            break;
                    }
                }
            }
        }

        private void Canvas_Paint(object sender, PaintEventArgs e)
        {
            if (!snake.Dead)
            {
                SolidBrush snakeBrush = new SolidBrush(Color.DarkBlue); // Head Color
                if (!snake.foodBonus)
                {
                    foodBrush = new SolidBrush(Color.Red); // Food Color
                    e.Graphics.FillEllipse(foodBrush,
                        food.X * circleWidth, food.Y * circleHeight,
                        food.Width, food.Height);
                }
                else
                {
                    foodBrush = new SolidBrush(Color.Gold); // Food Color
                    e.Graphics.FillEllipse(foodBrush,
                        food.X * circleWidth, food.Y * circleHeight,
                        circleWidth * 2, circleHeight * 2);
                }
                
                for (int i = 0; i < snake.Body.Count; i++)
                {
                    if (i > 0)
                    {
                        snakeBrush.Color = Color.Blue; // Body Color
                    }
                    // Draw Snake
                    e.Graphics.FillEllipse(snakeBrush,
                        snake.Body[i].X*circleWidth,snake.Body[i].Y*circleHeight,
                        circleWidth,circleHeight);

                }
            }
            else
            {
                this.GameOverlabel.Text = "GAME OVER\nYour Final Score is : " + (snake.Body.Count - 1) * 10 +
                                          "\nPress Enter to Play Again !";
                this.GameOverlabel.Visible = true;
            }
        }
    }
}
