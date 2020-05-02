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
            if (Properties.Settings.Default.Path == "NA")
            {
                MessageBox.Show("Please set path for RDP list in settings", "RDP File Error");
            }
            LoadList();
        }

        private void LoadList()
        {
            //var path = Path.Combine("C:\\Users" , Environment.UserName , "Documents\\ToolBox\\RDPList.txt");
            LBRDPcomputers.Items.Clear();
            try
            {
                //textBox1.Text = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
                //using (StreamReader sr = new StreamReader(path))
                using (StreamReader sr = new StreamReader(Properties.Settings.Default.Path))
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
                //This argument starts the Performance Reliability Monitor
                Arguments = "/C mstsc /v:" + ip
            };
            process.StartInfo = startInfo;
            process.Start();
            process.Dispose();

            if (Properties.Settings.Default.RDPClose == true)
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
