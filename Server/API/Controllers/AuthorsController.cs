using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BLL;
using DataObject;

namespace API.Controllers
{
    [RoutePrefix("api/Authors")]


    public class AuthorsController : ApiController
    {
        //שליפה
        // GET: api/Authors
        [Route("GetAll")]
        [HttpGet]
        public List<AuthorsDTO> GetAll()
        {
            
            return AuthorsBLL.GetAll();

        }

        //שליפה ע"י נתון
        // GET: api/Authors/5
        //[Route("Get/{}")]
        //[HttpGet]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //הוספה
        // POST: api/Authors
        [Route("{newAuthor}")]
        [HttpPost]
        public int Post(AuthorsDTO newAuthor)
        {
            
            return AuthorsBLL.Add(newAuthor);

        }

        //עדכון
        // PUT: api/Authors/5
        [Route("{upAuthor}")]
        [HttpPut]
        public bool Put(AuthorsDTO upAuthor)
        {
            
            return AuthorsBLL.Update(upAuthor);
        }

        //מחיקה
        // DELETE: api/Authors/5
        [Route("Delete/{CodeAuthor}")]
        [HttpDelete]
        public bool Delete(int CodeAuthor)
        {
            
            return AuthorsBLL.Delete(CodeAuthor);

        }
    }
}
