using DB3GP.BL.Repository;
using DB3GP.DAL.Entities;
using DB3GP.DAL.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DB3GP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        new UserRep User = new UserRep();

        [HttpGet("ViewProfile")]
        public IActionResult GetData(string email)  //view Myprofile by email
        {
            var data = User.ViewProfile(email);

            return Ok(data);
        }


        [HttpPut("UpdateMyProfile")]
        public IActionResult Update(string email, string name, string number, string password)   //Update my profile by email
        {
            User.ViewProfile2(email);

            var data = User.UpdateProfile(email, name, number, password);

            return Ok(data);
        }

        [HttpGet("ViewFurnitureOrElectronic")]
        public IActionResult ViewFurnitureOrElectronic(string itemType)
        {
            var data = User.GetFurnitureOrElectronic(itemType);

            return Ok(data);
        }

        [HttpGet("ViewItemDetails")]
        public IActionResult ViewItemDetails(int itemId) //view item details by itemID
        {
            var data = User.ViewDetails(itemId);

            return Ok(data);
        }

        [HttpGet("ShowMyCart")]
        public IActionResult ShowMyCart(string userId)  //View My Cart by UserID
        {
            var data = User.ViewCart(userId);

            return Ok(data);
        }

        [HttpGet("SearchItem")]
        public IActionResult Find(string name)  //Search item by itemName
        {
            var data = User.Search(name);

            return Ok(data);
        }

        [HttpPost("AddToItemCart")]
        public IActionResult AddtoMyCart(AddToCartVM dpt, string userid)  //Add item to my cart
        {
            User.AddToCart(dpt);

            var data  = User.ViewCart(userid);
            return Ok(data);

        }

        [HttpDelete("DeleteItemFromMyCart")]
        public void  DeleteItemFromMyCart(int id)  //delete item from my cart by itemID
        {
             User.DeleteFromCart(id);
            
        }

        [HttpPost("AddExistItemToMyCart")]
        public IActionResult AddExistItemToCart(string userid, int itemid)  //Add exist item to my cart by userID ,  ItemID
        {
            var data = User.AddExisttoCart(userid, itemid );
            return Ok(data);
        }

        [HttpGet("ViewMyCartToSendRequest")]
        public IActionResult RequestToTake(string userId)  //View my Cart by userID
        {
            var data = User.RequestToTake(userId);

            return Ok(data);
        }



        [HttpPost("RequestToTakeItem")]
        public void RequestToTake2(string userId)  //Request Item : Add items in request table and delete items from Cart table
        {
            User.RequestToTake2(userId); 
            
        }

        //[HttpDelete("RequestToTake3")]
        //public void RequestToTake3(int id)
        //{
        //    User.RequestToTake3(id);

        //}

        [HttpGet("GetMyOwnerShip")]
        public IActionResult GetMyOwnerShip(string userid)
        {
            var data = User.ShowMyOwnership(userid);

            return Ok(data);
        }

        [HttpGet("Popular")]
        public IActionResult Popular()
        {
            var data = User.PopularItems();

            return Ok(data);
        }
    }
}
