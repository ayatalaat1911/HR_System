using Microsoft.EntityFrameworkCore.Migrations;

namespace HR_System.Migrations
{
    public partial class AddJobHistoryRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobHistory_Employees_EmployeeId",
                table: "JobHistory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_JobHistory",
                table: "JobHistory");

            migrationBuilder.DropIndex(
                name: "IX_JobHistory_EmployeeId",
                table: "JobHistory");

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeId",
                table: "JobHistory",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_JobHistory",
                table: "JobHistory",
                columns: new[] { "EmployeeId", "StartDate" });

            migrationBuilder.AddForeignKey(
                name: "FK_JobHistory_Employees_EmployeeId",
                table: "JobHistory",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobHistory_Employees_EmployeeId",
                table: "JobHistory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_JobHistory",
                table: "JobHistory");

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeId",
                table: "JobHistory",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_JobHistory",
                table: "JobHistory",
                column: "StartDate");

            migrationBuilder.CreateIndex(
                name: "IX_JobHistory_EmployeeId",
                table: "JobHistory",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_JobHistory_Employees_EmployeeId",
                table: "JobHistory",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
