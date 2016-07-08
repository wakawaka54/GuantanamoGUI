using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using Guantanamo_GUI.Commands;
using Guantanamo_GUI.VehicleSensors;

namespace Guantanamo_GUI.VehicleSensors
{
    public struct GPS_Time
    {
        public string Hour;
        public string Minutes;
        public string Seconds;

        public GPS_Time(string hour, string minutes, string seconds)
        {
            Hour = hour; Minutes = minutes; Seconds = seconds;
        }
    }



    class GPS_Sensor : Sensor
    {
        public const string DESIGNATOR_CHAR = "G"; //character which update line checks for to designate data towards sensor

        public const double MAX_GPS_POINTS = 2000;
        public const int SAMPLES_CENTER_PLOT = 100;
        public const double GPS_MODULE_RANGE_MIN = .0001;

        public double HeadingTo = 0;
        public double Heading = 0;
        public double Distance = 0;
        public GPS_Time Time = new GPS_Time("", "", "");
        public double HDOP = 0;
        public int Satellites = 0;
        public int FailedChecksums = 0;
        public int ReceivedCharacters = 0;
        public int ReceivedSentences = 0;
        public double Speed = 0;
        public int FixAge = 0;

        public bool WaypointActive = false;

        public List<double[]> Coordinates = new List<double[]>();
        public List<double[]> Waypoints = new List<double[]>();

        public string PMTK_Lines = "";

        public bool AutoRange = true;

        public GPS_Sensor()
        {
            Designator = DESIGNATOR_CHAR;
        }

        public override void Reset()
        {
            Coordinates.Clear();
            Waypoints.Clear();
        }

        public void ClearBuffers()
        {
            PMTK_Lines = "";
        }

        public override bool Update(string[] split)
        {
            checkOtherSensors();

            switch (split[(int)GPS_DataColumns_P.GPS_Tag])
            {
                case "P":
                    return addPosition(split);

                case "W":
                    return addWaypoint(split);

                case "I":
                    return addInformation(split);

                case "L":
                    return readPMTK_Line(split);
            }

            return false;
        }

        void checkOtherSensors()
        {
            if (VehicleSystems.Diagnostics.VehicleState == 2) { WaypointActive = true; }
            else { WaypointActive = false; }
        }

        bool readPMTK_Line(string[] split)
        {
            if (split.Length == (int)GPS_DataColumns_L.Data) { return false; }

            string line = "";
            for (int i = (int)GPS_DataColumns_L.Data; i != split.Length - 1; i++)
            {
                line += split[i] + ",";
            }

            line += split[split.Length - 1];

            PMTK_Lines += line + "\n";

            return true;
        }

        bool addInformation(string[] split)
        {
            if (!double.TryParse(split[(int)GPS_DataColumns_I.HDOP], out HDOP)) { return false; }
            if (!int.TryParse(split[(int)GPS_DataColumns_I.Satellites], out Satellites)) { return false; }
            if (!int.TryParse(split[(int)GPS_DataColumns_I.FailedChecksums], out FailedChecksums)) { return false; }
            if (!int.TryParse(split[(int)GPS_DataColumns_I.Sentences], out ReceivedSentences)) { return false; }
            if (!int.TryParse(split[(int)GPS_DataColumns_I.ReceivedChars], out ReceivedCharacters)) { return false; }
            if (!int.TryParse(split[(int)GPS_DataColumns_I.Fix_Age], out FixAge)) { return false; }
            if (!double.TryParse(split[(int)GPS_DataColumns_I.Speed], out Speed)) { return false; }

            return true;
        }

        bool addWaypoint(string[] split)
        {
            double latitude = 0;
            double longitude = 0;

            if (!double.TryParse(split[(int)GPS_DataColumns_W.Latitute], out latitude)) { return false; }
            if (!double.TryParse(split[(int)GPS_DataColumns_W.Longitude], out longitude)) { return false; }
            if (!double.TryParse(split[(int)GPS_DataColumns_W.WP_Heading], out HeadingTo)) { return false; }
            if (!double.TryParse(split[(int)GPS_DataColumns_W.WP_Distance], out Distance)) { return false; }

            if (latitude == 0 || longitude == 0) { WaypointActive = false; return true; }

            WaypointActive = true;
            Waypoints.Add(new double[] { latitude, longitude });

            return true;
        }

        bool addPosition(string[] split)
        {
            double latitude = 0;
            double longitude = 0;

            if (Coordinates.Count >= MAX_GPS_POINTS) { Coordinates.Clear(); }

            if (!double.TryParse(split[(int)GPS_DataColumns_P.Latitude], out latitude)) { return false; }
            if (!double.TryParse(split[(int)GPS_DataColumns_P.Longitude], out longitude)) { return false; }
            if (!double.TryParse(split[(int)GPS_DataColumns_P.Heading], out Heading)) { return false; }
            Time = convert_String_To_GPSTime(split[(int)GPS_DataColumns_P.Time]);

            Heading /= 1000;
            if (latitude == 0 || longitude == 0) { return true; }

            Coordinates.Add(new double[] { latitude, longitude });

            return true;
        }

        GPS_Time convert_String_To_GPSTime(string time)
        {
            GPS_Time convert = new GPS_Time("", "", "");
            while (time.Length < 8) { time = "0" + time; }
            try
            {
                convert.Hour = time[0].ToString() + time[1].ToString();
                time = time.Remove(0, 2);
                convert.Minutes = time[0].ToString() + time[1].ToString();
                time = time.Remove(0, 2);
                convert.Seconds = time[0].ToString() + time[1].ToString();
                time = time.Remove(0, 2);
                convert.Seconds += "." + time;
            }
            catch { }

            return convert;
        }

        public static string PMTK_Query_DGPS_Mode()
        {
            PMTKSend send = new PMTKSend(null);
            send.Controls["txtPMTK"].Text = "401";
            return send.GetCommand();
        }

        public static string PMTK_Query_SBAS_Enabled()
        {
            PMTKSend send = new PMTKSend(null);
            send.Controls["txtPMTK"].Text = "413";
            return send.GetCommand();
        }

        public static string PMTK_Query_NMEA_Out()
        {
            PMTKSend send = new PMTKSend(null);
            send.Controls["txtPMTK"].Text = "414";
            return send.GetCommand();
        }

        public static string PMTK_Query_Pwr_Save_Mode()
        {
            PMTKSend send = new PMTKSend(null);
            send.Controls["txtPMTK"].Text = "420";
            return send.GetCommand();
        }

    }
}