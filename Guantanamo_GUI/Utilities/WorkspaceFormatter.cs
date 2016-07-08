using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Guantanamo_GUI.UltilityModules;
using Guantanamo_GUI.SensorModules;
using System.Windows.Forms;
using System.Drawing;

namespace Guantanamo_GUI
{
    class WorkspaceFormatter
    {
        public static void HomeScreen(PresenterManager manager)
        {
            
        }

        public static void DefaultWorkspace(PresenterManager manager, Size ownerSize)
        {
            LoadingScreen_Handler loading = new LoadingScreen_Handler();
            loading.ShowLoading();

            loading.UpdateProgress("Setting up workspace...", 0);
            SerialConnect SerialConnect = (SerialConnect)manager.ReInit_Utility(Utility_Modules.SerialConnect);

            Navigation_Module NavMod = (Navigation_Module)manager.ReInit_Sensor(Sensor_Modules.Navigation);
            Magnetometer_Module Magnetometer = (Magnetometer_Module)manager.ReInit_Sensor(Sensor_Modules.Magnetometer);
            SerialMonitor Monitor = (SerialMonitor)manager.ReInit_Sensor(Sensor_Modules.SerialMonitor);
            VehicleState VehicleState = (VehicleState)manager.ReInit_Sensor(Sensor_Modules.VehicleState);
            CommandSender CommandSend = (CommandSender)manager.ReInit_Utility(Utility_Modules.CommandSender);
            VehicleDiagnostics Diagnostics = (VehicleDiagnostics)manager.ReInit_Sensor(Sensor_Modules.VehicleDiagnostics);
            GPS_Module GPS = (GPS_Module)manager.ReInit_Sensor(Sensor_Modules.GPS);
            Gyroscope_Module Gyroscope = (Gyroscope_Module)manager.ReInit_Sensor(Sensor_Modules.Gyroscope);


            SerialConnect.StartPosition = FormStartPosition.Manual;
            NavMod.StartPosition = FormStartPosition.Manual;
            Magnetometer.StartPosition = FormStartPosition.Manual;
            Monitor.StartPosition = FormStartPosition.Manual;
            VehicleState.StartPosition = FormStartPosition.Manual;
            CommandSend.StartPosition = FormStartPosition.Manual;
            Diagnostics.StartPosition = FormStartPosition.Manual;
            GPS.StartPosition = FormStartPosition.Manual;
            Gyroscope.StartPosition = FormStartPosition.Manual;

            SerialConnect.Location = new Point(0, 0);
            CommandSend.Location = new Point(0, SerialConnect.Size.Height);
            NavMod.Location = new Point(SerialConnect.Size.Width, 0);
            Gyroscope.Location = new Point(NavMod.Location.X + NavMod.Size.Width, 60);
            Magnetometer.Location = new Point(NavMod.Location.X + NavMod.Size.Width, 90);
            GPS.Location = new Point(NavMod.Location.X + NavMod.Size.Width, 30);
            VehicleState.Location = new Point(NavMod.Location.X + NavMod.Size.Width, 0);
            Monitor.Location = new Point(NavMod.Location.X, NavMod.Location.Y + NavMod.Size.Height);
            Monitor.Size = new Size(NavMod.Size.Width, 200);
            Diagnostics.Location = new Point(Magnetometer.Location.X, Magnetometer.Location.Y + Magnetometer.Size.Height);

            VehicleState.Size = Magnetometer.Size;
            GPS.Size = Magnetometer.Size;
            Diagnostics.Size = new System.Drawing.Size(Magnetometer.Size.Width, ownerSize.Height - Magnetometer.Location.Y - Magnetometer.Size.Height - 80);

            loading.UpdateProgress("Setting up workspace...", 50);

            NavMod.Show();
            SerialConnect.Show();
            VehicleState.Show();
            GPS.Show();
            Gyroscope.Show();
            Magnetometer.Show();
            Monitor.Show();
            CommandSend.Show();
            Diagnostics.Show();

            loading.UpdateProgress("Setting up workspace...", 100);

            loading.CloseScreen();
        }
    }
}
