using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPE__Lab_5__
{
    public enum Direction
    {
        Up,
        Down,
        Left,
        Right
    }

    class Snake
    {
        public int Speed { get; set; }
        public List<Circle> Body { get; set; }
        public bool Dead { get; set; }
        public Direction SnakeDirection { get; set; }
        public bool foodBonus { get; set; }

        public Snake(int speed, Direction direction)
        {
            Dead = false;
            Body = new List<Circle>();

            Speed = speed;
            SnakeDirection = direction;

        }

        public void Eat(Circle circle)
        {
            Body.Add(circle);
        }

        public bool Move(int gridWidth , int gridHeight , Circle food)
        {
            for (int i = this.Body.Count - 1; i >= 0; i--)
            {
                //Move head
                if (i == 0)
                {
                    switch (this.SnakeDirection)
                    {
                        case Direction.Right:
                            this.Body[i].X++;
                            break;
                        case Direction.Left:
                            this.Body[i].X--;
                            break;
                        case Direction.Up:
                            this.Body[i].Y--;
                            break;
                        case Direction.Down:
                            this.Body[i].Y++;
                            break;
                    }

                    
                    //Detect collission with form borders.
                    if (this.Body[i].X < 0 || this.Body[i].Y < 0
                                       || this.Body[i].X >= gridWidth || this.Body[i].Y >= gridHeight)
                    {
                        this.Dead = true;
                    }

                    
                    //Detect collission with snake body
                    for (int j = 1; j < this.Body.Count; j++)
                    {
                        if (this.Body[i].X == this.Body[j].X &&
                            this.Body[i].Y == this.Body[j].Y)
                        {
                            this.Dead = true;
                        }
                    }
                    
                    //Detect collision with food 
                   
                    if (!foodBonus && this.Body[0].X == food.X && this.Body[0].Y == food.Y)
                    {
                        this.Eat(food);
                        return true;
                    } 

                   else if(foodBonus)
                    {
                        if((this.Body[0].X == food.X && this.Body[0].Y == food.Y) ||
                            (this.Body[0].X == food.X + 1 && this.Body[0].Y == food.Y + 1) ||
                            (this.Body[0].X == food.X && this.Body[0].Y == food.Y + 1)||
                            (this.Body[0].X == food.X + 1 && this.Body[0].Y == food.Y))
                        {
                            food.X = Body[0].X;
                            food.Y = Body[0].Y;
                            this.Eat(food);
                            return true;
                        }
                  
                    }
                }
                else
                {
                    //Move body **********
                    Body[i].X = Body[i - 1].X;
                    Body[i].Y = Body[i - 1].Y;
                }
            }

            return false;
        }



    }
}
