using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToolBox
{
    class RestartShutdown
    {
        public RestartShutdown()
        {

        }
        public void Restart()
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

        public void Shutdown()
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
    }
}
