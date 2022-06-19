using DB3GP.BL.Interface;
using DB3GP.DAL.Database;
using DB3GP.DAL.Entities;
using DB3GP.DAL.ViewModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DB3GP.BL.Repository
{
    public class UserRep : IUserRep
    {
        DbContainer db = new DbContainer();

        public ViewProfileVM ViewProfile(string email)     //view Myprofile by email
        {
            var data = db.Member.Where(a => a.Email == email)
                     .Select(a => new ViewProfileVM() { Email = a.Email, UserName = a.Name })
                     .FirstOrDefault();

            return data;
        }

        public Member ViewProfile2(string email)       //when click edit button hy3rd el data bta3te
        {
            return db.Member.Where(a => a.Email == email)
                     .Select(a => new Member { UserId = a.UserId, Name = a.Name, Email = a.Email, Number = a.Number, Password = a.Password })
                     .FirstOrDefault();

        }

        public Member UpdateProfile(string email, string name, string number, string password)   //Update my profile by email
        {
            var data = ViewProfile2(email);

            if (name != null && number == null && password == null)   //edit my name
            {
                data.Name = name;
                db.Member.Update(data);
                db.SaveChanges();
            }
            else if (name != null && number != null && password == null )   // edit name & number
            {
                data.Name = name;
                data.Number = number;
                db.Member.Update(data);
                db.SaveChanges();
            }
            else if (name != null && number != null && password != null )   //edit name & number & password
            {
                data.Name = name;
                data.Number = number;
                data.Password = password;
                
                db.Member.Update(data);
                db.SaveChanges();
            }
            else if (name == null && number != null && password == null )   //edit number
            {
                data.Number = number;
                db.Member.Update(data);
                db.SaveChanges();
            }
            else if (name == null && number != null && password != null )  //edit number & pasword
            {
                data.Number = number;
                data.Password = password;
                
                db.Member.Update(data);
                db.SaveChanges();
            }
            else if (name == null && number == null && password != null )  //edit password
            {
                data.Password = password;
               
                db.Member.Update(data);
                db.SaveChanges();
            }
            return data;
        }

        public IEnumerable<ItemNamePhoto> GetFurniture()   //Get furniture 
        {
            var data = db.Item.Where(a => a.ItemType == "Furniture")
                              .Select(a => new ItemNamePhoto() { ItemName = a.ItemName, Image = a.Image });
                              

            return data;
        }
        public IEnumerable<ItemNamePhoto> GetElectronic()   //Get Electronic
        {
            var data = db.Item.Where(a => a.ItemType == "Electronic Device")
                              .Select(a => new ItemNamePhoto() { ItemName = a.ItemName, Image = a.Image });


            return data;
        }
        public ViewDetailsVM ViewDetails(int itemID)   //view item details by itemID
        {
            var data = db.Item.Where(a => a.ItemId == itemID)
                              .Select(a => new ViewDetailsVM() { ItemName = a.ItemName, ItemType = a.ItemType, ItemStatus = a.ItemStatus, Quantity = a.Quantity, Serial = a.Serial })
                              .FirstOrDefault();
            return data;
        }

        public ViewCartVM ViewCart(string userId)  //View My Cart by UserID
        {
            var data = db.Cart.Where(a => a.UserId == userId)
                              .Select(a => new ViewCartVM() { ItemName = a.Item.ItemName }).FirstOrDefault();


            return data;
        }

        public IEnumerable<string> Search(string name)   //Search item by itemName
        {
            var data = db.Item.Where(a => a.ItemName == name)
                                  .Select(a => a.ItemName);

            return data;
        }


        public Cart AddExisttoCart(string userid, int itemid)   //Add exist item to my cart by userID ,  ItemID
        {

            var data = db.Cart.Where(a => a.UserId == userid && a.ItemId == itemid)
                                  .Select(a => new Cart { CartID = a.CartID, ItemId = a.ItemId, UserId = a.UserId, CartQuantity = a.CartQuantity + 1 })
                                  .FirstOrDefault();


            db.Cart.Update(data);
            db.SaveChanges();
            return data;
        }


        public AddToCartVM AddToCart(AddToCartVM dpt)  //Add item to my cart 
        {
            Cart d = new Cart();

            d.ItemId = dpt.ItemId;
            d.UserId = dpt.UserId;

            db.Cart.Add(d);
            db.SaveChanges();

            return dpt;
        }

        public void DeleteFromCart(int itemid)  //delete item from my cart by itemID
        {
            Cart cart;

            cart = db.Cart.Where(a => a.ItemId == itemid)
                          .First();

            db.Cart.Remove(cart);
            db.SaveChanges();
        }


        public Cart RequestToTake(string userid)     //View my Cart by userID
        {
            var data = db.Cart.Where(a => a.UserId == userid)
                               .Select(a => new Cart {  CartID = a.CartID ,UserId = a.UserId, ItemId = a.ItemId, CartQuantity = a.CartQuantity })
                               .FirstOrDefault();


            return data;
        }


        public void RequestToTake2(string userid)     //Request Item : Add items in request table and delete items from Cart table
        {
            var data = RequestToTake(userid);

            Request d = new Request();
            
            d.ItemId = data.ItemId;
            d.UserId = data.UserId;
            d.RequestQuantity = data.CartQuantity;
            d.TakeOrRestore = "Take";
            db.Request.Add(d);
           
            db.Cart.Remove(data);
            db.SaveChanges();

        }
       public void RequestToRestore(string userid,int itemid, string statusAfterRestore)
        {
            var data = RequestToRestore2(userid, itemid);

            Request d = new Request();

            d.ItemId = itemid;
            d.UserId = data.UserId;
            d.StatusAfterRestore = statusAfterRestore;
            d.TakeOrRestore = "Restore";
            d.RequestQuantity = data.OwnerShipQuantity;

            db.Request.Add(d);
            db.SaveChanges();

        }

        public OwnerShip RequestToRestore2(string userid, int itemid)   //search in Ownership by userid , itemid
        {
            var data = db.OwnerShip.Where(a => a.UserId == userid && a.ItemId == itemid)
                .Select(a => new OwnerShip { OwnerShipID = a.OwnerShipID,  UserId = a.UserId, ItemId = a.ItemId, OwnershipDate = a.OwnershipDate, OwnerShipQuantity = a.OwnerShipQuantity }).FirstOrDefault();

            return data;
        }
        public IEnumerable<ShowMyOwnershipVM> ShowMyOwnership(string userid)   //Show myOwnerShip by userID
        {
            var data = db.OwnerShip.Where(a => a.UserId == userid)
                .Select(a => new ShowMyOwnershipVM() { ItemName = a.Item.ItemName, Date = a.OwnershipDate });

            return data;
        }

        public IEnumerable<string> PopularItems()   //Show Popular items
        {
            var data = db.Item.Where(a => a.Popular == "True")
                                  .Select(a => a.ItemName);

            return data;
        }

        public static string getHash(string text)   //Password : Hash
        {
            // SHA512 is disposable by inheritance.  
            using (var sha256 = SHA256.Create())
            {
                // Send a sample text to hash.  
                var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(text));
                // Get the hashed string.  
                return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }
        }


    }
}
