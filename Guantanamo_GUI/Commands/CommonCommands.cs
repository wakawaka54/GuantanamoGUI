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
    public partial class CommonCommands : BaseCommand
    {
        int param = -1000;

        public CommonCommands(CommandSender owner)
            : base(owner, VehicleCommands_Enum.NONE)
        {
            InitializeComponent();
        }

        void updateQueuedCommand()
        {
            txtCommand.Text = GetCommand();
        }

        public override void FillParams()
        {
            if (param != -1000) { Params.Add(param.ToString()); param = -1000;  }
        }

        private void btnGPS_Click(object sender, EventArgs e)
        {
            VehicleCommandType = VehicleCommands_Enum.ToggleGPS_Output;
            updateQueuedCommand();
        }

        private void btnNavigation_Click(object sender, EventArgs e)
        {
            VehicleCommandType = VehicleCommands_Enum.ResetVehicleState;
            ForceCommandSend();
        }

        private void btnResetEEPROM_Click(object sender, EventArgs e)
        {
            List<string> tempParams = new List<string>();

            tempParams.Clear();
            tempParams.Add("0");
            VehicleSystems.SendCommand(GlobalVehicleCommands.VehicleStateChange(tempParams.ToArray()));
        }

        private void btnHijack_Click(object sender, EventArgs e)
        {
            VehicleSystems.EndHighDataTransfer();
        }
    }
}
