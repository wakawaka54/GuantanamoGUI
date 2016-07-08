using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace Guantanamo_GUI.UltilityModules.DataVisualizer
{
    class Visualizer_Base
    {
        public static Visualizer_Base GetVisualizer_ForType(DataVisualization_Controls type)
        {
            switch (type)
            {
                case DataVisualization_Controls.Heading_MagGyroVehicle:
                    return new Visualizer_MagGyroVehicle();

                case DataVisualization_Controls.Heading_PID:
                    return new Visualizer_WPHeadingSteering();

                case DataVisualization_Controls.ImageArea:
                    return new Visualizer_ImageArea();

                case DataVisualization_Controls.ImageCentroid:
                    return new Visualizer_ImageCentroid();

                case DataVisualization_Controls.MagXYZ_Norm:
                    return new Visualizer_MagNorm();

                case DataVisualization_Controls.VehicleInformation:
                    return new Visualizer_VehicleControl();
            }

            return new Visualizer_Base();
        }

        public string DataTitle = "";
        public int[] YBounds = new int[2];
        public int[] XBounds = new int[2];


        public Stopwatch XAxis_Timer;
        public bool IsXAxis_Time
        {
            get
            {
                return isXAxisTime;
            }
            set
            {
                if (value)
                {
                    XAxis_Timer = new Stopwatch();
                    XAxis_Timer.Start();
                }
                else
                {
                    XAxis_Timer.Stop();
                }

                isXAxisTime = value;
            }
        }

        bool isXAxisTime = false;

        public Dictionary<string, List<DataPoint>> Series = new Dictionary<string, List<DataPoint>>();

        public Visualizer_Base()
        {
            
        }

        public void Clear()
        {
            XAxis_Timer.Restart();

            foreach (string key in Series.Keys)
            {
                Series[key].Clear();
            }
        }

        public virtual void Update()
        {
            if (XAxis_Timer.ElapsedMilliseconds > XBounds[1]) { Clear(); } //reset X axis
        }
    }
}
