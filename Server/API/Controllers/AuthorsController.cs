using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using BL;
using DataObject;

namespace API.Controllers
{
    [EnableCors("*", "*", "*")]
    [RoutePrefix("api/Authors")]


    public class AuthorsController : ApiController
    {
        //Get
        // GET: api/Authors
        [Route("GetAll")]
        [HttpGet]
        public List<AuthorsDTO> GetAll()
        {
            
            return AuthorsBL.GetAll();

        }

        //Add
        // POST: api/Authors
        [Route("{newAuthor}")]
        [HttpPost]
        public int Post(AuthorsDTO newAuthor)
        {
            
            return AuthorsBL.Add(newAuthor);

        }

        //Update
        // PUT: api/Authors/5
        [Route("{upAuthor}")]
        [HttpPut]
        public bool Put(AuthorsDTO upAuthor)
        {
            
            return AuthorsBL.Update(upAuthor);
        }

        //Delete
        // DELETE: api/Authors/5
        [Route("Delete/{CodeAuthor}")]
        [HttpDelete]
        public bool Delete(int CodeAuthor)
        {
            
            return AuthorsBL.Delete(CodeAuthor);

        }
    }
}
