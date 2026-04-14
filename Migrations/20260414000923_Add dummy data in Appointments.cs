using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hospital.Migrations
{
    /// <inheritdoc />
    public partial class AdddummydatainAppointments : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("insert into Appointments (PatientName, AppointmentDate, AppointmentTime) values ('Ara Nevill', '4/8/2026', '12:13');insert into Appointments (PatientName, AppointmentDate, AppointmentTime) values ('Gill Heaven', '11/27/2025', '0:19');insert into Appointments (PatientName, AppointmentDate, AppointmentTime) values ('Mandie Dealy', '12/4/2025', '1:31');insert into Appointments (PatientName, AppointmentDate, AppointmentTime) values ('Dean Henricsson', '9/25/2025', '11:30');insert into Appointments (PatientName, AppointmentDate, AppointmentTime) values ('Brietta Disbrow', '2/25/2026', '13:27');insert into Appointments (PatientName, AppointmentDate, AppointmentTime) values ('Jenilee Coppard', '4/12/2026', '7:55');insert into Appointments (PatientName, AppointmentDate, AppointmentTime) values ('Yevette Tison', '4/8/2026', '4:43');insert into Appointments (PatientName, AppointmentDate, AppointmentTime) values ('Ninnetta Stanyon', '4/20/2026', '15:44');insert into Appointments (PatientName, AppointmentDate, AppointmentTime) values ('Dot Ruse', '2/13/2026', '12:28');insert into Appointments (PatientName, AppointmentDate, AppointmentTime) values ('Brook Braunton', '3/2/2026', '17:16');");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("truncate table Appointments");
        }
    }
}
