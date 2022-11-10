using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DZ_1_3 {
    public partial class Form1 : Form {
        public Form1 ( ) {
            InitializeComponent ( );
            this.MouseClick += new System.Windows.Forms.MouseEventHandler ( this.MouseRectangle );
            this.MouseMove += new System.Windows.Forms.MouseEventHandler ( this.MouseCoordinates );
            CenterToScreen ( );
        }
        private void MouseRectangle ( object sender, MouseEventArgs e ) {
            int x = Size.Width - 17;
            int y = Size.Height - 40;
            if ( ModifierKeys == Keys.Control && e.Button == MouseButtons.Left ) Close ( );
            else if ( e.Button == MouseButtons.Left ) {
                if ( e.X > 10 && e.X < x - 10 && e.Y > 10 && e.Y < y - 10 ){ 
                    MessageBox.Show ( $"точка: внутри прямоугольника" ); 
                }
                else if ( e.X == 0 || e.Y == 0 || e.X == x || e.Y == y ) { 
                    MessageBox.Show ( $"точка: на границе прямоугольника" ); 
                }
                else { 
                    MessageBox.Show ( $" точка: снаружи прямоугольника" ); 
                }
            }
            else if ( e.Button == MouseButtons.Right ) MessageBox.Show ( $"размере клиентской (рабочей) области: x={x}, y={y}" );
        }
        private void MouseCoordinates ( object sender, MouseEventArgs e ) {
            this.Text = $" координаты мыши : x={e.X}, y={e.Y}";
        }
        private void Form1_Load ( object sender, EventArgs e ) {

        }
    }
}
