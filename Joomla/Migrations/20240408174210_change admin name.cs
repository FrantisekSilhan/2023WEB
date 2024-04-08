using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Joomla.Migrations
{
    /// <inheritdoc />
    public partial class changeadminname : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("3ffe167b-82a2-4186-be80-c08961a8fc71"), new Guid("7f01ebb6-0c1a-4de7-b683-f6b4986e416c") });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("3ffe167b-82a2-4186-be80-c08961a8fc71"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7f01ebb6-0c1a-4de7-b683-f6b4986e416c"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Articles",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 8, 17, 42, 9, 247, DateTimeKind.Utc).AddTicks(4991),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldDefaultValue: new DateTime(2024, 3, 26, 9, 11, 52, 631, DateTimeKind.Utc).AddTicks(3643));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { new Guid("0e639a83-918f-45d2-b104-3662a29662a6"), null, "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("68de6de6-ffa4-4084-aac7-a98ed5a43d34"), 0, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "fd71e082-a80d-49a4-ae44-279f02e51def", "admin@localhost", true, "Administrator", false, null, "ADMIN@LOCALHOST", "ADMIN@LOCALHOST", "AQAAAAIAAYagAAAAEB/HuoKi9u+ZhPrPmfXEdW3lut9RpwWIctpD78aqZM45L+V+/qQXH/o+9M+k6tJl6A==", null, false, "", false, "admin@localhost" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("0e639a83-918f-45d2-b104-3662a29662a6"), new Guid("68de6de6-ffa4-4084-aac7-a98ed5a43d34") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("0e639a83-918f-45d2-b104-3662a29662a6"), new Guid("68de6de6-ffa4-4084-aac7-a98ed5a43d34") });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("0e639a83-918f-45d2-b104-3662a29662a6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("68de6de6-ffa4-4084-aac7-a98ed5a43d34"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Articles",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 26, 9, 11, 52, 631, DateTimeKind.Utc).AddTicks(3643),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldDefaultValue: new DateTime(2024, 4, 8, 17, 42, 9, 247, DateTimeKind.Utc).AddTicks(4991));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { new Guid("3ffe167b-82a2-4186-be80-c08961a8fc71"), null, "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("7f01ebb6-0c1a-4de7-b683-f6b4986e416c"), 0, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "be28ee2f-b5f9-4bfc-ae60-f4707ee8bc9b", "admin@localhost", true, "Administrator", false, null, "ADMIN@LOCALHOST", "ADMIN", "AQAAAAIAAYagAAAAEFMsNu+FZBDl49iZgJCb5a1WzgUzjIXW5LmHmI6BWjatnC89Dsb3tN9glE5r5VjRZA==", null, false, "", false, "admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("3ffe167b-82a2-4186-be80-c08961a8fc71"), new Guid("7f01ebb6-0c1a-4de7-b683-f6b4986e416c") });
        }
    }
}
