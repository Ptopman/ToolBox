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
    public partial class MenuStrip : Form
    {
        public MenuStrip()
        {
            InitializeComponent();
            //On form load, minimize window
            this.WindowState = FormWindowState.Minimized;
        }

        //Hide fourm icon on load
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Hide();
        }

        //This is for the context menu strip on the icon
        private void NotifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                //Add buttons to the context menu
                this.NIToolBox.ContextMenuStrip = new System.Windows.Forms.ContextMenuStrip();
                this.NIToolBox.ContextMenuStrip.Items.Add("Open ToolBox", null, this.IconOpenToolBox_click);
                this.NIToolBox.ContextMenuStrip.Items.Add("Task Manager", null, this.IconOpenTask_click);
                this.NIToolBox.ContextMenuStrip.Items.Add(new ToolStripSeparator());
                this.NIToolBox.ContextMenuStrip.Items.Add("Close ToolBox", null, this.IconExitToolbox_click).ForeColor = Color.Red;
                this.NIToolBox.ContextMenuStrip.Items.Add("Restart", null, this.IconRestart_click).ForeColor = Color.Red;
                this.NIToolBox.ContextMenuStrip.Items.Add("Shutdown", null, this.IconShutdown_click).ForeColor = Color.Red;
            }
        }

        //Opens shows Form1 (toolbox) and sets the window state to normal
        void IconOpenToolBox_click(object sender, EventArgs e)
        {
            ToolBox tbForm = new ToolBox();
            tbForm.Show();
        }

        //Opens task manager via method
        void IconOpenTask_click(object sender, EventArgs e)
        {
            TaskMan();
        }

        //Sets the flag to 1 to skip e.Cancel in Form1_FormClosing 
        void IconExitToolbox_click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //calles the restart method when pressed
        void IconRestart_click(object sender, EventArgs e)
        {
            Restart();
        }

        //called the shutdown method when pressed
        void IconShutdown_click(object sender, EventArgs e)
        {
            Shutdown();
        }

        //Open pannel for computer information
        private void NotifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            LoadingForm f3 = new LoadingForm();
            f3.Show();
            //Create new form2 () object
            SystemInformaitonForm SysInfoForm = new SystemInformaitonForm(f3);
            //Start and show the form
            SysInfoForm.Show();
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