using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class AudiencesController : ApiController
    {

        // GET: api/Audiences
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Audiences/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Audiences
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Audiences/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Audiences/5
        public void Delete(int id)
        {
        }
    }
}
