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

            //disables the maximize and minimize buttons and disables user interface dragging
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        //Hide fourm icon on load
        private void ToolBox_Load(object sender, EventArgs e)
        {
            //Add product version to the main ToolBox application
            LBLVersion.Text = Application.ProductVersion;

            //Centers ToolBox
            this.CenterToScreen();

            CheckNotepadPP();
        }

        //-----Buttons-----
        //Open Classic sound control panel
        private void BTNCPSound_Click(object sender, EventArgs e)
        {
            StartSpecProccess("/name Microsoft.Sound");
        }

        //Open classic control panel
        private void BTNControl_Click(object sender, EventArgs e)
        {
            StartProcess("control");
        }

        //Open classic program uninstall panel
        private void BTNUninstall_Click(object sender, EventArgs e)
        {
            StartSpecProccess("/name Microsoft.ProgramsAndFeatures");
        }

        //Open network and sharing center
        private void BTNNetShareCent_Click(object sender, EventArgs e)
        {
            StartSpecProccess("/name Microsoft.NetworkAndSharingCenter");
        }

        //Open network adapters
        private void BTNNetAdap_Click(object sender, EventArgs e)
        {
            StartSpecProccess("NCPA.cpl");
        }

        //Open notepad
        private void BTNNotepad_Click(object sender, EventArgs e)
        {
            StartProcess("notepad.exe");
        }

        //Open notepad++
        private void BTNNotepadPP_Click(object sender, EventArgs e)
        {
            StartProcess(Properties.Settings.Default.NotepadPPPath);
        }

        //Open performance monitor
        private void BTNPerfMon_Click(object sender, EventArgs e)
        {
            StartProcess("perfmon.exe");
        }

        //Open Resource monitor
        private void BTNResMon_Click(object sender, EventArgs e)
        {
            StartProcess("resmon.exe");
        }

        //Open non admin command prompt window
        private void BTNCmd_Click(object sender, EventArgs e)
        {
            StartProcess("cmd.exe");
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
            StartProcess("devmgmt.msc");
        }

        //Open disk manager
        private void BTNDiskMan_Click(object sender, EventArgs e)
        {
            StartProcess("diskmgmt.msc");
        }

        //Open regedit
        private void BTNRegedit_Click(object sender, EventArgs e)
        {
            StartProcess("regedit.exe");
        }

        //Open task manager
        private void BTNTaksMan_Click(object sender, EventArgs e)
        {
            TaskMan();
        }

        //Open system configuration
        private void BTNSysConfig_Click(object sender, EventArgs e)
        {
            StartProcess("msconfig.exe");
        }

        //Open system information
        private void BTNSysInfo_Click(object sender, EventArgs e)
        {
            StartProcess("msinfo32.exe");
        }

        //Open memory diag
        private void BTNMemDiag_Click(object sender, EventArgs e)
        {
            StartProcess("MdSched.exe");
        }

        //Open reliability monitor
        private void BTNReliabilityMon_Click(object sender, EventArgs e)
        {
            CommandPrompt("/C perfmon /rel");
        }

        //Open Remote desktop
        private void BTNRDP_Click(object sender, EventArgs e)
        {
            RemoteDesktopSelection RDPS = new RemoteDesktopSelection();
            RDPS.Show();
        }

        //Open Keybaord settings
        private void BTNKeybaord_Click(object sender, EventArgs e)
        {
            StartSpecProccess("/name Microsoft.Keyboard");
        }

        //Open Mouse settings
        private void BTNMouse_Click(object sender, EventArgs e)
        {
            StartSpecProccess("/name Microsoft.Mouse");
        }

        //Open on screen keyboard
        private void BTNosk_Click(object sender, EventArgs e)
        {
            StartProcess("osk.exe");
        }

        //Open services
        private void BTNServices_Click(object sender, EventArgs e)
        {
            StartProcess("services.msc");
        }

        //Open windows 10 settings
        private void BTNW10Settings_Click(object sender, EventArgs e)
        {
            CommandPrompt("/C start ms-settings:settings");
        }

        //Open windows 10 display settings
        private void BTNDisplaySet_Click(object sender, EventArgs e)
        {
            CommandPrompt("/C start ms-settings:display");
        }

        //Stop toolbox application
        private void BTNShutToolBox_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BTNTBSettings_Click(object sender, EventArgs e)
        {
            ToolBoxSettings TBS = new ToolBoxSettings();
            TBS.ShowDialog();
            CheckNotepadPP();
        }

        //-----Methods-----
        //Start task manager
        private void TaskMan()
        {
            StartProcess("Taskmgr.exe");
        }

        //Restart and shutdown prompts
        private void BTNRestart_Click(object sender, EventArgs e)
        {
            Restart();
        }

        //Restart method
        private void Restart()
        {
            RestartShutdown rs = new RestartShutdown();
            rs.Restart();
        }

        //Shutdown method
        private void Shutdown()
        {
            RestartShutdown rs = new RestartShutdown();
            rs.Shutdown();
        }

        //call shutdown method when pressed
        private void BTNShutdown_Click(object sender, EventArgs e)
        {
            Shutdown();
        }

        //Starts Process
        private void StartProcess(string p)
        {
            System.Diagnostics.Process.Start(p);
        }

        //Starts proccess that needs a control path
        private void StartSpecProccess(string p)
        {
            string controlpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), "control.exe");
            Process.Start(controlpath, p);
        }

        //Method for command prompt
        private void CommandPrompt(string arg)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo
            {
                WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden,
                FileName = "cmd.exe",
                Arguments = arg
            };
            process.StartInfo = startInfo;
            process.Start();
            process.Dispose();
        }

        private void CheckNotepadPP()
        {

            //Checks to see if Notepad++ is installed on the computer
            //If it cannot find the exacutable then it will disable the button
            if (File.Exists(Properties.Settings.Default.NotepadPPPath))
            {
                BTNNotepadPP.Enabled = true;
            }
            else
            {
                BTNNotepadPP.Enabled = false;
            }
        }
    }
}
