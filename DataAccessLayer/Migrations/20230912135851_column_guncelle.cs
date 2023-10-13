using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class column_guncelle : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentInfos_Courses_MathsId",
                table: "StudentInfos");

            migrationBuilder.DropIndex(
                name: "IX_StudentInfos_MathsId",
                table: "StudentInfos");

            migrationBuilder.DropColumn(
                name: "MathsId",
                table: "StudentInfos");

            migrationBuilder.AddColumn<int>(
                name: "CoursesId",
                table: "StudentInfos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_StudentInfos_CoursesId",
                table: "StudentInfos",
                column: "CoursesId");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentInfos_Courses_CoursesId",
                table: "StudentInfos",
                column: "CoursesId",
                principalTable: "Courses",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentInfos_Courses_CoursesId",
                table: "StudentInfos");

            migrationBuilder.DropIndex(
                name: "IX_StudentInfos_CoursesId",
                table: "StudentInfos");

            migrationBuilder.DropColumn(
                name: "CoursesId",
                table: "StudentInfos");

            migrationBuilder.AddColumn<int>(
                name: "MathsId",
                table: "StudentInfos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_StudentInfos_MathsId",
                table: "StudentInfos",
                column: "MathsId");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentInfos_Courses_MathsId",
                table: "StudentInfos",
                column: "MathsId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
