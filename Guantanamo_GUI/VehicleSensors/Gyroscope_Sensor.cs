using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Guantanamo_GUI.VehicleSensors;
using System.Diagnostics;

namespace Guantanamo_GUI.VehicleSensors
{
    class Gyroscope_Sensor : Sensor
    {
        public const string DESIGNATOR_CHAR = "I";

        public const double IO_TO_DEG_SEC = 14.325;

        public double[] Readings_XYZ = new double[3];
        public double Heading = 0;
        public double Z_Offset = 0;
        public double HeadingDrift;

        public double HeadingDrift_Offset = 0;

        int driftSamplesCount = 0;
        double driftSum = 0;
        double _lastHeading = 0;
        long lastTimeDriftCalc = 0;
        Stopwatch _driftTimer = new Stopwatch();

        public Gyroscope_Sensor()
        {
            Designator = DESIGNATOR_CHAR;
            _driftTimer.Start();
        }

        public override void Reset()
        {
            _driftTimer.Reset();
            driftSum = 0;
        }

        public override bool Update(string[] split)
        {
            switch (split[1])
            {
                case "D":
                    return read_D_Line(split);

                case "C":
                    return read_C_Line(split);
            }

            return true;
        }

        bool read_C_Line(string[] split)
        {
            int trash = 0;
            if (!int.TryParse(split[(int)Gyroscope_DataColumns_C.Xoff], out trash)) { return false; }
            if (!int.TryParse(split[(int)Gyroscope_DataColumns_C.Yoff], out trash)) { return false; }
            if (!double.TryParse(split[(int)Gyroscope_DataColumns_C.Zoff], out Z_Offset)) { return false; }
            if(!double.TryParse(split[(int)Gyroscope_DataColumns_C.DriftOffset], out HeadingDrift_Offset)) { return false; }

            return true;
        }

        bool read_D_Line(string[] split)
        {
            if (!double.TryParse(split[(int)Gyroscope_DataColumns_D.GyroX], out Readings_XYZ[0])) { return false; }
            if (!double.TryParse(split[(int)Gyroscope_DataColumns_D.GyroY], out Readings_XYZ[1])) { return false; }
            if (!double.TryParse(split[(int)Gyroscope_DataColumns_D.GyroZ], out Readings_XYZ[2])) { return false; }

            _lastHeading = Heading;
            if (!double.TryParse(split[(int)Gyroscope_DataColumns_D.GyroHeading], out Heading)) { return false; }

            driftSamplesCount++;
            driftSum += Math.Abs((_lastHeading - Heading));
            if (_driftTimer.ElapsedMilliseconds - lastTimeDriftCalc >= 1000)
            {
                //driftSum /= driftSamplesCount;
                lastTimeDriftCalc = _driftTimer.ElapsedMilliseconds;
                HeadingDrift = driftSum*1000;
                driftSum = 0;
                driftSamplesCount = 0;
            }

            Readings_XYZ[0] /= IO_TO_DEG_SEC;
            Readings_XYZ[1] /= IO_TO_DEG_SEC;
            Readings_XYZ[2] /= IO_TO_DEG_SEC;

            return true;
        }
    }
}
