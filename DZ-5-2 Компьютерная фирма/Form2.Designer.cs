﻿namespace Компьютерная_фирма {
    partial class Form2 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose ( bool disposing ) {
            if ( disposing && ( components != null ) ) {
                components.Dispose ( );
            }
            base.Dispose ( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ( ) {
            this.TextBoxNameProduct = new System.Windows.Forms.TextBox();
            this.LabelNameProducts = new System.Windows.Forms.Label();
            this.LabelCharacteristic = new System.Windows.Forms.Label();
            this.TextBoxCharacteristic = new System.Windows.Forms.TextBox();
            this.TextBoxDescription = new System.Windows.Forms.TextBox();
            this.LabelDescription = new System.Windows.Forms.Label();
            this.LabelPrice = new System.Windows.Forms.Label();
            this.TextBoxPrice = new System.Windows.Forms.TextBox();
            this.ButtonSaveProduct = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextBoxNameProduct
            // 
            this.TextBoxNameProduct.Location = new System.Drawing.Point(91, 33);
            this.TextBoxNameProduct.Name = "TextBoxNameProduct";
            this.TextBoxNameProduct.Size = new System.Drawing.Size(170, 20);
            this.TextBoxNameProduct.TabIndex = 0;
            this.TextBoxNameProduct.TextChanged += new System.EventHandler(this.TextBoxName_TextChanged);
            // 
            // LabelNameProducts
            // 
            this.LabelNameProducts.AutoSize = true;
            this.LabelNameProducts.Location = new System.Drawing.Point(25, 36);
            this.LabelNameProducts.Name = "LabelNameProducts";
            this.LabelNameProducts.Size = new System.Drawing.Size(60, 13);
            this.LabelNameProducts.TabIndex = 1;
            this.LabelNameProducts.Text = "Product iD:";
            // 
            // LabelCharacteristic
            // 
            this.LabelCharacteristic.AutoSize = true;
            this.LabelCharacteristic.Location = new System.Drawing.Point(25, 73);
            this.LabelCharacteristic.Name = "LabelCharacteristic";
            this.LabelCharacteristic.Size = new System.Drawing.Size(76, 13);
            this.LabelCharacteristic.TabIndex = 2;
            this.LabelCharacteristic.Text = "Specifications:";
            // 
            // TextBoxCharacteristic
            // 
            this.TextBoxCharacteristic.Location = new System.Drawing.Point(107, 70);
            this.TextBoxCharacteristic.Name = "TextBoxCharacteristic";
            this.TextBoxCharacteristic.Size = new System.Drawing.Size(154, 20);
            this.TextBoxCharacteristic.TabIndex = 3;
            this.TextBoxCharacteristic.TextChanged += new System.EventHandler(this.TextBoxName_TextChanged);
            // 
            // TextBoxDescription
            // 
            this.TextBoxDescription.Location = new System.Drawing.Point(65, 110);
            this.TextBoxDescription.Multiline = true;
            this.TextBoxDescription.Name = "TextBoxDescription";
            this.TextBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TextBoxDescription.Size = new System.Drawing.Size(196, 59);
            this.TextBoxDescription.TabIndex = 4;
            this.TextBoxDescription.TextChanged += new System.EventHandler(this.TextBoxName_TextChanged);
            // 
            // LabelDescription
            // 
            this.LabelDescription.AutoSize = true;
            this.LabelDescription.Location = new System.Drawing.Point(31, 113);
            this.LabelDescription.Name = "LabelDescription";
            this.LabelDescription.Size = new System.Drawing.Size(28, 13);
            this.LabelDescription.TabIndex = 5;
            this.LabelDescription.Text = "Info:";
            // 
            // LabelPrice
            // 
            this.LabelPrice.AutoSize = true;
            this.LabelPrice.Location = new System.Drawing.Point(25, 180);
            this.LabelPrice.Name = "LabelPrice";
            this.LabelPrice.Size = new System.Drawing.Size(34, 13);
            this.LabelPrice.TabIndex = 6;
            this.LabelPrice.Text = "Price:";
            // 
            // TextBoxPrice
            // 
            this.TextBoxPrice.Location = new System.Drawing.Point(65, 177);
            this.TextBoxPrice.Name = "TextBoxPrice";
            this.TextBoxPrice.Size = new System.Drawing.Size(196, 20);
            this.TextBoxPrice.TabIndex = 7;
            this.TextBoxPrice.TextChanged += new System.EventHandler(this.TextBoxName_TextChanged);
            this.TextBoxPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxPrice_KeyPress);
            // 
            // ButtonSaveProduct
            // 
            this.ButtonSaveProduct.Enabled = false;
            this.ButtonSaveProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonSaveProduct.Location = new System.Drawing.Point(12, 203);
            this.ButtonSaveProduct.Name = "ButtonSaveProduct";
            this.ButtonSaveProduct.Size = new System.Drawing.Size(253, 60);
            this.ButtonSaveProduct.TabIndex = 8;
            this.ButtonSaveProduct.Text = "Save";
            this.ButtonSaveProduct.UseVisualStyleBackColor = true;
            this.ButtonSaveProduct.Click += new System.EventHandler(this.ButtonSaveProduct_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 274);
            this.Controls.Add(this.ButtonSaveProduct);
            this.Controls.Add(this.TextBoxPrice);
            this.Controls.Add(this.LabelPrice);
            this.Controls.Add(this.LabelDescription);
            this.Controls.Add(this.TextBoxDescription);
            this.Controls.Add(this.TextBoxCharacteristic);
            this.Controls.Add(this.LabelCharacteristic);
            this.Controls.Add(this.LabelNameProducts);
            this.Controls.Add(this.TextBoxNameProduct);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Info product";
            this.Load += new System.EventHandler(this.FormProduct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxNameProduct;
        private System.Windows.Forms.Label LabelNameProducts;
        private System.Windows.Forms.Label LabelCharacteristic;
        private System.Windows.Forms.TextBox TextBoxCharacteristic;
        private System.Windows.Forms.TextBox TextBoxDescription;
        private System.Windows.Forms.Label LabelDescription;
        private System.Windows.Forms.Label LabelPrice;
        private System.Windows.Forms.TextBox TextBoxPrice;
        private System.Windows.Forms.Button ButtonSaveProduct;
    }
}