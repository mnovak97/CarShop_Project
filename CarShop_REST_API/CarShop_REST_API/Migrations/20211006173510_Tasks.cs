using Microsoft.EntityFrameworkCore.Migrations;

namespace CarShop_REST_API.Migrations
{
    public partial class Tasks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tasks",
                columns: table => new
                {
                    IDTask = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserIDUser = table.Column<int>(type: "int", nullable: true),
                    WorkOrderIDWorkOrder = table.Column<int>(type: "int", nullable: true),
                    Completed = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tasks", x => x.IDTask);
                    table.ForeignKey(
                        name: "FK_Tasks_Users_UserIDUser",
                        column: x => x.UserIDUser,
                        principalTable: "Users",
                        principalColumn: "IDUser",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tasks_WorkOrders_WorkOrderIDWorkOrder",
                        column: x => x.WorkOrderIDWorkOrder,
                        principalTable: "WorkOrders",
                        principalColumn: "IDWorkOrder",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_UserIDUser",
                table: "Tasks",
                column: "UserIDUser");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_WorkOrderIDWorkOrder",
                table: "Tasks",
                column: "WorkOrderIDWorkOrder");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tasks");
        }
    }
}
