using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DataObject;
using BL;
using System.Web.Http.Cors;

namespace API.Controllers
{
    [EnableCors("*", "*", "*")]
    [RoutePrefix("api/Algoritem")]
    public class AlgoritemController : ApiController
    {
        //שליפה
        // GET: api/Audiences
        [Route("GetAll")]
        [HttpGet]
        public List<ReadingBooksDTO> GetAll()
        {
            return AlgoritemBL.GetAll();
        }

        // POST: api/Algoritem
        public static void Post(Dictionary<string,Dictionary<int,int>> dictionaryAlgo,UsersDTO userIn)
        {
            AlgoritemBL.Add(dictionaryAlgo, userIn);
        }

        
    }
}
