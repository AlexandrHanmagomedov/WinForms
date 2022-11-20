
using System.IO;
using System;
using System.Windows.Forms;

namespace Анкета_в_файл {
    public partial class Form1 : Form {

        string surname, name, middlename, gender, dayOfBirth, familyStatus, additionalInformation;

        string file;

        public Form1 ( ) {
            InitializeComponent ( );
            CenterToScreen ( );
        }

        private void Form1_Load ( object sender, EventArgs e ) {
            DefaultTXT ( );
            NameAssemblity ( );
        }
        void Save ( ) {
            file = $"{textBox_surname.Text.ToUpper ( )}_{textBox_name.Text.ToUpper ( )}_{textBox_middlename.Text.ToUpper ( )}.txt";

            surname = textBox_surname.Text;
            name = textBox_name.Text;
            middlename = textBox_middlename.Text;
            if ( radioButton_genderMale.Checked ) {
                gender = radioButton_genderMale.Text;
            }
            else {
                gender = radioButton_genderFemale.Text;
            }
            dayOfBirth = dateTimePicker_dayOfBirth.Text;
            familyStatus = textBox_familyStatus.Text;
            additionalInformation = textBox_additionalInformation.Text;
        }

        void WritingToFile ( ) {
            using ( StreamWriter sw = new StreamWriter ( file ) ) {
                sw.WriteLine ( surname );
                sw.WriteLine ( name );
                sw.WriteLine ( middlename );
                sw.WriteLine ( gender );
                sw.WriteLine ( dayOfBirth );
                sw.WriteLine ( familyStatus );
                sw.WriteLine ( additionalInformation );
            }
        }

        bool IsCorrect ( ) {
            if ( surname != "" || name != "" || middlename != "" ) {
                return true;
            }
            return false;
        }

        private void button_save_Click ( object sender, EventArgs e ) {
            Save ( );
            if ( IsCorrect ( ) ) {
                WritingToFile ( );
                MessageBox.Show ( "Data recorded", "Successful entry", MessageBoxButtons.OK, MessageBoxIcon.Information );
                DefaultTXT ( );
                NameAssemblity ( );
            }
            else {
                MessageBox.Show ( "Not enough data", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning );
            }
        }

        void DefaultTXT ( ) {
            surname = "";
            name = "";
            middlename = "";
            gender = radioButton_genderMale.Text;
            familyStatus = "";
            additionalInformation = "";
            dayOfBirth = DateTime.Now.ToString ( );
            file = "";
        }

        void NameAssemblity ( ) {
            textBox_surname.Text = surname;
            textBox_name.Text = name;
            textBox_middlename.Text = middlename;
            radioButton_genderMale.Checked = true;
            dateTimePicker_dayOfBirth.Value = DateTime.Today;
            textBox_familyStatus.Text = familyStatus;
            textBox_additionalInformation.Text = additionalInformation;
        }

    }
}
