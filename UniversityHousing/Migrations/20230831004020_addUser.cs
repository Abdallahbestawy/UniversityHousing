using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UniversityHousing.Migrations
{
    public partial class addUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Admins_User_userId",
                table: "Admins");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_User_userId",
                table: "Students");

            migrationBuilder.DropTable(
                name: "StudentViewModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.RenameTable(
                name: "User",
                newName: "users");

            migrationBuilder.AddPrimaryKey(
                name: "PK_users",
                table: "users",
                column: "userId");

            migrationBuilder.AddForeignKey(
                name: "FK_Admins_users_userId",
                table: "Admins",
                column: "userId",
                principalTable: "users",
                principalColumn: "userId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_users_userId",
                table: "Students",
                column: "userId",
                principalTable: "users",
                principalColumn: "userId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Admins_users_userId",
                table: "Admins");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_users_userId",
                table: "Students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_users",
                table: "users");

            migrationBuilder.RenameTable(
                name: "users",
                newName: "User");

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "userId");

            migrationBuilder.CreateTable(
                name: "StudentViewModel",
                columns: table => new
                {
                    userId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddressId = table.Column<int>(type: "int", nullable: false),
                    facultyId = table.Column<byte>(type: "tinyint", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    NationalId = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    StudentGrade = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    studentLevel = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentViewModel", x => x.userId);
                    table.ForeignKey(
                        name: "FK_StudentViewModel_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentViewModel_Facultys_facultyId",
                        column: x => x.facultyId,
                        principalTable: "Facultys",
                        principalColumn: "FacultyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StudentViewModel_AddressId",
                table: "StudentViewModel",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentViewModel_facultyId",
                table: "StudentViewModel",
                column: "facultyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Admins_User_userId",
                table: "Admins",
                column: "userId",
                principalTable: "User",
                principalColumn: "userId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_User_userId",
                table: "Students",
                column: "userId",
                principalTable: "User",
                principalColumn: "userId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
