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
    [RoutePrefix("api/KindsOfBooks")]

    public class KindsOfBooksController : ApiController
    {
        //Get
        // GET: api/KindsOfBooks
        [Route("GetAll")]
        [HttpGet]
        public List<KindsOfBooksDTO> GetAll()
        {
            
            return KindsOfBooksBL.GetAll();
        }

        //Add
        // POST: api/KindsOfBooks
        [Route("{newKindOfBook}")]
        [HttpPost]
        public int Post(KindsOfBooksDTO newKindOfBook)
        {
            
            return KindsOfBooksBL.Add(newKindOfBook);
        }

        //Update
        // PUT: api/KindsOfBooks/5
        [Route("{upKindOfBook}")]
        [HttpPut]
        public bool Put(KindsOfBooksDTO upKindOfBook)
        {
            
            return KindsOfBooksBL.Update(upKindOfBook);

        }

        //Delete
        // DELETE: api/KindsOfBooks/5
        [Route("Delete/{CodeKindsOfBooks}")]
        [HttpDelete]
        public bool Delete(int CodeKindsOfBooks)
        {
           
            return KindsOfBooksBL.Delete(CodeKindsOfBooks);
        }
    }
}
