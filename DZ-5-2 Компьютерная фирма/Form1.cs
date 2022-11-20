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
    public partial class Form1 : Form {
        public Form1 ( ) {
            InitializeComponent ( );
            
        }
        private void RefreshProduct ( ) {
            if ( DataBaseProduct.products.Count > 0 ) {
                comboBoxListProducts.Items.Clear ( );
                for ( int i = 0; i < DataBaseProduct.products.Count; i++ )
                    comboBoxListProducts.Items.Add ( DataBaseProduct.products[i].NameProduct );
                comboBoxListProducts.SelectedIndex = 0;
            }
        }

        private void ButtonAddProduct_Click ( object sender, EventArgs e ) {
            Form2 formProduct = new Form2 ( );
            formProduct.Tag = "Add";
            if ( formProduct.ShowDialog ( ) == DialogResult.OK ) {
                RefreshProduct ( );
            }
        }

        private void ButtonSellProducts_Click ( object sender, EventArgs e ) {
            double total = double.Parse ( TextBoxTotalSum.Text );
            total += Math.Round ( double.Parse ( TextBoxPrice.Text ) * double.Parse ( TextBoxCount.Text ), 2 );
            TextBoxTotalSum.Text = total.ToString ( );
            ListBoxSales.Items.Add ( comboBoxListProducts.Text );

        }

        private void ButtonEditProducts_Click ( object sender, EventArgs e ) {
            Form2 formProduct = new Form2 ( comboBoxListProducts.Text );
            formProduct.Tag = "Edit";
            if ( formProduct.ShowDialog ( ) == DialogResult.OK ) {
                RefreshProduct ( );
            }
        }

        private void TextBoxCount_KeyPress ( object sender, KeyPressEventArgs e ) => e.Handled = ( ( e.KeyChar >= '0' && e.KeyChar <= '9' ) || e.KeyChar == ( char ) Keys.Back ) ? false : true;

        private void comboBoxListProducts_SelectedIndexChanged ( object sender, EventArgs e ) {
            if ( DataBaseProduct.FindProduct ( comboBoxListProducts.Text, out int index ) == true ) {
                TextBoxPrice.Text = DataBaseProduct.products[index].Price.ToString ( );
                TextBoxDescription.Text = DataBaseProduct.products[index].Description;
            }

            ButtonEditProducts.Enabled = comboBoxListProducts.Text.Length > 0;
            ButtonSellProducts.Enabled = comboBoxListProducts.Text.Length > 0 && TextBoxCount.TextLength > 0;
        }

        private void TextBoxCount_TextChanged ( object sender, EventArgs e ) {
            ButtonSellProducts.Enabled = comboBoxListProducts.Text.Length > 0 && TextBoxCount.TextLength > 0;
        }
    }

    public class Products {
        public string NameProduct { get; set; }
        public string Characteristic { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

        public Products ( string nameProduct, string characteristic, string description, double price ) {
            this.NameProduct = nameProduct;
            this.Characteristic = characteristic;
            this.Description = description;
            this.Price = price;
        }

    }
    public static class DataBaseProduct {
        public static List<Products> products = new List<Products> ( );

        public static void AddProduct ( string nameProduct, string characteristic, string description, double price, out string info ) {
            info = "";
            if ( FindProduct ( nameProduct, out int index ) == true )
                info = "A product with this name already exists";
            else
                products.Add ( new Products ( nameProduct, characteristic, description, price ) );
        }

        public static void UpdateProduct ( string nameProduct, string newNameProduct, string newCharacteristic, string newDescription, double newPrice, out string info ) {
            info = "";
            if ( FindProduct ( newNameProduct, out int findProductIndex ) == true
                && ( nameProduct != newNameProduct ) ) {
                info = "A product with this name already exists";
            }
            else {
                if ( FindProduct ( nameProduct, out int index ) == true ) {
                    products[index].NameProduct = newNameProduct;
                    products[index].Characteristic = newCharacteristic;
                    products[index].Description = newDescription;
                    products[index].Price = newPrice;
                }
            }
        }

        public static bool FindProduct ( string nameProduct, out int indexProduct ) {
            indexProduct = 0;
            for ( int i = 0; i < products.Count; i++ ) {
                if ( products[i].NameProduct == nameProduct ) {
                    indexProduct = i;
                    return true;
                }
            }
            return false;
        }

    }
}

