using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Application;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Udalennoe_zadanie3 {
    public partial class Form1 : Form {
        public Form1 ( ) {
            InitializeComponent ( );
        }

        private void save_Click ( object sender, EventArgs e ) {
            SaveFileDialog save = new SaveFileDialog ( );
            // создали экземпляр
            if ( save.ShowDialog ( ) == DialogResult.OK ) {
                StreamWriter writer =
                new StreamWriter ( save.FileName );
                // записываем в файл содержимое поля
                writer.Write ( textBox1.Text );
                writer.Close ( );
                // закрываем writer
            }
        }

        private void load_Click ( object sender, EventArgs e ) {
            loadFile ( );
        }


        private void toolStripMenuItem2_Click ( object sender, EventArgs e ) {
            ToolStripMenuItem item = ( ToolStripMenuItem ) sender;
            if ( item.Checked ) {
                this.BackColor = Color.Red;
            }
            else {
                this.BackColor = Color.White;
            }

        }

        private void toolStripMenuItem1_Click ( object sender, EventArgs e ) {

        }

        private void LoadMenuItem3_Click ( object sender, EventArgs e ) {
            loadFile ( );
        }

        private void loadFile ( ) {
            OpenFileDialog open = new OpenFileDialog ( );

            open.Filter = "\"All Files(*.*)|*.*|Text Files\r\n (*.txt)|*.txt";
            open.FilterIndex = 1;// по умолчанию фильтруются
                                 // текстовые файлы
            if ( open.ShowDialog ( ) == DialogResult.OK ) {
                StreamReader reader =
                File.OpenText ( open.FileName );
                textBox1.Text = reader.ReadToEnd ( ); //
                                                      // считываем файл до конца
                reader.Close ( ); // закрываем reader
            }
        }

        private void menuStrip1_ItemClicked ( object sender, ToolStripItemClickedEventArgs e ) {

        }
    }
}






