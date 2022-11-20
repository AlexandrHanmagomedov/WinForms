namespace Поиск_файла_по_маске {
    partial class Form1 {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose ( bool disposing ) {
            if ( disposing && ( components != null ) ) {
                components.Dispose ( );
            }
            base.Dispose ( disposing );
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent ( ) {
            this.ButtonCreateSearchForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonCreateSearchForm
            // 
            this.ButtonCreateSearchForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonCreateSearchForm.Location = new System.Drawing.Point(283, 180);
            this.ButtonCreateSearchForm.Name = "ButtonCreateSearchForm";
            this.ButtonCreateSearchForm.Size = new System.Drawing.Size(234, 90);
            this.ButtonCreateSearchForm.TabIndex = 1;
            this.ButtonCreateSearchForm.Text = "Искать";
            this.ButtonCreateSearchForm.UseVisualStyleBackColor = true;
            this.ButtonCreateSearchForm.Click += new System.EventHandler(this.ButtonCreateSearchForm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtonCreateSearchForm);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonCreateSearchForm;
    }
}

