using System;
using System.Collections.Generic;
using System.Threading;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guantanamo_GUI.Commands;
using Guantanamo_GUI.UltilityModules.DMP_Gains;

namespace Guantanamo_GUI.UltilityModules
{
    public partial class Calibration_DMP :  UtilityBase
    {
        bool requestUpdateGains = false;
        short counter = 0;

        public Calibration_DMP(PresenterManager owner)
            :base(owner, Utility_Modules.Calibrate_DMP)
        {
            InitializeComponent();

            updateTimer.Interval = 1000; //update every second
        }

        public override void UpdateUI(string line)
        {
            if (counter++ >= 10)
            {
                txtYaw.Text = VehicleSystems.Magnetometer.VehicleHeading.ToString("N2");
                counter = 0;
            }

            setPID_GainsTxt(line);

            if (requestUpdateGains)
            {
                requestUpdateGains = false;
                setGainsTxt();
            }

            updateFlag = true;
        }

        void readHeadingGains()
        {
            VehicleSystems.SendCommand(GlobalVehicleCommands.VehicleCommandString(VehicleCommands_Enum.ReadDMP_Gains, null));
            requestUpdateGains = true;
        }

        void setGainsTxt()
        {
            txtGyroAngular.Text = VehicleSystems.DMP.Heading_AngChange_Gyro.ToString("N5");
            txtMagAngularGain.Text = VehicleSystems.DMP.Heading_AngChange_Mag.ToString("N5");
            txtHeadingComp.Text = VehicleSystems.DMP.Heading_Error_Mag.ToString("N5");
        }

        private void btnReadHeadingGains_Click(object sender, EventArgs e)
        {
            readHeadingGains();
        }

        private void Filter_Configuration_Load(object sender, EventArgs e)
        {
            readHeadingGains();
        }

        void setPID_GainsTxt(string line)
        {
            string[] split = line.Split(',');

            if (split[0] != "Y" || split[1] != "P") { return; }

            foreach (TabPage tb in tc_PIDTabs.TabPages)
            {
                try
                {
                    DMP_GainControl gainControl = tb.Controls[0] as DMP_GainControl;

                    gainControl.UpdateProperty(split);
                }
                catch { }
            }
        }

        private void btnSetHeadingGains_Click(object sender, EventArgs e)
        {
            double gyroAngular = 0;
            double magAngular = 0;
            double magError = 0;

            if(!double.TryParse(txtGyroAngular.Text, out gyroAngular)) { return; }
            if(!double.TryParse(txtHeadingComp.Text, out magError)) { return; }
            if(!double.TryParse(txtMagAngularGain.Text, out magAngular)) { return; }


            VehicleSystems.SendCommand(GlobalVehicleCommands.VehicleCommandString(VehicleCommands_Enum.SetDMP_HeadingGains,
                new string[] {gyroAngular.ToString("N5"), magAngular.ToString("N5"), magError.ToString("N5")}));
        }

        private void btnReadPID_Click(object sender, EventArgs e)
        {
             VehicleSystems.SendCommand(GlobalVehicleCommands.ReadDMP_PIDGains());
        }

        private void tc_PIDTabs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSetPID_Click(object sender, EventArgs e)
        {
            DMP_GainControl selected = tc_PIDTabs.SelectedTab.Controls[0] as DMP_GainControl;

            if (selected == null) { return; }

            Dictionary<int, double> values = selected.GetProperties();

            foreach(int key in values.Keys)
            {
                VehicleSystems.SendCommand(GlobalVehicleCommands.SetDMP_PIDGains(new string[] { key.ToString(), values[key].ToString("N6").Replace(",","") }));
                Thread.Sleep(50);
            }
        }
    }
}
