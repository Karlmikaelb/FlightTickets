using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FlightTickets.Models
{
    public class AirPlane
    {
        public int Id { get; set; }
        
        public int FlightNumber { get; set; }

        public virtual Crew Crew { get; set; }
        public virtual Gate Gate { get; set; }
    }
}