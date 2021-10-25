using Microsoft.EntityFrameworkCore.Migrations;

namespace Board.Data.Migrations
{
    public partial class UpdateTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BoardId",
                table: "Task");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Task");

            migrationBuilder.DropColumn(
                name: "LastUpdatedBy",
                table: "Task");

            migrationBuilder.DropColumn(
                name: "SprintId",
                table: "Task");

            migrationBuilder.RenameColumn(
                name: "LastUpdatedDate",
                table: "Task",
                newName: "startDate");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "Task",
                newName: "endDate");

            migrationBuilder.AddColumn<string>(
                name: "taskDetails",
                table: "Task",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "taskName",
                table: "Task",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "taskDetails",
                table: "Task");

            migrationBuilder.DropColumn(
                name: "taskName",
                table: "Task");

            migrationBuilder.RenameColumn(
                name: "startDate",
                table: "Task",
                newName: "LastUpdatedDate");

            migrationBuilder.RenameColumn(
                name: "endDate",
                table: "Task",
                newName: "CreatedDate");

            migrationBuilder.AddColumn<int>(
                name: "BoardId",
                table: "Task",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                table: "Task",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LastUpdatedBy",
                table: "Task",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SprintId",
                table: "Task",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
