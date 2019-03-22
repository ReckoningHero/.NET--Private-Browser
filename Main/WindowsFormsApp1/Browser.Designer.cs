namespace WindowsFormsApp1
{
    partial class Browser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Browser));
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookmarksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookmarksToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.searchEngineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.googleChromeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.duckDuckGoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cPUTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.Forward = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AccessibleName = "";
            this.panel1.AutoScroll = true;
            this.panel1.AutoSize = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(0, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(4, 4);
            this.panel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.openToolStripMenuItem,
            this.bookmarksToolStripMenuItem,
            this.searchEngineToolStripMenuItem,
            this.cPUTestToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.newTabToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1894, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(68, 29);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // bookmarksToolStripMenuItem
            // 
            this.bookmarksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookmarksToolStripMenuItem1});
            this.bookmarksToolStripMenuItem.Name = "bookmarksToolStripMenuItem";
            this.bookmarksToolStripMenuItem.Size = new System.Drawing.Size(113, 29);
            this.bookmarksToolStripMenuItem.Text = "Bookmarks";
            // 
            // bookmarksToolStripMenuItem1
            // 
            this.bookmarksToolStripMenuItem1.Name = "bookmarksToolStripMenuItem1";
            this.bookmarksToolStripMenuItem1.Size = new System.Drawing.Size(185, 30);
            this.bookmarksToolStripMenuItem1.Text = "Bookmarks";
            // 
            // searchEngineToolStripMenuItem
            // 
            this.searchEngineToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.googleChromeToolStripMenuItem,
            this.duckDuckGoToolStripMenuItem});
            this.searchEngineToolStripMenuItem.Name = "searchEngineToolStripMenuItem";
            this.searchEngineToolStripMenuItem.Size = new System.Drawing.Size(134, 29);
            this.searchEngineToolStripMenuItem.Text = "Search Engine";
            // 
            // googleChromeToolStripMenuItem
            // 
            this.googleChromeToolStripMenuItem.Name = "googleChromeToolStripMenuItem";
            this.googleChromeToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.googleChromeToolStripMenuItem.Text = "Google";
            this.googleChromeToolStripMenuItem.Click += new System.EventHandler(this.googleChromeToolStripMenuItem_Click);
            // 
            // duckDuckGoToolStripMenuItem
            // 
            this.duckDuckGoToolStripMenuItem.Name = "duckDuckGoToolStripMenuItem";
            this.duckDuckGoToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.duckDuckGoToolStripMenuItem.Text = "DuckDuckGo";
            this.duckDuckGoToolStripMenuItem.Click += new System.EventHandler(this.duckDuckGoToolStripMenuItem_Click);
            // 
            // cPUTestToolStripMenuItem
            // 
            this.cPUTestToolStripMenuItem.Name = "cPUTestToolStripMenuItem";
            this.cPUTestToolStripMenuItem.Size = new System.Drawing.Size(94, 29);
            this.cPUTestToolStripMenuItem.Text = "CPU_Test";
            this.cPUTestToolStripMenuItem.Click += new System.EventHandler(this.cPUTestToolStripMenuItem_Click_1);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(74, 29);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // newTabToolStripMenuItem
            // 
            this.newTabToolStripMenuItem.Name = "newTabToolStripMenuItem";
            this.newTabToolStripMenuItem.Size = new System.Drawing.Size(91, 29);
            this.newTabToolStripMenuItem.Text = "New Tab";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Location = new System.Drawing.Point(12, 78);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1736, 26);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources._476283;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(1754, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 2;
            this.button1.Text = "Go";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Back.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Fast_backward;
            this.Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Back.Location = new System.Drawing.Point(12, 36);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(44, 40);
            this.Back.TabIndex = 3;
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Forward
            // 
            this.Forward.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Forward.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.windows_media_player_skip_forward_button_md;
            this.Forward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Forward.Location = new System.Drawing.Point(78, 36);
            this.Forward.Name = "Forward";
            this.Forward.Size = new System.Drawing.Size(44, 40);
            this.Forward.TabIndex = 4;
            this.Forward.UseVisualStyleBackColor = false;
            this.Forward.Click += new System.EventHandler(this.Forward_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.AutoSize = true;
            this.panel2.Location = new System.Drawing.Point(0, 103);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1894, 863);
            this.panel2.TabIndex = 5;
            this.panel2.UseWaitCursor = true;
            // 
            // Browser
            // 
            this.AccessibleName = "";
            this.AutoSize = true;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources._77448;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1894, 962);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Forward);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Browser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchEngineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem googleChromeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem duckDuckGoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cPUTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripMenuItem bookmarksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookmarksToolStripMenuItem1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem newTabToolStripMenuItem;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Forward;
        private System.Windows.Forms.Panel panel2;
    }
}