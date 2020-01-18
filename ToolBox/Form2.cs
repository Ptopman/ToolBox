using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Management;
using System.Diagnostics;

namespace ToolBox
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        //   :/
        private string CPULoadtxt = "CPULoad: ";

        //Using a timer to update CPU load %
        private void TickTock(object sender, EventArgs e)
        {
            //Creating a thread so that it does not lock up the form
            Task t = Task.Run(() =>
            {
                //Grabbing all information about Win32_Processer
                ManagementObjectSearcher CPUUsage = new ManagementObjectSearcher("Select * From " + "Win32_Processor");
                //Looping through the CPUUsage object
                foreach (ManagementObject share in CPUUsage.Get())
                {
                    //Setting "LoadPercentage" from share to text veriable
                    CPULoadtxt = ("CPULoad: " + share["LoadPercentage"].ToString());
                }
            });

            //updating veriable with cpu load percentage
            LBLCPULoad.Text = CPULoadtxt;
        }

        //On the form loading...
        private void Form2_Load(object sender, EventArgs e)
        {
            //Making the Rich Text Boxes read only  
            RTBCpuInfo.ReadOnly = true;
            RTBMotherboard.ReadOnly = true;
            //Starting timer1 tick
            timer1.Start();
            //Grabbing all information about Win32_Processor
            ManagementObjectSearcher CPUSearch = new ManagementObjectSearcher("Select * From " + "Win32_Processor");
            //Looping through the CPUSearch object
            foreach (ManagementObject share in CPUSearch.Get())
            {
                //Clearing the text box
                RTBCpuInfo.Text = "";
                //Setting the share[""] to appropriate veriable
                RTBCpuInfo.AppendText("Name: " + share["Name"] + "\n".ToString());
                RTBCpuInfo.AppendText("NumberOfCores: " + share["NumberOfCores"] + "\n".ToString());
                RTBCpuInfo.AppendText("NumberOfLogicalProcessors: " + share["NumberOfLogicalProcessors"] + "\n".ToString());
                RTBCpuInfo.AppendText("Status: " + share["Status"] + "\n".ToString());
                RTBCpuInfo.AppendText("SystemName: " + share["SystemName"].ToString());
            }

            //Grabbing all information about Win32_BaseBoard
            ManagementObjectSearcher MBSearcher = new ManagementObjectSearcher("Select * From " + "Win32_BaseBoard");
            //Looping through the MBSearcher object
            foreach (ManagementObject share in MBSearcher.Get())
            {
                //Clearing the text box
                RTBMotherboard.Text = "";
                //Setting the share[""] to appropriate veriable
                RTBMotherboard.AppendText("Manufacturer: " + share["Manufacturer"] + "\n".ToString());
                RTBMotherboard.AppendText("Product: " + share["Product"] + "\n".ToString());
                RTBMotherboard.AppendText("SerialNumber: " + share["SerialNumber"].ToString());
            }
        }
    }
}
