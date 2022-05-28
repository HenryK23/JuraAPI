using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Data.Migrations
{
    public partial class TasknotNote : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Timestamp",
                table: "Notes",
                newName: "DueDate");

            migrationBuilder.RenameColumn(
                name: "Content",
                table: "Notes",
                newName: "Description");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DueDate",
                table: "Notes",
                newName: "Timestamp");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Notes",
                newName: "Content");
        }
    }
}
