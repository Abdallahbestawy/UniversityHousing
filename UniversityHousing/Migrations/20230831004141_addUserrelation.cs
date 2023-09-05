using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UniversityHousing.Migrations
{
    public partial class addUserrelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Students_userId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Admins_userId",
                table: "Admins");

            migrationBuilder.CreateIndex(
                name: "IX_Students_userId",
                table: "Students",
                column: "userId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Admins_userId",
                table: "Admins",
                column: "userId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Students_userId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Admins_userId",
                table: "Admins");

            migrationBuilder.CreateIndex(
                name: "IX_Students_userId",
                table: "Students",
                column: "userId");

            migrationBuilder.CreateIndex(
                name: "IX_Admins_userId",
                table: "Admins",
                column: "userId");
        }
    }
}
