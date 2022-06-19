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
            optionsBuilder.UseSqlServer("server = . ; database = impor7Project ; integrated security = true");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Item>()
                .HasData(new Item { ItemId = 1, ItemName = "Laptop HP-1", ItemType = "Electronic Device", UnitPrice = 20000, Serial = "234-156-185", Quantity = 1, Image = "637897191887265465.jpg" },
                new Item { ItemId = 2, ItemName = "Laptop Dell-1", ItemType = "Electronic Device", UnitPrice = 25000, Serial = "555-156-187", Quantity = 1, Popular = "True", Image = "637897191887265465.jpg" },
                new Item { ItemId = 3, ItemName = "Laptop Apple-1", ItemType = "Electronic Device", UnitPrice = 35000, Serial = "584-157-189", Quantity = 1, Popular = "True", Image = "637897191887265465.jpg" },
                new Item { ItemId = 4, ItemName = "Laptop Lenovo-1", ItemType = "Electronic Device", UnitPrice = 22000, Serial = "128-174-181", Quantity = 1, Image = "637897191887265465.jpg" },
                new Item { ItemId = 5, ItemName = "Laptop Amazon-1", ItemType = "Electronic Device", UnitPrice = 15000, Serial = "987-123-158", Quantity = 1, Image = "637897191887265465.jpg" },
                new Item { ItemId = 6, ItemName = "Laptop HP-2", ItemType = "Electronic Device", UnitPrice = 40000, Serial = "455-789-718", Quantity = 1, Image = "637897191887265465.jpg" },
                new Item { ItemId = 7, ItemName = "LCD-1 Projector", ItemType = "Electronic Device", UnitPrice = 1000, Serial = "557-156-918", Quantity = 1, Image = "637897202071097364.jpg" },
                new Item { ItemId = 8, ItemName = "Data show Screen A-1", ItemType = "Electronic Device", UnitPrice = 15000, Serial = "555-156-168", Quantity = 1, Popular = "True", Image = "637897199425146171.jpg" },
                new Item { ItemId = 9, ItemName = "Screen UT-125", ItemType = "Electronic Device", UnitPrice = 3000, Serial = "488-147-187", Quantity = 1, Image = "637897244563427963.jpg" },
                new Item { ItemId = 10, ItemName = "Mouse k-45", ItemType = "Electronic Device", UnitPrice = 4000, Serial = "584-158-582", Quantity = 1, Image = "637897200938565540.jpg" },
                new Item { ItemId = 11, ItemName = "Keyboard rt-45", ItemType = "Electronic Device", UnitPrice = 2000, Serial = "152-434-509", Quantity = 1, Image = "637897200406465686.jpg" },
                new Item { ItemId = 12, ItemName = "Scanner", ItemType = "Electronic Device", UnitPrice = 3000, Serial = "782-314-059", Quantity = 1, Image = "637897244338111378.jpg" },
                new Item { ItemId = 13, ItemName = "Printer", ItemType = "Electronic Device", UnitPrice = 8000, Serial = "384-532-456", Quantity = 1, Image = "637897201152036805.jpg" },
                new Item { ItemId = 14, ItemName = "Michrophone", ItemType = "Electronic Device", UnitPrice = 7000, Serial = "345-735-645", Quantity = 1, Image = "637897200712709232.jpg" },
                new Item { ItemId = 15, ItemName = "Air Condition", ItemType = "Furniture", UnitPrice = 1000, Serial = "534-553-453", Quantity = 15, Image = "637897191119246922.jpg" },
                new Item { ItemId = 16, ItemName = "Processor", ItemType = "Electronic Device", UnitPrice = 2000, Serial = "278-754-467", Quantity = 1, Popular = "True", Image = "637897201590504495.jpg" },
                new Item { ItemId = 17, ItemName = "Ram", ItemType = "Electronic Device", UnitPrice = 1000, Serial = "487-754-155", Quantity = 1, Image = "637897202777982906.jpg" },
                new Item { ItemId = 18, ItemName = "CD", ItemType = "Electronic Device", UnitPrice = 50, Serial = "157-875-556", Quantity = 1, Image = "637897198576352429.jpg" },
                new Item { ItemId = 19, ItemName = "Speaker", ItemType = "Electronic Device", UnitPrice = 500, Serial = "445-787-594", Quantity = 1, Image = "637897244778262668.jpg" },
                 new Item { ItemId = 20, ItemName = "Table", ItemType = "Furniture", UnitPrice = 500, Serial = "455-887-954", Quantity = 10, Popular = "True", Image = "637897245239864495.jpg" },
                 new Item { ItemId = 21, ItemName = "Chair", ItemType = "Furniture", UnitPrice = 100, Serial = "457-887-924", Quantity = 15, Image = "637897198856333003.jpg" },
                 new Item { ItemId = 22, ItemName = "Clock", ItemType = "Furniture", UnitPrice = 100, Serial = "459-878-948", Quantity = 30, Image = "637897199283252911.jpg" },
                 new Item { ItemId = 23, ItemName = "Chest", ItemType = "Furniture", UnitPrice = 400, Serial = "475-877-894", Quantity = 5, Image = "637897199104943091.jpg" },
                 new Item { ItemId = 24, ItemName = "Cabinet", ItemType = "Furniture", UnitPrice = 500, Serial = "425-887-994", Quantity = 17, Image = "637897192735551218.jpg" },
                 new Item { ItemId = 25, ItemName = "Benche", ItemType = "Furniture", UnitPrice = 1000, Serial = "457-887-914", Quantity = 20, Image = "637896963384916375.jpg" },
                 new Item { ItemId = 26, ItemName = "Fire extingulisher", ItemType = "Furniture", Serial = "405-878-974", UnitPrice = 400, Quantity = 7, Image = "637897199842894480.jpg" },
                 new Item { ItemId = 27, ItemName = "Fan", ItemType = "Furniture", UnitPrice = 500, Serial = "845-877-914", Quantity = 40, Image = "637897199686917787.jpg" },
                 new Item { ItemId = 28, ItemName = "Handeld Projector", ItemType = "Electronic Device", UnitPrice = 1000, Serial = "587-156-138", Quantity = 1, Image = "637897202071097364.jpg" },
                 new Item { ItemId = 29, ItemName = "CRT Projector", ItemType = "Electronic Device", UnitPrice = 1000, Serial = "579-156-188", Quantity = 1, Image = "637897202071097364.jpg" },
                 new Item { ItemId = 30, ItemName = "Laptop Dell-2", ItemType = "Electronic Device", UnitPrice = 20000, Serial = "455-789-178", Quantity = 1, Image = "637897202071097364.jpg" },
                 new Item { ItemId = 31, ItemName = "Laptop Apple-2", ItemType = "Electronic Device", UnitPrice = 20000, Serial = "455-789-168", Quantity = 1, Image = "637897202071097364.jpg" },
                 new Item { ItemId = 32, ItemName = "Laptop Lenovo-2", ItemType = "Electronic Device", UnitPrice = 20000, Serial = "129-174-818", Quantity = 1, Image = "637897202071097364.jpg" },
                new Item { ItemId = 33, ItemName = "Laptop Amazon-2", ItemType = "Electronic Device", UnitPrice = 20000, Serial = "987-123-518", Quantity = 1, Image = "637897202071097364.jpg" },
                new Item { ItemId = 34, ItemName = "Data show Screen C-123", ItemType = "Electronic Device", UnitPrice = 15000, Serial = "555-156-185", Quantity = 1, Popular = "True", Image = "637897199425146171.jpg" },
                new Item { ItemId = 35, ItemName = "Data show Screen D-489", ItemType = "Electronic Device", UnitPrice = 15000, Serial = "555-156-188", Quantity = 1, Popular = "True", Image = "637897199425146171.jpg" },
                new Item { ItemId = 36, ItemName = "Screen IE-187", ItemType = "Electronic Device", UnitPrice = 3000, Serial = "482-178-179", Quantity = 1, Image = "637897244563427963.jpg" },
                new Item { ItemId = 37, ItemName = "Screen PE-789", ItemType = "Electronic Device", UnitPrice = 3000, Serial = "487-157-167", Quantity = 1, Image = "637897244563427963.jpg" },
                new Item { ItemId = 38, ItemName = "Mouse GE-48", ItemType = "Electronic Device", UnitPrice = 4000, Serial = "584-158-586", Quantity = 1, Image = "637897200938565540.jpg" },
                new Item { ItemId = 39, ItemName = "Mouse WO-45", ItemType = "Electronic Device", UnitPrice = 4000, Serial = "584-158-858", Quantity = 1, Image = "637897200938565540.jpg" },
                new Item { ItemId = 40, ItemName = "Keyboard e-4", ItemType = "Electronic Device", UnitPrice = 2000, Serial = "162-346-509", Quantity = 1, Image = "637897200406465686.jpg" },
                new Item { ItemId = 41, ItemName = "Keyboard i-7", ItemType = "Electronic Device", UnitPrice = 2000, Serial = "129-364-509", Quantity = 1, Image = "637897200406465686.jpg" },
                new Item { ItemId = 42, ItemName = "Basket", ItemType = "Furniture", UnitPrice = 500, Serial = "495-867-964", Quantity = 40, Image = "637897192165684906.jpg" },
                new Item { ItemId = 43, ItemName = "Board", ItemType = "Furniture", UnitPrice = 500, Serial = "495-897-974", Quantity = 40, Image = "637897192370070754.jpg" },
                new Item { ItemId = 44, ItemName = "Case", ItemType = "Electronic Device", UnitPrice = 500, Serial = "485-587-924", Quantity = 40, Image = "637897195418551957.jpg" });


            //modelBuilder.Entity<Request>()
            //    .HasData(new Request {RequestID =500, UserId = "2018001", ItemId = 1},
            //    new Request { RequestID = 501, UserId = "2018005", ItemId = 5 });

            modelBuilder.Entity<Cart>()
                .HasData(new Cart { CartID = 5001, ItemId = 20, UserId = "2018002" });

            //  base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Member>()
                .HasData(new Member { UserId = "5e844823-8fba-428c-8161-5b04e298748c", Name = "Mondaa", Email = "Mondaa@gmail.com", Number = "0101236548", Password = "5e844823-8fba-428c-8161-5b0458d7r6dkfore45", Role = MemberRole.Admin, status = MemberStatus.Active },
                new Member { UserId = "5e889423-8fba-428c-8161-5b04e298748c", Name = "Remondaa", Email = "Remondaa@gmail.com", Number = "0125697834", Password = "5e844823-8fba-428c-8161-5b0458d7r6dkfore45", Role = MemberRole.Admin, status = MemberStatus.Active });
        }
    }
    }


