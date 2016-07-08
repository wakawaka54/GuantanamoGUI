using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Guantanamo_GUI.VehicleSensors;

namespace Guantanamo_GUI
{
    static class VehicleSystems
    {
        public delegate void CommandSentHandles(string command); //for classes that want to monitor SENT commands
        public static event CommandSentHandles CommandSent;

        public static GPS_Sensor GPS;
        public static Magnetometer_Sensor Magnetometer;
        public static Accelerometer_Sensor Accelerometer;
        public static VehicleState_Sensor VehicleState;
        public static Gyroscope_Sensor Gyroscope;
        public static Ultrasonic_Sensor Ultrasonic;
        public static Probe_Sensor Probe;
        public static ImageProcessing_Sensor ImageProcessing;
        public static DigitalMotion_Sensor DMP;


        public static Navigation_Sensor Controller;
        public static Diagnostics_Sensor Diagnostics;
        public static SpecialPackets SpecialPackets;

        public static SerialCOM SerialCommunications;

        public static List<Sensor> VehicleSensors { get; set; }

        public static int ErrorUpdates { get; set; }

        public static volatile bool UpdateUI = true;

        static PresenterManager presenters;

        public static void Setup(PresenterManager _pres)
        {
            presenters = _pres;

            VehicleSensors = new List<Sensor>();
            Init_AllVehicleSystems();
        }

        #region Init_Sensors

        public static void Init_AllVehicleSystems()
        {
            Init_Accelerometer();
            Init_Controller();
            Init_Diagnostics();
            Init_GPS();
            Init_Gyroscope();
            Init_Magnetometer();
            Init_Probe();
            Init_VehicleState();
            Init_Ultrasonic();
            Init_Communications();
            Init_SpecialPackets();
            Init_ImageProcessing();
            Init_DMP();
        }

        public static void Init_DMP()
        {
            DMP = new DigitalMotion_Sensor();
            VehicleSensors.Add(DMP);
        }

        public static void Init_ImageProcessing()
        {
            ImageProcessing = new ImageProcessing_Sensor();
            VehicleSensors.Add(ImageProcessing);
        }

        public static void Init_SpecialPackets()
        {
            SpecialPackets = new SpecialPackets();
            VehicleSensors.Add(SpecialPackets);
        }

        public static void Init_Ultrasonic()
        {
            Ultrasonic = new Ultrasonic_Sensor();
            VehicleSensors.Add(Ultrasonic);
        }

        public static void Init_Probe()
        {
            Probe = new Probe_Sensor();
            VehicleSensors.Add(Probe);
        }

        public static void Init_Gyroscope()
        {
            Gyroscope = new Gyroscope_Sensor();
            VehicleSensors.Add(Gyroscope);
        }

        public static void Init_Diagnostics()
        {
            Diagnostics = new Diagnostics_Sensor();
            VehicleSensors.Add(Diagnostics);
        }

        public static void Init_Controller()
        {
            Controller = new Navigation_Sensor();
            VehicleSensors.Add(Controller);
        }

        public static void Init_Communications()
        {
            SerialCommunications = new SerialCOM();
        }

        public static void Init_VehicleState()
        {
            VehicleState = new VehicleState_Sensor();
            VehicleSensors.Add(VehicleState);
        }

        public static void Init_GPS()
        {
            GPS = new GPS_Sensor();
            VehicleSensors.Add(GPS);
        }

        public static void Init_Magnetometer()
        {
            Magnetometer = new Magnetometer_Sensor();
            VehicleSensors.Add(Magnetometer);
        }

        public static void Init_Accelerometer()
        {
            Accelerometer = new Accelerometer_Sensor();
            VehicleSensors.Add(Accelerometer);
        }

        #endregion

        public static void Reset()
        {
            foreach (Sensor s in VehicleSensors) { s.Reset(); }
        }

        public static void PrepareHighDataTransfer()
        {
            UpdateUI = false;
        }

        public static void EndHighDataTransfer()
        {
            UpdateUI = true;
        }

        public static void Update(string line)
        {
            string[] data = line.Split(',');
            string designator = data[0];

            foreach (Sensor s in VehicleSensors)
            {
                if (s.Designator.Length != 0 && s.CheckDesignator(designator))
                {
                    if (!s.Update(data)) { throw new Exception(s.Designator + " " + line); } //trigger if update came back false
                }
            }

            if (UpdateUI)
            {
                presenters.UpdateUI(line);
            }
        }

        public static bool SendCommand(string line)
        {
            if (SerialCommunications.WriteCommand(line)) {
                if (CommandSent != null) { CommandSent(line); } return true; }
            return false;
        }
    }
}
