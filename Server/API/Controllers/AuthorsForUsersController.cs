using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using BL;
using DataObject;

namespace API.Controllers
{
    [EnableCors("*", "*", "*")]
    
    [RoutePrefix("api/AuthorsForUsers")]

    public class AuthorsForUsersController : ApiController
    {
        //שליפה
        // GET: api/AuthorsForUsers
        [Route("GetAll")]
        [HttpGet]
        public List<AuthorsForUsersDTO> GetAll()
        {
            
            return AuthorsForUsersBL.GetAll();


        }

        //שליפה ע"י נתון
        // GET: api/AuthorsForUsers/5
        [Route("GetById/{id}")]
        [HttpGet]
        public List<AuthorsForUsersDTO> GetById(string id)
        {
            return AuthorsForUsersBL.GetById(id);
        }

        //הוספה
        // POST: api/AuthorsForUsers
        [Route("{newAuthorForUser}")]
        [HttpPost]
        public int Post(AuthorsForUsersDTO newAuthorForUser)
        {
          
            return AuthorsForUsersBL.Add(newAuthorForUser);

        }

        //עדכון
        // PUT: api/AuthorsForUsers/5
        [Route("{upAuthorForUser}")]
        [HttpPut]
        public bool Put(AuthorsForUsersDTO upAuthorForUser)
        {
           
            return AuthorsForUsersBL.Update(upAuthorForUser);


        }

        //מחיקה
        // DELETE: api/AuthorsForUsers/5
        [Route("Delete/{CodeAuthorsForUsers}")]
        [HttpDelete]
        public bool Delete(int CodeAuthorsForUsers)
        {
           
            return AuthorsForUsersBL.Delete(CodeAuthorsForUsers);

        }
    }
}
