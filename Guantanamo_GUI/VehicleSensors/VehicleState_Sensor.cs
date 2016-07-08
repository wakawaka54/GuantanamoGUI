using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Guantanamo_GUI.VehicleSensors;

namespace Guantanamo_GUI.VehicleSensors
{
    class VehicleState_Sensor : Sensor
    {
        public const string DESIGNATOR_CHAR = "V"; //character which update line checks for to designate data towards sensor
        public int SteeringServo = 0;
        public int Throttle = 0;

        public VehicleState_Sensor()
        {
            Designator = DESIGNATOR_CHAR;
        }

        public override void Reset()
        {

        }

        public override bool Update(string[] split)
        {
            if (split.Length < 2) { return false; }

            if (!int.TryParse(split[(int)VehicleState_Data_Columns.SteeringServo], out SteeringServo)) { return false; }
            if (!int.TryParse(split[(int)VehicleState_Data_Columns.Throttle], out Throttle)) { return false; }

            return true;
        }
    }
}
