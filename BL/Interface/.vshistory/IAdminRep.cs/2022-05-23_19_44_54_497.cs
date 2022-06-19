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
        IEnumerable<Item> getAlldata();   //done
        public IEnumerable<getAllUsersVM> getAllUsers();    //done
        public IEnumerable<getAllRequestsVM> getAllRequests(); //done
        public IEnumerable<getAllOwnershipVM> getAllOwnership(); //done
        public Item AddExistItemF(string name, int QT);
        public Item AddNewItem(Item dpt);

       // public IEnumerable<string> Search(string name);
    }
}
