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
    public partial class Form2 : Form {

        public string getText {
            get {
                return this.textBox1.Text;
            }
        }

        public Form2 ( ) {
            InitializeComponent ( );
        }        

        private void Cancel_Click ( object sender, EventArgs e ) {
            this.DialogResult=DialogResult.Cancel;
            this.Close ( );
        }

        private void OK_Click ( object sender, EventArgs e ) {
            this.DialogResult=DialogResult.OK;
            this.Close();
        }


    }
}
