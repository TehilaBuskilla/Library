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
    [RoutePrefix("api/Audiences")]

    public  class AudiencesController : ApiController
    {
        //Get
        // GET: api/Audiences
        [Route("GetAll")]
        [HttpGet]
        public List<AudiencesDTO> GetAll()
        {
            return AudiencesBL.GetAll();
        }

        //Add
        // POST: api/Audiences
        [Route("{newAudience}")]
        [HttpPost]
        public  int Post(AudiencesDTO newAudience)
        {
            return AudiencesBL.Add(newAudience);
        }

        //Update
        // PUT: api/Audiences/5
        [Route("{upAudience}")]
        [HttpPut]
        public bool Put(AudiencesDTO upAudience)
        {
          
            return AudiencesBL.Update(upAudience);

        }

        //Delete
        // DELETE: api/Audiences/5
        [Route("Delete/{CodeAudience}")]
        [HttpDelete]
        public bool Delete(int CodeAudience)
        {
           
            return AudiencesBL.Delete(CodeAudience);
        }
    }
}
