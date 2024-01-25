/*=======================================================================================================================
   Unit Name: TUF2000.cs
   Purpose  : Reads TUF-2000M Ultrasonic Flow Meter log file and converts the data to understandable form.
   Author   : Juha Koivukorpi
   Date     : 22.05.2021
   Todo     : Add more methods for reading and decoding log data. Just some registers are handled at the moment. 
              Finally could be converted to .dll

   Changes  : 14.1.2024 - More accurate name to function IntToBCD -> BCDToDec. Edited some comments.
=======================================================================================================================*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Windows.Forms;

namespace TUF2000MainForm
{
    class TUF2000
    {
        WebClient web = new WebClient(); // net connection for getting data
        private readonly int[] LogValues = new int[101]; // Array for data log values from file. Array index = TUF-2000 register address 
        private readonly string[] ErrorCodeTable = new string[16]; // String array for error code texts
        public string LogFileName { get; set; } // Log file name can be accessed directly. Function ReadDataLog() return error if not something is wrong.

        // TUF-2000 register handling
        public float FlowRate { get { return ConvertToFloat(LogValues[1], LogValues[2]); } }                // Get Flow Rate
        public long NegEnergyAccum { get { return ConvertToLong(LogValues[21], LogValues[22]); } }          // Get Negative Energy Accumulation
        public float Temperature1_input { get { return ConvertToFloat(LogValues[33], LogValues[34]); } }    // Get Temperature #1/inlet
        public string DateTime { get { return GetDateTime(LogValues[53], LogValues[54], LogValues[55]); } }  // Get date and time
        public int SignalQuality { get { return GetLowByte(LogValues[92]); } }                              // Get Signal Quality
        public string ErrorCodes { get { return GetErrorCodes(); }  }                                       // Returns error codes given by TUF-2000M


        public TUF2000() 
        {
            InitializeErrorCodeTable(); // Read error text to array
        }  

        ~TUF2000() { }

        /// <summary>
        /// Reads/updates TUF-2000 data log.
        /// </summary>
        /// <returns>TRUE if successful. FALSE if file error</returns>
        public bool ReadDataLog() // Reads TUF-2000 data log and converts it into arrays of integers
        {
            bool FileOK = true; 
            String FileText;
            String TempString;
            try // In the case of file error...
            {
                System.IO.Stream stream = web.OpenRead(LogFileName);
                using (System.IO.StreamReader reader = new System.IO.StreamReader(stream))
                {
                    FileText = reader.ReadToEnd();
                }
                string[] subs = FileText.Split('\n'); // Separate file lines to array of strings

                // Create array of integers
                for (int i = 1; i <= 100; i++)
                {
                    TempString = subs[i];
                    subs[i] = subs[i].Split(':').Last(); // Remove everything before ':' character
                    LogValues[i] = Convert.ToInt32(subs[i]);
                }
            }
            catch { FileOK = false; } // Error occured while reading file.
            return FileOK;
        }

        //------------------------------------------------------------------------------
        // Combines low word and high word, and returns the result as float
        //------------------------------------------------------------------------------
        private float ConvertToFloat(int LowWord, int HighWord)
        {
            var bytes1 = BitConverter.GetBytes(LowWord);
            var bytes2 = BitConverter.GetBytes(HighWord);
            bytes1[3] = bytes2[1];
            bytes1[2] = bytes2[0];

            return BitConverter.ToSingle(bytes1, 0);
        }

        //------------------------------------------------------------------------------
        // Combines low byte and high byte, and returns the result as long
        //------------------------------------------------------------------------------
        private long ConvertToLong(int LowByte, int HighByte) 
        {
            var bytes1 = BitConverter.GetBytes(LowByte);
            var bytes2 = BitConverter.GetBytes(HighByte);
            bytes1[3] = bytes2[1];
            bytes1[2] = bytes2[0];

             return BitConverter.ToInt32(bytes1, 0);
        }

        //------------------------------------------------------------------------------
        // Extract low or high byte from given value
        //------------------------------------------------------------------------------
        private int GetLowByte(int input) { return input & 0xff; }          // input AND 1111 1111
        private int GetHighByte(int input) { return (input >> 8) & 0xff; }  // input move 8 bits right, then AND 1111 1111

        //------------------------------------------------------------------------------
        // Convert BCD (binary coded decimal) to Decimal numbers.
        // Tens -> move high byte 4 right, AND with 0000 1111, and multiplied by 10.
        // Finally low byte is added.
        //------------------------------------------------------------------------------
        private int BCDtoDec(int SourceValue) { return ((SourceValue >> 4) & 0x0f) * 10 + (SourceValue & 0x0f); }

        //------------------------------------------------------------------------------
        // Convert given values to date and time using function above
        //------------------------------------------------------------------------------
        private string GetDateTime(int value1, int value2, int value3) 
        {
            string DateTime = Convert.ToString(BCDtoDec(GetHighByte(value3))) + "-"; // Year
            DateTime += Convert.ToString(BCDtoDec(GetLowByte(value3))) + "-";       // Month
            DateTime += Convert.ToString(BCDtoDec(GetHighByte(value2))) + " ";      // Day
            DateTime += Convert.ToString(BCDtoDec(GetLowByte(value2))) + ":";       // Hour
            DateTime += Convert.ToString(BCDtoDec(GetHighByte(value1))) + ":";      // Min
            DateTime += Convert.ToString(BCDtoDec(GetLowByte(value1)));             // Sec

            return DateTime;
        }

        //------------------------------------------------------------------------------
        // Get error code bits from register #72, and return correspoding error texts in one string, separated by comma
        //------------------------------------------------------------------------------
        private string GetErrorCodes() 
         {
            string Codes = "";
            //LogValues[72] = 65535; // just for testing error codes
            for (int i = 0; i < 16; i++)
            {
                if ((LogValues[72] & (1 << i)) != 0)  // Check all error bits
                {
                    Codes += ErrorCodeTable[i] + ","; // Make list of all error codes found
                }
            }
             return Codes;
         }

        //------------------------------------------------------------------------------
        // Set error code texts to array
        //------------------------------------------------------------------------------
        private void InitializeErrorCodeTable()
        {
            ErrorCodeTable[0] = "no received signal";
            ErrorCodeTable[1] = "low received signal";
            ErrorCodeTable[2] = "poor received signal";
            ErrorCodeTable[3] = "pipe empty";
            ErrorCodeTable[4] = "hardware failure";
            ErrorCodeTable[5] = "receiving circuits gain in adjusting";
            ErrorCodeTable[6] = "frequency at the frequency output over flow";
            ErrorCodeTable[7] = "current at 4-20mA over flow";
            ErrorCodeTable[8] = "RAM check-sum error";
            ErrorCodeTable[9] = "main clock or timer clock error";
            ErrorCodeTable[10] = "parameters check-sum error";
            ErrorCodeTable[11] = "ROM check-sum error";
            ErrorCodeTable[12] = "temperature circuits error";
            ErrorCodeTable[13] = "-reserved-";
            ErrorCodeTable[14] = "internal timer over flow";
            ErrorCodeTable[15] = "analog input over range";
        }

    }
}

