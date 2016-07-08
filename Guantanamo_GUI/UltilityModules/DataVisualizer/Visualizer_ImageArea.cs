using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace Guantanamo_GUI.UltilityModules.DataVisualizer
{
    class Visualizer_ImageArea : Visualizer_Base
    {
        public readonly string[] SeriesNames = { "Blob Area", "Object Centroid X"};

        public Visualizer_ImageArea()
        {
            DataTitle = "Image Area & Centroid Analysis";

            YBounds = new int[2] {0, 15000};
            XBounds = new int[2] { 0, 10000 };

            Series.Add(SeriesNames[0], new List<DataPoint>());
            Series.Add(SeriesNames[1], new List<DataPoint>());

            IsXAxis_Time = true;    
        }

        public override void Update()
        {

            DataPoint blobArea = new DataPoint(XAxis_Timer.ElapsedMilliseconds, VehicleSystems.ImageProcessing.Area);
            DataPoint centroidX = new DataPoint(XAxis_Timer.ElapsedMilliseconds, VehicleSystems.ImageProcessing.Readings_XY[0]);


            Series[SeriesNames[0]].Add(blobArea);
            Series[SeriesNames[1]].Add(centroidX); 

            base.Update();
        }
    }
}
