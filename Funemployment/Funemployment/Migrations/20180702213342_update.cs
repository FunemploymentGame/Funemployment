using Microsoft.EntityFrameworkCore.Migrations;

namespace Funemployment.Migrations
{
    public partial class update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "QID",
                table: "AnswerTable",
                newName: "TQID");

            migrationBuilder.AddColumn<int>(
                name: "BQID",
                table: "AnswerTable",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BQID",
                table: "AnswerTable");

            migrationBuilder.RenameColumn(
                name: "TQID",
                table: "AnswerTable",
                newName: "QID");
        }
    }
}
