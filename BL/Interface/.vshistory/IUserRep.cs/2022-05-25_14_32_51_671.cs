using DB3GP.DAL.Entities;
using DB3GP.DAL.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DB3GP.BL.Interface
{
    interface IUserRep
    {
        ViewProfileVM ViewProfile(string email);   //view Myprofile by email
        Member ViewProfile2(string email); //when click edit button hy3rd el data bta3te
        public Member UpdateProfile(string email, string name, string number, string password); //Update my profile by email
        IEnumerable<string> GetFurnitureOrElectronic(string itemType);  //Get furniture or electronic by itemtype
        public ViewDetailsVM ViewDetails(int itemID);  //done
        public ViewCartVM ViewCart(string userId);
        public IEnumerable<string> Search(string name);       //done
        public AddToCartVM AddToCart(AddToCartVM dpt);  //done
        public Cart AddExisttoCart(string userid, int itemid);
        public void DeleteFromCart(int itemid);  //done
        
        //public Cart RequestToTake2(int userid, Cart cart);
        public IEnumerable<ShowMyOwnershipVM> ShowMyOwnership(string userid);
        public IEnumerable<string> PopularItems();
        public Cart RequestToTake(string userid);
        public void RequestToTake2(string userid);

    }
}
