using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LibraryDB.Controllers
{
    public class StatusForUsersController : ApiController
    {
        // GET: api/StatusForUsers
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/StatusForUsers/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/StatusForUsers
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/StatusForUsers/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/StatusForUsers/5
        public void Delete(int id)
        {
        }
    }
}
