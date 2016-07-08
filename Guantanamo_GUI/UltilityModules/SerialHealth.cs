using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guantanamo_GUI.UltilityModules
{
    public partial class SerialHealth : UtilityBase
    {
        public SerialHealth(PresenterManager owner)
            :base(owner, Utility_Modules.SerialHealth)
        {
            InitializeComponent();
            VehicleSystems.SerialCommunications.SerialRead_Error += SerialErrorPost;
        }

        public override void UpdateUI(string line)
        {
            txtAvgTime.Text = VehicleSystems.SerialCommunications.AvgTime_Per_Read.ToString();
            txtUpdates.Text = VehicleSystems.SerialCommunications.Updates_Per_Second.ToString();
            txtBytes.Text = VehicleSystems.SerialCommunications.BytesToRead.ToString();
            txtErrors.Text = VehicleSystems.SerialCommunications.ErrorsCaught.ToString();
            txtBytesMax.Text = VehicleSystems.SerialCommunications.Max_BytesToRead.ToString();
            txtTransfer.Text = ((double)VehicleSystems.SerialCommunications.Bytes_Per_Second / 1000).ToString("N3");
            txtAttempts.Text = VehicleSystems.SerialCommunications.NumberTries_Write.ToString();
            txtBytesDump.Text = VehicleSystems.SerialCommunications.Bytes_Dumped.ToString();
        }

        public void SerialErrorPost(Exception e)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new SerialRead_ErrorHandler(SerialErrorPost), e);
                return;
            }

            if (txtErrorMessages.Text.Length > 5000) { txtErrorMessages.Text = ""; }

            txtErrorMessages.Text += e.Message + " | " + e.Source + "\n";
        }

        private void SerialHealth_FormClosing(object sender, FormClosingEventArgs e)
        {
            VehicleSystems.SerialCommunications.SerialRead_Error -= SerialErrorPost;
        }
    }
}
