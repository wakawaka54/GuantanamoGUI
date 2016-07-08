using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guantanamo_GUI.SensorModules;
using System.Media;

namespace Guantanamo_GUI.SensorModules
{
    public partial class VehicleDiagnostics : BaseSensorModule 
    {
        int lastVehicleState = 0;

        public VehicleDiagnostics(PresenterManager owner)
            : base(owner, Sensor_Modules.VehicleDiagnostics)
        {
            InitializeComponent();

            Designators = "D";

            txtCalibration.HideSelection = true;
            txtMisc.HideSelection = true;
        }

        public void Reset()
        {
            txtMisc.Text = "";
            txtCalibration.Text = "";
        }

        public void Update(string line)
        {

        }

        public override void UpdateUI(string designator)
        {
            if (lastVehicleState != 5 && VehicleSystems.Diagnostics.VehicleState == 5)
            {
                using (SoundPlayer player = new SoundPlayer(@"c:\Windows\Media\Windows Ding.wav"))
                {
                    player.Play();
                }
            }

            lastVehicleState = VehicleSystems.Diagnostics.VehicleState;

            string txtCalText = "";
            string txtMiscText = "";

            for (int i = 0; i != VehicleSystems.Diagnostics.CalibrationValues.Count && i != VehicleSystems.Diagnostics.CalibrationNames.Count; i++)
            {
                txtCalText += VehicleSystems.Diagnostics.CalibrationNames[i] + " " + VehicleSystems.Diagnostics.CalibrationValues[i] + "\n";
            }

            for (int i = 0; i != VehicleSystems.Diagnostics.MiscValues.Count; i++)
            {
                txtMiscText += VehicleSystems.Diagnostics.MiscNames[i] + " " + VehicleSystems.Diagnostics.MiscValues[i] + "\n";
            }

            if (txtCalibration.Text != txtCalText) { txtCalibration.Text = txtCalText; };
            if (txtMisc.Text != txtMiscText) { txtMisc.Text = txtMiscText; }
        }
    }
}
