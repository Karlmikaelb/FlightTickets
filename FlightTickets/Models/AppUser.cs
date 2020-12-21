using Microsoft.AspNet.Identity.EntityFramework;

namespace FlightTickets.Models
{
    public class AppUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Country { get; set; }
        public int Age { get; set; }
    }
}