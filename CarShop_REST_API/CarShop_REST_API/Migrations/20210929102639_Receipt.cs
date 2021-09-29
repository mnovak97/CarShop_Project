using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarShop_REST_API.Migrations
{
    public partial class Receipt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Receipts",
                columns: table => new
                {
                    IDReceipt = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateOfReceipt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalPrice = table.Column<double>(type: "float", nullable: false),
                    PaymentMethod = table.Column<int>(type: "int", nullable: false),
                    UserIDUser = table.Column<int>(type: "int", nullable: true),
                    BuyerIDBuyer = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Receipts", x => x.IDReceipt);
                    table.ForeignKey(
                        name: "FK_Receipts_Buyers_BuyerIDBuyer",
                        column: x => x.BuyerIDBuyer,
                        principalTable: "Buyers",
                        principalColumn: "IDBuyer",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Receipts_Users_UserIDUser",
                        column: x => x.UserIDUser,
                        principalTable: "Users",
                        principalColumn: "IDUser",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ReceiptWorkOrders",
                columns: table => new
                {
                    ReceiptID = table.Column<int>(type: "int", nullable: false),
                    WorkOrderID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReceiptWorkOrders", x => new { x.ReceiptID, x.WorkOrderID });
                    table.ForeignKey(
                        name: "FK_ReceiptWorkOrders_Receipts_ReceiptID",
                        column: x => x.ReceiptID,
                        principalTable: "Receipts",
                        principalColumn: "IDReceipt",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReceiptWorkOrders_WorkOrders_WorkOrderID",
                        column: x => x.WorkOrderID,
                        principalTable: "WorkOrders",
                        principalColumn: "IDWorkOrder",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Receipts_BuyerIDBuyer",
                table: "Receipts",
                column: "BuyerIDBuyer");

            migrationBuilder.CreateIndex(
                name: "IX_Receipts_UserIDUser",
                table: "Receipts",
                column: "UserIDUser");

            migrationBuilder.CreateIndex(
                name: "IX_ReceiptWorkOrders_WorkOrderID",
                table: "ReceiptWorkOrders",
                column: "WorkOrderID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReceiptWorkOrders");

            migrationBuilder.DropTable(
                name: "Receipts");
        }
    }
}
