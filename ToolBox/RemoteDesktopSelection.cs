using System;
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
        }

        private void RemoteDesktopSelection_Load(object sender, EventArgs e)
        {
            try
            {
                using (StreamReader sr = new StreamReader("RDPList.txt"))
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
            catch { }
            CBRDPcloseOnOpen.Checked = Properties.Settings.Default.RDPClose;
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
                //This argument starts the Performance Reliability Monitor
                Arguments = "/C mstsc /v:" + ip
            };
            process.StartInfo = startInfo;
            process.Start();
            process.Dispose();

            if (CBRDPcloseOnOpen.Checked)
            {
                this.Close();
            }
            //Console.WriteLine(ip);
        }

        private void BTNRDPadd_Click(object sender, EventArgs e)
        { 
            if(TBRDPdescription.Text == "")
            {
                TBRDPdescription.Text = "NA";
            }
            LBRDPcomputers.Items.Add(TBRDPdescription.Text + "- " + TBRDPip.Text);
            TBRDPip.Text = "";
            TBRDPdescription.Text = "";
        }

        private void BTNRDPremove_Click(object sender, EventArgs e)
        {
            try { LBRDPcomputers.Items.RemoveAt(LBRDPcomputers.SelectedIndex); } catch{ }
        }

        private void BTNRDPsave_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter SaveFile = new StreamWriter("RDPList.txt");
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

        private void CBRDPcloseOnOpen_CheckedChanged(object sender, EventArgs e)
        {
            if(CBRDPcloseOnOpen.Checked)
            {
                Properties.Settings.Default.RDPClose = true;
            }
            else
            {
                Properties.Settings.Default.RDPClose = false;
            }
            Properties.Settings.Default.Save();
        }
    }
}
