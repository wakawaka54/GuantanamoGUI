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
using Guantanamo_GUI.VehicleSensors;

namespace Guantanamo_GUI.SensorModules
{
    public partial class GPS_Module : BaseSensorModule
    {
        public bool PollingGPS = false;
        public List<string> CommandsToPoll = new List<string>();
        public List<string> SettingNames = new List<string>();

        public GPS_Module(PresenterManager owner)
            : base(owner, Sensor_Modules.GPS)
        {
            InitializeComponent();

            Designators = "G,$PMTK,$G";
        }

        public override bool CheckDesignator(string lineDesignator)
        {
            if (lineDesignator == "G") { return true; }
            if (lineDesignator.Contains("$PMTK")) { return true; }
            if (lineDesignator.Contains("$G")) { return true; }
            return false;
        }

        public override void UpdateUI(string designator)
        {
            /*if (designator.Contains("$PMTK"))
            {
                addTo_NMEA_Text(VehicleSystems.SpecialPackets.PMTK_Response.CommandLine);
                if (!PollingGPS || SettingNames.Count == 0) { return; }
                txtSettings.Text += SettingNames[0];
                SettingNames.RemoveAt(0);

                txtSettings.Text += " ";

                foreach (string param in VehicleSystems.SpecialPackets.PMTK_Response.Params)
                {
                    txtSettings.Text += param;
                    txtSettings.Text += ",";
                }

                txtSettings.Text = txtSettings.Text.Remove(txtSettings.Text.Length - 1, 1);
                txtSettings.Text += "\r\n";

                PollGPS_Settings();
            }*/

            if (txtNMEA.Text.Length != VehicleSystems.GPS.PMTK_Lines.Length)
            {
                txtNMEA.Text = VehicleSystems.GPS.PMTK_Lines;

                if (txtNMEA.Text.Length > 500) { VehicleSystems.GPS.ClearBuffers(); }
            }

            if (designator.Contains("$G"))
            {
                addTo_NMEA_Text(VehicleSystems.SpecialPackets.NMEA_Sentence);
            }

            txtHDOP.Text = (VehicleSystems.GPS.HDOP / 100).ToString();
            txtSatellites.Text = VehicleSystems.GPS.Satellites.ToString();
            txtFixage.Text = VehicleSystems.GPS.FixAge.ToString();
            txtSentences.Text = VehicleSystems.GPS.ReceivedSentences.ToString();
            txtSpeed.Text = VehicleSystems.GPS.Speed.ToString();
            txtCS.Text = VehicleSystems.GPS.FailedChecksums.ToString();
            txtCourse.Text = VehicleSystems.GPS.Heading.ToString();
            if (VehicleSystems.GPS.Coordinates.Count != 0)
            {
                txtLat.Text = VehicleSystems.GPS.Coordinates[VehicleSystems.GPS.Coordinates.Count - 1][0].ToString("N6");
                txtLong.Text = VehicleSystems.GPS.Coordinates[VehicleSystems.GPS.Coordinates.Count - 1][1].ToString("N6");
            }
        }

        public void Reset()
        {

        }

        public void PollGPS_Settings()
        {
            if (PollingGPS)
            {
                if (CommandsToPoll.Count == 0) { PollingGPS = false; return; }
                VehicleSystems.SendCommand(CommandsToPoll[0]);
                CommandsToPoll.RemoveAt(0);
            }
            else
            {
                txtSettings.Text = "";
                CommandsToPoll.Clear();
                SettingNames.Clear();
                CommandsToPoll.Add(GPS_Sensor.PMTK_Query_DGPS_Mode());
                SettingNames.Add("DGPS Mode:");
                CommandsToPoll.Add(GPS_Sensor.PMTK_Query_SBAS_Enabled());
                SettingNames.Add("SBAS Enabled:");
                CommandsToPoll.Add(GPS_Sensor.PMTK_Query_Pwr_Save_Mode());
                SettingNames.Add("Power Save Mode:");
                CommandsToPoll.Add(GPS_Sensor.PMTK_Query_NMEA_Out());
                SettingNames.Add("NMEA Output:");
                PollingGPS = true;
                PollGPS_Settings();
            }
        }

        private void btnPoll_Click(object sender, EventArgs e)
        {
            PollingGPS = false;
            PollGPS_Settings();
        }

        private void btnToggle_Click(object sender, EventArgs e)
        {
            NMEAOutput nmea = new NMEAOutput(null);
            VehicleSystems.SendCommand(nmea.GetCommand());
        }

        void addTo_NMEA_Text(string text)
        {
            if (txtNMEA.Text.Length > 5000) { txtNMEA.Text = ""; }
            txtNMEA.Text += text + "\r\n";
        }

        private void btnClearBuff_Click(object sender, EventArgs e)
        {
            VehicleSystems.GPS.ClearBuffers();
        }
    }
}
