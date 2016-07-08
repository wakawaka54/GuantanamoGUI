using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Ports;
using System.Diagnostics;

namespace Guantanamo_GUI
{
    public delegate void SerialRead_ErrorHandler(Exception e);

    public class SerialCOM
    {
        const int SerialPort_OverloadState = 4000; //when more than 4000 bytes, consider serial port overloaded
        const int WriteBuffer_Length = 1000;

        public SerialPort Port;

        public int BaudRate = 57600;

        public volatile int ErrorsCaught;
        public volatile int BytesToRead;
        public volatile int AvgTime_Per_Read = 0;
        public volatile int Updates_Per_Second = 0;
        public volatile int Bytes_Per_Second = 0;
        public volatile int Max_BytesToRead = 0;
        public volatile int NumberTries_Write = 0;
        public volatile int Bytes_Dumped = 0;

        public event SerialRead_ErrorHandler SerialRead_Error;

        BackgroundWorker readWorker;
        BackgroundWorker writeWorker;

        volatile int writeIndex_Main = 0;
        volatile int writeIndex_Background = 0;
        volatile char[] writeBuffer = new char[WriteBuffer_Length];

        Stopwatch _stopWatch = new Stopwatch();

        long avgTime_Per_Read = 0;
        long updates_Per_Second = 0;
        long nextTime_ToSample = 0;
        long bytesTransfered = 0;
        int maxBytesToRead = 0;
        int bytesDumped = 0;

        public SerialCOM()
        {
            Port = new SerialPort();

            Port.NewLine = "\r\n";

            resetHealth();
            setupWriteWorker();
            setupReadWorker();
        }

        public bool WriteCommand(string command)
        {
            if (!Port.IsOpen) { return false; }

            int tempWriteIndex = writeIndex_Main;

            for (int i = 0; i != command.Length; i++)
            {
                writeBuffer[tempWriteIndex] = command[i];
                tempWriteIndex++;
                if (tempWriteIndex >= WriteBuffer_Length) { tempWriteIndex = 0; }
            }

            writeIndex_Main = tempWriteIndex;

            if (!writeWorker.IsBusy) { writeWorker.RunWorkerAsync(); }

            return true;
        }

        public string[] GetCOMPorts()
        {
            return SerialPort.GetPortNames();
        }

        public bool Open(string portName)
        {
            try
            {
                if (Port.IsOpen) { return false; }

                Port.PortName = portName;
                Port.BaudRate = BaudRate;
                Port.Open();
                resetHealth();
                _stopWatch.Start();

                readWorker.RunWorkerAsync();
            }
            catch { return false; }
            return true;
        }

        public bool Close()
        {
            try
            {
                if (!Port.IsOpen) { return true; }
                _stopWatch.Stop();
                Port.Close();
                return true;
            }
            catch { return false; }
        }

        void setupWriteWorker()
        {
            writeWorker = new BackgroundWorker();
            writeWorker.DoWork += writeWorker_DoWork;
        }

        void setupReadWorker()
        {
            readWorker = new BackgroundWorker();
            readWorker.DoWork += readWorker_DoWork;
        }

        void writeWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            writeWorkerThread();
        }

        void readWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            readWorkerThread();
        }

        void writeWorkerThread()
        {
            while (Port.IsOpen)
            {
                while (writeIndex_Main != writeIndex_Background)
                {
                    Port.Write(writeBuffer[writeIndex_Background++].ToString());

                    if (writeIndex_Background >= WriteBuffer_Length) { writeIndex_Background = 0; }
                }
            }
        }

        void readWorkerThread() //Read Serial Line - Background Worker Main Thread
        {
            while (Port.IsOpen)
            {
                try
                {
                    checkOverload(); //if serial port is overloaded, dump data - WORST CASE SOLUTION
                    string line = Port.ReadLine();
                    if (line != "")
                    {
                        avgTime_Per_Read -= _stopWatch.ElapsedMilliseconds;
                        bytesTransfered += line.Length;
                        VehicleSystems.Update(line);
                        avgTime_Per_Read += _stopWatch.ElapsedMilliseconds;
                        updateHealth();
                    }
                }
                catch (Exception e) { ErrorsCaught++; if (SerialRead_Error != null) { SerialRead_Error(e); } }
            }
        }

        void checkOverload()
        {
            if (Port.BytesToRead > Port.ReadBufferSize)
            {
                bytesDumped = Port.BytesToRead;
                Port.ReadExisting();
            }
        }

        void updateHealth() //utility method for determining Serial Read Health
        {
            updates_Per_Second++;
            BytesToRead = Port.BytesToRead;
            if (Port.BytesToRead > maxBytesToRead) { maxBytesToRead = Port.BytesToRead; }

            if (_stopWatch.ElapsedMilliseconds - nextTime_ToSample >= 0)
            {
                AvgTime_Per_Read = (int)(avgTime_Per_Read / updates_Per_Second);
                Updates_Per_Second = (int)updates_Per_Second;
                Bytes_Per_Second = (int)bytesTransfered;
                Max_BytesToRead = (int)maxBytesToRead;
                Bytes_Dumped = bytesDumped;

                maxBytesToRead = 0;
                bytesTransfered = 0;
                updates_Per_Second = 0;
                avgTime_Per_Read = 0;
                nextTime_ToSample = _stopWatch.ElapsedMilliseconds + 1000;
            }
        }

        void resetHealth()
        {
            ErrorsCaught = 0;
            Max_BytesToRead = 0;
            Updates_Per_Second = 0;
            Bytes_Dumped = 0;
            BytesToRead = 0;
            _stopWatch = new Stopwatch();
        }
    }
}
