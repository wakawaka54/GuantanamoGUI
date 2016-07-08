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
    public partial class PMTKSend : BaseCommand
    {
        public static string ComputeChecksum(string dataToCalculate)
        {
            if (dataToCalculate == "") { return ""; }
            int checksum = Convert.ToByte(dataToCalculate[0]);

            for (int i = 1; i < dataToCalculate.Length; i++)
            {
                checksum ^= Convert.ToByte(dataToCalculate[i]);
            }

            return checksum.ToString("X2");
        }

        public static string ConstructPMTKSentence(string command)
        {
            return "$PMTK" + command + "*" + ComputeChecksum("PMTK" + command);
        }

        public PMTKSend(CommandSender owner)
            : base(owner, VehicleCommands_Enum.SendPMTKSentence)
        {
            InitializeComponent();
        }

        public override void FillParams()
        {
            Params.Add(txtEntireSentence.Text);
        }

        private void txtPMTK_TextChanged(object sender, EventArgs e)
        {
            txtEntireSentence.Text = ConstructPMTKSentence(txtPMTK.Text);
        }
    }
}
