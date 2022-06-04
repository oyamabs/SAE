using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD
{
    public class Station
    {
        private int stationId { get; set; }
        private string stationName { get; set; }
        private bool hasElevator { get; set; }
        private bool hasParking { get; set; }

        public Station(int stationId, string stationName, bool hasElevator, bool hasParking)
        {
            this.stationId = stationId;
            this.stationName = stationName;
            this.hasElevator = hasElevator;
            this.hasParking = hasParking;
        }
    }
}
