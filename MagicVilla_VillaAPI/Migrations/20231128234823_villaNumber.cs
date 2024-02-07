using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVillaVillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class villaNumber : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "villaNumber",
                columns: table => new
                {
                    villaNO = table.Column<int>(type: "int", nullable: false),
                    SpecialDetails = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_villaNumber", x => x.villaNO);
                });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 11, 29, 1, 48, 23, 826, DateTimeKind.Local).AddTicks(856), new DateTime(2023, 11, 28, 23, 48, 23, 826, DateTimeKind.Utc).AddTicks(984) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 11, 29, 1, 48, 23, 826, DateTimeKind.Local).AddTicks(986), new DateTime(2023, 11, 28, 23, 48, 23, 826, DateTimeKind.Utc).AddTicks(989) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 11, 29, 1, 48, 23, 826, DateTimeKind.Local).AddTicks(990), new DateTime(2023, 11, 28, 23, 48, 23, 826, DateTimeKind.Utc).AddTicks(992) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "villaNumber");

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 11, 24, 4, 56, 8, 960, DateTimeKind.Local).AddTicks(6237), new DateTime(2023, 11, 24, 2, 56, 8, 960, DateTimeKind.Utc).AddTicks(6283) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 11, 24, 4, 56, 8, 960, DateTimeKind.Local).AddTicks(6287), new DateTime(2023, 11, 24, 2, 56, 8, 960, DateTimeKind.Utc).AddTicks(6288) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 11, 24, 4, 56, 8, 960, DateTimeKind.Local).AddTicks(6290), new DateTime(2023, 11, 24, 2, 56, 8, 960, DateTimeKind.Utc).AddTicks(6291) });
        }
    }
}
