using Microsoft.EntityFrameworkCore.Migrations;

namespace easytickets.Migrations
{
    public partial class ShowActsToContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShowAct");

            migrationBuilder.CreateTable(
                name: "ShowActs",
                columns: table => new
                {
                    ShowID = table.Column<int>(nullable: false),
                    ActID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShowActs", x => new { x.ShowID, x.ActID });
                    table.ForeignKey(
                        name: "FK_ShowActs_Acts_ActID",
                        column: x => x.ActID,
                        principalTable: "Acts",
                        principalColumn: "ActID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShowActs_Shows_ShowID",
                        column: x => x.ShowID,
                        principalTable: "Shows",
                        principalColumn: "ShowID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ShowActs",
                columns: new[] { "ShowID", "ActID" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 16, 12 },
                    { 15, 11 },
                    { 14, 11 },
                    { 13, 11 },
                    { 12, 11 },
                    { 11, 11 },
                    { 10, 11 },
                    { 9, 10 },
                    { 8, 9 },
                    { 8, 8 },
                    { 7, 7 },
                    { 6, 6 },
                    { 5, 5 },
                    { 4, 4 },
                    { 4, 3 },
                    { 3, 2 },
                    { 2, 2 },
                    { 16, 13 },
                    { 17, 14 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ShowActs_ActID",
                table: "ShowActs",
                column: "ActID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShowActs");

            migrationBuilder.CreateTable(
                name: "ShowAct",
                columns: table => new
                {
                    ShowID = table.Column<int>(nullable: false),
                    ActID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShowAct", x => new { x.ShowID, x.ActID });
                    table.ForeignKey(
                        name: "FK_ShowAct_Acts_ActID",
                        column: x => x.ActID,
                        principalTable: "Acts",
                        principalColumn: "ActID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShowAct_Shows_ShowID",
                        column: x => x.ShowID,
                        principalTable: "Shows",
                        principalColumn: "ShowID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ShowAct",
                columns: new[] { "ShowID", "ActID" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 16, 12 },
                    { 15, 11 },
                    { 14, 11 },
                    { 13, 11 },
                    { 12, 11 },
                    { 11, 11 },
                    { 10, 11 },
                    { 9, 10 },
                    { 8, 9 },
                    { 8, 8 },
                    { 7, 7 },
                    { 6, 6 },
                    { 5, 5 },
                    { 4, 4 },
                    { 4, 3 },
                    { 3, 2 },
                    { 2, 2 },
                    { 16, 13 },
                    { 17, 14 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ShowAct_ActID",
                table: "ShowAct",
                column: "ActID");
        }
    }
}
