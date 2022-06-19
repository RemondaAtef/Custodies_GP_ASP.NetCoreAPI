using DB3GP.BL.Repository;
using DB3GP.DAL.Entities;
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
    public class AdminController : ControllerBase
    {
        AdminRep Admin = new AdminRep();

        [HttpGet("GetAllItems")]
        public IActionResult GetAll()  //Get All items
        {
            var data = Admin.getAlldata();

            return Ok(data);
        }

        [HttpGet("GetAllUsers")]
        public IActionResult GetUsers()  //GetAllUsers
        {
            var data = Admin.getAllUsers();

            return Ok(data);
        }

        [HttpGet("GetAllRequests")]
        public IActionResult GetRequests()
        {
            var data = Admin.getAllRequests();

            return Ok(data);
        }

        [HttpGet("GetAllOwnership")]
        public IActionResult GetOwnerShip()
        {
            var data = Admin.getAllOwnership();

            return Ok(data);
        }

        [HttpPost("AddExistItem")]
        public IActionResult AddExistItem(string name, int QT)  //Add Exist Item : Furniture
        {
            var data = Admin.AddExistItemF(name, QT);
            return Ok(data);
        }

        [HttpPost("AddNewItem")]
        public IActionResult AddNewItem(Item dpt)  //Add new Item : Furniture or Electronic Device
        {
            Admin.AddNewItem(dpt);

            var data = Admin.getAlldata();
            return Ok(data);

        }

        //[HttpGet("GetRequeststoResponse")]
        //public IActionResult GetRequestsToResponse()  //Get All items
        //{
        //    var data = Admin.UpdateDatabase1();

        //    return Ok(data);
        //}

        [HttpPost("Response")]
        public void Responsetorequest(string requestStatus)
        {
            Admin.UpdateDatabase(requestStatus);
        }
    }
}
