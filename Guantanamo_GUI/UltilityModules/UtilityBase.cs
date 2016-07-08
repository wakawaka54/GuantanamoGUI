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
    public partial class UtilityBase : Form
    {
        public string Designator = "";
        public Utility_Modules ModuleType { get; set; }

        PresenterManager _owner;

        protected Timer updateTimer = new Timer();

        protected bool updateFlag = false;

        public static UtilityBase GetUtility_OfType(Utility_Modules module, PresenterManager owner)
        {
            switch (module)
            {
                case Utility_Modules.CommandSender:
                    return new CommandSender(owner);

                case Utility_Modules.LogExtracter:
                    return new LogExtracter(owner);

                case Utility_Modules.Navigation_Utility:
                    return new Navigation_Utility(owner, owner.LogHandler);

                case Utility_Modules.SerialConnect:
                    return new SerialConnect(owner);

                case Utility_Modules.SerialHealth:
                    return new SerialHealth(owner);

                case Utility_Modules.Calibrate_Accerlerometer:
                    return new Calibration_Accelerometer(owner);

                case Utility_Modules.Calibrate_Gyro:
                    return new Calibration_Gyroscope(owner);

                case Utility_Modules.Calibrate_Compass:
                    return new Calibration_Magnetometer(owner);

                case Utility_Modules.Calibrate_DMP:
                    return new Calibration_DMP(owner);

                case Utility_Modules.StateEditor:
                    return new StateEditor(owner);

                case Utility_Modules.DataVisualizer_MagGyroVehicle:
                    return new DataVisualizer_Utility(owner, DataVisualization_Controls.Heading_MagGyroVehicle);

                case Utility_Modules.DataVisualizer_WPHeadingSteering:
                    return new DataVisualizer_Utility(owner, DataVisualization_Controls.Heading_PID);

                case Utility_Modules.DataVisualizer_ImageArea:
                    return new DataVisualizer_Utility(owner, DataVisualization_Controls.ImageArea);

                case Utility_Modules.DataVisualizer_ImageCentroid:
                    return new DataVisualizer_Utility(owner, DataVisualization_Controls.ImageCentroid);

                case Utility_Modules.DataVisualizer_MagXYZNorm:
                    return new DataVisualizer_Utility(owner, DataVisualization_Controls.MagXYZ_Norm);
                    
                case Utility_Modules.DataVisualizer_VehicleInformation:
                    return new DataVisualizer_Utility(owner, DataVisualization_Controls.VehicleInformation);

                case Utility_Modules.LogUtility:
                    return new LogUtility(owner);

                case Utility_Modules.StateHistory:
                    return new StateHistory(owner);
            }

            return null;
        }

        public UtilityBase() { }

        public UtilityBase(PresenterManager owner, Utility_Modules moduleType)
        {
            InitializeComponent();

            ModuleType = moduleType;

            _owner = owner;

            _owner.AddUtilityUpdate(this);

            FormClosing += UtilityBase_FormClosing;

            updateTimer.Interval = 250;
            updateTimer.Tick += updateTimer_Tick;
            updateTimer.Start();
        }

        void updateTimer_Tick(object sender, EventArgs e)
        {
            updateFlag = true;
        }

        public virtual bool CheckUpdate(string designator)
        {
            if (Designator != "") {
                return CheckDesignator(designator); }

            if (updateFlag) {
                updateFlag = false; return true; }

            return false;
        }

        public virtual bool CheckDesignator(string designator)
        {
            if (designator == Designator)
            {
                return true;
            }

            return false;
        }

        public virtual void UpdateUI(string line)
        {

        }

        void UtilityBase_FormClosing(object sender, FormClosingEventArgs e)
        {
            updateTimer.Stop();
            _owner.RemoveUtilityUpdate(this);
        }
    }
}
