using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace Динамическое_добавление_меню_подменю {
    public partial class Form1 : Form {

        private readonly MenuStrip topMenu = new MenuStrip ( );
        public Form1 ( ) {
            InitializeComponent ( );
            CenterToScreen ( );
            this.MainMenuStrip = topMenu;
            this.Controls.Add ( topMenu );
        }

        private void TopLevelMenu_TextChanged ( object sender, EventArgs e ) {
            ButtonAdMenu.Enabled = TopLevelMenu.Text.Length > 0;
            ButtonAdSubMenu.Enabled = ( TopLevelMenu.Text.Length > 0 && SubItem.Text.Length > 0 );
        }

        private void ButtonAddMenu_Click ( object sender, EventArgs e ) {
            if ( CheckTopLevelMenu ( TopLevelMenu.Text, out int index ) == false ) {
                ToolStripMenuItem newMenu = ( ToolStripMenuItem ) topMenu.Items.Add ( TopLevelMenu.Text );
                newMenu.Click += ToolStripMenuItem_Click;
            }

            else
                MessageBox.Show ( "This menu item already exists.", "info", MessageBoxButtons.OK, MessageBoxIcon.Information );

        }

        private void ButtonAddSubMenu_Click ( object sender, EventArgs e ) {
            if ( CheckTopLevelMenu ( TopLevelMenu.Text, out int index ) == false ) {
                MessageBox.Show ( "This menu item already exists.", "info", MessageBoxButtons.OK, MessageBoxIcon.Information );
            }
            else {
                if ( CheckSubMenu ( SubItem.Text, ( ToolStripMenuItem ) topMenu.Items[index] ) == true ) {
                    MessageBox.Show ( "This submenu already exists in the menu" + TopLevelMenu.Text, "info", MessageBoxButtons.OK, MessageBoxIcon.Information );
                }
                else {
                    ToolStripMenuItem newSubMenu = ( ToolStripMenuItem ) topMenu.Items[index];
                    newSubMenu.DropDownItems.Add ( SubItem.Text );
                }
            }
        }

        private void ToolStripMenuItem_Click ( object sender, EventArgs e ) => TopLevelMenu.Text = ( sender as ToolStripMenuItem ).Text;

        private bool CheckTopLevelMenu ( string text, out int index ) 
        {
            index = -1;
            for ( int i = 0; i < topMenu.Items.Count; i++ ) {
                if ( topMenu.Items[i].Text == text ) {
                    index = i;
                    return true;
                }
            }
            return false;
        }

        private bool CheckSubMenu ( string text, ToolStripMenuItem menu ) 
        {
            for ( int i = 0; i < menu.DropDownItems.Count; i++ ) {
                if ( menu.DropDownItems[i].Text == text ) {
                    return true;
                }
            }
            return false;
        }
    }
}