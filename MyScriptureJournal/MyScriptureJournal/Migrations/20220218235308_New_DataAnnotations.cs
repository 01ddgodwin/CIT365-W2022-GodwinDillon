using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyScriptureJournal.Migrations
{
    public partial class New_DataAnnotations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Book",
                table: "Scripture",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Chapter",
                table: "Scripture",
                type: "int()",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Note",
                table: "Scripture",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Verse",
                table: "Scripture",
                type: "int()",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Book",
                table: "Scripture");

            migrationBuilder.DropColumn(
                name: "Chapter",
                table: "Scripture");

            migrationBuilder.DropColumn(
                name: "Note",
                table: "Scripture");

            migrationBuilder.DropColumn(
                name: "Verse",
                table: "Scripture");
        }
    }
}
