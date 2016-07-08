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
    public partial class ImageProcessing_Module : BaseSensorModule
    {
        public ImageProcessing_Module(PresenterManager owner)
            :base(owner, Sensor_Modules.ImageProcessing)
        {
            InitializeComponent();
            ResetUI();

            Designators = "J";
        }

        public override void ResetUI()
        {
            chData.ChartAreas[0].AxisX.Minimum = 0;
            chData.ChartAreas[0].AxisX.Maximum = 320;
            chData.ChartAreas[0].AxisY.Minimum = 0;
            chData.ChartAreas[0].AxisY.Maximum = 240;
            chData.Series[0].Points.Clear();
            chData.Series[0].Points.Add(new DataPoint(-1, -1));
        }

        public override void UpdateUI(string designator)
        {
            chData.Series[0].Points[0] = new DataPoint(VehicleSystems.ImageProcessing.Readings_XY[0], VehicleSystems.ImageProcessing.Readings_XY[1]);
            txtX.Text = VehicleSystems.ImageProcessing.Readings_XY[0].ToString();
            txtY.Text = VehicleSystems.ImageProcessing.Readings_XY[1].ToString();
            txtArea.Text = VehicleSystems.ImageProcessing.Area.ToString();

            if (txtReceived.Text.Length != VehicleSystems.ImageProcessing.ReceivedLines.Length) { txtReceived.Text = VehicleSystems.ImageProcessing.ReceivedLines; }
            if (txtSent.Text.Length != VehicleSystems.ImageProcessing.SentLines.Length) { txtSent.Text = VehicleSystems.ImageProcessing.SentLines; }

            string[] split = designator.Split(',');

            if (split[0] == "J" && split[1] == "P" && split[2] == "E")
            {
                pbImage.Image = VehicleSystems.ImageProcessing.ImageBuffer;
                pbImage.SizeMode = PictureBoxSizeMode.StretchImage;
                pbImage.Size = new Size(200, 300);
            }

            txtRows.Text = VehicleSystems.ImageProcessing.RowsReceived.ToString();
        }

        private void txtClearBuffers_Click(object sender, EventArgs e)
        {
            VehicleSystems.ImageProcessing.ClearLineBuffers();
            txtSent.Text = "";
            txtReceived.Text = "";
        }

        private void ImageProcessing_Module_Load(object sender, EventArgs e)
        {
            pbImage.Image = VehicleSystems.ImageProcessing.ImageBuffer;
            pbImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pbImage.Size = new Size(200, 300);
            txtSent.Text = VehicleSystems.ImageProcessing.SentLines;
            txtReceived.Text = VehicleSystems.ImageProcessing.ReceivedLines;
        }

        private void btnHi_Click(object sender, EventArgs e)
        {
            
        }

        private void btnStopHi_Click(object sender, EventArgs e)
        {
            VehicleSystems.EndHighDataTransfer();
        }
    }
}
