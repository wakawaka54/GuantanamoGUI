using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Guantanamo_GUI
{
    class LoadingScreen_Handler
    {
        public LoadingScreen LoadingForm;
        BackgroundWorker worker;

        public LoadingScreen_Handler()
        {
            worker = new BackgroundWorker();
            LoadingForm = new LoadingScreen();
            worker.DoWork += worker_DoWork;
        }

        public void UpdateProgress(string message, int progress)
        {
            LoadingForm.UpdateUI(message, progress);
        }

        public void ShowLoading()
        {
            if (worker.IsBusy) { return; }
            worker.RunWorkerAsync();
        }

        public void CloseScreen()
        {
            LoadingForm.CloseScreen();
        }

        void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            LoadingForm.ShowDialog();
        }
    }
}
