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
    [RoutePrefix("api/BookToUser")]
    public class BookToUserController : ApiController
    {
        //שליפה
        // GET: api/BookToUser
        [Route("GetAll")]
        [HttpGet]
        public List<BookToUserDTO> GetAll()
        {
            return BookToUserBL.GetAll();
        }

     
         //הוספה
        // POST: api/BookToUser
        [Route("{newBookToUser}")]
        [HttpPost]
        public void Post(List <BookToUserDTO> newBookToUser)
        {
             BookToUserBL.Add(newBookToUser);

        }

    

    }
}
