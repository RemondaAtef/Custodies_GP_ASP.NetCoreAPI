using DB3GP.DAL.Entities;
using DB3GP.DAL.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DB3GP.BL.Interface
{
    interface IAdminRep
    {
        public IEnumerable<ItemNamePhoto> getAllItems();   //Get All items
        public IEnumerable<getAllUsersVM> getAllUsers();    //GetAllUsers
        public IEnumerable<getAllRequestsVM> getAllRequests(); //done
        public IEnumerable<getAllOwnershipVM> getAllOwnership(); //done
        public Item AddExistItemF(string name, int QT);  //Add Exist Item : Furniture
        public Item AddNewItem(Item dpt);  //Add new Item : Furniture or Electronic Device

        // public IEnumerable<string> Search(string name);
        public Request ReplyForRequest1(string userid, int itemid);
        public void ReplyForRequest(string requestStatus, string userid, int itemid);
       // public void UpdateDatabase3(string requestStatus, string userid, int itemid);
        public IEnumerable<Item> Report();

        public Request ReplayforRestore(string userid, int itemid);

        public void ReplayforRestore2(string requestStatus, string userid, int itemid);
    }
}
