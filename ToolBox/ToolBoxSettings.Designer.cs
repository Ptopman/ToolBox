namespace ToolBox
{
    partial class ToolBoxSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToolBoxSettings));
            this.LBTBSappselection = new System.Windows.Forms.ListBox();
            this.TBTBSapppath = new System.Windows.Forms.TextBox();
            this.BTNTBSBrowse = new System.Windows.Forms.Button();
            this.BTNTBSsave = new System.Windows.Forms.Button();
            this.BTNTBScancel = new System.Windows.Forms.Button();
            this.OFDTBSpathselect = new System.Windows.Forms.OpenFileDialog();
            this.GBTBTBS = new System.Windows.Forms.GroupBox();
            this.CBTBSrdp = new System.Windows.Forms.CheckBox();
            this.CBTBSputty = new System.Windows.Forms.CheckBox();
            this.BTNTBShelp = new System.Windows.Forms.Button();
            this.GBTBTBS.SuspendLayout();
            this.SuspendLayout();
            // 
            // LBTBSappselection
            // 
            this.LBTBSappselection.FormattingEnabled = true;
            this.LBTBSappselection.Items.AddRange(new object[] {
            "Notepad++",
            "Putty"});
            this.LBTBSappselection.Location = new System.Drawing.Point(12, 12);
            this.LBTBSappselection.Name = "LBTBSappselection";
            this.LBTBSappselection.Size = new System.Drawing.Size(237, 82);
            this.LBTBSappselection.TabIndex = 0;
            this.LBTBSappselection.SelectedIndexChanged += new System.EventHandler(this.LBTBSappselection_SelectedIndexChanged);
            // 
            // TBTBSapppath
            // 
            this.TBTBSapppath.Location = new System.Drawing.Point(12, 100);
            this.TBTBSapppath.Name = "TBTBSapppath";
            this.TBTBSapppath.Size = new System.Drawing.Size(237, 20);
            this.TBTBSapppath.TabIndex = 1;
            // 
            // BTNTBSBrowse
            // 
            this.BTNTBSBrowse.Location = new System.Drawing.Point(12, 126);
            this.BTNTBSBrowse.Name = "BTNTBSBrowse";
            this.BTNTBSBrowse.Size = new System.Drawing.Size(75, 23);
            this.BTNTBSBrowse.TabIndex = 2;
            this.BTNTBSBrowse.Text = "Browse";
            this.BTNTBSBrowse.UseVisualStyleBackColor = true;
            this.BTNTBSBrowse.Click += new System.EventHandler(this.BTNTBSBrowse_Click);
            // 
            // BTNTBSsave
            // 
            this.BTNTBSsave.Location = new System.Drawing.Point(93, 126);
            this.BTNTBSsave.Name = "BTNTBSsave";
            this.BTNTBSsave.Size = new System.Drawing.Size(75, 23);
            this.BTNTBSsave.TabIndex = 3;
            this.BTNTBSsave.Text = "Save";
            this.BTNTBSsave.UseVisualStyleBackColor = true;
            this.BTNTBSsave.Click += new System.EventHandler(this.BTNTBSsave_Click);
            // 
            // BTNTBScancel
            // 
            this.BTNTBScancel.Location = new System.Drawing.Point(174, 126);
            this.BTNTBScancel.Name = "BTNTBScancel";
            this.BTNTBScancel.Size = new System.Drawing.Size(75, 23);
            this.BTNTBScancel.TabIndex = 4;
            this.BTNTBScancel.Text = "Cancel";
            this.BTNTBScancel.UseVisualStyleBackColor = true;
            this.BTNTBScancel.Click += new System.EventHandler(this.BTNTBScancel_Click);
            // 
            // OFDTBSpathselect
            // 
            this.OFDTBSpathselect.FileName = "openFileDialog1";
            // 
            // GBTBTBS
            // 
            this.GBTBTBS.Controls.Add(this.CBTBSputty);
            this.GBTBTBS.Controls.Add(this.CBTBSrdp);
            this.GBTBTBS.Location = new System.Drawing.Point(12, 155);
            this.GBTBTBS.Name = "GBTBTBS";
            this.GBTBTBS.Size = new System.Drawing.Size(237, 73);
            this.GBTBTBS.TabIndex = 5;
            this.GBTBTBS.TabStop = false;
            this.GBTBTBS.Text = "Show in Icon";
            // 
            // CBTBSrdp
            // 
            this.CBTBSrdp.AutoSize = true;
            this.CBTBSrdp.Location = new System.Drawing.Point(6, 19);
            this.CBTBSrdp.Name = "CBTBSrdp";
            this.CBTBSrdp.Size = new System.Drawing.Size(49, 17);
            this.CBTBSrdp.TabIndex = 0;
            this.CBTBSrdp.Text = "RDP";
            this.CBTBSrdp.UseVisualStyleBackColor = true;
            this.CBTBSrdp.CheckedChanged += new System.EventHandler(this.CBTBSrdp_CheckedChanged);
            // 
            // CBTBSputty
            // 
            this.CBTBSputty.AutoSize = true;
            this.CBTBSputty.Location = new System.Drawing.Point(6, 42);
            this.CBTBSputty.Name = "CBTBSputty";
            this.CBTBSputty.Size = new System.Drawing.Size(58, 17);
            this.CBTBSputty.TabIndex = 1;
            this.CBTBSputty.Text = "PuTTy";
            this.CBTBSputty.UseVisualStyleBackColor = true;
            this.CBTBSputty.CheckedChanged += new System.EventHandler(this.CBTBSputty_CheckedChanged);
            // 
            // BTNTBShelp
            // 
            this.BTNTBShelp.Location = new System.Drawing.Point(12, 234);
            this.BTNTBShelp.Name = "BTNTBShelp";
            this.BTNTBShelp.Size = new System.Drawing.Size(75, 23);
            this.BTNTBShelp.TabIndex = 6;
            this.BTNTBShelp.Text = "Help";
            this.BTNTBShelp.UseVisualStyleBackColor = true;
            this.BTNTBShelp.Click += new System.EventHandler(this.BTNTBShelp_Click);
            // 
            // ToolBoxSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 267);
            this.Controls.Add(this.BTNTBShelp);
            this.Controls.Add(this.GBTBTBS);
            this.Controls.Add(this.BTNTBScancel);
            this.Controls.Add(this.BTNTBSsave);
            this.Controls.Add(this.BTNTBSBrowse);
            this.Controls.Add(this.TBTBSapppath);
            this.Controls.Add(this.LBTBSappselection);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ToolBoxSettings";
            this.Text = "ToolBoxSettings";
            this.Load += new System.EventHandler(this.ToolBoxSettings_Load);
            this.GBTBTBS.ResumeLayout(false);
            this.GBTBTBS.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LBTBSappselection;
        private System.Windows.Forms.TextBox TBTBSapppath;
        private System.Windows.Forms.Button BTNTBSBrowse;
        private System.Windows.Forms.Button BTNTBSsave;
        private System.Windows.Forms.Button BTNTBScancel;
        private System.Windows.Forms.OpenFileDialog OFDTBSpathselect;
        private System.Windows.Forms.GroupBox GBTBTBS;
        private System.Windows.Forms.CheckBox CBTBSputty;
        private System.Windows.Forms.CheckBox CBTBSrdp;
        private System.Windows.Forms.Button BTNTBShelp;
    }
}