
namespace 百度文字识别
{
    partial class FormSettingsToPropertyGrid
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
            this.tableLayoutPanelInputs = new System.Windows.Forms.TableLayoutPanel();
            this.buttonReload = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.panelInputText = new System.Windows.Forms.Panel();
            this.propertyGridMain = new System.Windows.Forms.PropertyGrid();
            this.tableLayoutPanelInputs.SuspendLayout();
            this.panelInputText.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelInputs
            // 
            this.tableLayoutPanelInputs.AutoSize = true;
            this.tableLayoutPanelInputs.ColumnCount = 2;
            this.tableLayoutPanelInputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelInputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelInputs.Controls.Add(this.buttonReload, 1, 1);
            this.tableLayoutPanelInputs.Controls.Add(this.buttonSave, 0, 1);
            this.tableLayoutPanelInputs.Controls.Add(this.panelInputText, 0, 0);
            this.tableLayoutPanelInputs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelInputs.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelInputs.Name = "tableLayoutPanelInputs";
            this.tableLayoutPanelInputs.RowCount = 2;
            this.tableLayoutPanelInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelInputs.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelInputs.Size = new System.Drawing.Size(584, 361);
            this.tableLayoutPanelInputs.TabIndex = 0;
            // 
            // buttonReload
            // 
            this.buttonReload.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonReload.Location = new System.Drawing.Point(381, 290);
            this.buttonReload.Name = "buttonReload";
            this.buttonReload.Size = new System.Drawing.Size(113, 68);
            this.buttonReload.TabIndex = 3;
            this.buttonReload.Text = "重置";
            this.buttonReload.UseVisualStyleBackColor = true;
            this.buttonReload.Click += new System.EventHandler(this.buttonReload_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSave.Location = new System.Drawing.Point(89, 290);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(113, 68);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "保存";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // panelInputText
            // 
            this.panelInputText.AutoScroll = true;
            this.tableLayoutPanelInputs.SetColumnSpan(this.panelInputText, 2);
            this.panelInputText.Controls.Add(this.propertyGridMain);
            this.panelInputText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInputText.Location = new System.Drawing.Point(3, 3);
            this.panelInputText.Name = "panelInputText";
            this.panelInputText.Size = new System.Drawing.Size(578, 281);
            this.panelInputText.TabIndex = 1;
            // 
            // propertyGridMain
            // 
            this.propertyGridMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGridMain.Location = new System.Drawing.Point(0, 0);
            this.propertyGridMain.Name = "propertyGridMain";
            this.propertyGridMain.Size = new System.Drawing.Size(578, 281);
            this.propertyGridMain.TabIndex = 0;
            // 
            // CkFormSettingsToPropertyGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.tableLayoutPanelInputs);
            this.Name = "CkFormSettingsToPropertyGrid";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "设置";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CkFormSettingsToPropertyGrid_FormClosing);
            this.Load += new System.EventHandler(this.CkFormSimpleSettings_Load);
            this.tableLayoutPanelInputs.ResumeLayout(false);
            this.panelInputText.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelInputs;
        private System.Windows.Forms.Panel panelInputText;
        private System.Windows.Forms.Button buttonReload;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.PropertyGrid propertyGridMain;
    }
}