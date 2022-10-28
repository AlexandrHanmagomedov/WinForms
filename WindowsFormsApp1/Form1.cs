using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()        {
            
            InitializeComponent();
            //MouseDown += new MouseEventHandler(ClickHandler);
        }


        public void ClickHandler(Object sender,MouseEventArgs e)
        {

            //MessageBox.Show($"MouseDown Click in x {e.X} y { e.Y} location {e.Location}");
            this.label2.Text = $"Mouse Down {DateTime.Now}(нажали кнопку мыши)";
        }

        private void MyCallback(object sender, MouseEventArgs e)
        {
            // MessageBox.Show("Mouse Up(отпустили конопку мыши)");
            this.label1.Text = $"Mouse Up {DateTime.Now}(отпустили конопку мыши)";

        }

    }
}
