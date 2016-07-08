using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guantanamo_GUI.UltilityModules
{
    public partial class StateEditor : UtilityBase
    {
        public List<byte> tableByteArray = new List<byte>();

        bool reading = false;

        public StateEditor(PresenterManager owner)
            :base(owner, Utility_Modules.StateEditor)
        {
            InitializeComponent();
        }

        public override void UpdateUI(string line)
        {
            if (reading && !VehicleSystems.Controller.ReadingData)
            {
                txtFromVehicle.Text = writeByteArray(VehicleSystems.Controller.ReadByteArray);
                reading = false;

                if (verifyByteTables())
                {
                    lbVerification.Text = "VERIFICATION SUCCEEDED";
                    lbVerification.ForeColor = Color.Green;
                }
                else
                {
                    lbVerification.Text = "VERIFICATION FAILED";
                    lbVerification.ForeColor = Color.Yellow;
                }
            }
        }

        bool verifyByteTables()
        {
            short endOfFile_Count = 0;
            List<byte> readByteArray = VehicleSystems.Controller.ReadByteArray;

            if (tableByteArray.Count < readByteArray.Count) { return false; }

            for(int i = 0; i != VehicleSystems.Controller.ReadByteArray.Count; i++)
            {
                if (readByteArray[i] == byte.MaxValue) { endOfFile_Count++; }
                else { endOfFile_Count = 0; }

                if (endOfFile_Count >= 5) { break; }

                if (tableByteArray[i] != readByteArray[i]) { return false; }
            }

            return true;
        }

        void generateHexTable()
        {
            char designator = char.MinValue;
            int index = 0;

            tableByteArray.Clear();
            txtHex.Text = "";

            try
            {
                for (index = 0; index < txtStateTable.Text.Length; index++)
                {
                    if (txtStateTable.Text[index] == '(')
                    {
                        designator = txtStateTable.Text[index - 1];

                        switch (designator)
                        {
                            /*case 0:
                                tableByteArray.AddRange(start_of_StateTable_ToHex(ref index));
                                break;*/

                            case '1':
                                tableByteArray.AddRange(waypointToHex(ref index));
                                break;

                            case '2':
                                tableByteArray.AddRange(imageGoToToHex(ref index));
                                break;

                            case '3':
                                tableByteArray.AddRange(imageAvoidToHex(ref index));
                                break;

                            case '4':
                                tableByteArray.AddRange(headingNavigationToHex(ref index));
                                break;

                            case '5':
                                tableByteArray.AddRange(delayToHex(ref index));
                                break;

                            case '6':
                                tableByteArray.AddRange(changeCameraVariableToHex(ref index));
                                break;

                            case '7':
                                tableByteArray.AddRange(headingNavigationRefToHex(ref index));
                                break;

                            case '8':
                                tableByteArray.AddRange(headingNavigationPrevious_ToHex(ref index));
                                break;

                            case '9':
                                tableByteArray.AddRange(executeFunction_ToHex(ref index));
                                break;

                            case 'A':
                                tableByteArray.AddRange(imageFollowToHex(ref index));
                                break;

                            case 'B':
                                tableByteArray.AddRange(imageTurnToHex(ref index));
                                break;

                            case 'C':
                                tableByteArray.AddRange(pushButtonToHex(ref index));
                                break;

                            case 'D':
                                tableByteArray.AddRange(waitForHeading_ToHex(ref index));
                                break;

                            case 'E':
                                tableByteArray.AddRange(alignGyro_ToHex(ref index));
                                break;
                        }

                    }
                }
            }

            catch { string msg = "Error Converting Table to Hex. Char Index = " + index.ToString(); MessageBox.Show(msg); return; }

            //append ending max values
            for (int i = 0; i != 10; i++) { tableByteArray.Add(byte.MaxValue); }

            txtHex.Text = writeByteArray(tableByteArray);
        }

        List<byte> alignGyro_ToHex(ref int startIndex)
        {
            List<byte> byteArrayLine = new List<byte>();

            byte commandNumber = 14; //push button command number in GUAN FIRMWARE

            UInt16 param1 = Convert.ToUInt16(extractParameter(ref startIndex)); //state timeout

            byteArrayLine.Add(commandNumber);
            byteArrayLine.Add((byte)(param1 >> 8));
            byteArrayLine.Add((byte)(param1 & 0xFF));

            return byteArrayLine;
        }

        List<byte> waitForHeading_ToHex(ref int startIndex)
        {
            List<byte> byteArrayLine = new List<byte>();

            byte commandNumber = 13; //wait for heading command number in GUAN FIRMWARE

            Int16 param1 = Convert.ToInt16(extractParameter(ref startIndex)); //heading to wait for
            Int16 param2 = Convert.ToInt16(extractParameter(ref startIndex)); //state timeout


            byteArrayLine.Add(commandNumber);
            byteArrayLine.Add((byte)(param1 >> 8));
            byteArrayLine.Add((byte)(param1 & 0xFF));
            byteArrayLine.Add((byte)(param2 >> 8));
            byteArrayLine.Add((byte)(param2 & 0xFF));

            return byteArrayLine;
        }

        List<byte> pushButtonToHex(ref int startIndex)
        {
            List<byte> byteArrayLine = new List<byte>();

            byte commandNumber = 12; //push button command number in GUAN FIRMWARE

            UInt16 param1 = Convert.ToUInt16(extractParameter(ref startIndex)); //state timeout

            byteArrayLine.Add(commandNumber);
            byteArrayLine.Add((byte)(param1 >> 8));
            byteArrayLine.Add((byte)(param1 & 0xFF));

            return byteArrayLine;
        }

        List<byte> executeFunction_ToHex(ref int startIndex)
        {
            List<byte> byteArrayLine = new List<byte>();

            byte commandNumber = 9;

            byte param1 = Convert.ToByte(extractParameter(ref startIndex)); //function index

            byteArrayLine.Add(commandNumber);
            byteArrayLine.Add(param1);

            return byteArrayLine;
        }

        List<byte> waypointToHex(ref int startIndex)
        {
            List<byte> byteArrayLine = new List<byte>();

            byte commandNumber = 1;

            double param1 = Convert.ToDouble(extractParameter(ref startIndex)); //latitude
            double param2 = Convert.ToDouble(extractParameter(ref startIndex)); //longitude
            byte param3 = Convert.ToByte(extractParameter(ref startIndex)); //speed

            param1 *= Math.Pow(10, 6); param2 *= Math.Pow(10, 6);

            Int32 param1_i = (Int32)param1; Int32 param2_i = (Int32)param2;

            byteArrayLine.Add(commandNumber);
            byteArrayLine.AddRange(toHex(param1_i));
            byteArrayLine.AddRange(toHex(param2_i));
            byteArrayLine.Add(param3);

            return byteArrayLine;
        }

        List<byte> imageGoToToHex(ref int startIndex)
        {
            List<byte> byteArrayLine = new List<byte>();

            byte commandNumber = 2;

            byte param1 = Convert.ToByte(extractParameter(ref startIndex)); //Color Code
            byte param2 = Convert.ToByte(extractParameter(ref startIndex)); //Test for no object
            UInt16 param3 = Convert.ToUInt16(extractParameter(ref startIndex)); //timeout
            byte param4 = Convert.ToByte(extractParameter(ref startIndex)); //speed

            byteArrayLine.Add(commandNumber);
            byteArrayLine.Add(param1);
            byteArrayLine.Add(param2);
            byteArrayLine.Add((byte)(param3 >> 8));
            byteArrayLine.Add((byte)(param3 & 0xFF));
            byteArrayLine.Add(param4);

            return byteArrayLine;
        }

        List<byte> imageAvoidToHex(ref int startIndex)
        {
            List<byte> byteArrayLine = new List<byte>();

            byte commandNumber = 3;

            byte param1 = Convert.ToByte(extractParameter(ref startIndex)); //color code
            byte param2 = Convert.ToByte(extractParameter(ref startIndex)); //position code
            byte param3 = Convert.ToByte(extractParameter(ref startIndex)); //test for no object
            UInt16 param4 = Convert.ToUInt16(extractParameter(ref startIndex)); //timeout
            byte param5 = Convert.ToByte(extractParameter(ref startIndex)); //speed

            byteArrayLine.Add(commandNumber);
            byteArrayLine.Add(param1);
            byteArrayLine.Add(param2);
            byteArrayLine.Add(param3);
            byteArrayLine.Add((byte)(param4 >> 8));
            byteArrayLine.Add((byte)(param4 & 0xFF));
            byteArrayLine.Add(param5);

            return byteArrayLine;
        }

        List<byte> imageFollowToHex(ref int startIndex)
        {
            List<byte> byteArrayLine = new List<byte>();

            byte commandNumber = 10;

            byte param1 = Convert.ToByte(extractParameter(ref startIndex)); //color code
            byte param2 = Convert.ToByte(extractParameter(ref startIndex)); //position code
            byte param3 = Convert.ToByte(extractParameter(ref startIndex)); //test for no object
            UInt16 param4 = Convert.ToUInt16(extractParameter(ref startIndex)); //timeout
            byte param5 = Convert.ToByte(extractParameter(ref startIndex)); //speed

            byteArrayLine.Add(commandNumber);
            byteArrayLine.Add(param1);
            byteArrayLine.Add(param2);
            byteArrayLine.Add(param3);
            byteArrayLine.Add((byte)(param4 >> 8));
            byteArrayLine.Add((byte)(param4 & 0xFF));
            byteArrayLine.Add(param5);

            return byteArrayLine;
        }

        List<byte> imageTurnToHex(ref int startIndex)
        {
            List<byte> byteArrayLine = new List<byte>();

            byte commandNumber = 11;

            byte param1 = Convert.ToByte(extractParameter(ref startIndex)); //color code
            byte param2 = Convert.ToByte(extractParameter(ref startIndex)); //position code
            byte param3 = Convert.ToByte(extractParameter(ref startIndex)); //ipFlags
            UInt16 param4 = Convert.ToUInt16(extractParameter(ref startIndex)); //timeout
            byte param5 = Convert.ToByte(extractParameter(ref startIndex)); //speed

            byteArrayLine.Add(commandNumber);
            byteArrayLine.Add(param1);
            byteArrayLine.Add(param2);
            byteArrayLine.Add(param3);
            byteArrayLine.Add((byte)(param4 >> 8));
            byteArrayLine.Add((byte)(param4 & 0xFF));
            byteArrayLine.Add(param5);

            return byteArrayLine;
        }

        List<byte> headingNavigationToHex(ref int startIndex)
        {
            List<byte> byteArrayLine = new List<byte>();

            byte commandNumber = 4;

            Int16 param1 = Convert.ToInt16(extractParameter(ref startIndex)); //heading
            Int16 param2 = Convert.ToInt16(extractParameter(ref startIndex)); //time to hold
            byte param3 = Convert.ToByte(extractParameter(ref startIndex)); //speed

            byteArrayLine.Add(commandNumber);
            byteArrayLine.Add((byte)(param1 >> 8));
            byteArrayLine.Add((byte)(param1 & 0xFF));
            byteArrayLine.Add((byte)(param2 >> 8));
            byteArrayLine.Add((byte)(param2 & 0xFF));
            byteArrayLine.Add(param3);

            return byteArrayLine;
        }

        List<byte> delayToHex(ref int startIndex)
        {
            List<byte> byteArrayLine = new List<byte>();

            byte commandNumber = 5;

            UInt16 param1 = Convert.ToUInt16(extractParameter(ref startIndex));
            byte param2 = Convert.ToByte(extractParameter(ref startIndex));

            byteArrayLine.Add(commandNumber);
            byteArrayLine.Add((byte)(param1 >> 8));
            byteArrayLine.Add((byte)(param1 & 0xFF));
            byteArrayLine.Add(param2);

            return byteArrayLine;
        }

        List<byte> changeCameraVariableToHex(ref int startIndex)
        {
            List<byte> byteArrayLine = new List<byte>();

            byte commandNumber = 6;

            byte param1 = Convert.ToByte(extractParameter(ref startIndex));
            UInt16 param2 = Convert.ToUInt16(extractParameter(ref startIndex));

            byteArrayLine.Add(commandNumber);
            byteArrayLine.Add(param1);
            byteArrayLine.Add((byte)(param2 >> 8));
            byteArrayLine.Add((byte)(param2 & 0xFF));

            return byteArrayLine;
        }

        List<byte> headingNavigationRefToHex(ref int startIndex)
        {
            List<byte> byteArrayLine = new List<byte>();

            byte commandNumber = 7;

            Int16 param1 = Convert.ToInt16(extractParameter(ref startIndex)); //heading
            UInt16 param2 = Convert.ToUInt16(extractParameter(ref startIndex)); //time to hold
            byte param3 = Convert.ToByte(extractParameter(ref startIndex));

            byteArrayLine.Add(commandNumber);
            byteArrayLine.Add((byte)(param1 >> 8));
            byteArrayLine.Add((byte)(param1 & 0xFF));
            byteArrayLine.Add((byte)(param2 >> 8));
            byteArrayLine.Add((byte)(param2 & 0xFF));
            byteArrayLine.Add(param3);

            return byteArrayLine;

        }

        List<byte> headingNavigationPrevious_ToHex(ref int startIndex)
        {
            List<byte> byteArrayLine = new List<byte>();

            byte commandNumber = 8;

            byte param1 = Convert.ToByte(extractParameter(ref startIndex)); //storeOrSet_Heading
            UInt16 param2 = Convert.ToUInt16(extractParameter(ref startIndex)); //time to hold
            byte param3 = Convert.ToByte(extractParameter(ref startIndex));

            byteArrayLine.Add(commandNumber);
            byteArrayLine.Add(param1);
            byteArrayLine.Add((byte)(param2 >> 8));
            byteArrayLine.Add((byte)(param2 & 0xFF));
            byteArrayLine.Add(param3);

            return byteArrayLine;
        }

        string writeByteArray(List<byte> array)
        {
            string text = "";

            short countPerLine = 0;

            foreach (byte b in array)
            {
                text += b.ToString("X2");
                text += " ";

                countPerLine++;

                if (countPerLine > 10) { countPerLine = 0; text += "\n"; }
            }

            return text;
        }

        List<byte> toHex(Int32 value)
        {
            List<byte> array = new List<byte>();

            for (int i = 3; i >= 0; i--)
            {
                array.Add((byte)((value >> 8*i) & 0xFF));
            }

            return array;
        }

        string extractParameter(ref int startIndex)
        {
            string param = "";
            char nextChar;

            for (; txtStateTable.Text[startIndex] != ')' && txtStateTable.Text[startIndex] != ','; startIndex++)
            {
                nextChar = txtStateTable.Text[startIndex];

                if (nextChar != '(') { param += nextChar; }
            }

            if (txtStateTable.Text[startIndex] == ',') { startIndex++; }

            return param;
        }

        void addCommandToTable(string command)
        {
            txtStateTable.Text += command + "\n";
        }

        void addWaypointToTable(double lat, double lon)
        {
            string command = "1(";

            command += lat.ToString("N6") + ",";
            command += lon.ToString("N6");

            command += ")";

            addCommandToTable(command);
        }

        byte extractCommandNumber(ref int startIndex)
        {
            string strCommand = "";
            byte commandNum = 0;

            for (; startIndex < txtStateTable.Text.Length && txtStateTable.Text[startIndex] != '(' && txtStateTable.Text[startIndex] != ','; startIndex++)
            {
                if (txtStateTable.Text[startIndex] != ' ' && txtStateTable.Text[startIndex] != '\n')
                {
                    strCommand += txtStateTable.Text[startIndex];
                    commandNum = Convert.ToByte(strCommand);
                }
            }

            return commandNum;
        }

        private void btnPathStart_Click(object sender, EventArgs e)
        {
            t_Tracker.Interval = (int)n_Interval.Value;
            t_Tracker.Start();

            lbPathTrack.Text = "ON";
        }

        private void btnPathEnd_Click(object sender, EventArgs e)
        {
            t_Tracker.Stop();

            lbPathTrack.Text = "OFF";
        }

        private void btnPathSingle_Click(object sender, EventArgs e)
        {
            int lastCoordinate = VehicleSystems.GPS.Coordinates.Count - 1;
            if (lastCoordinate < 0) { return; }
            addWaypointToTable(VehicleSystems.GPS.Coordinates[lastCoordinate][0], VehicleSystems.GPS.Coordinates[lastCoordinate][1]);

        }

        private void t_Tracker_Tick(object sender, EventArgs e)
        {
            int lastCoordinate = VehicleSystems.GPS.Coordinates.Count - 1;
            if (lastCoordinate < 0) { return; }
            addWaypointToTable(VehicleSystems.GPS.Coordinates[lastCoordinate][0], VehicleSystems.GPS.Coordinates[lastCoordinate][1]);
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {

        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            reading = true;
            VehicleSystems.Controller.ReadNavigation();
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            generateHexTable();
            VehicleSystems.Controller.WriteNavigation(tableByteArray);
        }

        private void StateEditor_Load(object sender, EventArgs e)
        {
            n_Interval.Value = t_Tracker.Interval;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            generateHexTable();
        }

        private void txtStateTable_TextChanged(object sender, EventArgs e)
        {
            lbVerification.Text = "NOT UPLOADED";
            lbVerification.ForeColor = Color.Red;
        }
    }
}
