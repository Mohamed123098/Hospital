using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hospital.DataAccessLayer.Configurations
{
    public class DoctorConfigurations : IEntityTypeConfiguration<Doctor>
    {
        public void Configure(EntityTypeBuilder<Doctor> builder)
        {
            builder.HasKey(D => D.Id);
            builder.HasOne(D => D.Specialization).WithMany(S => S.Doctors).HasForeignKey(D => D.SpecializationId);
        }
    }
}
