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
using Guantanamo_GUI.SensorModules;

namespace Guantanamo_GUI.SensorModules
{
    public partial class VehicleState : BaseSensorModule 
    {
        public const int MAX_POINTS_X = 100;
        public const int Y_AXIS_RANGE = 60;

        int pointIndex = 0;

        public VehicleState(PresenterManager owner)
            : base(owner, Sensor_Modules.VehicleState)
        {
            InitializeComponent();

            Designators = "V";
        }

        public void Reset()
        {
            resetPlot();
            resetLabels();
        }

        public void Update(string line)
        {

        }

        public override void UpdateUI(string designator)
        {
            if (pointIndex > MAX_POINTS_X) { resetPlot(); }

            txtSteering.Text = VehicleSystems.VehicleState.SteeringServo.ToString();
            txtThrottle.Text = VehicleSystems.VehicleState.Throttle.ToString();

            chData.Series[0].Points.Add(new DataPoint(pointIndex, VehicleSystems.VehicleState.SteeringServo));
            chData.Series[1].Points.Add(new DataPoint(pointIndex, VehicleSystems.VehicleState.Throttle));

            pointIndex++;
        }

        void resetLabels()
        {
            
        }

        void resetPlot()
        {
            pointIndex = 0;
            chData.Series[0].Points.Clear();
            chData.Series[1].Points.Clear();
            chData.ChartAreas[0].AxisY.Maximum = Y_AXIS_RANGE;
            chData.ChartAreas[0].AxisY.Minimum = -Y_AXIS_RANGE;
            chData.ChartAreas[0].AxisX.Maximum = MAX_POINTS_X;
            chData.ChartAreas[0].AxisX.Minimum = 0;
        }

        private void VehicleState_Load(object sender, EventArgs e)
        {
            resetPlot();
        }
    }
}
