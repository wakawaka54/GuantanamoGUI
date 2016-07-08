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
    public partial class ImageProcessing : BaseCommand
    {
        const short CHANGE_VARIABLE_COMMAND = 21;
        readonly short[] CHANGE_VARIABLE_NUMBERS = new short[] { 25, 26, 27, 28, 29, 30,
            31, 32, 33, 34, 35, 36, 37, 38, 42,43,47};

        int param = 0;

        public ImageProcessing(CommandSender owner)
            : base(owner, VehicleCommands_Enum.ImageProcessing)
        {
            InitializeComponent();
        }

        public override void FillParams()
        {
            if (param == CHANGE_VARIABLE_COMMAND)
            {
                short test = 0;
                if (!short.TryParse(txtVal.Text, out test)) { return; }

                Params.Add(param.ToString());
                Params.Add(CHANGE_VARIABLE_NUMBERS[cbVariableID.SelectedIndex].ToString());
                Params.Add(txtVal.Text);
                return;
            }

            if (param == 18) { VehicleSystems.PrepareHighDataTransfer(); }
            
            Params.Add(param.ToString());
        }

        private void btnAvoidRed_Click(object sender, EventArgs e)
        {
            param = 2;

            ForceCommandSend();
        }

        private void btnAvoidGreen_Click(object sender, EventArgs e)
        {
            param = 4;

            ForceCommandSend();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            param = 0;

            ForceCommandSend();
        }

        private void btnAvoidBlue_Click(object sender, EventArgs e)
        {
            param = 3;
            ForceCommandSend();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            param = 1;
            ForceCommandSend();
        }

        private void btnTerminate_Click(object sender, EventArgs e)
        {
            param = 5;
            ForceCommandSend();
        }

        private void btnGoRed_Click(object sender, EventArgs e)
        {
            param = 6;
            ForceCommandSend();
        }

        private void btnGoGreen_Click(object sender, EventArgs e)
        {
            param = 8;
            ForceCommandSend();
        }

        private void btnGoBlue_Click(object sender, EventArgs e)
        {
            param = 7;
            ForceCommandSend();
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            param = 9;
            ForceCommandSend();
        }

        private void btnStream_Click(object sender, EventArgs e)
        {
            param = 10;
            ForceCommandSend();
        }

        private void btnAvoidYellow_Click(object sender, EventArgs e)
        {
            param = 11;
            ForceCommandSend();
        }

        private void btnGotoYellow_Click(object sender, EventArgs e)
        {
            param = 12;
            ForceCommandSend();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            param = cbCommands.SelectedIndex;
            ForceCommandSend();
        }

        private void cbCommands_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            param = CHANGE_VARIABLE_COMMAND;
            ForceCommandSend();
        }
    }
}
