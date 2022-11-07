using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticWinForms_urok_03_Task5
{
    public partial class Form1 : Form
    {
        PictureBox frog;
        public Form1()
        {
            InitializeComponent();
            frog = new PictureBox();
            this.Load += FormLoad;
            this.MouseMove += FormMouseMove;
            this.MouseMove += new MouseEventHandler(moveMouse);

        }
        private void moveMouse(Object sender, MouseEventArgs mouse)
        {
            this.Text = mouse.Location.ToString();
            foreach (var view in this.Controls)
            {
                if (view is Button)
                {
                    var button = (Button)view;
                    Point point00 = button.Location;

                    if (point00.X - 50 < mouse.X)
                    {
                        point00.X++;
                        button.Location = point00;
                    }
                }
            }
        }
        private void FormLoad(object sender, EventArgs e)
        {
            frog.Image = global::PracticWinForms_urok_03_Task5.Properties.Resources._99px_ru_avatar_186261_zabavnaja_begushaja_ljagushka_by_scrii_2_;
            frog.Size = new Size(150,150);
            frog.AutoSize = false;
            Controls.Add(frog);
            LableCenter(frog);
        }
        private void FormMouseMove(object sender, MouseEventArgs e)        {
            if ((e.X > frog.Location.X - 50 && e.X < frog.Location.X + frog.Width + 50) && 
                (e.Y > frog.Location.Y - 50 && e.Y < frog.Location.Y + frog.Height + 50))
            {
                if (e.X > frog.Location.X - 50 && e.X < frog.Location.X)
                {
                    frog.Left += 1;//0,5
                }
                else if (e.X < frog.Location.X + frog.Width + 50 && e.X > frog.Location.X + frog.Width)
                {
                    frog.Left -= 1;
                }
                else if (e.Y > frog.Location.Y - 50 && e.Y < frog.Location.Y)
                {
                    frog.Top += 1;
                }
                else if (e.Y < frog.Location.Y + frog.Height + 50 && e.Y > frog.Location.Y + frog.Height)
                {
                    frog.Top -= 1;
                }

                if ((frog.Location.X < 0 ||
                    frog.Location.X > ClientSize.Width - frog.Width) || 
                    (frog.Location.Y < 0 ||frog.Location.Y > ClientSize.Height - frog.Height))
                {
                    LableCenter(frog);
                }
            }
        }
        void LableCenter(PictureBox lable)
        {
           frog.Left = (ClientSize.Width - frog.Size.Width) / 2;
            frog.Top = (ClientSize.Height - frog.Size.Height) / 2;
        }
    }
}
    

