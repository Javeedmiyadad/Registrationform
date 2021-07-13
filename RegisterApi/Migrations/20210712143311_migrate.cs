using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Metadata;

namespace RegisterApi.Migrations
{
    public partial class migrate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "department",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    code = table.Column<string>(nullable: true),
                    deptName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_department", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "designation",
                columns: table => new
                {
                    desId = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(nullable: true),
                    departmentsid = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_designation", x => x.desId);
                    table.ForeignKey(
                        name: "FK_designation_department_departmentsid",
                        column: x => x.departmentsid,
                        principalTable: "department",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    userId = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    firstName = table.Column<string>(nullable: false),
                    lastName = table.Column<string>(nullable: false),
                    DOJ = table.Column<string>(nullable: true),
                    Age = table.Column<int>(nullable: false),
                    departmentsid = table.Column<int>(nullable: false),
                    designationdesId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.userId);
                    table.ForeignKey(
                        name: "FK_Users_department_departmentsid",
                        column: x => x.departmentsid,
                        principalTable: "department",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Users_designation_designationdesId",
                        column: x => x.designationdesId,
                        principalTable: "designation",
                        principalColumn: "desId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_designation_departmentsid",
                table: "designation",
                column: "departmentsid");

            migrationBuilder.CreateIndex(
                name: "IX_Users_departmentsid",
                table: "Users",
                column: "departmentsid");

            migrationBuilder.CreateIndex(
                name: "IX_Users_designationdesId",
                table: "Users",
                column: "designationdesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "designation");

            migrationBuilder.DropTable(
                name: "department");
        }
    }
}
