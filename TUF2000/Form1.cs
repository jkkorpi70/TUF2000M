using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;

namespace TUF2000MainForm
{
    public partial class Form1 : Form
    {
        private readonly static DispatcherTimer Tim1 = new DispatcherTimer { Interval = TimeSpan.FromMilliseconds(1000) }; // Update once a second
        private readonly static TUF2000 TUF2000reader = new TUF2000 { }; // TUF-2000 reader init
        private string OldErrorList =""; // For comparing errors given by TUF2000

        public Form1()
        {
            InitializeComponent();
            Tim1.Tick += OnTimer;               // This event gets log data from TUF2000  
            Tim1.Start();                       // Start timer
            listBoxErrorCodes.Items.Add("OK");  // Everything is OK at the start

            // Following stuff are for this demo version
            TUF2000reader.LogFileName = "http://tuftuf.gambitlabs.fi/feed.txt";
            textBoxFileName.Text = "http://tuftuf.gambitlabs.fi/feed.txt";
        }

        //------------------------------------------------------------------------------
        // Timer updates values to window
        //------------------------------------------------------------------------------
        private void OnTimer(Object sender, EventArgs e)
        {
            if (!TUF2000reader.ReadDataLog())           // If error occured while reading data log
            {
                Tim1.Stop();                            // Stop timer 
                labelLoggingStatus.Text = "STOPPED";    // Change texts
                buttonStartStop.Text = "START";
                listBoxErrorCodes.Items.Clear();        // Clear old items from listBox
                listBoxErrorCodes.Items.Add("Error reading file");
                listBoxErrorCodes.Items.Add("Logging terminated");
                listBoxErrorCodes.Items.Add("Check file name");
                OldErrorList = "file error";            // list box has changed. After restart it will be updated again 
                return;
            }
            
            labelFlowRateValue.Text = Convert.ToString(Math.Round(TUF2000reader.FlowRate, 3)) + " m\xb3/h";            // Update flow rate,
            labelTemperatureValue.Text = Convert.ToString(Math.Round(TUF2000reader.Temperature1_input, 1)) + " °C"; // temperature and
            labelSignalQualityValue.Text = Convert.ToString(TUF2000reader.SignalQuality) + "/99";                   // signal quality in the window
            labelDateTime.Text = TUF2000reader.DateTime;

            // List possible errors into list box
            string NewErrorList = TUF2000reader.ErrorCodes; // Get error code list from TUF2000
            if (NewErrorList != OldErrorList)               // Error list have changed, list new codes. Otherwise do nothing
            {                                               // This prevents unnecessary update of listBox, which further prevents scrolling it
                OldErrorList = NewErrorList;
                listBoxErrorCodes.Items.Clear();            // Clear old items from listBox
                if (NewErrorList == "")
                {
                    listBoxErrorCodes.Items.Add("OK");      // No errors -> OK
                }
                else
                {                                               // Still errors found->update list
                    string[] codes = NewErrorList.Split(',');   // Separate to array, if multiple errors
                    listBoxErrorCodes.Items.Add("ERROR(S): ");  // Add 'Error(s):' text at the top
                    for (int i = 0; i < codes.Length; i++) { listBoxErrorCodes.Items.Add(codes[i]); } // Add all errors to the listBox
                }
            }
        }

        //------------------------------------------------------------------------------
        // Starts and stops timer and data logging
        //------------------------------------------------------------------------------
        private void buttonStartStop_Click(object sender, EventArgs e)
        {
            if (Tim1.IsEnabled == false) // If timer is not running
            {
                Tim1.Start(); // Start and change texts
                labelLoggingStatus.Text = "RUNNING";
                buttonStartStop.Text = "STOP";
            }
            else 
            {
                Tim1.Stop(); // Stop and change texts
                labelLoggingStatus.Text = "STOPPED";
                buttonStartStop.Text = "START";
            }
        }

        //------------------------------------------------------------------------------
        // Sets new log file name to TUF2000
        //------------------------------------------------------------------------------
        private void buttonSetLogFile_Click(object sender, EventArgs e)
        {
            TUF2000reader.LogFileName = textBoxFileName.Text;
        }

        private void textBoxFileName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) // if enter key is pressed
            {
                TUF2000reader.LogFileName = textBoxFileName.Text;
                e.Handled = true; // prevent beep sound
            }
        }
    }
}
