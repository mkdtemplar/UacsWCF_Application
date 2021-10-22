using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UniversityApplication.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    AddressId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StreetAddress = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(200)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.AddressId);
                });

            migrationBuilder.CreateTable(
                name: "Exam",
                columns: table => new
                {
                    ExamId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
                    ProfessorName = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
                    Credits = table.Column<decimal>(type: "decimal(5,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exam", x => x.ExamId);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(name: "First Name", type: "nvarchar(60)", maxLength: 60, nullable: true),
                    LastName = table.Column<string>(name: "Last Name", type: "nvarchar(60)", maxLength: 60, nullable: true),
                    EnrollmentDate = table.Column<DateTime>(name: "Enrollment Date", type: "datetime", nullable: true),
                    DateOfBirth = table.Column<DateTime>(name: "Date Of Birth", type: "datetime", nullable: true),
                    EMail = table.Column<string>(name: "E-Mail", type: "nvarchar(50)", nullable: true),
                    StudentIndex = table.Column<string>(name: "Student Index", type: "nvarchar(4)", nullable: true),
                    GPA = table.Column<decimal>(type: "decimal(3,2)", nullable: true),
                    AddressId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentId);
                    table.ForeignKey(
                        name: "FK_Students_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "AddressId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Transcripts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExamId = table.Column<int>(type: "int", nullable: false),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    Points = table.Column<decimal>(type: "decimal(4)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transcripts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Transcripts_Exam_ExamId",
                        column: x => x.ExamId,
                        principalTable: "Exam",
                        principalColumn: "ExamId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Transcripts_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Students_AddressId",
                table: "Students",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Transcripts_ExamId",
                table: "Transcripts",
                column: "ExamId");

            migrationBuilder.CreateIndex(
                name: "IX_Transcripts_StudentId",
                table: "Transcripts",
                column: "StudentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Transcripts");

            migrationBuilder.DropTable(
                name: "Exam");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Addresses");
        }
    }
}
