using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Seminary.Model.Migrations
{
    /// <inheritdoc />
    public partial class collections : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Subject_Class_ClassId",
                table: "Subject");

            migrationBuilder.DropForeignKey(
                name: "FK_Teacher_Class_Subjectid",
                table: "Teacher");

            migrationBuilder.DropIndex(
                name: "IX_Subject_ClassId",
                table: "Subject");

            migrationBuilder.DropColumn(
                name: "ClassId",
                table: "Subject");

            migrationBuilder.DropColumn(
                name: "Age",
                table: "Student");

            migrationBuilder.RenameColumn(
                name: "Age",
                table: "Teacher",
                newName: "Phone");

            migrationBuilder.AlterColumn<int>(
                name: "Subjectid",
                table: "Teacher",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EMail",
                table: "Teacher",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TZ",
                table: "Teacher",
                type: "nvarchar(9)",
                maxLength: 9,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TZ",
                table: "Student",
                type: "nvarchar(9)",
                maxLength: 9,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TeacherId",
                table: "Class",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Teacher_Subject_Subjectid",
                table: "Teacher",
                column: "Subjectid",
                principalTable: "Subject",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Class_Teacher_TeacherId",
                table: "Class");

            migrationBuilder.DropForeignKey(
                name: "FK_Teacher_Subject_Subjectid",
                table: "Teacher");

            migrationBuilder.DropIndex(
                name: "IX_Class_TeacherId",
                table: "Class");

            migrationBuilder.DropColumn(
                name: "EMail",
                table: "Teacher");

            migrationBuilder.DropColumn(
                name: "TZ",
                table: "Teacher");

            migrationBuilder.DropColumn(
                name: "TZ",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "TeacherId",
                table: "Class");

            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "Teacher",
                newName: "Age");

            migrationBuilder.AlterColumn<int>(
                name: "Subjectid",
                table: "Teacher",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "ClassId",
                table: "Subject",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "Student",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Subject_ClassId",
                table: "Subject",
                column: "ClassId");

            migrationBuilder.AddForeignKey(
                name: "FK_Subject_Class_ClassId",
                table: "Subject",
                column: "ClassId",
                principalTable: "Class",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Teacher_Class_Subjectid",
                table: "Teacher",
                column: "Subjectid",
                principalTable: "Class",
                principalColumn: "Id");
        }
    }
}
