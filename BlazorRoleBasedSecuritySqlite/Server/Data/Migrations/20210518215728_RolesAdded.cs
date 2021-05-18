using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorRoleBasedSecuritySqlite.Server.Data.Migrations
{
    public partial class RolesAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ae68b248-4d4f-44e8-a198-f497b3487c3a", "fbe6e591-45be-4b34-8a87-ec3aacd5fdce", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "04ba6cdb-75ab-4504-89fd-25af6a3a5461", "09cd73ea-1a71-4793-819a-4a5d1349b11b", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "04ba6cdb-75ab-4504-89fd-25af6a3a5461");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ae68b248-4d4f-44e8-a198-f497b3487c3a");
        }
    }
}
