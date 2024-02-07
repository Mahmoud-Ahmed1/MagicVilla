using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVillaVillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class updateUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "AppUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "AppUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "AppUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 12, 6, 15, 57, 8, 475, DateTimeKind.Local).AddTicks(5084), new DateTime(2023, 12, 6, 13, 57, 8, 475, DateTimeKind.Utc).AddTicks(5149) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 12, 6, 15, 57, 8, 475, DateTimeKind.Local).AddTicks(5153), new DateTime(2023, 12, 6, 13, 57, 8, 475, DateTimeKind.Utc).AddTicks(5155) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 12, 6, 15, 57, 8, 475, DateTimeKind.Local).AddTicks(5158), new DateTime(2023, 12, 6, 13, 57, 8, 475, DateTimeKind.Utc).AddTicks(5161) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                table: "AppUsers");

            migrationBuilder.DropColumn(
                name: "Role",
                table: "AppUsers");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "AppUsers");

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
    }
}
