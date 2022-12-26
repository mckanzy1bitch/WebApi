using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LRWEBAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2097f0c6-6d4b-4364-864b-d672a2586596");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a5323928-a935-4881-8e8e-10eac4269866");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "73cb0ed2-1d5c-430e-954d-517c8770f34a", "3432a4c5-72c4-431c-bba6-2c1d1b4ddf58", "Manager", "MANAGER" },
                    { "cf82b956-7848-42db-9b80-33be46fe67b0", "cba37443-6d26-4634-9c0d-f276b261388c", "Administrator", "ADMINISTRATOR" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73cb0ed2-1d5c-430e-954d-517c8770f34a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cf82b956-7848-42db-9b80-33be46fe67b0");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2097f0c6-6d4b-4364-864b-d672a2586596", "da193b8d-f358-4a4a-988d-6ea2a31e5563", "Administrator", "ADMINISTRATOR" },
                    { "a5323928-a935-4881-8e8e-10eac4269866", "ef7b5f3b-0951-492a-8e65-f876f7677c27", "Manager", "MANAGER" }
                });
        }
    }
}
