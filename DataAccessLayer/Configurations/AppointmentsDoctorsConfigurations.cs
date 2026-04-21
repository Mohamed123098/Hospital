using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hospital.DataAccessLayer.Configurations
{
    public class AppointmentsDoctorsConfigurations : IEntityTypeConfiguration<AppointmentsDoctor>
    {
        public void Configure(EntityTypeBuilder<AppointmentsDoctor> builder)
        {
            builder.HasKey(AD => new { AD.AppointmentId, AD.DoctorId });
            //builder.HasOne(AD => AD.Appointment).WithMany(A => A).HasForeignKey(AD => AD.AppointmentId);
            builder.HasOne(AD => AD.Doctor).WithMany(A => A.AppointmentsDoctors).HasForeignKey(AD => AD.DoctorId);

        }
    }
}
