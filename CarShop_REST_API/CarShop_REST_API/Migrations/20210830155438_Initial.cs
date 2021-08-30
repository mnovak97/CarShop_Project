using Microsoft.EntityFrameworkCore.Migrations;

namespace CarShop_REST_API.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Buyers",
                columns: table => new
                {
                    IDBuyer = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MobilePhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OIB = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Buyers", x => x.IDBuyer);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    IDItem = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.IDItem);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    IDUser = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Role = table.Column<int>(type: "int", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.IDUser);
                });

            migrationBuilder.CreateTable(
                name: "WorkOrders",
                columns: table => new
                {
                    IDWorkOrder = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number = table.Column<int>(type: "int", nullable: false),
                    Warranty = table.Column<bool>(type: "bit", nullable: false),
                    Done = table.Column<bool>(type: "bit", nullable: false),
                    TotalPrice = table.Column<double>(type: "float", nullable: false),
                    UserIDUser = table.Column<int>(type: "int", nullable: true),
                    BuyerIDBuyer = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkOrders", x => x.IDWorkOrder);
                    table.ForeignKey(
                        name: "FK_WorkOrders_Buyers_BuyerIDBuyer",
                        column: x => x.BuyerIDBuyer,
                        principalTable: "Buyers",
                        principalColumn: "IDBuyer",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WorkOrders_Users_UserIDUser",
                        column: x => x.UserIDUser,
                        principalTable: "Users",
                        principalColumn: "IDUser",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_WorkOrders_BuyerIDBuyer",
                table: "WorkOrders",
                column: "BuyerIDBuyer");

            migrationBuilder.CreateIndex(
                name: "IX_WorkOrders_UserIDUser",
                table: "WorkOrders",
                column: "UserIDUser");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItemWorkOrder");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "WorkOrders");

            migrationBuilder.DropTable(
                name: "Buyers");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
