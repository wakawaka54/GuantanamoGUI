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
    public partial class ImageAvoid_Control : DMP_GainControl
    {
        int[] propertyCodes = new int[] { 3, 4, 5, 6, 7, 20 };

        public ImageAvoid_Control()
        {
            InitializeComponent();

            Properties = new Dictionary<int, double>();
            Properties_GUI = new Dictionary<int, TextBox>();

            try
            {

                Properties_GUI.Add(propertyCodes[0], txtkP);
                Properties_GUI.Add(propertyCodes[1], txtkI);
                Properties_GUI.Add(propertyCodes[2], txtkD);
                Properties_GUI.Add(propertyCodes[3], txtMinArea);
                Properties_GUI.Add(propertyCodes[4], txtMaxArea);
                Properties_GUI.Add(propertyCodes[5], txtJump);


                Properties.Add(propertyCodes[0], VehicleSystems.DMP.Steering_WP_KP);
                Properties.Add(propertyCodes[1], VehicleSystems.DMP.Steering_WP_KI);
                Properties.Add(propertyCodes[2], VehicleSystems.DMP.Steering_WP_KD);
                Properties.Add(propertyCodes[3], VehicleSystems.DMP.Steering_ImAvoid_MinArea);
                Properties.Add(propertyCodes[4], VehicleSystems.DMP.Steering_ImAvoid_MaxArea);
                Properties.Add(propertyCodes[5], VehicleSystems.DMP.Steering_ImAvoid_CentroidJump);
            }
            catch { }
        }

        public override void ReadProperties()
        {
            Properties[propertyCodes[0]] = VehicleSystems.DMP.Steering_WP_KP;
            Properties[propertyCodes[1]] = VehicleSystems.DMP.Steering_WP_KI;
            Properties[propertyCodes[2]] = VehicleSystems.DMP.Steering_WP_KD;
            Properties[propertyCodes[3]] = VehicleSystems.DMP.Steering_ImAvoid_MinArea;
            Properties[propertyCodes[4]] = VehicleSystems.DMP.Steering_ImAvoid_MaxArea;
            Properties[propertyCodes[5]] = VehicleSystems.DMP.Steering_ImAvoid_CentroidJump;

            base.ReadProperties();
        }

        private void ImageAvoid_Control_Load(object sender, EventArgs e)
        {

        }
    }
}
