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
    public partial class SteerTowardsHeading : BaseCommand
    {
        public SteerTowardsHeading(CommandSender owner)
            : base(owner, VehicleCommands_Enum.NavigateTowardsHeading)
        {
            InitializeComponent();
        }

        public override void FillParams()
        {
            Params.Add(txtAngle.Text);
        }
    }
}
