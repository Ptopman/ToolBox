namespace ToolBox
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BTNCPSound = new System.Windows.Forms.Button();
            this.NIToolBox = new System.Windows.Forms.NotifyIcon(this.components);
            this.BTNControl = new System.Windows.Forms.Button();
            this.BTNUninstall = new System.Windows.Forms.Button();
            this.BTNNetShareCent = new System.Windows.Forms.Button();
            this.BTNNetAdap = new System.Windows.Forms.Button();
            this.BTNNotepad = new System.Windows.Forms.Button();
            this.BTNNotepadPP = new System.Windows.Forms.Button();
            this.BTNResMon = new System.Windows.Forms.Button();
            this.BTNCmd = new System.Windows.Forms.Button();
            this.BTNCmdAd = new System.Windows.Forms.Button();
            this.BTNDeviceMan = new System.Windows.Forms.Button();
            this.BTNDiskMan = new System.Windows.Forms.Button();
            this.BTNRegedit = new System.Windows.Forms.Button();
            this.BTNTaksMan = new System.Windows.Forms.Button();
            this.BTNPerfMon = new System.Windows.Forms.Button();
            this.BTNSysConfig = new System.Windows.Forms.Button();
            this.BTNSysInfo = new System.Windows.Forms.Button();
            this.BTNMemDiag = new System.Windows.Forms.Button();
            this.BTNReliabilityMon = new System.Windows.Forms.Button();
            this.BTNRDP = new System.Windows.Forms.Button();
            this.BTNServices = new System.Windows.Forms.Button();
            this.BTNKeybaord = new System.Windows.Forms.Button();
            this.BTNMouse = new System.Windows.Forms.Button();
            this.BTNosk = new System.Windows.Forms.Button();
            this.BTNRestart = new System.Windows.Forms.Button();
            this.BTNDisplaySet = new System.Windows.Forms.Button();
            this.BTNNvidiaControl = new System.Windows.Forms.Button();
            this.BTNShutdown = new System.Windows.Forms.Button();
            this.BTNW10Settings = new System.Windows.Forms.Button();
            this.BTNShutToolBox = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTNCPSound
            // 
            this.BTNCPSound.Location = new System.Drawing.Point(12, 273);
            this.BTNCPSound.Name = "BTNCPSound";
            this.BTNCPSound.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BTNCPSound.Size = new System.Drawing.Size(218, 23);
            this.BTNCPSound.TabIndex = 12;
            this.BTNCPSound.Text = "Sound";
            this.BTNCPSound.UseVisualStyleBackColor = true;
            this.BTNCPSound.Click += new System.EventHandler(this.BTNCPSound_Click);
            // 
            // NIToolBox
            // 
            this.NIToolBox.Icon = ((System.Drawing.Icon)(resources.GetObject("NIToolBox.Icon")));
            this.NIToolBox.Text = "ToolBox";
            this.NIToolBox.Visible = true;
            this.NIToolBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon1_MouseClick);
            // 
            // BTNControl
            // 
            this.BTNControl.Location = new System.Drawing.Point(12, 244);
            this.BTNControl.Name = "BTNControl";
            this.BTNControl.Size = new System.Drawing.Size(218, 23);
            this.BTNControl.TabIndex = 3;
            this.BTNControl.Text = "Control Panel";
            this.BTNControl.UseVisualStyleBackColor = true;
            this.BTNControl.Click += new System.EventHandler(this.BTNControl_Click);
            // 
            // BTNUninstall
            // 
            this.BTNUninstall.Location = new System.Drawing.Point(263, 273);
            this.BTNUninstall.Name = "BTNUninstall";
            this.BTNUninstall.Size = new System.Drawing.Size(218, 23);
            this.BTNUninstall.TabIndex = 4;
            this.BTNUninstall.Text = "Uninstall";
            this.BTNUninstall.UseVisualStyleBackColor = true;
            this.BTNUninstall.Click += new System.EventHandler(this.BTNUninstall_Click);
            // 
            // BTNNetShareCent
            // 
            this.BTNNetShareCent.Location = new System.Drawing.Point(12, 302);
            this.BTNNetShareCent.Name = "BTNNetShareCent";
            this.BTNNetShareCent.Size = new System.Drawing.Size(218, 23);
            this.BTNNetShareCent.TabIndex = 5;
            this.BTNNetShareCent.Text = "Network and Sharing Center";
            this.BTNNetShareCent.UseVisualStyleBackColor = true;
            this.BTNNetShareCent.Click += new System.EventHandler(this.BTNNetShareCent_Click);
            // 
            // BTNNetAdap
            // 
            this.BTNNetAdap.Location = new System.Drawing.Point(12, 331);
            this.BTNNetAdap.Name = "BTNNetAdap";
            this.BTNNetAdap.Size = new System.Drawing.Size(218, 23);
            this.BTNNetAdap.TabIndex = 6;
            this.BTNNetAdap.Text = "Network Adapters";
            this.BTNNetAdap.UseVisualStyleBackColor = true;
            this.BTNNetAdap.Click += new System.EventHandler(this.BTNNetAdap_Click);
            // 
            // BTNNotepad
            // 
            this.BTNNotepad.Location = new System.Drawing.Point(263, 70);
            this.BTNNotepad.Name = "BTNNotepad";
            this.BTNNotepad.Size = new System.Drawing.Size(218, 23);
            this.BTNNotepad.TabIndex = 7;
            this.BTNNotepad.Text = "Notepad";
            this.BTNNotepad.UseVisualStyleBackColor = true;
            this.BTNNotepad.Click += new System.EventHandler(this.BTNNotepad_Click);
            // 
            // BTNNotepadPP
            // 
            this.BTNNotepadPP.Location = new System.Drawing.Point(263, 99);
            this.BTNNotepadPP.Name = "BTNNotepadPP";
            this.BTNNotepadPP.Size = new System.Drawing.Size(218, 23);
            this.BTNNotepadPP.TabIndex = 8;
            this.BTNNotepadPP.Text = "Notepad++";
            this.BTNNotepadPP.UseVisualStyleBackColor = true;
            this.BTNNotepadPP.Click += new System.EventHandler(this.BTNNotepadPP_Click);
            // 
            // BTNResMon
            // 
            this.BTNResMon.Location = new System.Drawing.Point(263, 157);
            this.BTNResMon.Name = "BTNResMon";
            this.BTNResMon.Size = new System.Drawing.Size(218, 23);
            this.BTNResMon.TabIndex = 9;
            this.BTNResMon.Text = "Resource Monitor";
            this.BTNResMon.UseVisualStyleBackColor = true;
            this.BTNResMon.Click += new System.EventHandler(this.BTNResMon_Click);
            // 
            // BTNCmd
            // 
            this.BTNCmd.Location = new System.Drawing.Point(263, 12);
            this.BTNCmd.Name = "BTNCmd";
            this.BTNCmd.Size = new System.Drawing.Size(218, 23);
            this.BTNCmd.TabIndex = 10;
            this.BTNCmd.Text = "Command Prompt";
            this.BTNCmd.UseVisualStyleBackColor = true;
            this.BTNCmd.Click += new System.EventHandler(this.BTNCmd_Click);
            // 
            // BTNCmdAd
            // 
            this.BTNCmdAd.Location = new System.Drawing.Point(263, 41);
            this.BTNCmdAd.Name = "BTNCmdAd";
            this.BTNCmdAd.Size = new System.Drawing.Size(218, 23);
            this.BTNCmdAd.TabIndex = 11;
            this.BTNCmdAd.Text = "Command Prompt Admin";
            this.BTNCmdAd.UseVisualStyleBackColor = true;
            this.BTNCmdAd.Click += new System.EventHandler(this.BTNCmdAd_Click);
            // 
            // BTNDeviceMan
            // 
            this.BTNDeviceMan.Location = new System.Drawing.Point(12, 12);
            this.BTNDeviceMan.Name = "BTNDeviceMan";
            this.BTNDeviceMan.Size = new System.Drawing.Size(218, 23);
            this.BTNDeviceMan.TabIndex = 0;
            this.BTNDeviceMan.Text = "Divice Management";
            this.BTNDeviceMan.UseVisualStyleBackColor = true;
            this.BTNDeviceMan.Click += new System.EventHandler(this.BTNDeviceMan_Click);
            // 
            // BTNDiskMan
            // 
            this.BTNDiskMan.Location = new System.Drawing.Point(12, 360);
            this.BTNDiskMan.Name = "BTNDiskMan";
            this.BTNDiskMan.Size = new System.Drawing.Size(218, 23);
            this.BTNDiskMan.TabIndex = 13;
            this.BTNDiskMan.Text = "Disk Management";
            this.BTNDiskMan.UseVisualStyleBackColor = true;
            this.BTNDiskMan.Click += new System.EventHandler(this.BTNDiskMan_Click);
            // 
            // BTNRegedit
            // 
            this.BTNRegedit.Location = new System.Drawing.Point(12, 389);
            this.BTNRegedit.Name = "BTNRegedit";
            this.BTNRegedit.Size = new System.Drawing.Size(218, 23);
            this.BTNRegedit.TabIndex = 14;
            this.BTNRegedit.Text = "Regedit";
            this.BTNRegedit.UseVisualStyleBackColor = true;
            this.BTNRegedit.Click += new System.EventHandler(this.BTNRegedit_Click);
            // 
            // BTNTaksMan
            // 
            this.BTNTaksMan.Location = new System.Drawing.Point(263, 302);
            this.BTNTaksMan.Name = "BTNTaksMan";
            this.BTNTaksMan.Size = new System.Drawing.Size(218, 23);
            this.BTNTaksMan.TabIndex = 15;
            this.BTNTaksMan.Text = "Task Manager";
            this.BTNTaksMan.UseVisualStyleBackColor = true;
            this.BTNTaksMan.Click += new System.EventHandler(this.BTNTaksMan_Click);
            // 
            // BTNPerfMon
            // 
            this.BTNPerfMon.Location = new System.Drawing.Point(263, 128);
            this.BTNPerfMon.Name = "BTNPerfMon";
            this.BTNPerfMon.Size = new System.Drawing.Size(218, 23);
            this.BTNPerfMon.TabIndex = 16;
            this.BTNPerfMon.Text = "Performance Monitor";
            this.BTNPerfMon.UseVisualStyleBackColor = true;
            this.BTNPerfMon.Click += new System.EventHandler(this.BTNPerfMon_Click);
            // 
            // BTNSysConfig
            // 
            this.BTNSysConfig.Location = new System.Drawing.Point(263, 186);
            this.BTNSysConfig.Name = "BTNSysConfig";
            this.BTNSysConfig.Size = new System.Drawing.Size(218, 23);
            this.BTNSysConfig.TabIndex = 18;
            this.BTNSysConfig.Text = "System Configuration";
            this.BTNSysConfig.UseVisualStyleBackColor = true;
            this.BTNSysConfig.Click += new System.EventHandler(this.BTNSysConfig_Click);
            // 
            // BTNSysInfo
            // 
            this.BTNSysInfo.Location = new System.Drawing.Point(263, 215);
            this.BTNSysInfo.Name = "BTNSysInfo";
            this.BTNSysInfo.Size = new System.Drawing.Size(218, 23);
            this.BTNSysInfo.TabIndex = 19;
            this.BTNSysInfo.Text = "System Information";
            this.BTNSysInfo.UseVisualStyleBackColor = true;
            this.BTNSysInfo.Click += new System.EventHandler(this.BTNSysInfo_Click);
            // 
            // BTNMemDiag
            // 
            this.BTNMemDiag.Location = new System.Drawing.Point(263, 244);
            this.BTNMemDiag.Name = "BTNMemDiag";
            this.BTNMemDiag.Size = new System.Drawing.Size(218, 23);
            this.BTNMemDiag.TabIndex = 20;
            this.BTNMemDiag.Text = "Windows Memory Diagnostics";
            this.BTNMemDiag.UseVisualStyleBackColor = true;
            this.BTNMemDiag.Click += new System.EventHandler(this.BTNMemDiag_Click);
            // 
            // BTNReliabilityMon
            // 
            this.BTNReliabilityMon.Location = new System.Drawing.Point(12, 41);
            this.BTNReliabilityMon.Name = "BTNReliabilityMon";
            this.BTNReliabilityMon.Size = new System.Drawing.Size(218, 23);
            this.BTNReliabilityMon.TabIndex = 21;
            this.BTNReliabilityMon.Text = "Reliability Monitor";
            this.BTNReliabilityMon.UseVisualStyleBackColor = true;
            this.BTNReliabilityMon.Click += new System.EventHandler(this.BTNReliabilityMon_Click);
            // 
            // BTNRDP
            // 
            this.BTNRDP.Location = new System.Drawing.Point(12, 99);
            this.BTNRDP.Name = "BTNRDP";
            this.BTNRDP.Size = new System.Drawing.Size(218, 23);
            this.BTNRDP.TabIndex = 22;
            this.BTNRDP.Text = "RDP";
            this.BTNRDP.UseVisualStyleBackColor = true;
            this.BTNRDP.Click += new System.EventHandler(this.BTNRDP_Click);
            // 
            // BTNServices
            // 
            this.BTNServices.Location = new System.Drawing.Point(12, 70);
            this.BTNServices.Name = "BTNServices";
            this.BTNServices.Size = new System.Drawing.Size(218, 23);
            this.BTNServices.TabIndex = 23;
            this.BTNServices.Text = "Services";
            this.BTNServices.UseVisualStyleBackColor = true;
            this.BTNServices.Click += new System.EventHandler(this.BTNServices_Click);
            // 
            // BTNKeybaord
            // 
            this.BTNKeybaord.Location = new System.Drawing.Point(12, 128);
            this.BTNKeybaord.Name = "BTNKeybaord";
            this.BTNKeybaord.Size = new System.Drawing.Size(218, 23);
            this.BTNKeybaord.TabIndex = 24;
            this.BTNKeybaord.Text = "Keyboard Settings";
            this.BTNKeybaord.UseVisualStyleBackColor = true;
            this.BTNKeybaord.Click += new System.EventHandler(this.BTNKeybaord_Click);
            // 
            // BTNMouse
            // 
            this.BTNMouse.Location = new System.Drawing.Point(12, 186);
            this.BTNMouse.Name = "BTNMouse";
            this.BTNMouse.Size = new System.Drawing.Size(218, 23);
            this.BTNMouse.TabIndex = 25;
            this.BTNMouse.Text = "Mouse Settings";
            this.BTNMouse.UseVisualStyleBackColor = true;
            this.BTNMouse.Click += new System.EventHandler(this.BTNMouse_Click);
            // 
            // BTNosk
            // 
            this.BTNosk.Location = new System.Drawing.Point(12, 157);
            this.BTNosk.Name = "BTNosk";
            this.BTNosk.Size = new System.Drawing.Size(218, 23);
            this.BTNosk.TabIndex = 26;
            this.BTNosk.Text = "On-Screen Keyboard";
            this.BTNosk.UseVisualStyleBackColor = true;
            this.BTNosk.Click += new System.EventHandler(this.BTNosk_Click);
            // 
            // BTNRestart
            // 
            this.BTNRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNRestart.ForeColor = System.Drawing.Color.Red;
            this.BTNRestart.Location = new System.Drawing.Point(6, 19);
            this.BTNRestart.Name = "BTNRestart";
            this.BTNRestart.Size = new System.Drawing.Size(218, 23);
            this.BTNRestart.TabIndex = 27;
            this.BTNRestart.Text = "Restart";
            this.BTNRestart.UseVisualStyleBackColor = true;
            this.BTNRestart.Click += new System.EventHandler(this.BTNRestart_Click);
            // 
            // BTNDisplaySet
            // 
            this.BTNDisplaySet.Location = new System.Drawing.Point(263, 331);
            this.BTNDisplaySet.Name = "BTNDisplaySet";
            this.BTNDisplaySet.Size = new System.Drawing.Size(218, 23);
            this.BTNDisplaySet.TabIndex = 28;
            this.BTNDisplaySet.Text = "Display Settings";
            this.BTNDisplaySet.UseVisualStyleBackColor = true;
            this.BTNDisplaySet.Click += new System.EventHandler(this.BTNDisplaySet_Click);
            // 
            // BTNNvidiaControl
            // 
            this.BTNNvidiaControl.Location = new System.Drawing.Point(263, 360);
            this.BTNNvidiaControl.Name = "BTNNvidiaControl";
            this.BTNNvidiaControl.Size = new System.Drawing.Size(218, 23);
            this.BTNNvidiaControl.TabIndex = 29;
            this.BTNNvidiaControl.Text = "Nvidia Control Panel";
            this.BTNNvidiaControl.UseVisualStyleBackColor = true;
            this.BTNNvidiaControl.Click += new System.EventHandler(this.BTNNvidiaControl_Click);
            // 
            // BTNShutdown
            // 
            this.BTNShutdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNShutdown.ForeColor = System.Drawing.Color.Red;
            this.BTNShutdown.Location = new System.Drawing.Point(6, 48);
            this.BTNShutdown.Name = "BTNShutdown";
            this.BTNShutdown.Size = new System.Drawing.Size(218, 23);
            this.BTNShutdown.TabIndex = 30;
            this.BTNShutdown.Text = "Shutdown";
            this.BTNShutdown.UseVisualStyleBackColor = true;
            this.BTNShutdown.Click += new System.EventHandler(this.BTNShutdown_Click);
            // 
            // BTNW10Settings
            // 
            this.BTNW10Settings.Location = new System.Drawing.Point(12, 215);
            this.BTNW10Settings.Name = "BTNW10Settings";
            this.BTNW10Settings.Size = new System.Drawing.Size(218, 23);
            this.BTNW10Settings.TabIndex = 31;
            this.BTNW10Settings.Text = "Settings (Windows 10)";
            this.BTNW10Settings.UseVisualStyleBackColor = true;
            this.BTNW10Settings.Click += new System.EventHandler(this.BTNW10Settings_Click);
            // 
            // BTNShutToolBox
            // 
            this.BTNShutToolBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNShutToolBox.ForeColor = System.Drawing.Color.Red;
            this.BTNShutToolBox.Location = new System.Drawing.Point(6, 77);
            this.BTNShutToolBox.Name = "BTNShutToolBox";
            this.BTNShutToolBox.Size = new System.Drawing.Size(218, 23);
            this.BTNShutToolBox.TabIndex = 32;
            this.BTNShutToolBox.Text = "Shutdown ToolBox";
            this.BTNShutToolBox.UseVisualStyleBackColor = true;
            this.BTNShutToolBox.Click += new System.EventHandler(this.BTNShutToolBox_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BTNRestart);
            this.groupBox1.Controls.Add(this.BTNShutToolBox);
            this.groupBox1.Controls.Add(this.BTNShutdown);
            this.groupBox1.Location = new System.Drawing.Point(131, 424);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(231, 112);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "The Careful Box";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(498, 548);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BTNW10Settings);
            this.Controls.Add(this.BTNNvidiaControl);
            this.Controls.Add(this.BTNDisplaySet);
            this.Controls.Add(this.BTNosk);
            this.Controls.Add(this.BTNMouse);
            this.Controls.Add(this.BTNKeybaord);
            this.Controls.Add(this.BTNServices);
            this.Controls.Add(this.BTNRDP);
            this.Controls.Add(this.BTNReliabilityMon);
            this.Controls.Add(this.BTNMemDiag);
            this.Controls.Add(this.BTNSysInfo);
            this.Controls.Add(this.BTNSysConfig);
            this.Controls.Add(this.BTNPerfMon);
            this.Controls.Add(this.BTNTaksMan);
            this.Controls.Add(this.BTNRegedit);
            this.Controls.Add(this.BTNDiskMan);
            this.Controls.Add(this.BTNDeviceMan);
            this.Controls.Add(this.BTNCmdAd);
            this.Controls.Add(this.BTNCmd);
            this.Controls.Add(this.BTNResMon);
            this.Controls.Add(this.BTNNotepadPP);
            this.Controls.Add(this.BTNNotepad);
            this.Controls.Add(this.BTNNetAdap);
            this.Controls.Add(this.BTNNetShareCent);
            this.Controls.Add(this.BTNUninstall);
            this.Controls.Add(this.BTNControl);
            this.Controls.Add(this.BTNCPSound);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "ToolBox";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTNCPSound;
        private System.Windows.Forms.NotifyIcon NIToolBox;
        private System.Windows.Forms.Button BTNControl;
        private System.Windows.Forms.Button BTNUninstall;
        private System.Windows.Forms.Button BTNNetShareCent;
        private System.Windows.Forms.Button BTNNetAdap;
        private System.Windows.Forms.Button BTNNotepad;
        private System.Windows.Forms.Button BTNNotepadPP;
        private System.Windows.Forms.Button BTNResMon;
        private System.Windows.Forms.Button BTNCmd;
        private System.Windows.Forms.Button BTNCmdAd;
        private System.Windows.Forms.Button BTNDeviceMan;
        private System.Windows.Forms.Button BTNDiskMan;
        private System.Windows.Forms.Button BTNRegedit;
        private System.Windows.Forms.Button BTNTaksMan;
        private System.Windows.Forms.Button BTNPerfMon;
        private System.Windows.Forms.Button BTNSysConfig;
        private System.Windows.Forms.Button BTNSysInfo;
        private System.Windows.Forms.Button BTNMemDiag;
        private System.Windows.Forms.Button BTNReliabilityMon;
        private System.Windows.Forms.Button BTNRDP;
        private System.Windows.Forms.Button BTNServices;
        private System.Windows.Forms.Button BTNKeybaord;
        private System.Windows.Forms.Button BTNMouse;
        private System.Windows.Forms.Button BTNosk;
        private System.Windows.Forms.Button BTNRestart;
        private System.Windows.Forms.Button BTNDisplaySet;
        private System.Windows.Forms.Button BTNNvidiaControl;
        private System.Windows.Forms.Button BTNShutdown;
        private System.Windows.Forms.Button BTNW10Settings;
        private System.Windows.Forms.Button BTNShutToolBox;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

