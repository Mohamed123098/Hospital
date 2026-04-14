using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hospital.Migrations
{
    /// <inheritdoc />
    public partial class AdddummydatainAppointmentsDoctors : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("insert into AppointmentsDoctors (AppointmentId, DoctorId) values (3, 8);insert into AppointmentsDoctors (AppointmentId, DoctorId) values (2, 27);insert into AppointmentsDoctors (AppointmentId, DoctorId) values (9, 22);insert into AppointmentsDoctors (AppointmentId, DoctorId) values (9, 17);insert into AppointmentsDoctors (AppointmentId, DoctorId) values (7, 16);insert into AppointmentsDoctors (AppointmentId, DoctorId) values (2, 24);insert into AppointmentsDoctors (AppointmentId, DoctorId) values (1, 21);insert into AppointmentsDoctors (AppointmentId, DoctorId) values (5, 1);insert into AppointmentsDoctors (AppointmentId, DoctorId) values (6, 15);insert into AppointmentsDoctors (AppointmentId, DoctorId) values (3, 29);");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("truncate table AppointmentsDoctors");
        }
    }
}
