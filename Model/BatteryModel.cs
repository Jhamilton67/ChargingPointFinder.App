using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChargingPointFinder.Model
{
    public static class BatteryModel
    {
        public static string Name { get; set; }
        public static string Location { get; set; }
        public static string Details { get; set; }
        public static string Image { get; set; }
        public static int NumberofBatteries { get; set; }
        public static double Latiitude { get; set; }
        public static double Longitude { get; set; }
    }
}
