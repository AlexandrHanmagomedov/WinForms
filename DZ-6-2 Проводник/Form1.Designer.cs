namespace Проводник {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ListBoxFolders = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.OpenContextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BackContextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ListBoxFiles = new System.Windows.Forms.ListBox();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.ToolStripStatusGetTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripAddressStringStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusLabelCurrentCatalog = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusCurrentCatalog = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusLabelSelectedFile = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusSelectedFile = new System.Windows.Forms.ToolStripStatusLabel();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.GroupBoxFolders = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.OpenToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.BackToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.contextMenuStrip1.SuspendLayout();
            this.StatusStrip.SuspendLayout();
            this.GroupBoxFolders.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListBoxFolders
            // 
            this.ListBoxFolders.ContextMenuStrip = this.contextMenuStrip1;
            this.ListBoxFolders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListBoxFolders.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ListBoxFolders.FormattingEnabled = true;
            this.ListBoxFolders.HorizontalScrollbar = true;
            this.ListBoxFolders.ItemHeight = 25;
            this.ListBoxFolders.Location = new System.Drawing.Point(3, 22);
            this.ListBoxFolders.Name = "ListBoxFolders";
            this.ListBoxFolders.ScrollAlwaysVisible = true;
            this.ListBoxFolders.Size = new System.Drawing.Size(209, 401);
            this.ListBoxFolders.TabIndex = 0;
            this.ListBoxFolders.SelectedIndexChanged += new System.EventHandler(this.ListBoxFolders_SelectedIndexChanged);
            this.ListBoxFolders.DoubleClick += new System.EventHandler(this.ListBoxFolders_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenContextToolStripMenuItem,
            this.BackContextToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(165, 48);
            // 
            // OpenContextToolStripMenuItem
            // 
            this.OpenContextToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("OpenContextToolStripMenuItem.Image")));
            this.OpenContextToolStripMenuItem.Name = "OpenContextToolStripMenuItem";
            this.OpenContextToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.OpenContextToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.OpenContextToolStripMenuItem.Text = "Открыть";
            this.OpenContextToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // BackContextToolStripMenuItem
            // 
            this.BackContextToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("BackContextToolStripMenuItem.Image")));
            this.BackContextToolStripMenuItem.Name = "BackContextToolStripMenuItem";
            this.BackContextToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Left)));
            this.BackContextToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.BackContextToolStripMenuItem.Text = "Назад";
            this.BackContextToolStripMenuItem.Click += new System.EventHandler(this.BackToolStripMenuItem_Click);
            // 
            // ListBoxFiles
            // 
            this.ListBoxFiles.ContextMenuStrip = this.contextMenuStrip1;
            this.ListBoxFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListBoxFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ListBoxFiles.FormattingEnabled = true;
            this.ListBoxFiles.HorizontalScrollbar = true;
            this.ListBoxFiles.ItemHeight = 25;
            this.ListBoxFiles.Location = new System.Drawing.Point(3, 25);
            this.ListBoxFiles.Name = "ListBoxFiles";
            this.ListBoxFiles.ScrollAlwaysVisible = true;
            this.ListBoxFiles.Size = new System.Drawing.Size(241, 395);
            this.ListBoxFiles.TabIndex = 1;
            this.ListBoxFiles.SelectedIndexChanged += new System.EventHandler(this.ListBoxFiles_SelectedIndexChanged);
            this.ListBoxFiles.DoubleClick += new System.EventHandler(this.ListBoxFiles_DoubleClick);
            // 
            // StatusStrip
            // 
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripStatusGetTime,
            this.ToolStripStatusLabel1,
            this.ToolStripAddressStringStatusLabel,
            this.ToolStripStatusLabelCurrentCatalog,
            this.ToolStripStatusCurrentCatalog,
            this.ToolStripStatusLabelSelectedFile,
            this.ToolStripStatusSelectedFile});
            this.StatusStrip.Location = new System.Drawing.Point(0, 513);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.StatusStrip.Size = new System.Drawing.Size(480, 26);
            this.StatusStrip.TabIndex = 2;
            this.StatusStrip.Text = "statusStrip1";
            // 
            // ToolStripStatusGetTime
            // 
            this.ToolStripStatusGetTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToolStripStatusGetTime.Name = "ToolStripStatusGetTime";
            this.ToolStripStatusGetTime.Size = new System.Drawing.Size(70, 21);
            this.ToolStripStatusGetTime.Text = "23:59:59";
            // 
            // ToolStripStatusLabel1
            // 
            this.ToolStripStatusLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1";
            this.ToolStripStatusLabel1.Size = new System.Drawing.Size(121, 21);
            this.ToolStripStatusLabel1.Text = "Path:";
            // 
            // ToolStripAddressStringStatusLabel
            // 
            this.ToolStripAddressStringStatusLabel.Name = "ToolStripAddressStringStatusLabel";
            this.ToolStripAddressStringStatusLabel.Size = new System.Drawing.Size(0, 21);
            // 
            // ToolStripStatusLabelCurrentCatalog
            // 
            this.ToolStripStatusLabelCurrentCatalog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToolStripStatusLabelCurrentCatalog.Name = "ToolStripStatusLabelCurrentCatalog";
            this.ToolStripStatusLabelCurrentCatalog.Size = new System.Drawing.Size(158, 21);
            this.ToolStripStatusLabelCurrentCatalog.Text = "Выбранный каталог:";
            // 
            // ToolStripStatusCurrentCatalog
            // 
            this.ToolStripStatusCurrentCatalog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToolStripStatusCurrentCatalog.Name = "ToolStripStatusCurrentCatalog";
            this.ToolStripStatusCurrentCatalog.Size = new System.Drawing.Size(0, 21);
            // 
            // ToolStripStatusLabelSelectedFile
            // 
            this.ToolStripStatusLabelSelectedFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToolStripStatusLabelSelectedFile.Name = "ToolStripStatusLabelSelectedFile";
            this.ToolStripStatusLabelSelectedFile.Size = new System.Drawing.Size(138, 21);
            this.ToolStripStatusLabelSelectedFile.Text = "Selected fail:";
            // 
            // ToolStripStatusSelectedFile
            // 
            this.ToolStripStatusSelectedFile.AutoToolTip = true;
            this.ToolStripStatusSelectedFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToolStripStatusSelectedFile.Name = "ToolStripStatusSelectedFile";
            this.ToolStripStatusSelectedFile.Size = new System.Drawing.Size(0, 21);
            // 
            // Timer1
            // 
            this.Timer1.Interval = 1000;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // GroupBoxFolders
            // 
            this.GroupBoxFolders.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.GroupBoxFolders.Controls.Add(this.ListBoxFolders);
            this.GroupBoxFolders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GroupBoxFolders.Location = new System.Drawing.Point(12, 84);
            this.GroupBoxFolders.Name = "GroupBoxFolders";
            this.GroupBoxFolders.Size = new System.Drawing.Size(215, 426);
            this.GroupBoxFolders.TabIndex = 6;
            this.GroupBoxFolders.TabStop = false;
            this.GroupBoxFolders.Text = "Folders";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.ListBoxFiles);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(233, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 423);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Files";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(480, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuItem
            // 
            this.ToolStripMenuItem.Checked = true;
            this.ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenToolStripMenuItem,
            this.BackToolStripMenuItem});
            this.ToolStripMenuItem.Name = "ToolStripMenuItem";
            this.ToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ToolStripMenuItem.Text = "Menu";
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("OpenToolStripMenuItem.Image")));
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.OpenToolStripMenuItem.Text = "Open";
            this.OpenToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // BackToolStripMenuItem
            // 
            this.BackToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("BackToolStripMenuItem.Image")));
            this.BackToolStripMenuItem.Name = "BackToolStripMenuItem";
            this.BackToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Left)));
            this.BackToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.BackToolStripMenuItem.Text = "Back";
            this.BackToolStripMenuItem.Click += new System.EventHandler(this.BackToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenToolStripButton1,
            this.BackToolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(480, 57);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // OpenToolStripButton1
            // 
            this.OpenToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.OpenToolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("OpenToolStripButton1.Image")));
            this.OpenToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpenToolStripButton1.Name = "OpenToolStripButton1";
            this.OpenToolStripButton1.Size = new System.Drawing.Size(54, 54);
            this.OpenToolStripButton1.Text = "toolStripButton1";
            this.OpenToolStripButton1.ToolTipText = "Открыть";
            this.OpenToolStripButton1.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // BackToolStripButton1
            // 
            this.BackToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BackToolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("BackToolStripButton1.Image")));
            this.BackToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BackToolStripButton1.Name = "BackToolStripButton1";
            this.BackToolStripButton1.Size = new System.Drawing.Size(54, 54);
            this.BackToolStripButton1.Text = "Назад";
            this.BackToolStripButton1.Click += new System.EventHandler(this.BackToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(480, 539);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GroupBoxFolders);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Volkov commander for pauper";           
            this.Load += new System.EventHandler(this.FormExplorer_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.GroupBoxFolders.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListBoxFolders;
        private System.Windows.Forms.ListBox ListBoxFiles;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel ToolStripStatusGetTime;
        private System.Windows.Forms.Timer Timer1;
        private System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabelCurrentCatalog;
        private System.Windows.Forms.ToolStripStatusLabel ToolStripStatusCurrentCatalog;
        private System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabelSelectedFile;
        private System.Windows.Forms.ToolStripStatusLabel ToolStripStatusSelectedFile;
        private System.Windows.Forms.GroupBox GroupBoxFolders;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BackToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BackToolStripButton1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem BackContextToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton OpenToolStripButton1;
        private System.Windows.Forms.ToolStripMenuItem OpenContextToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel ToolStripAddressStringStatusLabel;
    }
}

