using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ef_pages.Migrations
{
    /// <inheritdoc />
    public partial class _03nton : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ClassSubject",
                columns: table => new
                {
                    Classes2ClassId = table.Column<int>(type: "INTEGER", nullable: false),
                    Subjects2SubjectId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassSubject", x => new { x.Classes2ClassId, x.Subjects2SubjectId });
                    table.ForeignKey(
                        name: "FK_ClassSubject_Classes_Classes2ClassId",
                        column: x => x.Classes2ClassId,
                        principalTable: "Classes",
                        principalColumn: "ClassId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClassSubject_subjects_Subjects2SubjectId",
                        column: x => x.Subjects2SubjectId,
                        principalTable: "subjects",
                        principalColumn: "SubjectId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClassSubject_Subjects2SubjectId",
                table: "ClassSubject",
                column: "Subjects2SubjectId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClassSubject");
        }
    }
}
