using Microsoft.EntityFrameworkCore.Migrations;

namespace Board.Data.Migrations
{
    public partial class DbUpdate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Type",
                table: "Task",
                newName: "type");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Task",
                newName: "status");

            migrationBuilder.RenameColumn(
                name: "AssignedTo",
                table: "Task",
                newName: "assignedTo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "type",
                table: "Task",
                newName: "Type");

            migrationBuilder.RenameColumn(
                name: "status",
                table: "Task",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "assignedTo",
                table: "Task",
                newName: "AssignedTo");
        }
    }
}
