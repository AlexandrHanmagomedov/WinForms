using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DZ_1_2 {
    public partial class Form1 : Form {
        public Form1 ( ) {
            InitializeComponent ( );
            CenterToScreen ( );
        }
        public static int RandomNumber ( ) { 
            return new Random ( ).Next ( 1, 2001 ); 
        }
        private void start_Click ( object sender, EventArgs e ) {
            for ( int i = 1; ; i++ ) {
                var answer = MessageBox.Show ( $"Вы загадали число : {RandomNumber ( )} ?", "Guess Number", MessageBoxButtons.YesNo );
                if ( answer == DialogResult.Yes ) {
                    var newGame = MessageBox.Show ( $"Количество попыток: {i}. Сыграть снова?", "Guess Number", MessageBoxButtons.YesNo );
                    if ( newGame == DialogResult.Yes ) { 
                        break;
                    }
                    if ( newGame == DialogResult.No ) {
                        this.Close ();
                    }
                    else { 
                        i = 0; 
                    }
                }
            }
        } 
    }
}

