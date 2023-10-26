using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MockAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultUserRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "47d8a131-9482-46fd-a0ec-2a18e32bac64", "fa4f4a4b-5179-4f03-be40-e51c0c5d05a0", "Admin", "ADMIN" },
                    { "9af204ba-4d28-4229-a623-f572395988ee", "f3dde67e-94e8-42e0-80a3-912d0e88b95b", "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "47d8a131-9482-46fd-a0ec-2a18e32bac64");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9af204ba-4d28-4229-a623-f572395988ee");
        }
    }
}
