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
    [RoutePrefix("api/BorrowedBooks")]

    public class BorrowedBooksController : ApiController
    {
        //Get
        // GET: api/BorrowedBooks
        [Route("GetAll")]
        [HttpGet]
        public List<BorrowedBooksDTO> GetAll()
        {

            
            return BorrowedBooksBL.GetAll();
        }

        //Add
        // POST: api/BorrowedBooks
        [Route("{newBorrowedBook}")]
        [HttpPost]
        public int Post(BorrowedBooksDTO newBorrowedBook)
        {
            
            return BorrowedBooksBL.Add(newBorrowedBook);

        }

        //Update
        // PUT: api/BorrowedBooks/5
        [Route("{upBorrowedBook}")]
        [HttpPut]
        public bool Put(BorrowedBooksDTO upBorrowedBook)
        {
            
            return BorrowedBooksBL.Update(upBorrowedBook);
        }

        //Delete
        // DELETE: api/BorrowedBooks/5
        [Route("Delete/{CodeBorrowedBooks}")]
        [HttpDelete]
        public bool Delete(int CodeBorrowedBooks)
        {
            
            return BorrowedBooksBL.Delete(CodeBorrowedBooks);

        }
    }
}
