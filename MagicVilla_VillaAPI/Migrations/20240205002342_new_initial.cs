using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVillaVillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class newinitial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2024, 2, 5, 2, 23, 42, 112, DateTimeKind.Local).AddTicks(2046), new DateTime(2024, 2, 5, 0, 23, 42, 112, DateTimeKind.Utc).AddTicks(2088) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2024, 2, 5, 2, 23, 42, 112, DateTimeKind.Local).AddTicks(2090), new DateTime(2024, 2, 5, 0, 23, 42, 112, DateTimeKind.Utc).AddTicks(2092) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2024, 2, 5, 2, 23, 42, 112, DateTimeKind.Local).AddTicks(2093), new DateTime(2024, 2, 5, 0, 23, 42, 112, DateTimeKind.Utc).AddTicks(2095) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2024, 1, 26, 2, 37, 35, 604, DateTimeKind.Local).AddTicks(6064), new DateTime(2024, 1, 26, 0, 37, 35, 604, DateTimeKind.Utc).AddTicks(6208) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2024, 1, 26, 2, 37, 35, 604, DateTimeKind.Local).AddTicks(6215), new DateTime(2024, 1, 26, 0, 37, 35, 604, DateTimeKind.Utc).AddTicks(6220) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2024, 1, 26, 2, 37, 35, 604, DateTimeKind.Local).AddTicks(6222), new DateTime(2024, 1, 26, 0, 37, 35, 604, DateTimeKind.Utc).AddTicks(6224) });
        }
    }
}
