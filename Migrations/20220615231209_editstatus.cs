using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DB3GP.Migrations
{
    public partial class editstatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ItemStatus",
                table: "Item");

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7000,
                column: "DateUpdated",
                value: new DateTime(2022, 6, 16, 1, 12, 8, 804, DateTimeKind.Local).AddTicks(761));

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7001,
                column: "DateUpdated",
                value: new DateTime(2022, 6, 16, 1, 12, 8, 805, DateTimeKind.Local).AddTicks(2978));

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7002,
                column: "DateUpdated",
                value: new DateTime(2022, 6, 16, 1, 12, 8, 805, DateTimeKind.Local).AddTicks(3244));

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7003,
                column: "DateUpdated",
                value: new DateTime(2022, 6, 16, 1, 12, 8, 805, DateTimeKind.Local).AddTicks(3251));

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7004,
                column: "DateUpdated",
                value: new DateTime(2022, 6, 16, 1, 12, 8, 805, DateTimeKind.Local).AddTicks(3254));

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7005,
                column: "DateUpdated",
                value: new DateTime(2022, 6, 16, 1, 12, 8, 805, DateTimeKind.Local).AddTicks(3255));

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7006,
                column: "DateUpdated",
                value: new DateTime(2022, 6, 16, 1, 12, 8, 805, DateTimeKind.Local).AddTicks(3257));

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7007,
                column: "DateUpdated",
                value: new DateTime(2022, 6, 16, 1, 12, 8, 805, DateTimeKind.Local).AddTicks(3260));

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7008,
                column: "DateUpdated",
                value: new DateTime(2022, 6, 16, 1, 12, 8, 805, DateTimeKind.Local).AddTicks(3262));

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7009,
                column: "DateUpdated",
                value: new DateTime(2022, 6, 16, 1, 12, 8, 805, DateTimeKind.Local).AddTicks(3264));

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7010,
                column: "DateUpdated",
                value: new DateTime(2022, 6, 16, 1, 12, 8, 805, DateTimeKind.Local).AddTicks(3265));

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7011,
                column: "DateUpdated",
                value: new DateTime(2022, 6, 16, 1, 12, 8, 805, DateTimeKind.Local).AddTicks(3267));

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7012,
                column: "DateUpdated",
                value: new DateTime(2022, 6, 16, 1, 12, 8, 805, DateTimeKind.Local).AddTicks(3269));

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7013,
                column: "DateUpdated",
                value: new DateTime(2022, 6, 16, 1, 12, 8, 805, DateTimeKind.Local).AddTicks(3270));

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7014,
                column: "DateUpdated",
                value: new DateTime(2022, 6, 16, 1, 12, 8, 805, DateTimeKind.Local).AddTicks(3272));

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7015,
                column: "DateUpdated",
                value: new DateTime(2022, 6, 16, 1, 12, 8, 805, DateTimeKind.Local).AddTicks(3274));

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7016,
                column: "DateUpdated",
                value: new DateTime(2022, 6, 16, 1, 12, 8, 805, DateTimeKind.Local).AddTicks(3275));

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7017,
                column: "DateUpdated",
                value: new DateTime(2022, 6, 16, 1, 12, 8, 805, DateTimeKind.Local).AddTicks(3277));

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7018,
                column: "DateUpdated",
                value: new DateTime(2022, 6, 16, 1, 12, 8, 805, DateTimeKind.Local).AddTicks(3279));

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7019,
                column: "DateUpdated",
                value: new DateTime(2022, 6, 16, 1, 12, 8, 805, DateTimeKind.Local).AddTicks(3281));

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7020,
                column: "DateUpdated",
                value: new DateTime(2022, 6, 16, 1, 12, 8, 805, DateTimeKind.Local).AddTicks(3282));

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7021,
                column: "DateUpdated",
                value: new DateTime(2022, 6, 16, 1, 12, 8, 805, DateTimeKind.Local).AddTicks(3284));

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7022,
                column: "DateUpdated",
                value: new DateTime(2022, 6, 16, 1, 12, 8, 805, DateTimeKind.Local).AddTicks(3285));

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7023,
                column: "DateUpdated",
                value: new DateTime(2022, 6, 16, 1, 12, 8, 805, DateTimeKind.Local).AddTicks(3287));

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7024,
                column: "DateUpdated",
                value: new DateTime(2022, 6, 16, 1, 12, 8, 805, DateTimeKind.Local).AddTicks(3288));

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7025,
                column: "DateUpdated",
                value: new DateTime(2022, 6, 16, 1, 12, 8, 805, DateTimeKind.Local).AddTicks(3290));

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7026,
                column: "DateUpdated",
                value: new DateTime(2022, 6, 16, 1, 12, 8, 805, DateTimeKind.Local).AddTicks(3292));

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7027,
                column: "DateUpdated",
                value: new DateTime(2022, 6, 16, 1, 12, 8, 805, DateTimeKind.Local).AddTicks(3293));

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7028,
                column: "DateUpdated",
                value: new DateTime(2022, 6, 16, 1, 12, 8, 805, DateTimeKind.Local).AddTicks(3295));

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7029,
                column: "DateUpdated",
                value: new DateTime(2022, 6, 16, 1, 12, 8, 805, DateTimeKind.Local).AddTicks(3297));

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7030,
                column: "DateUpdated",
                value: new DateTime(2022, 6, 16, 1, 12, 8, 805, DateTimeKind.Local).AddTicks(3299));

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7031,
                column: "DateUpdated",
                value: new DateTime(2022, 6, 16, 1, 12, 8, 805, DateTimeKind.Local).AddTicks(3301));

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7032,
                column: "DateUpdated",
                value: new DateTime(2022, 6, 16, 1, 12, 8, 805, DateTimeKind.Local).AddTicks(3303));

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7033,
                column: "DateUpdated",
                value: new DateTime(2022, 6, 16, 1, 12, 8, 805, DateTimeKind.Local).AddTicks(3305));

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7034,
                column: "DateUpdated",
                value: new DateTime(2022, 6, 16, 1, 12, 8, 805, DateTimeKind.Local).AddTicks(3307));

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7035,
                column: "DateUpdated",
                value: new DateTime(2022, 6, 16, 1, 12, 8, 805, DateTimeKind.Local).AddTicks(3308));

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7036,
                column: "DateUpdated",
                value: new DateTime(2022, 6, 16, 1, 12, 8, 805, DateTimeKind.Local).AddTicks(3310));

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7037,
                column: "DateUpdated",
                value: new DateTime(2022, 6, 16, 1, 12, 8, 805, DateTimeKind.Local).AddTicks(3312));

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7038,
                column: "DateUpdated",
                value: new DateTime(2022, 6, 16, 1, 12, 8, 805, DateTimeKind.Local).AddTicks(3313));

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7039,
                column: "DateUpdated",
                value: new DateTime(2022, 6, 16, 1, 12, 8, 805, DateTimeKind.Local).AddTicks(3315));

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7040,
                column: "DateUpdated",
                value: new DateTime(2022, 6, 16, 1, 12, 8, 805, DateTimeKind.Local).AddTicks(3316));

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7041,
                column: "DateUpdated",
                value: new DateTime(2022, 6, 16, 1, 12, 8, 805, DateTimeKind.Local).AddTicks(3318));

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7042,
                column: "DateUpdated",
                value: new DateTime(2022, 6, 16, 1, 12, 8, 805, DateTimeKind.Local).AddTicks(3319));

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7043,
                column: "DateUpdated",
                value: new DateTime(2022, 6, 16, 1, 12, 8, 805, DateTimeKind.Local).AddTicks(3321));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ItemStatus",
                table: "Item",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7000,
                columns: new[] { "DateUpdated", "ItemStatus" },
                values: new object[] { new DateTime(2022, 6, 15, 19, 25, 30, 908, DateTimeKind.Local).AddTicks(4138), "Free" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7001,
                columns: new[] { "DateUpdated", "ItemStatus" },
                values: new object[] { new DateTime(2022, 6, 15, 19, 25, 30, 909, DateTimeKind.Local).AddTicks(5080), "Free" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7002,
                columns: new[] { "DateUpdated", "ItemStatus" },
                values: new object[] { new DateTime(2022, 6, 15, 19, 25, 30, 909, DateTimeKind.Local).AddTicks(5372), "Free" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7003,
                columns: new[] { "DateUpdated", "ItemStatus" },
                values: new object[] { new DateTime(2022, 6, 15, 19, 25, 30, 909, DateTimeKind.Local).AddTicks(5379), "Free" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7004,
                columns: new[] { "DateUpdated", "ItemStatus" },
                values: new object[] { new DateTime(2022, 6, 15, 19, 25, 30, 909, DateTimeKind.Local).AddTicks(5380), "Free" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7005,
                columns: new[] { "DateUpdated", "ItemStatus" },
                values: new object[] { new DateTime(2022, 6, 15, 19, 25, 30, 909, DateTimeKind.Local).AddTicks(5382), "Free" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7006,
                columns: new[] { "DateUpdated", "ItemStatus" },
                values: new object[] { new DateTime(2022, 6, 15, 19, 25, 30, 909, DateTimeKind.Local).AddTicks(5383), "Free" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7007,
                columns: new[] { "DateUpdated", "ItemStatus" },
                values: new object[] { new DateTime(2022, 6, 15, 19, 25, 30, 909, DateTimeKind.Local).AddTicks(5385), "Free" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7008,
                columns: new[] { "DateUpdated", "ItemStatus" },
                values: new object[] { new DateTime(2022, 6, 15, 19, 25, 30, 909, DateTimeKind.Local).AddTicks(5386), "Free" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7009,
                columns: new[] { "DateUpdated", "ItemStatus" },
                values: new object[] { new DateTime(2022, 6, 15, 19, 25, 30, 909, DateTimeKind.Local).AddTicks(5387), "Free" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7010,
                columns: new[] { "DateUpdated", "ItemStatus" },
                values: new object[] { new DateTime(2022, 6, 15, 19, 25, 30, 909, DateTimeKind.Local).AddTicks(5389), "Free" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7011,
                columns: new[] { "DateUpdated", "ItemStatus" },
                values: new object[] { new DateTime(2022, 6, 15, 19, 25, 30, 909, DateTimeKind.Local).AddTicks(5390), "Free" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7012,
                columns: new[] { "DateUpdated", "ItemStatus" },
                values: new object[] { new DateTime(2022, 6, 15, 19, 25, 30, 909, DateTimeKind.Local).AddTicks(5391), "Free" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7013,
                columns: new[] { "DateUpdated", "ItemStatus" },
                values: new object[] { new DateTime(2022, 6, 15, 19, 25, 30, 909, DateTimeKind.Local).AddTicks(5392), "Free" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7014,
                columns: new[] { "DateUpdated", "ItemStatus" },
                values: new object[] { new DateTime(2022, 6, 15, 19, 25, 30, 909, DateTimeKind.Local).AddTicks(5394), "Free" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7015,
                columns: new[] { "DateUpdated", "ItemStatus" },
                values: new object[] { new DateTime(2022, 6, 15, 19, 25, 30, 909, DateTimeKind.Local).AddTicks(5395), "Free" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7016,
                columns: new[] { "DateUpdated", "ItemStatus" },
                values: new object[] { new DateTime(2022, 6, 15, 19, 25, 30, 909, DateTimeKind.Local).AddTicks(5396), "Free" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7017,
                columns: new[] { "DateUpdated", "ItemStatus" },
                values: new object[] { new DateTime(2022, 6, 15, 19, 25, 30, 909, DateTimeKind.Local).AddTicks(5398), "Free" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7018,
                columns: new[] { "DateUpdated", "ItemStatus" },
                values: new object[] { new DateTime(2022, 6, 15, 19, 25, 30, 909, DateTimeKind.Local).AddTicks(5400), "Free" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7019,
                columns: new[] { "DateUpdated", "ItemStatus" },
                values: new object[] { new DateTime(2022, 6, 15, 19, 25, 30, 909, DateTimeKind.Local).AddTicks(5402), "Free" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7020,
                columns: new[] { "DateUpdated", "ItemStatus" },
                values: new object[] { new DateTime(2022, 6, 15, 19, 25, 30, 909, DateTimeKind.Local).AddTicks(5403), "Free" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7021,
                columns: new[] { "DateUpdated", "ItemStatus" },
                values: new object[] { new DateTime(2022, 6, 15, 19, 25, 30, 909, DateTimeKind.Local).AddTicks(5405), "Free" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7022,
                columns: new[] { "DateUpdated", "ItemStatus" },
                values: new object[] { new DateTime(2022, 6, 15, 19, 25, 30, 909, DateTimeKind.Local).AddTicks(5406), "Free" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7023,
                columns: new[] { "DateUpdated", "ItemStatus" },
                values: new object[] { new DateTime(2022, 6, 15, 19, 25, 30, 909, DateTimeKind.Local).AddTicks(5407), "Free" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7024,
                columns: new[] { "DateUpdated", "ItemStatus" },
                values: new object[] { new DateTime(2022, 6, 15, 19, 25, 30, 909, DateTimeKind.Local).AddTicks(5409), "Free" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7025,
                columns: new[] { "DateUpdated", "ItemStatus" },
                values: new object[] { new DateTime(2022, 6, 15, 19, 25, 30, 909, DateTimeKind.Local).AddTicks(5410), "Free" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7026,
                columns: new[] { "DateUpdated", "ItemStatus" },
                values: new object[] { new DateTime(2022, 6, 15, 19, 25, 30, 909, DateTimeKind.Local).AddTicks(5411), "Free" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7027,
                columns: new[] { "DateUpdated", "ItemStatus" },
                values: new object[] { new DateTime(2022, 6, 15, 19, 25, 30, 909, DateTimeKind.Local).AddTicks(5413), "Free" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7028,
                columns: new[] { "DateUpdated", "ItemStatus" },
                values: new object[] { new DateTime(2022, 6, 15, 19, 25, 30, 909, DateTimeKind.Local).AddTicks(5414), "Free" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7029,
                columns: new[] { "DateUpdated", "ItemStatus" },
                values: new object[] { new DateTime(2022, 6, 15, 19, 25, 30, 909, DateTimeKind.Local).AddTicks(5415), "Free" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7030,
                columns: new[] { "DateUpdated", "ItemStatus" },
                values: new object[] { new DateTime(2022, 6, 15, 19, 25, 30, 909, DateTimeKind.Local).AddTicks(5417), "Free" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7031,
                columns: new[] { "DateUpdated", "ItemStatus" },
                values: new object[] { new DateTime(2022, 6, 15, 19, 25, 30, 909, DateTimeKind.Local).AddTicks(5418), "Free" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7032,
                columns: new[] { "DateUpdated", "ItemStatus" },
                values: new object[] { new DateTime(2022, 6, 15, 19, 25, 30, 909, DateTimeKind.Local).AddTicks(5419), "Free" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7033,
                columns: new[] { "DateUpdated", "ItemStatus" },
                values: new object[] { new DateTime(2022, 6, 15, 19, 25, 30, 909, DateTimeKind.Local).AddTicks(5421), "Free" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7034,
                columns: new[] { "DateUpdated", "ItemStatus" },
                values: new object[] { new DateTime(2022, 6, 15, 19, 25, 30, 909, DateTimeKind.Local).AddTicks(5422), "Free" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7035,
                columns: new[] { "DateUpdated", "ItemStatus" },
                values: new object[] { new DateTime(2022, 6, 15, 19, 25, 30, 909, DateTimeKind.Local).AddTicks(5423), "Free" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7036,
                columns: new[] { "DateUpdated", "ItemStatus" },
                values: new object[] { new DateTime(2022, 6, 15, 19, 25, 30, 909, DateTimeKind.Local).AddTicks(5425), "Free" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7037,
                columns: new[] { "DateUpdated", "ItemStatus" },
                values: new object[] { new DateTime(2022, 6, 15, 19, 25, 30, 909, DateTimeKind.Local).AddTicks(5426), "Free" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7038,
                columns: new[] { "DateUpdated", "ItemStatus" },
                values: new object[] { new DateTime(2022, 6, 15, 19, 25, 30, 909, DateTimeKind.Local).AddTicks(5428), "Free" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7039,
                columns: new[] { "DateUpdated", "ItemStatus" },
                values: new object[] { new DateTime(2022, 6, 15, 19, 25, 30, 909, DateTimeKind.Local).AddTicks(5429), "Free" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7040,
                columns: new[] { "DateUpdated", "ItemStatus" },
                values: new object[] { new DateTime(2022, 6, 15, 19, 25, 30, 909, DateTimeKind.Local).AddTicks(5431), "Free" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7041,
                columns: new[] { "DateUpdated", "ItemStatus" },
                values: new object[] { new DateTime(2022, 6, 15, 19, 25, 30, 909, DateTimeKind.Local).AddTicks(5432), "Free" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7042,
                columns: new[] { "DateUpdated", "ItemStatus" },
                values: new object[] { new DateTime(2022, 6, 15, 19, 25, 30, 909, DateTimeKind.Local).AddTicks(5434), "Free" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 7043,
                columns: new[] { "DateUpdated", "ItemStatus" },
                values: new object[] { new DateTime(2022, 6, 15, 19, 25, 30, 909, DateTimeKind.Local).AddTicks(5435), "Free" });
        }
    }
}
