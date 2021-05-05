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

    [RoutePrefix("api/Genders")]


    public class GendersController : ApiController
    {
        //שליפה
        // GET: api/Genders
        [Route("GetAll")]
        [HttpGet]
        public List<GendersDTO> GetAll()
        {
            
            return GendersBL.GetAll();
        }

        //שליפה ע"י נתון
        // GET: api/Genders/5
        //[Route("Get/{}")]
        //[HttpGet]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //הוספה
        // POST: api/Genders
        [Route("{newGender}")]
        [HttpPost]
        public int Post(GendersDTO newGender)
        {
            
            return GendersBL.Add(newGender);
        }

        //עדכון
        // PUT: api/Genders/5
        [Route("{upGender}")]
        [HttpPut]
        public bool Put(GendersDTO upGender)
        {
            

            return GendersBL.Update(upGender);

        }

        //מחיקה
        // DELETE: api/Genders/5
        [Route("Delete/{CodeGender}")]
        [HttpDelete]
        public bool Delete(int CodeGender)
        {
            

            return GendersBL.Delete(CodeGender);
        }
    }
}
