using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BLL;
using DataObject;

namespace API.Controllers
{
    [RoutePrefix("api/AuthorsForUsers")]

    public class AuthorsForUsersController : ApiController
    {
        //שליפה
        // GET: api/AuthorsForUsers
        [Route("GetAll")]
        [HttpGet]
        public List<AuthorsForUsersDTO> GetAll()
        {
            
            return AuthorsForUsersBLL.GetAll();


        }

        //שליפה ע"י נתון
        // GET: api/AuthorsForUsers/5
        //[Route("Get/{}")]
        //[HttpGet]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //הוספה
        // POST: api/AuthorsForUsers
        [Route("{newAuthorForUser}")]
        [HttpPost]
        public int Post(AuthorsForUsersDTO newAuthorForUser)
        {
          
            return AuthorsForUsersBLL.Add(newAuthorForUser);

        }

        //עדכון
        // PUT: api/AuthorsForUsers/5
        [Route("{upAuthorForUser}")]
        [HttpPut]
        public bool Put(AuthorsForUsersDTO upAuthorForUser)
        {
           
            return AuthorsForUsersBLL.Update(upAuthorForUser);


        }

        //מחיקה
        // DELETE: api/AuthorsForUsers/5
        [Route("Delete/{CodeAuthorsForUsers}")]
        [HttpDelete]
        public bool Delete(int CodeAuthorsForUsers)
        {
           
            return AuthorsForUsersBLL.Delete(CodeAuthorsForUsers);

        }
    }
}
