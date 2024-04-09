using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Joomla.Migrations
{
    /// <inheritdoc />
    public partial class _03test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                defaultValue: new DateTime(2024, 4, 9, 5, 51, 22, 492, DateTimeKind.Utc).AddTicks(9764),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldDefaultValue: new DateTime(2024, 4, 8, 17, 42, 9, 247, DateTimeKind.Utc).AddTicks(4991));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { new Guid("b6d74e95-e620-4f6d-a825-24c98d328d7d"), null, "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("7898ec0d-de83-4282-b79d-ecf29c59420e"), 0, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "89c389ca-e86b-44de-8a15-419928b4041c", "admin@localhost", true, "Administrator", false, null, "ADMIN@LOCALHOST", "ADMIN@LOCALHOST", "AQAAAAIAAYagAAAAEIateCKnZYYHLFkpyU+h37Jn9rj/eFTLz3x/EsdUbgh3nMFdc9QhHNlR7pK8j8/Mmg==", null, false, "", false, "admin@localhost" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("b6d74e95-e620-4f6d-a825-24c98d328d7d"), new Guid("7898ec0d-de83-4282-b79d-ecf29c59420e") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("b6d74e95-e620-4f6d-a825-24c98d328d7d"), new Guid("7898ec0d-de83-4282-b79d-ecf29c59420e") });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("b6d74e95-e620-4f6d-a825-24c98d328d7d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7898ec0d-de83-4282-b79d-ecf29c59420e"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Articles",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 8, 17, 42, 9, 247, DateTimeKind.Utc).AddTicks(4991),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldDefaultValue: new DateTime(2024, 4, 9, 5, 51, 22, 492, DateTimeKind.Utc).AddTicks(9764));

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
    }
}
