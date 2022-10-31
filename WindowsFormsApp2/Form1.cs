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

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public List<string> Data = new List<string>();



        public Form1()
        {
            InitializeComponent();
            Data.Add("asfasfafafa");
            Data.Add("zzzzzzzzzzzzzzzz");
        }
        //horisontal scrollbar чтобы текст влазил 
        private void AddButton_Click(object sender, EventArgs e)        {
            string text=textBox.Text;
            listBoxInput.Items.Add(text);
            checkedListBox1.Items.Add(text);

            textBox.Clear();
        }

        private void RemoveButton_Click(object sender, EventArgs e)        {
            if (this.listBoxInput.Items.Count != 0)            {
                //есть выделенные
                if (this.listBoxInput.SelectedItems != null)                {
                    while (listBoxInput.SelectedItems.Count > 0)                    {
                        this.listBoxInput.Items.Remove(this.listBoxInput.SelectedItems[0]);
                    }
                }
            }
        }

        private void CopyButtot_Click(object sender, EventArgs e)        {
            foreach (var data in listBoxInput.SelectedItems)
            listBoxOutput.Items.Add(data);
        }

        private void RemoveCheckListButton_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GetText_Click(object sender, EventArgs e)
        {
            MessageBox.Show(comboBox1.Text);
        }

        private void StartProgress_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(progress);
            thread.Start();
        }
        private void progress()
        {
            while (progressBar1.Value < progressBar1.Maximum)
            {
                progressBar1.PerformStep();
                listBoxInput.Items.Add($"{progressBar1.Value}%");
                Thread.Sleep(50);
                this.Update();
            }
            progressBar1.Value = progressBar1.Minimum;
        }


        private void UpdateColor()
        {
            Color c = Color.FromArgb(this.Red.Value,
            this.Green.Value, this.Blue.Value);
            this.BackColor = c;
        }
        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            
        }

        private void Red_Scroll(object sender, EventArgs e)
        {
            UpdateColor();
        }

        private void Green_Scroll(object sender, EventArgs e)
        {
            UpdateColor();
        }

        private void Blue_Scroll(object sender, EventArgs e)
        {
            UpdateColor();
        }
    }

}
