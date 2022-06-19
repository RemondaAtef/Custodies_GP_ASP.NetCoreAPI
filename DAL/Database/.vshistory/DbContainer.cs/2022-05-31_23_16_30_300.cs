using DB3GP.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DB3GP.DAL.Database
{
    public class DbContainer : DbContext
    {
        public DbSet<Item> Item { get; set; }
        //public DbSet<User> User { get; set; }
        public DbSet<Request> Request { get; set; }
        public DbSet<OwnerShip> OwnerShip { get; set; }
        public DbSet<Archive> Archive { get; set; }
        public DbSet<Member> Member { get; set; }
        public DbSet<Cart> Cart { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server = . ; database = impor4Project ; integrated security = true");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Item>()
                .HasData(new Item { ItemId = 1, ItemName = "Laptop", ItemType = "Electronic Device", UnitPrice = 20000, Serial = "234-156-18", Quantity = 1 },
                new Item{ ItemId = 2, ItemName = "Laptop",  ItemType = "Electronic Device", UnitPrice = 20000, Serial = "555-156-18", Quantity = 1,  Popular = "True" },
                new Item { ItemId = 3, ItemName = "Laptop",  ItemType = "Electronic Device", UnitPrice = 20000, Serial = "58-157-18", Quantity = 1 },
                new Item { ItemId = 4, ItemName = "Laptop",  ItemType = "Electronic Device", UnitPrice = 20000, Serial = "12-174-18", Quantity = 1 },
                new Item { ItemId = 5, ItemName = "Laptop",  ItemType = "Electronic Device", UnitPrice = 20000, Serial = "987-123-18", Quantity = 1 },
                new Item { ItemId = 6, ItemName = "Laptop",  ItemType = "Electronic Device", UnitPrice = 20000, Serial = "455-789-18", Quantity = 1 },
                new Item { ItemId = 7, ItemName = "Projector",  ItemType = "Electronic Device", UnitPrice = 1000, Serial = "57-156-18", Quantity = 1 },
                new Item { ItemId = 8, ItemName = "Data show", ItemType = "Electronic Device", UnitPrice = 15000, Serial = "555-156-18", Quantity = 1 , Popular = "True"},
                new Item { ItemId = 9, ItemName = "Screen",  ItemType = "Electronic Device", UnitPrice = 3000, Serial = "48-17-17", Quantity = 1 },
                new Item { ItemId = 10, ItemName = "Mouse",  ItemType = "Electronic Device", UnitPrice = 4000, Serial = "584-158-58", Quantity = 1 },
                new Item { ItemId = 11, ItemName = "Keyboard",  ItemType = "Electronic Device", UnitPrice = 2000, Serial = "12-34-509", Quantity = 1 },
                new Item { ItemId = 12, ItemName = "Scanner",  ItemType = "Electronic Device", UnitPrice = 3000, Serial = "72-34-09", Quantity = 1 },
                new Item { ItemId = 13, ItemName = "Printer",  ItemType = "Electronic Device", UnitPrice = 8000, Serial = "34-532-456", Quantity = 1 },
                new Item { ItemId = 14, ItemName = "Michrophone", ItemType = "Electronic Device", UnitPrice = 7000, Serial = "34-35-45", Quantity = 1 },
                new Item { ItemId = 15, ItemName = "Cabl",  ItemType = "Electronic Device", UnitPrice = 1000, Serial = "534-53-43", Quantity = 1 },
                new Item { ItemId = 16, ItemName = "Processor",  ItemType = "Electronic Device", UnitPrice = 2000, Serial = "78-74-47", Quantity = 1, Popular = "True" },
                new Item { ItemId = 17, ItemName = "Ram",  ItemType = "Electronic Device", UnitPrice = 1000, Serial = "47-74-15", Quantity = 1 },
                new Item { ItemId = 18, ItemName = "CD",  ItemType = "Electronic Device", UnitPrice = 50, Serial = "15-87-56", Quantity = 1 },
                new Item { ItemId = 19, ItemName = "Speaker",  ItemType = "Electronic Device", UnitPrice = 500, Serial = "45-87-94", Quantity = 1 },
                 new Item { ItemId =20,ItemName = "Table",  ItemType = "Furniture", UnitPrice = 500, Quantity = 10, Popular = "True" },
                 new Item { ItemId = 21, ItemName = "Chair",  ItemType = "Furniture", UnitPrice = 100, Quantity = 15 },
                 new Item { ItemId = 22, ItemName = "Clock",  ItemType = "Furniture", UnitPrice = 100, Quantity = 30 },
                 new Item { ItemId = 23, ItemName = "Chest",  ItemType = "Furniture", UnitPrice = 400, Quantity = 5 },
                 new Item { ItemId = 24, ItemName = "Cabinet",  ItemType = "Furniture", UnitPrice = 500, Quantity = 17 },
                 new Item { ItemId = 25, ItemName = "Benche",  ItemType = "Furniture", UnitPrice = 1000, Quantity = 20 },
                 new Item { ItemId = 26, ItemName = "Fire extingulisher", ItemType = "Furniture", UnitPrice = 400, Quantity = 7 },
                 new Item { ItemId = 27, ItemName = "Fan", ItemType = "Furniture", UnitPrice = 500, Quantity = 40 });

            //modelBuilder.Entity<User>()
            //.HasData(new User { UserId = 2018001, Email = "Remondaa@gmail.com", Name = "Remondaa", Number = 01256489975, Password = "remondaa1234####", ConfirmPassword = "remondaa1234####" },
            //new User { UserId = 2018002, Email = "Mirna@gmail.com", Name = "Mirna", Number = 01256874953, Password = "mirna1234####", ConfirmPassword = "mirna1234####" },
            //new User { UserId = 2018003, Email = "Moheb@gmail.com", Name = "Moheb", Number = 01257598461, Password = "moheb1234####", ConfirmPassword = "moheb1234####" },
            //new User { UserId = 2018004, Email = "Alaa@gmail.com", Name = "Alaa", Number = 01014672358, Password = "alaa1234####", ConfirmPassword = "alaa1234####" },
            //new User { UserId = 2018005, Email = "Araby@gmail.com", Name = "Araby", Number = 01272114568, Password = "araby1234####", ConfirmPassword = "araby1234####" },
            //new User { UserId = 2018006, Email = "Baioumy@gmail.com", Name = "Baioumy", Number = 01001235698, Password = "baioumy1234####", ConfirmPassword = "baioumy1234####" },
            //new User { UserId = 2018007, Email = "Ahmed@gmail.com", Name = "Ahmed", Number = 01236587491, Password = "ahmed1234####", ConfirmPassword = "ahmed1234####" });

            //modelBuilder.Entity<Request>()
            //    .HasData(new Request {RequestID =500, UserId = "2018001", ItemId = 1},
            //    new Request { RequestID = 501, UserId = "2018005", ItemId = 5 });

            //modelBuilder.Entity<Cart>()
            //    .HasData(new Cart { CartID = 5001, ItemId = 20, UserId = "2018002" });

            //  base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<OwnerShip>()
                  .HasData(new OwnerShip { OwnerShipID = 1000, ItemId = 10, UserId = "03e3d9d9-9b89-4952-b2ad-63ff0f0b9ad0" });

            modelBuilder.Entity<Request>()
                .HasData(new Request { RequestID = 515, ItemId = 25, RequestQuantity = 2 });
        }

    }
}

