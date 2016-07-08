using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guantanamo_GUI.UltilityModules;

namespace Guantanamo_GUI
{
    public partial class SerialConnect : UtilityBase
    {
        public SerialConnect(PresenterManager owner)
            :base(owner, Utility_Modules.SerialConnect)
        {
            InitializeComponent();
            cbBaud.SelectedIndex = 1;
        }

        void refreshCOMPorts()
        {
            cbCOM.Items.Clear();

            foreach (string port in VehicleSystems.SerialCommunications.GetCOMPorts())
            {
                cbCOM.Items.Add(port);
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            int.TryParse(cbBaud.Text, out VehicleSystems.SerialCommunications.BaudRate);

            if (VehicleSystems.SerialCommunications.Open(cbCOM.Text))
            {
                lbConnection.Text = "OPEN!";
                lbConnection.ForeColor = Color.Green;
            }
        }
        
        private void btnClose_Click(object sender, EventArgs e)
        {
            if (VehicleSystems.SerialCommunications.Close())
            {
                lbConnection.Text = "NOT OPEN!";
                lbConnection.ForeColor = Color.Red;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refreshCOMPorts();
        }

        private void SerialConnect_Load(object sender, EventArgs e)
        {
            refreshCOMPorts();
        }
    }
}
