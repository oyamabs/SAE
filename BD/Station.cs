using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD
{
    public class Station
    {
        public int stationId { get; private set; }
        public string stationName { get; private set; }
        public  bool hasElevator { get; private set; }
        public bool hasParking { get; private set; }
        public Station(int stationId, string stationName, bool hasElevator, bool hasParking)
        {
            this.stationId = stationId;
            this.stationName = stationName;
            this.hasElevator = hasElevator;
            this.hasParking = hasParking;
        }
    }
}
