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
    public partial class ImageGoTo_Control : DMP_GainControl
    {
        int[] propertyCodes = new int[] { 8, 9, 10, 11 };

        public ImageGoTo_Control()
        {
            InitializeComponent();

            Properties = new Dictionary<int, double>();
            Properties_GUI = new Dictionary<int, TextBox>();

            try
            {

                Properties_GUI.Add(propertyCodes[0], txtkP);
                Properties_GUI.Add(propertyCodes[1], txtkI);
                Properties_GUI.Add(propertyCodes[2], txtkD);
                Properties_GUI.Add(propertyCodes[3], txtMaxArea);

                Properties.Add(propertyCodes[0], VehicleSystems.DMP.Steering_ImGoTo_KP);
                Properties.Add(propertyCodes[1], VehicleSystems.DMP.Steering_ImGoTo_KI);
                Properties.Add(propertyCodes[2], VehicleSystems.DMP.Steering_ImGoTo_KD);
                Properties.Add(propertyCodes[3], VehicleSystems.DMP.Steering_ImGoTo_MaxArea);
            }
            catch { }

        }

        public override void ReadProperties()
        {
            Properties[propertyCodes[0]] = VehicleSystems.DMP.Steering_ImGoTo_KP;
            Properties[propertyCodes[1]] = VehicleSystems.DMP.Steering_ImGoTo_KI;
            Properties[propertyCodes[2]] = VehicleSystems.DMP.Steering_ImGoTo_KD;
            Properties[propertyCodes[3]] = VehicleSystems.DMP.Steering_ImGoTo_MaxArea;
            
            base.ReadProperties();
        }
    }
}
