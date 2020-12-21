using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FlightTickets.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }

        public virtual Crew Crew { get; set; }
    }
}