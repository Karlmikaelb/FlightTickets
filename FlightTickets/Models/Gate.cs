using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FlightTickets.Models
{
    public class Gate
    {
        [ForeignKey("AirPlane")]
        public int Id { get; set; }

        public int GateNumber { get; set; }

        public virtual Crew Crew { get; set; }
        public virtual AirPlane AirPlane { get; set; }
    }
}