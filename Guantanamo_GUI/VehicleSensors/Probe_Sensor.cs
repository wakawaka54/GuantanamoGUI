using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Guantanamo_GUI.VehicleSensors;

namespace Guantanamo_GUI.VehicleSensors
{
    class Probe_Sensor : Sensor
    {
        public const string DESIGNATOR_CHAR = "P";

        public List<double> Readings = new List<double>();

        public Probe_Sensor()
        {
            Designator = DESIGNATOR_CHAR;
        }

        public override void Reset()
        {
            Readings = new List<double>();
        }

        public override bool Update(string[] split)
        {
            Readings.Clear();

            for (int i = 1; i < split.Length; i++)
            {
                double read;
                if (!double.TryParse(split[i], out read)) { return false; }
                Readings.Add(read);
            }

            return true;
        }
    }
}
