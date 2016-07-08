using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guantanamo_GUI.Commands
{
    public enum VehicleCommands_Enum
    {
        ResetVehicleState = 1, WaypointNavigation = 2, SetSteeringAngle = 3, VehicleStateChange = 4, ReadCalibrations = 5,
        ToggleGPS_Output = 6, SendPMTKSentence = 7, CalibrationGyro = 8, NavigateTowardsHeading = 9,
        StopVehicle = 10, ThrottleSet = 11, ImageProcessing = 12, CalibrationCompass = 13, ReadDMP_Gains = 14, SetDMP_HeadingGains = 15, State_EEPROM_Edit = 16,
        ReadPIDGains = 17, SetPIDGains = 18, NONE = 100
    }

    class GlobalVehicleCommands
    {
        public static string VehicleCommandString(VehicleCommands_Enum command, string[] param)
        {
            switch (command)
            {
                case VehicleCommands_Enum.NONE:
                    throw new Exception("UNITITALIZED COMMAND TYPE");

                case VehicleCommands_Enum.ResetVehicleState:
                    return VehicleState_Reset();

                case VehicleCommands_Enum.WaypointNavigation:
                    return WaypointNavigation(param);

                case VehicleCommands_Enum.SetSteeringAngle:
                    return SetSteeringAngle(param);

                /*case VehicleCommands_Enum.CalibrationADX:
                    return CalibrationADX(param);*/

                case VehicleCommands_Enum.VehicleStateChange:
                    return VehicleStateChange(param);

                case VehicleCommands_Enum.ToggleGPS_Output:
                    return ToggleGPS_Output();

                case VehicleCommands_Enum.SendPMTKSentence:
                    return SendPMTKSentence(param);

                case VehicleCommands_Enum.CalibrationGyro:
                    return CalibrationGyro(param);

                case VehicleCommands_Enum.NavigateTowardsHeading:
                    return NavigateTowardsHeading(param);

                case VehicleCommands_Enum.StopVehicle:
                    return StopVehicle();

                case VehicleCommands_Enum.ThrottleSet:
                    return ThrottleSet(param);

                case VehicleCommands_Enum.ImageProcessing:
                    return ImageProcessingCommand(param);

                case VehicleCommands_Enum.ReadCalibrations:
                    return ReadCalibrations();

                case VehicleCommands_Enum.CalibrationCompass:
                    return CalibrationCompass(param);

                case VehicleCommands_Enum.SetDMP_HeadingGains:
                    return SetDMP_HeadingGains(param);

                case VehicleCommands_Enum.ReadDMP_Gains:
                    return ReadDMP_Gains();

                case VehicleCommands_Enum.SetPIDGains:
                    return SetDMP_PIDGains(param);

                case VehicleCommands_Enum.ReadPIDGains:
                    return ReadDMP_PIDGains();
            }

            return "";
        }

        public static string ReadDMP_PIDGains()
        {
            return "!" + getCommandDesignator(VehicleCommands_Enum.ReadPIDGains) + "()";
        }

        public static string SetDMP_PIDGains(string[] param)
        {
            return "!" + getCommandDesignator(VehicleCommands_Enum.SetPIDGains) + formatParams(param);
        }

        public static string SetDMP_HeadingGains(string[] param)
        {
            return "!" + getCommandDesignator(VehicleCommands_Enum.SetDMP_HeadingGains) + formatParams(param);
        }

        public static string ReadDMP_Gains()
        {
            return "!" + getCommandDesignator(VehicleCommands_Enum.ReadDMP_Gains) + "()";
        }
        
        public static string CalibrationCompass(string[] param)
        {
            return "!" + getCommandDesignator(VehicleCommands_Enum.CalibrationCompass) + formatParams(param);
        }

        public static string ReadCalibrations()
        {
            return "!" + getCommandDesignator(VehicleCommands_Enum.ReadCalibrations) + "()";
        }

        public static string VehicleState_Reset()
        {
            string command = "!" + getCommandDesignator(VehicleCommands_Enum.ResetVehicleState) + "()";
            return command;
        }

        public static string WaypointNavigation(string[] param)
        {
            string command = "!" + getCommandDesignator(VehicleCommands_Enum.WaypointNavigation) + formatParams(param);
            return command;
        }

        public static string SetSteeringAngle(string[] param)
        {
            return "!" + getCommandDesignator(VehicleCommands_Enum.SetSteeringAngle) + formatParams(param);
        }

        /*public static string CalibrationADX(string[] param)
        {
            return "!" + getCommandDesignator(VehicleCommands_Enum.CalibrationADX) + formatParams(param);
        }*/

        public static string State_EEPROM_Edit(string[] param)
        {
            return "!" + getCommandDesignator(VehicleCommands_Enum.State_EEPROM_Edit) + formatParams(param);
        }

        public static string VehicleStateChange(string[] param)
        {
            return "!" + getCommandDesignator(VehicleCommands_Enum.VehicleStateChange) + formatParams(param);
        }

        public static string ToggleGPS_Output()
        {
            return "!" + getCommandDesignator(VehicleCommands_Enum.ToggleGPS_Output) + "()";
        }

        public static string SendPMTKSentence(string[] param)
        {
            return "!" + getCommandDesignator(VehicleCommands_Enum.SendPMTKSentence) + formatParams(param);
        }

        public static string CalibrationGyro(string[] param)
        {
            return "!" + getCommandDesignator(VehicleCommands_Enum.CalibrationGyro) + formatParams(param);
        }

        public static string NavigateTowardsHeading(string[] param)
        {
            return "!" + getCommandDesignator(VehicleCommands_Enum.NavigateTowardsHeading) + formatParams(param);
        }

        public static string StopVehicle()
        {
            return "!" + getCommandDesignator(VehicleCommands_Enum.StopVehicle) + "()";
        }

        public static string ThrottleSet(string[] param)
        {
            return "!" + getCommandDesignator(VehicleCommands_Enum.ThrottleSet) + formatParams(param);
        }

        public static string ImageProcessingCommand(string[] param)
        {
            return "!" + getCommandDesignator(VehicleCommands_Enum.ImageProcessing) + formatParams(param);
        }

        static string formatParams(string[] param)
        {
            if (param.Length == 0) { return ""; }

            string format = "(";
            for (int i = 0; i != param.Length - 1; i++)
            {
                format += param[i];
                format += ",";
            }

            format += param[param.Length - 1] + ")";

            return format;
        }

        static string getCommandDesignator(VehicleCommands_Enum command)
        {
            if ((int)command < 10) { return ((int)command).ToString(); }
            return ((char)((int)'A' + ((int)command - 10))).ToString();
        }
    }
}
