namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AddButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.CopyButtot = new System.Windows.Forms.Button();
            this.listBoxInput = new System.Windows.Forms.ListBox();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.listBoxOutput = new System.Windows.Forms.ListBox();
            this.textBox = new System.Windows.Forms.TextBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.RemoveCheckListButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.GetText = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.StartProgress = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Red = new System.Windows.Forms.TrackBar();
            this.Green = new System.Windows.Forms.TrackBar();
            this.Blue = new System.Windows.Forms.TrackBar();
            this.form1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Blue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(123, 239);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(224, 239);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(75, 23);
            this.RemoveButton.TabIndex = 3;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // CopyButtot
            // 
            this.CopyButtot.Location = new System.Drawing.Point(323, 239);
            this.CopyButtot.Name = "CopyButtot";
            this.CopyButtot.Size = new System.Drawing.Size(75, 23);
            this.CopyButtot.TabIndex = 4;
            this.CopyButtot.Text = "Copy";
            this.CopyButtot.UseVisualStyleBackColor = true;
            this.CopyButtot.Click += new System.EventHandler(this.CopyButtot_Click);
            // 
            // listBoxInput
            // 
            this.listBoxInput.FormattingEnabled = true;
            this.listBoxInput.HorizontalScrollbar = true;
            this.listBoxInput.Location = new System.Drawing.Point(123, 53);
            this.listBoxInput.Name = "listBoxInput";
            this.listBoxInput.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxInput.Size = new System.Drawing.Size(120, 95);
            this.listBoxInput.TabIndex = 5;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(754, -1);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(29, 577);
            this.vScrollBar1.TabIndex = 14;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            // 
            // listBoxOutput
            // 
            this.listBoxOutput.FormattingEnabled = true;
            this.listBoxOutput.Location = new System.Drawing.Point(278, 53);
            this.listBoxOutput.Name = "listBoxOutput";
            this.listBoxOutput.Size = new System.Drawing.Size(120, 95);
            this.listBoxOutput.TabIndex = 6;
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(124, 181);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(274, 20);
            this.textBox.TabIndex = 7;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.ColumnWidth = 50;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(440, 53);
            this.checkedListBox1.MultiColumn = true;
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkedListBox1.Size = new System.Drawing.Size(252, 94);
            this.checkedListBox1.TabIndex = 8;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // RemoveCheckListButton
            // 
            this.RemoveCheckListButton.Location = new System.Drawing.Point(459, 178);
            this.RemoveCheckListButton.Name = "RemoveCheckListButton";
            this.RemoveCheckListButton.Size = new System.Drawing.Size(75, 23);
            this.RemoveCheckListButton.TabIndex = 9;
            this.RemoveCheckListButton.Text = "RemoveCheckList";
            this.RemoveCheckListButton.UseVisualStyleBackColor = true;
            this.RemoveCheckListButton.Click += new System.EventHandler(this.RemoveCheckListButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "zzzzzzzzzzzzzzz",
            "zxczxczxczxc",
            "222",
            "111111111111111111"});
            this.comboBox1.Location = new System.Drawing.Point(440, 239);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(233, 21);
            this.comboBox1.TabIndex = 10;
            // 
            // GetText
            // 
            this.GetText.Location = new System.Drawing.Point(473, 266);
            this.GetText.Name = "GetText";
            this.GetText.Size = new System.Drawing.Size(75, 23);
            this.GetText.TabIndex = 11;
            this.GetText.Text = "GetText";
            this.GetText.UseVisualStyleBackColor = true;
            this.GetText.Click += new System.EventHandler(this.GetText_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(31, 318);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(250, 23);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 12;
            // 
            // StartProgress
            // 
            this.StartProgress.Location = new System.Drawing.Point(114, 362);
            this.StartProgress.Name = "StartProgress";
            this.StartProgress.Size = new System.Drawing.Size(75, 23);
            this.StartProgress.TabIndex = 13;
            this.StartProgress.Text = "StartProgress";
            this.StartProgress.UseVisualStyleBackColor = true;
            this.StartProgress.Click += new System.EventHandler(this.StartProgress_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 553);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(783, 22);
            this.statusStrip1.TabIndex = 15;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Red
            // 
            this.Red.BackColor = System.Drawing.Color.Red;
            this.Red.Location = new System.Drawing.Point(323, 377);
            this.Red.Maximum = 255;
            this.Red.Name = "Red";
            this.Red.Size = new System.Drawing.Size(104, 45);
            this.Red.TabIndex = 16;
            this.Red.Value = 150;
            this.Red.Scroll += new System.EventHandler(this.Red_Scroll);
            // 
            // Green
            // 
            this.Green.BackColor = System.Drawing.Color.Green;
            this.Green.Location = new System.Drawing.Point(323, 428);
            this.Green.Maximum = 255;
            this.Green.Name = "Green";
            this.Green.Size = new System.Drawing.Size(104, 45);
            this.Green.TabIndex = 17;
            this.Green.Value = 150;
            this.Green.Scroll += new System.EventHandler(this.Green_Scroll);
            // 
            // Blue
            // 
            this.Blue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Blue.Location = new System.Drawing.Point(323, 479);
            this.Blue.Maximum = 255;
            this.Blue.Name = "Blue";
            this.Blue.Size = new System.Drawing.Size(104, 45);
            this.Blue.TabIndex = 18;
            this.Blue.Value = 150;
            this.Blue.Scroll += new System.EventHandler(this.Blue_Scroll);
            // 
            // form1BindingSource
            // 
            this.form1BindingSource.DataSource = typeof(WindowsFormsApp2.Form1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 575);
            this.Controls.Add(this.Blue);
            this.Controls.Add(this.Green);
            this.Controls.Add(this.Red);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.StartProgress);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.GetText);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.RemoveCheckListButton);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.listBoxOutput);
            this.Controls.Add(this.listBoxInput);
            this.Controls.Add(this.CopyButtot);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.AddButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Blue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button CopyButtot;
        private System.Windows.Forms.ListBox listBoxInput;
        private System.Windows.Forms.ListBox listBoxOutput;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button RemoveCheckListButton;
        private System.Windows.Forms.BindingSource form1BindingSource;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button GetText;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button StartProgress;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TrackBar Red;
        private System.Windows.Forms.TrackBar Green;
        private System.Windows.Forms.TrackBar Blue;
    }
}

