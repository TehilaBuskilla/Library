using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DataObject;
using BLL;

namespace API.Controllers
{
    [RoutePrefix("api/ReadingBooks")]

    public class ReadingBooksController : ApiController
    {
        //שליפה
        // GET: api/ReadingBooks
        [Route("GetAll")]
        [HttpGet]
        public List<ReadingBooksDTO> GetAll()
        {
            
            return ReadingBooksBLL.GetAll();
        }

        //שליפה ע"י נתון
        // GET: api/ReadingBooks/5
        [Route("GetBottom10")]
        [HttpGet]
        public IEnumerable<ReadingBooksDTO> GetBottom10()
        {
            var a = ReadingBooksBLL.GetAll();
             return a.OrderByDescending(b=>b.CodeBook).Take(10);
        }

        //הוספה
        // POST: api/ReadingBooks
        [Route("{newReadingBook}")]
        [HttpPost]
        public int Post(ReadingBooksDTO newReadingBook)
        {
            
            return ReadingBooksBLL.Add(newReadingBook);
        }

        //עדכון
        // PUT: api/ReadingBooks/5
        [Route("{upReadingBook}")]
        [HttpPut]
        public bool Put(ReadingBooksDTO upReadingBook)
        {
          
            return ReadingBooksBLL.Update(upReadingBook);

        }

        //מחיקה
        // DELETE: api/ReadingBooks/5
        [Route("Delete/{CodeReadingBook}")]
        [HttpDelete]
        public bool Delete(int CodeReadingBook)
        {
           
            return ReadingBooksBLL.Delete(CodeReadingBook);
        }
    }
}
