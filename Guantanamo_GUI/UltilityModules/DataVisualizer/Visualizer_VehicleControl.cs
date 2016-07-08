using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace Guantanamo_GUI.UltilityModules.DataVisualizer
{
    class Visualizer_VehicleControl : Visualizer_Base
    {
        public readonly string[] SeriesNames = { "Speed", "Steering" };

        public Visualizer_VehicleControl()
        {
            DataTitle = "Vehicle Control Information";

            YBounds = new int[2] {-10, 50};
            XBounds = new int[2] { 0, 30000 };

            Series.Add(SeriesNames[0], new List<DataPoint>());
            Series.Add(SeriesNames[1], new List<DataPoint>());

            IsXAxis_Time = true;    
        }

        public override void Update()
        {
            DataPoint vehicleSpeed = new DataPoint(XAxis_Timer.ElapsedMilliseconds, VehicleSystems.GPS.Speed);
            DataPoint vehicleControl = new DataPoint(XAxis_Timer.ElapsedMilliseconds, CMath.Map(VehicleSystems.VehicleState.SteeringServo, -180, 180, -10, 50));


            Series[SeriesNames[0]].Add(vehicleSpeed);
            Series[SeriesNames[1]].Add(vehicleControl);

            if (XAxis_Timer.ElapsedMilliseconds > XBounds[1]) { Clear(); } //reset X axis
        }
    }
}
