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
    [RoutePrefix("api/KindsOfBooksForUsers")]

    public class KindsOfBooksForUsersController : ApiController
    {
        //שליפה
        // GET: api/KindsOfBooksForUsers
        [Route("GetAll")]
        [HttpGet]
        public List<KindsOfBooksForUsersDTO> GetAll()
        {
           
            return KindsOfBooksForUsersBL.GetAll();
        }

        //שליפה ע"י נתון
        // GET: api/KindsOfBooksForUsers/5
        //[Route("Get/{}")]
        //[HttpGet]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //הוספה
        // POST: api/KindsOfBooksForUsers
        [Route("{newKindOfBookForUser}")]
        [HttpPost]
        public int Post(KindsOfBooksForUsersDTO newKindOfBookForUser)
        {
            
            return KindsOfBooksForUsersBL.Add(newKindOfBookForUser);
        }

        //עדכון
        // PUT: api/KindsOfBooksForUsers/5
        [Route("{upKindOfBookForUser}")]
        [HttpPut]
        public bool Put(KindsOfBooksForUsersDTO upKindOfBookForUser)
        {
            
            return KindsOfBooksForUsersBL.Update(upKindOfBookForUser);

        }

        //מחיקה
        // DELETE: api/KindsOfBooksForUsers/5
        [Route("Delete/{CodeKindsOfBooksForUsers}")]
        [HttpDelete]
        public bool Delete(int CodeKindsOfBooksForUsers)
        {
            
            return KindsOfBooksForUsersBL.Delete(CodeKindsOfBooksForUsers);
        }
    }
}
