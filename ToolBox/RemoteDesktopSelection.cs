﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ToolBox
{
    public partial class RemoteDesktopSelection : Form
    {
        public RemoteDesktopSelection()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void RemoteDesktopSelection_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.RDPSettingsPath == "NA")
            {
                MessageBox.Show("Please set path for RDP list in settings", "RDP File Error");
            }
            LoadList();
        }

        private void LoadList()
        {
            LBRDPcomputers.Items.Clear();
            try
            {
                using (StreamReader sr = new StreamReader(Properties.Settings.Default.RDPSettingsPath))
                {
                    while (!sr.EndOfStream)
                    {
                        string strItem = sr.ReadLine();
                        LBRDPcomputers.Items.Add(strItem);
                    }
                    LBRDPcomputers.SelectedIndex = 0;
                    sr.Close();
                }
            }
            catch
            {

            }
        }

        private void BTNRDPconnect_Click(object sender, EventArgs e)
        {
            string item = LBRDPcomputers.SelectedItem.ToString();
            int index = item.IndexOf("- ");
            string ip = item.Substring(index + 2);
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo
            {
                WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden,
                FileName = "cmd.exe",
                //This argument starts Remote Desktop and passes the Ip
                Arguments = "/C mstsc /v:" + ip
            };
            process.StartInfo = startInfo;
            process.Start();
            process.Dispose();

            if (Properties.Settings.Default.RDPClose == true)
            {
                this.Close();
            }
        }

        private void BTNRDPadd_Click(object sender, EventArgs e)
        { 
            if(TBRDPdescription.Text == "")
            {
                TBRDPdescription.Text = "NA";
            }
            if(TBRDPip.Text != "")
            {
                LBRDPcomputers.Items.Add(TBRDPdescription.Text + " - " + TBRDPip.Text);
                TBRDPip.Text = "";
                TBRDPdescription.Text = "";
            }
            else
            {
                MessageBox.Show("IP address empty!", "Error");
            }
            
        }

        private void BTNRDPremove_Click(object sender, EventArgs e)
        {
            try { LBRDPcomputers.Items.RemoveAt(LBRDPcomputers.SelectedIndex); } catch{ }
        }

        private void BTNRDPsave_Click(object sender, EventArgs e)
        {
            try
            {
                var path = Path.Combine("C:\\Users", Environment.UserName, "Documents\\ToolBox\\RDPList.txt");
                StreamWriter SaveFile = new StreamWriter(path);
                foreach (var item in LBRDPcomputers.Items)
                {
                    SaveFile.WriteLine(item.ToString());
                }
                SaveFile.Close();
            }
            catch
            {

            }
            
        }

        private void BTNRDPsettings_Click(object sender, EventArgs e)
        {
            RDPsettings rdpsettings = new RDPsettings();
            rdpsettings.ShowDialog();
            LoadList();
        }
    }
}
