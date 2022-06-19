using DB3GP.BL.Repository;
using DB3GP.DAL.Database;
using DB3GP.DAL.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DB3GP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MemberController : ControllerBase
    {
        DbContainer db = new DbContainer();
        // GET: api/<MemberController>
        [HttpGet("GetAllUsers")]
        public IEnumerable<Member> GetAllUsers()  //Get All Users
        {
            return db.Member;
        }

        // GET api/<MemberController>/5
        [HttpGet("GetUserByID{id}")]
        public Member GetUserByID(string id)           //Get User by Id (login)  
        {
            var member = db.Member.Find(id);
            return member;
        }

        // POST api/<MemberController>
        [HttpPost("AddNewUser")]
        public void AddNewUser(Member member)   // Add new User ( signup)
        {
            Guid g = Guid.NewGuid();
            member.UserId = g.ToString();
            member.Role = MemberRole.Normal;
            member.status = MemberStatus.Inactive;
            member.Password= UserRep.getHash(member.Password);
            db.Member.Add(member);
            db.SaveChanges();
        }

        [HttpPost("ActiveMember{id}")]
        public IActionResult ActiveMember(string id)     //when admin active User , status = 1 
        {
            var member = db.Member.Find(id);
            member.status = MemberStatus.Active;
            db.Member.Update(member);
            db.SaveChanges();
            return Ok(member);
        }

        
        //// PUT api/<MemberController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<MemberController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
