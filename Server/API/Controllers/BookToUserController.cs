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

        //Get
        // GET: api/BookToUser
        [Route("GetAll/{id}/{love}")]
        [HttpGet]
        public List<ReadingBooksDTO> GetAll(string id,bool? love)
        {
            return BookToUserBL.GetAll(id,love);
        }

        //GetById
        // GET: api/BookToUser
        [Route("GetById/{id}")]   
        [HttpGet]
        public Dictionary<string, Dictionary<int, int>> GetById(string id) //create dictionary : key and value 
        {
            return BookToUserBL.GetById(id);
        }

        //Add
        // POST: api/BookToUser
        [Route("Post")]
        [HttpPost]
        public void Post( BookToUserDTO newBookToUser)
        {
             BookToUserBL.Add(newBookToUser);

        }

        //Update
        // PUT: api/BookToUser/5
        [Route("Put")]
        [HttpPut]
        public bool Put(BookToUserDTO newBookToUser)
        {
           return BookToUserBL.Update(newBookToUser);

        }
        //Delete
        // DELETE: api/BookToUser/5
        [Route("Delete/{CodeBookToUser}")]
        [HttpDelete]
        public bool Delete(int CodeBookToUser)
        {


            return BookToUserBL.Delete(CodeBookToUser);
        }





    }
}
