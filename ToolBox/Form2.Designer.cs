﻿namespace ToolBox
{
    partial class Form2
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
            this.LBLCpuInfo = new System.Windows.Forms.Label();
            this.RTBCpuInfo = new System.Windows.Forms.RichTextBox();
            this.RTBMotherboard = new System.Windows.Forms.RichTextBox();
            this.RTBWindowsInfo = new System.Windows.Forms.RichTextBox();
            this.LBLMotherboardInfo = new System.Windows.Forms.Label();
            this.LBLCPULoad = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.LBLMemoryAvailable = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.LBLWindowsInfo = new System.Windows.Forms.Label();
            this.LBLNetworkInfo = new System.Windows.Forms.Label();
            this.RTBNetworkInfo = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // LBLCpuInfo
            // 
            this.LBLCpuInfo.Location = new System.Drawing.Point(12, 55);
            this.LBLCpuInfo.Name = "LBLCpuInfo";
            this.LBLCpuInfo.Size = new System.Drawing.Size(352, 23);
            this.LBLCpuInfo.TabIndex = 3;
            this.LBLCpuInfo.Text = "CPU Information:";
            this.LBLCpuInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RTBCpuInfo
            // 
            this.RTBCpuInfo.BackColor = System.Drawing.Color.White;
            this.RTBCpuInfo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RTBCpuInfo.Location = new System.Drawing.Point(12, 81);
            this.RTBCpuInfo.Name = "RTBCpuInfo";
            this.RTBCpuInfo.Size = new System.Drawing.Size(352, 73);
            this.RTBCpuInfo.TabIndex = 12;
            this.RTBCpuInfo.Text = "Name: NA\nNumberOfCores: NA\nNumberOfLogicalProcessors: NA\nStatus: NA\nSystemName: N" +
    "A";
            // 
            // RTBMotherboard
            // 
            this.RTBMotherboard.BackColor = System.Drawing.Color.White;
            this.RTBMotherboard.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RTBMotherboard.Location = new System.Drawing.Point(12, 183);
            this.RTBMotherboard.Name = "RTBMotherboard";
            this.RTBMotherboard.Size = new System.Drawing.Size(352, 73);
            this.RTBMotherboard.TabIndex = 13;
            this.RTBMotherboard.Text = "Manufacturer: NA\nProduct: NA\nSerialNumber: NA\nBIOS Version: NA\nBIOS Release Date:" +
    " NA";
            // 
            // RTBWindowsInfo
            // 
            this.RTBWindowsInfo.BackColor = System.Drawing.Color.White;
            this.RTBWindowsInfo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RTBWindowsInfo.Location = new System.Drawing.Point(12, 285);
            this.RTBWindowsInfo.Name = "RTBWindowsInfo";
            this.RTBWindowsInfo.Size = new System.Drawing.Size(352, 73);
            this.RTBWindowsInfo.TabIndex = 14;
            this.RTBWindowsInfo.Text = "Windows Edition: NA\nWindows Architecture: NA\nBuild Number: NA\nInstall Date: NA\nLa" +
    "st Boot Up: NA";
            // 
            // LBLMotherboardInfo
            // 
            this.LBLMotherboardInfo.Location = new System.Drawing.Point(12, 157);
            this.LBLMotherboardInfo.Name = "LBLMotherboardInfo";
            this.LBLMotherboardInfo.Size = new System.Drawing.Size(139, 23);
            this.LBLMotherboardInfo.TabIndex = 15;
            this.LBLMotherboardInfo.Text = "Motherboard Information:";
            this.LBLMotherboardInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LBLCPULoad
            // 
            this.LBLCPULoad.Location = new System.Drawing.Point(12, 9);
            this.LBLCPULoad.Name = "LBLCPULoad";
            this.LBLCPULoad.Size = new System.Drawing.Size(352, 23);
            this.LBLCPULoad.TabIndex = 16;
            this.LBLCPULoad.Text = "CPULoad:";
            this.LBLCPULoad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.TickTock);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(35, 547);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(302, 48);
            this.label2.TabIndex = 17;
            this.label2.Text = "This Screen is under construction, \r\nMay be unstable";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBLMemoryAvailable
            // 
            this.LBLMemoryAvailable.Location = new System.Drawing.Point(12, 32);
            this.LBLMemoryAvailable.Name = "LBLMemoryAvailable";
            this.LBLMemoryAvailable.Size = new System.Drawing.Size(352, 23);
            this.LBLMemoryAvailable.TabIndex = 18;
            this.LBLMemoryAvailable.Text = "Memory Usage:";
            this.LBLMemoryAvailable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timer2
            // 
            this.timer2.Interval = 5000;
            this.timer2.Tick += new System.EventHandler(this.TickTock2);
            // 
            // LBLWindowsInfo
            // 
            this.LBLWindowsInfo.Location = new System.Drawing.Point(12, 259);
            this.LBLWindowsInfo.Name = "LBLWindowsInfo";
            this.LBLWindowsInfo.Size = new System.Drawing.Size(139, 23);
            this.LBLWindowsInfo.TabIndex = 19;
            this.LBLWindowsInfo.Text = "Windows Information: ";
            this.LBLWindowsInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LBLNetworkInfo
            // 
            this.LBLNetworkInfo.Location = new System.Drawing.Point(12, 361);
            this.LBLNetworkInfo.Name = "LBLNetworkInfo";
            this.LBLNetworkInfo.Size = new System.Drawing.Size(139, 23);
            this.LBLNetworkInfo.TabIndex = 21;
            this.LBLNetworkInfo.Text = "Network Information: ";
            this.LBLNetworkInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RTBNetworkInfo
            // 
            this.RTBNetworkInfo.BackColor = System.Drawing.Color.White;
            this.RTBNetworkInfo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RTBNetworkInfo.Location = new System.Drawing.Point(12, 387);
            this.RTBNetworkInfo.Name = "RTBNetworkInfo";
            this.RTBNetworkInfo.Size = new System.Drawing.Size(352, 131);
            this.RTBNetworkInfo.TabIndex = 20;
            this.RTBNetworkInfo.Text = "";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 604);
            this.Controls.Add(this.LBLNetworkInfo);
            this.Controls.Add(this.RTBNetworkInfo);
            this.Controls.Add(this.LBLWindowsInfo);
            this.Controls.Add(this.LBLMemoryAvailable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LBLCPULoad);
            this.Controls.Add(this.LBLMotherboardInfo);
            this.Controls.Add(this.RTBWindowsInfo);
            this.Controls.Add(this.RTBMotherboard);
            this.Controls.Add(this.RTBCpuInfo);
            this.Controls.Add(this.LBLCpuInfo);
            this.Name = "Form2";
            this.Text = "System Stats";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LBLCpuInfo;
        private System.Windows.Forms.RichTextBox RTBCpuInfo;
        private System.Windows.Forms.RichTextBox RTBMotherboard;
        private System.Windows.Forms.RichTextBox RTBWindowsInfo;
        private System.Windows.Forms.Label LBLMotherboardInfo;
        private System.Windows.Forms.Label LBLCPULoad;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LBLMemoryAvailable;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label LBLWindowsInfo;
        private System.Windows.Forms.Label LBLNetworkInfo;
        private System.Windows.Forms.RichTextBox RTBNetworkInfo;
    }
}