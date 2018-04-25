namespace Ksu.Cis300.NetworkFlow
{
    partial class UserInterface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserInterface));
            this.uxToolStrip = new System.Windows.Forms.ToolStrip();
            this.uxOpenFile = new System.Windows.Forms.ToolStripButton();
            this.uxSaveFile = new System.Windows.Forms.ToolStripButton();
            this.uxTextBox = new System.Windows.Forms.TextBox();
            this.uxLabel = new System.Windows.Forms.Label();
            this.uxOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.uxSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.uxToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // uxToolStrip
            // 
            this.uxToolStrip.AutoSize = false;
            this.uxToolStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.uxToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uxOpenFile,
            this.uxSaveFile});
            this.uxToolStrip.Location = new System.Drawing.Point(0, 0);
            this.uxToolStrip.Name = "uxToolStrip";
            this.uxToolStrip.Size = new System.Drawing.Size(501, 64);
            this.uxToolStrip.TabIndex = 0;
            this.uxToolStrip.Text = "toolStrip1";
            // 
            // uxOpenFile
            // 
            this.uxOpenFile.AutoSize = false;
            this.uxOpenFile.AutoToolTip = false;
            this.uxOpenFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.uxOpenFile.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.uxOpenFile.Image = ((System.Drawing.Image)(resources.GetObject("uxOpenFile.Image")));
            this.uxOpenFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.uxOpenFile.Name = "uxOpenFile";
            this.uxOpenFile.Size = new System.Drawing.Size(100, 36);
            this.uxOpenFile.Text = "Open File";
            this.uxOpenFile.Click += new System.EventHandler(this.uxOpenFile_Click);
            // 
            // uxSaveFile
            // 
            this.uxSaveFile.AutoSize = false;
            this.uxSaveFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.uxSaveFile.Enabled = false;
            this.uxSaveFile.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.uxSaveFile.Image = ((System.Drawing.Image)(resources.GetObject("uxSaveFile.Image")));
            this.uxSaveFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.uxSaveFile.Name = "uxSaveFile";
            this.uxSaveFile.Size = new System.Drawing.Size(100, 36);
            this.uxSaveFile.Text = "Save File";
            this.uxSaveFile.Click += new System.EventHandler(this.uxSaveFile_Click);
            // 
            // uxTextBox
            // 
            this.uxTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.uxTextBox.ForeColor = System.Drawing.SystemColors.Control;
            this.uxTextBox.Location = new System.Drawing.Point(128, 82);
            this.uxTextBox.Multiline = true;
            this.uxTextBox.Name = "uxTextBox";
            this.uxTextBox.ReadOnly = true;
            this.uxTextBox.Size = new System.Drawing.Size(346, 64);
            this.uxTextBox.TabIndex = 1;
            // 
            // uxLabel
            // 
            this.uxLabel.AutoSize = true;
            this.uxLabel.Location = new System.Drawing.Point(12, 99);
            this.uxLabel.Name = "uxLabel";
            this.uxLabel.Size = new System.Drawing.Size(110, 25);
            this.uxLabel.TabIndex = 2;
            this.uxLabel.Text = "Max Flow:";
            // 
            // uxOpenFileDialog
            // 
            this.uxOpenFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            // 
            // uxSaveFileDialog
            // 
            this.uxSaveFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 173);
            this.Controls.Add(this.uxLabel);
            this.Controls.Add(this.uxTextBox);
            this.Controls.Add(this.uxToolStrip);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserInterface";
            this.Text = "Network Flow";
            this.uxToolStrip.ResumeLayout(false);
            this.uxToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip uxToolStrip;
        private System.Windows.Forms.ToolStripButton uxOpenFile;
        private System.Windows.Forms.ToolStripButton uxSaveFile;
        private System.Windows.Forms.TextBox uxTextBox;
        private System.Windows.Forms.Label uxLabel;
        private System.Windows.Forms.OpenFileDialog uxOpenFileDialog;
        private System.Windows.Forms.SaveFileDialog uxSaveFileDialog;
    }
}