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
    [RoutePrefix("api/AudiencesForUsers")]

    public class AudiencesForUsersController : ApiController
    {
        //שליפה
        // GET: api/AudiencesForUsers
        [Route("GetAll")]
        [HttpGet]
        public List<AudiencesForUsersDTO> GetAll()
        {
           
            return AudiencesForUsersBLL.GetAll();
        }

        
        [Route("getById/{id}")]
        [HttpGet]
        public List<AudiencesForUsersDTO> getById(int id)
        {
            return AudiencesForUsersBLL.getById(id);
        }

        //הוספה
        // POST: api/AudiencesForUsers
        [Route("{newAudienceForUser}")]
        [HttpPost]
        public int Post(AudiencesForUsersDTO newAudienceForUser)
        {
           
            return AudiencesForUsersBLL.Add(newAudienceForUser);
        }

        //עדכון
        // PUT: api/AudiencesForUsers/5
        [Route("{upAudienceForUser}")]
        [HttpPut]
        public bool Put(AudiencesForUsersDTO upAudienceForUser)
        {
            
            return AudiencesForUsersBLL.Update(upAudienceForUser);



        }

        //מחיקה
        // DELETE: api/AudiencesForUsers/5
        [Route("Delete/{CodeAudiencesForUsers}")]
        [HttpDelete]
        public bool Delete(int CodeAudiencesForUsers)
        {
           
            return AudiencesForUsersBLL.Delete(CodeAudiencesForUsers);


        }
    }
}
