using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DB3GP.Migrations
{
    public partial class db349 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 44);

            migrationBuilder.InsertData(
                table: "Item",
                columns: new[] { "ItemId", "DateUpdated", "Image", "ItemName", "ItemStatus", "ItemType", "Popular", "Quantity", "Serial", "UnitPrice" },
                values: new object[,]
                {
                    { 7000, new DateTime(2022, 6, 15, 19, 19, 26, 657, DateTimeKind.Local).AddTicks(1929), "637897191887265465.jpg", "Laptop HP-1", "Free", "Electronic Device", "False", 1, "234-156-185", 20000 },
                    { 7024, new DateTime(2022, 6, 15, 19, 19, 26, 659, DateTimeKind.Local).AddTicks(6802), "637896963384916375.jpg", "Benche", "Free", "Furniture", "False", 20, "457-887-914", 1000 },
                    { 7025, new DateTime(2022, 6, 15, 19, 19, 26, 659, DateTimeKind.Local).AddTicks(6804), "637897199842894480.jpg", "Fire extingulisher", "Free", "Furniture", "False", 7, "405-878-974", 400 },
                    { 7026, new DateTime(2022, 6, 15, 19, 19, 26, 659, DateTimeKind.Local).AddTicks(6806), "637897199686917787.jpg", "Fan", "Free", "Furniture", "False", 40, "845-877-914", 500 },
                    { 7027, new DateTime(2022, 6, 15, 19, 19, 26, 659, DateTimeKind.Local).AddTicks(6809), "637897202071097364.jpg", "Handeld Projector", "Free", "Electronic Device", "False", 1, "587-156-138", 1000 },
                    { 7028, new DateTime(2022, 6, 15, 19, 19, 26, 659, DateTimeKind.Local).AddTicks(6811), "637897202071097364.jpg", "CRT Projector", "Free", "Electronic Device", "False", 1, "579-156-188", 1000 },
                    { 7029, new DateTime(2022, 6, 15, 19, 19, 26, 659, DateTimeKind.Local).AddTicks(6813), "637897202071097364.jpg", "Laptop Dell-2", "Free", "Electronic Device", "False", 1, "455-789-178", 20000 },
                    { 7030, new DateTime(2022, 6, 15, 19, 19, 26, 659, DateTimeKind.Local).AddTicks(6816), "637897202071097364.jpg", "Laptop Apple-2", "Free", "Electronic Device", "False", 1, "455-789-168", 20000 },
                    { 7031, new DateTime(2022, 6, 15, 19, 19, 26, 659, DateTimeKind.Local).AddTicks(6818), "637897202071097364.jpg", "Laptop Lenovo-2", "Free", "Electronic Device", "False", 1, "129-174-818", 20000 },
                    { 7023, new DateTime(2022, 6, 15, 19, 19, 26, 659, DateTimeKind.Local).AddTicks(6800), "637897192735551218.jpg", "Cabinet", "Free", "Furniture", "False", 17, "425-887-994", 500 },
                    { 7032, new DateTime(2022, 6, 15, 19, 19, 26, 659, DateTimeKind.Local).AddTicks(6820), "637897202071097364.jpg", "Laptop Amazon-2", "Free", "Electronic Device", "False", 1, "987-123-518", 20000 },
                    { 7034, new DateTime(2022, 6, 15, 19, 19, 26, 659, DateTimeKind.Local).AddTicks(6826), "637897199425146171.jpg", "Data show Screen D-489", "Free", "Electronic Device", "True", 1, "555-156-188", 15000 },
                    { 7035, new DateTime(2022, 6, 15, 19, 19, 26, 659, DateTimeKind.Local).AddTicks(6829), "637897244563427963.jpg", "Screen IE-187", "Free", "Electronic Device", "False", 1, "482-178-179", 3000 },
                    { 7036, new DateTime(2022, 6, 15, 19, 19, 26, 659, DateTimeKind.Local).AddTicks(6831), "637897244563427963.jpg", "Screen PE-789", "Free", "Electronic Device", "False", 1, "487-157-167", 3000 },
                    { 7037, new DateTime(2022, 6, 15, 19, 19, 26, 659, DateTimeKind.Local).AddTicks(6833), "637897200938565540.jpg", "Mouse GE-48", "Free", "Electronic Device", "False", 1, "584-158-586", 4000 },
                    { 7038, new DateTime(2022, 6, 15, 19, 19, 26, 659, DateTimeKind.Local).AddTicks(6835), "637897200938565540.jpg", "Mouse WO-45", "Free", "Electronic Device", "False", 1, "584-158-858", 4000 },
                    { 7039, new DateTime(2022, 6, 15, 19, 19, 26, 659, DateTimeKind.Local).AddTicks(6837), "637897200406465686.jpg", "Keyboard e-4", "Free", "Electronic Device", "False", 1, "162-346-509", 2000 },
                    { 7040, new DateTime(2022, 6, 15, 19, 19, 26, 659, DateTimeKind.Local).AddTicks(6839), "637897200406465686.jpg", "Keyboard i-7", "Free", "Electronic Device", "False", 1, "129-364-509", 2000 },
                    { 7041, new DateTime(2022, 6, 15, 19, 19, 26, 659, DateTimeKind.Local).AddTicks(6841), "637897192165684906.jpg", "Basket", "Free", "Furniture", "False", 40, "495-867-964", 500 },
                    { 7033, new DateTime(2022, 6, 15, 19, 19, 26, 659, DateTimeKind.Local).AddTicks(6823), "637897199425146171.jpg", "Data show Screen C-123", "Free", "Electronic Device", "True", 1, "555-156-185", 15000 },
                    { 7022, new DateTime(2022, 6, 15, 19, 19, 26, 659, DateTimeKind.Local).AddTicks(6798), "637897199104943091.jpg", "Chest", "Free", "Furniture", "False", 5, "475-877-894", 400 },
                    { 7021, new DateTime(2022, 6, 15, 19, 19, 26, 659, DateTimeKind.Local).AddTicks(6795), "637897199283252911.jpg", "Clock", "Free", "Furniture", "False", 30, "459-878-948", 100 },
                    { 7020, new DateTime(2022, 6, 15, 19, 19, 26, 659, DateTimeKind.Local).AddTicks(6793), "637897198856333003.jpg", "Chair", "Free", "Furniture", "False", 15, "457-887-924", 100 },
                    { 7001, new DateTime(2022, 6, 15, 19, 19, 26, 659, DateTimeKind.Local).AddTicks(6156), "637897191887265465.jpg", "Laptop Dell-1", "Free", "Electronic Device", "True", 1, "555-156-187", 25000 },
                    { 7002, new DateTime(2022, 6, 15, 19, 19, 26, 659, DateTimeKind.Local).AddTicks(6613), "637897191887265465.jpg", "Laptop Apple-1", "Free", "Electronic Device", "True", 1, "584-157-189", 35000 },
                    { 7003, new DateTime(2022, 6, 15, 19, 19, 26, 659, DateTimeKind.Local).AddTicks(6625), "637897191887265465.jpg", "Laptop Lenovo-1", "Free", "Electronic Device", "False", 1, "128-174-181", 22000 },
                    { 7004, new DateTime(2022, 6, 15, 19, 19, 26, 659, DateTimeKind.Local).AddTicks(6629), "637897191887265465.jpg", "Laptop Amazon-1", "Free", "Electronic Device", "False", 1, "987-123-158", 15000 },
                    { 7005, new DateTime(2022, 6, 15, 19, 19, 26, 659, DateTimeKind.Local).AddTicks(6632), "637897191887265465.jpg", "Laptop HP-2", "Free", "Electronic Device", "False", 1, "455-789-718", 40000 },
                    { 7006, new DateTime(2022, 6, 15, 19, 19, 26, 659, DateTimeKind.Local).AddTicks(6634), "637897202071097364.jpg", "LCD-1 Projector", "Free", "Electronic Device", "False", 1, "557-156-918", 1000 },
                    { 7007, new DateTime(2022, 6, 15, 19, 19, 26, 659, DateTimeKind.Local).AddTicks(6636), "637897199425146171.jpg", "Data show Screen A-1", "Free", "Electronic Device", "True", 1, "555-156-168", 15000 },
                    { 7008, new DateTime(2022, 6, 15, 19, 19, 26, 659, DateTimeKind.Local).AddTicks(6638), "637897244563427963.jpg", "Screen UT-125", "Free", "Electronic Device", "False", 1, "488-147-187", 3000 },
                    { 7009, new DateTime(2022, 6, 15, 19, 19, 26, 659, DateTimeKind.Local).AddTicks(6641), "637897200938565540.jpg", "Mouse k-45", "Free", "Electronic Device", "False", 1, "584-158-582", 4000 },
                    { 7010, new DateTime(2022, 6, 15, 19, 19, 26, 659, DateTimeKind.Local).AddTicks(6764), "637897200406465686.jpg", "Keyboard rt-45", "Free", "Electronic Device", "False", 1, "152-434-509", 2000 },
                    { 7011, new DateTime(2022, 6, 15, 19, 19, 26, 659, DateTimeKind.Local).AddTicks(6772), "637897244338111378.jpg", "Scanner", "Free", "Electronic Device", "False", 1, "782-314-059", 3000 },
                    { 7012, new DateTime(2022, 6, 15, 19, 19, 26, 659, DateTimeKind.Local).AddTicks(6774), "637897201152036805.jpg", "Printer", "Free", "Electronic Device", "False", 1, "384-532-456", 8000 },
                    { 7013, new DateTime(2022, 6, 15, 19, 19, 26, 659, DateTimeKind.Local).AddTicks(6776), "637897200712709232.jpg", "Michrophone", "Free", "Electronic Device", "False", 1, "345-735-645", 7000 },
                    { 7014, new DateTime(2022, 6, 15, 19, 19, 26, 659, DateTimeKind.Local).AddTicks(6779), "637897191119246922.jpg", "Air Condition", "Free", "Furniture", "False", 15, "534-553-453", 1000 },
                    { 7015, new DateTime(2022, 6, 15, 19, 19, 26, 659, DateTimeKind.Local).AddTicks(6780), "637897201590504495.jpg", "Processor", "Free", "Electronic Device", "True", 1, "278-754-467", 2000 },
                    { 7016, new DateTime(2022, 6, 15, 19, 19, 26, 659, DateTimeKind.Local).AddTicks(6784), "637897202777982906.jpg", "Ram", "Free", "Electronic Device", "False", 1, "487-754-155", 1000 },
                    { 7017, new DateTime(2022, 6, 15, 19, 19, 26, 659, DateTimeKind.Local).AddTicks(6786), "637897198576352429.jpg", "CD", "Free", "Electronic Device", "False", 1, "157-875-556", 50 },
                    { 7018, new DateTime(2022, 6, 15, 19, 19, 26, 659, DateTimeKind.Local).AddTicks(6789), "637897244778262668.jpg", "Speaker", "Free", "Electronic Device", "False", 1, "445-787-594", 500 },
                    { 7019, new DateTime(2022, 6, 15, 19, 19, 26, 659, DateTimeKind.Local).AddTicks(6791), "637897245239864495.jpg", "Table", "Free", "Furniture", "True", 10, "455-887-954", 500 }
                });

            migrationBuilder.InsertData(
                table: "Item",
                columns: new[] { "ItemId", "DateUpdated", "Image", "ItemName", "ItemStatus", "ItemType", "Popular", "Quantity", "Serial", "UnitPrice" },
                values: new object[] { 7042, new DateTime(2022, 6, 15, 19, 19, 26, 659, DateTimeKind.Local).AddTicks(6843), "637897192370070754.jpg", "Board", "Free", "Furniture", "False", 40, "495-897-974", 500 });

            migrationBuilder.InsertData(
                table: "Item",
                columns: new[] { "ItemId", "DateUpdated", "Image", "ItemName", "ItemStatus", "ItemType", "Popular", "Quantity", "Serial", "UnitPrice" },
                values: new object[] { 7043, new DateTime(2022, 6, 15, 19, 19, 26, 659, DateTimeKind.Local).AddTicks(6845), "637897195418551957.jpg", "Case", "Free", "Electronic Device", "False", 40, "485-587-924", 500 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7000);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7001);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7002);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7003);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7004);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7005);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7006);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7007);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7008);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7009);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7010);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7011);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7012);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7013);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7014);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7015);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7016);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7017);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7018);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7019);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7020);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7021);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7022);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7023);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7024);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7025);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7026);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7027);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7028);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7029);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7030);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7031);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7032);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7033);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7034);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7035);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7036);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7037);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7038);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7039);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7040);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7041);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7042);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7043);

            migrationBuilder.InsertData(
                table: "Item",
                columns: new[] { "ItemId", "DateUpdated", "Image", "ItemName", "ItemStatus", "ItemType", "Popular", "Quantity", "Serial", "UnitPrice" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 6, 15, 17, 45, 45, 505, DateTimeKind.Local).AddTicks(9268), "637897191887265465.jpg", "Laptop HP-1", "Free", "Electronic Device", "False", 1, "234-156-185", 20000 },
                    { 25, new DateTime(2022, 6, 15, 17, 45, 45, 507, DateTimeKind.Local).AddTicks(1440), "637896963384916375.jpg", "Benche", "Free", "Furniture", "False", 20, "457-887-914", 1000 },
                    { 26, new DateTime(2022, 6, 15, 17, 45, 45, 507, DateTimeKind.Local).AddTicks(1442), "637897199842894480.jpg", "Fire extingulisher", "Free", "Furniture", "False", 7, "405-878-974", 400 },
                    { 27, new DateTime(2022, 6, 15, 17, 45, 45, 507, DateTimeKind.Local).AddTicks(1444), "637897199686917787.jpg", "Fan", "Free", "Furniture", "False", 40, "845-877-914", 500 },
                    { 28, new DateTime(2022, 6, 15, 17, 45, 45, 507, DateTimeKind.Local).AddTicks(1445), "637897202071097364.jpg", "Handeld Projector", "Free", "Electronic Device", "False", 1, "587-156-138", 1000 },
                    { 29, new DateTime(2022, 6, 15, 17, 45, 45, 507, DateTimeKind.Local).AddTicks(1446), "637897202071097364.jpg", "CRT Projector", "Free", "Electronic Device", "False", 1, "579-156-188", 1000 },
                    { 30, new DateTime(2022, 6, 15, 17, 45, 45, 507, DateTimeKind.Local).AddTicks(1447), "637897202071097364.jpg", "Laptop Dell-2", "Free", "Electronic Device", "False", 1, "455-789-178", 20000 },
                    { 31, new DateTime(2022, 6, 15, 17, 45, 45, 507, DateTimeKind.Local).AddTicks(1449), "637897202071097364.jpg", "Laptop Apple-2", "Free", "Electronic Device", "False", 1, "455-789-168", 20000 },
                    { 32, new DateTime(2022, 6, 15, 17, 45, 45, 507, DateTimeKind.Local).AddTicks(1450), "637897202071097364.jpg", "Laptop Lenovo-2", "Free", "Electronic Device", "False", 1, "129-174-818", 20000 },
                    { 24, new DateTime(2022, 6, 15, 17, 45, 45, 507, DateTimeKind.Local).AddTicks(1438), "637897192735551218.jpg", "Cabinet", "Free", "Furniture", "False", 17, "425-887-994", 500 },
                    { 33, new DateTime(2022, 6, 15, 17, 45, 45, 507, DateTimeKind.Local).AddTicks(1452), "637897202071097364.jpg", "Laptop Amazon-2", "Free", "Electronic Device", "False", 1, "987-123-518", 20000 },
                    { 35, new DateTime(2022, 6, 15, 17, 45, 45, 507, DateTimeKind.Local).AddTicks(1454), "637897199425146171.jpg", "Data show Screen D-489", "Free", "Electronic Device", "True", 1, "555-156-188", 15000 },
                    { 36, new DateTime(2022, 6, 15, 17, 45, 45, 507, DateTimeKind.Local).AddTicks(1456), "637897244563427963.jpg", "Screen IE-187", "Free", "Electronic Device", "False", 1, "482-178-179", 3000 },
                    { 37, new DateTime(2022, 6, 15, 17, 45, 45, 507, DateTimeKind.Local).AddTicks(1457), "637897244563427963.jpg", "Screen PE-789", "Free", "Electronic Device", "False", 1, "487-157-167", 3000 },
                    { 38, new DateTime(2022, 6, 15, 17, 45, 45, 507, DateTimeKind.Local).AddTicks(1459), "637897200938565540.jpg", "Mouse GE-48", "Free", "Electronic Device", "False", 1, "584-158-586", 4000 },
                    { 39, new DateTime(2022, 6, 15, 17, 45, 45, 507, DateTimeKind.Local).AddTicks(1460), "637897200938565540.jpg", "Mouse WO-45", "Free", "Electronic Device", "False", 1, "584-158-858", 4000 },
                    { 40, new DateTime(2022, 6, 15, 17, 45, 45, 507, DateTimeKind.Local).AddTicks(1462), "637897200406465686.jpg", "Keyboard e-4", "Free", "Electronic Device", "False", 1, "162-346-509", 2000 },
                    { 41, new DateTime(2022, 6, 15, 17, 45, 45, 507, DateTimeKind.Local).AddTicks(1463), "637897200406465686.jpg", "Keyboard i-7", "Free", "Electronic Device", "False", 1, "129-364-509", 2000 },
                    { 42, new DateTime(2022, 6, 15, 17, 45, 45, 507, DateTimeKind.Local).AddTicks(1465), "637897192165684906.jpg", "Basket", "Free", "Furniture", "False", 40, "495-867-964", 500 },
                    { 34, new DateTime(2022, 6, 15, 17, 45, 45, 507, DateTimeKind.Local).AddTicks(1453), "637897199425146171.jpg", "Data show Screen C-123", "Free", "Electronic Device", "True", 1, "555-156-185", 15000 },
                    { 23, new DateTime(2022, 6, 15, 17, 45, 45, 507, DateTimeKind.Local).AddTicks(1437), "637897199104943091.jpg", "Chest", "Free", "Furniture", "False", 5, "475-877-894", 400 },
                    { 22, new DateTime(2022, 6, 15, 17, 45, 45, 507, DateTimeKind.Local).AddTicks(1434), "637897199283252911.jpg", "Clock", "Free", "Furniture", "False", 30, "459-878-948", 100 },
                    { 21, new DateTime(2022, 6, 15, 17, 45, 45, 507, DateTimeKind.Local).AddTicks(1432), "637897198856333003.jpg", "Chair", "Free", "Furniture", "False", 15, "457-887-924", 100 },
                    { 2, new DateTime(2022, 6, 15, 17, 45, 45, 507, DateTimeKind.Local).AddTicks(1171), "637897191887265465.jpg", "Laptop Dell-1", "Free", "Electronic Device", "True", 1, "555-156-187", 25000 },
                    { 3, new DateTime(2022, 6, 15, 17, 45, 45, 507, DateTimeKind.Local).AddTicks(1396), "637897191887265465.jpg", "Laptop Apple-1", "Free", "Electronic Device", "True", 1, "584-157-189", 35000 },
                    { 4, new DateTime(2022, 6, 15, 17, 45, 45, 507, DateTimeKind.Local).AddTicks(1402), "637897191887265465.jpg", "Laptop Lenovo-1", "Free", "Electronic Device", "False", 1, "128-174-181", 22000 },
                    { 5, new DateTime(2022, 6, 15, 17, 45, 45, 507, DateTimeKind.Local).AddTicks(1404), "637897191887265465.jpg", "Laptop Amazon-1", "Free", "Electronic Device", "False", 1, "987-123-158", 15000 },
                    { 6, new DateTime(2022, 6, 15, 17, 45, 45, 507, DateTimeKind.Local).AddTicks(1406), "637897191887265465.jpg", "Laptop HP-2", "Free", "Electronic Device", "False", 1, "455-789-718", 40000 },
                    { 7, new DateTime(2022, 6, 15, 17, 45, 45, 507, DateTimeKind.Local).AddTicks(1408), "637897202071097364.jpg", "LCD-1 Projector", "Free", "Electronic Device", "False", 1, "557-156-918", 1000 },
                    { 8, new DateTime(2022, 6, 15, 17, 45, 45, 507, DateTimeKind.Local).AddTicks(1410), "637897199425146171.jpg", "Data show Screen A-1", "Free", "Electronic Device", "True", 1, "555-156-168", 15000 },
                    { 9, new DateTime(2022, 6, 15, 17, 45, 45, 507, DateTimeKind.Local).AddTicks(1411), "637897244563427963.jpg", "Screen UT-125", "Free", "Electronic Device", "False", 1, "488-147-187", 3000 },
                    { 10, new DateTime(2022, 6, 15, 17, 45, 45, 507, DateTimeKind.Local).AddTicks(1412), "637897200938565540.jpg", "Mouse k-45", "Free", "Electronic Device", "False", 1, "584-158-582", 4000 },
                    { 11, new DateTime(2022, 6, 15, 17, 45, 45, 507, DateTimeKind.Local).AddTicks(1414), "637897200406465686.jpg", "Keyboard rt-45", "Free", "Electronic Device", "False", 1, "152-434-509", 2000 },
                    { 12, new DateTime(2022, 6, 15, 17, 45, 45, 507, DateTimeKind.Local).AddTicks(1415), "637897244338111378.jpg", "Scanner", "Free", "Electronic Device", "False", 1, "782-314-059", 3000 },
                    { 13, new DateTime(2022, 6, 15, 17, 45, 45, 507, DateTimeKind.Local).AddTicks(1417), "637897201152036805.jpg", "Printer", "Free", "Electronic Device", "False", 1, "384-532-456", 8000 },
                    { 14, new DateTime(2022, 6, 15, 17, 45, 45, 507, DateTimeKind.Local).AddTicks(1419), "637897200712709232.jpg", "Michrophone", "Free", "Electronic Device", "False", 1, "345-735-645", 7000 },
                    { 15, new DateTime(2022, 6, 15, 17, 45, 45, 507, DateTimeKind.Local).AddTicks(1420), "637897191119246922.jpg", "Air Condition", "Free", "Furniture", "False", 15, "534-553-453", 1000 },
                    { 16, new DateTime(2022, 6, 15, 17, 45, 45, 507, DateTimeKind.Local).AddTicks(1423), "637897201590504495.jpg", "Processor", "Free", "Electronic Device", "True", 1, "278-754-467", 2000 },
                    { 17, new DateTime(2022, 6, 15, 17, 45, 45, 507, DateTimeKind.Local).AddTicks(1426), "637897202777982906.jpg", "Ram", "Free", "Electronic Device", "False", 1, "487-754-155", 1000 },
                    { 18, new DateTime(2022, 6, 15, 17, 45, 45, 507, DateTimeKind.Local).AddTicks(1428), "637897198576352429.jpg", "CD", "Free", "Electronic Device", "False", 1, "157-875-556", 50 },
                    { 19, new DateTime(2022, 6, 15, 17, 45, 45, 507, DateTimeKind.Local).AddTicks(1429), "637897244778262668.jpg", "Speaker", "Free", "Electronic Device", "False", 1, "445-787-594", 500 },
                    { 20, new DateTime(2022, 6, 15, 17, 45, 45, 507, DateTimeKind.Local).AddTicks(1431), "637897245239864495.jpg", "Table", "Free", "Furniture", "True", 10, "455-887-954", 500 }
                });

            migrationBuilder.InsertData(
                table: "Item",
                columns: new[] { "ItemId", "DateUpdated", "Image", "ItemName", "ItemStatus", "ItemType", "Popular", "Quantity", "Serial", "UnitPrice" },
                values: new object[] { 43, new DateTime(2022, 6, 15, 17, 45, 45, 507, DateTimeKind.Local).AddTicks(1467), "637897192370070754.jpg", "Board", "Free", "Furniture", "False", 40, "495-897-974", 500 });

            migrationBuilder.InsertData(
                table: "Item",
                columns: new[] { "ItemId", "DateUpdated", "Image", "ItemName", "ItemStatus", "ItemType", "Popular", "Quantity", "Serial", "UnitPrice" },
                values: new object[] { 44, new DateTime(2022, 6, 15, 17, 45, 45, 507, DateTimeKind.Local).AddTicks(1470), "637897195418551957.jpg", "Case", "Free", "Electronic Device", "False", 40, "485-587-924", 500 });
        }
    }
}
