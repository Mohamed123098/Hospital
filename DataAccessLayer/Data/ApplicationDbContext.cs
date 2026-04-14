using Hospital.Models;
using Microsoft.EntityFrameworkCore;

namespace Hospital.DataAccessLayer.Data
{
    public class ApplicationDbContext:DbContext
    {
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<AppointmentsDoctor> AppointmentsDoctors { get; set; }
        public DbSet<Specialization> Specializations { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppointmentConfigurations).Assembly);
        }
    }
}
