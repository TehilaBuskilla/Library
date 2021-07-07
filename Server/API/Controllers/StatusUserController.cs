using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DataObject;
using BL;
using System.Web.Http.Cors;

namespace API.Controllers
{
    [EnableCors("*", "*", "*")]

    [RoutePrefix("api/StatusUser")]

    public class StatusUserController : ApiController
    {
        //Get
        // GET: api/StatusUser
        [Route("GetAll")]
        [HttpGet]
        public List<StatusUserDTO> GetAll()
        {
            
            return StatusUserBL.GetAll();
        }

        //Add
        // POST: api/StatusUser
        [Route("{newStatusUser}")]
        [HttpPost]
        public int Post(StatusUserDTO newStatusUser)
        {
           
            return StatusUserBL.Add(newStatusUser);
        }

        //Update
        // PUT: api/StatusUser/5
        [Route("{upStatusUser}")]
        [HttpPut]
        public bool Put(StatusUserDTO upStatusUser)
        {
         
            return StatusUserBL.Update(upStatusUser);

        }

        //Delete
        // DELETE: api/StatusUser/5
        [Route("Delete/{CodeStatusUser}")]
        [HttpDelete]
        public bool Delete(int CodeStatusUser)
        {
            
            return StatusUserBL.Delete(CodeStatusUser);
        }
    }
}
