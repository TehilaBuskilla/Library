using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class AuthorsForUsersController : ApiController
    {

        // GET: api/AuthorsForUsers
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/AuthorsForUsers/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/AuthorsForUsers
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/AuthorsForUsers/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/AuthorsForUsers/5
        public void Delete(int id)
        {
        }
    }
}
