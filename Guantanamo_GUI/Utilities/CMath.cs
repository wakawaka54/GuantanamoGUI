using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guantanamo_GUI
{
    class CMath
    {
        public static double Map(double value, double fromMin, double fromMax, double toMin, double toMax)
        {
            //(value - minLat)/(maxLat-minLat) * (maxScale - minScale) - minScale
            return (value - fromMin) / (fromMax - fromMin) * (toMax - toMin) + toMin;
        }
    }
}
