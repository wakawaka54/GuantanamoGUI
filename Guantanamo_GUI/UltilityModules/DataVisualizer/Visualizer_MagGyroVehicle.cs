using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace Guantanamo_GUI.UltilityModules.DataVisualizer
{
    class Visualizer_MagGyroVehicle : Visualizer_Base
    {
        public readonly string[] SeriesNames = { "Mag Heading", "Gyro Heading", "Filtered Heading", "GPS Heading" };

        public Visualizer_MagGyroVehicle()
        {
            DataTitle = "Heading Complementary Filter Performance";

            YBounds = new int[2] {-180, 180};
            XBounds = new int[2] { 0, 30000 };
            IsXAxis_Time = true;

            Series.Add(SeriesNames[0], new List<DataPoint>());
            Series.Add(SeriesNames[1], new List<DataPoint>());
            Series.Add(SeriesNames[2], new List<DataPoint>());
            Series.Add(SeriesNames[3], new List<DataPoint>());
        }

        public override void Update()
        {
            DataPoint magHeading = new DataPoint(XAxis_Timer.ElapsedMilliseconds, VehicleSystems.Magnetometer.MagHeading);
            DataPoint gyroHeading = new DataPoint(XAxis_Timer.ElapsedMilliseconds, VehicleSystems.Gyroscope.Heading);
            DataPoint filterHeading = new DataPoint(XAxis_Timer.ElapsedMilliseconds, VehicleSystems.Magnetometer.VehicleHeading);
            DataPoint gpsHeading = new DataPoint(XAxis_Timer.ElapsedMilliseconds, VehicleSystems.GPS.Heading);


            Series[SeriesNames[0]].Add(magHeading);
            Series[SeriesNames[1]].Add(gyroHeading);
            Series[SeriesNames[2]].Add(filterHeading);
            Series[SeriesNames[3]].Add(gpsHeading);

            if (XAxis_Timer.ElapsedMilliseconds > XBounds[1]) { Clear(); } //reset X axis
        }
    }
}
