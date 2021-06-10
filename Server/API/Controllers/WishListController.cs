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
    [RoutePrefix("api/ProfileBook")]

    public class WishListController : ApiController
    {
        //שליפה
        // GET: api/WishList
        [Route("GetAll")]
        [HttpGet]
        public List<WishListDTO> GetAll()
        {
            return WishListBL.GetAll();

        }

        //שליפה ע"י נתון
        // GET: api/WishList/5
        //[Route("Get/{}")]
        //[HttpGet]
        //public string Get(int id)
        //{
        //    return "value";
        //}


        //הוספה
        // POST: api/WishList
        [Route("{newWishList}")]
        [HttpPost]
        public int Post(WishListDTO newWishList)
        {
            return WishListBL.Add(newWishList);

        }

        //עדכון
        // PUT: api/WishList/5
        [Route("{upWishList}")]
        [HttpPut]
        public bool Put(WishListDTO upWishList)
        {
            return WishListBL.Update(upWishList);

        }

        //מחיקה
        // DELETE: api/WishList/5
        [Route("Delete/{CodeWishList}")]
        [HttpDelete]
        public bool Delete(int CodeWishList)
        {
            return WishListBL.Delete(CodeWishList);

        }
    }
}
