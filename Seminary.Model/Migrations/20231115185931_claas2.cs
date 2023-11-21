using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Seminary.Model.Migrations
{
    /// <inheritdoc />
    public partial class claas2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Class_Teacher_TeacherId",
                table: "Class");

            migrationBuilder.DropIndex(
                name: "IX_Teacher_Subjectid",
                table: "Teacher");

            migrationBuilder.DropIndex(
                name: "IX_Class_TeacherId",
                table: "Class");

            migrationBuilder.DropColumn(
                name: "TeacherId",
                table: "Class");

            migrationBuilder.CreateIndex(
                name: "IX_Teacher_Subjectid",
                table: "Teacher",
                column: "Subjectid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Teacher_Subjectid",
                table: "Teacher");

            migrationBuilder.AddColumn<int>(
                name: "TeacherId",
                table: "Class",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Teacher_Subjectid",
                table: "Teacher",
                column: "Subjectid",
                unique: true,
                filter: "[Subjectid] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Class_TeacherId",
                table: "Class",
                column: "TeacherId");

            migrationBuilder.AddForeignKey(
                name: "FK_Class_Teacher_TeacherId",
                table: "Class",
                column: "TeacherId",
                principalTable: "Teacher",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }
    }
}
