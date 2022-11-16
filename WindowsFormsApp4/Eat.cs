using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    internal class Eat
    {
        private Point point;

        public Eat(Point point)
        {
            this.point = point;
        }
        public void moveX(int dx)
        {
            point.X = point.X + dx;
        }
        public void moveY(int dy)
        {
            point.Y = point.Y + dy;
        }

        public void paint(Graphics graphics)
        {
            Random random = new Random();
            int xRand = random.Next(0, 800);
            int yRand = random.Next(0, 800);

            graphics.FillEllipse(new SolidBrush(Color.RoyalBlue), xRand, yRand, 15, 15);
        }

    }
}
