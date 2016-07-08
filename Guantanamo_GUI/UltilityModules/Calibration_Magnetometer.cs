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
    public partial class Calibration_Magnetometer : UtilityBase
    {
        public Calibration_Magnetometer(PresenterManager owner)
            :base(owner, Utility_Modules.Calibrate_Compass)
        {
            InitializeComponent();
        }

        public override void UpdateUI(string line)
        {
            txtXMax.Text = VehicleSystems.Magnetometer.Max_Readings[0].ToString("N0");
            txtYMax.Text = VehicleSystems.Magnetometer.Max_Readings[1].ToString("N0");
            txtZMax.Text = VehicleSystems.Magnetometer.Max_Readings[2].ToString("N0");
            txtXMin.Text = VehicleSystems.Magnetometer.Min_Readings[0].ToString("N0");
            txtYMin.Text = VehicleSystems.Magnetometer.Min_Readings[1].ToString("N0");
            txtZMin.Text = VehicleSystems.Magnetometer.Min_Readings[2].ToString("N0");

            txtXOff.Text = VehicleSystems.Magnetometer.Offsets_XYZ[0].ToString("N0");
            txtYOff.Text = VehicleSystems.Magnetometer.Offsets_XYZ[1].ToString("N0");
            txtZOff.Text = VehicleSystems.Magnetometer.Offsets_XYZ[2].ToString("N0");
            txtDeclination.Text = VehicleSystems.Magnetometer.DeclinationAngle.ToString();

        }

        private void btnCalAll_Click(object sender, EventArgs e)
        {
            VehicleSystems.SendCommand(GlobalVehicleCommands.VehicleCommandString(VehicleCommands_Enum.CalibrationCompass, new string[] { "0" }));
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            VehicleSystems.SendCommand("#"); //send one byte to stop
        }

        private void btnStore_Click(object sender, EventArgs e)
        {
            VehicleSystems.SendCommand(GlobalVehicleCommands.VehicleCommandString(VehicleCommands_Enum.CalibrationCompass, new string[] { "3" }));
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            VehicleSystems.SendCommand(GlobalVehicleCommands.VehicleCommandString(VehicleCommands_Enum.CalibrationCompass, new string[] { "4" }));
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            VehicleSystems.SendCommand(GlobalVehicleCommands.VehicleCommandString(VehicleCommands_Enum.ReadCalibrations, null));
        }

        private void btnReInit_Click(object sender, EventArgs e)
        {
            VehicleSystems.SendCommand(GlobalVehicleCommands.VehicleCommandString(VehicleCommands_Enum.CalibrationCompass, new string[] { "5" }));
        }
    }
}
