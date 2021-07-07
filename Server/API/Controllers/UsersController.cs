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
   [EnableCors("*","*","*")]
    [RoutePrefix("api/Users")]

    public class UsersController : ApiController
    {
        //Get
        // GET: api/Users
        [Route("GetAll")]
        [HttpGet]
        public List<UsersDTO> GetAll()
        {
            
            return UsersBL.GetAll();
        }

        // Get
        // GET: api/Users/5
        [Route("Connect")]
        [HttpPost]
        public UsersDTO Connect([FromBody]UsersDTO existUser)//user signIn
        {
          
          return UsersBL.GetByCode(existUser);
        }

        //Add
        // POST: api/Users

        [Route("Post")]
        [HttpPost]
        public string Post(UsersDTO newUser)
        {
            
            return UsersBL.Add(newUser);
        }

        //Update
        // PUT: api/Users/5
        [Route("{upUser}")]
        [HttpPut]
        public bool Put(UsersDTO upUser)
        {
            
            return UsersBL.Update(upUser);

        }

        //Delete
        // DELETE: api/Users/5
        [Route("Delete/{IdUser}")]
        [HttpDelete]
        public bool Delete(string IdUser)
        {
            
            return UsersBL.Delete(IdUser);
        }
    }
}
