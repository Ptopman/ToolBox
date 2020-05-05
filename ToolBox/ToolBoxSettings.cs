using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToolBox
{
    public partial class ToolBoxSettings : Form
    {
        public ToolBoxSettings()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            //this.FormBorderStyle = FormBorderStyle.None;
            this.CenterToParent();
            //notepad++
            //putty
        }

        private void ToolBoxSettings_Load(object sender, EventArgs e)
        {
            LBTBSappselection.SelectedIndex = 0;
            PullPath();
            CBTBSrdp.Checked = Properties.Settings.Default.ShowRDPIcon;
            CBTBSputty.Checked = Properties.Settings.Default.ShowPuttyIcon;
        }

        private void LBTBSappselection_SelectedIndexChanged(object sender, EventArgs e)
        {
            PullPath();
        }

        private void PullPath()
        {
            string app = LBTBSappselection.SelectedItem.ToString();
            switch (app)
            {
                case "Notepad++":
                    TBTBSapppath.Text = Properties.Settings.Default.NotepadPPPath;
                    break;
                case "Putty":
                    TBTBSapppath.Text = Properties.Settings.Default.PuttyPath;
                    break;
            }
        }

        private void BTNTBSBrowse_Click(object sender, EventArgs e)
        {
            string path = "";
            if (OFDTBSpathselect.ShowDialog() == DialogResult.OK)
            {
                path = OFDTBSpathselect.FileName;
                TBTBSapppath.Text = path;
            }
        }

        private void BTNTBSsave_Click(object sender, EventArgs e)
        {
            string app = LBTBSappselection.SelectedItem.ToString();
            switch (app)
            {
                case "Notepad++":
                    Properties.Settings.Default.NotepadPPPath = TBTBSapppath.Text;
                    break;
                case "Putty":
                    Properties.Settings.Default.PuttyPath = TBTBSapppath.Text;
                    break;
            }
            Properties.Settings.Default.Save();
        }

        private void BTNTBScancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CBTBSrdp_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.ShowRDPIcon = CBTBSrdp.Checked;
            Properties.Settings.Default.Save();
        }

        private void CBTBSputty_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.ShowPuttyIcon = CBTBSputty.Checked;
            Properties.Settings.Default.Save();
        }

        private void BTNTBShelp_Click(object sender, EventArgs e)
        {
            ToolBoxSettingsHelp TBSH = new ToolBoxSettingsHelp();
            TBSH.ShowDialog();
            
        }
    }
}
