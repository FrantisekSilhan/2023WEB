using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ef_pages.Migrations
{
    /// <inheritdoc />
    public partial class addmento : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "MentorId",
                table: "Teachers",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_MentorId",
                table: "Teachers",
                column: "MentorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Teachers_Teachers_MentorId",
                table: "Teachers",
                column: "MentorId",
                principalTable: "Teachers",
                principalColumn: "TeacherId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teachers_Teachers_MentorId",
                table: "Teachers");

            migrationBuilder.DropIndex(
                name: "IX_Teachers_MentorId",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "MentorId",
                table: "Teachers");
        }
    }
}
