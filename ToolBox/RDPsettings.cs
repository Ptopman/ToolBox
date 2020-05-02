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
    public partial class RDPsettings : Form
    {
        public RDPsettings()
        {
            InitializeComponent();
            TBRDPsettingsFilePath.Text = Properties.Settings.Default.Path;
            CBRDPcloseOnOpen.Checked = Properties.Settings.Default.RDPClose;
        }

        private void BTNRDPsettingsFileSelection_Click(object sender, EventArgs e)
        {
            string path = "";
            if(FDRDPfileSelect.ShowDialog() == DialogResult.OK)
            {
                path = FDRDPfileSelect.FileName;
            }
            TBRDPsettingsFilePath.Text = path;
            
        }

        private void BTNRDPsettingsSaveClose_Click(object sender, EventArgs e)
        {
            Check();
            Properties.Settings.Default.Path = TBRDPsettingsFilePath.Text;
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void Check()
        {
            if (CBRDPcloseOnOpen.Checked)
            {
                Properties.Settings.Default.RDPClose = true;
            }
            else
            {
                Properties.Settings.Default.RDPClose = false;
            }
        }

        private void BTNRDPsettingsCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
