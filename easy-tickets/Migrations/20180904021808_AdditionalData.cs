using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace easytickets.Migrations
{
    public partial class AdditionalData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Acts",
                columns: new[] { "ActID", "Details", "Name" },
                values: new object[,]
                {
                    { 1, "Metal Royalty", "Metallica" },
                    { 2, "Live adaptation of popular kid's cartoon", "PAW Patrol" },
                    { 3, "Mainstream pop-punk rock", "Fallout Boy" },
                    { 4, "Radio rapper", "Machine Gun Kelley" },
                    { 5, "Jam band pioneer", "Beck" },
                    { 6, "Country legend", "Alan Jackson" },
                    { 7, "Power pop", "Justin Timberlake" },
                    { 8, "Pop Rock revival", "Panic! At the Disco" },
                    { 9, "Hardcore rock", "Two Feet" },
                    { 10, "Pop royalty", "Elton John" },
                    { 11, "Modern broadway", "The Play That Goes Wrong" },
                    { 12, "Modern Bluegrass", "Lake Street Dive" },
                    { 13, "Alternative", "Kalbells" },
                    { 14, "Funk Rock", "Here Come the Mummies!" }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "LocationID", "Capacity", "Name" },
                values: new object[] { 5, 470, "Slowdown" });

            migrationBuilder.InsertData(
                table: "Shows",
                columns: new[] { "ShowID", "Date", "LocationID", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2018, 9, 6, 16, 0, 0, 0, DateTimeKind.Unspecified), 1, "Metallica at PBA!" },
                    { 2, new DateTime(2018, 9, 22, 14, 0, 0, 0, DateTimeKind.Unspecified), 1, "PAW Patrol LIVE! Race to the Rescue" },
                    { 3, new DateTime(2018, 9, 23, 14, 0, 0, 0, DateTimeKind.Unspecified), 1, "PAW Patrol LIVE! Race to the Rescue" },
                    { 4, new DateTime(2018, 9, 6, 16, 0, 0, 0, DateTimeKind.Unspecified), 1, "Fallout Boy Mania Tour" },
                    { 5, new DateTime(2018, 9, 6, 19, 0, 0, 0, DateTimeKind.Unspecified), 2, "The Beck Live Experience" },
                    { 6, new DateTime(2018, 9, 21, 21, 0, 0, 0, DateTimeKind.Unspecified), 3, "Alan Jackson: Honky Tonk Highway Tour" },
                    { 7, new DateTime(2018, 12, 8, 21, 0, 0, 0, DateTimeKind.Unspecified), 3, "Justin Timberlake - The Man Of The Woods Tour" },
                    { 8, new DateTime(2019, 2, 1, 21, 0, 0, 0, DateTimeKind.Unspecified), 3, "Panic! At the Disco: Pray for the Wicked Tour" },
                    { 9, new DateTime(2019, 2, 12, 20, 0, 0, 0, DateTimeKind.Unspecified), 3, "Elton John: Farewell Yellow Brick Road" },
                    { 10, new DateTime(2018, 11, 1, 19, 30, 0, 0, DateTimeKind.Unspecified), 4, "The Play That Goes Wrong" },
                    { 11, new DateTime(2018, 11, 2, 19, 30, 0, 0, DateTimeKind.Unspecified), 4, "The Play That Goes Wrong" },
                    { 12, new DateTime(2018, 11, 3, 14, 0, 0, 0, DateTimeKind.Unspecified), 4, "The Play That Goes Wrong" },
                    { 13, new DateTime(2018, 11, 3, 19, 30, 0, 0, DateTimeKind.Unspecified), 4, "The Play That Goes Wrong" },
                    { 14, new DateTime(2018, 11, 4, 14, 0, 0, 0, DateTimeKind.Unspecified), 4, "The Play That Goes Wrong" },
                    { 15, new DateTime(2018, 11, 4, 19, 30, 0, 0, DateTimeKind.Unspecified), 4, "The Play That Goes Wrong" }
                });

            migrationBuilder.InsertData(
                table: "ShowAct",
                columns: new[] { "ShowID", "ActID" },
                values: new object[,]
                {
                    { 7, 7 },
                    { 13, 11 },
                    { 12, 11 },
                    { 11, 11 },
                    { 10, 11 },
                    { 9, 10 },
                    { 8, 9 },
                    { 8, 8 },
                    { 14, 11 },
                    { 15, 11 },
                    { 5, 5 },
                    { 4, 4 },
                    { 4, 3 },
                    { 3, 2 },
                    { 2, 2 },
                    { 1, 1 },
                    { 6, 6 }
                });

            migrationBuilder.InsertData(
                table: "Shows",
                columns: new[] { "ShowID", "Date", "LocationID", "Name" },
                values: new object[,]
                {
                    { 17, new DateTime(2018, 9, 13, 19, 0, 0, 0, DateTimeKind.Unspecified), 5, "Here Come the Mummies Spooktacular" },
                    { 16, new DateTime(2018, 9, 4, 19, 0, 0, 0, DateTimeKind.Unspecified), 5, "All Ages Tuesday" }
                });

            migrationBuilder.InsertData(
                table: "ShowAct",
                columns: new[] { "ShowID", "ActID" },
                values: new object[] { 16, 12 });

            migrationBuilder.InsertData(
                table: "ShowAct",
                columns: new[] { "ShowID", "ActID" },
                values: new object[] { 16, 13 });

            migrationBuilder.InsertData(
                table: "ShowAct",
                columns: new[] { "ShowID", "ActID" },
                values: new object[] { 17, 14 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ShowAct",
                keyColumns: new[] { "ShowID", "ActID" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "ShowAct",
                keyColumns: new[] { "ShowID", "ActID" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "ShowAct",
                keyColumns: new[] { "ShowID", "ActID" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "ShowAct",
                keyColumns: new[] { "ShowID", "ActID" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.DeleteData(
                table: "ShowAct",
                keyColumns: new[] { "ShowID", "ActID" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "ShowAct",
                keyColumns: new[] { "ShowID", "ActID" },
                keyValues: new object[] { 5, 5 });

            migrationBuilder.DeleteData(
                table: "ShowAct",
                keyColumns: new[] { "ShowID", "ActID" },
                keyValues: new object[] { 6, 6 });

            migrationBuilder.DeleteData(
                table: "ShowAct",
                keyColumns: new[] { "ShowID", "ActID" },
                keyValues: new object[] { 7, 7 });

            migrationBuilder.DeleteData(
                table: "ShowAct",
                keyColumns: new[] { "ShowID", "ActID" },
                keyValues: new object[] { 8, 8 });

            migrationBuilder.DeleteData(
                table: "ShowAct",
                keyColumns: new[] { "ShowID", "ActID" },
                keyValues: new object[] { 8, 9 });

            migrationBuilder.DeleteData(
                table: "ShowAct",
                keyColumns: new[] { "ShowID", "ActID" },
                keyValues: new object[] { 9, 10 });

            migrationBuilder.DeleteData(
                table: "ShowAct",
                keyColumns: new[] { "ShowID", "ActID" },
                keyValues: new object[] { 10, 11 });

            migrationBuilder.DeleteData(
                table: "ShowAct",
                keyColumns: new[] { "ShowID", "ActID" },
                keyValues: new object[] { 11, 11 });

            migrationBuilder.DeleteData(
                table: "ShowAct",
                keyColumns: new[] { "ShowID", "ActID" },
                keyValues: new object[] { 12, 11 });

            migrationBuilder.DeleteData(
                table: "ShowAct",
                keyColumns: new[] { "ShowID", "ActID" },
                keyValues: new object[] { 13, 11 });

            migrationBuilder.DeleteData(
                table: "ShowAct",
                keyColumns: new[] { "ShowID", "ActID" },
                keyValues: new object[] { 14, 11 });

            migrationBuilder.DeleteData(
                table: "ShowAct",
                keyColumns: new[] { "ShowID", "ActID" },
                keyValues: new object[] { 15, 11 });

            migrationBuilder.DeleteData(
                table: "ShowAct",
                keyColumns: new[] { "ShowID", "ActID" },
                keyValues: new object[] { 16, 12 });

            migrationBuilder.DeleteData(
                table: "ShowAct",
                keyColumns: new[] { "ShowID", "ActID" },
                keyValues: new object[] { 16, 13 });

            migrationBuilder.DeleteData(
                table: "ShowAct",
                keyColumns: new[] { "ShowID", "ActID" },
                keyValues: new object[] { 17, 14 });

            migrationBuilder.DeleteData(
                table: "Acts",
                keyColumn: "ActID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Acts",
                keyColumn: "ActID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Acts",
                keyColumn: "ActID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Acts",
                keyColumn: "ActID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Acts",
                keyColumn: "ActID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Acts",
                keyColumn: "ActID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Acts",
                keyColumn: "ActID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Acts",
                keyColumn: "ActID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Acts",
                keyColumn: "ActID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Acts",
                keyColumn: "ActID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Acts",
                keyColumn: "ActID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Acts",
                keyColumn: "ActID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Acts",
                keyColumn: "ActID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Acts",
                keyColumn: "ActID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "ShowID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "ShowID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "ShowID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "ShowID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "ShowID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "ShowID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "ShowID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "ShowID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "ShowID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "ShowID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "ShowID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "ShowID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "ShowID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "ShowID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "ShowID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "ShowID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "ShowID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "LocationID",
                keyValue: 5);
        }
    }
}
