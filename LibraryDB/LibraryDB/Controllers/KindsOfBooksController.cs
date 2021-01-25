using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LibraryDB.Controllers
{
    public class KindsOfBooksController : ApiController
    {
        // GET: api/KindsOfBooks
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/KindsOfBooks/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/KindsOfBooks
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/KindsOfBooks/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/KindsOfBooks/5
        public void Delete(int id)
        {
        }
    }
}
