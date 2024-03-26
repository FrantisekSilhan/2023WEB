using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ef_pages.Migrations
{
    /// <inheritdoc />
    public partial class _04Data : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "ClassId", "Name" },
                values: new object[,]
                {
                    { 1, "P3A" },
                    { 2, "P4" }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "TeacherId", "MentorId", "TeacherName" },
                values: new object[,]
                {
                    { new Guid("0c7d4707-819f-4a46-8d99-df9731b4e49f"), null, "Petr Mucha" },
                    { new Guid("53eb8a47-4f23-46af-9d53-0ec08ea12c2f"), null, "Jan Butanský" },
                    { new Guid("b8f4a96b-e707-43de-ab40-12f0d8d9e1d5"), null, "Ozzy Matikář" }
                });

            migrationBuilder.InsertData(
                table: "subjects",
                columns: new[] { "SubjectId", "SubjectName", "SubjectShortName" },
                values: new object[,]
                {
                    { 1, "Matematika", "MAT" },
                    { 2, "Angličtina", "ANJ" },
                    { 3, "Webové aplikace", "WEB" },
                    { 4, "Programování", "PRG" }
                });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "StudentId", "ClassId", "StudentEmail", "StudentName" },
                values: new object[,]
                {
                    { new Guid("3a36a73d-d445-407d-bc00-83817a7ea295"), 1, null, "Alice" },
                    { new Guid("41648691-07ef-470d-8ed3-1e15d51c4c14"), 1, null, "Franta Vomáčka" },
                    { new Guid("933f54b0-1e72-48a7-b5a4-9f6e9b9464a6"), 2, null, "Bob" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: new Guid("0c7d4707-819f-4a46-8d99-df9731b4e49f"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: new Guid("53eb8a47-4f23-46af-9d53-0ec08ea12c2f"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: new Guid("b8f4a96b-e707-43de-ab40-12f0d8d9e1d5"));

            migrationBuilder.DeleteData(
                table: "students",
                keyColumn: "StudentId",
                keyValue: new Guid("3a36a73d-d445-407d-bc00-83817a7ea295"));

            migrationBuilder.DeleteData(
                table: "students",
                keyColumn: "StudentId",
                keyValue: new Guid("41648691-07ef-470d-8ed3-1e15d51c4c14"));

            migrationBuilder.DeleteData(
                table: "students",
                keyColumn: "StudentId",
                keyValue: new Guid("933f54b0-1e72-48a7-b5a4-9f6e9b9464a6"));

            migrationBuilder.DeleteData(
                table: "subjects",
                keyColumn: "SubjectId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "subjects",
                keyColumn: "SubjectId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "subjects",
                keyColumn: "SubjectId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "subjects",
                keyColumn: "SubjectId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ClassId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ClassId",
                keyValue: 2);
        }
    }
}
