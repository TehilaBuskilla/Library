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
    [RoutePrefix("api/KindsOfBooksForUsers")]

    public class KindsOfBooksForUsersController : ApiController
    {
        //שליפה
        // GET: api/KindsOfBooksForUsers
        [Route("GetAll")]
        [HttpGet]
        public List<KindsOfBooksForUsersDTO> GetAll()
        {
           
            return KindsOfBooksForUsersBLL.GetAll();
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
            
            return KindsOfBooksForUsersBLL.Add(newKindOfBookForUser);
        }

        //עדכון
        // PUT: api/KindsOfBooksForUsers/5
        [Route("{upKindOfBookForUser}")]
        [HttpPut]
        public bool Put(KindsOfBooksForUsersDTO upKindOfBookForUser)
        {
            
            return KindsOfBooksForUsersBLL.Update(upKindOfBookForUser);

        }

        //מחיקה
        // DELETE: api/KindsOfBooksForUsers/5
        [Route("Delete/{CodeKindsOfBooksForUsers}")]
        [HttpDelete]
        public bool Delete(int CodeKindsOfBooksForUsers)
        {
            
            return KindsOfBooksForUsersBLL.Delete(CodeKindsOfBooksForUsers);
        }
    }
}
