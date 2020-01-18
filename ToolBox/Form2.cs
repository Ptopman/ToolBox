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

        string txt = "CPULoad: ";

        private void TickTock(object sender, EventArgs e)
        {
            Task t = Task.Run(() =>
            {
                ManagementObjectSearcher CPUUsage = new ManagementObjectSearcher("Select * From " + "Win32_Processor");
                foreach (ManagementObject share in CPUUsage.Get())
                {
                    txt = ("CPULoad: " + share["LoadPercentage"].ToString());
                }
            });

            label1.Text = txt;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            RTBCpuInfo.ReadOnly = true;
            RTBMotherboard.ReadOnly = true;
            timer1.Start();
            ManagementObjectSearcher CPUSearch = new ManagementObjectSearcher("Select * From " + "Win32_Processor");
            foreach (ManagementObject share in CPUSearch.Get())
            {
                RTBCpuInfo.Text = "";
                RTBCpuInfo.AppendText("Name: " + share["Name"] + "\n".ToString());
                RTBCpuInfo.AppendText("NumberOfCores: " + share["NumberOfCores"] + "\n".ToString());
                RTBCpuInfo.AppendText("NumberOfLogicalProcessors: " + share["NumberOfLogicalProcessors"] + "\n".ToString());
                RTBCpuInfo.AppendText("Status: " + share["Status"] + "\n".ToString());
                RTBCpuInfo.AppendText("SystemName: " + share["SystemName"].ToString());
            }

            ManagementObjectSearcher MBSearcher = new ManagementObjectSearcher("Select * From " + "Win32_BaseBoard");
            foreach (ManagementObject share in MBSearcher.Get())
            {
                RTBMotherboard.Text = "";
                RTBMotherboard.AppendText("Manufacturer: " + share["Manufacturer"] + "\n".ToString());
                RTBMotherboard.AppendText("Product: " + share["Product"] + "\n".ToString());
                RTBMotherboard.AppendText("SerialNumber: " + share["SerialNumber"].ToString());
            }
        }
    }
}
