using System;
using System.Drawing;
using System.Windows.Forms;
using Timer = System.Timers.Timer;

namespace WindowsFormsApp4
{
    
    public partial class Form1 : Form
    {
        private Player player;
        private Eat eat;
        int score;
        Timer timer;
        public Form1()        {
            InitializeComponent();
            CenterToScreen();
            KeyDown += new KeyEventHandler(press);
            eat = new Eat(new Point(10, 10));
            player = new Player(new Point(this.Width / 2, this.Height / 2));
            FormClosing += new FormClosingEventHandler(close);
            timer =new Timer(1);
            timer.Elapsed += OnTimedEvent;
            timer.AutoReset = true;
            timer.Enabled = true;
           
        }      
       

        private void OnTimedEvent(object sender, System.Timers.ElapsedEventArgs e)
        {
            updateGame();
        }

        public void close(object sender, FormClosingEventArgs args)
        {
            player.stop();
            timer.Stop();
            timer.Dispose();
        }

        public void press(object sender, KeyEventArgs key)
        {
            if (player.currenntDirection() == Direction.Stop&&!player.isRunning)
            {
                player.setDirection(key.KeyCode);
                player.start();
            }
            else
            {
                player.setDirection(key.KeyCode);
            }            
        }

        private void updateGame()
        {
            Graphics graphics = CreateGraphics();
            graphics.Clear(BackColor);
            eat.paint(graphics);
            player.paint(graphics);



        }
        protected override void OnPaint(PaintEventArgs e)
        {             
            eat.paint(CreateGraphics());
            player.paint(CreateGraphics());   
            
            
        }
    }
}
