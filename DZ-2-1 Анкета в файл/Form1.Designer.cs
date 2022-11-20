namespace Анкета_в_файл {
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
            this.label_surname = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.label_patronymic = new System.Windows.Forms.Label();
            this.label_gender = new System.Windows.Forms.Label();
            this.label_dataOfBirth = new System.Windows.Forms.Label();
            this.label_familyStatus = new System.Windows.Forms.Label();
            this.label_additionalInformation = new System.Windows.Forms.Label();
            this.button_save = new System.Windows.Forms.Button();
            this.textBox_additionalInformation = new System.Windows.Forms.TextBox();
            this.textBox_surname = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_middlename = new System.Windows.Forms.TextBox();
            this.radioButton_genderMale = new System.Windows.Forms.RadioButton();
            this.radioButton_genderFemale = new System.Windows.Forms.RadioButton();
            this.dateTimePicker_dayOfBirth = new System.Windows.Forms.DateTimePicker();
            this.textBox_familyStatus = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_surname
            // 
            this.label_surname.AutoSize = true;
            this.label_surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_surname.Location = new System.Drawing.Point(16, 90);
            this.label_surname.Margin = new System.Windows.Forms.Padding(10);
            this.label_surname.Name = "label_surname";
            this.label_surname.Size = new System.Drawing.Size(68, 16);
            this.label_surname.TabIndex = 0;
            this.label_surname.Text = "Surname";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_name.Location = new System.Drawing.Point(18, 9);
            this.label_name.Margin = new System.Windows.Forms.Padding(10);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(48, 16);
            this.label_name.TabIndex = 1;
            this.label_name.Text = "Name";
            // 
            // label_patronymic
            // 
            this.label_patronymic.AutoSize = true;
            this.label_patronymic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_patronymic.Location = new System.Drawing.Point(18, 158);
            this.label_patronymic.Margin = new System.Windows.Forms.Padding(10);
            this.label_patronymic.Name = "label_patronymic";
            this.label_patronymic.Size = new System.Drawing.Size(96, 16);
            this.label_patronymic.TabIndex = 2;
            this.label_patronymic.Text = "Middle name";
            // 
            // label_gender
            // 
            this.label_gender.AutoSize = true;
            this.label_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_gender.Location = new System.Drawing.Point(340, 86);
            this.label_gender.Margin = new System.Windows.Forms.Padding(10);
            this.label_gender.Name = "label_gender";
            this.label_gender.Size = new System.Drawing.Size(58, 16);
            this.label_gender.TabIndex = 3;
            this.label_gender.Text = "Gender";
            // 
            // label_dataOfBirth
            // 
            this.label_dataOfBirth.AutoSize = true;
            this.label_dataOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_dataOfBirth.Location = new System.Drawing.Point(337, 45);
            this.label_dataOfBirth.Margin = new System.Windows.Forms.Padding(10);
            this.label_dataOfBirth.Name = "label_dataOfBirth";
            this.label_dataOfBirth.Size = new System.Drawing.Size(92, 16);
            this.label_dataOfBirth.TabIndex = 4;
            this.label_dataOfBirth.Text = "Date of Birth";
            // 
            // label_familyStatus
            // 
            this.label_familyStatus.AutoSize = true;
            this.label_familyStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_familyStatus.Location = new System.Drawing.Point(340, 122);
            this.label_familyStatus.Margin = new System.Windows.Forms.Padding(10);
            this.label_familyStatus.Name = "label_familyStatus";
            this.label_familyStatus.Size = new System.Drawing.Size(98, 16);
            this.label_familyStatus.TabIndex = 5;
            this.label_familyStatus.Text = "Family status";
            // 
            // label_additionalInformation
            // 
            this.label_additionalInformation.AutoSize = true;
            this.label_additionalInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_additionalInformation.Location = new System.Drawing.Point(19, 234);
            this.label_additionalInformation.Margin = new System.Windows.Forms.Padding(10);
            this.label_additionalInformation.Name = "label_additionalInformation";
            this.label_additionalInformation.Size = new System.Drawing.Size(157, 16);
            this.label_additionalInformation.TabIndex = 6;
            this.label_additionalInformation.Text = "Additional Information";
            // 
            // button_save
            // 
            this.button_save.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_save.Location = new System.Drawing.Point(327, 270);
            this.button_save.Margin = new System.Windows.Forms.Padding(10);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(292, 61);
            this.button_save.TabIndex = 7;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // textBox_additionalInformation
            // 
            this.textBox_additionalInformation.Location = new System.Drawing.Point(18, 270);
            this.textBox_additionalInformation.Margin = new System.Windows.Forms.Padding(10);
            this.textBox_additionalInformation.Multiline = true;
            this.textBox_additionalInformation.Name = "textBox_additionalInformation";
            this.textBox_additionalInformation.Size = new System.Drawing.Size(292, 58);
            this.textBox_additionalInformation.TabIndex = 8;
            // 
            // textBox_surname
            // 
            this.textBox_surname.Location = new System.Drawing.Point(19, 126);
            this.textBox_surname.Margin = new System.Windows.Forms.Padding(10);
            this.textBox_surname.Name = "textBox_surname";
            this.textBox_surname.Size = new System.Drawing.Size(291, 20);
            this.textBox_surname.TabIndex = 9;
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(19, 45);
            this.textBox_name.Margin = new System.Windows.Forms.Padding(10);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(291, 20);
            this.textBox_name.TabIndex = 10;
            // 
            // textBox_middlename
            // 
            this.textBox_middlename.Location = new System.Drawing.Point(21, 194);
            this.textBox_middlename.Margin = new System.Windows.Forms.Padding(10);
            this.textBox_middlename.Name = "textBox_middlename";
            this.textBox_middlename.Size = new System.Drawing.Size(289, 20);
            this.textBox_middlename.TabIndex = 11;
            // 
            // radioButton_genderMale
            // 
            this.radioButton_genderMale.AutoSize = true;
            this.radioButton_genderMale.Location = new System.Drawing.Point(438, 86);
            this.radioButton_genderMale.Margin = new System.Windows.Forms.Padding(10);
            this.radioButton_genderMale.Name = "radioButton_genderMale";
            this.radioButton_genderMale.Size = new System.Drawing.Size(48, 17);
            this.radioButton_genderMale.TabIndex = 12;
            this.radioButton_genderMale.TabStop = true;
            this.radioButton_genderMale.Text = "Male";
            this.radioButton_genderMale.UseVisualStyleBackColor = true;
            // 
            // radioButton_genderFemale
            // 
            this.radioButton_genderFemale.AutoSize = true;
            this.radioButton_genderFemale.Location = new System.Drawing.Point(507, 86);
            this.radioButton_genderFemale.Margin = new System.Windows.Forms.Padding(10);
            this.radioButton_genderFemale.Name = "radioButton_genderFemale";
            this.radioButton_genderFemale.Size = new System.Drawing.Size(59, 17);
            this.radioButton_genderFemale.TabIndex = 13;
            this.radioButton_genderFemale.TabStop = true;
            this.radioButton_genderFemale.Text = "Female";
            this.radioButton_genderFemale.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker_dayOfBirth
            // 
            this.dateTimePicker_dayOfBirth.Location = new System.Drawing.Point(449, 45);
            this.dateTimePicker_dayOfBirth.Margin = new System.Windows.Forms.Padding(10);
            this.dateTimePicker_dayOfBirth.Name = "dateTimePicker_dayOfBirth";
            this.dateTimePicker_dayOfBirth.Size = new System.Drawing.Size(185, 20);
            this.dateTimePicker_dayOfBirth.TabIndex = 14;
            // 
            // textBox_familyStatus
            // 
            this.textBox_familyStatus.Location = new System.Drawing.Point(343, 154);
            this.textBox_familyStatus.Margin = new System.Windows.Forms.Padding(10);
            this.textBox_familyStatus.Name = "textBox_familyStatus";
            this.textBox_familyStatus.Size = new System.Drawing.Size(291, 20);
            this.textBox_familyStatus.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(638, 350);
            this.Controls.Add(this.textBox_familyStatus);
            this.Controls.Add(this.dateTimePicker_dayOfBirth);
            this.Controls.Add(this.radioButton_genderFemale);
            this.Controls.Add(this.radioButton_genderMale);
            this.Controls.Add(this.textBox_middlename);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.textBox_surname);
            this.Controls.Add(this.textBox_additionalInformation);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.label_additionalInformation);
            this.Controls.Add(this.label_familyStatus);
            this.Controls.Add(this.label_dataOfBirth);
            this.Controls.Add(this.label_gender);
            this.Controls.Add(this.label_patronymic);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.label_surname);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_surname;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_patronymic;
        private System.Windows.Forms.Label label_gender;
        private System.Windows.Forms.Label label_dataOfBirth;
        private System.Windows.Forms.Label label_familyStatus;
        private System.Windows.Forms.Label label_additionalInformation;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.TextBox textBox_additionalInformation;
        private System.Windows.Forms.TextBox textBox_surname;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_middlename;
        private System.Windows.Forms.RadioButton radioButton_genderMale;
        private System.Windows.Forms.RadioButton radioButton_genderFemale;
        private System.Windows.Forms.DateTimePicker dateTimePicker_dayOfBirth;
        private System.Windows.Forms.TextBox textBox_familyStatus;
    }
}
