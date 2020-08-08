namespace ToolBox
{
    partial class ToolBoxSettingsHelp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToolBoxSettingsHelp));
            this.LBLTBSHWords = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LBLTBSHWords
            // 
            this.LBLTBSHWords.Location = new System.Drawing.Point(12, 9);
            this.LBLTBSHWords.Name = "LBLTBSHWords";
            this.LBLTBSHWords.Size = new System.Drawing.Size(377, 155);
            this.LBLTBSHWords.TabIndex = 0;
            this.LBLTBSHWords.Text = resources.GetString("LBLTBSHWords.Text");
            this.LBLTBSHWords.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ToolBoxSettingsHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 173);
            this.Controls.Add(this.LBLTBSHWords);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ToolBoxSettingsHelp";
            this.Text = "ToolBoxSettingsHelp";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LBLTBSHWords;
    }
}