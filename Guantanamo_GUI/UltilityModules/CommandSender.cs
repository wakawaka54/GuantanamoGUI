using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guantanamo_GUI.Commands;
using Guantanamo_GUI.VehicleSensors;
using Guantanamo_GUI.UltilityModules;

namespace Guantanamo_GUI.UltilityModules
{
    public partial class CommandSender : UtilityBase
    {
        public Dictionary<string, BaseCommand> Commands = new Dictionary<string, BaseCommand>();

        public CommandSender(PresenterManager owner)
            :base(owner, Utility_Modules.CommandSender)
        {
            InitializeComponent();

            setupCommands();
        }

        public void RequestCommandSend_Target()
        {
            sendCommand();
        }

        public override void UpdateUI(string line)
        {
            if (line.Contains("~"))
            {
                AcknowledgePacketStruct aP = VehicleSystems.SpecialPackets.AcknowledgePacket;
                lbTime.Text = aP.TimeStamp.ToString("hh:mm:ss");
                txtAcknowledgement.Text = aP.CommandNumber.ToString();
            }
        }

        //ADD NEW COMMANDS HERE
        void setupCommands()
        {
            Commands.Add("General Commands", new CommonCommands(this));
            Commands.Add("Send Waypoint", new SendWaypoint(this));
            Commands.Add("Navigate to Heading", new SteerTowardsHeading(this));
            Commands.Add("Set Steering", new SetSteering(this));
            Commands.Add("PMTK Sender", new PMTKSend(this));
            Commands.Add("Image Processing", new ImageProcessing(this));

            foreach (string command in Commands.Keys)
            {
                cbCommand.Items.Add(command);
            }

            cbCommand.SelectedIndex = 0;
        }

        void sendCommand()
        {
            string command = ((BaseCommand)gbCommandName.Controls[0]).GetCommand();
            if (command == "") { return; }
            VehicleSystems.SendCommand(command);  
        }

        private void CommandSender_Load(object sender, EventArgs e)
        {

        }

        private void cbCommand_SelectedIndexChanged(object sender, EventArgs e)
        {
            gbCommandName.Controls.Clear();
            gbCommandName.Controls.Add(Commands[cbCommand.SelectedItem.ToString()]);
            gbCommandName.Controls[0].Dock = DockStyle.Fill;
        }

        private void txtSend_Click(object sender, EventArgs e)
        {
            sendCommand();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            VehicleSystems.SendCommand("!A");
        }
    }
}
