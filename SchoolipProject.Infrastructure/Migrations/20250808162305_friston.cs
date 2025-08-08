using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolipProject.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class friston : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DepartmentSubjects_Depatrations_DepartmentId",
                table: "DepartmentSubjects");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Depatrations_department_id",
                table: "Students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Depatrations",
                table: "Depatrations");

            migrationBuilder.RenameTable(
                name: "Depatrations",
                newName: "Depatrment");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Depatrment",
                table: "Depatrment",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_DepartmentSubjects_Depatrment_DepartmentId",
                table: "DepartmentSubjects",
                column: "DepartmentId",
                principalTable: "Depatrment",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Depatrment_department_id",
                table: "Students",
                column: "department_id",
                principalTable: "Depatrment",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DepartmentSubjects_Depatrment_DepartmentId",
                table: "DepartmentSubjects");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Depatrment_department_id",
                table: "Students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Depatrment",
                table: "Depatrment");

            migrationBuilder.RenameTable(
                name: "Depatrment",
                newName: "Depatrations");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Depatrations",
                table: "Depatrations",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_DepartmentSubjects_Depatrations_DepartmentId",
                table: "DepartmentSubjects",
                column: "DepartmentId",
                principalTable: "Depatrations",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Depatrations_department_id",
                table: "Students",
                column: "department_id",
                principalTable: "Depatrations",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
