using Microsoft.EntityFrameworkCore.Migrations;

namespace CarShop_REST_API.Migrations
{
    public partial class AlterUserSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "IDUser", "Email", "Password", "Role", "Username" },
                values: new object[] { 2, "marko@gmail.com", "marko123", 1, "Marko" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "IDUser",
                keyValue: 2);
        }
    }
}
