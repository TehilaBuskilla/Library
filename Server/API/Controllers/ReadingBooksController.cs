using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DataObject;
using BL;
using System.Web.Http.Cors;
using Newtonsoft.Json;

namespace API.Controllers
{
    [EnableCors("*", "*", "*")]

    [RoutePrefix("api/ReadingBooks")]

    public class ReadingBooksController : ApiController
    {
        //Get
        // GET: api/ReadingBooks
        [Route("GetAll")]
        [HttpGet]
        public List<ReadingBooksDTO> GetAll()
        {
            
            return ReadingBooksBL.GetAll();
        }

        //GetByCode
        // GET: api/ReadingBooks
        [Route("GetByCode")]
        [HttpGet]
        public IEnumerable<ReadingBooksDTO> GetByCode()
        {
            var a = ReadingBooksBL.GetAll();
             return a.OrderByDescending(b=>b.CodeBook).Take(10);
        }

        //Add
        // POST: api/ReadingBooks
        [Route("{newReadingBook}")]
        [HttpPost]
        public int Post(ReadingBooksDTO newReadingBook)
        {
            
            return ReadingBooksBL.Add(newReadingBook);
        }


        //Update
        // PUT: api/ReadingBooks/5
        [Route("{upReadingBook}")]
        [HttpPut]
        public bool Put(ReadingBooksDTO upReadingBook)
        {
          
            return ReadingBooksBL.Update(upReadingBook);

        }

        //Delete
        // DELETE: api/ReadingBooks/5
        [Route("Delete/{CodeReadingBook}")]
        [HttpDelete]
        public bool Delete(int CodeReadingBook)
        {
           
            return ReadingBooksBL.Delete(CodeReadingBook);
        }
    }
}
