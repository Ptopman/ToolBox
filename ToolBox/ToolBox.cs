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
    public partial class ToolBox : Form
    {

        public ToolBox()
        {
            InitializeComponent();
        }

        //Hide fourm icon on load
        private void ToolBox_Load(object sender, EventArgs e)
        {
            LBLVersion.Text = Application.ProductVersion;
            this.CenterToScreen();
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
            try
            {
                System.Diagnostics.Process.Start("notepad++.exe");
            }
            catch(Exception)
            {
                MessageBox.Show("Cannot find Notepad++ exicutible", "Error");
            }
            
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
            //More comments on whats happening near end of program
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo
            {
                WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden,
                FileName = "cmd.exe",
                //This argument starts the Performance Reliability Monitor
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
            //More comments on whats happening near end of program
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo
            {
                WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden,
                FileName = "cmd.exe",
                //This argument start the Windows 10 settings
                Arguments = "/C start ms-settings:settings"
            };
            process.StartInfo = startInfo;
            process.Start();
            process.Dispose();
        }

        //Open windows 10 display settings
        private void BTNDisplaySet_Click(object sender, EventArgs e)
        {
            //More comments on whats happening near end of program
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo
            {
                WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden,
                FileName = "cmd.exe",
                //This argument start the Windows 10 display settings
                Arguments = "/C start ms-settings:display"
            };
            process.StartInfo = startInfo;
            process.Start();
            process.Dispose();
        }

        //Stop toolbox application
        private void BTNShutToolBox_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        //Restart method
        private void Restart()
        {
            //Displayed a yes / no dialog windows asking if you want to restart
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to restart?", "Restart", MessageBoxButtons.YesNo);
            //If dialog window yes is pressed
            if (dialogResult == DialogResult.Yes)
            {
                //New process
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                //Process start information
                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo
                {
                    //Keep window hidded
                    WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden,
                    //Process is Command prompt
                    FileName = "cmd.exe",
                    //Arguments to be passed to the command prompt
                    Arguments = "/C shutdown /r /t 10"
                    //Argument needs to start with /C, command is "Shutdown", /r is restart, /t is count down followed by number of seconds
                };
                //Passing the start information to the process start
                process.StartInfo = startInfo;
                //Start the process, command will run
                process.Start();
                //Once compleated, dispose of process
                process.Dispose();
            }
            //if dialog window no is pressed
            else if (dialogResult == DialogResult.No)
            {
                //NOTHING, DO NOTHING!!!
            }
        }

        //Shutdown method
        private void Shutdown()
        {
            //Displayed a yes / no dialog windows asking if you want to shutdown
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to shutdown?", "Shutdown", MessageBoxButtons.YesNo);
            //If dialog window yes is pressed
            if (dialogResult == DialogResult.Yes)
            {
                //new process
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                //Process start information
                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo
                {
                    //Keep window hidded
                    WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden,
                    //Process is command prompt
                    FileName = "cmd.exe",
                    //arguments to be passed to the command prompt
                    Arguments = "/C shutdown /s /t 10"
                    //Argument needs to start with /C, command is "Shutdown", /s is shutdown, /t is count down followed by number of seconds
                };
                //Passing the start information to the process start
                process.StartInfo = startInfo;
                //Start the process, command will run
                process.Start();
                //Once compleated, dispose of process
                process.Dispose();
            }
            //If dialog window no is pressed
            else if (dialogResult == DialogResult.No)
            {
                //NOTHING, DO NOTHING!!!
            }
        }

        //call shutdown method when pressed
        private void BTNShutdown_Click(object sender, EventArgs e)
        {
            Shutdown();
        }
    }
}
