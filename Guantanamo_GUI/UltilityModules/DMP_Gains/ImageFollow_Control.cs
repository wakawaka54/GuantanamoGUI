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
    public partial class ImageFollow_Control : DMP_GainControl
    {
        int[] propertyCodes = new int[] { 12, 13, 14, 15, 16, 17, 18, 19 };

        public ImageFollow_Control()
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
                Properties_GUI.Add(propertyCodes[4], txtMinArea);
                Properties_GUI.Add(propertyCodes[5], txtRgtTrg);
                Properties_GUI.Add(propertyCodes[6], txtLftTrg);
                Properties_GUI.Add(propertyCodes[7], txtJump);

                Properties.Add(propertyCodes[0], VehicleSystems.DMP.Steering_ImFollow_KP);
                Properties.Add(propertyCodes[1], VehicleSystems.DMP.Steering_ImFollow_KI);
                Properties.Add(propertyCodes[2], VehicleSystems.DMP.Steering_ImFollow_KD);
                Properties.Add(propertyCodes[3], VehicleSystems.DMP.Steering_ImFollow_MaxArea);
                Properties.Add(propertyCodes[4], VehicleSystems.DMP.Steering_ImFollow_MinArea);
                Properties.Add(propertyCodes[5], VehicleSystems.DMP.Steering_ImFollow_LeftTarget);
                Properties.Add(propertyCodes[6], VehicleSystems.DMP.Steering_ImFollow_RightTarget);
                Properties.Add(propertyCodes[7], VehicleSystems.DMP.Steering_ImFollow_CentroidJump);


            }
            catch { }
        }

        public override void ReadProperties()
        {
            Properties[propertyCodes[0]] = VehicleSystems.DMP.Steering_ImFollow_KP;
            Properties[propertyCodes[1]] = VehicleSystems.DMP.Steering_ImFollow_KI;
            Properties[propertyCodes[2]] = VehicleSystems.DMP.Steering_ImFollow_KD;
            Properties[propertyCodes[3]] = VehicleSystems.DMP.Steering_ImFollow_MaxArea;
            Properties[propertyCodes[4]] = VehicleSystems.DMP.Steering_ImFollow_MinArea;
            Properties[propertyCodes[5]] = VehicleSystems.DMP.Steering_ImFollow_LeftTarget;
            Properties[propertyCodes[6]] = VehicleSystems.DMP.Steering_ImFollow_RightTarget;
            Properties[propertyCodes[7]] = VehicleSystems.DMP.Steering_ImFollow_CentroidJump;

            base.ReadProperties();
        }
    }
}
