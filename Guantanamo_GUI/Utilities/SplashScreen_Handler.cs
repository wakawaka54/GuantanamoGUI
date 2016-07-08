using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;

namespace Guantanamo_GUI
{
    class SplashScreen_Handler
    {
        public SplashScreen Splash;
        BackgroundWorker worker;

        public SplashScreen_Handler()
        {
            worker = new BackgroundWorker();
            Splash = new SplashScreen();
            worker.DoWork += worker_DoWork;
        }

        public void UpdateProgress(string message, int progress)
        {
            Splash.Message = message;
            Splash.Progress = (int)CMath.Map((double)progress, 0, MDI_Parent.INIT_PROGRESS_COUNT, 0, SplashScreen.Max_Width);
            Splash.UpdateUI();
        }

        public void CloseSplash()
        {
            Splash.CloseScreen();
        }

        public void ShowSplash()
        {
            worker.RunWorkerAsync();
        }

        void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            Splash.ShowDialog();
        }
       
    }
}
