using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guantanamo_GUI.SensorModules
{
    public partial class Ultrasonic_Module : BaseSensorModule 
    {
        public Ultrasonic_Module(PresenterManager owner)
            : base(owner, Sensor_Modules.Ultrasonic)
        {
            InitializeComponent();

            Designators = "U";
        }

        public void Reset()
        {
            txtDistance.Text = "";
        }

        public override void UpdateUI(string designator)
        {
            txtDistance.Text = VehicleSystems.Ultrasonic.Distance.ToString();
        }
    }
}
