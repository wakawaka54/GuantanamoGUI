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
    public partial class Calibration_Accelerometer : UtilityBase
    { 
        public Calibration_Accelerometer(PresenterManager owner)
            :base(owner, Utility_Modules.Calibrate_Accerlerometer)
        {
            InitializeComponent();
        }

        public override void UpdateUI(string line)
        {
            txtXOff.Text = VehicleSystems.Accelerometer.X_Offset.ToString();
            txtYOff.Text = VehicleSystems.Accelerometer.Y_Offset.ToString();
            txtZOff.Text = VehicleSystems.Accelerometer.Z_Offset.ToString();
        }

        private void btnCalX_Click(object sender, EventArgs e)
        {
            //VehicleSystems.SendCommand(GlobalVehicleCommands.CalibrationADX(new string[] { "0" }));
        }

        private void btnCalY_Click(object sender, EventArgs e)
        {
            //VehicleSystems.SendCommand(GlobalVehicleCommands.CalibrationADX(new string[] { "1" }));
        }

        private void btnCalZ_Click(object sender, EventArgs e)
        {
            //VehicleSystems.SendCommand(GlobalVehicleCommands.CalibrationADX(new string[] { "2" }));
        }

        private void btnStore_Click(object sender, EventArgs e)
        {
            //VehicleSystems.SendCommand(GlobalVehicleCommands.CalibrationADX(new string[] { "3" }));
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            //VehicleSystems.SendCommand(GlobalVehicleCommands.CalibrationADX(new string[] { "4" }));
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            VehicleSystems.SendCommand(GlobalVehicleCommands.ReadCalibrations());
        }
    }
}
