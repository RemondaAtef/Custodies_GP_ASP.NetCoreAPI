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

        [HttpGet("ViewDetails")]
        public IActionResult ViewItemDetails(int itemId)
        {
            var data = User.ViewDetails(itemId);

            return Ok(data);
        }

        [HttpGet("ShowMyCart")]
        public IActionResult ShowMyCart(string userId)
        {
            var data = User.ViewCart(userId);

            return Ok(data);
        }

        [HttpGet("Search")]
        public IActionResult Find(string name)
        {
            var data = User.Search(name);

            return Ok(data);
        }

        [HttpPost("AddToCart")]
        public IActionResult AddtoMyCart(AddToCartVM dpt, string userid)
        {
            User.AddToCart(dpt);

            var data  = User.ViewCart(userid);
            return Ok(data);

        }

        [HttpDelete("DeleteItemFromMyCart")]
        public void  DeleteItemFromMyCart(int id)
        {
             User.DeleteFromCart(id);
            
        }

        [HttpPost("AddExistItemToCart")]
        public IActionResult AddExistItemToCart(string userid, int itemid)
        {
            var data = User.AddExisttoCart(userid, itemid );
            return Ok(data);
        }

        [HttpGet("RequestToTake")]
        public IActionResult RequestToTake(string userId)
        {
            var data = User.RequestToTake(userId);

            return Ok(data);
        }



        [HttpPost("RequestToTake2")]
        public void RequestToTake2(string userId)
        {
            User.RequestToTake2(userId); 
            //var data = User.RequestToTake2(userId);

            //return Ok(data);
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
