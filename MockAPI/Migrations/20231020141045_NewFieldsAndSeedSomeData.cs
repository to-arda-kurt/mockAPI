using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MockAPI.Migrations
{
    /// <inheritdoc />
    public partial class NewFieldsAndSeedSomeData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Houses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Postcode",
                table: "Houses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name", "ShortName" },
                values: new object[,]
                {
                    { 1, "United Kingdom", "UK" },
                    { 2, "Wales", "WAL" },
                    { 3, "Scotland", "SCO" },
                    { 4, "England", "ENG" }
                });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Address", "CountryId", "Description", "Name", "Postcode", "Rating" },
                values: new object[,]
                {
                    { 1, "Chelmsford, Essex", 4, "From the outside this house looks gorgeous. It has been built with wheat colored bricks and has sandstone decorations. Small, octagon windows let in plenty of light and have been added to the house in a very asymmetric way.", "3 Bedroom Detached House", "CM2 1AA", 4.5 },
                    { 2, "London Road, Cardiff", 2, "The house is equipped with an average kitchen and one large bathroom, it also has a comfortable living room, two bedrooms, a large dining room, a bar and a snug basement.", "3 Bedroom State House", "CA2 9KK", 4.2000000000000002 },
                    { 3, "Old Town, Edinburgh", 3, "The roof is high and v-shaped and is covered with wood shingles. One large chimney sits at the side of the house. A few round, small windows let in enough light to the rooms below the roof.\nThe house itself is surrounded by paved ground, with various party spots, like a fancy barbeque and a firepit.\n", "2 Bedroom City Flat", "ED3 2HQ", 4.9000000000000004 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Houses");

            migrationBuilder.DropColumn(
                name: "Postcode",
                table: "Houses");
        }
    }
}
