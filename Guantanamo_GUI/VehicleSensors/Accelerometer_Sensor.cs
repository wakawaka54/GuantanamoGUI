using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Guantanamo_GUI.VehicleSensors;

namespace Guantanamo_GUI.VehicleSensors
{
    public class Accelerometer_Sensor : Sensor
    {
        public const double FULL_SCALE_IO = 675.18; //reads 0-675 because 3.3v on a 5v MC
        public const double FULL_SCALE_REAL = 3; //reads +/- 3 g
        public const string DESIGNATOR_CHAR = "A"; //character which update line checks for to designate data towards sensor


        public double[] Readings { get; set; }

        public double X_Offset = 0;
        public double Y_Offset = 0;
        public double Z_Offset = 0;

        public Accelerometer_Sensor()
        {
            Designator = DESIGNATOR_CHAR;
        }

        public override void Reset()
        {

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

            return false;
        }

        bool read_D_Line(string[] split)
        {
            double[] reading = new double[3];

            for (int i = 0; i != 3; i++)
            {
                if (!double.TryParse(split[(int)Accelerometer_DataColumns_D.AccX + i], out reading[i])) { return false; }
                reading[i] = reading[i] * FULL_SCALE_REAL * 2 / FULL_SCALE_IO;
            }

            Readings = reading;

            return true;
        }

        bool read_C_Line(string[] split)
        {
            if (!double.TryParse(split[(int)Accerlerometer_DataColumns_C.Xoff], out X_Offset)) { return false; }
            if (!double.TryParse(split[(int)Accerlerometer_DataColumns_C.Yoff], out Y_Offset)) { return false; }
            if (!double.TryParse(split[(int)Accerlerometer_DataColumns_C.Zoff], out Z_Offset)) { return false; }

            return true;
        }
    }
}
