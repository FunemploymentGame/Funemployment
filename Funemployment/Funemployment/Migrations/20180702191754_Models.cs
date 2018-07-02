using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Funemployment.Migrations
{
    public partial class Models : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PlayerTable",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    About = table.Column<string>(nullable: true),
                    Points = table.Column<int>(nullable: false),
                    Location = table.Column<string>(nullable: true),
                    Username = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerTable", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "AnswersTable",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    QID = table.Column<int>(nullable: false),
                    PID = table.Column<int>(nullable: false),
                    Content = table.Column<string>(nullable: true),
                    PlayerID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnswersTable", x => x.ID);
                    table.ForeignKey(
                        name: "FK_AnswersTable_PlayerTable_PlayerID",
                        column: x => x.PlayerID,
                        principalTable: "PlayerTable",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AnswersTable_PlayerID",
                table: "AnswersTable",
                column: "PlayerID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnswersTable");

            migrationBuilder.DropTable(
                name: "PlayerTable");
        }
    }
}
