using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LibraryDB.Controllers
{
    public class ProfileBooksController : ApiController
    {
        // GET: api/ProfileBooks
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/ProfileBooks/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/ProfileBooks
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/ProfileBooks/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/ProfileBooks/5
        public void Delete(int id)
        {
        }
    }
}
