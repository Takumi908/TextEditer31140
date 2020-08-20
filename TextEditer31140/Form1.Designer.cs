namespace TextEditer31140
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
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            this.ofdFileOpeen = new System.Windows.Forms.OpenFileDialog();
            this.sfdFileSave = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.保存AltF4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OopenOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveNameAToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.編集EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.文字コードCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ヘルプHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rtTextArea = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ofdFileOpeen
            // 
            this.ofdFileOpeen.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.保存AltF4ToolStripMenuItem,
            this.編集EToolStripMenuItem,
            this.文字コードCToolStripMenuItem,
            this.ヘルプHToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 保存AltF4ToolStripMenuItem
            // 
            this.保存AltF4ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewNToolStripMenuItem,
            this.OopenOToolStripMenuItem,
            this.SaveAToolStripMenuItem,
            this.SaveNameAToolStripMenuItem1,
            this.toolStripSeparator1,
            this.ExitXToolStripMenuItem});
            this.保存AltF4ToolStripMenuItem.Name = "保存AltF4ToolStripMenuItem";
            this.保存AltF4ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.保存AltF4ToolStripMenuItem.Text = "ファイル(&F)";
            // 
            // NewNToolStripMenuItem
            // 
            this.NewNToolStripMenuItem.Name = "NewNToolStripMenuItem";
            this.NewNToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.NewNToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.NewNToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.NewNToolStripMenuItem.Text = "新規作成(&N)";
            // 
            // OopenOToolStripMenuItem
            // 
            this.OopenOToolStripMenuItem.Name = "OopenOToolStripMenuItem";
            this.OopenOToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.OopenOToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.OopenOToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.OopenOToolStripMenuItem.Text = "開く&O...)";
            this.OopenOToolStripMenuItem.Click += new System.EventHandler(this.OopenOToolStripMenuItem_Click);
            // 
            // SaveAToolStripMenuItem
            // 
            this.SaveAToolStripMenuItem.Name = "SaveAToolStripMenuItem";
            this.SaveAToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.SaveAToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.SaveAToolStripMenuItem.Text = "上書き保存(&S)";
            // 
            // SaveNameAToolStripMenuItem1
            // 
            this.SaveNameAToolStripMenuItem1.Name = "SaveNameAToolStripMenuItem1";
            this.SaveNameAToolStripMenuItem1.Size = new System.Drawing.Size(186, 22);
            this.SaveNameAToolStripMenuItem1.Text = "名前を付けて保存(&A...)";
            this.SaveNameAToolStripMenuItem1.Click += new System.EventHandler(this.SaveNameAToolStripMenuItem1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(183, 6);
            // 
            // ExitXToolStripMenuItem
            // 
            this.ExitXToolStripMenuItem.Name = "ExitXToolStripMenuItem";
            this.ExitXToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.ExitXToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.ExitXToolStripMenuItem.Text = "終了(&X)";
            this.ExitXToolStripMenuItem.Click += new System.EventHandler(this.ExitXToolStripMenuItem_Click);
            // 
            // 編集EToolStripMenuItem
            // 
            this.編集EToolStripMenuItem.Name = "編集EToolStripMenuItem";
            this.編集EToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.編集EToolStripMenuItem.Text = "編集(&E)";
            // 
            // 文字コードCToolStripMenuItem
            // 
            this.文字コードCToolStripMenuItem.Name = "文字コードCToolStripMenuItem";
            this.文字コードCToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.文字コードCToolStripMenuItem.Text = "文字コード(&C)";
            // 
            // ヘルプHToolStripMenuItem
            // 
            this.ヘルプHToolStripMenuItem.Name = "ヘルプHToolStripMenuItem";
            this.ヘルプHToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.ヘルプHToolStripMenuItem.Text = "ヘルプ(&H)";
            // 
            // rtTextArea
            // 
            this.rtTextArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtTextArea.Location = new System.Drawing.Point(0, 24);
            this.rtTextArea.Name = "rtTextArea";
            this.rtTextArea.Size = new System.Drawing.Size(800, 426);
            this.rtTextArea.TabIndex = 1;
            this.rtTextArea.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtTextArea);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "テキストエディタ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ofdFileOpeen;
        private System.Windows.Forms.SaveFileDialog sfdFileSave;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 保存AltF4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OopenOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveNameAToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ExitXToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 編集EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 文字コードCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ヘルプHToolStripMenuItem;
        private System.Windows.Forms.RichTextBox rtTextArea;
    }
}

