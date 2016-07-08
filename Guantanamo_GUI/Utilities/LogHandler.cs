using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;

namespace Guantanamo_GUI
{
    public enum LegacyFile_DataColumns
    {
        Latitute = 0, Longitude = 1,
    }

    public class LogHandler
    {
        public StreamWriter Writer;
        public StreamReader Reader;

        public bool RecordData = false;
        public bool WriteOpen = false;

        long fileLength = 0;

        PresenterManager parentForm;

        public LogHandler(PresenterManager parent)
        {
            parentForm = parent;
        }

        void LogHandler_LineReadUI()
        {

        }

        void LogHandler_LineRead(string line)
        {

        }

        public void BeginRecord()
        {
            if (Writer == null || !Writer.BaseStream.CanWrite) { return; }
            RecordData = true;
        }

        public void EndRecord()
        {
            RecordData = false;
        }

        public void Update(string line)
        {
            if (WriteOpen && RecordData)
            {
                Writer.WriteLine(line);
            }
        }

        public void ConvertLegacyFile(string fileName)
        {
            if (!OpenFile_Read(fileName)) { return; }
            string[] split = fileName.Split('.');
            split[0] += "CONVERT.";
            fileName = split[0] + split[1];

            if (!OpenFile_Write(fileName)) { return; }

            string line = ReadLine();
            string[] columns;

            while (line != null)
            {
                columns = line.Split(',');
                try
                {
                    Writer.WriteLine("G,P," + columns[(int)LegacyFile_DataColumns.Latitute] + "," + columns[(int)LegacyFile_DataColumns.Longitude]);
                }
                catch { }
                line = ReadLine();
            }

            Writer.Close();
            Reader.Close();
        }

        public bool OpenFile_Write(string fileName)
        {
            try
            {
                Writer = new StreamWriter(File.OpenWrite(fileName));
                WriteOpen = true;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool OpenFile_Read(string fileName)
        {
            try
            {
                Reader = new StreamReader(File.OpenRead(fileName));
                FileInfo f = new FileInfo(fileName);
                fileLength = f.Length;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void ReadEntireFile_Simulate()
        {
            LoadingScreen_Handler progressScreen = new LoadingScreen_Handler();

            progressScreen.ShowLoading();

            string line = ReadLine();

            int index = 0;
            int lastUpdate = 0;
            string progressMessage = "";
            long charsRead = 0;

            while (line != null)
            {
                charsRead += line.Length + 2;

                if (line.Length != 0)
                {
                    VehicleSystems.Update(line);
                    parentForm.UpdateUI(line);
                    line = ReadLine();
                    index++;
                }

                if ((int)((float)index/20.0f) != lastUpdate)
                {
                    lastUpdate++;
                    progressMessage = "Reading line " + index.ToString();
                    progressScreen.UpdateProgress(progressMessage, (int)((float)charsRead / (float)fileLength * 100.0f));
                }
            }

            progressScreen.UpdateProgress("FINISHED!", 100);

            CloseRead();

            progressScreen.CloseScreen();
        }

        public List<double[]> ReadEntireFile_Waypoints()
        {
            List<double[]> waypoints = new List<double[]>();
            string line = ReadLine();

            while (line != null)
            {
                double[] coords = new double[2];

                do
                {
                    if (line.Length != 0)
                    {
                        string[] split = line.Split(',');
                        if (!double.TryParse(split[0], out coords[0])) { break; }
                        if (!double.TryParse(split[1], out coords[1])) { break; }
                        waypoints.Add(coords);
                    }
                } while (false);

                line = ReadLine();
            }

            CloseRead();

            return waypoints;
        }

        public void SplitLog(string fileName)
        {
            StreamWriter writer;
            StreamReader reader;

            string[] fileName_Split = fileName.Split('.');
            string finalFN = "";

            for (int i = 0; i != fileName_Split.Length - 1; i++)
            {
                finalFN += fileName_Split[i] + ".";
            }

            List<char> designatorsExported = new List<char>();

            bool fullySplitLog = false;

            while (!fullySplitLog)
            {
                reader = new StreamReader(File.OpenRead(fileName));
                writer = null;

                string line = reader.ReadLine();
                char designator = ' ';

                while (line != null)
                {
                    if (designator == ' ' && !designatorsExported.Contains(line[0]))
                    {
                        designator = line[0];
                        designatorsExported.Add(designator);
                        writer = new StreamWriter(File.OpenWrite(finalFN + "_" + designator + "txt"));
                    }
                    if(line[0] == designator) { writer.WriteLine(line); }
                    line = reader.ReadLine();
                }

                if (designator == ' ') { fullySplitLog = true; }
                else { writer.Close(); }
                reader.Close();
            }
        }

        public string ReadLine()
        {
            return Reader.ReadLine();
        }

        public void WriteLine(string line)
        {
            Writer.WriteLine(line);
        }

        public void CloseRead()
        {
            try
            {
                Reader.Close();
            }
            catch { }
        }

        public void CloseWrite()
        {
            try
            {
                Writer.Close();
                WriteOpen = false;
            }
            catch { }
        }
    }
}
