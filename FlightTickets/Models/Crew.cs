using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FlightTickets.Models
{
    public class Crew
    {
        public int Id { get; set; }
        public string CrewRole { get; set; }

        public virtual ICollection<AirPlane> AirPlanes { get; set; }
        public virtual ICollection<Gate> Gates { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}