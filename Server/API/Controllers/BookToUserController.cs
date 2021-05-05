using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DataOdject;
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

        //שליפה ע"י נתון
        // GET: api/BookToUser/5

        //public string Get(int id)
        //{
        //    return "value";
        //}

         //הוספה
        // POST: api/BookToUser
        [Route("{newBookToUser}")]
        [HttpPost]
        public int Post(BookToUserDTO newBookToUser)
        {
            return BookToUserBL.Add(newBookToUser);

        }

        //עדכון
        // PUT: api/BookToUser/5
        [Route("{upBookToUser}")]
        [HttpPut]
        public bool Put(BookToUserDTO)
        {
            return BookToUserBL.Update(upBookToUser);

        }

        //מחיקה
        // DELETE: api/BookToUser/5
        [Route("Delete/{CodeStatusForUsers}")]
        [HttpDelete]
        public bool Delete(int CodeBookToUser)
        {
            return BookToUserBL.Delete(CodeBookToUser);

        }
    }
}
