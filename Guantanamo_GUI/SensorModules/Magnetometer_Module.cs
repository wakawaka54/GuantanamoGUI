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
    public partial class Magnetometer_Module : BaseSensorModule 
    {
        public const int MAX_POINTS_ON_PATH = 100;
        public const int AXISY_MAX = 10;

        int pointIndex = 0;

        public Magnetometer_Module(PresenterManager owner)
            : base(owner, Sensor_Modules.Magnetometer)
        {
            InitializeComponent();

            Designators = "M";

            chData.ChartAreas[0].AxisY.Maximum = AXISY_MAX;
            chData.ChartAreas[0].AxisY.Minimum = 0;

            Reset();
        }

        public void Reset()
        {
            ResetChart();
            ResetLabels();
        }

        public void ResetLabels()
        {
            txtX.Text = "";
            txtY.Text = "";
            txtZ.Text = "";
            txtHeading.Text = "";
            txtNorm.Text = "";
            txtNormXY.Text = "";
        }

        public void ResetChart()
        {
            chData.Series[0].Points.Clear();
            chData.Series[1].Points.Clear();
            chData.Series[2].Points.Clear();
            chData.Series[3].Points.Clear();
            chData.ChartAreas[0].AxisY.Maximum = AXISY_MAX;
            chData.ChartAreas[0].AxisY.Minimum = 0;
            chData.Series[0].Points.Add(new DataPoint(0,0));
            chData.Series[3].Points.Add(new DataPoint(0, 0));
            chData.Series[2].Points.Add(new DataPoint(0, 0));
            pointIndex = 0;
        }

        public override void UpdateUI(string designator)
        {
            updateTextboxes();

            double pointY = chData.Series[0].Points[0].XValue;
            pointY = CMath.Map(pointIndex, 0, MAX_POINTS_ON_PATH, 0, AXISY_MAX);

            chData.Series[1].Points.Add(new DataPoint(chData.Series[0].Points[0].XValue, pointY)); //draw true heading path
            chData.Series[0].Points[0] = new DataPoint(VehicleSystems.Magnetometer.VehicleHeading, AXISY_MAX);
            chData.Series[2].Points[0]= new DataPoint(VehicleSystems.GPS.HeadingTo, AXISY_MAX);
            chData.Series[3].Points[0] = new DataPoint(VehicleSystems.Magnetometer.MagHeading, AXISY_MAX);

            chData.Series[2].Enabled = VehicleSystems.GPS.WaypointActive;

            pointIndex++;
            if (pointIndex > MAX_POINTS_ON_PATH) { chData.Series[1].Points.Clear();  pointIndex = 0; }
        }

        void updateTextboxes()
        {
            txtX.Text = VehicleSystems.Magnetometer.MagReading[0].ToString("N2");
            txtY.Text = VehicleSystems.Magnetometer.MagReading[1].ToString("N2");
            txtZ.Text = VehicleSystems.Magnetometer.MagReading[2].ToString("N2");
            txtHeading.Text = VehicleSystems.Magnetometer.VehicleHeading.ToString("N2");
            txtMagHeading.Text = VehicleSystems.Magnetometer.MagHeading.ToString("N2");
            txtNorm.Text = VehicleSystems.Magnetometer.Norm_Mag.ToString("N2");
            txtNormXY.Text = VehicleSystems.Magnetometer.Norm_XY.ToString("N2");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetChart();
            ResetLabels();
        }
    }
}
