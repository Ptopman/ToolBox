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
using System.Net.NetworkInformation;

namespace ToolBox
{
    public partial class Form2 : Form
    {
        Form3 f3 = new Form3();

        public Form2()
        {
            InitializeComponent();
        }

        private Int64 totalMemory = 0;

        //Performance Counter Objects for processor speed, Available memory, and the System uptime.
        PerformanceCounter CpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
        PerformanceCounter MemCounter = new PerformanceCounter("Memory", "Available MBytes");
        PerformanceCounter UpTimeCounter = new PerformanceCounter("System","System Up Time");

        //Using a timer to update CPU load %
        private void TickTock(object sender, EventArgs e)
        {
            //This timer runs every 500ms

            //Getting current CPU Usage
            double CPU = 0;
            CPU = CpuCounter.NextValue();
            CPU = Math.Round(CPU, 2);
            LBLCPULoad.Text = "CPULoad: " + CPU.ToString() + "%";
            //Getting current available memory amount and doing math to get how much is being used.
            LBLMemoryAvailable.Text = "Memory Usage: " + (totalMemory - MemCounter.NextValue()) + "MB / " + totalMemory + "MB"; 
        }

        private void TickTock2(object sender, EventArgs e)
        {
            //Collect garbage and free up some ram every 10 seconds
            GC.Collect();
        }

        //On the form loading...
        private void Form2_Load(object sender, EventArgs e)
        {
            f3.Show();
            //Start windows in bottem right
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Rectangle workingArea = Screen.GetWorkingArea(this);
            this.Location = new Point(workingArea.Right - Size.Width, workingArea.Bottom - Size.Height);

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
                //Getting the BIOS version
                RTBMotherboard.AppendText("BIOS Version: " + (string)share["SMBIOSBIOSVersion"] + "\n");
                //Getting the release date of the BIOS as well as changing the date format into a readable format
                string relDt = (string)share["ReleaseDate"];
                DateTime dt = ManagementDateTimeConverter.ToDateTime(relDt);
                RTBMotherboard.AppendText("Bios Release Date: " + dt.ToString("MM-dd-yyy"));
            }

            ManagementObjectSearcher MemorySearcher = new ManagementObjectSearcher("Select * From Win32_ComputerSystem");
            foreach (ManagementObject share in MemorySearcher.Get())
            {
                //Getting total memory of computer
                totalMemory = Convert.ToInt64(share["TotalPhysicalMemory"]);
                //Memory is get; by bytes so change it to mebabytes
                totalMemory /= 1024;
                totalMemory /= 1024;
                RTBWindowsInfo.AppendText(totalMemory.ToString());

                RTBCpuInfo.AppendText("\nModel: " + share["Model"]);
                RTBCpuInfo.AppendText("\nManufacturer: " + share["Manufacturer"]);
            }

            ManagementObjectSearcher WindowsSearcher = new ManagementObjectSearcher("Select * From Win32_OperatingSystem");
            foreach (ManagementObject share in WindowsSearcher.Get())
            {
                //Getting windows information
                RTBWindowsInfo.Text = "";
                RTBWindowsInfo.AppendText("Windows Edition: " + share["Caption"].ToString() + "\n");
                RTBWindowsInfo.AppendText("Windows Architecture: " + share["OSArchitecture"].ToString() + "\n");
                RTBWindowsInfo.AppendText("BuildNumber: " + share["Version"].ToString() + " Build: " + share["BuildNumber"].ToString() + "\n");
                //Changing windows install date and last boot date to a readable format
                DateTime IstDt = ManagementDateTimeConverter.ToDateTime((string)share["InstallDate"]);
                DateTime BootDt = ManagementDateTimeConverter.ToDateTime((string)share["LastBootUpTime"]);
                RTBWindowsInfo.AppendText("InstallDate: " + IstDt.ToString("MM-dd-yyy") + "\n");
                //Getting system uptime and formatting it
                UpTimeCounter.NextValue();
                var time = TimeSpan.FromSeconds(UpTimeCounter.NextValue());
                RTBWindowsInfo.AppendText("Last Boot: " + BootDt.ToString("MM-dd-yyy") + " UpTime: " + "Days: " + time.Days + " Hours: " + time.Hours + " Minutes: " + time.Minutes);
            }

            ManagementObjectSearcher GPUSearcher = new ManagementObjectSearcher("Select * From Win32_VideoController");
            foreach (ManagementObject share in GPUSearcher.Get())
            {
                //Pulling GPU Information
                RTBGPUInfo.Text = "";
                RTBGPUInfo.AppendText("Name: " + share["Name"].ToString() + "\n");
                RTBGPUInfo.AppendText("Video Processor: " + share["VideoProcessor"].ToString() + "\n");
                RTBGPUInfo.AppendText("Driver Version: " + share["DriverVersion"].ToString() + "\n");
                DateTime GpuDvDt = ManagementDateTimeConverter.ToDateTime((string)share["DriverDate"]);
                RTBGPUInfo.AppendText("Driver Date: " + GpuDvDt.ToString("MM-dd-yyy") + "\n");
            }

            foreach(NetworkInterface ni in NetworkInterface.GetAllNetworkInterfaces())
            {
                //Pull all network interfaces with a status of Up
                if(ni.OperationalStatus == OperationalStatus.Up)
                {
                    //Pull the discription of the NIC and speed, formatt speed to Mbps
                    RTBNetworkInfo.AppendText(ni.Description.ToString() + " = " + (ni.Speed / 1000000).ToString() + "Mbps = ");
                    foreach (UnicastIPAddressInformation ip in ni.GetIPProperties().UnicastAddresses)
                    {
                        //Getting the IPV4 address of the current NIC
                        if(ip.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                        {
                            RTBNetworkInfo.AppendText(ip.Address.ToString());
                        }
                    }
                    RTBNetworkInfo.AppendText("\n");
                }
            }

            foreach (NetworkInterface ni in NetworkInterface.GetAllNetworkInterfaces())
            {
                //For all NICs that are down, display the discription and status
                if (ni.OperationalStatus == OperationalStatus.Down)
                {
                    RTBNetworkInfo.AppendText(ni.Description.ToString() + " = " + ni.OperationalStatus.ToString() + "\n");
                }
            }
            f3.Close();
        }

        private void BTNClose_Click(object sender, EventArgs e)
        {
            GC.Collect();
            this.Close();
        }
    }
}
