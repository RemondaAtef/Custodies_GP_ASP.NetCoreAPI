using DB3GP.BL.Repository;
using DB3GP.DAL.Database;
using DB3GP.DAL.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace DB3GP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        AdminRep Admin = new AdminRep();
        DbContainer db = new DbContainer();

        [HttpGet("GetAllItems")]
        public IActionResult GetAllItems()  //Get All items
        {
            var data = Admin.getAllItems();

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

        //[HttpPost("AddNewItem")]
        //public IActionResult AddNewItem(Item dpt)  //Add new Item : Furniture or Electronic Device
        //{
        //    Admin.AddNewItem(dpt);

        //    var data = Admin.getAllItems();
        //    return Ok(data);

        //}

        private async Task<string> WriteFile(IFormFile file , [FromForm]Item item)
        {

            string fileName = "";

            try
            {
                var extension = "." + file.FileName.Split('.')[file.FileName.Split('.').Length - 1];
                fileName = DateTime.Now.Ticks + extension;
                var pathBuilt = Path.Combine(Directory.GetCurrentDirectory(), "Upload\\files");

                if (!Directory.Exists(pathBuilt))
                {
                    Directory.CreateDirectory(pathBuilt);

                }
                var path = Path.Combine(Directory.GetCurrentDirectory(), "Upload\\files", fileName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }
                

                item.Image = fileName;
                db.Item.Add(item);
                Admin.AddNewItem(item);
                db.SaveChanges();
             
            }
            catch (Exception ex)
            {
                // return ex.Message.ToString();
                return ex.InnerException.Message;
            }
            return fileName;
        }

        [HttpPost("AddNewItem")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> AddNewItem(IFormFile file,  [FromForm] Item item,CancellationToken cancellationToken )
        {
            var result = await WriteFile(file, item);

            return Ok(result);
        }


        //[HttpGet("GetRequeststoResponse")]
        //public IActionResult GetRequestsToResponse(string userid, int itemid)  //Get All items
        //{
        //    var data = Admin.ReplyForRequest1(userid, itemid);

        //    return Ok(data);
        //}

        [HttpPost("ResponseforTake")]
        public void Responsetorequest(string requestStatus, string userid, int itemid)
        {
            Admin.ReplyForRequest(requestStatus, userid, itemid);
        }


        [HttpPost("ResponseForRestore")]
        public void Responsetorestore(string requestStatus, string userid, int itemid)
        {
            Admin.ReplayforRestore2(requestStatus, userid, itemid);
        }

        //[HttpPost("ResponseForFurniture")]
        //public void Responsetorequest2(string requestStatus, string userid, int itemid)
        //{
        //    Admin.UpdateDatabase3(requestStatus, userid, itemid);

        //    // return Ok();
        //}

        [HttpGet("Report")]
        public IActionResult GetReport()  //Get All items
        {
            var data = Admin.Report();

            return Ok(data);
        }
    }
}
