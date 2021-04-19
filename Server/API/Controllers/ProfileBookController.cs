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
    [RoutePrefix("api/ProfileBook")]

    public class ProfileBookController : ApiController
    {
        //שליפה
        // GET: api/ProfileBook
        [Route("GetAll")]
        [HttpGet]
        public List<ProfileBookDTO> GetAll()
        {
            
            return ProfileBookBLL.GetAll();
        }

        //שליפה ע"י נתון
        // GET: api/ProfileBook/5
        //[Route("Get/{}")]
        //[HttpGet]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //הוספה
        // POST: api/ProfileBook
        [Route("{newProfileBook}")]
        [HttpPost]
        public int Post(ProfileBookDTO newProfileBook)
        {
            
            return ProfileBookBLL.Add(newProfileBook);
        }

        //עדכון
        // PUT: api/ProfileBook/5
        [Route("{upProfileBook}")]
        [HttpPut]
        public bool Put(ProfileBookDTO upProfileBook)
        {
            
            return ProfileBookBLL.Update(upProfileBook);

        }

        //מחיקה
        // DELETE: api/ProfileBook/5
        [Route("Delete/{CodeProfileBook}")]
        [HttpDelete]
        public bool Delete(int CodeProfileBook)
        {
            
            return ProfileBookBLL.Delete(CodeProfileBook);
        }
    }
}
