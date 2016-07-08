using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guantanamo_GUI.Utilities
{
    public partial class HomeScreen : Form
    {
        MDI_Parent owner;

        public HomeScreen(MDI_Parent _owner)
        {
            owner = _owner;
            InitializeComponent();

            MdiParent = _owner;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(_owner.Size.Width / 2 - this.Size.Width / 2, _owner.Size.Height / 2 - 300);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            owner.Workspace_Default();
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
