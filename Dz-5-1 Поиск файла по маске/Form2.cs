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

namespace Поиск_файла_по_маске {
    public partial class Form2 : Form {
        public Form2 ( ) {
            InitializeComponent ( );
            ComboBoxSearch.SelectedIndex = 0;
        }

        private void ButtonSearch_Click ( object sender, EventArgs e ) {
            using ( var folderDialog = new FolderBrowserDialog ( ) ) {
                DialogResult result = folderDialog.ShowDialog ( );
                if ( result == DialogResult.OK && !string.IsNullOrWhiteSpace ( folderDialog.SelectedPath ) ) {
                    string[] files = Directory.GetFiles ( folderDialog.SelectedPath, ComboBoxSearch.Text );
                    if ( files.Length == 0 ) {
                        MessageBox.Show ( "Файлы не найдены", "Результат поиска", 
                            MessageBoxButtons.OK, MessageBoxIcon.Information );
                    }
                    else {
                        ListBoxFiles.Items.Clear ( );
                        for ( int i = 0; i < files.Count ( ); i++ ) {
                            ListBoxFiles.Items.Add ( files[i] );
                        }
                    }
                }
            }
        }
        private void ComboBoxSearch_TextChanged ( object sender, EventArgs e )
            => ButtonSearch.Enabled = ComboBoxSearch.Text.Length > 0;

    }
}
