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

        [HttpGet("GetData")]
        public IActionResult GetAll()
        {
            var data = Admin.getAlldata();

            return Ok(data);
        }

        [HttpGet("GetUsers")]
        public IActionResult GetUsers()
        {
            var data = Admin.getAllUsers();

            return Ok(data);
        }

        [HttpGet("GetRequests")]
        public IActionResult GetRequests()
        {
            var data = Admin.getAllRequests();

            return Ok(data);
        }

        [HttpGet("GetOwnership")]
        public IActionResult GetOwnerShip()
        {
            var data = Admin.getAllOwnership();

            return Ok(data);
        }

        [HttpPost("AddExistItem")]
        public IActionResult AddExistItem(string name, int QT)
        {
            var data = Admin.AddExistItemF(name, QT);
            return Ok(data);
        }

        [HttpPost("AddNewItem")]
        public IActionResult AddNewItem(Item dpt)
        {
            Admin.AddNewItem(dpt);

            var data = Admin.getAlldata();
            return Ok(data);

        }
    }
}
