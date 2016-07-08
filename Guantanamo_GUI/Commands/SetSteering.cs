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
    public partial class SetSteering : BaseCommand
    {
        public SetSteering(CommandSender owner)
            :base(owner, VehicleCommands_Enum.SetSteeringAngle)
        {
            InitializeComponent();
        }

        public override void FillParams()
        {
            Params.Add(txtSteering.Text);
        }

        public override string GetCommand()
        {
            return txtQueued.Text;
        }

        private void btnThrottle_Click(object sender, EventArgs e)
        {
            txtQueued.Text = "!B(" + txtThrottle.Text + ")";
            ForceCommandSend();
        }

        private void btnSteering_Click(object sender, EventArgs e)
        {
            txtQueued.Text = "!3(" + txtSteering.Text + ")";
            ForceCommandSend();
        }
    }
}
