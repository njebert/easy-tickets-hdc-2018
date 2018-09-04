using Microsoft.EntityFrameworkCore.Migrations;

namespace easytickets.Migrations
{
    public partial class BaseLocations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "LocationID", "Capacity", "Name" },
                values: new object[,]
                {
                    { 1, 14620, "Pinnacle Bank Arena" },
                    { 2, 5500, "Pinewood Bowl Theater" },
                    { 3, 18100, "CHI Health Center Omaha" },
                    { 4, 2596, "Orpheum Theater" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "LocationID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "LocationID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "LocationID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "LocationID",
                keyValue: 4);
        }
    }
}
