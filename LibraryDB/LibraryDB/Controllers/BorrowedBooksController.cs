using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LibraryDB.Controllers
{
    public class BorrowedBooksController : ApiController
    {
        // GET: api/BorrowedBooks
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/BorrowedBooks/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/BorrowedBooks
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/BorrowedBooks/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/BorrowedBooks/5
        public void Delete(int id)
        {
        }
    }
}
