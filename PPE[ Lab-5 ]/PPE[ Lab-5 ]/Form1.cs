using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace PPE__Lab_5__
{
	enum Level
	{
		Basic, Medium, Hard
	};

	public partial class Form1 : Form
    {
        private Snake snake;
        private Circle food;

        private int circleWidth;
        private int circleHeight;
        private int gridWidth;
        private int gridHeight;

		int score = 0, bonus = 0;

        SolidBrush foodBrush;
		Pen pen = new Pen(new SolidBrush(Color.SaddleBrown), 10);

        SoundPlayer snakaEats = new SoundPlayer(@"crunch.wav");
        SoundPlayer startMusic = new SoundPlayer(@"bckgMusic.wav");

		Level lvl;

        public Form1()
        {
            InitializeComponent();
            startMusic.Play();
        }

		private void StartBtn_Click(object sender, EventArgs e)
		{
			MenuPanel.Dispose();
			LevelPanel.Visible = true;
		}

		private void BasicLvlBtn_Click(object sender, EventArgs e)
		{
			lvl = Level.Basic;
			Start();
		}

		private void MediumLvlBtn_Click(object sender, EventArgs e)
		{
			lvl = Level.Medium;
			Start();
		}

		private void HardLvlBtn_Click(object sender, EventArgs e)
		{
			lvl = Level.Hard;
			Start();
		}

		public void Start()
        {
			LevelPanel.Dispose();
			GamePanel.Visible = true;

			snake = new Snake(5, Direction.Down, lvl);

			circleWidth = 16;
			circleHeight = 16;
			gridWidth = this.Canvas.Width / circleWidth;
			gridHeight = this.Canvas.Height / circleHeight;

			timer.Enabled = true;
			timer.Interval = 1000 / snake.Speed;

			this.RulesLabel.Text = "Press P\nfor pausing \nthe GAME";
            this.ScoreLabel.Text = "Score : " + snake.Body.Count;
			GameOverlabel.Visible = false;

			// create head of the snake and add it to body
			Circle head = new Circle(5, 5, circleWidth, circleHeight);
            snake.Body.Add(head);

            GenerateFood();
        }

        public void GenerateFood()
        {
            bonus = 0;
            snake.FoodBonus = false;
            Random random = new Random();
            food = new Circle(random.Next(0, gridWidth), random.Next(0, gridHeight),
				circleWidth, circleHeight);
        }

        public void GenerateBonusFood()
        {
            bonus = 10;
            snake.FoodBonus = true;
            Random random = new Random();
            food = new Circle(random.Next(0, gridWidth), random.Next(0, gridHeight),
				circleWidth * 2, circleHeight * 2);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
			if (snake.Move(gridWidth, gridHeight, food))
            {
                snakaEats.Play();
                score += 10 + bonus;

                if (snake.Body.Count % 5 == 0)
                    GenerateBonusFood();
                else
                    GenerateFood();

                this.ScoreLabel.Text = "Score : " + score;

				// increase speed when snake eats 2 (apples)
				if (snake.Body.Count % 2 == 0)
				{
					snake.Speed += 2;
					timer.Interval = 1000 / snake.Speed;
				}
            }
			Canvas.Invalidate();            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
			// pauses the game at P key down event
			if (e.KeyCode == Keys.P && this.timer.Enabled)
				this.timer.Enabled = false;

			// unpauses the game at any key down event
			else if (!timer.Enabled)
				timer.Enabled = true;

			// Player can not change the snake direction when he pauses the game
			if (this.timer.Enabled)
            {
				// restarts the game at any key down event
				if (snake.Dead)
					Start();
                else
					switch (e.KeyCode)
					{
						case Keys.D:
						case Keys.Right:
							if (snake.SnakeDirection != Direction.Left)
								snake.SnakeDirection = Direction.Right;
							break;
						case Keys.A:
                        case Keys.Left:
                            if (snake.SnakeDirection != Direction.Right)
                                snake.SnakeDirection = Direction.Left;
                            break;
						case Keys.W:
                        case Keys.Up:
                            if (snake.SnakeDirection != Direction.Down)
                                snake.SnakeDirection = Direction.Up;
                            break;
						case Keys.S:
                        case Keys.Down:
                            if (snake.SnakeDirection != Direction.Up)
                                snake.SnakeDirection = Direction.Down;
                            break;
                    }
            }
        }

		private void Canvas_Paint(object sender, PaintEventArgs e)
        {
			if (snake != null)
			{
				if (!snake.Dead)
				{
					SolidBrush snakeBrush = new SolidBrush(Color.DarkBlue); // Head Color

					if (!snake.FoodBonus)
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
							snakeBrush.Color = Color.Blue; // Body Color

						// Draw Snake
						e.Graphics.FillEllipse(snakeBrush, snake.Body[i].X * circleWidth,
							snake.Body[i].Y * circleHeight, circleWidth, circleHeight);
					}

					// draws obstacles 
					if (lvl != Level.Basic)
						foreach (var obst in snake.Obstacles)
							e.Graphics.FillRectangle(new SolidBrush(Color.SaddleBrown),
								obst.x * circleWidth, obst.y * circleHeight, obst.w, obst.h);
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
}
