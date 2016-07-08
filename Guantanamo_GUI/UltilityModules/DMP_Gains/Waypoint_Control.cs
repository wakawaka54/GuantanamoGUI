using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guantanamo_GUI.UltilityModules.DMP_Gains
{
    public partial class Waypoint_Control : DMP_GainControl
    {
        int[] propertyCodes = new int[] { 0, 1, 2 };

        public Waypoint_Control()
        {
            InitializeComponent();

            Properties = new Dictionary<int, double>();
            Properties_GUI = new Dictionary<int, TextBox>();

            try
            {

                Properties_GUI.Add(propertyCodes[0], txtkP);
                Properties_GUI.Add(propertyCodes[1], txtkI);
                Properties_GUI.Add(propertyCodes[2], txtkD);

                Properties.Add(propertyCodes[0], VehicleSystems.DMP.Steering_WP_KP);
                Properties.Add(propertyCodes[1], VehicleSystems.DMP.Steering_WP_KI);
                Properties.Add(propertyCodes[2], VehicleSystems.DMP.Steering_WP_KD);
            }
            catch { }
        }

        public override void ReadProperties()
        {
            Properties[propertyCodes[0]] = VehicleSystems.DMP.Steering_WP_KP;
            Properties[propertyCodes[1]] = VehicleSystems.DMP.Steering_WP_KI;
            Properties[propertyCodes[2]] = VehicleSystems.DMP.Steering_WP_KD;
            
            base.ReadProperties();
        }
    }
}
