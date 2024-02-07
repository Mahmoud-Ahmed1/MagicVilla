using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVillaVillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class addUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "villaNumber");

            migrationBuilder.CreateTable(
                name: "AppUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUsers", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 12, 6, 1, 5, 55, 411, DateTimeKind.Local).AddTicks(1387), new DateTime(2023, 12, 5, 23, 5, 55, 411, DateTimeKind.Utc).AddTicks(1428) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 12, 6, 1, 5, 55, 411, DateTimeKind.Local).AddTicks(1431), new DateTime(2023, 12, 5, 23, 5, 55, 411, DateTimeKind.Utc).AddTicks(1432) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 12, 6, 1, 5, 55, 411, DateTimeKind.Local).AddTicks(1433), new DateTime(2023, 12, 5, 23, 5, 55, 411, DateTimeKind.Utc).AddTicks(1435) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppUsers");

            migrationBuilder.CreateTable(
                name: "villaNumber",
                columns: table => new
                {
                    villaNO = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SpecialDetails = table.Column<int>(type: "int", nullable: false),
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
    }
}
