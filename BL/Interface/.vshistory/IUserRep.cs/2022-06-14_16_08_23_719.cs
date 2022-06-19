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
                                                                                                // IEnumerable<string> GetFurnitureOrElectronic(string itemType);  //Get furniture or electronic by itemtype
        public IEnumerable<ItemNamePhoto> GetFurniture();  //Get furniture 
        public ViewDetailsVM ViewDetails(int itemID);  //view item details by itemID
        public ViewCartVM ViewCart(string userId);     //View My Cart by UserID
        public IEnumerable<string> Search(string name);       //Search item by itemName
        public AddToCartVM AddToCart(AddToCartVM dpt);  //Add item to my cart
        public Cart AddExisttoCart(string userid, int itemid);  //Add exist item to my cart by userID ,  ItemID
        public void DeleteFromCart(int itemid);   //delete item from my cart by itemID
        public OwnerShip RequestToRestore2(string userid,int itemid);  //Show myOwnerShip by userID
        public IEnumerable<string> PopularItems();  //Show Popular items
        public Cart RequestToTake(string userid);  //View my Cart by userID
        public void RequestToTake2(string userid);  //Request Item : Add items in request table and delete items from Cart table

        public void RequestToRestore(string userid, int itemid, string statusAfterRestore);
        public IEnumerable<ShowMyOwnershipVM> ShowMyOwnership(string userid);  //Show myOwnerShip by userID
    }
}
