using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Guantanamo_GUI.VehicleSensors
{
    class ImageProcessing_Sensor : Sensor
    {
        public int[] Readings_XY = new int[2];
        public int Area = 0;
        public Bitmap ImageBuffer = new Bitmap(320, 240);
        public int RowsReceived = 0;

        public string SentLines = "";
        public string ReceivedLines = "";

        int[] bitmapIndex = new int[2] { 0, 0 };
        int rowUpdateCounter = 0;

        public ImageProcessing_Sensor()
        {
            Designator = "J";
        }

        public override void Reset()
        {
            Readings_XY = new int[2];

            ClearLineBuffers();
        }

        public override bool Update(string[] split)
        {
            switch (split[1])
            {
                case "V":
                    return read_V_Line(split);

                case "S":
                    read_S_Line(split);
                    break;

                case "R":
                    read_R_Line(split);
                    break;

                case "P":
                    read_P_Line(split);
                    break;
            }

            return true;
        }

        public void ClearLineBuffers()
        {
            ReceivedLines = "";
            SentLines = "";
        }

        bool read_P_Line(string[] split)
        {
            switch (split[2])
            {
                case "R":
                    bitmapIndex[0] = 0;
                    bitmapIndex[1] = (bitmapIndex[1] + 1) % ImageBuffer.Height;
                    RowsReceived++;
                    if (rowUpdateCounter < (int)(RowsReceived / 5))
                    {
                        rowUpdateCounter = (int)(RowsReceived / 5);
                        VehicleSystems.EndHighDataTransfer();
                    }
                    return true;
                    
                case "E":
                    VehicleSystems.EndHighDataTransfer();
                    return true;

                case "B":
                    ImageBuffer = new Bitmap(320, 240);
                    bitmapIndex = new int[2] { 0, 0 };
                    RowsReceived = 0;
                    return true;

                default:
                    VehicleSystems.PrepareHighDataTransfer();
                    short r, g, b;
                    if (!short.TryParse(split[2], out r)) { return false; }
                    if (!short.TryParse(split[3], out g)) { return false; }
                    if (!short.TryParse(split[4], out b)) { return false; }
                    ImageBuffer.SetPixel(bitmapIndex[0]++, bitmapIndex[1], Color.FromArgb(r,g,b));
                    if (bitmapIndex[0] >= ImageBuffer.Width) { bitmapIndex[0] = 0; }
                    return true;
            }
        }

        int clamp(int i)
        {
            if (i < 0) { return 0; }
            if (i > 255) { return 255; }

            return i;
        }

        bool read_S_Line(string[] split)
        {
            string line = "";

            for (int i = (int)ImageProcessing_DataColumns_S.SentSerial; i != split.Length - 1; i++)
            {
                line += split[i] + ",";
            }

            line += split[split.Length - 1];

            SentLines += line + "\n";

            return true;
        }

        bool read_R_Line(string[] split)
        {
            string line = "";

            for (int i = (int)ImageProcessing_DataColumns_S.SentSerial; i != split.Length - 1; i++)
            {
                line += split[i] + ",";
            }

            line += split[split.Length - 1];

            ReceivedLines += line + "\n";

            return false;  
        }

        bool read_V_Line(string[] split)
        {
            if (!int.TryParse(split[(int)ImageProcessing_DataColumns_V.CentroidX], out Readings_XY[0])) { return false; }
            if (!int.TryParse(split[(int)ImageProcessing_DataColumns_V.CentroidY], out Readings_XY[1])) { return false; }
            if (!int.TryParse(split[(int)ImageProcessing_DataColumns_V.Area], out Area)) { return false; }

            return true;
        }
    }
}
