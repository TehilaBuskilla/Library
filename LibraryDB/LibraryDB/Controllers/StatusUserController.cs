using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LibraryDB.Controllers
{
    public class StatusUserController : ApiController
    {
        // GET: api/StatusUser
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/StatusUser/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/StatusUser
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/StatusUser/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/StatusUser/5
        public void Delete(int id)
        {
        }
    }
}
