using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UniversityApplication.Data.Migrations
{
    public partial class InitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "AddressId", "City", "Country", "StreetAddress" },
                values: new object[,]
                {
                    { 1, "London", "UK", "Frying Pan Road" },
                    { 2, "Cincinnati", "USA", "Error Place" },
                    { 3, "Rome", "Italy", "Bad Route Road" },
                    { 4, "Las Vegas", "USA", "Pillow Talk Court" },
                    { 5, "Berlin", "Germany", "This Street" }
                });

            migrationBuilder.InsertData(
                table: "Exam",
                columns: new[] { "ExamId", "Credits", "Name", "ProfessorName" },
                values: new object[,]
                {
                    { 1, 6m, "Computer Programming", "Nicoline Abspoel" },
                    { 2, 5m, "Computer Architecture", "Ashlynn Van Hautum" },
                    { 3, 5.5m, "Databases", "Andrew Kennard" },
                    { 4, 5m, "Discrete Mathematics", "Algernon Aarse" },
                    { 5, 5m, "Data Structures and Algorithms", "Sampson Daelmans" },
                    { 6, 5.5m, "Operating Systems", "Ermintrude Royceston" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "AddressId", "Date Of Birth", "Enrollment Date", "First Name", "GPA", "Last Name", "E-Mail", "Student Index" },
                values: new object[,]
                {
                    { 3, 1, null, new DateTime(2019, 10, 21, 0, 0, 0, 0, DateTimeKind.Local), "Kristel", null, "Madison", "Kristel.Madison@mail.com", "3121" },
                    { 1, 2, null, new DateTime(2018, 10, 21, 0, 0, 0, 0, DateTimeKind.Local), "Kassidy", null, "Trueman", "Kassidy.Trueman@mail.com", "3516" },
                    { 4, 3, null, new DateTime(2020, 10, 21, 0, 0, 0, 0, DateTimeKind.Local), "Lyndsey", null, "Albers", "Lyndsey.Albers@mail.com", "1415" },
                    { 5, 4, null, new DateTime(2018, 10, 21, 0, 0, 0, 0, DateTimeKind.Local), "Alishia", null, "Gabriels", "Alishia.Gabriels@mail.com", "3717" },
                    { 2, 5, null, new DateTime(2017, 10, 21, 0, 0, 0, 0, DateTimeKind.Local), "Christobel", null, "Bezuidenhout", "Christobel.Bezuidenhout@mail.com", "1241" }
                });

            migrationBuilder.InsertData(
                table: "Transcripts",
                columns: new[] { "Id", "ExamId", "Points", "StudentId" },
                values: new object[,]
                {
                    { 2, 2, 65m, 3 },
                    { 7, 3, 75.5m, 2 },
                    { 6, 1, 81m, 2 },
                    { 22, 2, 69m, 5 },
                    { 21, 5, 84m, 5 },
                    { 20, 6, 78m, 5 },
                    { 19, 3, 83m, 5 },
                    { 18, 6, 82m, 4 },
                    { 17, 5, 91m, 4 },
                    { 8, 6, 98m, 2 },
                    { 16, 4, 94m, 4 },
                    { 14, 2, 89m, 4 },
                    { 13, 1, 96m, 4 },
                    { 4, 2, 75m, 1 },
                    { 3, 5, 88m, 1 },
                    { 1, 1, 90m, 1 },
                    { 12, 6, 67m, 3 },
                    { 11, 1, 79m, 3 },
                    { 10, 2, 65m, 3 },
                    { 15, 3, 78m, 4 },
                    { 9, 5, 61m, 2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Transcripts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Transcripts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Transcripts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Transcripts",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Transcripts",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Transcripts",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Transcripts",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Transcripts",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Transcripts",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Transcripts",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Transcripts",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Transcripts",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Transcripts",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Transcripts",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Transcripts",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Transcripts",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Transcripts",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Transcripts",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Transcripts",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Transcripts",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Transcripts",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Exam",
                keyColumn: "ExamId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Exam",
                keyColumn: "ExamId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Exam",
                keyColumn: "ExamId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Exam",
                keyColumn: "ExamId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Exam",
                keyColumn: "ExamId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Exam",
                keyColumn: "ExamId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 5);
        }
    }
}
