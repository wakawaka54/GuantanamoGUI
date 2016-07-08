using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guantanamo_GUI.UltilityModules;

namespace Guantanamo_GUI.Commands
{
    public partial class SendWaypoint : BaseCommand
    {
        public SendWaypoint(CommandSender owner)
            : base(owner, VehicleCommands_Enum.WaypointNavigation)
        {
            InitializeComponent();
        }

        public override void FillParams()
        {
            double param1 = 0;
            double param2 = 0;
            if (!double.TryParse(txt1.Text, out param1)) { MessageBox.Show("Cannot convert Latitude to number"); return; }
            if (!double.TryParse(txt2.Text, out param2)) { MessageBox.Show("Cannot convert Latitude to number"); return; }

            int param1_I = (int)(param1 * Math.Pow(10, 6));
            int param2_I = (int)(param2 * Math.Pow(10, 6));

            Params.Add((param1 * Math.Pow(10, 6)).ToString().Replace(",", ""));
            Params.Add((param2 * Math.Pow(10, 6)).ToString().Replace(",", ""));
        }
    }
}
