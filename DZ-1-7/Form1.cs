using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DZ_1_7 {
    public partial class Form1 : Form {
        public Form1 ( ) {
            InitializeComponent ( );
        }

        private void button1_Click ( object sender, EventArgs e ) {
            try {
                DateTime dayT = new DateTime ( );
                dayT = DateTime.Parse ( textBox1.Text );
                DateTime dayNow = DateTime.Now;
                TimeSpan tempDay = dayT - dayNow;
                if ( dayT > dayNow ) {
                    if ( radioButton1.Checked ) {
                        result.Text = ( tempDay.TotalDays / 365 ).ToString ( );
                    }
                    if ( radioButton2.Checked ) {
                        result.Text = ( tempDay.TotalDays / 30 ).ToString ( );
                    }
                    if ( radioButton3.Checked ) {
                        result.Text = ( ( int ) tempDay.TotalDays ).ToString ( );
                    }
                    if ( radioButton4.Checked ) {
                        result.Text = ( ( int ) tempDay.TotalMinutes ).ToString ( );
                    }
                    if ( radioButton5.Checked ) {
                        result.Text = ( ( int ) tempDay.TotalSeconds ).ToString ( );
                    }
                }
                else {
                    result.Text = "Эта дата уже прошла!";
                }
            }
            catch ( Exception ) {

            }

        }

        private void textBox1_TextChanged ( object sender, EventArgs e ) {

        }

        private void result_TextChanged ( object sender, EventArgs e ) {

        }
    }
}
