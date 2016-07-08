using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guantanamo_GUI.Commands;

namespace Guantanamo_GUI.UltilityModules
{
    public partial class Calibration_Gyroscope : UtilityBase
    {
        public Calibration_Gyroscope(PresenterManager owner)
            :base(owner, Utility_Modules.Calibrate_Gyro)
        {
            InitializeComponent();
        }

        public override void UpdateUI(string line)
        {
            txtXOff.Text = "N/A";
            txtYOff.Text = VehicleSystems.Gyroscope.HeadingDrift_Offset.ToString("N9");
            txtZOff.Text = VehicleSystems.Gyroscope.Z_Offset.ToString();
            txtDrift.Text = VehicleSystems.Gyroscope.HeadingDrift.ToString("N2");
        }

        private void btnCalZ_Click(object sender, EventArgs e)
        {
            VehicleSystems.SendCommand(GlobalVehicleCommands.CalibrationGyro(new string[] { "2"}));
        }

        private void btnStore_Click(object sender, EventArgs e)
        {
            VehicleSystems.SendCommand(GlobalVehicleCommands.CalibrationGyro(new string[] { "3" }));
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            VehicleSystems.SendCommand(GlobalVehicleCommands.CalibrationGyro(new string[] { "4" }));
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            VehicleSystems.SendCommand(GlobalVehicleCommands.ReadCalibrations());
        }

        private void btnCalOffset_Click(object sender, EventArgs e)
        {
            VehicleSystems.SendCommand(GlobalVehicleCommands.CalibrationGyro(new string[] { "1" }));
        }
    }
}
