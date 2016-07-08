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

namespace Guantanamo_GUI.SensorModules
{
    public partial class BaseSensorModule : Form
    {
        public string Designators = "";
        public Sensor_Modules ModuleType { get; set; }

        protected PresenterManager _owner;

        public static BaseSensorModule GetSensorModule_OfType(Sensor_Modules moduleType, PresenterManager owner)
        {
            switch (moduleType)
            {
                case Sensor_Modules.Accerlerometer:
                    return new Accelerometer_Module(owner);

                case Sensor_Modules.GPS:
                    return new GPS_Module(owner);

                case Sensor_Modules.Gyroscope:
                    return new Gyroscope_Module(owner);

                case Sensor_Modules.ImageProcessing:
                    return new ImageProcessing_Module(owner);

                case Sensor_Modules.Magnetometer:
                    return new Magnetometer_Module(owner);

                case Sensor_Modules.Navigation:
                    return new Navigation_Module(owner.LogHandler, owner);

                case Sensor_Modules.Probe:
                    return new Probe_Module(owner);

                case Sensor_Modules.Ultrasonic:
                    return new Ultrasonic_Module(owner);

                case Sensor_Modules.VehicleDiagnostics:
                    return new VehicleDiagnostics(owner);
                    
                case Sensor_Modules.VehicleState:
                    return new VehicleState(owner);

                case Sensor_Modules.SerialMonitor:
                    return new SerialMonitor(owner);
            }

            return null;
        }

        public BaseSensorModule() { }

        public BaseSensorModule(PresenterManager owner, Sensor_Modules moduleType)
        {
            InitializeComponent();

            ModuleType = moduleType;

            _owner = owner;

            _owner.AddSensorModuleUpdate(this);

            FormClosing += BaseSensorModule_FormClosing;
        }

        void BaseSensorModule_FormClosing(object sender, FormClosingEventArgs e)
        {
            _owner.RemoveSensorModuleUpdate(this);
        }

        public virtual bool CheckDesignator(string lineDesignator)
        {
            string[] desis = Designators.Split(',');

            foreach (string desi in desis)
            {
                if (desi == lineDesignator) { return true; }
            }
            return false;
        }

        public virtual void ResetUI()
        {

        }

        public virtual void UpdateUI(string designator)
        {

        }
    }
}
