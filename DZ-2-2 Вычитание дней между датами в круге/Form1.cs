using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Вычитание_дней_между_датами_в_круге {
    public partial class Form1 : Form {
        Point moveStart;
        TimeSpan timeSpan;

        public Form1 ( ) {
            InitializeComponent ( );
            CenterToScreen ( );

        }

        private void button_close_Click ( object sender, EventArgs e ) {
            Close ( );
        }

        private void Form1_Load ( object sender, EventArgs e ) {
            GraphicsPath myPath = new GraphicsPath ( );
            myPath.AddEllipse ( 0, 0, Width, Height );
            Region myRegion = new Region ( myPath );
            Region = myRegion;
            timeSpan = new TimeSpan ( );
            label_result.Visible = false;
        }

        private void Form1_MouseDown ( object sender, MouseEventArgs e ) {
            if ( e.Button == MouseButtons.Left ) {
                moveStart = new Point ( e.X, e.Y );
            }
        }

        private void Form1_MouseMove ( object sender, MouseEventArgs e ) {
            if ( ( e.Button & MouseButtons.Left ) != 0 ) {
                Point deltaPos = new Point ( e.X - moveStart.X, e.Y - moveStart.Y );
                Location = new Point ( Location.X + deltaPos.X, Location.Y + deltaPos.Y );
            }
        }

        void TimeSpanDay ( ) {
            DateTime date1 = dateTimePicker1.Value;
            DateTime date2 = dateTimePicker2.Value;
            DateTime min, max;
            min = ( date1 < date2 ) ? date1 : date2;
            max = ( date1 > date2 ) ? date1 : date2;
            timeSpan = max.Subtract ( min );
            label_result.Text = $"{timeSpan.Days} days";
            label_result.Visible = true;
        }

        private void dateTimePicker2_ValueChanged ( object sender, EventArgs e ) {
            TimeSpanDay ( );
        }

        private void dateTimePicker1_ValueChanged ( object sender, EventArgs e ) {
            TimeSpanDay ( );
        }
    }
}

