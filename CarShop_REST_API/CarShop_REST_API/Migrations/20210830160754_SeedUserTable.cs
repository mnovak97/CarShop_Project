using Microsoft.EntityFrameworkCore.Migrations;

namespace CarShop_REST_API.Migrations
{
    public partial class SeedUserTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "IDUser", "Email", "Password", "Role", "Username" },
                values: new object[] { 1, "ipad3monkey@gmail.com", "martin123", 0, "MartyParty97" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "IDUser",
                keyValue: 1);
        }
    }
}
