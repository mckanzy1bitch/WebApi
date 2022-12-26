using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LRWEBAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddedRolesToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "1536d00e-9fe6-43ed-ae6a-976b0031aec4", "87ed08ab-6ec0-478e-9fb4-fb066085cf58", "Administrator", "ADMINISTRATOR" },
                    { "293a39d5-fe71-449a-97bb-e7e53dd1296f", "c9b7b5e3-3990-4a7f-a505-d577c496c31a", "Manager", "MANAGER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1536d00e-9fe6-43ed-ae6a-976b0031aec4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "293a39d5-fe71-449a-97bb-e7e53dd1296f");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "73cb0ed2-1d5c-430e-954d-517c8770f34a", "3432a4c5-72c4-431c-bba6-2c1d1b4ddf58", "Manager", "MANAGER" },
                    { "cf82b956-7848-42db-9b80-33be46fe67b0", "cba37443-6d26-4634-9c0d-f276b261388c", "Administrator", "ADMINISTRATOR" }
                });
        }
    }
}
