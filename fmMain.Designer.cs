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
			this.cmColorsPopup = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.miCopyRGB = new System.Windows.Forms.ToolStripMenuItem();
			this.miCopyR = new System.Windows.Forms.ToolStripMenuItem();
			this.miCopyG = new System.Windows.Forms.ToolStripMenuItem();
			this.miCopyB = new System.Windows.Forms.ToolStripMenuItem();
			this.ilColors = new System.Windows.Forms.ImageList(this.components);
			this.lbInfo = new System.Windows.Forms.Label();
			this.rbRGB = new System.Windows.Forms.RadioButton();
			this.rbHEX = new System.Windows.Forms.RadioButton();
			this.chHEX = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.miCopyHEX = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			((System.ComponentModel.ISupportInitialize)(this.pbArea)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbColor)).BeginInit();
			this.cmColorsPopup.SuspendLayout();
			this.SuspendLayout();
			// 
			// pbArea
			// 
			this.pbArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pbArea.Location = new System.Drawing.Point(12, 12);
			this.pbArea.Name = "pbArea";
			this.pbArea.Size = new System.Drawing.Size(132, 132);
			this.pbArea.TabIndex = 0;
			this.pbArea.TabStop = false;
			// 
			// pbColor
			// 
			this.pbColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pbColor.Location = new System.Drawing.Point(12, 150);
			this.pbColor.Name = "pbColor";
			this.pbColor.Size = new System.Drawing.Size(46, 62);
			this.pbColor.TabIndex = 1;
			this.pbColor.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(64, 153);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(15, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "R";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(64, 174);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(15, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "G";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(64, 195);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(14, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "B";
			// 
			// trRefresh
			// 
			this.trRefresh.Enabled = true;
			this.trRefresh.Tick += new System.EventHandler(this.trRefresh_Tick);
			// 
			// tbRed
			// 
			this.tbRed.Location = new System.Drawing.Point(85, 150);
			this.tbRed.Name = "tbRed";
			this.tbRed.ReadOnly = true;
			this.tbRed.Size = new System.Drawing.Size(59, 20);
			this.tbRed.TabIndex = 8;
			// 
			// tbGreen
			// 
			this.tbGreen.Location = new System.Drawing.Point(85, 171);
			this.tbGreen.Name = "tbGreen";
			this.tbGreen.ReadOnly = true;
			this.tbGreen.Size = new System.Drawing.Size(59, 20);
			this.tbGreen.TabIndex = 9;
			// 
			// tbBlue
			// 
			this.tbBlue.Location = new System.Drawing.Point(85, 192);
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
			this.lvColors.ContextMenuStrip = this.cmColorsPopup;
			this.lvColors.FullRowSelect = true;
			this.lvColors.LargeImageList = this.ilColors;
			this.lvColors.Location = new System.Drawing.Point(150, 12);
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
			// cmColorsPopup
			// 
			this.cmColorsPopup.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miCopyHEX,
            this.miCopyRGB,
            this.toolStripSeparator1,
            this.miCopyR,
            this.miCopyG,
            this.miCopyB});
			this.cmColorsPopup.Name = "cmColorsPopup";
			this.cmColorsPopup.Size = new System.Drawing.Size(153, 142);
			// 
			// miCopyRGB
			// 
			this.miCopyRGB.Name = "miCopyRGB";
			this.miCopyRGB.Size = new System.Drawing.Size(152, 22);
			this.miCopyRGB.Text = "Copy RGB";
			this.miCopyRGB.Click += new System.EventHandler(this.miCopyRGB_Click);
			// 
			// miCopyR
			// 
			this.miCopyR.Name = "miCopyR";
			this.miCopyR.Size = new System.Drawing.Size(152, 22);
			this.miCopyR.Text = "Copy Red";
			this.miCopyR.Click += new System.EventHandler(this.miCopyR_Click);
			// 
			// miCopyG
			// 
			this.miCopyG.Name = "miCopyG";
			this.miCopyG.Size = new System.Drawing.Size(152, 22);
			this.miCopyG.Text = "Copy Green";
			this.miCopyG.Click += new System.EventHandler(this.miCopyG_Click);
			// 
			// miCopyB
			// 
			this.miCopyB.Name = "miCopyB";
			this.miCopyB.Size = new System.Drawing.Size(152, 22);
			this.miCopyB.Text = "Copy Blue";
			this.miCopyB.Click += new System.EventHandler(this.miCopyB_Click);
			// 
			// ilColors
			// 
			this.ilColors.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.ilColors.ImageSize = new System.Drawing.Size(16, 16);
			this.ilColors.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// lbInfo
			// 
			this.lbInfo.Location = new System.Drawing.Point(147, 215);
			this.lbInfo.Name = "lbInfo";
			this.lbInfo.Size = new System.Drawing.Size(257, 31);
			this.lbInfo.TabIndex = 12;
			this.lbInfo.Text = "Press Space to save the current color or Ctrl+C to copy directly as:";
			// 
			// rbRGB
			// 
			this.rbRGB.AutoSize = true;
			this.rbRGB.Location = new System.Drawing.Point(236, 227);
			this.rbRGB.Name = "rbRGB";
			this.rbRGB.Size = new System.Drawing.Size(48, 17);
			this.rbRGB.TabIndex = 13;
			this.rbRGB.Text = "RGB";
			this.rbRGB.UseVisualStyleBackColor = true;
			// 
			// rbHEX
			// 
			this.rbHEX.AutoSize = true;
			this.rbHEX.Checked = true;
			this.rbHEX.Location = new System.Drawing.Point(290, 227);
			this.rbHEX.Name = "rbHEX";
			this.rbHEX.Size = new System.Drawing.Size(47, 17);
			this.rbHEX.TabIndex = 14;
			this.rbHEX.TabStop = true;
			this.rbHEX.Text = "HEX";
			this.rbHEX.UseVisualStyleBackColor = true;
			// 
			// chHEX
			// 
			this.chHEX.Text = "HEX";
			this.chHEX.Width = 80;
			// 
			// miCopyHEX
			// 
			this.miCopyHEX.Name = "miCopyHEX";
			this.miCopyHEX.Size = new System.Drawing.Size(152, 22);
			this.miCopyHEX.Text = "Copy HEX";
			this.miCopyHEX.Click += new System.EventHandler(this.miCopyHEX_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
			// 
			// fmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(416, 252);
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
			this.MaximizeBox = false;
			this.Name = "fmMain";
			this.Text = "Digital Color Meter";
			this.Load += new System.EventHandler(this.fmMain_Load);
			((System.ComponentModel.ISupportInitialize)(this.pbArea)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbColor)).EndInit();
			this.cmColorsPopup.ResumeLayout(false);
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
        private System.Windows.Forms.ContextMenuStrip cmColorsPopup;
        private System.Windows.Forms.ToolStripMenuItem miCopyRGB;
        private System.Windows.Forms.ToolStripMenuItem miCopyR;
        private System.Windows.Forms.ToolStripMenuItem miCopyG;
        private System.Windows.Forms.ToolStripMenuItem miCopyB;
        private System.Windows.Forms.ImageList ilColors;
		private System.Windows.Forms.RadioButton rbRGB;
		private System.Windows.Forms.RadioButton rbHEX;
		private System.Windows.Forms.ColumnHeader chHEX;
		private System.Windows.Forms.ToolStripMenuItem miCopyHEX;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}