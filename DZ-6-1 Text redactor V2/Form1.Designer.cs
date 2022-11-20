using System.Windows.Forms;

namespace PracticWinForms_urok_04_Task1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newDocumentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuncelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.Open = new System.Windows.Forms.ToolStripButton();
            this.Save = new System.Windows.Forms.ToolStripButton();
            this.NewDocument = new System.Windows.Forms.ToolStripButton();
            this.Copy = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Cut = new System.Windows.Forms.ToolStripButton();
            this.Insert = new System.Windows.Forms.ToolStripButton();
            this.Cancel = new System.Windows.Forms.ToolStripButton();
            this.SelectAll = new System.Windows.Forms.ToolStripButton();
            this.SaveAs = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.FontColor = new System.Windows.Forms.ToolStripButton();
            this.BackgroundColor = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.inputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.cancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.editToolStripMenuItem,
            this.fontToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(582, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.newDocumentToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.файлToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = global::PracticWinForms_urok_04_Task1.Properties.Resources.Hopstarter_Sleek_Xp_Basic_Folder_Open;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.Open_Click);
            // 
            // newDocumentToolStripMenuItem
            // 
            this.newDocumentToolStripMenuItem.Image = global::PracticWinForms_urok_04_Task1.Properties.Resources.Gakuseisean_Ivista_2_Files_New_File1;
            this.newDocumentToolStripMenuItem.Name = "newDocumentToolStripMenuItem";
            this.newDocumentToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newDocumentToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.newDocumentToolStripMenuItem.Text = "New Document";
            this.newDocumentToolStripMenuItem.Click += new System.EventHandler(this.NewDocument_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = global::PracticWinForms_urok_04_Task1.Properties.Resources.Custom_Icon_Design_Pretty_Office_7_Save;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.Save_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Image = global::PracticWinForms_urok_04_Task1.Properties.Resources.saveall_1204;
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAs_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.Close_click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.cutToolStripMenuItem,
            this.selectAllToolStripMenuItem,
            this.cuncelToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = global::PracticWinForms_urok_04_Task1.Properties.Resources.Custom_Icon_Design_Mono_General_2_Copy;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.Copy_Click);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Image = global::PracticWinForms_urok_04_Task1.Properties.Resources.Custom_Icon_Design_Mono_General_2_Cut;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.Cut_Click);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Image = global::PracticWinForms_urok_04_Task1.Properties.Resources.select_icon_125164;
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.selectAllToolStripMenuItem.Text = "Select All";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.SelectAll_Click);
            // 
            // cuncelToolStripMenuItem
            // 
            this.cuncelToolStripMenuItem.Image = global::PracticWinForms_urok_04_Task1.Properties.Resources.Oxygen_Icons_org_Oxygen_Actions_application_exit;
            this.cuncelToolStripMenuItem.Name = "cuncelToolStripMenuItem";
            this.cuncelToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.cuncelToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.cuncelToolStripMenuItem.Text = "Cancel";
            this.cuncelToolStripMenuItem.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontColorToolStripMenuItem,
            this.backgroundColorToolStripMenuItem});
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.fontToolStripMenuItem.Text = "Font";
            // 
            // fontColorToolStripMenuItem
            // 
            this.fontColorToolStripMenuItem.Image = global::PracticWinForms_urok_04_Task1.Properties.Resources.Oxygen_Icons_org_Oxygen_Apps_preferences_desktop_font;
            this.fontColorToolStripMenuItem.Name = "fontColorToolStripMenuItem";
            this.fontColorToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.fontColorToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.fontColorToolStripMenuItem.Text = "Font Color";
            this.fontColorToolStripMenuItem.Click += new System.EventHandler(this.FontColor_Click);
            // 
            // backgroundColorToolStripMenuItem
            // 
            this.backgroundColorToolStripMenuItem.Image = global::PracticWinForms_urok_04_Task1.Properties.Resources.Custom_Icon_Design_Flatastic_9_Stop_red;
            this.backgroundColorToolStripMenuItem.Name = "backgroundColorToolStripMenuItem";
            this.backgroundColorToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.backgroundColorToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.backgroundColorToolStripMenuItem.Text = "Background Color";
            this.backgroundColorToolStripMenuItem.Click += new System.EventHandler(this.BackgroundColor_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator9,
            this.Open,
            this.Save,
            this.NewDocument,
            this.Copy,
            this.toolStripSeparator7,
            this.toolStripSeparator8,
            this.toolStripSeparator1,
            this.Cut,
            this.Insert,
            this.Cancel,
            this.SelectAll,
            this.SaveAs,
            this.toolStripSeparator6,
            this.toolStripSeparator5,
            this.toolStripSeparator2,
            this.FontColor,
            this.BackgroundColor,
            this.toolStripSeparator3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(582, 37);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 37);
            // 
            // Open
            // 
            this.Open.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Open.Image = global::PracticWinForms_urok_04_Task1.Properties.Resources.Hopstarter_Sleek_Xp_Basic_Folder_Open;
            this.Open.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(34, 34);
            this.Open.Text = "Open";
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // Save
            // 
            this.Save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Save.Image = global::PracticWinForms_urok_04_Task1.Properties.Resources.Custom_Icon_Design_Pretty_Office_7_Save;
            this.Save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(34, 34);
            this.Save.Text = "Save";
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // NewDocument
            // 
            this.NewDocument.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NewDocument.Image = global::PracticWinForms_urok_04_Task1.Properties.Resources.Gakuseisean_Ivista_2_Files_New_File1;
            this.NewDocument.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NewDocument.Name = "NewDocument";
            this.NewDocument.Size = new System.Drawing.Size(34, 34);
            this.NewDocument.Text = "New Document";
            this.NewDocument.Click += new System.EventHandler(this.NewDocument_Click);
            // 
            // Copy
            // 
            this.Copy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Copy.Image = global::PracticWinForms_urok_04_Task1.Properties.Resources.Custom_Icon_Design_Mono_General_2_Copy;
            this.Copy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Copy.Name = "Copy";
            this.Copy.Size = new System.Drawing.Size(34, 34);
            this.Copy.Text = "Copy";
            this.Copy.Click += new System.EventHandler(this.Copy_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 37);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 37);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 37);
            // 
            // Cut
            // 
            this.Cut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Cut.Image = global::PracticWinForms_urok_04_Task1.Properties.Resources.Custom_Icon_Design_Mono_General_2_Cut;
            this.Cut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Cut.Name = "Cut";
            this.Cut.Size = new System.Drawing.Size(34, 34);
            this.Cut.Text = "Cut";
            this.Cut.Click += new System.EventHandler(this.Cut_Click);
            // 
            // Insert
            // 
            this.Insert.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Insert.Image = global::PracticWinForms_urok_04_Task1.Properties.Resources.transfer_64px;
            this.Insert.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(34, 34);
            this.Insert.Text = "Insert";
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // Cancel
            // 
            this.Cancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Cancel.Image = global::PracticWinForms_urok_04_Task1.Properties.Resources.Oxygen_Icons_org_Oxygen_Actions_application_exit;
            this.Cancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(34, 34);
            this.Cancel.Text = "Cancel";
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // SelectAll
            // 
            this.SelectAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SelectAll.Image = global::PracticWinForms_urok_04_Task1.Properties.Resources.select_icon_125164;
            this.SelectAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SelectAll.Name = "SelectAll";
            this.SelectAll.Size = new System.Drawing.Size(34, 34);
            this.SelectAll.Text = "Select All";
            this.SelectAll.Click += new System.EventHandler(this.SelectAll_Click);
            // 
            // SaveAs
            // 
            this.SaveAs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveAs.Image = global::PracticWinForms_urok_04_Task1.Properties.Resources.saveall_1204;
            this.SaveAs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveAs.Name = "SaveAs";
            this.SaveAs.Size = new System.Drawing.Size(34, 34);
            this.SaveAs.Text = "SaveAs";
            this.SaveAs.Click += new System.EventHandler(this.SaveAs_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 37);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 37);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 37);
            // 
            // FontColor
            // 
            this.FontColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.FontColor.Image = global::PracticWinForms_urok_04_Task1.Properties.Resources.Oxygen_Icons_org_Oxygen_Apps_preferences_desktop_font;
            this.FontColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FontColor.Name = "FontColor";
            this.FontColor.Size = new System.Drawing.Size(34, 34);
            this.FontColor.Text = "Font Color";
            this.FontColor.Click += new System.EventHandler(this.FontColor_Click);
            // 
            // BackgroundColor
            // 
            this.BackgroundColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BackgroundColor.Image = global::PracticWinForms_urok_04_Task1.Properties.Resources.Custom_Icon_Design_Flatastic_9_Stop_red;
            this.BackgroundColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BackgroundColor.Name = "BackgroundColor";
            this.BackgroundColor.Size = new System.Drawing.Size(34, 34);
            this.BackgroundColor.Text = "Background Color";
            this.BackgroundColor.Click += new System.EventHandler(this.BackgroundColor_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 37);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem1,
            this.cutToolStripMenuItem1,
            this.inputToolStripMenuItem,
            this.toolStripSeparator4,
            this.cancelToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(152, 98);
            // 
            // copyToolStripMenuItem1
            // 
            this.copyToolStripMenuItem1.Image = global::PracticWinForms_urok_04_Task1.Properties.Resources.Custom_Icon_Design_Mono_General_2_Copy;
            this.copyToolStripMenuItem1.Name = "copyToolStripMenuItem1";
            this.copyToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem1.Size = new System.Drawing.Size(151, 22);
            this.copyToolStripMenuItem1.Text = "Copy";
            this.copyToolStripMenuItem1.Click += new System.EventHandler ( Copy_Click );
            // 
            // cutToolStripMenuItem1
            // 
            this.cutToolStripMenuItem1.Image = global::PracticWinForms_urok_04_Task1.Properties.Resources.Custom_Icon_Design_Mono_General_2_Cut;
            this.cutToolStripMenuItem1.Name = "cutToolStripMenuItem1";
            this.cutToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem1.Size = new System.Drawing.Size(151, 22);
            this.cutToolStripMenuItem1.Text = "Cut";
            this.cutToolStripMenuItem1.Click += new System.EventHandler ( Cut_Click);
            // 
            // inputToolStripMenuItem
            // 
            this.inputToolStripMenuItem.Image = global::PracticWinForms_urok_04_Task1.Properties.Resources.transfer_64px;
            this.inputToolStripMenuItem.Name = "inputToolStripMenuItem";
            this.inputToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.inputToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.inputToolStripMenuItem.Text = "Insert";
            this.inputToolStripMenuItem.Click += new System.EventHandler ( Insert_Click );
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(148, 6);
            // 
            // cancelToolStripMenuItem
            // 
            this.cancelToolStripMenuItem.Name = "cancelToolStripMenuItem";
            this.cancelToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.cancelToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.cancelToolStripMenuItem.Text = "Cancel";
            this.cancelToolStripMenuItem.Click+=new System.EventHandler ( Cancel_Click );
            // 
            // richTextBox1
            // 
            this.richTextBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.richTextBox1.Location = new System.Drawing.Point(12, 75);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(558, 618);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(582, 705);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Text editor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newDocumentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuncelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backgroundColorToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Open;
        private System.Windows.Forms.ToolStripButton Save;
        private System.Windows.Forms.ToolStripButton NewDocument;
        private System.Windows.Forms.ToolStripButton Copy;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton Cut;
        private System.Windows.Forms.ToolStripButton Insert;
        private System.Windows.Forms.ToolStripButton Cancel;
        private System.Windows.Forms.ToolStripButton SelectAll;
        private System.Windows.Forms.ToolStripButton SaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton FontColor;
        private System.Windows.Forms.ToolStripButton BackgroundColor;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem inputToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem cancelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
    }
}

