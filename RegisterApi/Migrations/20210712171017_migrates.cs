using Microsoft.EntityFrameworkCore.Migrations;

namespace RegisterApi.Migrations
{
    public partial class migrates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_department_departmentsid",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_designation_designationdesId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_departmentsid",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_designationdesId",
                table: "Users");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Users_departmentsid",
                table: "Users",
                column: "departmentsid");

            migrationBuilder.CreateIndex(
                name: "IX_Users_designationdesId",
                table: "Users",
                column: "designationdesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_department_departmentsid",
                table: "Users",
                column: "departmentsid",
                principalTable: "department",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_designation_designationdesId",
                table: "Users",
                column: "designationdesId",
                principalTable: "designation",
                principalColumn: "desId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
