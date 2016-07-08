using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guantanamo_GUI.VehicleSensors
{
    public enum Accelerometer_DataColumns_D
    {
        TagID = 1, AccX = 2, AccY = 3, AccZ = 4
    }

    public enum Accerlerometer_DataColumns_C
    {
        TagID = 1, Xoff = 2, Yoff = 3, Zoff = 4
    }

    public enum DigitalMotion_DataColumns_H
    {
        TagID = 1, AngChange_Gyro = 2, AngChange_Mag = 3, HeadingError_Mag = 4
    }

    public enum DigitalMotion_DataColumns_P
    {
        GainNumber = 2, GainValue = 3
    }

    public enum VehicleDiagnostics_DataColumn_S
    {
        SampleRate_GPS = 2, SampleRate_Mag = 3, RamAvailable = 4, SampleRate_Acc = 5, SampleRate_Gyro = 6, VehicleState = 7, SampleRate_RPI = 8,
        SampleRate_Ultrasonic = 9, SampleRate_Loop = 10, Uptime = 11, GPS_AvailableMax = 12
    }

    public enum VehicleDiagnostics_DataColumn_C
    {
        I2C_Timeouts = 2, SentCommands_RPI = 3, AcksReceived_RPI = 4
    }

    public enum VehicleDiagnostics_DataColumns_H
    {
        VehicleState = 2, ChangeReason = 3
    }

    public enum ImageProcessing_DataColumns_V
    {
        CentroidX = 2, CentroidY = 3, Area = 4
    }

    public enum ImageProcessing_DataColumns_R
    {
        ReceivedSerial = 2
    }

    public enum ImageProcessing_DataColumns_S
    {
        SentSerial = 2
    }

    public enum GPS_DataColumns_P
    {
        GPS_Tag = 1, Latitude = 2, Longitude = 3, Heading = 4, Time = 5
    }

    public enum GPS_DataColumns_I
    {
        GPS_Tag = 1, HDOP = 2, Satellites = 3, FailedChecksums = 4, Sentences = 5, ReceivedChars = 6, Speed = 7, Fix_Age = 8
    }

    public enum GPS_DataColumns_L
    {
        GPS_Tag = 1, Data = 2
    }

    public enum GPS_DataColumns_W
    {
        GPS_Tag = 1, Latitute = 2, Longitude = 3, WP_Heading = 4, WP_Distance = 5
    }

    public enum Gyroscope_DataColumns_D
    {
        TagID = 1, GyroX = 2, GyroY = 3, GyroZ = 4, GyroHeading = 5
    }

    public enum Gyroscope_DataColumns_C
    {
        TagID = 1, Xoff = 2, Yoff = 3, Zoff = 4, DriftOffset = 5
    }

    public enum Magnetometer_DataColumns_D
    {
        X = 2, Y = 3, Z = 4, Heading = 5, FilteredHeading = 6
    }

    public enum Magnetometer_DataColumns_C
    {
        OffX = 2, OffY = 3, OffZ = 4, ScaleX = 5, ScaleY = 6, ScaleZ = 7, DeclinationAngle = 8
    }

    public enum Magnetometer_DataColumns_Z //used for calibration
    {
        MaxX = 2, MaxY = 3, MaxZ = 4, MinX = 5, MinY = 6, MinZ = 7
    }

    public enum Controller_DataColumns
    {
        Status = 1
    }

    public enum Ultrasonic_DataColumns
    {
        Distance = 1
    }

    public enum VehicleState_Data_Columns
    {
        SteeringServo = 1, Throttle = 2
    }
}
