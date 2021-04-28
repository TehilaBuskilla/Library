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
    [Route("api/Users")]

    public class UsersController : ApiController
    {
        //שליפה
        // GET: api/Users
        [Route("GetAll")]
        [HttpGet]
        public List<UsersDTO> GetAll()
        {
            
            return UsersBLL.GetAll();
        }

        //התחברות משתמש
        // GET: api/Users/5
        [Route("GetByCode/{existUser}")]
        [HttpGet]
        public UsersDTO GetByCode(UsersDTO existUser)
        {
          
          return UsersBLL.GetByCode(existUser);
        }

        //הוספה
        // POST: api/Users
  
        [Route("Post")]
        [HttpPost]
        public int Post(UsersDTO newUser)
        {
            
            return UsersBLL.Add(newUser);
        }

        //עדכון
        // PUT: api/Users/5
        [Route("{upUser}")]
        [HttpPut]
        public bool Put(UsersDTO upUser)
        {
            
            return UsersBLL.Update(upUser);

        }

        //מחיקה
        // DELETE: api/Users/5
        [Route("Delete/{IdUser}")]
        [HttpDelete]
        public bool Delete(int IdUser)
        {
            
            return UsersBLL.Delete(IdUser);
        }
    }
}
