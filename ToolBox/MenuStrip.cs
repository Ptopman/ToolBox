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
                this.NIToolBox.ContextMenuStrip.Items.Add("Open System Info", null, this.IconOpenSystemSpecs_click);
                this.NIToolBox.ContextMenuStrip.Items.Add("Task Manager", null, this.IconOpenTask_click);
                this.NIToolBox.ContextMenuStrip.Items.Add("RDP", null, this.IconOpenRDP_click);
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
            //Open Task Manager
            System.Diagnostics.Process.Start("Taskmgr.exe");
        }

        //Sets the flag to 1 to skip e.Cancel in Form1_FormClosing 
        void IconExitToolbox_click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //calles the restart method when pressed
        void IconRestart_click(object sender, EventArgs e)
        {
            RestartShutdown rs = new RestartShutdown();
            rs.Restart();
        }

        //called the shutdown method when pressed
        void IconShutdown_click(object sender, EventArgs e)
        {
            RestartShutdown rs = new RestartShutdown();
            rs.Shutdown();
        }

        //Open pannel for computer information
        void IconOpenSystemSpecs_click(object sender, EventArgs e)
        {
            LoadingForm f3 = new LoadingForm();
            f3.Show();
            //Create new form2 () object
            SystemInformaitonForm SysInfoForm = new SystemInformaitonForm(f3);
            //Start and show the form
            SysInfoForm.Show();
        }

        
        private void NotifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            /*
            LoadingForm f3 = new LoadingForm();
            f3.Show();
            //Create new form2 () object
            SystemInformaitonForm SysInfoForm = new SystemInformaitonForm(f3);
            //Start and show the form
            SysInfoForm.Show();
            */
        }

        private void IconOpenRDP_click(object sender, EventArgs e)
        {
            RemoteDesktopSelection rdp = new RemoteDesktopSelection();
            rdp.Show();
        }


    }
}