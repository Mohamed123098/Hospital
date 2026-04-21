using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hospital.DataAccessLayer.Configurations
{
    public class AppointmentConfigurations : IEntityTypeConfiguration<Appointment>
    {
        public void Configure(EntityTypeBuilder<Appointment> builder)
        {
            builder.HasKey(A => A.Id);
            builder.HasOne(A => A.Doctor).WithMany(D => D.Appointments).HasForeignKey(A => A.DoctorId);
            builder.HasOne(A => A.Specialization).WithMany(S => S.Appointments).HasForeignKey(A => A.SpecializationId);
           
        }

    }
}
