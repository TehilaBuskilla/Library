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
    [RoutePrefix("api/Genders")]


    public class GendersController : ApiController
    {
        //שליפה
        // GET: api/Genders
        [Route("GetAll")]
        [HttpGet]
        public List<GendersDTO> GetAll()
        {
            
            return GendersBLL.GetAll();
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
            
            return GendersBLL.Add(newGender);
        }

        //עדכון
        // PUT: api/Genders/5
        [Route("{upGender}")]
        [HttpPut]
        public bool Put(GendersDTO upGender)
        {
            

            return GendersBLL.Update(upGender);

        }

        //מחיקה
        // DELETE: api/Genders/5
        [Route("Delete/{CodeGender}")]
        [HttpDelete]
        public bool Delete(int CodeGender)
        {
            

            return GendersBLL.Delete(CodeGender);
        }
    }
}
