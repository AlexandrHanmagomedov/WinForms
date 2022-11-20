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

namespace загрузить_файл_и_редактировать {
    public partial class Form2 : Form {

        private string fileName = "";
        public Form2 ( ) {
            InitializeComponent ( );         
        }
        public Form2 ( string fileName, string textData ) {
            this.fileName = fileName;
            InitializeComponent ( );
            CenterToScreen ( );
            TextBoxEditTextFile.Text = textData;
        }

        private void ButtonSaveTextFile_Click ( object sender, EventArgs e ) {
            StreamWriter writer = new StreamWriter ( fileName );
            
            writer.Write ( TextBoxEditTextFile.Text );
            writer.Close ( );
            this.DialogResult = DialogResult.OK;
            
            this.Close ( );
        }

        private void ButtonCancel_Click ( object sender, EventArgs e ) => 
            this.Close ( );

    }
    
}
