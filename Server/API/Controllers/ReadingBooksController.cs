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

    [RoutePrefix("api/ReadingBooks")]

    public class ReadingBooksController : ApiController
    {
        //שליפה
        // GET: api/ReadingBooks
        [Route("GetAll")]
        [HttpGet]
        public List<ReadingBooksDTO> GetAll()
        {
            
            return ReadingBooksBL.GetAll();
        }

        //שליפה ע"י נתון
        // GET: api/ReadingBooks/5
        [Route("GetBottom10")]
        [HttpGet]
        public IEnumerable<ReadingBooksDTO> GetBottom10()
        {
            var a = ReadingBooksBL.GetAll();
             return a.OrderByDescending(b=>b.CodeBook).Take(10);
        }

        //הוספה
        // POST: api/ReadingBooks
        [Route("{newReadingBook}")]
        [HttpPost]
        public int Post(ReadingBooksDTO newReadingBook)
        {
            
            return ReadingBooksBL.Add(newReadingBook);
        }


        //עדכון
        // PUT: api/ReadingBooks/5
        [Route("{upReadingBook}")]
        [HttpPut]
        public bool Put(ReadingBooksDTO upReadingBook)
        {
          
            return ReadingBooksBL.Update(upReadingBook);

        }

        //מחיקה
        // DELETE: api/ReadingBooks/5
        [Route("Delete/{CodeReadingBook}")]
        [HttpDelete]
        public bool Delete(int CodeReadingBook)
        {
           
            return ReadingBooksBL.Delete(CodeReadingBook);
        }
    }
}
