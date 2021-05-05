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
        //שליפה
        // GET: api/Audiences
        [Route("GetAll")]
        [HttpGet]
        public List<AudiencesDTO> GetAll()
        {
            return AudiencesBL.GetAll();
        }

        //שליפה ע"י נתון
        // GET: api/Audiences/5
        //[Route("Get/{}")]
        //[HttpGet]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //הוספה
        // POST: api/Audiences
        [Route("{newAudience}")]
        [HttpPost]
        public  int Post(AudiencesDTO newAudience)
        {
            return AudienceBL.Add(newAudience);
        }

        //עדכון
        // PUT: api/Audiences/5
        [Route("{upAudience}")]
        [HttpPut]
        public bool Put(AudiencesDTO upAudience)
        {
          
            return AudienceBL.Update(upAudience);

        }

        //מחיקה
        // DELETE: api/Audiences/5
        [Route("Delete/{CodeAudience}")]
        [HttpDelete]
        public bool Delete(int CodeAudience)
        {
           
            return AudienceBL.Delete(CodeAudience);
        }
    }
}
