using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Guantanamo_GUI.VehicleSensors;

namespace Guantanamo_GUI.VehicleSensors
{
    struct StateChange
    {
        public DateTime TimeOfChange;
        public short VehicleState;
        public short ChangeReason;

        public StateChange(short vehicleState, short changeReason)
        {
            TimeOfChange = DateTime.Now;
            VehicleState = vehicleState;
            ChangeReason = changeReason;
        }
    }

    class Diagnostics_Sensor : Sensor
    {

        public const string DESIGNATOR_CHAR = "D"; //character which update line checks for to designate data towards sensor

        public int SystemUptime = 0;
        public int VehicleState = 0;

        public short RPI_SentCommands = 0;
        public short RPI_ReceivedCommands = 0;
        public short I2C_Timeouts = 0;

        public List<string> CalibrationNames = new List<string>();
        public List<string> CalibrationValues = new List<string>();

        public List<string> MiscNames = new List<string>();
        public List<string> MiscValues = new List<string>();

        public List<StateChange> StateChanges = new List<StateChange>();

        public Diagnostics_Sensor()
        {
            Designator = DESIGNATOR_CHAR;

            CalibrationNames = new List<string>();
            CalibrationNames.Add("AccX:");
            CalibrationNames.Add("AccY:");
            CalibrationNames.Add("AccZ:");
            CalibrationNames.Add("MagX:");
            CalibrationNames.Add("MagY:");
            CalibrationNames.Add("MagZ:");
            CalibrationNames.Add("Mag_ScaleX:");
            CalibrationNames.Add("Mag_ScaleY:");
            CalibrationNames.Add("Mag_ScaleZ:");
            CalibrationNames.Add("GyroZ:");

            MiscNames = new List<string>();
            MiscNames.Add("Vehicle State:");
            MiscNames.Add("System Uptime:");
            MiscNames.Add("GPS Available Max:");
            MiscNames.Add("Available SRAM:");
            MiscNames.Add("Sample Rate Loop:");
            MiscNames.Add("Sample Rate GPS:");
            MiscNames.Add("Sample Rate Mag:");
            MiscNames.Add("Sample Rate Acc:");
            MiscNames.Add("Sample Rate Gyro:");
            MiscNames.Add("Sample Rate RPI:");
            MiscNames.Add("Sample Rate UltS:");
            MiscNames.Add("I2C Timeouts: ");
            MiscNames.Add("RPI Send/Rec Ratio: ");
        }

        public override bool Update(string[] split)
        {
            switch (split[1])
            {
                case "S":
                    return readSLine(split);

                case "C":
                    return readCLine(split);

                case "H":
                    return readHLine(split);
            }

            return false;
        }

        public override void Reset()
        {
            CalibrationValues.Clear();
            MiscValues.Clear();
            StateChanges.Clear();
        }

        public void ClearBuffers()
        {
            StateChanges.Clear();
        }

        bool readSLine(string[] split)
        {
            List<string> values = new List<string>();

            if (!int.TryParse(split[(int)VehicleDiagnostics_DataColumn_S.VehicleState], out VehicleState)) { return false; }
            values.Add(VehicleState.ToString());

            if(!int.TryParse(split[(int)VehicleDiagnostics_DataColumn_S.Uptime], out SystemUptime)) { return false; }

            values.Add((SystemUptime / 1000).ToString() + " s");
            values.Add(split[(int)VehicleDiagnostics_DataColumn_S.GPS_AvailableMax] + " kb");
            values.Add(split[(int)VehicleDiagnostics_DataColumn_S.RamAvailable] + " kb");
            values.Add(split[(int)VehicleDiagnostics_DataColumn_S.SampleRate_Loop] + " Hz");
            values.Add(split[(int)VehicleDiagnostics_DataColumn_S.SampleRate_GPS] + " Hz");
            values.Add(split[(int)VehicleDiagnostics_DataColumn_S.SampleRate_Mag] + " Hz");
            values.Add(split[(int)VehicleDiagnostics_DataColumn_S.SampleRate_Acc] + " Hz");
            values.Add(split[(int)VehicleDiagnostics_DataColumn_S.SampleRate_Gyro] + " Hz");
            values.Add(split[(int)VehicleDiagnostics_DataColumn_S.SampleRate_RPI] + " Hz");
            values.Add(split[(int)VehicleDiagnostics_DataColumn_S.SampleRate_Ultrasonic] + " Hz");
            values.Add(I2C_Timeouts.ToString());
            values.Add(RPI_SentCommands.ToString() + ":" + RPI_ReceivedCommands.ToString());

            MiscValues = values;

            return updateCalibrations();
        }

        bool readCLine(string[] split)
        {
            if(!short.TryParse(split[(int)VehicleDiagnostics_DataColumn_C.I2C_Timeouts], out I2C_Timeouts)) { return false;}
            if (!short.TryParse(split[(int)VehicleDiagnostics_DataColumn_C.SentCommands_RPI], out RPI_SentCommands)) { return false; }
            if (!short.TryParse(split[(int)VehicleDiagnostics_DataColumn_C.AcksReceived_RPI], out RPI_ReceivedCommands)) { return false; }

            return true;
        }

        bool readHLine(string[] split)
        {
            StateChange change = new StateChange();

            change.TimeOfChange = DateTime.Now;

            if (!short.TryParse(split[(int)VehicleDiagnostics_DataColumns_H.VehicleState], out change.VehicleState)) { return false; }
            if (!short.TryParse(split[(int)VehicleDiagnostics_DataColumns_H.ChangeReason], out change.ChangeReason)) { return false; }

            StateChanges.Add(change);

            return true;
        }

       bool updateCalibrations()
        {
            List<string> values = new List<string>();
            values.Add(VehicleSystems.Accelerometer.X_Offset.ToString("N2"));
            values.Add(VehicleSystems.Accelerometer.Y_Offset.ToString("N2"));
            values.Add(VehicleSystems.Accelerometer.Z_Offset.ToString("N2"));
            values.Add(VehicleSystems.Magnetometer.Offsets_XYZ[0].ToString("N2"));
            values.Add(VehicleSystems.Magnetometer.Offsets_XYZ[1].ToString("N2"));
            values.Add(VehicleSystems.Magnetometer.Offsets_XYZ[2].ToString("N2"));
            values.Add(VehicleSystems.Magnetometer.Scale_XYZ[0].ToString("N2"));
            values.Add(VehicleSystems.Magnetometer.Scale_XYZ[0].ToString("N2"));
            values.Add(VehicleSystems.Magnetometer.Scale_XYZ[0].ToString("N2"));
            values.Add(VehicleSystems.Gyroscope.Z_Offset.ToString("N2"));

            CalibrationValues = values;

            return true;
        }
    }
}
