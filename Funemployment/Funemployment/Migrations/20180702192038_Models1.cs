using Microsoft.EntityFrameworkCore.Migrations;

namespace Funemployment.Migrations
{
    public partial class Models1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AnswersTable_PlayerTable_PlayerID",
                table: "AnswersTable");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AnswersTable",
                table: "AnswersTable");

            migrationBuilder.RenameTable(
                name: "AnswersTable",
                newName: "AnswerTable");

            migrationBuilder.RenameIndex(
                name: "IX_AnswersTable_PlayerID",
                table: "AnswerTable",
                newName: "IX_AnswerTable_PlayerID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AnswerTable",
                table: "AnswerTable",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_AnswerTable_PlayerTable_PlayerID",
                table: "AnswerTable",
                column: "PlayerID",
                principalTable: "PlayerTable",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AnswerTable_PlayerTable_PlayerID",
                table: "AnswerTable");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AnswerTable",
                table: "AnswerTable");

            migrationBuilder.RenameTable(
                name: "AnswerTable",
                newName: "AnswersTable");

            migrationBuilder.RenameIndex(
                name: "IX_AnswerTable_PlayerID",
                table: "AnswersTable",
                newName: "IX_AnswersTable_PlayerID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AnswersTable",
                table: "AnswersTable",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_AnswersTable_PlayerTable_PlayerID",
                table: "AnswersTable",
                column: "PlayerID",
                principalTable: "PlayerTable",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
