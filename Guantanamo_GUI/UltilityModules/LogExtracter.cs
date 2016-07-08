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
using System.IO;

namespace Guantanamo_GUI
{
    public partial class LogExtracter : UtilityBase
    {
        public LogExtracter(PresenterManager owner)
            :base(owner, Utility_Modules.LogExtracter)
        {
            InitializeComponent();
        }
    }
}
