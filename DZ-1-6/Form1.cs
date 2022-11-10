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



namespace DZ_1_6 {
    public partial class Form1 : Form {
        public Form1 ( ) {
            InitializeComponent ( );
            btnOk.Click += OkClick;

        }

        private void OkClick ( object sender, EventArgs e ) {
            if ( inputTextBox.Text == "" ) {
                resultTextBox.Text = dateTimePicker.Value.Date.ToString ( "dddd" ).ToUpper ( );//ru
                inputTextBox.Text = dateTimePicker.Value.ToShortDateString ( );
            }
            else {
                try {
                    DateTime day = new DateTime ( );
                    day = DateTime.Parse ( inputTextBox.Text );
                    resultTextBox.Text = day.ToString ( "dddd" ).ToUpper ( );
                    dateTimePicker.Value = day;
                }
                catch ( Exception ) {
                    
                }
            }
        }
    }
}
