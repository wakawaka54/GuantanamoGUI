using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guantanamo_GUI.VehicleSensors
{
    public class Sensor
    {
        public string Designator = "";

        public Sensor()
        {

        }

        public virtual bool CheckDesignator(string lineDesi)
        {
            if (lineDesi != Designator) { return false; }
            return true;
        }

        public virtual void Reset()
        {

        }

        public virtual bool Update(string[] data)
        {
            return true;
        }
    }
}
