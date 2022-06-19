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
        IEnumerable<Item> getAlldata();   //Get All items
        public IEnumerable<getAllUsersVM> getAllUsers();    //GetAllUsers
        public IEnumerable<getAllRequestsVM> getAllRequests(); //done
        public IEnumerable<getAllOwnershipVM> getAllOwnership(); //done
        public Item AddExistItemF(string name, int QT);  //Add Exist Item : Furniture
        public Item AddNewItem(Item dpt);  //Add new Item : Furniture or Electronic Device

        // public IEnumerable<string> Search(string name);
        public Request UpdateDatabase1(string userid);
        public void UpdateDatabase(string requestStatus, string userid);
        public Item UpdateDatabase3(string requestStatus, string userid);
        public IEnumerable<Item> Report();
    }
}
