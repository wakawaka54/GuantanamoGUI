using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace Guantanamo_GUI.UltilityModules.DataVisualizer
{
    class Visualizer_WPHeadingSteering : Visualizer_Base
    {
        public readonly string[] SeriesNames = { "Heading To Waypoint", "Vehicle Heading", "Steering Input" };

        public Visualizer_WPHeadingSteering()
        {
            DataTitle = "Heading PID Performance";

            YBounds = new int[2] {-180, 180};
            XBounds = new int[2] { 0, 30000 };

            Series.Add(SeriesNames[0], new List<DataPoint>());
            Series.Add(SeriesNames[1], new List<DataPoint>());
            Series.Add(SeriesNames[2], new List<DataPoint>());

            IsXAxis_Time = true;    
        }

        public override void Update()
        {
            DataPoint headingTo = new DataPoint(XAxis_Timer.ElapsedMilliseconds, VehicleSystems.GPS.HeadingTo);
            DataPoint vehicleHeading = new DataPoint(XAxis_Timer.ElapsedMilliseconds, VehicleSystems.Magnetometer.VehicleHeading);
            DataPoint steeringInput = new DataPoint(XAxis_Timer.ElapsedMilliseconds, VehicleSystems.VehicleState.SteeringServo);


            Series[SeriesNames[0]].Add(headingTo);
            Series[SeriesNames[1]].Add(vehicleHeading);
            Series[SeriesNames[2]].Add(steeringInput);

            if (XAxis_Timer.ElapsedMilliseconds > XBounds[1]) { Clear(); } //reset X axis
        }
    }
}
