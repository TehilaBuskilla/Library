﻿using System;
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
    [RoutePrefix("api/ProfileBook")]

    public class ProfileBookController : ApiController
    {
        //שליפה

        [Route("GetAll")]
        [HttpGet]
        public List<ProfileBookDTO> GetAll()
        {
            
            return ProfileBookBL.GetAll();
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
            
            return ProfileBookBL.Add(newProfileBook);
        }

        //עדכון
        // PUT: api/ProfileBook/5
        [Route("{upProfileBook}")]
        [HttpPut]
        public bool Put(ProfileBookDTO upProfileBook)
        {
            
            return ProfileBookBL.Update(upProfileBook);

        }

        //מחיקה
        // DELETE: api/ProfileBook/5
        [Route("Delete/{CodeProfileBook}")]
        [HttpDelete]
        public bool Delete(int CodeProfileBook)
        {
            
            return ProfileBookBL.Delete(CodeProfileBook);
        }
    }
}
