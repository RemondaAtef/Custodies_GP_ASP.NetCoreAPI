// <auto-generated />
using System;
using DB3GP.DAL.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DB3GP.Migrations
{
    [DbContext(typeof(DbContainer))]
    [Migration("20220614141703_firstmig")]
    partial class firstmig
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("DB3GP.DAL.Entities.Archive", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ItemId");

                    b.ToTable("Archive");
                });

            modelBuilder.Entity("DB3GP.DAL.Entities.Cart", b =>
                {
                    b.Property<int>("CartID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("CartQuantity")
                        .HasColumnType("int");

                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("CartID");

                    b.HasIndex("ItemId");

                    b.HasIndex("UserId");

                    b.ToTable("Cart");
                });

            modelBuilder.Entity("DB3GP.DAL.Entities.Item", b =>
                {
                    b.Property<int>("ItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ItemName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ItemStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ItemType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Popular")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("Serial")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UnitPrice")
                        .HasColumnType("int");

                    b.HasKey("ItemId");

                    b.ToTable("Item");

                    b.HasData(
                        new
                        {
                            ItemId = 1,
                            DateUpdated = new DateTime(2022, 6, 14, 16, 17, 3, 336, DateTimeKind.Local).AddTicks(8013),
                            Image = "637897191887265465.jpg",
                            ItemName = "Laptop HP-1",
                            ItemStatus = "Free",
                            ItemType = "Electronic Device",
                            Popular = "False",
                            Quantity = 1,
                            Serial = "234-156-185",
                            UnitPrice = 20000
                        },
                        new
                        {
                            ItemId = 2,
                            DateUpdated = new DateTime(2022, 6, 14, 16, 17, 3, 338, DateTimeKind.Local).AddTicks(1192),
                            Image = "637897191887265465.jpg",
                            ItemName = "Laptop Dell-1",
                            ItemStatus = "Free",
                            ItemType = "Electronic Device",
                            Popular = "True",
                            Quantity = 1,
                            Serial = "555-156-187",
                            UnitPrice = 25000
                        },
                        new
                        {
                            ItemId = 3,
                            DateUpdated = new DateTime(2022, 6, 14, 16, 17, 3, 338, DateTimeKind.Local).AddTicks(1450),
                            Image = "637897191887265465.jpg",
                            ItemName = "Laptop Apple-1",
                            ItemStatus = "Free",
                            ItemType = "Electronic Device",
                            Popular = "True",
                            Quantity = 1,
                            Serial = "584-157-189",
                            UnitPrice = 35000
                        },
                        new
                        {
                            ItemId = 4,
                            DateUpdated = new DateTime(2022, 6, 14, 16, 17, 3, 338, DateTimeKind.Local).AddTicks(1457),
                            Image = "637897191887265465.jpg",
                            ItemName = "Laptop Lenovo-1",
                            ItemStatus = "Free",
                            ItemType = "Electronic Device",
                            Popular = "False",
                            Quantity = 1,
                            Serial = "128-174-181",
                            UnitPrice = 22000
                        },
                        new
                        {
                            ItemId = 5,
                            DateUpdated = new DateTime(2022, 6, 14, 16, 17, 3, 338, DateTimeKind.Local).AddTicks(1459),
                            Image = "637897191887265465.jpg",
                            ItemName = "Laptop Amazon-1",
                            ItemStatus = "Free",
                            ItemType = "Electronic Device",
                            Popular = "False",
                            Quantity = 1,
                            Serial = "987-123-158",
                            UnitPrice = 15000
                        },
                        new
                        {
                            ItemId = 6,
                            DateUpdated = new DateTime(2022, 6, 14, 16, 17, 3, 338, DateTimeKind.Local).AddTicks(1460),
                            Image = "637897191887265465.jpg",
                            ItemName = "Laptop HP-2",
                            ItemStatus = "Free",
                            ItemType = "Electronic Device",
                            Popular = "False",
                            Quantity = 1,
                            Serial = "455-789-718",
                            UnitPrice = 40000
                        },
                        new
                        {
                            ItemId = 7,
                            DateUpdated = new DateTime(2022, 6, 14, 16, 17, 3, 338, DateTimeKind.Local).AddTicks(1464),
                            Image = "637897202071097364.jpg",
                            ItemName = "LCD-1 Projector",
                            ItemStatus = "Free",
                            ItemType = "Electronic Device",
                            Popular = "False",
                            Quantity = 1,
                            Serial = "557-156-918",
                            UnitPrice = 1000
                        },
                        new
                        {
                            ItemId = 8,
                            DateUpdated = new DateTime(2022, 6, 14, 16, 17, 3, 338, DateTimeKind.Local).AddTicks(1465),
                            Image = "637897199425146171.jpg",
                            ItemName = "Data show Screen A-1",
                            ItemStatus = "Free",
                            ItemType = "Electronic Device",
                            Popular = "True",
                            Quantity = 1,
                            Serial = "555-156-168",
                            UnitPrice = 15000
                        },
                        new
                        {
                            ItemId = 9,
                            DateUpdated = new DateTime(2022, 6, 14, 16, 17, 3, 338, DateTimeKind.Local).AddTicks(1466),
                            Image = "637897244563427963.jpg",
                            ItemName = "Screen UT-125",
                            ItemStatus = "Free",
                            ItemType = "Electronic Device",
                            Popular = "False",
                            Quantity = 1,
                            Serial = "488-147-187",
                            UnitPrice = 3000
                        },
                        new
                        {
                            ItemId = 10,
                            DateUpdated = new DateTime(2022, 6, 14, 16, 17, 3, 338, DateTimeKind.Local).AddTicks(1468),
                            Image = "637897200938565540.jpg",
                            ItemName = "Mouse k-45",
                            ItemStatus = "Free",
                            ItemType = "Electronic Device",
                            Popular = "False",
                            Quantity = 1,
                            Serial = "584-158-582",
                            UnitPrice = 4000
                        },
                        new
                        {
                            ItemId = 11,
                            DateUpdated = new DateTime(2022, 6, 14, 16, 17, 3, 338, DateTimeKind.Local).AddTicks(1469),
                            Image = "637897200406465686.jpg",
                            ItemName = "Keyboard rt-45",
                            ItemStatus = "Free",
                            ItemType = "Electronic Device",
                            Popular = "False",
                            Quantity = 1,
                            Serial = "152-434-509",
                            UnitPrice = 2000
                        },
                        new
                        {
                            ItemId = 12,
                            DateUpdated = new DateTime(2022, 6, 14, 16, 17, 3, 338, DateTimeKind.Local).AddTicks(1472),
                            Image = "637897244338111378.jpg",
                            ItemName = "Scanner",
                            ItemStatus = "Free",
                            ItemType = "Electronic Device",
                            Popular = "False",
                            Quantity = 1,
                            Serial = "782-314-059",
                            UnitPrice = 3000
                        },
                        new
                        {
                            ItemId = 13,
                            DateUpdated = new DateTime(2022, 6, 14, 16, 17, 3, 338, DateTimeKind.Local).AddTicks(1473),
                            Image = "637897201152036805.jpg",
                            ItemName = "Printer",
                            ItemStatus = "Free",
                            ItemType = "Electronic Device",
                            Popular = "False",
                            Quantity = 1,
                            Serial = "384-532-456",
                            UnitPrice = 8000
                        },
                        new
                        {
                            ItemId = 14,
                            DateUpdated = new DateTime(2022, 6, 14, 16, 17, 3, 338, DateTimeKind.Local).AddTicks(1474),
                            Image = "637897200712709232.jpg",
                            ItemName = "Michrophone",
                            ItemStatus = "Free",
                            ItemType = "Electronic Device",
                            Popular = "False",
                            Quantity = 1,
                            Serial = "345-735-645",
                            UnitPrice = 7000
                        },
                        new
                        {
                            ItemId = 15,
                            DateUpdated = new DateTime(2022, 6, 14, 16, 17, 3, 338, DateTimeKind.Local).AddTicks(1476),
                            Image = "637897191119246922.jpg",
                            ItemName = "Air Condition",
                            ItemStatus = "Free",
                            ItemType = "Furniture",
                            Popular = "False",
                            Quantity = 15,
                            Serial = "534-553-453",
                            UnitPrice = 1000
                        },
                        new
                        {
                            ItemId = 16,
                            DateUpdated = new DateTime(2022, 6, 14, 16, 17, 3, 338, DateTimeKind.Local).AddTicks(1477),
                            Image = "637897201590504495.jpg",
                            ItemName = "Processor",
                            ItemStatus = "Free",
                            ItemType = "Electronic Device",
                            Popular = "True",
                            Quantity = 1,
                            Serial = "278-754-467",
                            UnitPrice = 2000
                        },
                        new
                        {
                            ItemId = 17,
                            DateUpdated = new DateTime(2022, 6, 14, 16, 17, 3, 338, DateTimeKind.Local).AddTicks(1479),
                            Image = "637897202777982906.jpg",
                            ItemName = "Ram",
                            ItemStatus = "Free",
                            ItemType = "Electronic Device",
                            Popular = "False",
                            Quantity = 1,
                            Serial = "487-754-155",
                            UnitPrice = 1000
                        },
                        new
                        {
                            ItemId = 18,
                            DateUpdated = new DateTime(2022, 6, 14, 16, 17, 3, 338, DateTimeKind.Local).AddTicks(1480),
                            Image = "637897198576352429.jpg",
                            ItemName = "CD",
                            ItemStatus = "Free",
                            ItemType = "Electronic Device",
                            Popular = "False",
                            Quantity = 1,
                            Serial = "157-875-556",
                            UnitPrice = 50
                        },
                        new
                        {
                            ItemId = 19,
                            DateUpdated = new DateTime(2022, 6, 14, 16, 17, 3, 338, DateTimeKind.Local).AddTicks(1481),
                            Image = "637897244778262668.jpg",
                            ItemName = "Speaker",
                            ItemStatus = "Free",
                            ItemType = "Electronic Device",
                            Popular = "False",
                            Quantity = 1,
                            Serial = "445-787-594",
                            UnitPrice = 500
                        },
                        new
                        {
                            ItemId = 20,
                            DateUpdated = new DateTime(2022, 6, 14, 16, 17, 3, 338, DateTimeKind.Local).AddTicks(1483),
                            Image = "637897245239864495.jpg",
                            ItemName = "Table",
                            ItemStatus = "Free",
                            ItemType = "Furniture",
                            Popular = "True",
                            Quantity = 10,
                            Serial = "455-887-954",
                            UnitPrice = 500
                        },
                        new
                        {
                            ItemId = 21,
                            DateUpdated = new DateTime(2022, 6, 14, 16, 17, 3, 338, DateTimeKind.Local).AddTicks(1484),
                            Image = "637897198856333003.jpg",
                            ItemName = "Chair",
                            ItemStatus = "Free",
                            ItemType = "Furniture",
                            Popular = "False",
                            Quantity = 15,
                            Serial = "457-887-924",
                            UnitPrice = 100
                        },
                        new
                        {
                            ItemId = 22,
                            DateUpdated = new DateTime(2022, 6, 14, 16, 17, 3, 338, DateTimeKind.Local).AddTicks(1486),
                            Image = "637897199283252911.jpg",
                            ItemName = "Clock",
                            ItemStatus = "Free",
                            ItemType = "Furniture",
                            Popular = "False",
                            Quantity = 30,
                            Serial = "459-878-948",
                            UnitPrice = 100
                        },
                        new
                        {
                            ItemId = 23,
                            DateUpdated = new DateTime(2022, 6, 14, 16, 17, 3, 338, DateTimeKind.Local).AddTicks(1488),
                            Image = "637897199104943091.jpg",
                            ItemName = "Chest",
                            ItemStatus = "Free",
                            ItemType = "Furniture",
                            Popular = "False",
                            Quantity = 5,
                            Serial = "475-877-894",
                            UnitPrice = 400
                        },
                        new
                        {
                            ItemId = 24,
                            DateUpdated = new DateTime(2022, 6, 14, 16, 17, 3, 338, DateTimeKind.Local).AddTicks(1489),
                            Image = "637897192735551218.jpg",
                            ItemName = "Cabinet",
                            ItemStatus = "Free",
                            ItemType = "Furniture",
                            Popular = "False",
                            Quantity = 17,
                            Serial = "425-887-994",
                            UnitPrice = 500
                        },
                        new
                        {
                            ItemId = 25,
                            DateUpdated = new DateTime(2022, 6, 14, 16, 17, 3, 338, DateTimeKind.Local).AddTicks(1491),
                            Image = "637896963384916375.jpg",
                            ItemName = "Benche",
                            ItemStatus = "Free",
                            ItemType = "Furniture",
                            Popular = "False",
                            Quantity = 20,
                            Serial = "457-887-914",
                            UnitPrice = 1000
                        },
                        new
                        {
                            ItemId = 26,
                            DateUpdated = new DateTime(2022, 6, 14, 16, 17, 3, 338, DateTimeKind.Local).AddTicks(1492),
                            Image = "637897199842894480.jpg",
                            ItemName = "Fire extingulisher",
                            ItemStatus = "Free",
                            ItemType = "Furniture",
                            Popular = "False",
                            Quantity = 7,
                            Serial = "405-878-974",
                            UnitPrice = 400
                        },
                        new
                        {
                            ItemId = 27,
                            DateUpdated = new DateTime(2022, 6, 14, 16, 17, 3, 338, DateTimeKind.Local).AddTicks(1493),
                            Image = "637897199686917787.jpg",
                            ItemName = "Fan",
                            ItemStatus = "Free",
                            ItemType = "Furniture",
                            Popular = "False",
                            Quantity = 40,
                            Serial = "845-877-914",
                            UnitPrice = 500
                        },
                        new
                        {
                            ItemId = 28,
                            DateUpdated = new DateTime(2022, 6, 14, 16, 17, 3, 338, DateTimeKind.Local).AddTicks(1495),
                            Image = "637897202071097364.jpg",
                            ItemName = "Handeld Projector",
                            ItemStatus = "Free",
                            ItemType = "Electronic Device",
                            Popular = "False",
                            Quantity = 1,
                            Serial = "587-156-138",
                            UnitPrice = 1000
                        },
                        new
                        {
                            ItemId = 29,
                            DateUpdated = new DateTime(2022, 6, 14, 16, 17, 3, 338, DateTimeKind.Local).AddTicks(1498),
                            Image = "637897202071097364.jpg",
                            ItemName = "CRT Projector",
                            ItemStatus = "Free",
                            ItemType = "Electronic Device",
                            Popular = "False",
                            Quantity = 1,
                            Serial = "579-156-188",
                            UnitPrice = 1000
                        },
                        new
                        {
                            ItemId = 30,
                            DateUpdated = new DateTime(2022, 6, 14, 16, 17, 3, 338, DateTimeKind.Local).AddTicks(1499),
                            Image = "637897202071097364.jpg",
                            ItemName = "Laptop Dell-2",
                            ItemStatus = "Free",
                            ItemType = "Electronic Device",
                            Popular = "False",
                            Quantity = 1,
                            Serial = "455-789-178",
                            UnitPrice = 20000
                        },
                        new
                        {
                            ItemId = 31,
                            DateUpdated = new DateTime(2022, 6, 14, 16, 17, 3, 338, DateTimeKind.Local).AddTicks(1501),
                            Image = "637897202071097364.jpg",
                            ItemName = "Laptop Apple-2",
                            ItemStatus = "Free",
                            ItemType = "Electronic Device",
                            Popular = "False",
                            Quantity = 1,
                            Serial = "455-789-168",
                            UnitPrice = 20000
                        },
                        new
                        {
                            ItemId = 32,
                            DateUpdated = new DateTime(2022, 6, 14, 16, 17, 3, 338, DateTimeKind.Local).AddTicks(1502),
                            Image = "637897202071097364.jpg",
                            ItemName = "Laptop Lenovo-2",
                            ItemStatus = "Free",
                            ItemType = "Electronic Device",
                            Popular = "False",
                            Quantity = 1,
                            Serial = "129-174-818",
                            UnitPrice = 20000
                        },
                        new
                        {
                            ItemId = 33,
                            DateUpdated = new DateTime(2022, 6, 14, 16, 17, 3, 338, DateTimeKind.Local).AddTicks(1503),
                            Image = "637897202071097364.jpg",
                            ItemName = "Laptop Amazon-2",
                            ItemStatus = "Free",
                            ItemType = "Electronic Device",
                            Popular = "False",
                            Quantity = 1,
                            Serial = "987-123-518",
                            UnitPrice = 20000
                        },
                        new
                        {
                            ItemId = 34,
                            DateUpdated = new DateTime(2022, 6, 14, 16, 17, 3, 338, DateTimeKind.Local).AddTicks(1505),
                            Image = "637897199425146171.jpg",
                            ItemName = "Data show Screen C-123",
                            ItemStatus = "Free",
                            ItemType = "Electronic Device",
                            Popular = "True",
                            Quantity = 1,
                            Serial = "555-156-185",
                            UnitPrice = 15000
                        },
                        new
                        {
                            ItemId = 35,
                            DateUpdated = new DateTime(2022, 6, 14, 16, 17, 3, 338, DateTimeKind.Local).AddTicks(1506),
                            Image = "637897199425146171.jpg",
                            ItemName = "Data show Screen D-489",
                            ItemStatus = "Free",
                            ItemType = "Electronic Device",
                            Popular = "True",
                            Quantity = 1,
                            Serial = "555-156-188",
                            UnitPrice = 15000
                        },
                        new
                        {
                            ItemId = 36,
                            DateUpdated = new DateTime(2022, 6, 14, 16, 17, 3, 338, DateTimeKind.Local).AddTicks(1508),
                            Image = "637897244563427963.jpg",
                            ItemName = "Screen IE-187",
                            ItemStatus = "Free",
                            ItemType = "Electronic Device",
                            Popular = "False",
                            Quantity = 1,
                            Serial = "482-178-179",
                            UnitPrice = 3000
                        },
                        new
                        {
                            ItemId = 37,
                            DateUpdated = new DateTime(2022, 6, 14, 16, 17, 3, 338, DateTimeKind.Local).AddTicks(1509),
                            Image = "637897244563427963.jpg",
                            ItemName = "Screen PE-789",
                            ItemStatus = "Free",
                            ItemType = "Electronic Device",
                            Popular = "False",
                            Quantity = 1,
                            Serial = "487-157-167",
                            UnitPrice = 3000
                        },
                        new
                        {
                            ItemId = 38,
                            DateUpdated = new DateTime(2022, 6, 14, 16, 17, 3, 338, DateTimeKind.Local).AddTicks(1510),
                            Image = "637897200938565540.jpg",
                            ItemName = "Mouse GE-48",
                            ItemStatus = "Free",
                            ItemType = "Electronic Device",
                            Popular = "False",
                            Quantity = 1,
                            Serial = "584-158-586",
                            UnitPrice = 4000
                        },
                        new
                        {
                            ItemId = 39,
                            DateUpdated = new DateTime(2022, 6, 14, 16, 17, 3, 338, DateTimeKind.Local).AddTicks(1512),
                            Image = "637897200938565540.jpg",
                            ItemName = "Mouse WO-45",
                            ItemStatus = "Free",
                            ItemType = "Electronic Device",
                            Popular = "False",
                            Quantity = 1,
                            Serial = "584-158-858",
                            UnitPrice = 4000
                        },
                        new
                        {
                            ItemId = 40,
                            DateUpdated = new DateTime(2022, 6, 14, 16, 17, 3, 338, DateTimeKind.Local).AddTicks(1513),
                            Image = "637897200406465686.jpg",
                            ItemName = "Keyboard e-4",
                            ItemStatus = "Free",
                            ItemType = "Electronic Device",
                            Popular = "False",
                            Quantity = 1,
                            Serial = "162-346-509",
                            UnitPrice = 2000
                        },
                        new
                        {
                            ItemId = 41,
                            DateUpdated = new DateTime(2022, 6, 14, 16, 17, 3, 338, DateTimeKind.Local).AddTicks(1514),
                            Image = "637897200406465686.jpg",
                            ItemName = "Keyboard i-7",
                            ItemStatus = "Free",
                            ItemType = "Electronic Device",
                            Popular = "False",
                            Quantity = 1,
                            Serial = "129-364-509",
                            UnitPrice = 2000
                        },
                        new
                        {
                            ItemId = 42,
                            DateUpdated = new DateTime(2022, 6, 14, 16, 17, 3, 338, DateTimeKind.Local).AddTicks(1516),
                            Image = "637897192165684906.jpg",
                            ItemName = "Basket",
                            ItemStatus = "Free",
                            ItemType = "Furniture",
                            Popular = "False",
                            Quantity = 40,
                            Serial = "495-867-964",
                            UnitPrice = 500
                        },
                        new
                        {
                            ItemId = 43,
                            DateUpdated = new DateTime(2022, 6, 14, 16, 17, 3, 338, DateTimeKind.Local).AddTicks(1517),
                            Image = "637897192370070754.jpg",
                            ItemName = "Board",
                            ItemStatus = "Free",
                            ItemType = "Furniture",
                            Popular = "False",
                            Quantity = 40,
                            Serial = "495-897-974",
                            UnitPrice = 500
                        },
                        new
                        {
                            ItemId = 44,
                            DateUpdated = new DateTime(2022, 6, 14, 16, 17, 3, 338, DateTimeKind.Local).AddTicks(1519),
                            Image = "637897195418551957.jpg",
                            ItemName = "Case",
                            ItemStatus = "Free",
                            ItemType = "Electronic Device",
                            Popular = "False",
                            Quantity = 40,
                            Serial = "485-587-924",
                            UnitPrice = 500
                        });
                });

            modelBuilder.Entity("DB3GP.DAL.Entities.Member", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Number")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<int>("status")
                        .HasColumnType("int");

                    b.HasKey("UserId");

                    b.ToTable("Member");

                    b.HasData(
                        new
                        {
                            UserId = "5e844823-8fba-428c-8161-5b04e298748c",
                            Email = "Mondaa@gmail.com",
                            Name = "Mondaa",
                            Number = "0101236548",
                            Password = "5e844823-8fba-428c-8161-5b0458d7r6dkfore45",
                            Role = 1,
                            status = 1
                        },
                        new
                        {
                            UserId = "5e889423-8fba-428c-8161-5b04e298748c",
                            Email = "Remondaa@gmail.com",
                            Name = "Remondaa",
                            Number = "0125697834",
                            Password = "5e844823-8fba-428c-8161-5b0458d7r6dkfore45",
                            Role = 1,
                            status = 1
                        });
                });

            modelBuilder.Entity("DB3GP.DAL.Entities.OwnerShip", b =>
                {
                    b.Property<int>("OwnerShipID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.Property<int>("OwnerShipQuantity")
                        .HasColumnType("int");

                    b.Property<DateTime>("OwnershipDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("OwnerShipID");

                    b.HasIndex("ItemId");

                    b.HasIndex("UserId");

                    b.ToTable("OwnerShip");
                });

            modelBuilder.Entity("DB3GP.DAL.Entities.Request", b =>
                {
                    b.Property<int>("RequestID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.Property<int>("RequestQuantity")
                        .HasColumnType("int");

                    b.Property<string>("RequestStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StatusAfterRestore")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TakeOrRestore")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("RequestID");

                    b.HasIndex("ItemId");

                    b.HasIndex("UserId");

                    b.ToTable("Request");
                });

            modelBuilder.Entity("DB3GP.DAL.Entities.Archive", b =>
                {
                    b.HasOne("DB3GP.DAL.Entities.Item", "Item")
                        .WithMany()
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Item");
                });

            modelBuilder.Entity("DB3GP.DAL.Entities.Cart", b =>
                {
                    b.HasOne("DB3GP.DAL.Entities.Item", "Item")
                        .WithMany()
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DB3GP.DAL.Entities.Member", "Member")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("Item");

                    b.Navigation("Member");
                });

            modelBuilder.Entity("DB3GP.DAL.Entities.OwnerShip", b =>
                {
                    b.HasOne("DB3GP.DAL.Entities.Item", "Item")
                        .WithMany()
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DB3GP.DAL.Entities.Member", "Member")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("Item");

                    b.Navigation("Member");
                });

            modelBuilder.Entity("DB3GP.DAL.Entities.Request", b =>
                {
                    b.HasOne("DB3GP.DAL.Entities.Item", "Item")
                        .WithMany()
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DB3GP.DAL.Entities.Member", "Member")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("Item");

                    b.Navigation("Member");
                });
#pragma warning restore 612, 618
        }
    }
}
