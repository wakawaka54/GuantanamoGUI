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
    public partial class Navigation_Utility : UtilityBase
    {
        LogHandler log;

        public Navigation_Utility(PresenterManager owner, LogHandler _log)
            :base(owner, Utility_Modules.Navigation_Utility)
        {
            InitializeComponent();
            log = _log;
            cbWaypointLoop.SelectedIndex = 0;

            _trackTimer.Interval = 1000;
            txtTracking.Text = _trackTimer.Interval.ToString();
        }

        public override void UpdateUI(string line)
        {
            /*txtNavigateEnabled.Text = VehicleSystems.Controller.NavigateEnabled.ToString();

            if (VehicleSystems.Controller.NavigateEnabled)
            {
                double[] currentWP = new double[2];
                currentWP = VehicleSystems.Controller.NavigationCoords[VehicleSystems.Controller.CurrentWaypoint];
                txtCurrentWaypoint.Text = currentWP[0].ToString("N6") + ", " + currentWP[1].ToString("N6");
            }
            else { txtCurrentWaypoint.Text = ""; }*/
        }

        void fileToTextbox(List<double[]> wps)
        {
            /*txtWaypoints.Text = "";

            foreach (double[] coords in wps)
            {
                txtWaypoints.Text += coords[0].ToString("N6") + "," + coords[1].ToString("N6") + "\n";
            }*/
        }

        bool textboxToWPS()
        {
            /*string line = "";
            List<double[]> wps = new List<double[]>();
            double[] coord = new double[2];

            for (int i = 0; i != txtWaypoints.Text.Length; i++)
            {
                if (txtWaypoints.Text[i] == '\n')
                {
                    string[] split = line.Split(',');
                    if (!double.TryParse(split[0], out coord[0])) { return false; }
                    if (!double.TryParse(split[1], out coord[1])) { return false; }
                    wps.Add(coord);
                    coord = new double[2];
                    line = "";
                }
                else
                {
                    line += txtWaypoints.Text[i];
                }
            }

            //VehicleSystems.Controller.BeginNavigation(wps);
            return true;*/

            return true;
        }

        private void cbWaypointLoop_SelectedIndexChanged(object sender, EventArgs e)
        {
           /* if (cbWaypointLoop.SelectedIndex == 0) { VehicleSystems.Controller.LoopWaypoints = true; }
            if (cbWaypointLoop.SelectedIndex == 1) { VehicleSystems.Controller.LoopWaypoints = false; }*/
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            d_openWaypoints.ShowDialog();
        }

        private void d_openWaypoints_FileOk(object sender, CancelEventArgs e)
        {
            if (!log.OpenFile_Read(d_openWaypoints.FileName)) { MessageBox.Show("Error Opening File..."); return; }
            List<double[]> waypoints = log.ReadEntireFile_Waypoints();
            fileToTextbox(waypoints);
        }

        private void btnBegin_Click(object sender, EventArgs e)
        {
            if (!textboxToWPS()) { MessageBox.Show("Error converting text box to waypoints..."); return; }
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            //VehicleSystems.Controller.EndNavigation();
        }

        private void _trackTimer_Tick(object sender, EventArgs e)
        {
            int lastCoordinate = VehicleSystems.GPS.Coordinates.Count - 1;
            string currentCoords = VehicleSystems.GPS.Coordinates[lastCoordinate][0].ToString("N6") + "," + VehicleSystems.GPS.Coordinates[lastCoordinate][1];
            txtWaypoints.Text += currentCoords + "\n";
        }

        private void btnTrack_Click(object sender, EventArgs e)
        {
            int interval = 0;
            if (!int.TryParse(txtTracking.Text, out interval)) { MessageBox.Show("Error converting tracking interval..."); return; }
            _trackTimer.Interval = interval;
            lbStatus.Text = "ON"; lbStatus.ForeColor = Color.Green;
            _trackTimer.Start();
        }

        private void btnEndTrack_Click(object sender, EventArgs e)
        {
            lbStatus.Text = "OFF"; lbStatus.ForeColor = Color.Black;
            _trackTimer.Stop();
        }
    }
}
