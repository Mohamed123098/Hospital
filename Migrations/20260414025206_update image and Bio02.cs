using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hospital.Migrations
{
    /// <inheritdoc />
    public partial class updateimageandBio02 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("update Doctors set Image='team-1.jpg' where Id in(1,4,7,10,13,16,19,22,25,28)");
            migrationBuilder.Sql("update Doctors set Image='team-2.jpg' where Id in(2,5,8,11,14,17,20,23,26,29)");
            migrationBuilder.Sql("update Doctors set Image='team-3.jpg' where Id in(3,6,9,12,15,18,21,24,27,30)");


        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
