using Microsoft.EntityFrameworkCore.Migrations;

namespace CarShop_REST_API.Migrations
{
    public partial class PickUpUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserIDUserMobile",
                table: "PickUps",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PickUps_UserIDUserMobile",
                table: "PickUps",
                column: "UserIDUserMobile");

            migrationBuilder.AddForeignKey(
                name: "FK_PickUps_UsersMobile_UserIDUserMobile",
                table: "PickUps",
                column: "UserIDUserMobile",
                principalTable: "UsersMobile",
                principalColumn: "IDUserMobile",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PickUps_UsersMobile_UserIDUserMobile",
                table: "PickUps");

            migrationBuilder.DropIndex(
                name: "IX_PickUps_UserIDUserMobile",
                table: "PickUps");

            migrationBuilder.DropColumn(
                name: "UserIDUserMobile",
                table: "PickUps");
        }
    }
}
