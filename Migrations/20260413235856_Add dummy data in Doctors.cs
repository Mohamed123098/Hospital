using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hospital.Migrations
{
    /// <inheritdoc />
    public partial class AdddummydatainDoctors : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("insert into Doctors (Name, Position, Age, SpecializationId) values ('Gustavus Pash', 'Gynecologist', 79, 4);insert into Doctors (Name, Position, Age, SpecializationId) values ('Cecily Varnals', 'Oncologist', 34, 10);insert into Doctors (Name, Position, Age, SpecializationId) values ('Albie Mowling', 'Pediatrician', 75, 1);insert into Doctors (Name, Position, Age, SpecializationId) values ('Tony Tamburo', 'Oncologist', 49, 10);insert into Doctors (Name, Position, Age, SpecializationId) values ('Lydie Hamley', 'Psychiatrist', 30, 10);insert into Doctors (Name, Position, Age, SpecializationId) values ('Rebe Busse', 'Pediatrician', 48, 10);insert into Doctors (Name, Position, Age, SpecializationId) values ('Minda Ploughwright', 'Pediatrician', 38, 4);insert into Doctors (Name, Position, Age, SpecializationId) values ('Robinett Bettenay', 'Cardiologist', 57, 9);insert into Doctors (Name, Position, Age, SpecializationId) values ('Knox Weems', 'Oncologist', 77, 3);insert into Doctors (Name, Position, Age, SpecializationId) values ('Nikolas Lack', 'Gynecologist', 76, 8);insert into Doctors (Name, Position, Age, SpecializationId) values ('Rafaela Kidds', 'Psychiatrist', 69, 8);insert into Doctors (Name, Position, Age, SpecializationId) values ('Tad Petriello', 'Cardiologist', 66, 9);insert into Doctors (Name, Position, Age, SpecializationId) values ('Corabelle Paxman', 'Cardiologist', 30, 5);insert into Doctors (Name, Position, Age, SpecializationId) values ('Waly Weyland', 'Neurologist', 47, 4);insert into Doctors (Name, Position, Age, SpecializationId) values ('Dulcine Dassindale', 'Oncologist', 38, 8);insert into Doctors (Name, Position, Age, SpecializationId) values ('Gustie Prosser', 'Urologist', 66, 4);insert into Doctors (Name, Position, Age, SpecializationId) values ('Benny Buxsy', 'Psychiatrist', 46, 9);insert into Doctors (Name, Position, Age, SpecializationId) values ('Elsy Duran', 'Neurologist', 52, 4);insert into Doctors (Name, Position, Age, SpecializationId) values ('Tamqrah Spriddle', 'Orthopedic Surgeon', 71, 8);insert into Doctors (Name, Position, Age, SpecializationId) values ('Joannes Lowensohn', 'Psychiatrist', 57, 6);insert into Doctors (Name, Position, Age, SpecializationId) values ('Anestassia Crudginton', 'Gynecologist', 73, 8);insert into Doctors (Name, Position, Age, SpecializationId) values ('Hewe Delacour', 'Orthopedic Surgeon', 54, 6);insert into Doctors (Name, Position, Age, SpecializationId) values ('Taite Tibbles', 'Orthopedic Surgeon', 33, 7);insert into Doctors (Name, Position, Age, SpecializationId) values ('Bernardine Cholwell', 'Neurologist', 54, 9);insert into Doctors (Name, Position, Age, SpecializationId) values ('Sam Blackbourn', 'Pediatrician', 62, 1);insert into Doctors (Name, Position, Age, SpecializationId) values ('Wendie Rawne', 'Pediatrician', 63, 3);insert into Doctors (Name, Position, Age, SpecializationId) values ('Guillaume Short', 'Dermatologist', 36, 8);insert into Doctors (Name, Position, Age, SpecializationId) values ('Inge Andreou', 'Cardiologist', 54, 7);insert into Doctors (Name, Position, Age, SpecializationId) values ('Cary Mattek', 'Pediatrician', 77, 1);insert into Doctors (Name, Position, Age, SpecializationId) values ('Stavro Blayd', 'Dermatologist', 51, 4);");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("truncate table Doctors");
        }
    }
}
