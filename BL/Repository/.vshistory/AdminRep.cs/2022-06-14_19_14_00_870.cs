using DB3GP.BL.Interface;
using DB3GP.DAL.Database;
using DB3GP.DAL.Entities;
using DB3GP.DAL.ViewModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DB3GP.BL.Repository
{
    public class AdminRep : IAdminRep
    {
        DbContainer db = new DbContainer();

        public IEnumerable<Item> getAlldata()    //Get All items
        {
            var data = db.Item;

            return data;
        }

        public IEnumerable<getAllUsersVM> getAllUsers()   //GetAllUsers
        {
            var data = db.Member.Select(a => new getAllUsersVM() {  UserId = a.UserId, Name = a.Name, Email = a.Email, Number = a.Number});

            return data;
        }

      
        public IEnumerable<getAllOwnershipVM> getAllOwnership()
        {
            var data = db.OwnerShip.Select(a => new getAllOwnershipVM() {  UserID = a.UserId, ItemID = a.ItemId, UserName = a.Member.Name, ItemName = a.Item.ItemName, Date = a.OwnershipDate});

            return data;
        }

        public Item AddExistItemF(string name, int QT)   //Add Exist Item : Furniture
        {

            var data = db.Item.Where(a => a.ItemName == name && a.ItemType == "Furniture" )
                                 .Select(a => new Item { ItemId = a.ItemId, ItemName = a.ItemName, Quantity = a.Quantity + QT, ItemStatus = a.ItemStatus, UnitPrice = a.UnitPrice, Serial = a.Serial, ItemType = a.ItemType , DateUpdated = a.DateUpdated})
                                  .FirstOrDefault();

            db.Item.Update(data);
            db.SaveChanges();
            return data;
        }

        public Item AddNewItem(Item dpt)    //Add new Item : Furniture or Electronic Device
        { 
            
            Item d = new Item();
            
            d.ItemName = dpt.ItemName;
            d.ItemType = dpt.ItemType;
            d.Serial = dpt.Serial;
            d.UnitPrice = dpt.UnitPrice;
            d.DateUpdated = dpt.DateUpdated;
            if (d.ItemType == "Electronic Device"){

                d.Quantity = 1;
            }
            else if(d.ItemType == "Furniture")
            {
                d.Quantity = dpt.Quantity;
            }
            else
            {
                
            }

            db.Item.Add(d);
            db.SaveChanges();

            return dpt;
            //11111
            //if (dpt.ItemType == "Electronic Device")
            //{

            //    dpt.Quantity = 1;
            //}

            //db.Item.Add(dpt);
            //db.SaveChanges();

            //return dpt;
        }

        //public IEnumerable<string> Search(string name)
        //{
        //    var data = db.Item.Where(a => a.ItemName == name)
        //                          .Select(a => a.ItemName);

        //    return data;
        //}
        public IEnumerable<getAllRequestsVM> getAllRequests()
        {
            var data = db.Request.Select(a => new getAllRequestsVM() { ItemID = a.ItemId, RequestStatus = a.RequestStatus, UserID = a.UserId, UserName = a.Member.Name, ItemName = a.Item.ItemName });


            return data;
        }

        public Request UpdateDatabase1(string userid)
        {
            var data = db.Request.Where(a => a.TakeOrRestore == "Take" && a.UserId == userid)
                                .Select(a => new Request { UserId = a.UserId, ItemId = a.ItemId, RequestID = a.RequestID, RequestQuantity = a.RequestQuantity, RequestStatus = a.RequestStatus, StatusAfterRestore = a.StatusAfterRestore, TakeOrRestore = a.TakeOrRestore }).FirstOrDefault();
                                
                                
            //  var data = db.Request;

            return data;
        }
       
        public void UpdateDatabase(string requestStatus, string userid)
        {
            var data = UpdateDatabase1(userid);

            // Request data = new Request();

            if (requestStatus == "Accept")
            {
                OwnerShip d = new OwnerShip();

                Item d1 = new Item();

                d.ItemId = data.ItemId;
                d.UserId = data.UserId;
                d.OwnerShipQuantity = data.RequestQuantity;

                db.OwnerShip.Add(d);

                if (d1.ItemType == "Electronic Device")
                {
                    d1.ItemStatus = "Owned";
                }
                else if (d1.ItemType == "Furniture")
                {
                    d1.Quantity = d1.Quantity - data.RequestQuantity;
                }

                db.Request.Remove(data);

                db.SaveChanges();
            }
        }

        public IEnumerable<Item> Report()    
        {
            var data = db.Item;

            return data;
        }

    }
}
