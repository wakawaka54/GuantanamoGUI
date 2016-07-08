using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Guantanamo_GUI.VehicleSensors;

namespace Guantanamo_GUI.VehicleSensors
{
    class Ultrasonic_Sensor : Sensor
    {
        public const string DESIGNATOR_CHAR = "U";

        public double Distance = 0;

        public Ultrasonic_Sensor()
        {
            Designator = DESIGNATOR_CHAR;
        }

        public override void Reset()
        {

        }

        public override bool Update(string[] split)
        {

            if (!double.TryParse(split[(int)Ultrasonic_DataColumns.Distance], out Distance)) { return false; }

            return true;
        }
    }
}
