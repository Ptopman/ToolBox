namespace ToolBox
{
    partial class RemoteDesktopSelection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoteDesktopSelection));
            this.BTNRDPconnect = new System.Windows.Forms.Button();
            this.LBRDPcomputers = new System.Windows.Forms.ListBox();
            this.BTNRDPadd = new System.Windows.Forms.Button();
            this.BTNRDPsave = new System.Windows.Forms.Button();
            this.BTNRDPremove = new System.Windows.Forms.Button();
            this.TBRDPip = new System.Windows.Forms.TextBox();
            this.LBLRDPip = new System.Windows.Forms.Label();
            this.LBLRDPdescription = new System.Windows.Forms.Label();
            this.TBRDPdescription = new System.Windows.Forms.TextBox();
            this.BTNRDPsettings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTNRDPconnect
            // 
            this.BTNRDPconnect.Location = new System.Drawing.Point(192, 200);
            this.BTNRDPconnect.Name = "BTNRDPconnect";
            this.BTNRDPconnect.Size = new System.Drawing.Size(75, 23);
            this.BTNRDPconnect.TabIndex = 0;
            this.BTNRDPconnect.Text = "Connect";
            this.BTNRDPconnect.UseVisualStyleBackColor = true;
            this.BTNRDPconnect.Click += new System.EventHandler(this.BTNRDPconnect_Click);
            // 
            // LBRDPcomputers
            // 
            this.LBRDPcomputers.FormattingEnabled = true;
            this.LBRDPcomputers.Location = new System.Drawing.Point(12, 12);
            this.LBRDPcomputers.Name = "LBRDPcomputers";
            this.LBRDPcomputers.Size = new System.Drawing.Size(255, 95);
            this.LBRDPcomputers.TabIndex = 1;
            // 
            // BTNRDPadd
            // 
            this.BTNRDPadd.Location = new System.Drawing.Point(12, 119);
            this.BTNRDPadd.Name = "BTNRDPadd";
            this.BTNRDPadd.Size = new System.Drawing.Size(75, 23);
            this.BTNRDPadd.TabIndex = 2;
            this.BTNRDPadd.Text = "Add";
            this.BTNRDPadd.UseVisualStyleBackColor = true;
            this.BTNRDPadd.Click += new System.EventHandler(this.BTNRDPadd_Click);
            // 
            // BTNRDPsave
            // 
            this.BTNRDPsave.Location = new System.Drawing.Point(192, 119);
            this.BTNRDPsave.Name = "BTNRDPsave";
            this.BTNRDPsave.Size = new System.Drawing.Size(75, 23);
            this.BTNRDPsave.TabIndex = 3;
            this.BTNRDPsave.Text = "Save";
            this.BTNRDPsave.UseVisualStyleBackColor = true;
            this.BTNRDPsave.Click += new System.EventHandler(this.BTNRDPsave_Click);
            // 
            // BTNRDPremove
            // 
            this.BTNRDPremove.Location = new System.Drawing.Point(101, 119);
            this.BTNRDPremove.Name = "BTNRDPremove";
            this.BTNRDPremove.Size = new System.Drawing.Size(75, 23);
            this.BTNRDPremove.TabIndex = 4;
            this.BTNRDPremove.Text = "Remove";
            this.BTNRDPremove.UseVisualStyleBackColor = true;
            this.BTNRDPremove.Click += new System.EventHandler(this.BTNRDPremove_Click);
            // 
            // TBRDPip
            // 
            this.TBRDPip.Location = new System.Drawing.Point(101, 148);
            this.TBRDPip.Name = "TBRDPip";
            this.TBRDPip.Size = new System.Drawing.Size(166, 20);
            this.TBRDPip.TabIndex = 5;
            // 
            // LBLRDPip
            // 
            this.LBLRDPip.Location = new System.Drawing.Point(9, 148);
            this.LBLRDPip.Name = "LBLRDPip";
            this.LBLRDPip.Size = new System.Drawing.Size(86, 20);
            this.LBLRDPip.TabIndex = 6;
            this.LBLRDPip.Text = "Remote IP:";
            this.LBLRDPip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBLRDPdescription
            // 
            this.LBLRDPdescription.Location = new System.Drawing.Point(9, 173);
            this.LBLRDPdescription.Name = "LBLRDPdescription";
            this.LBLRDPdescription.Size = new System.Drawing.Size(86, 20);
            this.LBLRDPdescription.TabIndex = 7;
            this.LBLRDPdescription.Text = "Description:";
            this.LBLRDPdescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TBRDPdescription
            // 
            this.TBRDPdescription.Location = new System.Drawing.Point(101, 174);
            this.TBRDPdescription.Name = "TBRDPdescription";
            this.TBRDPdescription.Size = new System.Drawing.Size(166, 20);
            this.TBRDPdescription.TabIndex = 8;
            // 
            // BTNRDPsettings
            // 
            this.BTNRDPsettings.BackColor = System.Drawing.SystemColors.Control;
            this.BTNRDPsettings.Location = new System.Drawing.Point(101, 200);
            this.BTNRDPsettings.Name = "BTNRDPsettings";
            this.BTNRDPsettings.Size = new System.Drawing.Size(75, 23);
            this.BTNRDPsettings.TabIndex = 10;
            this.BTNRDPsettings.Text = "Settings";
            this.BTNRDPsettings.UseVisualStyleBackColor = false;
            this.BTNRDPsettings.Click += new System.EventHandler(this.BTNRDPsettings_Click);
            // 
            // RemoteDesktopSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 234);
            this.Controls.Add(this.BTNRDPsettings);
            this.Controls.Add(this.TBRDPdescription);
            this.Controls.Add(this.LBLRDPdescription);
            this.Controls.Add(this.LBLRDPip);
            this.Controls.Add(this.TBRDPip);
            this.Controls.Add(this.BTNRDPremove);
            this.Controls.Add(this.BTNRDPsave);
            this.Controls.Add(this.BTNRDPadd);
            this.Controls.Add(this.LBRDPcomputers);
            this.Controls.Add(this.BTNRDPconnect);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RemoteDesktopSelection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remote Desktop";
            this.Load += new System.EventHandler(this.RemoteDesktopSelection_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNRDPconnect;
        private System.Windows.Forms.ListBox LBRDPcomputers;
        private System.Windows.Forms.Button BTNRDPadd;
        private System.Windows.Forms.Button BTNRDPsave;
        private System.Windows.Forms.Button BTNRDPremove;
        private System.Windows.Forms.TextBox TBRDPip;
        private System.Windows.Forms.Label LBLRDPip;
        private System.Windows.Forms.Label LBLRDPdescription;
        private System.Windows.Forms.TextBox TBRDPdescription;
        private System.Windows.Forms.Button BTNRDPsettings;
    }
}