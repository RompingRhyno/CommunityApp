using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CommunityApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class M1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Provinces",
                columns: table => new
                {
                    ProvinceCode = table.Column<string>(type: "TEXT", maxLength: 2, nullable: false),
                    ProvinceName = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provinces", x => x.ProvinceCode);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    CityId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CityName = table.Column<string>(type: "TEXT", nullable: false),
                    Population = table.Column<int>(type: "INTEGER", nullable: false),
                    ProvinceCode = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.CityId);
                    table.ForeignKey(
                        name: "FK_Cities_Provinces_ProvinceCode",
                        column: x => x.ProvinceCode,
                        principalTable: "Provinces",
                        principalColumn: "ProvinceCode");
                });

            migrationBuilder.InsertData(
                table: "Provinces",
                columns: new[] { "ProvinceCode", "ProvinceName" },
                values: new object[,]
                {
                    { "AB", "Alberta" },
                    { "BC", "British Columbia" },
                    { "MB", "Manitoba" },
                    { "NB", "New Brunswick" },
                    { "NL", "Newfoundland and Labrador" },
                    { "NS", "Nova Scotia" },
                    { "NT", "Northwest Territories" },
                    { "NU", "Nunavut" },
                    { "ON", "Ontario" },
                    { "PE", "Prince Edward Island" },
                    { "QC", "Quebec" },
                    { "SK", "Saskatchewan" },
                    { "YT", "Yukon" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityId", "CityName", "Population", "ProvinceCode" },
                values: new object[,]
                {
                    { 1, "Calgary", 1336000, "AB" },
                    { 2, "Edmonton", 981000, "AB" },
                    { 3, "Red Deer", 100418, "AB" },
                    { 4, "Vancouver", 2463431, "BC" },
                    { 5, "Surrey", 517887, "BC" },
                    { 6, "Burnaby", 232755, "BC" },
                    { 7, "Richmond", 198309, "BC" },
                    { 8, "Winnipeg", 749534, "MB" },
                    { 9, "Brandon", 48859, "MB" },
                    { 10, "Thompson", 13008, "MB" },
                    { 11, "Saint John", 67575, "NB" },
                    { 12, "Moncton", 144810, "NB" },
                    { 13, "Fredericton", 58206, "NB" },
                    { 14, "Labrador City", 9445, "NL" },
                    { 15, "St. John's", 108860, "NL" },
                    { 16, "Corner Brook", 19504, "NL" },
                    { 17, "Halifax", 403131, "NS" },
                    { 18, "Sydney", 31686, "NS" },
                    { 19, "Truro", 12349, "NS" },
                    { 20, "Toronto", 2731571, "ON" },
                    { 21, "Ottawa", 934243, "ON" },
                    { 22, "Mississauga", 721599, "ON" },
                    { 23, "Charlettetown", 36847, "PE" },
                    { 24, "Souris", 1279, "PE" },
                    { 25, "Summerside", 14857, "PE" },
                    { 26, "Quebec City", 531902, "QC" },
                    { 27, "Montreal", 1704694, "QC" },
                    { 28, "Laval", 422993, "QC" },
                    { 29, "Saskatoon", 246376, "SK" },
                    { 30, "Regina", 215106, "SK" },
                    { 31, "Moose Jaw", 33877, "SK" },
                    { 32, "Yellowknife", 19569, "NT" },
                    { 33, "Inuvik", 3495, "NT" },
                    { 34, "Hay River", 3461, "NT" },
                    { 35, "Iqaluit", 6695, "NU" },
                    { 36, "Baker Lake", 2058, "NU" },
                    { 37, "Rankin Inlet", 2825, "NU" },
                    { 38, "Whitehorse", 25085, "YT" },
                    { 39, "Dawson City", 1319, "YT" },
                    { 40, "Watson Lake", 790, "YT" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cities_ProvinceCode",
                table: "Cities",
                column: "ProvinceCode");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Provinces");
        }
    }
}
