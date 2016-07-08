using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Guantanamo_GUI.UltilityModules
{
    public partial class LogUtility : UtilityBase
    {
        bool logging = false;

        StreamWriter writer;
        StreamReader reader;

        string read_Filename = "";

        public LogUtility(PresenterManager owner)
            :base(owner, Utility_Modules.LogUtility)
        {
            InitializeComponent();
        }

        public override void UpdateUI(string line)
        {
            if (logging)
            {
                writer.WriteLine(line);

                updateFlag = true;
            }
        }

        bool openNewFile()
        {
            if (writer != null && writer.BaseStream.CanWrite)
            {
                writer.Close();
            }

            string fileName = "";
            fileName = Application.StartupPath + @"\" + DateTime.Now.ToString("HH-mm-ss--dd-mm-yyyy") + ".txt";

            lbFilename.Text = DateTime.Now.ToString("HH-mm-ss--dd-mm-yyyy");

            if (File.Exists(fileName))
            {
                MessageBox.Show(fileName + " already exists... cannot create new file");
                return false;
            }

            try
            {
                writer = new StreamWriter(fileName);
            }
            catch {
                MessageBox.Show("Unable to open new file");
                return false; }

            return true;
        }

        void splitLog()
        {
            List<string> designators = new List<string>();

            string line = reader.ReadLine();
            string[] split = null;

            while (line != null)
            {
                split = line.Split(',');

                string designator = "";

                for (int i = 0; i != split.Length; i++)
                {
                    if ((int)split[i][0] > (int)'A' && (int)split[i][0] < (int)'z') //isLetter
                    {
                        designator += split[i][0];
                    }
                }

                for (int i = 1; i < designator.Length; i += 2)
                {
                    designator = designator.Insert(i, ",");
                }

                if (designator != "" && !designators.Contains(designator)) { designators.Add(designator); }

                line = reader.ReadLine();
            }

            string splitPath = Application.StartupPath + @"\" + read_Filename + @"\";

            if(!Directory.Exists(splitPath))
            {
                Directory.CreateDirectory(splitPath);
            }

            foreach (string designator in designators)
            {
                reader.BaseStream.Position = 0;
                string fileName = splitPath + designator + ".txt";
                line = reader.ReadLine();
                using (StreamWriter tempWriter = new StreamWriter(fileName))
                {
                    while (line != null)
                    {
                        if (line.Contains(designator))
                        {
                            tempWriter.WriteLine(line);
                        }
                        line = reader.ReadLine();
                    }
                }
            }
        }

        private void btnBegin_Click(object sender, EventArgs e)
        {
            openNewFile();

            logging = true;

            lbStatus.Text = "RECORDING";

            updateFlag = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            logging = false;

            if (writer != null)
            {
                writer.Close();
            }

            lbStatus.Text = "NOT RECORDING";
        }

        private void btnNewFile_Click(object sender, EventArgs e)
        {
            openNewFile();
        }

        private void btnSplit_Click(object sender, EventArgs e)
        {
            d_OpenFile.ShowDialog();
        }

        private void d_OpenFile_FileOk(object sender, CancelEventArgs e)
        {
            try
            {
                reader = new StreamReader(d_OpenFile.FileName);
                read_Filename = d_OpenFile.SafeFileName;
                read_Filename = read_Filename.Split('.')[0];

                splitLog();
            }
            catch { MessageBox.Show("Could not split log");  }
        }
    }
}
