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
    public partial class BaseCommand : UserControl
    {
        public delegate void RequestCommandSend_Handler();

        public event RequestCommandSend_Handler RequestCommandSend;

        public VehicleCommands_Enum VehicleCommandType = VehicleCommands_Enum.NONE;
        public List<string> Params = new List<string>();

        CommandSender _owner;

        public BaseCommand() { }

        public BaseCommand(CommandSender owner, VehicleCommands_Enum commandType)
        {
            InitializeComponent();

            _owner = owner;
            VehicleCommandType = commandType;

            if (owner == null) { return; }

            RequestCommandSend += _owner.RequestCommandSend_Target;
        }

        public void ForceCommandSend()
        {
            RequestCommandSend();
        }

        public virtual string GetCommand()
        {
            Params.Clear();
            FillParams();

            return GlobalVehicleCommands.VehicleCommandString(VehicleCommandType, Params.ToArray());
        }

        public virtual void FillParams()
        {

        }
    }
}
