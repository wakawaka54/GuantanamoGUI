using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Guantanamo_GUI.VehicleSensors;

namespace Guantanamo_GUI.SensorModules
{
    public partial class Navigation_Module : BaseSensorModule 
    {
        const double SCALE_FACTOR = 1.5;
        const int SAMPLES_CENTER_PLOT = 100;
        const float WAYPOINT_CIRCLE_SIZE = 10;
        const bool AUTO_RANGE = true;

        List<double[]> Coordinates_XY = new List<double[]>();
        List<double[]> Waypoints_XY = new List<double[]>();
        public double[] LatitudeLims = { 1, 1 };
        public double[] LongitudeLims = { 1, 1 };

        public double GPS_Drawing_Range_Width = 0.005;
        public double GPS_Drawing_Range_Height = 0.005;

        LogHandler Log;

        Bitmap DrawingSurface;

        public Navigation_Module(LogHandler log , PresenterManager owner)
            :base(owner, Sensor_Modules.Navigation)
        {
            InitializeComponent();

            Designators = "G";

            this.Shown += Navigation_Module_Shown;
            Log = log;
        }

        void Navigation_Module_Shown(object sender, EventArgs e)
        {
            scaleAspect();
            resetPlot();
        }

        public void Reset()
        {
            resetPlot();
            resetLabels();
        }

        public void Update(string line)
        {
            if (Log.WriteOpen) { Log.WriteLine(line); }
        }

        public override void UpdateUI(string designator)
        {
            if (!this.Visible || this.WindowState == FormWindowState.Minimized) { return; }
            if (Coordinates_XY.Count >= GPS_Sensor.MAX_GPS_POINTS) { resetPlot(); }

            if (!this.Visible) { return; }
            if (VehicleSystems.GPS.Coordinates.Count != Coordinates_XY.Count) { drawLine_LastXYValue(); }
            if (VehicleSystems.GPS.Waypoints.Count != Waypoints_XY.Count) { drawCircle_LastWaypoint(); }

            if (VehicleSystems.GPS.Waypoints.Count != 0 && VehicleSystems.GPS.WaypointActive)
            {
                int index = VehicleSystems.GPS.Waypoints.Count - 1;
                txtLatitude_D.Text = VehicleSystems.GPS.Waypoints[index][0].ToString("N6");
                txtLongitude_D.Text = VehicleSystems.GPS.Waypoints[index][1].ToString("N6");
                txtDistance_D.Text = VehicleSystems.GPS.Distance.ToString();
                txtHeading_D.Text = VehicleSystems.GPS.HeadingTo.ToString();
            }
            else
            {
                txtLatitude_D.Text = "";
                txtLongitude_D.Text = "";
                txtDistance_D.Text = "";
                txtHeading_D.Text = "";
            }

            if (VehicleSystems.GPS.Coordinates.Count != 0)
            {
                int index = VehicleSystems.GPS.Coordinates.Count - 1;
                txtC_Latitude.Text = VehicleSystems.GPS.Coordinates[index][0].ToString("N6");
                txtC_Longitude.Text = VehicleSystems.GPS.Coordinates[index][1].ToString("N6");
                txt_Heading_C.Text = VehicleSystems.GPS.Heading.ToString();
                lbTime.Text = VehicleSystems.GPS.Time.Hour + ":" + VehicleSystems.GPS.Time.Minutes + ":" + VehicleSystems.GPS.Time.Seconds;
            }
        }
        
        #region Drawing Methods

        void resetLabels()
        {
            txtLatitude_D.Text = "";
            txtLongitude_D.Text = "";
            txtDistance_D.Text = "";
            txtHeading_D.Text = "";
            txtC_Latitude.Text = "";
            txtC_Longitude.Text = "";
            txt_Heading_C.Text = "";
            lbTime.Text = "";
        }

        void scaleAspect()
        {
            GPS_Drawing_Range_Height = GPS_Sensor.GPS_MODULE_RANGE_MIN * Math.Pow(SCALE_FACTOR, tbZoom.Value);
            GPS_Drawing_Range_Width = GPS_Drawing_Range_Height * DrawingSurface.Height / DrawingSurface.Width;
        }

        void averageLatLong(out double avgLat, out double avgLong)
        {
            avgLat = 0; avgLong = 0;

            if (VehicleSystems.GPS.Coordinates.Count == 0) { return; }

            double[] coord;

            for (int i = 0; i != SAMPLES_CENTER_PLOT; i++)
            {
                int index = (int)CMath.Map(i, 0, 100, 0, VehicleSystems.GPS.Coordinates.Count);
                coord = VehicleSystems.GPS.Coordinates[index];
                avgLat += coord[0];
                avgLong += coord[1];
            }

            avgLat /= SAMPLES_CENTER_PLOT;
            avgLong /= SAMPLES_CENTER_PLOT;
        }

        void scaleDrawing(double lat, double lon)
        {
            setLongLatLims(lat - GPS_Drawing_Range_Width, lon - GPS_Drawing_Range_Height, lat + GPS_Drawing_Range_Width, lon + GPS_Drawing_Range_Height);
        }

        void setLongLatLims(double minLat, double minLong, double maxLat, double maxLong)
        {
            convertToXY(minLat, minLong, out LatitudeLims[0], out LongitudeLims[0]);
            convertToXY(maxLat, maxLong, out LatitudeLims[1], out LongitudeLims[1]);

            lbX.Text = "X: " + distanceBetween(minLat, minLong, minLat, maxLong).ToString("N0") + " m";
            lbY.Text = "Y: " + distanceBetween(minLat, minLong, maxLat, minLong).ToString("N0") + " m";
        }

        double distanceBetween(double lat1, double lon1, double lat2, double lon2) //in meters
        {
            double R = 6378.1; //radius of earth
            double delLat = lat2 - lat1;
            double delLon = lon2 - lon1;

            delLat *= Math.PI / 180.0;
            delLon *= Math.PI / 180.0;

            return R * Math.Sqrt(delLat * delLat + delLon * delLon)*1000;
        }

        void drawCircle_LastWaypoint()
        {
            int index = VehicleSystems.GPS.Waypoints.Count - 1;
            double x, y;
            convertToXY(VehicleSystems.GPS.Waypoints[index][0], VehicleSystems.GPS.Waypoints[index][1], out x, out y);
            Waypoints_XY.Add(new double[] { x, y });

            drawCircle(Waypoints_XY[index][0], Waypoints_XY[index][1], WAYPOINT_CIRCLE_SIZE);
        }

        void drawCircle_CurrentCoord()
        {
            int index = Coordinates_XY.Count-1;
            drawCircleUnFilled(Coordinates_XY[index][0], Coordinates_XY[index][1], WAYPOINT_CIRCLE_SIZE);
        }

        void drawLine_LastXYValue()
        {
            int index = VehicleSystems.GPS.Coordinates.Count - 1;
            double x, y;
            convertToXY(VehicleSystems.GPS.Coordinates[index][0], VehicleSystems.GPS.Coordinates[index][1], out x, out y);
            Coordinates_XY.Add(new double[] { x, y });

            if (Coordinates_XY.Count == 1)
            {
                if (AUTO_RANGE)
                {
                    scaleDrawing(Coordinates_XY[0][1], Coordinates_XY[0][0]);
                }
                return;
            }

            resetBitmap();
            redrawPlot();

            //drawLine_XY(Coordinates_XY[index][0], Coordinates_XY[index][1], Coordinates_XY[index - 1][0], Coordinates_XY[index - 1][1]);
        }

        //draw from XY
        void redrawPlot()
        {
            if (Coordinates_XY.Count <= 1) { return; }

            for (int i = 1; i != Coordinates_XY.Count; i++)
            {
                drawLine_XY(Coordinates_XY[i - 1][0], Coordinates_XY[i - 1][1], Coordinates_XY[i][0], Coordinates_XY[i][1]);
            }

            foreach (double[] point in Waypoints_XY)
            {
                drawCircle(point[0], point[1], WAYPOINT_CIRCLE_SIZE);
            }

            drawCircle_CurrentCoord();
        }

        void centerPlot()
        {
            resetBitmap();

            scaleAspect();

            double avgLat, avgLong;

            averageLatLong(out avgLat, out avgLong);
            scaleDrawing(avgLat, avgLong);

            recalculateXY();

            redrawPlot();
        }

        bool convertToXY(double latitude, double longitude, out double x, out double y)
        {
            //double R = 6371;
            // x = R * Math.Cos(latitude) * Math.Cos(longitude);
            // y = R * Math.Cos(latitude) * Math.Sin(longitude);

            x = longitude;
            y = latitude;

            return true;
        }

        void recalculateXY()
        {
            Coordinates_XY.Clear();

            foreach (double[] coord in VehicleSystems.GPS.Coordinates)
            {
                double[] newCoord = { 0, 0 };
                convertToXY(coord[0], coord[1], out newCoord[0], out newCoord[1]);

                Coordinates_XY.Add(newCoord);
            }

            Waypoints_XY.Clear();

            foreach (double[] coord in VehicleSystems.GPS.Waypoints)
            {
                double[] newCoord = { 0, 0 };
                convertToXY(coord[0], coord[1], out newCoord[0], out newCoord[1]);

                Waypoints_XY.Add(newCoord);
            }
        }

        //FULL RESET OF PLOT
        void resetPlot()
        {
            if (!this.Visible || this.WindowState == FormWindowState.Minimized) { return; }

            resetBitmap();
            
            double avgLat, avgLong;

            averageLatLong(out avgLat, out avgLong);
            scaleDrawing(avgLat, avgLong);

            recalculateXY();
            redrawPlot();
        }

        void drawCircle(double x1, double y1, double radius)
        {
            x1 = CMath.Map(x1, LatitudeLims[0], LatitudeLims[1], 0, DrawingSurface.Width);
            y1 = CMath.Map(y1, LongitudeLims[0], LongitudeLims[1], 0, DrawingSurface.Height);

            if (x1 < -2000 || x1 > 2000 || y1 < -2000 || y1 > 2000) { return; }

            using (Graphics g = Graphics.FromImage(DrawingSurface))
            {
                g.FillEllipse(Brushes.Red, new RectangleF((float)x1 - (float)radius / 2.0f, (float)y1 - (float)radius / 2.0f, (float)radius, (float)radius));
            }
        }

        void drawCircleUnFilled(double x1, double y1, double radius)
        {
            x1 = CMath.Map(x1, LatitudeLims[0], LatitudeLims[1], 0, DrawingSurface.Width);
            y1 = CMath.Map(y1, LongitudeLims[0], LongitudeLims[1], 0, DrawingSurface.Height);

            if (x1 < -2000 || x1 > 2000 || y1 < -2000 || y1 > 2000) { return; }

            Pen p = new Pen(Color.Blue, 2f);

            using (Graphics g = Graphics.FromImage(DrawingSurface))
            {
                g.DrawEllipse(p, new RectangleF((float)x1 - (float)radius / 2.0f, (float)y1 - (float)radius / 2.0f, (float)radius, (float)radius));
            }
        }

        void drawLine_XY(double x1, double y1, double x2, double y2)
        {
            //convert to latitude scale
            x1 = CMath.Map(x1, LatitudeLims[0], LatitudeLims[1], 0, DrawingSurface.Width);
            y1 = CMath.Map(y1, LongitudeLims[0], LongitudeLims[1], 0, DrawingSurface.Height);

            x2 = CMath.Map(x2, LatitudeLims[0], LatitudeLims[1], 0, DrawingSurface.Width);
            y2 = CMath.Map(y2, LongitudeLims[0], LongitudeLims[1], 0, DrawingSurface.Height);

            using (Graphics g = Graphics.FromImage(DrawingSurface))
            {
                Pen p = new Pen(Color.Black, 2f);
                g.DrawLine(p, new Point((int)x1, (int)y1), new Point((int)x2, (int)y2));

                pbDrawing.Image = DrawingSurface;
            }
        }

        void resetBitmap()
        {
            DrawingSurface = new Bitmap(pbDrawing.Width, pbDrawing.Height);

            using (Graphics g = Graphics.FromImage(DrawingSurface))
            {
                g.Clear(Color.White);
            }

            pbDrawing.Image = DrawingSurface;
        }

        #endregion

        private void btnCenter_Click(object sender, EventArgs e)
        {
            centerPlot();
        }

        private void GPS_Module_Load(object sender, EventArgs e)
        {
            resetPlot();
        }

        private void tbZoom_Scroll(object sender, EventArgs e)
        {
            scaleAspect();
            resetPlot();
        }

        private void Navigation_Module_Resize(object sender, EventArgs e)
        {
            scaleAspect();
            resetPlot();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            resetLabels();
            resetPlot();
        }

        private void btnResetGPS_Click(object sender, EventArgs e)
        {
            VehicleSystems.GPS.Reset();
            resetPlot();
            resetLabels();
        }
    }
}
