using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DB3GP.Migrations
{
    public partial class dbyu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cart",
                columns: new[] { "CartID", "CartQuantity", "ItemId", "UserId" },
                values: new object[,]
                {
                    { 5001, 1, 7035, "5e844823-8fba-428c-8161-5b04e29wue12" },
                    { 5002, 3, 7020, "5e844823-8fba-428c-8161-5b04e29wue12" }
                });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7000,
                column: "DateUpdated",
                value: new DateTime(2022, 6, 15, 19, 25, 30, 908, DateTimeKind.Local).AddTicks(4138));

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7001,
                column: "DateUpdated",
                value: new DateTime(2022, 6, 15, 19, 25, 30, 909, DateTimeKind.Local).AddTicks(5080));

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7002,
                column: "DateUpdated",
                value: new DateTime(2022, 6, 15, 19, 25, 30, 909, DateTimeKind.Local).AddTicks(5372));

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7003,
                column: "DateUpdated",
                value: new DateTime(2022, 6, 15, 19, 25, 30, 909, DateTimeKind.Local).AddTicks(5379));

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7004,
                column: "DateUpdated",
                value: new DateTime(2022, 6, 15, 19, 25, 30, 909, DateTimeKind.Local).AddTicks(5380));

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7005,
                column: "DateUpdated",
                value: new DateTime(2022, 6, 15, 19, 25, 30, 909, DateTimeKind.Local).AddTicks(5382));

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7006,
                column: "DateUpdated",
                value: new DateTime(2022, 6, 15, 19, 25, 30, 909, DateTimeKind.Local).AddTicks(5383));

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7007,
                column: "DateUpdated",
                value: new DateTime(2022, 6, 15, 19, 25, 30, 909, DateTimeKind.Local).AddTicks(5385));

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7008,
                column: "DateUpdated",
                value: new DateTime(2022, 6, 15, 19, 25, 30, 909, DateTimeKind.Local).AddTicks(5386));

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7009,
                column: "DateUpdated",
                value: new DateTime(2022, 6, 15, 19, 25, 30, 909, DateTimeKind.Local).AddTicks(5387));

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7010,
                column: "DateUpdated",
                value: new DateTime(2022, 6, 15, 19, 25, 30, 909, DateTimeKind.Local).AddTicks(5389));

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7011,
                column: "DateUpdated",
                value: new DateTime(2022, 6, 15, 19, 25, 30, 909, DateTimeKind.Local).AddTicks(5390));

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7012,
                column: "DateUpdated",
                value: new DateTime(2022, 6, 15, 19, 25, 30, 909, DateTimeKind.Local).AddTicks(5391));

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7013,
                column: "DateUpdated",
                value: new DateTime(2022, 6, 15, 19, 25, 30, 909, DateTimeKind.Local).AddTicks(5392));

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7014,
                column: "DateUpdated",
                value: new DateTime(2022, 6, 15, 19, 25, 30, 909, DateTimeKind.Local).AddTicks(5394));

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7015,
                column: "DateUpdated",
                value: new DateTime(2022, 6, 15, 19, 25, 30, 909, DateTimeKind.Local).AddTicks(5395));

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7016,
                column: "DateUpdated",
                value: new DateTime(2022, 6, 15, 19, 25, 30, 909, DateTimeKind.Local).AddTicks(5396));

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7017,
                column: "DateUpdated",
                value: new DateTime(2022, 6, 15, 19, 25, 30, 909, DateTimeKind.Local).AddTicks(5398));

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7018,
                column: "DateUpdated",
                value: new DateTime(2022, 6, 15, 19, 25, 30, 909, DateTimeKind.Local).AddTicks(5400));

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7019,
                column: "DateUpdated",
                value: new DateTime(2022, 6, 15, 19, 25, 30, 909, DateTimeKind.Local).AddTicks(5402));

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7020,
                column: "DateUpdated",
                value: new DateTime(2022, 6, 15, 19, 25, 30, 909, DateTimeKind.Local).AddTicks(5403));

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7021,
                column: "DateUpdated",
                value: new DateTime(2022, 6, 15, 19, 25, 30, 909, DateTimeKind.Local).AddTicks(5405));

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7022,
                column: "DateUpdated",
                value: new DateTime(2022, 6, 15, 19, 25, 30, 909, DateTimeKind.Local).AddTicks(5406));

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7023,
                column: "DateUpdated",
                value: new DateTime(2022, 6, 15, 19, 25, 30, 909, DateTimeKind.Local).AddTicks(5407));

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7024,
                column: "DateUpdated",
                value: new DateTime(2022, 6, 15, 19, 25, 30, 909, DateTimeKind.Local).AddTicks(5409));

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7025,
                column: "DateUpdated",
                value: new DateTime(2022, 6, 15, 19, 25, 30, 909, DateTimeKind.Local).AddTicks(5410));

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7026,
                column: "DateUpdated",
                value: new DateTime(2022, 6, 15, 19, 25, 30, 909, DateTimeKind.Local).AddTicks(5411));

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7027,
                column: "DateUpdated",
                value: new DateTime(2022, 6, 15, 19, 25, 30, 909, DateTimeKind.Local).AddTicks(5413));

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7028,
                column: "DateUpdated",
                value: new DateTime(2022, 6, 15, 19, 25, 30, 909, DateTimeKind.Local).AddTicks(5414));

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7029,
                column: "DateUpdated",
                value: new DateTime(2022, 6, 15, 19, 25, 30, 909, DateTimeKind.Local).AddTicks(5415));

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7030,
                column: "DateUpdated",
                value: new DateTime(2022, 6, 15, 19, 25, 30, 909, DateTimeKind.Local).AddTicks(5417));

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7031,
                column: "DateUpdated",
                value: new DateTime(2022, 6, 15, 19, 25, 30, 909, DateTimeKind.Local).AddTicks(5418));

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7032,
                column: "DateUpdated",
                value: new DateTime(2022, 6, 15, 19, 25, 30, 909, DateTimeKind.Local).AddTicks(5419));

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7033,
                column: "DateUpdated",
                value: new DateTime(2022, 6, 15, 19, 25, 30, 909, DateTimeKind.Local).AddTicks(5421));

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7034,
                column: "DateUpdated",
                value: new DateTime(2022, 6, 15, 19, 25, 30, 909, DateTimeKind.Local).AddTicks(5422));

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7035,
                column: "DateUpdated",
                value: new DateTime(2022, 6, 15, 19, 25, 30, 909, DateTimeKind.Local).AddTicks(5423));

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7036,
                column: "DateUpdated",
                value: new DateTime(2022, 6, 15, 19, 25, 30, 909, DateTimeKind.Local).AddTicks(5425));

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7037,
                column: "DateUpdated",
                value: new DateTime(2022, 6, 15, 19, 25, 30, 909, DateTimeKind.Local).AddTicks(5426));

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7038,
                column: "DateUpdated",
                value: new DateTime(2022, 6, 15, 19, 25, 30, 909, DateTimeKind.Local).AddTicks(5428));

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7039,
                column: "DateUpdated",
                value: new DateTime(2022, 6, 15, 19, 25, 30, 909, DateTimeKind.Local).AddTicks(5429));

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7040,
                column: "DateUpdated",
                value: new DateTime(2022, 6, 15, 19, 25, 30, 909, DateTimeKind.Local).AddTicks(5431));

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7041,
                column: "DateUpdated",
                value: new DateTime(2022, 6, 15, 19, 25, 30, 909, DateTimeKind.Local).AddTicks(5432));

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7042,
                column: "DateUpdated",
                value: new DateTime(2022, 6, 15, 19, 25, 30, 909, DateTimeKind.Local).AddTicks(5434));

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7043,
                column: "DateUpdated",
                value: new DateTime(2022, 6, 15, 19, 25, 30, 909, DateTimeKind.Local).AddTicks(5435));

            migrationBuilder.InsertData(
                table: "Member",
                columns: new[] { "UserId", "Email", "Name", "Number", "Password", "Role", "status" },
                values: new object[,]
                {
                    { "5e844823-8fba-428c-8161-5b04e298748c", "Mondaa@gmail.com", "Mondaa", "0101236548", "5e844823-8fba-428c-8161-5b0458d7r6dkfore45", 1, 1 },
                    { "5e889423-8fba-428c-8161-5b04e298748c", "Remondaa@gmail.com", "Remondaa", "0125697834", "5e844823-8fba-428c-8161-5b0458d7r6dkfore45", 1, 1 }
                });

            migrationBuilder.InsertData(
                table: "Request",
                columns: new[] { "RequestID", "ItemId", "RequestQuantity", "RequestStatus", "StatusAfterRestore", "TakeOrRestore", "UserId" },
                values: new object[,]
                {
                    { 10001, 7030, 1, "waiting", "Available", "Restore", "5e844823-8fba-428c-8161-5b04e29wue12" },
                    { 1000, 7021, 1, "waiting", "Available", "Take", "5e844823-8fba-428c-8161-5b04e29wue12" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cart",
                keyColumn: "CartID",
                keyValue: 5001);

            migrationBuilder.DeleteData(
                table: "Cart",
                keyColumn: "CartID",
                keyValue: 5002);

            migrationBuilder.DeleteData(
                table: "Member",
                keyColumn: "UserId",
                keyValue: "5e844823-8fba-428c-8161-5b04e298748c");

            migrationBuilder.DeleteData(
                table: "Member",
                keyColumn: "UserId",
                keyValue: "5e889423-8fba-428c-8161-5b04e298748c");

            migrationBuilder.DeleteData(
                table: "Request",
                keyColumn: "RequestID",
                keyValue: 1000);

            migrationBuilder.DeleteData(
                table: "Request",
                keyColumn: "RequestID",
                keyValue: 10001);

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7000,
                column: "DateUpdated",
                value: new DateTime(2022, 6, 15, 19, 19, 26, 657, DateTimeKind.Local).AddTicks(1929));

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7001,
                column: "DateUpdated",
                value: new DateTime(2022, 6, 15, 19, 19, 26, 659, DateTimeKind.Local).AddTicks(6156));

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7002,
                column: "DateUpdated",
                value: new DateTime(2022, 6, 15, 19, 19, 26, 659, DateTimeKind.Local).AddTicks(6613));

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7003,
                column: "DateUpdated",
                value: new DateTime(2022, 6, 15, 19, 19, 26, 659, DateTimeKind.Local).AddTicks(6625));

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7004,
                column: "DateUpdated",
                value: new DateTime(2022, 6, 15, 19, 19, 26, 659, DateTimeKind.Local).AddTicks(6629));

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7005,
                column: "DateUpdated",
                value: new DateTime(2022, 6, 15, 19, 19, 26, 659, DateTimeKind.Local).AddTicks(6632));

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7006,
                column: "DateUpdated",
                value: new DateTime(2022, 6, 15, 19, 19, 26, 659, DateTimeKind.Local).AddTicks(6634));

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7007,
                column: "DateUpdated",
                value: new DateTime(2022, 6, 15, 19, 19, 26, 659, DateTimeKind.Local).AddTicks(6636));

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7008,
                column: "DateUpdated",
                value: new DateTime(2022, 6, 15, 19, 19, 26, 659, DateTimeKind.Local).AddTicks(6638));

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7009,
                column: "DateUpdated",
                value: new DateTime(2022, 6, 15, 19, 19, 26, 659, DateTimeKind.Local).AddTicks(6641));

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7010,
                column: "DateUpdated",
                value: new DateTime(2022, 6, 15, 19, 19, 26, 659, DateTimeKind.Local).AddTicks(6764));

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7011,
                column: "DateUpdated",
                value: new DateTime(2022, 6, 15, 19, 19, 26, 659, DateTimeKind.Local).AddTicks(6772));

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7012,
                column: "DateUpdated",
                value: new DateTime(2022, 6, 15, 19, 19, 26, 659, DateTimeKind.Local).AddTicks(6774));

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7013,
                column: "DateUpdated",
                value: new DateTime(2022, 6, 15, 19, 19, 26, 659, DateTimeKind.Local).AddTicks(6776));

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7014,
                column: "DateUpdated",
                value: new DateTime(2022, 6, 15, 19, 19, 26, 659, DateTimeKind.Local).AddTicks(6779));

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7015,
                column: "DateUpdated",
                value: new DateTime(2022, 6, 15, 19, 19, 26, 659, DateTimeKind.Local).AddTicks(6780));

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7016,
                column: "DateUpdated",
                value: new DateTime(2022, 6, 15, 19, 19, 26, 659, DateTimeKind.Local).AddTicks(6784));

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7017,
                column: "DateUpdated",
                value: new DateTime(2022, 6, 15, 19, 19, 26, 659, DateTimeKind.Local).AddTicks(6786));

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7018,
                column: "DateUpdated",
                value: new DateTime(2022, 6, 15, 19, 19, 26, 659, DateTimeKind.Local).AddTicks(6789));

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7019,
                column: "DateUpdated",
                value: new DateTime(2022, 6, 15, 19, 19, 26, 659, DateTimeKind.Local).AddTicks(6791));

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7020,
                column: "DateUpdated",
                value: new DateTime(2022, 6, 15, 19, 19, 26, 659, DateTimeKind.Local).AddTicks(6793));

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7021,
                column: "DateUpdated",
                value: new DateTime(2022, 6, 15, 19, 19, 26, 659, DateTimeKind.Local).AddTicks(6795));

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7022,
                column: "DateUpdated",
                value: new DateTime(2022, 6, 15, 19, 19, 26, 659, DateTimeKind.Local).AddTicks(6798));

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7023,
                column: "DateUpdated",
                value: new DateTime(2022, 6, 15, 19, 19, 26, 659, DateTimeKind.Local).AddTicks(6800));

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7024,
                column: "DateUpdated",
                value: new DateTime(2022, 6, 15, 19, 19, 26, 659, DateTimeKind.Local).AddTicks(6802));

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7025,
                column: "DateUpdated",
                value: new DateTime(2022, 6, 15, 19, 19, 26, 659, DateTimeKind.Local).AddTicks(6804));

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7026,
                column: "DateUpdated",
                value: new DateTime(2022, 6, 15, 19, 19, 26, 659, DateTimeKind.Local).AddTicks(6806));

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7027,
                column: "DateUpdated",
                value: new DateTime(2022, 6, 15, 19, 19, 26, 659, DateTimeKind.Local).AddTicks(6809));

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7028,
                column: "DateUpdated",
                value: new DateTime(2022, 6, 15, 19, 19, 26, 659, DateTimeKind.Local).AddTicks(6811));

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7029,
                column: "DateUpdated",
                value: new DateTime(2022, 6, 15, 19, 19, 26, 659, DateTimeKind.Local).AddTicks(6813));

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7030,
                column: "DateUpdated",
                value: new DateTime(2022, 6, 15, 19, 19, 26, 659, DateTimeKind.Local).AddTicks(6816));

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7031,
                column: "DateUpdated",
                value: new DateTime(2022, 6, 15, 19, 19, 26, 659, DateTimeKind.Local).AddTicks(6818));

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7032,
                column: "DateUpdated",
                value: new DateTime(2022, 6, 15, 19, 19, 26, 659, DateTimeKind.Local).AddTicks(6820));

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7033,
                column: "DateUpdated",
                value: new DateTime(2022, 6, 15, 19, 19, 26, 659, DateTimeKind.Local).AddTicks(6823));

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7034,
                column: "DateUpdated",
                value: new DateTime(2022, 6, 15, 19, 19, 26, 659, DateTimeKind.Local).AddTicks(6826));

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7035,
                column: "DateUpdated",
                value: new DateTime(2022, 6, 15, 19, 19, 26, 659, DateTimeKind.Local).AddTicks(6829));

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7036,
                column: "DateUpdated",
                value: new DateTime(2022, 6, 15, 19, 19, 26, 659, DateTimeKind.Local).AddTicks(6831));

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7037,
                column: "DateUpdated",
                value: new DateTime(2022, 6, 15, 19, 19, 26, 659, DateTimeKind.Local).AddTicks(6833));

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7038,
                column: "DateUpdated",
                value: new DateTime(2022, 6, 15, 19, 19, 26, 659, DateTimeKind.Local).AddTicks(6835));

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7039,
                column: "DateUpdated",
                value: new DateTime(2022, 6, 15, 19, 19, 26, 659, DateTimeKind.Local).AddTicks(6837));

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7040,
                column: "DateUpdated",
                value: new DateTime(2022, 6, 15, 19, 19, 26, 659, DateTimeKind.Local).AddTicks(6839));

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7041,
                column: "DateUpdated",
                value: new DateTime(2022, 6, 15, 19, 19, 26, 659, DateTimeKind.Local).AddTicks(6841));

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7042,
                column: "DateUpdated",
                value: new DateTime(2022, 6, 15, 19, 19, 26, 659, DateTimeKind.Local).AddTicks(6843));

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7043,
                column: "DateUpdated",
                value: new DateTime(2022, 6, 15, 19, 19, 26, 659, DateTimeKind.Local).AddTicks(6845));
        }
    }
}
