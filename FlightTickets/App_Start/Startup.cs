using FlightTickets.DAL;
using FlightTickets.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Owin;
using System;

[assembly: OwinStartup(typeof(FlightTickets.App_Start.Startup))]

namespace FlightTickets.App_Start
{
    public class Startup
    {
        public static Func<UserManager<AppUser>> UserManagerFactory { get; set; }
        public void Configuration(IAppBuilder app)
        {
            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath = new PathString("/auth/login"),
                ExpireTimeSpan = TimeSpan.FromMinutes(20),
                SlidingExpiration = true,
                CookieSecure = CookieSecureOption.Always,
                CookieName = "Kladdkaka"
            });

            // configure user manager
            UserManagerFactory = () =>
            {
                var usermanager = new UserManager<AppUser>(
                    new UserStore<AppUser>(new AppDbContext()));

                usermanager.UserValidator = new UserValidator<AppUser>(usermanager)
                {
                    AllowOnlyAlphanumericUserNames = true                    
                };

                usermanager.PasswordValidator = new PasswordValidator()
                {
                    RequiredLength = 6
                };

                return usermanager;
            };
        }
    }
}