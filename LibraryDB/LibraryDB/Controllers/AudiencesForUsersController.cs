using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LibraryDB.Controllers
{
    public class AudiencesForUsersController : ApiController
    {
        // GET: api/AudiencesForUsers
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/AudiencesForUsers/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/AudiencesForUsers
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/AudiencesForUsers/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/AudiencesForUsers/5
        public void Delete(int id)
        {
        }
    }
}
