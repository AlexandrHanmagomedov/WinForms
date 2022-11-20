using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Компьютерная_фирма {
    public partial class Form2 : Form {
        private string nameProduct;
        public Form2 ( ) {
            InitializeComponent ( );
        }
        public Form2 ( string nameProduct ) {
            InitializeComponent ( );
            this.nameProduct = nameProduct;
            
        }

        private void FormProduct_Load ( object sender, EventArgs e ) {
            if ( this.Tag.ToString ( ) == "Add" ) {
                this.Text = "Add ";
            }
            else {
                this.Text = "Change";
                if ( DataBaseProduct.FindProduct ( nameProduct, out int index ) == true ) {
                    TextBoxNameProduct.Text = DataBaseProduct.products[index].NameProduct;
                    TextBoxDescription.Text = DataBaseProduct.products[index].Description;
                    TextBoxCharacteristic.Text = DataBaseProduct.products[index].Characteristic;
                    TextBoxPrice.Text = DataBaseProduct.products[index].Price.ToString ( );
                }
            }

        }

        private void ButtonSaveProduct_Click ( object sender, EventArgs e ) {
            try {
                if ( this.Tag.ToString ( ) == "Add" ) {
                    DataBaseProduct.AddProduct ( TextBoxNameProduct.Text, TextBoxCharacteristic.Text, 
                        TextBoxDescription.Text, double.Parse ( TextBoxPrice.Text ), out string infoAdd );
                    if ( infoAdd.Length == 0 )
                        this.DialogResult = DialogResult.OK;
                    else
                        MessageBox.Show ( infoAdd, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information );
                }
                else {
                    DataBaseProduct.UpdateProduct ( nameProduct, TextBoxNameProduct.Text, TextBoxCharacteristic.Text, 
                        TextBoxDescription.Text, double.Parse ( TextBoxPrice.Text ), out string infoEdit );
                    if ( infoEdit.Length == 0 )
                        this.DialogResult = DialogResult.OK;
                    else
                        MessageBox.Show ( infoEdit, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information );
                }
            }
            catch ( Exception ex ) {
                MessageBox.Show ( ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
        }

        private void TextBoxName_TextChanged ( object sender, EventArgs e ) => 
            ButtonSaveProduct.Enabled = ( TextBoxNameProduct.TextLength > 0 && TextBoxCharacteristic.TextLength > 0 
            && TextBoxDescription.TextLength > 0 && TextBoxPrice.TextLength > 0 );

        private void TextBoxPrice_KeyPress ( object sender, KeyPressEventArgs e ) => 
            e.Handled = ( ( e.KeyChar >= '0' && e.KeyChar <= '9' ) || e.KeyChar == System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator[0] 
            || e.KeyChar == ( char ) Keys.Back ) ? false : true;
    }
}

