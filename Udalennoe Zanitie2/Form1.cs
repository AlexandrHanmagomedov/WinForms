using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Udalennoe_Zanitie2 {
    public partial class Form1 : Form {
        public Form1 ( ) {
            InitializeComponent ( );
        }

        private void Load_Click ( object sender, EventArgs e ) {
            OpenFileDialog open = new OpenFileDialog ( );
            //// создали экземпляр установим фильтр для файлов
            open.Filter = "All Files(*.*)|*.*|Text Files\r\n( *.txt )|*.txt"; 
            open.FilterIndex = 1;// по умолчанию фильтруются текстовые файлы
            if ( open.ShowDialog ( ) == DialogResult.OK ) {
                StreamReader reader = File.OpenText ( open.FileName );
                textBox1.Text = reader.ReadToEnd ( );// считываем файл до конца 
                reader.Close ( ); // закрываем reader
            }
        }

        private void Save_Click ( object sender, EventArgs e ) {
            SaveFileDialog save = new SaveFileDialog ( );
            // создали экземпляр
            if ( save.ShowDialog ( ) == DialogResult.OK ) {
                StreamWriter writer = new StreamWriter ( save.FileName );
                // записываем в файл содержимое поля
                writer.Write ( textBox1.Text );
                writer.Close ( );
                // закрываем writer
            }
        }
    }
}
