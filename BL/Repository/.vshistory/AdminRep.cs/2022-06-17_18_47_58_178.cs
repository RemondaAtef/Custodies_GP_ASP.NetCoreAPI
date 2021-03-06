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

      
        public IEnumerable<ItemNamePhoto> getAllItems()   //Get All items
        {
            var data = db.Item.Select(a => new ItemNamePhoto() { ItemName = a.ItemName, Image = a.Image });

            return data;
        }

        public IEnumerable<getAllUsersVM> getAllUsers()   //GetAllUsers
        {
            var data = db.Member.Select(a => new getAllUsersVM() { Name = a.Name, Email = a.Email, status = (DAL.ViewModel.MemberStatus)a.status});

            return data;
        }

        public IEnumerable<getAllOwnershipVM> getAllOwnership()
        {
            var data = db.OwnerShip.Select(a => new getAllOwnershipVM() {  UserName = a.Member.Name, ItemName = a.Item.ItemName, Quantitiy = a.OwnerShipQuantity, Date = a.OwnershipDate});

            return data;
        }

        public IEnumerable<getAllRequestsVM> getAllRequests()
        {
            var data = db.Request.Select(a => new getAllRequestsVM() { RequestStatus = a.RequestStatus,  statusAfterRestore = a.StatusAfterRestore , requestQuantity = a.RequestQuantity , takeOrrestore = a.TakeOrRestore, UserName = a.Member.Name, ItemName = a.Item.ItemName });

            return data;
        }

        public Item AddExistItemF(string name, int QT)   //Add Exist Item : Furniture
        {

            var data = db.Item.Where(a => a.ItemName == name && a.ItemType == "Furniture" )
                                 .Select(a => new Item { ItemId = a.ItemId, ItemName = a.ItemName, Quantity = a.Quantity + QT, UnitPrice = a.UnitPrice, Serial = a.Serial, ItemType = a.ItemType , DateUpdated = DateTime.Now, Image = a.Image})
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
            d.DateUpdated = DateTime.Now;
            if (d.ItemType == "Electronic Device"){

                d.Quantity = 1;
            }
            else if(d.ItemType == "Furniture")
            {
                d.Quantity = dpt.Quantity;
            }
           
            db.Item.Add(d);
         //   db.SaveChanges();

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
        
        public Request ReplyForRequest1(string userid , int itemid)   //Take
        {
            var data = db.Request.Where(a => a.TakeOrRestore == "Take" && a.UserId == userid && a.ItemId == itemid)
                                .Select(a => new Request { UserId = a.UserId, ItemId = a.ItemId, RequestID = a.RequestID, RequestQuantity = a.RequestQuantity, RequestStatus = a.RequestStatus, StatusAfterRestore = a.StatusAfterRestore, TakeOrRestore = a.TakeOrRestore })
                                .FirstOrDefault();
                        
         
            return data;
        }
       
        public void ReplyForRequest(string requestStatus, string userid ,int itemid)    //Take
        {
            var data = ReplyForRequest1(userid, itemid);

            OwnerShip d = new OwnerShip();
          
            if (requestStatus == "Accept" )
            {
                d.ItemId = data.ItemId;
                d.UserId = data.UserId;
                d.OwnerShipQuantity = data.RequestQuantity;
                d.OwnershipDate = DateTime.Now;

                db.OwnerShip.Add(d);
                db.SaveChanges();                              //1- Add item in Ownership TABLE

                var data1 = db.Item.Select(a => new Item { ItemId = a.ItemId, ItemName = a.ItemName, ItemType = a.ItemType, Image = a.Image, Popular = a.Popular, Serial = a.Serial, UnitPrice = a.UnitPrice, DateUpdated = DateTime.Now, Quantity = a.Quantity - data.RequestQuantity }).First();
                //.FirstOrDefault();
                db.Item.Update(data1);

                //Item I = new Item();
                //I.Quantity = I.Quantity - data.RequestQuantity;
                //I.ItemId = data.ItemId;
                // I.ItemName = data.Item.ItemName;
                //I.ItemType = data.Item.ItemType;
                //    I.Image = data.Item.Image;
                //   I.Popular = data.Item.Popular;
                //  I.Serial = data.Item.Serial;
                //  I.UnitPrice = data.Item.UnitPrice;

                //db.Item.Update(I);
                db.SaveChanges();                    // 2- Quantity in Item Table - RequestQuantity

               
                db.Request.Remove(data);
                db.SaveChanges();                   // 3 - Remove Row of Request in Request TABLE 
            }
            else if(requestStatus == "Reject")
            {
                db.Request.Remove(data);           // Remove  Row of Request in Request TABLE 
                db.SaveChanges();
            }
           
        }

        public Request ReplayforRestore(string userid, int itemid)
        {
            var data = db.Request.Where(a => a.TakeOrRestore == "Restore" && a.UserId == userid && a.ItemId == itemid)
                                .Select(a => new Request { UserId = a.UserId, ItemId = a.ItemId, RequestID = a.RequestID, RequestQuantity = a.RequestQuantity, RequestStatus = a.RequestStatus, StatusAfterRestore = a.StatusAfterRestore, TakeOrRestore = a.TakeOrRestore }).FirstOrDefault();


            return data;
        }

        public void ReplayforRestore2(string requestStatus, string userid, int itemid)
        {
            var data = ReplayforRestore(userid, itemid);

          //  OwnerShip d = new OwnerShip();
             Item I = new Item();

            if (requestStatus == "Restore")
            {
                
                var data1 = db.Item.Where(a => a.ItemId == itemid)
                                     .Select(a => new Item { ItemId = a.ItemId, ItemName = a.ItemName, ItemType = a.ItemType, Image = a.Image, Popular = a.Popular, Serial = a.Serial, UnitPrice = a.UnitPrice, DateUpdated = DateTime.Now, Quantity = a.Quantity + data.RequestQuantity })
                                     .FirstOrDefault();

                db.Item.Update(data1);
                db.SaveChanges();

                OwnerShip ownerShip;

                ownerShip = db.OwnerShip.Where(a => a.ItemId == data.ItemId && a.UserId == data.UserId)
                              .First();

                db.OwnerShip.Remove(ownerShip);
                db.SaveChanges();

                db.Request.Remove(data);
                db.SaveChanges();
            }
            else if (requestStatus == "Archive")
            {
                Archive archive = new Archive();

                archive.ItemId = data.ItemId;

                db.Archive.Add(archive);

               // arch.ItemId = data.ItemId;
                               
                db.SaveChanges();

                if (I.Quantity == 0)
                {
                    db.Item.Remove(I);
                    db.SaveChanges();
                }
                
                db.Request.Remove(data);
                db.SaveChanges();

            }

        }
        //public void UpdateDatabase3(string requestStatus, string userid, int itemid)
        //{
        //    var d1 = UpdateDatabase(requestStatus, userid, itemid);


        //    var data = db.Item.Where(a => a.ItemType == "Furniture")
        //                             .Select(a => new Item { ItemId = a.ItemId, ItemName = a.ItemName, ItemType = a.ItemType, ItemStatus = a.ItemStatus, Image = a.Image, Popular = a.Popular, Serial = a.Serial, UnitPrice = a.UnitPrice, DateUpdated = DateTime.Now, Quantity = a.Quantity - d1.RequestQuantity })
        //                             .FirstOrDefault();

        //    db.Item.Update(data);
        //    db.SaveChanges();

        //    //var data1 = db.Item.Where(a => a.ItemType == " Electronic Device")
        //    //                         .Select(a => new Item { ItemId = a.ItemId, ItemName = a.ItemName, ItemType = a.ItemType, ItemStatus = a.ItemStatus, Image = a.Image, Popular = a.Popular, Serial = a.Serial, UnitPrice = a.UnitPrice, DateUpdated = DateTime.Now, Quantity = a.Quantity - d1.RequestQuantity })
        //    //                         .FirstOrDefault();

        //    //db.Item.Update(data1);
        //    //db.SaveChanges();

        //    db.Request.Remove(d1);
        //    db.SaveChanges();
        //}

        public IEnumerable<Item> Report()
        {
            var data = db.Item;

            return data;
        }

    }
}
