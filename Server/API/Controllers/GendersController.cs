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
        //Get
        // GET: api/Genders
        [Route("GetAll")]
        [HttpGet]
        public List<GendersDTO> GetAll()
        {
            
            return GendersBL.GetAll();
        }

        //Add
        // POST: api/Genders
        [Route("{newGender}")]
        [HttpPost]
        public int Post(GendersDTO newGender)
        {
            
            return GendersBL.Add(newGender);
        }

        //Update
        // PUT: api/Genders/5
        [Route("{upGender}")]
        [HttpPut]
        public bool Put(GendersDTO upGender)
        {
            

            return GendersBL.Update(upGender);

        }

        //Delete
        // DELETE: api/Genders/5
        [Route("Delete/{CodeGender}")]
        [HttpDelete]
        public bool Delete(int CodeGender)
        {
            

            return GendersBL.Delete(CodeGender);
        }
    }
}
