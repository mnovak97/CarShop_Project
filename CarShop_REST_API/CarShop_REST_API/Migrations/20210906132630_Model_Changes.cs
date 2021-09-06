using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarShop_REST_API.Migrations
{
    public partial class Model_Changes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItemWorkOrder");

            migrationBuilder.AddColumn<string>(
                name: "CarType",
                table: "WorkOrders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Comment",
                table: "WorkOrders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfWorkOrder",
                table: "WorkOrders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "WorkOrders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "Km",
                table: "WorkOrders",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<int>(
                name: "ManufacturingYear",
                table: "WorkOrders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "RegistrationPlate",
                table: "WorkOrders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "WorkOrdersItems",
                columns: table => new
                {
                    WorkOrderID = table.Column<int>(type: "int", nullable: false),
                    ItemID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkOrdersItems", x => new { x.WorkOrderID, x.ItemID });
                    table.ForeignKey(
                        name: "FK_WorkOrdersItems_Items_ItemID",
                        column: x => x.ItemID,
                        principalTable: "Items",
                        principalColumn: "IDItem",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WorkOrdersItems_WorkOrders_WorkOrderID",
                        column: x => x.WorkOrderID,
                        principalTable: "WorkOrders",
                        principalColumn: "IDWorkOrder",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WorkOrdersItems_ItemID",
                table: "WorkOrdersItems",
                column: "ItemID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WorkOrdersItems");

            migrationBuilder.DropColumn(
                name: "CarType",
                table: "WorkOrders");

            migrationBuilder.DropColumn(
                name: "Comment",
                table: "WorkOrders");

            migrationBuilder.DropColumn(
                name: "DateOfWorkOrder",
                table: "WorkOrders");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "WorkOrders");

            migrationBuilder.DropColumn(
                name: "Km",
                table: "WorkOrders");

            migrationBuilder.DropColumn(
                name: "ManufacturingYear",
                table: "WorkOrders");

            migrationBuilder.DropColumn(
                name: "RegistrationPlate",
                table: "WorkOrders");

            migrationBuilder.CreateTable(
                name: "ItemWorkOrder",
                columns: table => new
                {
                    ItemsIDItem = table.Column<int>(type: "int", nullable: false),
                    WorkOrdersIDWorkOrder = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemWorkOrder", x => new { x.ItemsIDItem, x.WorkOrdersIDWorkOrder });
                    table.ForeignKey(
                        name: "FK_ItemWorkOrder_Items_ItemsIDItem",
                        column: x => x.ItemsIDItem,
                        principalTable: "Items",
                        principalColumn: "IDItem",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemWorkOrder_WorkOrders_WorkOrdersIDWorkOrder",
                        column: x => x.WorkOrdersIDWorkOrder,
                        principalTable: "WorkOrders",
                        principalColumn: "IDWorkOrder",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ItemWorkOrder_WorkOrdersIDWorkOrder",
                table: "ItemWorkOrder",
                column: "WorkOrdersIDWorkOrder");
        }
    }
}
