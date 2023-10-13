using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class changedb3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Department_Literatures_LiteratureID",
                table: "Department");

            migrationBuilder.DropForeignKey(
                name: "FK_Department_Mathses_MathsID",
                table: "Department");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentInfos_Literatures_LiteratureID",
                table: "StudentInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentInfos_Mathses_MathsID",
                table: "StudentInfos");

            migrationBuilder.DropTable(
                name: "Literatures");

            migrationBuilder.DropTable(
                name: "Mathses");

            migrationBuilder.DropIndex(
                name: "IX_StudentInfos_LiteratureID",
                table: "StudentInfos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Department",
                table: "Department");

            migrationBuilder.DropIndex(
                name: "IX_Department_LiteratureID",
                table: "Department");

            migrationBuilder.DropIndex(
                name: "IX_Department_MathsID",
                table: "Department");

            migrationBuilder.DropColumn(
                name: "LiteratureID",
                table: "StudentInfos");

            migrationBuilder.DropColumn(
                name: "LiteratureID",
                table: "Department");

            migrationBuilder.DropColumn(
                name: "MathsID",
                table: "Department");

            migrationBuilder.RenameTable(
                name: "Department",
                newName: "Departments");

            migrationBuilder.RenameColumn(
                name: "MathsID",
                table: "StudentInfos",
                newName: "MathsId");

            migrationBuilder.RenameIndex(
                name: "IX_StudentInfos_MathsID",
                table: "StudentInfos",
                newName: "IX_StudentInfos_MathsId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Departments",
                table: "Departments",
                column: "DepartmentID");

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Exam1 = table.Column<double>(type: "float", nullable: false),
                    Exam2 = table.Column<double>(type: "float", nullable: false),
                    StdID = table.Column<int>(type: "int", nullable: false),
                    DepartmentID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CoursesDepartment",
                columns: table => new
                {
                    CoursesId = table.Column<int>(type: "int", nullable: false),
                    DepartmentsDepartmentID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoursesDepartment", x => new { x.CoursesId, x.DepartmentsDepartmentID });
                    table.ForeignKey(
                        name: "FK_CoursesDepartment_Courses_CoursesId",
                        column: x => x.CoursesId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CoursesDepartment_Departments_DepartmentsDepartmentID",
                        column: x => x.DepartmentsDepartmentID,
                        principalTable: "Departments",
                        principalColumn: "DepartmentID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CoursesDepartment_DepartmentsDepartmentID",
                table: "CoursesDepartment",
                column: "DepartmentsDepartmentID");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentInfos_Courses_MathsId",
                table: "StudentInfos",
                column: "MathsId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentInfos_Courses_MathsId",
                table: "StudentInfos");

            migrationBuilder.DropTable(
                name: "CoursesDepartment");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Departments",
                table: "Departments");

            migrationBuilder.RenameTable(
                name: "Departments",
                newName: "Department");

            migrationBuilder.RenameColumn(
                name: "MathsId",
                table: "StudentInfos",
                newName: "MathsID");

            migrationBuilder.RenameIndex(
                name: "IX_StudentInfos_MathsId",
                table: "StudentInfos",
                newName: "IX_StudentInfos_MathsID");

            migrationBuilder.AddColumn<int>(
                name: "LiteratureID",
                table: "StudentInfos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LiteratureID",
                table: "Department",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MathsID",
                table: "Department",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Department",
                table: "Department",
                column: "DepartmentID");

            migrationBuilder.CreateTable(
                name: "Literatures",
                columns: table => new
                {
                    LiteratureID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentID = table.Column<int>(type: "int", nullable: false),
                    Exam1 = table.Column<double>(type: "float", nullable: false),
                    Exam2 = table.Column<double>(type: "float", nullable: false),
                    LessonName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StdID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Literatures", x => x.LiteratureID);
                });

            migrationBuilder.CreateTable(
                name: "Mathses",
                columns: table => new
                {
                    MathsID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentID = table.Column<int>(type: "int", nullable: false),
                    Exam1 = table.Column<double>(type: "float", nullable: false),
                    Exam2 = table.Column<double>(type: "float", nullable: false),
                    LessonName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StdID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mathses", x => x.MathsID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StudentInfos_LiteratureID",
                table: "StudentInfos",
                column: "LiteratureID");

            migrationBuilder.CreateIndex(
                name: "IX_Department_LiteratureID",
                table: "Department",
                column: "LiteratureID");

            migrationBuilder.CreateIndex(
                name: "IX_Department_MathsID",
                table: "Department",
                column: "MathsID");

            migrationBuilder.AddForeignKey(
                name: "FK_Department_Literatures_LiteratureID",
                table: "Department",
                column: "LiteratureID",
                principalTable: "Literatures",
                principalColumn: "LiteratureID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Department_Mathses_MathsID",
                table: "Department",
                column: "MathsID",
                principalTable: "Mathses",
                principalColumn: "MathsID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentInfos_Literatures_LiteratureID",
                table: "StudentInfos",
                column: "LiteratureID",
                principalTable: "Literatures",
                principalColumn: "LiteratureID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentInfos_Mathses_MathsID",
                table: "StudentInfos",
                column: "MathsID",
                principalTable: "Mathses",
                principalColumn: "MathsID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
