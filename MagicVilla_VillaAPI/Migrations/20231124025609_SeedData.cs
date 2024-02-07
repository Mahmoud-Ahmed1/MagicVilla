using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MagicVillaVillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "CreatedDate", "Details", "ImageUrl", "Name", "Occupancy", "Rate", "Sqft", "UpdateDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 24, 4, 56, 8, 960, DateTimeKind.Local).AddTicks(6237), "im negan", "", "Test", 5, 3.0, 4, new DateTime(2023, 11, 24, 2, 56, 8, 960, DateTimeKind.Utc).AddTicks(6283) },
                    { 2, new DateTime(2023, 11, 24, 4, 56, 8, 960, DateTimeKind.Local).AddTicks(6287), "im Mahmoud", "", "Testing", 3, 4.0, 5, new DateTime(2023, 11, 24, 2, 56, 8, 960, DateTimeKind.Utc).AddTicks(6288) },
                    { 3, new DateTime(2023, 11, 24, 4, 56, 8, 960, DateTimeKind.Local).AddTicks(6290), "negan", "", "software", 7, 9.0, 8, new DateTime(2023, 11, 24, 2, 56, 8, 960, DateTimeKind.Utc).AddTicks(6291) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
