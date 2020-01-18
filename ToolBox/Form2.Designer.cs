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
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.LBLMotherboardInfo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LBLCpuInfo
            // 
            this.LBLCpuInfo.Location = new System.Drawing.Point(12, 32);
            this.LBLCpuInfo.Name = "LBLCpuInfo";
            this.LBLCpuInfo.Size = new System.Drawing.Size(139, 23);
            this.LBLCpuInfo.TabIndex = 3;
            this.LBLCpuInfo.Text = "CPU Information:";
            this.LBLCpuInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RTBCpuInfo
            // 
            this.RTBCpuInfo.BackColor = System.Drawing.Color.White;
            this.RTBCpuInfo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RTBCpuInfo.Location = new System.Drawing.Point(12, 58);
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
            this.RTBMotherboard.Location = new System.Drawing.Point(12, 160);
            this.RTBMotherboard.Name = "RTBMotherboard";
            this.RTBMotherboard.Size = new System.Drawing.Size(352, 73);
            this.RTBMotherboard.TabIndex = 13;
            this.RTBMotherboard.Text = "Manufacturer: NA\nProduct: NA\nSerialNumber: NA";
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.Color.White;
            this.richTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.richTextBox2.Location = new System.Drawing.Point(12, 356);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(352, 73);
            this.richTextBox2.TabIndex = 14;
            this.richTextBox2.Text = "PlaceHolder";
            // 
            // LBLMotherboardInfo
            // 
            this.LBLMotherboardInfo.Location = new System.Drawing.Point(12, 134);
            this.LBLMotherboardInfo.Name = "LBLMotherboardInfo";
            this.LBLMotherboardInfo.Size = new System.Drawing.Size(139, 23);
            this.LBLMotherboardInfo.TabIndex = 15;
            this.LBLMotherboardInfo.Text = "Motherboard Information:";
            this.LBLMotherboardInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 23);
            this.label1.TabIndex = 16;
            this.label1.Text = "CPULoad:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.TickTock);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(35, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(302, 48);
            this.label2.TabIndex = 17;
            this.label2.Text = "This Screen is under construction, \r\nMay be unstable";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 441);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LBLMotherboardInfo);
            this.Controls.Add(this.richTextBox2);
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
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label LBLMotherboardInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
    }
}