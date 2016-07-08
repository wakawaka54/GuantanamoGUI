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
    public partial class SplashScreen : Form
    {
        public const double Max_Width = 100;

        public string Message = "";
        public int Progress = 0;

        public int Width_Init;
        public int X_Init;

        public SplashScreen()
        {
            InitializeComponent();

            pbBackground.Location = new Point(pbBackground.Location.X + 1, pbBackground.Location.Y);
            pbBackground.Size = new System.Drawing.Size(pbBackground.Size.Width - 2, pbBackground.Size.Height);

            Width_Init = pbCover.Width;
            X_Init = pbCover.Location.X;
            pbBackground.BackColor = Color.DodgerBlue;

            pbBackground.BorderStyle = BorderStyle.None;
            pbCover.BorderStyle = BorderStyle.None;
        }

        public void UpdateUI()
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new MethodInvoker(UpdateUI));
                return;
            }

            lbProgress.Text = Message;
            pbCover.Size = new Size((int)((double)(Max_Width - Progress) / Max_Width * (double)Width_Init), pbCover.Size.Height);
            pbCover.Location = new Point(X_Init + (Width_Init - (int)((double)(Max_Width - Progress) / Max_Width * (double)Width_Init)), pbCover.Location.Y);
        }

        public void CloseScreen()
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new MethodInvoker(CloseScreen));
                return;
            }

            System.Threading.Thread.Sleep(500);

            this.Close();
        }
    }
}
