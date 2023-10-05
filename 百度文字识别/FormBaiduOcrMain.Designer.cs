
namespace 百度文字识别
{
    partial class FormBaiduOcrMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.contextMenuStripImgPaste = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.粘贴ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBoxShow = new System.Windows.Forms.PictureBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.richTextBoxImgText = new System.Windows.Forms.RichTextBox();
            this.buttonCopyWords = new System.Windows.Forms.Button();
            this.labelWord = new System.Windows.Forms.Label();
            this.buttonGetImgText = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.设置百度ApiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.contextMenuStripImgPaste.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.splitContainer1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(800, 425);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(800, 450);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.menuStrip1);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.ContextMenuStrip = this.contextMenuStripImgPaste;
            this.splitContainer1.Panel1.Controls.Add(this.pictureBoxShow);
            this.splitContainer1.Panel1.Resize += new System.EventHandler(this.splitContainer1_Panel1_Resize);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(800, 425);
            this.splitContainer1.SplitterDistance = 490;
            this.splitContainer1.TabIndex = 0;
            // 
            // contextMenuStripImgPaste
            // 
            this.contextMenuStripImgPaste.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.粘贴ToolStripMenuItem});
            this.contextMenuStripImgPaste.Name = "contextMenuStripImgPaste";
            this.contextMenuStripImgPaste.Size = new System.Drawing.Size(125, 26);
            // 
            // 粘贴ToolStripMenuItem
            // 
            this.粘贴ToolStripMenuItem.Name = "粘贴ToolStripMenuItem";
            this.粘贴ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.粘贴ToolStripMenuItem.Text = "图像粘贴";
            this.粘贴ToolStripMenuItem.Click += new System.EventHandler(this.粘贴ToolStripMenuItem_Click);
            // 
            // pictureBoxShow
            // 
            this.pictureBoxShow.ContextMenuStrip = this.contextMenuStripImgPaste;
            this.pictureBoxShow.Location = new System.Drawing.Point(12, 3);
            this.pictureBoxShow.Name = "pictureBoxShow";
            this.pictureBoxShow.Size = new System.Drawing.Size(400, 400);
            this.pictureBoxShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxShow.TabIndex = 0;
            this.pictureBoxShow.TabStop = false;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.richTextBoxImgText);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.buttonCopyWords);
            this.splitContainer2.Panel2.Controls.Add(this.labelWord);
            this.splitContainer2.Panel2.Controls.Add(this.buttonGetImgText);
            this.splitContainer2.Size = new System.Drawing.Size(306, 425);
            this.splitContainer2.SplitterDistance = 321;
            this.splitContainer2.TabIndex = 0;
            // 
            // richTextBoxImgText
            // 
            this.richTextBoxImgText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxImgText.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxImgText.Name = "richTextBoxImgText";
            this.richTextBoxImgText.ReadOnly = true;
            this.richTextBoxImgText.Size = new System.Drawing.Size(306, 321);
            this.richTextBoxImgText.TabIndex = 0;
            this.richTextBoxImgText.Text = "";
            // 
            // buttonCopyWords
            // 
            this.buttonCopyWords.Enabled = false;
            this.buttonCopyWords.Location = new System.Drawing.Point(172, 49);
            this.buttonCopyWords.Name = "buttonCopyWords";
            this.buttonCopyWords.Size = new System.Drawing.Size(91, 29);
            this.buttonCopyWords.TabIndex = 2;
            this.buttonCopyWords.Text = "复制图片内容";
            this.buttonCopyWords.UseVisualStyleBackColor = true;
            this.buttonCopyWords.Click += new System.EventHandler(this.buttonCopyWords_Click);
            // 
            // labelWord
            // 
            this.labelWord.AutoSize = true;
            this.labelWord.ForeColor = System.Drawing.Color.Red;
            this.labelWord.Location = new System.Drawing.Point(32, 15);
            this.labelWord.Name = "labelWord";
            this.labelWord.Size = new System.Drawing.Size(0, 12);
            this.labelWord.TabIndex = 1;
            // 
            // buttonGetImgText
            // 
            this.buttonGetImgText.Location = new System.Drawing.Point(35, 49);
            this.buttonGetImgText.Name = "buttonGetImgText";
            this.buttonGetImgText.Size = new System.Drawing.Size(91, 29);
            this.buttonGetImgText.TabIndex = 0;
            this.buttonGetImgText.Text = "获取图片内容";
            this.buttonGetImgText.UseVisualStyleBackColor = true;
            this.buttonGetImgText.Click += new System.EventHandler(this.buttonGetImgText_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.设置百度ApiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 设置百度ApiToolStripMenuItem
            // 
            this.设置百度ApiToolStripMenuItem.Name = "设置百度ApiToolStripMenuItem";
            this.设置百度ApiToolStripMenuItem.Size = new System.Drawing.Size(87, 21);
            this.设置百度ApiToolStripMenuItem.Text = "设置百度API";
            this.设置百度ApiToolStripMenuItem.Click += new System.EventHandler(this.设置百度ApiToolStripMenuItem_Click);
            // 
            // FormBaiduOcrMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ContextMenuStrip = this.contextMenuStripImgPaste;
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "FormBaiduOcrMain";
            this.Text = "百度文字识别";
            this.Load += new System.EventHandler(this.FormBaiduOcrMain_Load);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.contextMenuStripImgPaste.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShow)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 设置百度ApiToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripImgPaste;
        private System.Windows.Forms.ToolStripMenuItem 粘贴ToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.RichTextBox richTextBoxImgText;
        private System.Windows.Forms.PictureBox pictureBoxShow;
        private System.Windows.Forms.Button buttonGetImgText;
        private System.Windows.Forms.Label labelWord;
        private System.Windows.Forms.Button buttonCopyWords;
    }
}

