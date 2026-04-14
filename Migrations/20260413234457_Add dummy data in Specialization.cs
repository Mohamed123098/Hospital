using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hospital.Migrations
{
    /// <inheritdoc />
    public partial class AdddummydatainSpecialization : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("insert into Specializations (Name, Capacity) values ('Gastroenterology', 60); insert into Specializations (Name, Capacity) values ('Gastroenterology', 60);insert into Specializations (Name, Capacity) values ('Neurology', 60);insert into Specializations (Name, Capacity) values ('Orthopedics', 60);insert into Specializations (Name, Capacity) values ('Oncology', 60);insert into Specializations (Name, Capacity) values ('Dermatology', 72);insert into Specializations (Name, Capacity) values ('Urology', 63);insert into Specializations (Name, Capacity) values ('Orthopedics', 64);insert into Specializations (Name, Capacity) values ('Pediatrics', 58);insert into Specializations (Name, Capacity) values ('Pediatrics', 69);");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("truncate table Specializations");
        }
    }
}
