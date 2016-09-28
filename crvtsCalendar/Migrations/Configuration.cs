namespace crvtsCalendar.Migrations
{
    using crvtsCalendar.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<crvtsCalendar.Models.AppointmentDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "crvtsCalendar.Models.AppointmentDBContext";
        }

        protected override void Seed(crvtsCalendar.Models.AppointmentDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            
                context.Appointments.AddOrUpdate(
                  p => p.ID,
                  new Appointment { Description="Skype interview", Organizer="Dary Harrison", Date=DateTime.Now.AddMonths(1), Attendees="Sasha, Tom, Paul" },
                  new Appointment { Description="Scrum meeting", Organizer="Tom Smith", Date=DateTime.Now.AddMonths(-1), Attendees="Sasha, Tom, Paul" },
                  new Appointment { Description="MVC training", Organizer="Gary Turner", Date=DateTime.Now.AddMonths(1), Attendees="Sasha, Tom, Paul" }
                );
            
        }
    }
}
