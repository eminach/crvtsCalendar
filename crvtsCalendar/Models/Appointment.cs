using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace crvtsCalendar.Models
{
    public class Appointment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string  Description { get; set; }
        public DateTime Date { get; set; }
        public string Organizer { get; set; }
        public string Attendees { get; set; }
    }
    public class AppointmentDBContext : DbContext
    {
        public DbSet<Appointment> Appointments { get; set; }
    }
}