using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guantanamo_GUI
{
    public partial class LoadingScreen : Form
    {
        public delegate void LoadingScreenUpdate_Handler(string message, int progress);

        public volatile string Message = "";
        public volatile int Progress = 0;

        public LoadingScreen()
        {
            InitializeComponent();
        }

        public void UpdateUI(string message, int progress)
        {
            if (this.InvokeRequired)
            {
                Message = message;
                Progress = progress;
                this.BeginInvoke(new LoadingScreenUpdate_Handler(UpdateUI), new object[] { message, progress });
            }
            else
            {
                try
                {
                    lbMessage.Text = Message;
                    pbProgress.Value = Progress;
                }
                catch { }
            }
        }

        public void CloseScreen()
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new MethodInvoker(CloseScreen));
                return;
            }

            this.Close();
        }
    }
}
