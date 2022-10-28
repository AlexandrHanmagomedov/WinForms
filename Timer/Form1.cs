using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class Form1 : Form
    {
        System.Windows.Forms.Timer timer;//потому что сам проект называется Timer
        System.Windows.Forms.Timer timerUpdate;
        public Form1()
        {
            timer = new System.Windows.Forms.Timer();
            timerUpdate = new System.Windows.Forms.Timer();

            timer.Tick += new EventHandler(ShowTimer);

            timerUpdate.Tick += new EventHandler(UpdateValueTimer);
            timerUpdate.Interval = 1000;
            timerUpdate.Enabled = false;

            timer.Enabled = false;
            InitializeComponent();
            button2.Enabled = false;
        }

        private void UpdateValueTimer(object vObject, EventArgs e)
        {
            if (numericUpDown1.Value - 1 >= numericUpDown1.Minimum)
            {
                var value = numericUpDown1.Value--;
            }
            
          
        }
        private void ShowTimer(object vObject,EventArgs e)
        {
            //останавливаем таймер
            timer.Stop();
            button2.Enabled = false;
            MessageBox.Show("Таймер отработал", "Таймер");
            button1.Enabled = true;
            stopUpdateTimer();
        }
        private void stop_Click(object sender, EventArgs e)
        {
            timer?.Stop();
            button2.Enabled = false;
            button1.Enabled = true;
            stopUpdateTimer();
            MessageBox.Show("Кнопка \"Стоп\" нажата раньше завершения работы таймера","Таймер");
        }

        private void start_Click(object sender, EventArgs e)
        {
            try
            {
                timer.Interval = (int)numericUpDown1.Value * 1000;
                this.Enabled = true;
                timer.Start();
                button2.Enabled = true;
                button1.Enabled = false;
                timerUpdate.Enabled=true;
                timer.Start();
            }
            catch
            {
                MessageBox.Show("Время не должно быть 0", "Таймер");

            }
            
        }
        private void stopUpdateTimer()
        {
            timerUpdate.Enabled = false;
            timerUpdate.Stop();
        }
    }
}
