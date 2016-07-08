using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guantanamo_GUI.SensorModules;

namespace Guantanamo_GUI.SensorModules
{
    public partial class SerialMonitor : BaseSensorModule 
    {
        public delegate void WriteInvoked(string line);

        public WriteInvoked WriteInvokeDelegate;

        StringBuilder monitorInput = new StringBuilder(10000);
        int linesBuffered = 0;

        public SerialMonitor(PresenterManager owner)
            : base(owner, Sensor_Modules.SerialMonitor)
        {
            InitializeComponent();
            Designators = "";
            monitorInput.Capacity = 10000;

            VehicleSystems.CommandSent += Write;

            this.FormClosed += SerialMonitor_FormClosed;

            WriteInvokeDelegate = new WriteInvoked(Write);
        }

        void SerialMonitor_FormClosed(object sender, FormClosedEventArgs e)
        {
            VehicleSystems.CommandSent -= Write;
        }

        public override bool CheckDesignator(string lineDesignator)
        {
            return true;
        }

        public override void ResetUI()
        {
            txtSerial.Text = "";
        }

        public void Write(string line)
        {
            if (InvokeRequired)
            {
                this.BeginInvoke(WriteInvokeDelegate, line);
                return;
            }

            if (!this.Visible) { return; }

            if (txtSent.Text.Length > 10000) { txtSent.Text = ""; }

            txtSent.Text += line;
            txtSent.Text += "\n";
            txtSent.SelectionStart = txtSent.Text.Length;
            txtSent.ScrollToCaret();
        }

        public override void UpdateUI(string line)
        {
            if (!this.Visible || !VehicleSystems.UpdateUI) { return; }

            if (txtSerial.Text.Length > 3000)
            {
                txtSerial.Text = "";
            }

            if (monitorInput.Length > 3000) { monitorInput.Clear(); }

            monitorInput.Append(line + "\n");

            if (linesBuffered > 10)
            {
                txtSerial.Text = monitorInput.ToString();
                txtSerial.SelectionStart = txtSerial.Text.Length;
                txtSerial.ScrollToCaret();
                linesBuffered = 0;
            }

            linesBuffered++;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            VehicleSystems.SendCommand(txtSend.Text);
        }
    }
}
