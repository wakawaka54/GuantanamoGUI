using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guantanamo_GUI.VehicleSensors
{
    class DigitalMotion_Sensor : Sensor
    {
        public double Heading_AngChange_Gyro = 0;
        public double Heading_AngChange_Mag = 0;
        public double Heading_Error_Mag = 0;

        public double Steering_WP_KP = 0;
        public double Steering_WP_KI = 0;
        public double Steering_WP_KD = 0;

        public double Steering_ImAvoid_KP = 0;
        public double Steering_ImAvoid_KI = 0;
        public double Steering_ImAvoid_KD = 0;
        public int Steering_ImAvoid_MaxArea = 0;
        public int Steering_ImAvoid_MinArea = 0;
        public int Steering_ImAvoid_CentroidJump = 0;

        public double Steering_ImGoTo_KP = 0;
        public double Steering_ImGoTo_KI = 0;
        public double Steering_ImGoTo_KD = 0;
        public int Steering_ImGoTo_MaxArea = 0;

        public double Steering_ImFollow_KP = 0;
        public double Steering_ImFollow_KI = 0;
        public double Steering_ImFollow_KD = 0;
        public int Steering_ImFollow_MaxArea = 0;
        public int Steering_ImFollow_MinArea = 0;
        public int Steering_ImFollow_LeftTarget = 0;
        public int Steering_ImFollow_RightTarget = 0;
        public int Steering_ImFollow_CentroidJump = 0;


        public DigitalMotion_Sensor()
        {
            Designator = "Y";
        }

        public override bool Update(string[] split)
        {
            switch (split[1])
            {
                case "H":
                    return read_H_Line(split);

                case "P":
                    return read_P_Line(split);

            }

            return false;
        }

        bool read_H_Line(string[] split)
        {
            if (!double.TryParse(split[(int)DigitalMotion_DataColumns_H.AngChange_Gyro], out Heading_AngChange_Gyro)) { return false; }
            if (!double.TryParse(split[(int)DigitalMotion_DataColumns_H.AngChange_Mag], out Heading_AngChange_Mag)) { return false; }
            if (!double.TryParse(split[(int)DigitalMotion_DataColumns_H.HeadingError_Mag], out Heading_Error_Mag)) { return false; }

            return true;
        }

        bool read_P_Line(string[] split)
        {
            short gainNumber = 0;
            double gain = 0;

            if (!short.TryParse(split[(int)DigitalMotion_DataColumns_P.GainNumber], out gainNumber)) { return false; }
            if(!double.TryParse(split[(int)DigitalMotion_DataColumns_P.GainValue], out gain)) { return false;} 

            switch (gainNumber)
            {
                case 0:
                    Steering_WP_KP = gain;
                    break;

                case 1:
                    Steering_WP_KI = gain;
                    break;

                case 2:
                    Steering_WP_KD = gain;
                    break;

                case 3:
                    Steering_ImAvoid_KP = gain;
                    break;

                case 4:
                    Steering_ImAvoid_KI = gain;
                    break;

                case 5:
                    Steering_ImAvoid_KD = gain;
                    break;

                case 6:
                    Steering_ImAvoid_MinArea = (int)gain;
                    break;

                case 7:
                    Steering_ImAvoid_MaxArea = (int)gain;
                    break;

                case 8:
                    Steering_ImGoTo_KP = gain;
                    break;

                case 9:
                    Steering_ImGoTo_KI = gain;
                    break;

                case 10:
                    Steering_ImGoTo_KP = gain;
                    break;

                case 11:
                    Steering_ImGoTo_MaxArea = (int)gain;
                    break;

                case 12:
                    Steering_ImFollow_KP = gain;
                    break;

                case 13:
                    Steering_ImFollow_KI = gain;
                    break;

                case 14:
                    Steering_ImFollow_KD = gain;
                    break;

                case 15:
                    Steering_ImFollow_MaxArea = (int)gain;
                    break;

                case 16:
                    Steering_ImFollow_MinArea = (int)gain;
                    break;

                case 17:
                    Steering_ImFollow_LeftTarget = (int)gain;
                    break;

                case 18:
                    Steering_ImFollow_RightTarget = (int)gain;
                    break;

                case 19:
                    Steering_ImFollow_CentroidJump = (int)gain;
                    break;

                case 20:
                    Steering_ImAvoid_CentroidJump = (int)gain;
                    break;


                default:
                    return false;
            }

            return true;
        }
    }
}
