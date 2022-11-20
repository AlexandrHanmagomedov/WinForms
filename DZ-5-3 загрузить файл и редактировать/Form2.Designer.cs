namespace загрузить_файл_и_редактировать {
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
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ButtonSaveTextFile = new System.Windows.Forms.Button();
            this.TextBoxEditTextFile = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonCancel.Location = new System.Drawing.Point(188, 355);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(153, 28);
            this.ButtonCancel.TabIndex = 5;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // ButtonSaveTextFile
            // 
            this.ButtonSaveTextFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonSaveTextFile.Location = new System.Drawing.Point(12, 353);
            this.ButtonSaveTextFile.Name = "ButtonSaveTextFile";
            this.ButtonSaveTextFile.Size = new System.Drawing.Size(154, 32);
            this.ButtonSaveTextFile.TabIndex = 4;
            this.ButtonSaveTextFile.Text = "Save";
            this.ButtonSaveTextFile.UseVisualStyleBackColor = true;
            this.ButtonSaveTextFile.Click += new System.EventHandler(this.ButtonSaveTextFile_Click);
            // 
            // TextBoxEditTextFile
            // 
            this.TextBoxEditTextFile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxEditTextFile.Location = new System.Drawing.Point(12, 12);
            this.TextBoxEditTextFile.Multiline = true;
            this.TextBoxEditTextFile.Name = "TextBoxEditTextFile";
            this.TextBoxEditTextFile.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TextBoxEditTextFile.Size = new System.Drawing.Size(323, 337);
            this.TextBoxEditTextFile.TabIndex = 3;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 388);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonSaveTextFile);
            this.Controls.Add(this.TextBoxEditTextFile);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Button ButtonSaveTextFile;
        private System.Windows.Forms.TextBox TextBoxEditTextFile;
    }
}