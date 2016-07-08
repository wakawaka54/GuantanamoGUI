using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Guantanamo_GUI.Commands;
using Guantanamo_GUI.VehicleSensors;

namespace Guantanamo_GUI.VehicleSensors
{

    class Navigation_Sensor : Sensor
    {
        public const string DESIGNATOR_CHAR = "N"; //character which update line checks for to designate data towards sensor
        public bool ReadingData = false;

        public List<byte> ReadByteArray = new List<byte>();

        LoadingScreen_Handler workingOperations = new LoadingScreen_Handler();

        short endOfFileCounter = 0;

        public Navigation_Sensor()
        {
            Designator = DESIGNATOR_CHAR;
        }

        public override void Reset()
        {

        }

        public override bool Update(string[] split)
        {
            if (ReadingData)
            {
                byte newByte = 0;
                if (!byte.TryParse(split[1], out newByte)) { return false; }

                ReadByteArray.Add(newByte);

                if (newByte == byte.MaxValue && endOfFileCounter >= 5)
                {
                        ReadingData = false;

                        sendEEPROMEdit_Command(0, 0);

                        sendVehicleStateChange_Command(5);
                        workingOperations.CloseScreen();
                }
                else
                {
                    if (newByte == byte.MaxValue) { endOfFileCounter++; }
                    else { endOfFileCounter = 0; }
                    sendEEPROMEdit_Command(2, 0);
                }
            }

            return true;
        }

        public void WriteNavigation(List<byte> byteArray)
        {
            LoadingScreen_Handler loading = new LoadingScreen_Handler();
            loading.ShowLoading();
            loading.UpdateProgress("Writing navigation data...", 0);

            sendVehicleStateChange_Command(-2);

            sendEEPROMEdit_Command(0, 0);

            for (int i = 0; i != byteArray.Count; i++)
            {
                sendEEPROMEdit_Command(1, byteArray[i]);
            }

            sendVehicleStateChange_Command(5);

            loading.CloseScreen();
        }

        public void ReadNavigation()
        {
            ReadByteArray.Clear();

            workingOperations.ShowLoading();
            workingOperations.UpdateProgress("Reading navigation data...", 0);

            sendVehicleStateChange_Command(-2);
            sendEEPROMEdit_Command(0, 0);
            sendEEPROMEdit_Command(2, 0);

            ReadingData = true;
        }

        void sendVehicleStateChange_Command(short state)
        {
            string command = "!4(";
            command += state.ToString();
            command += ")";

            VehicleSystems.SendCommand(command);
        }

        void sendEEPROMEdit_Command(short param, short data)
        {
            string command = "!G(";
            command += param.ToString();
            command += ",";
            command += data.ToString();
            command += ")";

            VehicleSystems.SendCommand(command);
            Thread.Sleep(20);
        }
    }
}
