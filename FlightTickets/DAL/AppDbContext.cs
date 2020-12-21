using FlightTickets.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace FlightTickets.DAL
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public DbSet<AirPlane> AirPlanes { get; set; }
        public DbSet<Crew> Crews { get; set; }
        public DbSet<Gate> Gates { get; set; }
        public DbSet<Employee> Employee { get; set; }

        public AppDbContext() : base("DefaultConnection")
        {
        }        
    }    
}