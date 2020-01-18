using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToolBox
{
    public partial class Form1 : Form
    {
        //Dont judge me
        int flag = 0;
        public Form1()
        {
            InitializeComponent();
            //On form load, minimize window
            this.WindowState = FormWindowState.Minimized;
        }

        //-----Buttons-----
        //Open Classic sound control panel
        private void BTNCPSound_Click(object sender, EventArgs e)
        {
            string controlpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), "control.exe");
            Process.Start(controlpath, "/name Microsoft.Sound");
        }

        //Open classic control panel
        private void BTNControl_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("control");
        }

        //Open classic program uninstall panel
        private void BTNUninstall_Click(object sender, EventArgs e)
        {
            string controlpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), "control.exe");
            Process.Start(controlpath, "/name Microsoft.ProgramsAndFeatures");
        }

        //Open network and sharing center
        private void BTNNetShareCent_Click(object sender, EventArgs e)
        {
            string controlpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), "control.exe");
            Process.Start(controlpath, "/name Microsoft.NetworkAndSharingCenter");
        }

        //Open network adapters
        private void BTNNetAdap_Click(object sender, EventArgs e)
        {
            string controlpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), "control.exe");
            Process.Start(controlpath, "NCPA.cpl");
        }

        //Open notepad
        private void BTNNotepad_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad.exe");
        }

        //Open notepad++
        private void BTNNotepadPP_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad++.exe");
        }

        //Open performance monitor
        private void BTNPerfMon_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("perfmon.exe");
        }

        //Open Resource monitor
        private void BTNResMon_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("resmon.exe");
        }

        //Open non admin command prompt window
        private void BTNCmd_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("cmd.exe");
        }

        //Open Admin command prompt window
        private void BTNCmdAd_Click(object sender, EventArgs e)
        {
            ProcessStartInfo info = new ProcessStartInfo("cmd.exe")
            {
                UseShellExecute = true,
                Verb = "runas"
            };
            Process.Start(info);
        }

        //Open device manager
        private void BTNDeviceMan_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("devmgmt.msc");
        }

        //Open disk manager
        private void BTNDiskMan_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("diskmgmt.msc");
        }

        //Open regedit
        private void BTNRegedit_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("regedit.exe");
        }

        //Open task manager
        private void BTNTaksMan_Click(object sender, EventArgs e)
        {
            TaskMan();
        }

        //Open system configuration
        private void BTNSysConfig_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("msconfig.exe");
        }

        //Open system information
        private void BTNSysInfo_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("msinfo32.exe");
        }

        //Open memory diag
        private void BTNMemDiag_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("MdSched.exe");
        }

        //Open reliability monitor
        private void BTNReliabilityMon_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo
            {
                WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden,
                FileName = "cmd.exe",
                Arguments = "/C perfmon /rel"
            };
            process.StartInfo = startInfo;
            process.Start();
            process.Dispose();
        }

        //Open Remote desktop
        private void BTNRDP_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("mstsc.exe");
        }

        //Open Keybaord settings
        private void BTNKeybaord_Click(object sender, EventArgs e)
        {
            string controlpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), "control.exe");
            Process.Start(controlpath, "/name Microsoft.Keyboard");
        }

        //Open Mouse settings
        private void BTNMouse_Click(object sender, EventArgs e)
        {
            string controlpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), "control.exe");
            Process.Start(controlpath, "/name Microsoft.Mouse");
        }





        //Open on screen keyboard
        private void BTNosk_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("osk.exe");
        }

        //Open services
        private void BTNServices_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("services.msc");
        }

        //Open windows 10 settings
        private void BTNW10Settings_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo
            {
                WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden,
                FileName = "cmd.exe",
                Arguments = "/C start ms-settings:settings"
            };
            process.StartInfo = startInfo;
            process.Start();
            process.Dispose();
        }

        //Open windows 10 display settings
        private void BTNDisplaySet_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo
            {
                WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden,
                FileName = "cmd.exe",
                Arguments = "/C start ms-settings:display"
            };
            process.StartInfo = startInfo;
            process.Start();
            process.Dispose();
        }

        //Stop toolbox application
        private void BTNShutToolBox_Click(object sender, EventArgs e)
        {
            flag = 1;
            Application.Exit();
        }

        //Hide fourm icon on load
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Hide();
        }

        //When user presses the windows fourm exit button, it minimizes it instead of closing the application
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(flag == 0)
            {
                e.Cancel = true;
                this.WindowState = FormWindowState.Minimized;
                this.Hide();
            }
        }

        //This is for the context menu strip on the icon
        private void NotifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.NIToolBox.ContextMenuStrip = new System.Windows.Forms.ContextMenuStrip();
                this.NIToolBox.ContextMenuStrip.Items.Add("Open ToolBox", null, this.IconOpenToolBox_click);
                this.NIToolBox.ContextMenuStrip.Items.Add("Task Manager", null, this.IconOpenTask_click);
                this.NIToolBox.ContextMenuStrip.Items.Add(new ToolStripSeparator());
                this.NIToolBox.ContextMenuStrip.Items.Add("Close ToolBox", null, this.IconExitToolbox_click).ForeColor = Color.Red;
                this.NIToolBox.ContextMenuStrip.Items.Add("Restart", null, this.IconRestart_click).ForeColor = Color.Red;
                this.NIToolBox.ContextMenuStrip.Items.Add("Shutdown", null, this.IconShutdown_click).ForeColor = Color.Red;
            }
        }
        void IconOpenToolBox_click(object sender, EventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
        }

        void IconOpenTask_click(object sender, EventArgs e)
        {
            TaskMan();
        }

        void IconExitToolbox_click(object sender, EventArgs e)
        {
            flag = 1;
            Application.Exit();
        }
        void IconRestart_click(object sender, EventArgs e)
        {
            Restart();
        }
        void IconShutdown_click(object sender, EventArgs e)
        {
            Shutdown();
        }
        //Open pannel for computer information
        private void NotifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        //-----Methods-----
        //Start task manager
        private void TaskMan()
        {
            System.Diagnostics.Process.Start("Taskmgr.exe");
        }

        //Restart and shutdown prompts
        private void BTNRestart_Click(object sender, EventArgs e)
        {
            Restart();
        }
        private void Restart()
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to restart?", "Restart", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo
                {
                    WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden,
                    FileName = "cmd.exe",
                    Arguments = "/C shutdown /r /t 10"
                };
                process.StartInfo = startInfo;
                process.Start();
                process.Dispose();
            }
            else if (dialogResult == DialogResult.No)
            {
                
            }
        }

        private void Shutdown()
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to shutdown?", "Shutdown", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo
                {
                    WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden,
                    FileName = "cmd.exe",
                    Arguments = "/C shutdown /s /t 10"
                };
                process.StartInfo = startInfo;
                process.Start();
                process.Dispose();
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void BTNShutdown_Click(object sender, EventArgs e)
        {
            Shutdown();
        }
    }
}