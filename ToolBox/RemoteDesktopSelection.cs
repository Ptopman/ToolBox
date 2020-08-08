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
            Connect();
        }

        private void LBRDPcomputers_DoubleClick(object sender, MouseEventArgs e)
        {
            Connect();
        }

        private void Connect()
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
            Save();

        }

        private void BTNRDPremove_Click(object sender, EventArgs e)
        {
            try { LBRDPcomputers.Items.RemoveAt(LBRDPcomputers.SelectedIndex); } catch{ }
            LBRDPcomputers.SelectedIndex = 0;
            Save();
        }

        private void Save()
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


        private void BTNRDEdit_Click(object sender, EventArgs e)
        {
            
            int index = LBRDPcomputers.SelectedIndex;
            LBRDPcomputers.Items.RemoveAt(index);
            LBRDPcomputers.Items.Insert(index, TBRDPdescription.Text + " - " + TBRDPip.Text);
            LBRDPcomputers.SelectedIndex = index;
        }

        private void BTNRDPsettings_Click(object sender, EventArgs e)
        {
            RDPsettings rdpsettings = new RDPsettings();
            rdpsettings.ShowDialog();
            LoadList();
        }

        public void MoveItem(int direction)
        {
            // Checking selected item
            if (LBRDPcomputers.SelectedItem == null || LBRDPcomputers.SelectedIndex < 0)
                return; // No selected item - nothing to do

            // Calculate new index using move direction
            int newIndex = LBRDPcomputers.SelectedIndex + direction;

            // Checking bounds of the range
            if (newIndex < 0 || newIndex >= LBRDPcomputers.Items.Count)
                return; // Index out of range - nothing to do

            object selected = LBRDPcomputers.SelectedItem;

            // Removing removable element
            LBRDPcomputers.Items.Remove(selected);
            // Insert it in new position
            LBRDPcomputers.Items.Insert(newIndex, selected);
            // Restore selection
            LBRDPcomputers.SetSelected(newIndex, true);
        }

        private void BTNMoveUp_Click(object sender, EventArgs e)
        {
            MoveItem(-1);
        }

        private void BTNMoveDown_Click(object sender, EventArgs e)
        {
            MoveItem(1);
        }

        private void LBRDPcomputers_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void LBRDPcomputers_Click(object sender, EventArgs e)
        {
            try
            {
                string itm = "";

                itm = LBRDPcomputers.SelectedItem.ToString();
                int index = itm.IndexOf("- ");
                TBRDPip.Text = itm.Substring(index + 2);

                TBRDPdescription.Text = itm.Substring(0, index - 1);
            }
            catch
            {

            }
        }
    }
}
