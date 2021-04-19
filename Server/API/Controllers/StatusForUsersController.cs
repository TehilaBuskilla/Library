using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DataObject;
using BLL;

namespace API.Controllers
{
    [RoutePrefix("api/StatusForUsers")]

    public class StatusForUsersController : ApiController
    {
        //שליפה
        // GET: api/StatusForUsers
        [Route("GetAll")]
        [HttpGet]
        public List<StatusForUsersDTO> GetAll()
        {
           
            return StatusForUsersBLL.GetAll();
        }

        //שליפה ע"י נתון
        // GET: api/StatusForUsers/5
        //[Route("Get/{}")]
        //[HttpGet]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //הוספה
        // POST: api/StatusForUsers
        [Route("{newStatusForUser}")]
        [HttpPost]
        public int Post(StatusForUsersDTO newStatusForUser)
        {
            
            return StatusForUsersBLL.Add(newStatusForUser);
            
        }

        //עדכון
        // PUT: api/StatusForUsers/5
        [Route("{upStatusForUser}")]
        [HttpPut]
        public bool Put(StatusForUsersDTO upStatusForUser)
        {
           
            return StatusForUsersBLL.Update(upStatusForUser);

        }

        //מחיקה
        // DELETE: api/StatusForUsers/5
        [Route("Delete/{CodeStatusForUsers}")]
        [HttpDelete]
        public bool Delete(int CodeStatusForUsers)
        {
           
            return StatusForUsersBLL.Delete(CodeStatusForUsers);
        }
    }
}
