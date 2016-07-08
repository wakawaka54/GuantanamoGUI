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
    public partial class NMEAOutput : BaseCommand
    {
        public NMEAOutput(CommandSender owner)
            : base(owner, VehicleCommands_Enum.ToggleGPS_Output)
        {
            InitializeComponent();
        }

        public override void FillParams()
        {
            Params.Clear();
        }
    }
}
