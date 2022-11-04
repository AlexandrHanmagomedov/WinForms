using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Udalenoe_zanitie {
    public partial class Form1 : Form {
        public Form1 ( ) {
            InitializeComponent ( );
        }

        private void Remove_Click ( object sender, EventArgs e ) {

            //listBox1.Items.RemoveAt ( listBox1.SelectedIndex );
                while ( listBox1.SelectedItems.Count > 0 ) {
                   listBox1.Items.Remove(listBox1.SelectedItems[0]);
                }
        }

        private void Add_Click ( object sender, EventArgs e ) {
            Form2 form2 = new Form2 ( );
            if ( form2.ShowDialog ( ) == DialogResult.OK ) {
                this.listBox1.Items.Add ( form2.getText );
            }
        }

        private void Delete_Click ( object sender, EventArgs e ) {
            this.listBox1.Items.Clear ( );
        }
    }
}
