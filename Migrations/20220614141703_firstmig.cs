using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DB3GP.Migrations
{
    public partial class firstmig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Item",
                columns: table => new
                {
                    ItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Serial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ItemType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ItemName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ItemStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    UnitPrice = table.Column<int>(type: "int", nullable: false),
                    Popular = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item", x => x.ItemId);
                });

            migrationBuilder.CreateTable(
                name: "Member",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Role = table.Column<int>(type: "int", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Member", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Archive",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Archive", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Archive_Item_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Item",
                        principalColumn: "ItemId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cart",
                columns: table => new
                {
                    CartID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    CartQuantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cart", x => x.CartID);
                    table.ForeignKey(
                        name: "FK_Cart_Item_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Item",
                        principalColumn: "ItemId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cart_Member_UserId",
                        column: x => x.UserId,
                        principalTable: "Member",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OwnerShip",
                columns: table => new
                {
                    OwnerShipID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    OwnerShipQuantity = table.Column<int>(type: "int", nullable: false),
                    OwnershipDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OwnerShip", x => x.OwnerShipID);
                    table.ForeignKey(
                        name: "FK_OwnerShip_Item_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Item",
                        principalColumn: "ItemId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OwnerShip_Member_UserId",
                        column: x => x.UserId,
                        principalTable: "Member",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Request",
                columns: table => new
                {
                    RequestID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    RequestStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RequestQuantity = table.Column<int>(type: "int", nullable: false),
                    TakeOrRestore = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StatusAfterRestore = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Request", x => x.RequestID);
                    table.ForeignKey(
                        name: "FK_Request_Item_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Item",
                        principalColumn: "ItemId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Request_Member_UserId",
                        column: x => x.UserId,
                        principalTable: "Member",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Item",
                columns: new[] { "ItemId", "DateUpdated", "Image", "ItemName", "ItemStatus", "ItemType", "Popular", "Quantity", "Serial", "UnitPrice" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 6, 14, 16, 17, 3, 336, DateTimeKind.Local).AddTicks(8013), "637897191887265465.jpg", "Laptop HP-1", "Free", "Electronic Device", "False", 1, "234-156-185", 20000 },
                    { 26, new DateTime(2022, 6, 14, 16, 17, 3, 338, DateTimeKind.Local).AddTicks(1492), "637897199842894480.jpg", "Fire extingulisher", "Free", "Furniture", "False", 7, "405-878-974", 400 },
                    { 27, new DateTime(2022, 6, 14, 16, 17, 3, 338, DateTimeKind.Local).AddTicks(1493), "637897199686917787.jpg", "Fan", "Free", "Furniture", "False", 40, "845-877-914", 500 },
                    { 28, new DateTime(2022, 6, 14, 16, 17, 3, 338, DateTimeKind.Local).AddTicks(1495), "637897202071097364.jpg", "Handeld Projector", "Free", "Electronic Device", "False", 1, "587-156-138", 1000 },
                    { 29, new DateTime(2022, 6, 14, 16, 17, 3, 338, DateTimeKind.Local).AddTicks(1498), "637897202071097364.jpg", "CRT Projector", "Free", "Electronic Device", "False", 1, "579-156-188", 1000 },
                    { 30, new DateTime(2022, 6, 14, 16, 17, 3, 338, DateTimeKind.Local).AddTicks(1499), "637897202071097364.jpg", "Laptop Dell-2", "Free", "Electronic Device", "False", 1, "455-789-178", 20000 },
                    { 31, new DateTime(2022, 6, 14, 16, 17, 3, 338, DateTimeKind.Local).AddTicks(1501), "637897202071097364.jpg", "Laptop Apple-2", "Free", "Electronic Device", "False", 1, "455-789-168", 20000 },
                    { 32, new DateTime(2022, 6, 14, 16, 17, 3, 338, DateTimeKind.Local).AddTicks(1502), "637897202071097364.jpg", "Laptop Lenovo-2", "Free", "Electronic Device", "False", 1, "129-174-818", 20000 },
                    { 33, new DateTime(2022, 6, 14, 16, 17, 3, 338, DateTimeKind.Local).AddTicks(1503), "637897202071097364.jpg", "Laptop Amazon-2", "Free", "Electronic Device", "False", 1, "987-123-518", 20000 },
                    { 34, new DateTime(2022, 6, 14, 16, 17, 3, 338, DateTimeKind.Local).AddTicks(1505), "637897199425146171.jpg", "Data show Screen C-123", "Free", "Electronic Device", "True", 1, "555-156-185", 15000 },
                    { 35, new DateTime(2022, 6, 14, 16, 17, 3, 338, DateTimeKind.Local).AddTicks(1506), "637897199425146171.jpg", "Data show Screen D-489", "Free", "Electronic Device", "True", 1, "555-156-188", 15000 },
                    { 36, new DateTime(2022, 6, 14, 16, 17, 3, 338, DateTimeKind.Local).AddTicks(1508), "637897244563427963.jpg", "Screen IE-187", "Free", "Electronic Device", "False", 1, "482-178-179", 3000 },
                    { 37, new DateTime(2022, 6, 14, 16, 17, 3, 338, DateTimeKind.Local).AddTicks(1509), "637897244563427963.jpg", "Screen PE-789", "Free", "Electronic Device", "False", 1, "487-157-167", 3000 },
                    { 38, new DateTime(2022, 6, 14, 16, 17, 3, 338, DateTimeKind.Local).AddTicks(1510), "637897200938565540.jpg", "Mouse GE-48", "Free", "Electronic Device", "False", 1, "584-158-586", 4000 },
                    { 39, new DateTime(2022, 6, 14, 16, 17, 3, 338, DateTimeKind.Local).AddTicks(1512), "637897200938565540.jpg", "Mouse WO-45", "Free", "Electronic Device", "False", 1, "584-158-858", 4000 },
                    { 40, new DateTime(2022, 6, 14, 16, 17, 3, 338, DateTimeKind.Local).AddTicks(1513), "637897200406465686.jpg", "Keyboard e-4", "Free", "Electronic Device", "False", 1, "162-346-509", 2000 },
                    { 41, new DateTime(2022, 6, 14, 16, 17, 3, 338, DateTimeKind.Local).AddTicks(1514), "637897200406465686.jpg", "Keyboard i-7", "Free", "Electronic Device", "False", 1, "129-364-509", 2000 },
                    { 42, new DateTime(2022, 6, 14, 16, 17, 3, 338, DateTimeKind.Local).AddTicks(1516), "637897192165684906.jpg", "Basket", "Free", "Furniture", "False", 40, "495-867-964", 500 },
                    { 43, new DateTime(2022, 6, 14, 16, 17, 3, 338, DateTimeKind.Local).AddTicks(1517), "637897192370070754.jpg", "Board", "Free", "Furniture", "False", 40, "495-897-974", 500 },
                    { 44, new DateTime(2022, 6, 14, 16, 17, 3, 338, DateTimeKind.Local).AddTicks(1519), "637897195418551957.jpg", "Case", "Free", "Electronic Device", "False", 40, "485-587-924", 500 },
                    { 25, new DateTime(2022, 6, 14, 16, 17, 3, 338, DateTimeKind.Local).AddTicks(1491), "637896963384916375.jpg", "Benche", "Free", "Furniture", "False", 20, "457-887-914", 1000 },
                    { 24, new DateTime(2022, 6, 14, 16, 17, 3, 338, DateTimeKind.Local).AddTicks(1489), "637897192735551218.jpg", "Cabinet", "Free", "Furniture", "False", 17, "425-887-994", 500 },
                    { 23, new DateTime(2022, 6, 14, 16, 17, 3, 338, DateTimeKind.Local).AddTicks(1488), "637897199104943091.jpg", "Chest", "Free", "Furniture", "False", 5, "475-877-894", 400 },
                    { 22, new DateTime(2022, 6, 14, 16, 17, 3, 338, DateTimeKind.Local).AddTicks(1486), "637897199283252911.jpg", "Clock", "Free", "Furniture", "False", 30, "459-878-948", 100 },
                    { 2, new DateTime(2022, 6, 14, 16, 17, 3, 338, DateTimeKind.Local).AddTicks(1192), "637897191887265465.jpg", "Laptop Dell-1", "Free", "Electronic Device", "True", 1, "555-156-187", 25000 },
                    { 3, new DateTime(2022, 6, 14, 16, 17, 3, 338, DateTimeKind.Local).AddTicks(1450), "637897191887265465.jpg", "Laptop Apple-1", "Free", "Electronic Device", "True", 1, "584-157-189", 35000 },
                    { 4, new DateTime(2022, 6, 14, 16, 17, 3, 338, DateTimeKind.Local).AddTicks(1457), "637897191887265465.jpg", "Laptop Lenovo-1", "Free", "Electronic Device", "False", 1, "128-174-181", 22000 },
                    { 5, new DateTime(2022, 6, 14, 16, 17, 3, 338, DateTimeKind.Local).AddTicks(1459), "637897191887265465.jpg", "Laptop Amazon-1", "Free", "Electronic Device", "False", 1, "987-123-158", 15000 },
                    { 6, new DateTime(2022, 6, 14, 16, 17, 3, 338, DateTimeKind.Local).AddTicks(1460), "637897191887265465.jpg", "Laptop HP-2", "Free", "Electronic Device", "False", 1, "455-789-718", 40000 },
                    { 7, new DateTime(2022, 6, 14, 16, 17, 3, 338, DateTimeKind.Local).AddTicks(1464), "637897202071097364.jpg", "LCD-1 Projector", "Free", "Electronic Device", "False", 1, "557-156-918", 1000 },
                    { 8, new DateTime(2022, 6, 14, 16, 17, 3, 338, DateTimeKind.Local).AddTicks(1465), "637897199425146171.jpg", "Data show Screen A-1", "Free", "Electronic Device", "True", 1, "555-156-168", 15000 },
                    { 9, new DateTime(2022, 6, 14, 16, 17, 3, 338, DateTimeKind.Local).AddTicks(1466), "637897244563427963.jpg", "Screen UT-125", "Free", "Electronic Device", "False", 1, "488-147-187", 3000 },
                    { 10, new DateTime(2022, 6, 14, 16, 17, 3, 338, DateTimeKind.Local).AddTicks(1468), "637897200938565540.jpg", "Mouse k-45", "Free", "Electronic Device", "False", 1, "584-158-582", 4000 },
                    { 11, new DateTime(2022, 6, 14, 16, 17, 3, 338, DateTimeKind.Local).AddTicks(1469), "637897200406465686.jpg", "Keyboard rt-45", "Free", "Electronic Device", "False", 1, "152-434-509", 2000 },
                    { 13, new DateTime(2022, 6, 14, 16, 17, 3, 338, DateTimeKind.Local).AddTicks(1473), "637897201152036805.jpg", "Printer", "Free", "Electronic Device", "False", 1, "384-532-456", 8000 },
                    { 14, new DateTime(2022, 6, 14, 16, 17, 3, 338, DateTimeKind.Local).AddTicks(1474), "637897200712709232.jpg", "Michrophone", "Free", "Electronic Device", "False", 1, "345-735-645", 7000 },
                    { 15, new DateTime(2022, 6, 14, 16, 17, 3, 338, DateTimeKind.Local).AddTicks(1476), "637897191119246922.jpg", "Air Condition", "Free", "Furniture", "False", 15, "534-553-453", 1000 },
                    { 16, new DateTime(2022, 6, 14, 16, 17, 3, 338, DateTimeKind.Local).AddTicks(1477), "637897201590504495.jpg", "Processor", "Free", "Electronic Device", "True", 1, "278-754-467", 2000 },
                    { 17, new DateTime(2022, 6, 14, 16, 17, 3, 338, DateTimeKind.Local).AddTicks(1479), "637897202777982906.jpg", "Ram", "Free", "Electronic Device", "False", 1, "487-754-155", 1000 },
                    { 18, new DateTime(2022, 6, 14, 16, 17, 3, 338, DateTimeKind.Local).AddTicks(1480), "637897198576352429.jpg", "CD", "Free", "Electronic Device", "False", 1, "157-875-556", 50 },
                    { 19, new DateTime(2022, 6, 14, 16, 17, 3, 338, DateTimeKind.Local).AddTicks(1481), "637897244778262668.jpg", "Speaker", "Free", "Electronic Device", "False", 1, "445-787-594", 500 },
                    { 20, new DateTime(2022, 6, 14, 16, 17, 3, 338, DateTimeKind.Local).AddTicks(1483), "637897245239864495.jpg", "Table", "Free", "Furniture", "True", 10, "455-887-954", 500 }
                });

            migrationBuilder.InsertData(
                table: "Item",
                columns: new[] { "ItemId", "DateUpdated", "Image", "ItemName", "ItemStatus", "ItemType", "Popular", "Quantity", "Serial", "UnitPrice" },
                values: new object[,]
                {
                    { 21, new DateTime(2022, 6, 14, 16, 17, 3, 338, DateTimeKind.Local).AddTicks(1484), "637897198856333003.jpg", "Chair", "Free", "Furniture", "False", 15, "457-887-924", 100 },
                    { 12, new DateTime(2022, 6, 14, 16, 17, 3, 338, DateTimeKind.Local).AddTicks(1472), "637897244338111378.jpg", "Scanner", "Free", "Electronic Device", "False", 1, "782-314-059", 3000 }
                });

            migrationBuilder.InsertData(
                table: "Member",
                columns: new[] { "UserId", "Email", "Name", "Number", "Password", "Role", "status" },
                values: new object[,]
                {
                    { "5e844823-8fba-428c-8161-5b04e298748c", "Mondaa@gmail.com", "Mondaa", "0101236548", "5e844823-8fba-428c-8161-5b0458d7r6dkfore45", 1, 1 },
                    { "5e889423-8fba-428c-8161-5b04e298748c", "Remondaa@gmail.com", "Remondaa", "0125697834", "5e844823-8fba-428c-8161-5b0458d7r6dkfore45", 1, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Archive_ItemId",
                table: "Archive",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Cart_ItemId",
                table: "Cart",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Cart_UserId",
                table: "Cart",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_OwnerShip_ItemId",
                table: "OwnerShip",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_OwnerShip_UserId",
                table: "OwnerShip",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Request_ItemId",
                table: "Request",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Request_UserId",
                table: "Request",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Archive");

            migrationBuilder.DropTable(
                name: "Cart");

            migrationBuilder.DropTable(
                name: "OwnerShip");

            migrationBuilder.DropTable(
                name: "Request");

            migrationBuilder.DropTable(
                name: "Item");

            migrationBuilder.DropTable(
                name: "Member");
        }
    }
}
