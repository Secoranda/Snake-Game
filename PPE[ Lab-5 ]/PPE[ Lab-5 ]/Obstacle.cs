﻿using System.Drawing;
using System.Windows.Forms;

namespace PPE__Lab_5__
{
	public class Obstacle
	{
		public int x;
		public int y;
		public int w;
		public int h;

		public Obstacle(int x, int y, int w, int h)
		{
			this.x = x;
			this.y = y;
			this.w = w;
			this.h = h;
		}
	}
}
