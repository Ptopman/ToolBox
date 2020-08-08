namespace ToolBox
{
    partial class RDPsettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RDPsettings));
            this.BTNRDPsettingsFileSelection = new System.Windows.Forms.Button();
            this.FDRDPfileSelect = new System.Windows.Forms.OpenFileDialog();
            this.TBRDPsettingsFilePath = new System.Windows.Forms.TextBox();
            this.BTNRDPsettingsSaveClose = new System.Windows.Forms.Button();
            this.CBRDPcloseOnOpen = new System.Windows.Forms.CheckBox();
            this.BTNRDPsettingsCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTNRDPsettingsFileSelection
            // 
            this.BTNRDPsettingsFileSelection.Location = new System.Drawing.Point(12, 12);
            this.BTNRDPsettingsFileSelection.Name = "BTNRDPsettingsFileSelection";
            this.BTNRDPsettingsFileSelection.Size = new System.Drawing.Size(100, 23);
            this.BTNRDPsettingsFileSelection.TabIndex = 0;
            this.BTNRDPsettingsFileSelection.Text = "Select RDP file";
            this.BTNRDPsettingsFileSelection.UseVisualStyleBackColor = true;
            this.BTNRDPsettingsFileSelection.Click += new System.EventHandler(this.BTNRDPsettingsFileSelection_Click);
            // 
            // FDRDPfileSelect
            // 
            this.FDRDPfileSelect.FileName = "openFileDialog1";
            // 
            // TBRDPsettingsFilePath
            // 
            this.TBRDPsettingsFilePath.Location = new System.Drawing.Point(12, 41);
            this.TBRDPsettingsFilePath.Name = "TBRDPsettingsFilePath";
            this.TBRDPsettingsFilePath.Size = new System.Drawing.Size(273, 20);
            this.TBRDPsettingsFilePath.TabIndex = 1;
            // 
            // BTNRDPsettingsSaveClose
            // 
            this.BTNRDPsettingsSaveClose.Location = new System.Drawing.Point(12, 67);
            this.BTNRDPsettingsSaveClose.Name = "BTNRDPsettingsSaveClose";
            this.BTNRDPsettingsSaveClose.Size = new System.Drawing.Size(83, 23);
            this.BTNRDPsettingsSaveClose.TabIndex = 2;
            this.BTNRDPsettingsSaveClose.Text = "Save / Close";
            this.BTNRDPsettingsSaveClose.UseVisualStyleBackColor = true;
            this.BTNRDPsettingsSaveClose.Click += new System.EventHandler(this.BTNRDPsettingsSaveClose_Click);
            // 
            // CBRDPcloseOnOpen
            // 
            this.CBRDPcloseOnOpen.AutoSize = true;
            this.CBRDPcloseOnOpen.Location = new System.Drawing.Point(192, 12);
            this.CBRDPcloseOnOpen.Name = "CBRDPcloseOnOpen";
            this.CBRDPcloseOnOpen.Size = new System.Drawing.Size(93, 17);
            this.CBRDPcloseOnOpen.TabIndex = 10;
            this.CBRDPcloseOnOpen.Text = "Close on RDP";
            this.CBRDPcloseOnOpen.UseVisualStyleBackColor = true;
            // 
            // BTNRDPsettingsCancel
            // 
            this.BTNRDPsettingsCancel.Location = new System.Drawing.Point(210, 67);
            this.BTNRDPsettingsCancel.Name = "BTNRDPsettingsCancel";
            this.BTNRDPsettingsCancel.Size = new System.Drawing.Size(75, 23);
            this.BTNRDPsettingsCancel.TabIndex = 11;
            this.BTNRDPsettingsCancel.Text = "Cancel";
            this.BTNRDPsettingsCancel.UseVisualStyleBackColor = true;
            this.BTNRDPsettingsCancel.Click += new System.EventHandler(this.BTNRDPsettingsCancel_Click);
            // 
            // RDPsettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 102);
            this.Controls.Add(this.BTNRDPsettingsCancel);
            this.Controls.Add(this.CBRDPcloseOnOpen);
            this.Controls.Add(this.BTNRDPsettingsSaveClose);
            this.Controls.Add(this.TBRDPsettingsFilePath);
            this.Controls.Add(this.BTNRDPsettingsFileSelection);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RDPsettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "RDPsettings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNRDPsettingsFileSelection;
        private System.Windows.Forms.OpenFileDialog FDRDPfileSelect;
        private System.Windows.Forms.TextBox TBRDPsettingsFilePath;
        private System.Windows.Forms.Button BTNRDPsettingsSaveClose;
        private System.Windows.Forms.CheckBox CBRDPcloseOnOpen;
        private System.Windows.Forms.Button BTNRDPsettingsCancel;
    }
}