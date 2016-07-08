using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Guantanamo_GUI.VehicleSensors;

namespace Guantanamo_GUI.VehicleSensors
{
    class Magnetometer_Sensor : Sensor
    {

        public const string DESIGNATOR_CHAR = "M"; //character which update line checks for to designate data towards sensor

        public double[] MagReading = new double[3];
        public double MagHeading = 0;
        public double VehicleHeading = 0;
        public int DeclinationAngle = 0;

        public double[] Offsets_XYZ = { 0, 0, 0 };
        public double[] Scale_XYZ = { 0, 0, 0 };

        public double[] Max_Readings = { 0, 0, 0 };
        public double[] Min_Readings = { 0, 0, 0 };

        public double Norm_Mag = 0;
        public double Norm_XY = 0;

        public Magnetometer_Sensor()
        {
            Designator = DESIGNATOR_CHAR;
        }

        public override void Reset()
        {
            MagReading = new double[3];
        }

        public override bool Update(string[] split)
        {
            switch (split[1])
            {
                case "D":
                    return read_D_Line(split);

                case "C":
                    return read_C_Line(split);

                case "Z":
                    return read_Z_Line(split);
            }

            return false;
        }

        bool read_D_Line(string[] split)
        {
            double[] readings = new double[3];

            for (int i = 0; i != 3; i++) //get X Y Z readings
            {
                if (!double.TryParse(split[(int)Magnetometer_DataColumns_D.X + i], out readings[i])) { return false; }
            }

            MagReading = readings;

            if (!double.TryParse(split[(int)Magnetometer_DataColumns_D.Heading], out MagHeading)) { return false; }
            if (!double.TryParse(split[(int)Magnetometer_DataColumns_D.FilteredHeading], out VehicleHeading)) { return false; }

            computeSensorParameters();

            return true;
        }

        bool read_C_Line(string[] split)
        {
            double[] offReadings = new double[3];
            double[] scaleReadings = new double[3];

            for (int i = 0; i != 3; i++)
            {
                if (!double.TryParse(split[(int)Magnetometer_DataColumns_C.OffX + i], out offReadings[i])) { return false; }
            }

            for (int i = 0; i != 3; i++)
            {
                if (!double.TryParse(split[(int)Magnetometer_DataColumns_C.ScaleX+ i], out scaleReadings[i])) { return false; }
            }


            if (!int.TryParse(split[(int)Magnetometer_DataColumns_C.DeclinationAngle], out DeclinationAngle)) { return false; } 

            Offsets_XYZ = offReadings;
            Scale_XYZ = scaleReadings;

            return true;
        }

        bool read_Z_Line(string[] split)
        {
            double[] maxReadings = new double[3];
            double[] minReadings = new double[3];

            for (int i = 0; i != 3; i++)
            {
                if (!double.TryParse(split[(int)Magnetometer_DataColumns_Z.MaxX + i], out maxReadings[i])) { return false; }
            }

            for (int i = 0; i != 3; i++)
            {
                if (!double.TryParse(split[(int)Magnetometer_DataColumns_Z.MinX + i], out minReadings[i])) { return false; }
            }

            Max_Readings = maxReadings;
            Min_Readings = minReadings;

            return true;
        }

        void computeSensorParameters()
        {
            Norm_Mag = Math.Sqrt(MagReading[0] * MagReading[0] + MagReading[1] * MagReading[1] + MagReading[2] * MagReading[2]);
            Norm_XY = Math.Sqrt(MagReading[0] * MagReading[0] + MagReading[1] * MagReading[1]);
        }
    }
}
