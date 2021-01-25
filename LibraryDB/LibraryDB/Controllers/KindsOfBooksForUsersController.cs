using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LibraryDB.Controllers
{
    public class KindsOfBooksForUsersController : ApiController
    {
        // GET: api/KindsOfBooksForUsers
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/KindsOfBooksForUsers/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/KindsOfBooksForUsers
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/KindsOfBooksForUsers/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/KindsOfBooksForUsers/5
        public void Delete(int id)
        {
        }
    }
}
