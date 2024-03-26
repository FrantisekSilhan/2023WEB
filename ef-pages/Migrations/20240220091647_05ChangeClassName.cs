using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ef_pages.Migrations
{
    /// <inheritdoc />
    public partial class _05ChangeClassName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Classes",
                newName: "ClassName");

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "TeacherId", "MentorId", "TeacherName" },
                values: new object[,]
                {
                    { new Guid("44f825b4-0b96-414d-84ea-9ecb6f1d16eb"), null, "Petr Mucha" },
                    { new Guid("9a96e698-196c-43f2-894e-f6a9bbd9f874"), null, "Jan Butanský" },
                    { new Guid("d41a5f46-1d95-44b8-8dc3-bc0d449329a2"), null, "Ozzy Matikář" }
                });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "StudentId", "ClassId", "StudentEmail", "StudentName" },
                values: new object[,]
                {
                    { new Guid("1b2db1ab-dffb-4c69-a96e-49ef3132c847"), 1, null, "Franta Vomáčka" },
                    { new Guid("4de0ce36-7fc4-4e67-b12e-173bcf47f262"), 1, null, "Alice" },
                    { new Guid("adf2d6e0-e958-416b-9f5f-4722ee4c3954"), 2, null, "Bob" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: new Guid("44f825b4-0b96-414d-84ea-9ecb6f1d16eb"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: new Guid("9a96e698-196c-43f2-894e-f6a9bbd9f874"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: new Guid("d41a5f46-1d95-44b8-8dc3-bc0d449329a2"));

            migrationBuilder.DeleteData(
                table: "students",
                keyColumn: "StudentId",
                keyValue: new Guid("1b2db1ab-dffb-4c69-a96e-49ef3132c847"));

            migrationBuilder.DeleteData(
                table: "students",
                keyColumn: "StudentId",
                keyValue: new Guid("4de0ce36-7fc4-4e67-b12e-173bcf47f262"));

            migrationBuilder.DeleteData(
                table: "students",
                keyColumn: "StudentId",
                keyValue: new Guid("adf2d6e0-e958-416b-9f5f-4722ee4c3954"));

            migrationBuilder.RenameColumn(
                name: "ClassName",
                table: "Classes",
                newName: "Name");

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
                table: "students",
                columns: new[] { "StudentId", "ClassId", "StudentEmail", "StudentName" },
                values: new object[,]
                {
                    { new Guid("3a36a73d-d445-407d-bc00-83817a7ea295"), 1, null, "Alice" },
                    { new Guid("41648691-07ef-470d-8ed3-1e15d51c4c14"), 1, null, "Franta Vomáčka" },
                    { new Guid("933f54b0-1e72-48a7-b5a4-9f6e9b9464a6"), 2, null, "Bob" }
                });
        }
    }
}
