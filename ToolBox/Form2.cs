﻿using System;
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
        Form3 f3 = new Form3();
        public Form2()
        {
            f3.Show();
            InitializeComponent();
        }

        private Int64 totalMemory = 0;
        PerformanceCounter CpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
        PerformanceCounter MemCounter = new PerformanceCounter("Memory", "Available MBytes");

        //Using a timer to update CPU load %
        private void TickTock(object sender, EventArgs e)
        {
            //ima comment this at a later point...
            double CPU = 0;
            CPU = CpuCounter.NextValue();
            CPU = Math.Round(CPU, 2);
            LBLCPULoad.Text = "CPULoad: " + CPU.ToString() + "%";

            LBLMemoryAvailable.Text = "Memory Available: " + MemCounter.NextValue() + "MB / " + totalMemory + "MB"; 
        }

        private void TickTock2(object sender, EventArgs e)
        {
            GC.Collect();
        }

        //On the form loading...
        private void Form2_Load(object sender, EventArgs e)
        {
            //Making the Rich Text Boxes read only  
            RTBCpuInfo.ReadOnly = true;
            RTBMotherboard.ReadOnly = true;
            //Starting timers
            timer1.Start();
            timer2.Start();
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
                RTBMotherboard.AppendText("SerialNumber: " + share["SerialNumber"] + "\n".ToString());
            }

            ManagementObjectSearcher BiosSearcher = new ManagementObjectSearcher("Select * From " + "Win32_BIOS");
            foreach (ManagementObject share in BiosSearcher.Get())
            {
                RTBMotherboard.AppendText("BIOS Version: " + (string)share["SMBIOSBIOSVersion"] + "\n");
                string relDt = (string)share["ReleaseDate"];
                DateTime dt = ManagementDateTimeConverter.ToDateTime(relDt);
                RTBMotherboard.AppendText("Bios Release Date: " + dt.ToString("MM-dd-yyy"));
            }

            ManagementObjectSearcher MemorySearcher = new ManagementObjectSearcher("Select * From Win32_ComputerSystem");
            foreach (ManagementObject share in MemorySearcher.Get())
            {
                totalMemory = Convert.ToInt64(share["TotalPhysicalMemory"]);
                totalMemory /= 1024;
                totalMemory /= 1024;
                richTextBox2.AppendText(totalMemory.ToString());
            }


            f3.Close();
        }
    }
}
