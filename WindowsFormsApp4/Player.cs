using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    enum Direction
    {
        Left,
        Right,
        Up,
        Down,
        Stop
    }
    internal class Player
    {
        private Point point;
        Direction directionState;
        bool isWall;
        Thread thread;
        public bool isRunning;
        int speed;

        int playerSizeWidth, playerSizeHeight;


        public Player(Point point)
        {
            this.point = point;
            directionState = Direction.Stop;
            isRunning = false;
            isWall = false;
            speed = 5;
            thread = new Thread(move);
            playerSizeHeight = 50;
            playerSizeWidth = 50;
        }

        
        public Direction currenntDirection()
        {
            return directionState;
        }       

        public void setDirection(Keys key)
        {
            switch (key)
            {
                case Keys.Left:
                    directionState = Direction.Left;
                    break;
                case Keys.Right:
                    directionState = Direction.Right;
                    break;
                case Keys.Up:
                    directionState = Direction.Up;
                    break;
                case Keys.Down:
                    directionState = Direction.Down;
                    break;
            }
        }
        
        private void move()
        {
            if (directionState != Direction.Stop)
            {
                while (isRunning)
                {
                    switch (directionState)
                    {
                        case Direction.Left:
                            moveX(-speed);
                            break;
                        case Direction.Right:
                            moveX(speed);
                            break;
                        case Direction.Down:
                            moveY(speed);
                            break;
                        case Direction.Up:
                            moveY(-speed);
                            break;
                            default:
                            break;
                    }
                    Thread.Sleep(25);
                }
            }
        }
        public void start()
        {
            isRunning = true;
            thread.Start();
        }
        public void stop()
        {
            isRunning = false;
        }

        public void moveX(int dx)
        {
            if (0<point.X+dx&&point.X+dx+playerSizeWidth< Form1.ActiveForm.ClientSize.Width)
            {
                point.X=point.X+dx;
            }
            else
            {
                directionState = Direction.Stop;
            }    
        }
        public void moveY(int dy)
        {
            if (point.Y+dy+playerSizeHeight< Form1.ActiveForm.ClientSize.Height&&point.Y+dy>0 )
            {
                point.Y=point.Y+dy;
            }
            else{
                directionState=Direction.Stop;
            }
        }
        

        public void paint(Graphics graphics)
        {
            Rectangle rectangle = new Rectangle(point, new Size(playerSizeHeight, playerSizeWidth));
            graphics.FillRectangle(new SolidBrush(Color.Red), rectangle);
        }

    }
}
