using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guantanamo_GUI.UltilityModules.DataVisualizer;
using System.Windows.Forms.DataVisualization.Charting;

namespace Guantanamo_GUI.UltilityModules
{
    public partial class DataVisualizer_Utility : UtilityBase
    {
        Visualizer_Base DataSource;

        public DataVisualizer_Utility(PresenterManager owner, DataVisualization_Controls chartType)
            :base(owner, Utility_Modules.DataVisualizer_MagGyroVehicle)
        {
            InitializeComponent();

            DataSource = Visualizer_Base.GetVisualizer_ForType(chartType);

            chData.ChartAreas[0].AxisX.Minimum = DataSource.XBounds[0];
            chData.ChartAreas[0].AxisX.Maximum = DataSource.XBounds[1];

            chData.ChartAreas[0].AxisY.Minimum = DataSource.YBounds[0];
            chData.ChartAreas[0].AxisY.Maximum = DataSource.YBounds[1];

            lbTitle.Text = DataSource.DataTitle;


            chData.Series.Clear();

            foreach (string series in DataSource.Series.Keys)
            {
                chData.Series.Add(series);
                chData.Series[series].ChartType = SeriesChartType.FastLine;
                chData.Series[series].BorderWidth = 3;
            }

            updateTimer.Interval = 100;
        }

        public override void UpdateUI(string line)
        {
            DataSource.Update();

            foreach (string key in DataSource.Series.Keys)
            {
                if (chData.Series[key].Points.Count > DataSource.Series[key].Count) { chData.Series[key].Points.Clear(); }

                if (chData.Series[key].Points.Count < DataSource.Series[key].Count)
                {
                    for (int i = chData.Series[key].Points.Count; i < DataSource.Series[key].Count; i++)
                    {
                        chData.Series[key].Points.Add(DataSource.Series[key][i]);
                    }
                }
            }
        }
    }
}
