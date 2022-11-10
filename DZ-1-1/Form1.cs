using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DZ_1_1 {
    public partial class Form1 : Form {

        public Form1 ( ) {
            InitializeComponent ( );
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
            this.Shown += ShowMessageBox;

        }
        private void ShowMessageBox ( object sender, EventArgs e ) {
            string first = "Студент Ханмагомедов Александр Зияутдинович";
            string second = "Основы разработки приложений с использованием\nWindows Forms";
            string third = "Группа:Группа: ПВ111 ";

            MessageBox.Show ( first, "Box1" );
            MessageBox.Show ( second, "Box2" );
            MessageBox.Show ( third, String.Format ( "Box3 Среднее количество символов: {0}", ( first.Length + second.Length + third.Length ) / 3 ) );

            this.Close ( );
        }

    }
}

