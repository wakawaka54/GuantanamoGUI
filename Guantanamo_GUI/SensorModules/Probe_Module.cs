using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Guantanamo_GUI.SensorModules
{
    public partial class Probe_Module : BaseSensorModule 
    {
        const double Y_Max = 180;
        const double Y_Min = -180;
        const int MAX_POINTS_X = 250;

        int currentPoint = 0;

        public Probe_Module(PresenterManager owner)
            : base(owner, Sensor_Modules.Probe)
        {
            InitializeComponent();

            Designators = "P";

            Reset();
        }

        public void Reset()
        {
            resetPlot();
            resetLabels();
        }

        void setupLegend()
        {
            try
            {
                chData.Series[0].Name = "Gyro Heading";
                chData.Series[1].Name = "Mag Heading";
                chData.Series[2].Name = "Filtered Heading";
            }
            catch { MessageBox.Show("ERROR Setting up Probe Legend"); return; }
        }

        void resetLabels()
        {
            txtYMax.Text = chData.ChartAreas[0].AxisY.Maximum.ToString();
            txtYMin.Text = chData.ChartAreas[0].AxisY.Minimum.ToString();
        }

        void resetPlot()
        {
            chData.Series.Clear();
            chData.ChartAreas[0].AxisY.Maximum = Y_Max;
            chData.ChartAreas[0].AxisY.Minimum = Y_Min;

            chData.ChartAreas[0].AxisX.Maximum = MAX_POINTS_X;

            currentPoint = 0;
        }

        public override void UpdateUI(string designator)
        {
            if (VehicleSystems.Probe.Readings.Count > chData.Series.Count) { createNewSeries(); }
            for (int i = 0; i != VehicleSystems.Probe.Readings.Count; i++)
            {
                if (chData.Series[i].Points.Count > MAX_POINTS_X) { chData.Series[i].Points.Clear(); currentPoint = 0; }
                chData.Series[i].Points.Add(new DataPoint( currentPoint,VehicleSystems.Probe.Readings[i]));
                chData.Series[i].ChartType = SeriesChartType.FastLine;
            }

            currentPoint++;
        }

        void createNewSeries()
        {
            for (int i = chData.Series.Count; i < VehicleSystems.Probe.Readings.Count; i++)
            {
                chData.Series.Add(i.ToString());
                chData.Series[i].ChartType = SeriesChartType.FastLine;
                chData.Series[i].ChartArea = chData.ChartAreas[0].Name;
            }

            setupLegend();
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            double yMax, yMin;
            if (!double.TryParse(txtYMax.Text, out yMax)) { MessageBox.Show("Y Max Invalid"); return; }
            if (!double.TryParse(txtYMin.Text, out yMin)) { MessageBox.Show("Y Min Invalid"); return; }

            chData.ChartAreas[0].AxisY.Maximum = yMax;
            chData.ChartAreas[0].AxisY.Minimum = yMin;
        }
    }
}
