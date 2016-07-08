using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guantanamo_GUI.VehicleSensors;

namespace Guantanamo_GUI.UltilityModules
{
    public partial class StateHistory : UtilityBase
    {
        public string[] StateNames = new string[] { "Listener Mode", "Start Up", "Next State", "Navigate To Heading",
            "Navigate To Waypoint","Go To Image Processing", "Avoid Image Processing", "Idle", "Delay", "Follow Image Processing", "Turn Image Processing",
            "Push Button", "Wait For Heading", "Align Gyro"};

        public string[] EOS_Reasons = new string[] { "Non Conditional", "Condition Reached", "Setpoint Set", "No Object",
            "Max Area", "Centroid Jump", "End Of State Table", "From GUI", "Failsafe", "Timeout" };

        public StateHistory(PresenterManager owner) : 
            base(owner, Utility_Modules.StateHistory)
        {
            InitializeComponent();

            Designator = "D";
        }

        public override void UpdateUI(string line)
        {
            string[] split = line.Split(',');

            if (!CheckDesignator(split[0])) { return; }

            if (split[1] != "H") { return; }

            updateDataGrid();
        }


        void updateDataGrid()
        {
            dgStateChanges.Rows.Clear();

            foreach (StateChange change in VehicleSystems.Diagnostics.StateChanges)
            {
                dgStateChanges.Rows.Add(new object[]{change.TimeOfChange.ToString("hh-mm-ss"),
                StateNames[change.VehicleState + 2], EOS_Reasons[change.ChangeReason]});
            }
        }

        private void txtClear_Click(object sender, EventArgs e)
        {
            dgStateChanges.Rows.Clear();
            VehicleSystems.Diagnostics.ClearBuffers();
        }

        private void StateHistory_Load(object sender, EventArgs e)
        {
            updateDataGrid();

            for (int i = 0; i != dgStateChanges.Columns.Count; i++)
            {
                dgStateChanges.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }
    }
}
