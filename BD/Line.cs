using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD
{
    public class Line
    {
        public int lineId { get; private set; }
        public string lineName { get; private set; }
        public int station1 { get; private set; }
        public int station2 { get; private set; }


        public Line(int lineId, string lineName, int station1, int station2)
        {
            this.lineId = lineId;
            this.lineName = lineName;
            this.station1 = station1;
            this.station2 = station2;
        }
    }
}
