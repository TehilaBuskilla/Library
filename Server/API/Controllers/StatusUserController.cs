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
    [RoutePrefix("api/StatusUser")]

    public class StatusUserController : ApiController
    {
        //שליפה
        // GET: api/StatusUser
        [Route("GetAll")]
        [HttpGet]
        public List<StatusUserDTO> GetAll()
        {
            
            return StatusUserBLL.GetAll();
        }

        //שליפה ע"י נתון
        // GET: api/StatusUser/5
        //[Route("Get/{}")]
        //[HttpGet]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //הוספה
        // POST: api/StatusUser
        [Route("{newStatusUser}")]
        [HttpPost]
        public int Post(StatusUserDTO newStatusUser)
        {
           
            return StatusUserBLL.Add(newStatusUser);
        }

        //עדכון
        // PUT: api/StatusUser/5
        [Route("{upStatusUser}")]
        [HttpPut]
        public bool Put(StatusUserDTO upStatusUser)
        {
         
            return StatusUserBLL.Update(upStatusUser);

        }

        //מחיקה
        // DELETE: api/StatusUser/5
        [Route("Delete/{CodeStatusUser}")]
        [HttpDelete]
        public bool Delete(int CodeStatusUser)
        {
            
            return StatusUserBLL.Delete(CodeStatusUser);
        }
    }
}
