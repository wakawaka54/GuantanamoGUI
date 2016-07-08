using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace Guantanamo_GUI.UltilityModules.DataVisualizer
{
    class Visualizer_MagNorm : Visualizer_Base
    {
        public readonly string[] SeriesNames = { "Mag XYZ Norm" };

        public Visualizer_MagNorm()
        {
            DataTitle = "Magnetometer Vector Magnitude";
            YBounds = new int[2] { 0, 15000 };
            XBounds = new int[2] { 0, 15000 };

            Series.Add(SeriesNames[0], new List<DataPoint>());

            IsXAxis_Time = true;
        }

        public override void Update()
        {
            DataPoint vectorMagnitude = new DataPoint(XAxis_Timer.ElapsedMilliseconds, VehicleSystems.Magnetometer.Norm_Mag);


            Series[SeriesNames[0]].Add(vectorMagnitude);

            if (XAxis_Timer.ElapsedMilliseconds > XBounds[1]) { Clear(); } //reset X axis
        }
    }
}
