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
        [Route("GetAll/{id}")]
        
        [HttpGet]
        public List<ReadingBooksDTO> GetAll(string id)
        {
            return BookToUserBL.GetAll(id);
        }


        [Route("GetById/{id}")]
        [HttpGet]
        public Dictionary<string, Dictionary<int, int>> GetById(string id)
        {
            return BookToUserBL.GetById(id);
        }

        //הוספה
        // POST: api/BookToUser
        [Route("Post")]
        [HttpPost]
        public void Post(List <BookToUserDTO> newBookToUser)
        {
             BookToUserBL.Add(newBookToUser);

        }

    

    }
}
