
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
            components = new System.ComponentModel.Container();
            toolStripContainer1 = new ToolStripContainer();
            splitContainer1 = new SplitContainer();
            contextMenuStripImgPaste = new ContextMenuStrip(components);
            粘贴ToolStripMenuItem = new ToolStripMenuItem();
            pictureBoxShow = new PictureBox();
            splitContainer2 = new SplitContainer();
            richTextBoxImgText = new RichTextBox();
            buttonCopyWords = new Button();
            labelWord = new Label();
            buttonGetImgText = new Button();
            menuStrip1 = new MenuStrip();
            设置百度ApiToolStripMenuItem = new ToolStripMenuItem();
            buttonClear = new Button();
            toolStripContainer1.ContentPanel.SuspendLayout();
            toolStripContainer1.TopToolStripPanel.SuspendLayout();
            toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            contextMenuStripImgPaste.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxShow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            toolStripContainer1.ContentPanel.Controls.Add(splitContainer1);
            toolStripContainer1.ContentPanel.Margin = new Padding(4, 4, 4, 4);
            toolStripContainer1.ContentPanel.Size = new Size(933, 613);
            toolStripContainer1.Dock = DockStyle.Fill;
            toolStripContainer1.Location = new Point(0, 0);
            toolStripContainer1.Margin = new Padding(4, 4, 4, 4);
            toolStripContainer1.Name = "toolStripContainer1";
            toolStripContainer1.Size = new Size(933, 638);
            toolStripContainer1.TabIndex = 0;
            toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            toolStripContainer1.TopToolStripPanel.Controls.Add(menuStrip1);
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Margin = new Padding(4, 4, 4, 4);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.AutoScroll = true;
            splitContainer1.Panel1.ContextMenuStrip = contextMenuStripImgPaste;
            splitContainer1.Panel1.Controls.Add(pictureBoxShow);
            splitContainer1.Panel1.Resize += splitContainer1_Panel1_Resize;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Size = new Size(933, 613);
            splitContainer1.SplitterDistance = 571;
            splitContainer1.SplitterWidth = 5;
            splitContainer1.TabIndex = 0;
            // 
            // contextMenuStripImgPaste
            // 
            contextMenuStripImgPaste.Items.AddRange(new ToolStripItem[] { 粘贴ToolStripMenuItem });
            contextMenuStripImgPaste.Name = "contextMenuStripImgPaste";
            contextMenuStripImgPaste.Size = new Size(125, 26);
            // 
            // 粘贴ToolStripMenuItem
            // 
            粘贴ToolStripMenuItem.Name = "粘贴ToolStripMenuItem";
            粘贴ToolStripMenuItem.Size = new Size(124, 22);
            粘贴ToolStripMenuItem.Text = "图像粘贴";
            粘贴ToolStripMenuItem.Click += 粘贴ToolStripMenuItem_Click;
            // 
            // pictureBoxShow
            // 
            pictureBoxShow.ContextMenuStrip = contextMenuStripImgPaste;
            pictureBoxShow.Location = new Point(14, 4);
            pictureBoxShow.Margin = new Padding(4, 4, 4, 4);
            pictureBoxShow.Name = "pictureBoxShow";
            pictureBoxShow.Size = new Size(400, 400);
            pictureBoxShow.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxShow.TabIndex = 0;
            pictureBoxShow.TabStop = false;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Margin = new Padding(4, 4, 4, 4);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(richTextBoxImgText);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(buttonClear);
            splitContainer2.Panel2.Controls.Add(buttonCopyWords);
            splitContainer2.Panel2.Controls.Add(labelWord);
            splitContainer2.Panel2.Controls.Add(buttonGetImgText);
            splitContainer2.Size = new Size(357, 613);
            splitContainer2.SplitterDistance = 462;
            splitContainer2.SplitterWidth = 6;
            splitContainer2.TabIndex = 0;
            // 
            // richTextBoxImgText
            // 
            richTextBoxImgText.Dock = DockStyle.Fill;
            richTextBoxImgText.Location = new Point(0, 0);
            richTextBoxImgText.Margin = new Padding(4, 4, 4, 4);
            richTextBoxImgText.Name = "richTextBoxImgText";
            richTextBoxImgText.ReadOnly = true;
            richTextBoxImgText.Size = new Size(357, 462);
            richTextBoxImgText.TabIndex = 0;
            richTextBoxImgText.Text = "";
            // 
            // buttonCopyWords
            // 
            buttonCopyWords.Enabled = false;
            buttonCopyWords.Location = new Point(132, 69);
            buttonCopyWords.Margin = new Padding(4, 4, 4, 4);
            buttonCopyWords.Name = "buttonCopyWords";
            buttonCopyWords.Size = new Size(97, 41);
            buttonCopyWords.TabIndex = 2;
            buttonCopyWords.Text = "复制图片内容";
            buttonCopyWords.UseVisualStyleBackColor = true;
            buttonCopyWords.Click += buttonCopyWords_Click;
            // 
            // labelWord
            // 
            labelWord.AutoSize = true;
            labelWord.ForeColor = Color.Red;
            labelWord.Location = new Point(37, 21);
            labelWord.Margin = new Padding(4, 0, 4, 0);
            labelWord.Name = "labelWord";
            labelWord.Size = new Size(0, 17);
            labelWord.TabIndex = 1;
            // 
            // buttonGetImgText
            // 
            buttonGetImgText.Location = new Point(13, 69);
            buttonGetImgText.Margin = new Padding(4, 4, 4, 4);
            buttonGetImgText.Name = "buttonGetImgText";
            buttonGetImgText.Size = new Size(97, 41);
            buttonGetImgText.TabIndex = 0;
            buttonGetImgText.Text = "获取图片内容";
            buttonGetImgText.UseVisualStyleBackColor = true;
            buttonGetImgText.Click += buttonGetImgText_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.Items.AddRange(new ToolStripItem[] { 设置百度ApiToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(933, 25);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // 设置百度ApiToolStripMenuItem
            // 
            设置百度ApiToolStripMenuItem.Name = "设置百度ApiToolStripMenuItem";
            设置百度ApiToolStripMenuItem.Size = new Size(87, 21);
            设置百度ApiToolStripMenuItem.Text = "设置百度API";
            设置百度ApiToolStripMenuItem.Click += 设置百度ApiToolStripMenuItem_Click;
            // 
            // buttonClear
            // 
            buttonClear.Enabled = false;
            buttonClear.Location = new Point(247, 69);
            buttonClear.Margin = new Padding(4);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(97, 41);
            buttonClear.TabIndex = 3;
            buttonClear.Text = "清除";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // FormBaiduOcrMain
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 638);
            ContextMenuStrip = contextMenuStripImgPaste;
            Controls.Add(toolStripContainer1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "FormBaiduOcrMain";
            Text = "百度文字识别";
            Load += FormBaiduOcrMain_Load;
            toolStripContainer1.ContentPanel.ResumeLayout(false);
            toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            toolStripContainer1.TopToolStripPanel.PerformLayout();
            toolStripContainer1.ResumeLayout(false);
            toolStripContainer1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            contextMenuStripImgPaste.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxShow).EndInit();
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
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
        private Button buttonClear;
    }
}

