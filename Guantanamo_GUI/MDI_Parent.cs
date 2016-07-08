using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guantanamo_GUI.UltilityModules;
using Guantanamo_GUI.SensorModules;
using Guantanamo_GUI.Utilities;
using Guantanamo_GUI.Commands;
using System.IO;

namespace Guantanamo_GUI
{
    public partial class MDI_Parent : Form
    {
        public const double INIT_PROGRESS_COUNT = 4;

        PresenterManager ModuleManager;

        public MDI_Parent()
        {
            InitializeComponent();
        }

        public void UpdateUI(string line)
        {

        }

        public void Workspace_Default()
        {
            WorkspaceFormatter.DefaultWorkspace(ModuleManager, this.Size);
        }

        void main_Init()
        {
            double i = 0;

            SplashScreen_Handler splashScreen = new SplashScreen_Handler();
            splashScreen.ShowSplash();

            splashScreen.UpdateProgress("Setting up Vehicle Systems...", (int)(i++ / INIT_PROGRESS_COUNT * INIT_PROGRESS_COUNT));
            VehicleSystems.Setup(ModuleManager);

            ModuleManager = new PresenterManager(this);

            splashScreen.UpdateProgress("Opening home screen....", (int)(i++ / INIT_PROGRESS_COUNT * INIT_PROGRESS_COUNT));
            HomeScreen home = new HomeScreen(this);
            home.Show();

            splashScreen.UpdateProgress("Brushing up final details...", (int)(i++ / INIT_PROGRESS_COUNT * INIT_PROGRESS_COUNT));

            splashScreen.CloseSplash();
        }

        private void gPSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModuleManager.ShowWindow_Sensor(Sensor_Modules.Navigation);
        }

        private void d_OpenLog_FileOk(object sender, CancelEventArgs e)
        {
            VehicleSystems.Reset();
            ModuleManager.ResetUI();
            ModuleManager.LogHandler.OpenFile_Read(d_OpenLog.FileName);
            ModuleManager.LogHandler.ReadEntireFile_Simulate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            main_Init();
        }

        private void MDI_Parent_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void d_OpenWaypoints_FileOk(object sender, CancelEventArgs e)
        {
            ModuleManager.LogHandler.OpenFile_Read(d_OpenWaypoints.FileName);
            //VehicleSystems.Controller.BeginNavigation(ModuleManager.LogHandler.ReadEntireFile_Waypoints());
        }

        private void openWaypointsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            d_OpenWaypoints.ShowDialog();
        }

        private void accelerometerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModuleManager.ShowWindow_Sensor(Sensor_Modules.Accerlerometer);
        }

        private void commandSenderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModuleManager.ShowWindow_Utility(Utility_Modules.CommandSender);
        }

        private void resetWorkspaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WorkspaceFormatter.DefaultWorkspace(ModuleManager, this.Size);
        }

        private void resetSensorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VehicleSystems.Reset();
        }

        private void magnetometerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModuleManager.ShowWindow_Sensor(Sensor_Modules.Magnetometer);
        }

        private void serialMonitorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModuleManager.ShowWindow_Sensor(Sensor_Modules.SerialMonitor);
        }

        private void serialConnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModuleManager.ShowWindow_Utility(Utility_Modules.SerialConnect);
        }

        private void openLogToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            d_OpenLog.ShowDialog();
        }

        private void splitLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            d_SplitLog.ShowDialog();
        }

        private void d_SplitLog_FileOk(object sender, CancelEventArgs e)
        {
            ModuleManager.LogHandler.SplitLog(d_SplitLog.FileName);
        }

        private void extractLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModuleManager.ShowWindow_Utility(Utility_Modules.LogExtracter);
        }

        private void resetUIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModuleManager.ResetUI();
        }

        private void probeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModuleManager.ShowWindow_Sensor(Sensor_Modules.Probe);
        }

        private void ultrasonicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModuleManager.ShowWindow_Sensor(Sensor_Modules.Ultrasonic);
        }

        private void serialHealthToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModuleManager.ShowWindow_Utility(Utility_Modules.SerialHealth);
        }

        private void imageProcessingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModuleManager.ShowWindow_Sensor(Sensor_Modules.ImageProcessing);
        }

        private void navigationUtilityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModuleManager.ShowWindow_Utility(Utility_Modules.Navigation_Utility);
        }

        private void accelerometerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ModuleManager.ShowWindow_Utility(Utility_Modules.Calibrate_Accerlerometer);
        }

        private void gyroscopeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModuleManager.ShowWindow_Utility(Utility_Modules.Calibrate_Gyro);
        }

        private void magnetometerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ModuleManager.ShowWindow_Utility(Utility_Modules.Calibrate_Compass);
        }

        private void dMPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModuleManager.ShowWindow_Utility(Utility_Modules.Calibrate_DMP);
        }

        private void windowToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void stateTableEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModuleManager.ShowWindow_Utility(Utility_Modules.StateEditor);
        }

        private void magGyroVehicleHeadingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModuleManager.ShowWindow_Utility(Utility_Modules.DataVisualizer_MagGyroVehicle);
        }

        private void wPHeadingSteeringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModuleManager.ShowWindow_Utility(Utility_Modules.DataVisualizer_WPHeadingSteering);
        }

        private void blobAreaCentroidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModuleManager.ShowWindow_Utility(Utility_Modules.DataVisualizer_ImageArea);
        }

        private void imageCentroidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModuleManager.ShowWindow_Utility(Utility_Modules.DataVisualizer_ImageCentroid);
        }

        private void logUtilityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModuleManager.ShowWindow_Utility(Utility_Modules.LogUtility);
        }

        private void diagnosticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModuleManager.ShowWindow_Sensor(Sensor_Modules.VehicleDiagnostics);
        }

        private void stateHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModuleManager.ShowWindow_Utility(Utility_Modules.StateHistory);
        }

        private void magnetometerXYZNormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModuleManager.ShowWindow_Utility(Utility_Modules.DataVisualizer_MagXYZNorm);
        }

        private void vehicleControlInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModuleManager.ShowWindow_Utility(Utility_Modules.DataVisualizer_VehicleInformation);
        }

        private void cameraSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            d_OpenCameraSettings.ShowDialog();
        }

        private void d_OpenCameraSettings_FileOk(object sender, CancelEventArgs e)
        {
            try
            {
                StreamReader reader = new StreamReader(d_OpenCameraSettings.FileName);

                string line = reader.ReadLine();

                while (line != null)
                {
                    string[] split = line.Split(',');

                    if (split.Length == 2)
                    {
                        VehicleSystems.SendCommand(GlobalVehicleCommands.ImageProcessingCommand(split));
                    }
                }
            }
            catch { }
        }
    }
}
