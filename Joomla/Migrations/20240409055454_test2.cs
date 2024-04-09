using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Joomla.Migrations
{
    /// <inheritdoc />
    public partial class test2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("bc91f436-2970-487e-877d-1b801a84f609"), new Guid("94923dbb-0c62-41fe-802d-5e24f7e26d7c") });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("bc91f436-2970-487e-877d-1b801a84f609"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("94923dbb-0c62-41fe-802d-5e24f7e26d7c"));

            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "Users",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<DateTime>(
                name: "BirthDate",
                table: "Users",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Articles",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 9, 5, 54, 52, 981, DateTimeKind.Utc).AddTicks(885),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldDefaultValue: new DateTime(2024, 4, 9, 5, 53, 4, 939, DateTimeKind.Utc).AddTicks(3000));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { new Guid("ec2c3176-d22d-4647-93b4-daecdd01f5ff"), null, "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("e359a0b0-2ab3-4a81-85a9-dc3ac3a52f5c"), 0, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "c60a3790-aaf1-432f-ae25-365dbf3cabe3", "admin@localhost", true, "Administrator", false, null, "ADMIN@LOCALHOST", "ADMIN@LOCALHOST", "AQAAAAIAAYagAAAAEJZbpEhy3qZRmL5CCKtqZspM+BENDU5B3AmWjIHNXffMEE4+7eyIR/gH54/BqGJiNA==", null, false, "", false, "admin@localhost" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("ec2c3176-d22d-4647-93b4-daecdd01f5ff"), new Guid("e359a0b0-2ab3-4a81-85a9-dc3ac3a52f5c") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("ec2c3176-d22d-4647-93b4-daecdd01f5ff"), new Guid("e359a0b0-2ab3-4a81-85a9-dc3ac3a52f5c") });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("ec2c3176-d22d-4647-93b4-daecdd01f5ff"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e359a0b0-2ab3-4a81-85a9-dc3ac3a52f5c"));

            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "Users",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "BirthDate",
                table: "Users",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Articles",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 9, 5, 53, 4, 939, DateTimeKind.Utc).AddTicks(3000),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldDefaultValue: new DateTime(2024, 4, 9, 5, 54, 52, 981, DateTimeKind.Utc).AddTicks(885));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { new Guid("bc91f436-2970-487e-877d-1b801a84f609"), null, "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("94923dbb-0c62-41fe-802d-5e24f7e26d7c"), 0, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "100510fb-6c2e-4c90-99eb-8e7dbf81cefa", "admin@localhost", true, "Administrator", false, null, "ADMIN@LOCALHOST", "ADMIN@LOCALHOST", "AQAAAAIAAYagAAAAEHUAOuEWEiuS/qD0HfTwHI8IY0W8yFRKmzICF+1b7xHiX5jmXmvva3RU2Zajqb8cDQ==", null, false, "", false, "admin@localhost" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("bc91f436-2970-487e-877d-1b801a84f609"), new Guid("94923dbb-0c62-41fe-802d-5e24f7e26d7c") });
        }
    }
}
