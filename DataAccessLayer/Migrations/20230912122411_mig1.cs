using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Literatures",
                columns: table => new
                {
                    LiteratureID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LessonName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Exam1 = table.Column<double>(type: "float", nullable: false),
                    Exam2 = table.Column<double>(type: "float", nullable: false),
                    StdID = table.Column<int>(type: "int", nullable: false),
                    DepartmentID = table.Column<int>(type: "int", nullable: false)
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
                    LessonName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Exam1 = table.Column<double>(type: "float", nullable: false),
                    Exam2 = table.Column<double>(type: "float", nullable: false),
                    StdID = table.Column<int>(type: "int", nullable: false),
                    DepartmentID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mathses", x => x.MathsID);
                });

            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    DepartmentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MathsID = table.Column<int>(type: "int", nullable: false),
                    LiteratureID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.DepartmentID);
                    table.ForeignKey(
                        name: "FK_Department_Literatures_LiteratureID",
                        column: x => x.LiteratureID,
                        principalTable: "Literatures",
                        principalColumn: "LiteratureID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Department_Mathses_MathsID",
                        column: x => x.MathsID,
                        principalTable: "Mathses",
                        principalColumn: "MathsID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudentInfos",
                columns: table => new
                {
                    StdID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TC = table.Column<int>(type: "int", nullable: false),
                    StdName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StdSurname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StdNum = table.Column<int>(type: "int", nullable: false),
                    StdBirthDay = table.Column<int>(type: "int", nullable: false),
                    StdClass = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AbsentDay = table.Column<int>(type: "int", nullable: false),
                    MathsID = table.Column<int>(type: "int", nullable: false),
                    LiteratureID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentInfos", x => x.StdID);
                    table.ForeignKey(
                        name: "FK_StudentInfos_Literatures_LiteratureID",
                        column: x => x.LiteratureID,
                        principalTable: "Literatures",
                        principalColumn: "LiteratureID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentInfos_Mathses_MathsID",
                        column: x => x.MathsID,
                        principalTable: "Mathses",
                        principalColumn: "MathsID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Department_LiteratureID",
                table: "Department",
                column: "LiteratureID");

            migrationBuilder.CreateIndex(
                name: "IX_Department_MathsID",
                table: "Department",
                column: "MathsID");

            migrationBuilder.CreateIndex(
                name: "IX_StudentInfos_LiteratureID",
                table: "StudentInfos",
                column: "LiteratureID");

            migrationBuilder.CreateIndex(
                name: "IX_StudentInfos_MathsID",
                table: "StudentInfos",
                column: "MathsID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Department");

            migrationBuilder.DropTable(
                name: "StudentInfos");

            migrationBuilder.DropTable(
                name: "Literatures");

            migrationBuilder.DropTable(
                name: "Mathses");
        }
    }
}
