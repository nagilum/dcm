namespace dcm
{
    partial class fmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmMain));
            this.pbArea = new System.Windows.Forms.PictureBox();
            this.pbColor = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.trRefresh = new System.Windows.Forms.Timer(this.components);
            this.tbRed = new System.Windows.Forms.TextBox();
            this.tbGreen = new System.Windows.Forms.TextBox();
            this.tbBlue = new System.Windows.Forms.TextBox();
            this.lvColors = new System.Windows.Forms.ListView();
            this.chColor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chRGB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chHEX = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.copyValueContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyHexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyRGBValueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyRValueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyGValueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyBValueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ilColors = new System.Windows.Forms.ImageList(this.components);
            this.lbInfo = new System.Windows.Forms.Label();
            this.rbRGB = new System.Windows.Forms.RadioButton();
            this.rbHEX = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.cbRGB = new System.Windows.Forms.CheckBox();
            this.cbHEX = new System.Windows.Forms.CheckBox();
            this.copyValueMenuStrip = new System.Windows.Forms.MenuStrip();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyRGBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyRGBToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.copyRedValueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyGreenValueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyBlueValueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblUpdateSpeed = new System.Windows.Forms.Label();
            this.tbrUpdateSpeed = new System.Windows.Forms.TrackBar();
            this.lblSlow = new System.Windows.Forms.Label();
            this.lblFast = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbColor)).BeginInit();
            this.copyValueContextMenuStrip.SuspendLayout();
            this.copyValueMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbrUpdateSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // pbArea
            // 
            this.pbArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbArea.Location = new System.Drawing.Point(12, 29);
            this.pbArea.Name = "pbArea";
            this.pbArea.Size = new System.Drawing.Size(132, 132);
            this.pbArea.TabIndex = 0;
            this.pbArea.TabStop = false;
            // 
            // pbColor
            // 
            this.pbColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbColor.Location = new System.Drawing.Point(12, 167);
            this.pbColor.Name = "pbColor";
            this.pbColor.Size = new System.Drawing.Size(46, 62);
            this.pbColor.TabIndex = 1;
            this.pbColor.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "R";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "G";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "B";
            // 
            // trRefresh
            // 
            this.trRefresh.Enabled = true;
            this.trRefresh.Interval = 50;
            this.trRefresh.Tick += new System.EventHandler(this.trRefresh_Tick);
            // 
            // tbRed
            // 
            this.tbRed.Location = new System.Drawing.Point(85, 167);
            this.tbRed.Name = "tbRed";
            this.tbRed.ReadOnly = true;
            this.tbRed.Size = new System.Drawing.Size(59, 20);
            this.tbRed.TabIndex = 8;
            // 
            // tbGreen
            // 
            this.tbGreen.Location = new System.Drawing.Point(85, 188);
            this.tbGreen.Name = "tbGreen";
            this.tbGreen.ReadOnly = true;
            this.tbGreen.Size = new System.Drawing.Size(59, 20);
            this.tbGreen.TabIndex = 9;
            // 
            // tbBlue
            // 
            this.tbBlue.Location = new System.Drawing.Point(85, 209);
            this.tbBlue.Name = "tbBlue";
            this.tbBlue.ReadOnly = true;
            this.tbBlue.Size = new System.Drawing.Size(59, 20);
            this.tbBlue.TabIndex = 10;
            // 
            // lvColors
            // 
            this.lvColors.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvColors.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chColor,
            this.chRGB,
            this.chHEX});
            this.lvColors.ContextMenuStrip = this.copyValueContextMenuStrip;
            this.lvColors.FullRowSelect = true;
            this.lvColors.HideSelection = false;
            this.lvColors.LargeImageList = this.ilColors;
            this.lvColors.Location = new System.Drawing.Point(150, 29);
            this.lvColors.Name = "lvColors";
            this.lvColors.Size = new System.Drawing.Size(254, 200);
            this.lvColors.SmallImageList = this.ilColors;
            this.lvColors.TabIndex = 11;
            this.lvColors.UseCompatibleStateImageBehavior = false;
            this.lvColors.View = System.Windows.Forms.View.Details;
            // 
            // chColor
            // 
            this.chColor.Text = "";
            this.chColor.Width = 25;
            // 
            // chRGB
            // 
            this.chRGB.Text = "RGB";
            this.chRGB.Width = 120;
            // 
            // chHEX
            // 
            this.chHEX.Text = "HEX";
            this.chHEX.Width = 80;
            // 
            // copyValueContextMenuStrip
            // 
            this.copyValueContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyHexToolStripMenuItem,
            this.copyRGBValueToolStripMenuItem,
            this.copyRValueToolStripMenuItem,
            this.copyGValueToolStripMenuItem,
            this.copyBValueToolStripMenuItem});
            this.copyValueContextMenuStrip.Name = "contextMenuStrip1";
            this.copyValueContextMenuStrip.Size = new System.Drawing.Size(159, 114);
            // 
            // copyHexToolStripMenuItem
            // 
            this.copyHexToolStripMenuItem.Name = "copyHexToolStripMenuItem";
            this.copyHexToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.copyHexToolStripMenuItem.Text = "Copy Hex Value";
            this.copyHexToolStripMenuItem.Click += new System.EventHandler(this.miCopyHEX_Click);
            // 
            // copyRGBValueToolStripMenuItem
            // 
            this.copyRGBValueToolStripMenuItem.Name = "copyRGBValueToolStripMenuItem";
            this.copyRGBValueToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.copyRGBValueToolStripMenuItem.Text = "Copy RGB Value";
            this.copyRGBValueToolStripMenuItem.Click += new System.EventHandler(this.miCopyRGB_Click);
            // 
            // copyRValueToolStripMenuItem
            // 
            this.copyRValueToolStripMenuItem.Name = "copyRValueToolStripMenuItem";
            this.copyRValueToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.copyRValueToolStripMenuItem.Text = "Copy R Value";
            this.copyRValueToolStripMenuItem.Click += new System.EventHandler(this.miCopyR_Click);
            // 
            // copyGValueToolStripMenuItem
            // 
            this.copyGValueToolStripMenuItem.Name = "copyGValueToolStripMenuItem";
            this.copyGValueToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.copyGValueToolStripMenuItem.Text = "Copy G Value";
            this.copyGValueToolStripMenuItem.Click += new System.EventHandler(this.miCopyG_Click);
            // 
            // copyBValueToolStripMenuItem
            // 
            this.copyBValueToolStripMenuItem.Name = "copyBValueToolStripMenuItem";
            this.copyBValueToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.copyBValueToolStripMenuItem.Text = "Copy B Value";
            this.copyBValueToolStripMenuItem.Click += new System.EventHandler(this.miCopyB_Click);
            // 
            // ilColors
            // 
            this.ilColors.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.ilColors.ImageSize = new System.Drawing.Size(16, 16);
            this.ilColors.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // lbInfo
            // 
            this.lbInfo.Location = new System.Drawing.Point(147, 236);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(257, 31);
            this.lbInfo.TabIndex = 12;
            this.lbInfo.Text = "Press Space to save the current color or Ctrl+C to copy directly as:";
            // 
            // rbRGB
            // 
            this.rbRGB.AutoSize = true;
            this.rbRGB.Location = new System.Drawing.Point(236, 248);
            this.rbRGB.Name = "rbRGB";
            this.rbRGB.Size = new System.Drawing.Size(48, 17);
            this.rbRGB.TabIndex = 13;
            this.rbRGB.Text = "RGB";
            this.rbRGB.UseVisualStyleBackColor = true;
            this.rbRGB.CheckedChanged += new System.EventHandler(this.rbRGB_CheckedChanged);
            // 
            // rbHEX
            // 
            this.rbHEX.AutoSize = true;
            this.rbHEX.Checked = true;
            this.rbHEX.Location = new System.Drawing.Point(290, 248);
            this.rbHEX.Name = "rbHEX";
            this.rbHEX.Size = new System.Drawing.Size(47, 17);
            this.rbHEX.TabIndex = 14;
            this.rbHEX.TabStop = true;
            this.rbHEX.Text = "HEX";
            this.rbHEX.UseVisualStyleBackColor = true;
            this.rbHEX.CheckedChanged += new System.EventHandler(this.rbHEX_CheckedChanged);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(147, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(257, 31);
            this.label4.TabIndex = 15;
            this.label4.Text = "Press Ctrl+L to copy the entire list to clipboard with values from:";
            // 
            // cbRGB
            // 
            this.cbRGB.AutoSize = true;
            this.cbRGB.Checked = true;
            this.cbRGB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbRGB.Location = new System.Drawing.Point(236, 284);
            this.cbRGB.Name = "cbRGB";
            this.cbRGB.Size = new System.Drawing.Size(49, 17);
            this.cbRGB.TabIndex = 16;
            this.cbRGB.Text = "RGB";
            this.cbRGB.UseVisualStyleBackColor = true;
            this.cbRGB.CheckedChanged += new System.EventHandler(this.cbRGB_CheckedChanged);
            // 
            // cbHEX
            // 
            this.cbHEX.AutoSize = true;
            this.cbHEX.Checked = true;
            this.cbHEX.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbHEX.Location = new System.Drawing.Point(290, 284);
            this.cbHEX.Name = "cbHEX";
            this.cbHEX.Size = new System.Drawing.Size(48, 17);
            this.cbHEX.TabIndex = 17;
            this.cbHEX.Text = "HEX";
            this.cbHEX.UseVisualStyleBackColor = true;
            this.cbHEX.CheckedChanged += new System.EventHandler(this.cbHEX_CheckedChanged);
            // 
            // copyValueMenuStrip
            // 
            this.copyValueMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem});
            this.copyValueMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.copyValueMenuStrip.Name = "copyValueMenuStrip";
            this.copyValueMenuStrip.Size = new System.Drawing.Size(416, 24);
            this.copyValueMenuStrip.TabIndex = 18;
            this.copyValueMenuStrip.Text = "menuStrip1";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyRGBToolStripMenuItem,
            this.copyRGBToolStripMenuItem1,
            this.copyRedValueToolStripMenuItem,
            this.copyGreenValueToolStripMenuItem,
            this.copyBlueValueToolStripMenuItem});
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.copyToolStripMenuItem.Text = "Copy";
            // 
            // copyRGBToolStripMenuItem
            // 
            this.copyRGBToolStripMenuItem.Name = "copyRGBToolStripMenuItem";
            this.copyRGBToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.copyRGBToolStripMenuItem.Text = "Hex Value";
            this.copyRGBToolStripMenuItem.Click += new System.EventHandler(this.miCopyHEX_Click);
            // 
            // copyRGBToolStripMenuItem1
            // 
            this.copyRGBToolStripMenuItem1.Name = "copyRGBToolStripMenuItem1";
            this.copyRGBToolStripMenuItem1.Size = new System.Drawing.Size(127, 22);
            this.copyRGBToolStripMenuItem1.Text = "RGB Value";
            this.copyRGBToolStripMenuItem1.Click += new System.EventHandler(this.miCopyRGB_Click);
            // 
            // copyRedValueToolStripMenuItem
            // 
            this.copyRedValueToolStripMenuItem.Name = "copyRedValueToolStripMenuItem";
            this.copyRedValueToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.copyRedValueToolStripMenuItem.Text = "R Value";
            this.copyRedValueToolStripMenuItem.Click += new System.EventHandler(this.miCopyR_Click);
            // 
            // copyGreenValueToolStripMenuItem
            // 
            this.copyGreenValueToolStripMenuItem.Name = "copyGreenValueToolStripMenuItem";
            this.copyGreenValueToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.copyGreenValueToolStripMenuItem.Text = "G Value";
            this.copyGreenValueToolStripMenuItem.Click += new System.EventHandler(this.miCopyG_Click);
            // 
            // copyBlueValueToolStripMenuItem
            // 
            this.copyBlueValueToolStripMenuItem.Name = "copyBlueValueToolStripMenuItem";
            this.copyBlueValueToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.copyBlueValueToolStripMenuItem.Text = "B Value";
            this.copyBlueValueToolStripMenuItem.Click += new System.EventHandler(this.miCopyB_Click);
            // 
            // lblUpdateSpeed
            // 
            this.lblUpdateSpeed.AutoSize = true;
            this.lblUpdateSpeed.Location = new System.Drawing.Point(38, 237);
            this.lblUpdateSpeed.Name = "lblUpdateSpeed";
            this.lblUpdateSpeed.Size = new System.Drawing.Size(76, 13);
            this.lblUpdateSpeed.TabIndex = 19;
            this.lblUpdateSpeed.Text = "Update Speed";
            // 
            // tbrUpdateSpeed
            // 
            this.tbrUpdateSpeed.LargeChange = 10;
            this.tbrUpdateSpeed.Location = new System.Drawing.Point(23, 255);
            this.tbrUpdateSpeed.Maximum = 99;
            this.tbrUpdateSpeed.Minimum = 1;
            this.tbrUpdateSpeed.Name = "tbrUpdateSpeed";
            this.tbrUpdateSpeed.Size = new System.Drawing.Size(104, 45);
            this.tbrUpdateSpeed.TabIndex = 20;
            this.tbrUpdateSpeed.TickFrequency = 10;
            this.tbrUpdateSpeed.Value = 1;
            this.tbrUpdateSpeed.Scroll += new System.EventHandler(this.tbrUpdateSpeed_Scroll);
            // 
            // lblSlow
            // 
            this.lblSlow.AutoSize = true;
            this.lblSlow.Location = new System.Drawing.Point(22, 284);
            this.lblSlow.Name = "lblSlow";
            this.lblSlow.Size = new System.Drawing.Size(30, 13);
            this.lblSlow.TabIndex = 21;
            this.lblSlow.Text = "Slow";
            // 
            // lblFast
            // 
            this.lblFast.AutoSize = true;
            this.lblFast.Location = new System.Drawing.Point(100, 284);
            this.lblFast.Name = "lblFast";
            this.lblFast.Size = new System.Drawing.Size(27, 13);
            this.lblFast.TabIndex = 22;
            this.lblFast.Text = "Fast";
            // 
            // fmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 305);
            this.Controls.Add(this.lblFast);
            this.Controls.Add(this.lblSlow);
            this.Controls.Add(this.tbrUpdateSpeed);
            this.Controls.Add(this.lblUpdateSpeed);
            this.Controls.Add(this.copyValueMenuStrip);
            this.Controls.Add(this.cbHEX);
            this.Controls.Add(this.cbRGB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rbHEX);
            this.Controls.Add(this.rbRGB);
            this.Controls.Add(this.lbInfo);
            this.Controls.Add(this.lvColors);
            this.Controls.Add(this.tbBlue);
            this.Controls.Add(this.tbGreen);
            this.Controls.Add(this.tbRed);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbColor);
            this.Controls.Add(this.pbArea);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.copyValueMenuStrip;
            this.MaximizeBox = false;
            this.Name = "fmMain";
            this.Text = "Digital Color Meter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fmMain_FormClosing);
            this.Load += new System.EventHandler(this.fmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbColor)).EndInit();
            this.copyValueContextMenuStrip.ResumeLayout(false);
            this.copyValueMenuStrip.ResumeLayout(false);
            this.copyValueMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbrUpdateSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbArea;
        private System.Windows.Forms.PictureBox pbColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer trRefresh;
        private System.Windows.Forms.TextBox tbRed;
        private System.Windows.Forms.TextBox tbGreen;
        private System.Windows.Forms.TextBox tbBlue;
        private System.Windows.Forms.ListView lvColors;
		private System.Windows.Forms.ColumnHeader chColor;
        private System.Windows.Forms.ColumnHeader chRGB;
        private System.Windows.Forms.Label lbInfo;
        private System.Windows.Forms.ImageList ilColors;
		private System.Windows.Forms.RadioButton rbRGB;
		private System.Windows.Forms.RadioButton rbHEX;
		private System.Windows.Forms.ColumnHeader chHEX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cbRGB;
        private System.Windows.Forms.CheckBox cbHEX;
        private System.Windows.Forms.MenuStrip copyValueMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyRGBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyRGBToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem copyRedValueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyBlueValueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyGreenValueToolStripMenuItem;
        private System.Windows.Forms.Label lblUpdateSpeed;
        private System.Windows.Forms.TrackBar tbrUpdateSpeed;
        private System.Windows.Forms.Label lblSlow;
        private System.Windows.Forms.Label lblFast;
        private System.Windows.Forms.ContextMenuStrip copyValueContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem copyHexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyRGBValueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyRValueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyGValueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyBValueToolStripMenuItem;
    }
}