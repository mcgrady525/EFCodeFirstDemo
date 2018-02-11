using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstDemo.Entity.BO
{
    public class GetFltAskOrderRS
    {
        public int AskOrderId { get; set; }

        public string AskOrderNo { get; set; }

        public int CorpId { get; set; }

        public string FlightType { get; set; }

        public string TravelType { get; set; }

    }
}
