using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace Guantanamo_GUI.UltilityModules.DataVisualizer
{
    class Visualizer_ImageCentroid : Visualizer_Base
    {
        public readonly string[] SeriesNames = { "Object Centroid X", "Object Centroid Y"};

        public Visualizer_ImageCentroid()
        {
            DataTitle = "Centroid Analysis";

            YBounds = new int[2] { 0, 360 };
            XBounds = new int[2] { 0, 10000 };

            Series.Add(SeriesNames[0], new List<DataPoint>());
            Series.Add(SeriesNames[1], new List<DataPoint>());

            IsXAxis_Time = true;    
        }

        public override void Update()
        {
            DataPoint centroidX = new DataPoint(XAxis_Timer.ElapsedMilliseconds, VehicleSystems.ImageProcessing.Readings_XY[0]);
            DataPoint centroidY = new DataPoint(XAxis_Timer.ElapsedMilliseconds, VehicleSystems.ImageProcessing.Readings_XY[1]);


            Series[SeriesNames[0]].Add(centroidX);
            Series[SeriesNames[1]].Add(centroidY);

            if (XAxis_Timer.ElapsedMilliseconds > XBounds[1]) { Clear(); } //reset X axis
        }
    }
}
