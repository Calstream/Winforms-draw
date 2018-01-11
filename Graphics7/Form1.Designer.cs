namespace Graphics7
{
    partial class MainWindow
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
            this.menu = new System.Windows.Forms.MenuStrip();
            this.imageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.openMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.saveMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.th_l = new System.Windows.Forms.Label();
            this.op_l = new System.Windows.Forms.Label();
            this.color_l = new System.Windows.Forms.Label();
            this.trackBarTHval = new System.Windows.Forms.Label();
            this.trackBarOPval = new System.Windows.Forms.Label();
            this.trackBarTH = new System.Windows.Forms.TrackBar();
            this.trackBarOP = new System.Windows.Forms.TrackBar();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.menu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarOP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu.AutoSize = false;
            this.menu.Dock = System.Windows.Forms.DockStyle.None;
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imageToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menu.Size = new System.Drawing.Size(727, 30);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // imageToolStripMenuItem
            // 
            this.imageToolStripMenuItem.AutoSize = false;
            this.imageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newMenu,
            this.openMenu,
            this.saveMenu,
            this.exitMenu});
            this.imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            this.imageToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.imageToolStripMenuItem.Text = "Image";
            // 
            // newMenu
            // 
            this.newMenu.Name = "newMenu";
            this.newMenu.Size = new System.Drawing.Size(129, 26);
            this.newMenu.Text = "New";
            this.newMenu.Click += new System.EventHandler(this.newMenu_Click);
            // 
            // openMenu
            // 
            this.openMenu.Name = "openMenu";
            this.openMenu.Size = new System.Drawing.Size(129, 26);
            this.openMenu.Text = "Open...";
            this.openMenu.Click += new System.EventHandler(this.openMenu_Click);
            // 
            // saveMenu
            // 
            this.saveMenu.Name = "saveMenu";
            this.saveMenu.Size = new System.Drawing.Size(129, 26);
            this.saveMenu.Text = "Save...";
            this.saveMenu.Click += new System.EventHandler(this.saveMenu_Click);
            // 
            // exitMenu
            // 
            this.exitMenu.Name = "exitMenu";
            this.exitMenu.Size = new System.Drawing.Size(129, 26);
            this.exitMenu.Text = "Exit";
            this.exitMenu.Click += new System.EventHandler(this.exitMenu_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.th_l);
            this.panel1.Controls.Add(this.op_l);
            this.panel1.Controls.Add(this.color_l);
            this.panel1.Controls.Add(this.trackBarTHval);
            this.panel1.Controls.Add(this.trackBarOPval);
            this.panel1.Controls.Add(this.trackBarTH);
            this.panel1.Controls.Add(this.trackBarOP);
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(727, 64);
            this.panel1.TabIndex = 1;
            // 
            // th_l
            // 
            this.th_l.AutoSize = true;
            this.th_l.BackColor = System.Drawing.Color.White;
            this.th_l.Location = new System.Drawing.Point(435, 43);
            this.th_l.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.th_l.Name = "th_l";
            this.th_l.Size = new System.Drawing.Size(72, 17);
            this.th_l.TabIndex = 6;
            this.th_l.Text = "Thickness";
            // 
            // op_l
            // 
            this.op_l.AutoSize = true;
            this.op_l.BackColor = System.Drawing.Color.White;
            this.op_l.Location = new System.Drawing.Point(103, 43);
            this.op_l.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.op_l.Name = "op_l";
            this.op_l.Size = new System.Drawing.Size(56, 17);
            this.op_l.TabIndex = 5;
            this.op_l.Text = "Opacity";
            // 
            // color_l
            // 
            this.color_l.BackColor = System.Drawing.Color.Turquoise;
            this.color_l.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.color_l.Location = new System.Drawing.Point(659, 14);
            this.color_l.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.color_l.Name = "color_l";
            this.color_l.Size = new System.Drawing.Size(33, 28);
            this.color_l.TabIndex = 0;
            this.color_l.Click += new System.EventHandler(this.color_l_Click);
            // 
            // trackBarTHval
            // 
            this.trackBarTHval.AutoSize = true;
            this.trackBarTHval.Location = new System.Drawing.Point(597, 26);
            this.trackBarTHval.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.trackBarTHval.Name = "trackBarTHval";
            this.trackBarTHval.Size = new System.Drawing.Size(24, 17);
            this.trackBarTHval.TabIndex = 4;
            this.trackBarTHval.Text = "73";
            // 
            // trackBarOPval
            // 
            this.trackBarOPval.AutoSize = true;
            this.trackBarOPval.Location = new System.Drawing.Point(265, 26);
            this.trackBarOPval.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.trackBarOPval.Name = "trackBarOPval";
            this.trackBarOPval.Size = new System.Drawing.Size(32, 17);
            this.trackBarOPval.TabIndex = 3;
            this.trackBarOPval.Text = "255";
            // 
            // trackBarTH
            // 
            this.trackBarTH.BackColor = System.Drawing.SystemColors.HighlightText;
            this.trackBarTH.Location = new System.Drawing.Point(347, 4);
            this.trackBarTH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.trackBarTH.Maximum = 100;
            this.trackBarTH.Name = "trackBarTH";
            this.trackBarTH.Size = new System.Drawing.Size(243, 56);
            this.trackBarTH.TabIndex = 2;
            this.trackBarTH.TickFrequency = 10;
            this.trackBarTH.Value = 73;
            this.trackBarTH.ValueChanged += new System.EventHandler(this.trackBar_ValueChanged);
            // 
            // trackBarOP
            // 
            this.trackBarOP.BackColor = System.Drawing.SystemColors.HighlightText;
            this.trackBarOP.LargeChange = 10;
            this.trackBarOP.Location = new System.Drawing.Point(15, 4);
            this.trackBarOP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.trackBarOP.Maximum = 255;
            this.trackBarOP.Name = "trackBarOP";
            this.trackBarOP.Size = new System.Drawing.Size(243, 56);
            this.trackBarOP.TabIndex = 1;
            this.trackBarOP.TickFrequency = 17;
            this.trackBarOP.Value = 255;
            this.trackBarOP.ValueChanged += new System.EventHandler(this.trackBar_ValueChanged);
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox.Location = new System.Drawing.Point(0, 94);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(549, 351);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            this.pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseUp);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(723, 493);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menu;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainWindow";
            this.Text = "Graphics-7";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarOP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem imageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newMenu;
        private System.Windows.Forms.ToolStripMenuItem openMenu;
        private System.Windows.Forms.ToolStripMenuItem saveMenu;
        private System.Windows.Forms.ToolStripMenuItem exitMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TrackBar trackBarTH;
        private System.Windows.Forms.TrackBar trackBarOP;
        private System.Windows.Forms.Label color_l;
        private System.Windows.Forms.Label th_l;
        private System.Windows.Forms.Label op_l;
        private System.Windows.Forms.Label trackBarTHval;
        private System.Windows.Forms.Label trackBarOPval;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

