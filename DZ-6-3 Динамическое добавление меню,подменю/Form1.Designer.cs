namespace Динамическое_добавление_меню_подменю {
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
            this.TopLevelMenu = new System.Windows.Forms.TextBox();
            this.SubItem = new System.Windows.Forms.TextBox();
            this.ButtonAdMenu = new System.Windows.Forms.Button();
            this.ButtonAdSubMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TopLevelMenu
            // 
            this.TopLevelMenu.Location = new System.Drawing.Point(12, 71);
            this.TopLevelMenu.Name = "TopLevelMenu";
            this.TopLevelMenu.Size = new System.Drawing.Size(110, 20);
            this.TopLevelMenu.TabIndex = 1;
            this.TopLevelMenu.TextChanged += new System.EventHandler(this.TopLevelMenu_TextChanged);
            // 
            // SubItem
            // 
            this.SubItem.Location = new System.Drawing.Point(12, 139);
            this.SubItem.Name = "SubItem";
            this.SubItem.Size = new System.Drawing.Size(110, 20);
            this.SubItem.TabIndex = 2;
            this.SubItem.TextChanged += new System.EventHandler(this.TopLevelMenu_TextChanged);
            // 
            // ButtonAdMenu
            // 
            this.ButtonAdMenu.Enabled = false;
            this.ButtonAdMenu.Location = new System.Drawing.Point(12, 29);
            this.ButtonAdMenu.Name = "ButtonAdMenu";
            this.ButtonAdMenu.Size = new System.Drawing.Size(110, 36);
            this.ButtonAdMenu.TabIndex = 3;
            this.ButtonAdMenu.Text = "Add menu item";
            this.ButtonAdMenu.UseVisualStyleBackColor = true;
            this.ButtonAdMenu.Click += new System.EventHandler(this.ButtonAddMenu_Click);
            // 
            // ButtonAdSubMenu
            // 
            this.ButtonAdSubMenu.Enabled = false;
            this.ButtonAdSubMenu.Location = new System.Drawing.Point(12, 97);
            this.ButtonAdSubMenu.Name = "ButtonAdSubMenu";
            this.ButtonAdSubMenu.Size = new System.Drawing.Size(110, 36);
            this.ButtonAdSubMenu.TabIndex = 4;
            this.ButtonAdSubMenu.Text = "Add submenu item";
            this.ButtonAdSubMenu.UseVisualStyleBackColor = true;
            this.ButtonAdSubMenu.Click += new System.EventHandler(this.ButtonAddSubMenu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(139, 181);
            this.Controls.Add(this.ButtonAdSubMenu);
            this.Controls.Add(this.ButtonAdMenu);
            this.Controls.Add(this.SubItem);
            this.Controls.Add(this.TopLevelMenu);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dynamic menu addition";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TopLevelMenu;
        private System.Windows.Forms.TextBox SubItem;
        private System.Windows.Forms.Button ButtonAdMenu;
        private System.Windows.Forms.Button ButtonAdSubMenu;
    }
}

