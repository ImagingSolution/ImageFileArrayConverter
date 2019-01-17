namespace ImageFileArrayConverter
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBgr101010Bmp = new System.Windows.Forms.Button();
            this.btnBgr101010Tif = new System.Windows.Forms.Button();
            this.btnBgr101010Png = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGray16Bmp = new System.Windows.Forms.Button();
            this.btnGray16Tif = new System.Windows.Forms.Button();
            this.btnGray16Png = new System.Windows.Forms.Button();
            this.btnRgb48Bmp = new System.Windows.Forms.Button();
            this.btnRgb48Tif = new System.Windows.Forms.Button();
            this.btnRgb48Png = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(420, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileOpen,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(51, 20);
            this.mnuFile.Text = "File(&F)";
            // 
            // mnuFileOpen
            // 
            this.mnuFileOpen.Name = "mnuFileOpen";
            this.mnuFileOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.mnuFileOpen.Size = new System.Drawing.Size(152, 22);
            this.mnuFileOpen.Text = "Open";
            this.mnuFileOpen.Click += new System.EventHandler(this.mnuFileOpen_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // btnBgr101010Bmp
            // 
            this.btnBgr101010Bmp.Location = new System.Drawing.Point(14, 53);
            this.btnBgr101010Bmp.Name = "btnBgr101010Bmp";
            this.btnBgr101010Bmp.Size = new System.Drawing.Size(129, 33);
            this.btnBgr101010Bmp.TabIndex = 1;
            this.btnBgr101010Bmp.Text = "Bgr101010.bmp";
            this.btnBgr101010Bmp.UseVisualStyleBackColor = true;
            this.btnBgr101010Bmp.Click += new System.EventHandler(this.btnBgr101010Bmp_Click);
            // 
            // btnBgr101010Tif
            // 
            this.btnBgr101010Tif.Location = new System.Drawing.Point(149, 53);
            this.btnBgr101010Tif.Name = "btnBgr101010Tif";
            this.btnBgr101010Tif.Size = new System.Drawing.Size(129, 33);
            this.btnBgr101010Tif.TabIndex = 2;
            this.btnBgr101010Tif.Text = "Bgr101010.tif";
            this.btnBgr101010Tif.UseVisualStyleBackColor = true;
            this.btnBgr101010Tif.Click += new System.EventHandler(this.btnBgr101010Tif_Click);
            // 
            // btnBgr101010Png
            // 
            this.btnBgr101010Png.Location = new System.Drawing.Point(284, 53);
            this.btnBgr101010Png.Name = "btnBgr101010Png";
            this.btnBgr101010Png.Size = new System.Drawing.Size(129, 33);
            this.btnBgr101010Png.TabIndex = 3;
            this.btnBgr101010Png.Text = "Bgr101010.png";
            this.btnBgr101010Png.UseVisualStyleBackColor = true;
            this.btnBgr101010Png.Click += new System.EventHandler(this.btnBgr101010Png_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(14, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "画像ファイル作成";
            // 
            // btnGray16Bmp
            // 
            this.btnGray16Bmp.Location = new System.Drawing.Point(14, 92);
            this.btnGray16Bmp.Name = "btnGray16Bmp";
            this.btnGray16Bmp.Size = new System.Drawing.Size(129, 33);
            this.btnGray16Bmp.TabIndex = 1;
            this.btnGray16Bmp.Text = "Gray16.bmp";
            this.btnGray16Bmp.UseVisualStyleBackColor = true;
            this.btnGray16Bmp.Click += new System.EventHandler(this.btnGray16Bmp_Click);
            // 
            // btnGray16Tif
            // 
            this.btnGray16Tif.Location = new System.Drawing.Point(149, 92);
            this.btnGray16Tif.Name = "btnGray16Tif";
            this.btnGray16Tif.Size = new System.Drawing.Size(129, 33);
            this.btnGray16Tif.TabIndex = 1;
            this.btnGray16Tif.Text = "Gray16.tif";
            this.btnGray16Tif.UseVisualStyleBackColor = true;
            this.btnGray16Tif.Click += new System.EventHandler(this.btnGray16Tif_Click);
            // 
            // btnGray16Png
            // 
            this.btnGray16Png.Location = new System.Drawing.Point(284, 92);
            this.btnGray16Png.Name = "btnGray16Png";
            this.btnGray16Png.Size = new System.Drawing.Size(129, 33);
            this.btnGray16Png.TabIndex = 1;
            this.btnGray16Png.Text = "Gray16.png";
            this.btnGray16Png.UseVisualStyleBackColor = true;
            this.btnGray16Png.Click += new System.EventHandler(this.btnGray16Png_Click);
            // 
            // btnRgb48Bmp
            // 
            this.btnRgb48Bmp.Location = new System.Drawing.Point(14, 131);
            this.btnRgb48Bmp.Name = "btnRgb48Bmp";
            this.btnRgb48Bmp.Size = new System.Drawing.Size(129, 33);
            this.btnRgb48Bmp.TabIndex = 5;
            this.btnRgb48Bmp.Text = "Rgb48.bmp";
            this.btnRgb48Bmp.UseVisualStyleBackColor = true;
            this.btnRgb48Bmp.Click += new System.EventHandler(this.btnRgb48Bmp_Click);
            // 
            // btnRgb48Tif
            // 
            this.btnRgb48Tif.Location = new System.Drawing.Point(149, 131);
            this.btnRgb48Tif.Name = "btnRgb48Tif";
            this.btnRgb48Tif.Size = new System.Drawing.Size(129, 33);
            this.btnRgb48Tif.TabIndex = 6;
            this.btnRgb48Tif.Text = "Rgb48.tif";
            this.btnRgb48Tif.UseVisualStyleBackColor = true;
            this.btnRgb48Tif.Click += new System.EventHandler(this.btnRgb48Tif_Click);
            // 
            // btnRgb48Png
            // 
            this.btnRgb48Png.Location = new System.Drawing.Point(284, 131);
            this.btnRgb48Png.Name = "btnRgb48Png";
            this.btnRgb48Png.Size = new System.Drawing.Size(129, 33);
            this.btnRgb48Png.TabIndex = 7;
            this.btnRgb48Png.Text = "Rgb48.png";
            this.btnRgb48Png.UseVisualStyleBackColor = true;
            this.btnRgb48Png.Click += new System.EventHandler(this.btnRgb48Png_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 170);
            this.Controls.Add(this.btnRgb48Png);
            this.Controls.Add(this.btnRgb48Tif);
            this.Controls.Add(this.btnRgb48Bmp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBgr101010Png);
            this.Controls.Add(this.btnGray16Png);
            this.Controls.Add(this.btnGray16Tif);
            this.Controls.Add(this.btnGray16Bmp);
            this.Controls.Add(this.btnBgr101010Tif);
            this.Controls.Add(this.btnBgr101010Bmp);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuFileOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button btnBgr101010Bmp;
        private System.Windows.Forms.Button btnBgr101010Tif;
        private System.Windows.Forms.Button btnBgr101010Png;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGray16Bmp;
        private System.Windows.Forms.Button btnGray16Tif;
        private System.Windows.Forms.Button btnGray16Png;
        private System.Windows.Forms.Button btnRgb48Bmp;
        private System.Windows.Forms.Button btnRgb48Tif;
        private System.Windows.Forms.Button btnRgb48Png;
    }
}

