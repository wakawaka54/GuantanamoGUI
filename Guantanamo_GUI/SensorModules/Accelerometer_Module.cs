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
using Guantanamo_GUI.VehicleSensors;

namespace Guantanamo_GUI.SensorModules
{
    public partial class Accelerometer_Module : BaseSensorModule 
    {
        const int MAX_POINTS_X = 100;

        int pointIndex = 0;

        public Accelerometer_Module(PresenterManager owner)
            : base(owner, Sensor_Modules.Accerlerometer)
        {
            InitializeComponent();

            Designators = "A";
        }

        public void Reset()
        {
            resetPlot();
            ResetLabels();
        }

        public void ResetLabels()
        {
            txtAccX.Text = "";
            txtAccY.Text = "";
            txtAclZ.Text = "";
        }

        public override void UpdateUI(string designator)
        {
            if (pointIndex > MAX_POINTS_X) { resetPlot(); }

            if (VehicleSystems.Accelerometer.Readings == null) { return; }

            double[] readings = VehicleSystems.Accelerometer.Readings;

            txtAccX.Text = readings[0].ToString("N2");
            txtAccY.Text = readings[1].ToString("N2");
            txtAclZ.Text = readings[2].ToString("N2");

            chData.Series[0].Points.Add(new DataPoint(pointIndex, readings[0]));
            chData.Series[1].Points.Add(new DataPoint(pointIndex, readings[1]));
            chData.Series[2].Points.Add(new DataPoint(pointIndex, readings[2]));

            pointIndex++;
        }

        void resetPlot()
        {
            pointIndex = 0;
            chData.Series[0].Points.Clear();
            chData.Series[1].Points.Clear();
            chData.Series[2].Points.Clear();
            chData.ChartAreas[0].AxisY.Maximum = Accelerometer_Sensor.FULL_SCALE_REAL;
            chData.ChartAreas[0].AxisY.Minimum = -Accelerometer_Sensor.FULL_SCALE_REAL;
            chData.ChartAreas[0].AxisX.Minimum = 0;
            chData.ChartAreas[0].AxisX.Maximum = MAX_POINTS_X;
        }

        private void Accelerometer_Module_Load(object sender, EventArgs e)
        {
            resetPlot();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
