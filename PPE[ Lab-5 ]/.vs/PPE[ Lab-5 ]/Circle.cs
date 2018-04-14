using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE__Lab_5__
{
    class Circle
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public Circle(int x,int y,int width,int height)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
        }
    }
}
