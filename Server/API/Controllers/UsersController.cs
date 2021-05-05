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
        //שליפה
        // GET: api/Users
        [Route("GetAll")]
        [HttpGet]
        public List<UsersDTO> GetAll()
        {
            
            return UsersBL.GetAll();
        }

        //התחברות משתמש
        // GET: api/Users/5
        [Route("GetByCode/{existUser}")]
        [HttpGet]
        public UsersDTO GetByCode(UsersDTO existUser)
        {
          
          return UsersBL.GetByCode(existUser);
        }

        //הוספה
        // POST: api/Users
  
        [Route("Post")]
        [HttpPost]
        public string Post(UsersDTO newUser)
        {
            
            return UsersBL.Add(newUser);
        }

        //עדכון
        // PUT: api/Users/5
        [Route("{upUser}")]
        [HttpPut]
        public bool Put(UsersDTO upUser)
        {
            
            return UsersBL.Update(upUser);

        }

        //מחיקה
        // DELETE: api/Users/5
        [Route("Delete/{IdUser}")]
        [HttpDelete]
        public bool Delete(string IdUser)
        {
            
            return UsersBL.Delete(IdUser);
        }
    }
}
