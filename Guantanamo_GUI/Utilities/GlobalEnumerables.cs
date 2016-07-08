using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guantanamo_GUI
{
    public enum Sensor_Modules
    {
        Accerlerometer, GPS, Gyroscope, ImageProcessing, Magnetometer, Navigation,
        Probe, Ultrasonic, VehicleDiagnostics, VehicleState, SerialMonitor, END_OF_ENUM
    }

    public enum Utility_Modules
    {
        CommandSender, LogExtracter, Navigation_Utility, SerialConnect, SerialHealth,
        Calibrate_Accerlerometer, Calibrate_Gyro, Calibrate_Compass, Calibrate_DMP, StateEditor, DataVisualizer_MagGyroVehicle, DataVisualizer_WPHeadingSteering,
        DataVisualizer_ImageArea, DataVisualizer_ImageCentroid, DataVisualizer_MagXYZNorm, DataVisualizer_VehicleInformation, LogUtility, StateHistory, END_OF_ENUM
    }

    public enum DataVisualization_Controls
    {
        Heading_MagGyroVehicle, Heading_PID, ImageArea, ImageCentroid, MagXYZ_Norm, VehicleInformation
    }
}
