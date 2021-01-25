using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LibraryDB.Controllers
{
    public class ReadingBooksController : ApiController
    {
        // GET: api/ReadingBooks
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/ReadingBooks/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/ReadingBooks
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/ReadingBooks/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/ReadingBooks/5
        public void Delete(int id)
        {
        }
    }
}
