using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace PracticWinForms_urok_04_Task1 {
    public partial class Form1 : Form {

        private OpenFileDialog open = new OpenFileDialog {
            //Создали экземпляр. Установим фильтр для файлов
            Filter = "txt files (*.txt)|*.txt",
            FilterIndex = 1, //по умолчанию фильтруются текстовые файлы
            InitialDirectory = Environment.GetFolderPath ( Environment.SpecialFolder.Desktop ) //По-умолчанию. Пусть к рабочему столу
        };

        public Form1 ( ) {

            InitializeComponent ( );
            CenterToScreen ( );
        }


        private void Open_Click ( object sender, EventArgs e ) {
            richTextBox1.Clear ( );
            if ( open.ShowDialog ( ) == DialogResult.OK ) {
                using ( StreamReader reader = File.OpenText ( open.FileName ) ) {
                    richTextBox1.Text = reader.ReadToEnd ( ); //Считываем файл до конца
                    if ( richTextBox1.Text.Length > 0 )
                        this.Text = open.FileName;
                }
            }
        }

        private void Save_Click ( object sender, EventArgs e ) {
            using ( StreamWriter writer = new StreamWriter ( open.FileName ) ) {
                //Записываем в файл содержимое поля
                writer.Write ( richTextBox1.Text );
            }
        }

        private void SaveAs_Click ( object sender, EventArgs e ) {
            SaveFileDialog saveFileDialog = new SaveFileDialog ( );
            saveFileDialog.Filter = "txt files (*.txt)|*.txt";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;
            if ( saveFileDialog.ShowDialog ( ) == DialogResult.OK ) {
                using ( StreamWriter writer = new StreamWriter ( saveFileDialog.FileName ) ) {
                    writer.Write ( richTextBox1.Text );
                    open.FileName = saveFileDialog.FileName;
                    this.Text = open.FileName;
                 
                }
            }
        }

        private void NewDocument_Click ( object sender, EventArgs e ) {
            SaveFileDialog saveFileDialog = new SaveFileDialog ( );
            saveFileDialog.Filter = "txt files (*.txt)|*.txt";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;
            if ( saveFileDialog.ShowDialog ( ) == DialogResult.OK ) {
                open.FileName = saveFileDialog.FileName;
                using ( StreamWriter writer = new StreamWriter ( open.FileName ) ) {
                   
                    writer.Write ( richTextBox1.Text );
                }
                this.Text = open.FileName;
                
            }
        }

        private void Copy_Click ( object sender, EventArgs e ) {
            //Ensure that text is selected in the text box.    
            if ( richTextBox1.SelectionLength > 0 )
                //Copy the selected text to the Clipboard
                richTextBox1.Copy ( );
        }

        private void Cut_Click ( object sender, EventArgs e ) {
            //Ensure that text is currently selected in the text box
            if ( richTextBox1.SelectedText != "" )
                //Cut the selected text in the control and paste it into the Clipboard
               richTextBox1.Cut ( );
        }

        private void Insert_Click ( object sender, EventArgs e ) {
            //Determine if there is any text in the Clipboard to paste into the text box.
            if ( Clipboard.GetDataObject ( ).GetDataPresent ( DataFormats.Text ) == true ) {
                //Ask user if they want to paste over currently selected text.
                if ( MessageBox.Show ( "Do you want to paste over current selection?", "Cut Example", 
                    MessageBoxButtons.YesNo ) == DialogResult.No ) {
                    //Move selection to the point after the current selection and paste
                    richTextBox1.SelectionStart = richTextBox1.SelectionStart + richTextBox1.SelectionLength;
                }
                //Paste current text in Clipboard into the text box.
                richTextBox1.Paste ( );
            }
        }

        private void Cancel_Click ( object sender, EventArgs e ) {
            //Determine if last operation can be undone in the text box.
            if ( richTextBox1.CanUndo == true ) {
                //Undo the last operation
                richTextBox1.Undo ( );
                //Clear the undo buffer to prevent last action from being redone
                richTextBox1.ClearUndo ( );
            }
        }

        private void FontColor_Click ( object sender, EventArgs e ) {
            FontDialog fontDialog = new FontDialog ( );
            fontDialog.ShowColor = true;
            fontDialog.Font = richTextBox1.Font;
            fontDialog.Color = richTextBox1.ForeColor;
            if ( fontDialog.ShowDialog ( ) != DialogResult.Cancel ) {
                richTextBox1.Font = fontDialog.Font;
                richTextBox1.ForeColor = fontDialog.Color;
            }
        }

        private void BackgroundColor_Click ( object sender, EventArgs e ) {
            ColorDialog colorDialog = new ColorDialog ( );
            colorDialog.Color = richTextBox1.BackColor;
            if ( colorDialog.ShowDialog ( ) == DialogResult.OK )
                richTextBox1.BackColor = colorDialog.Color;
        }

        private void SelectAll_Click ( object sender, EventArgs e ) => richTextBox1.SelectAll ( );

        private void Close_click( object sender, EventArgs e ) => Close ( );
        
    }
}
