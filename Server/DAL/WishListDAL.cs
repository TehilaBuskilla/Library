using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataObject;

namespace DAL
{
   public class WishListDAL
    {
        //שליפה להכל
        public static List<WishList> GetAll()
        {
            using (var context = new LibraryDBEntities1())
            {
                List<WishList> listWishList = context.WishList.ToList();
                return listWishList;
            }

        }

        //שליפת נתון

        //public static List<WishListDTO> GetById(string id)
        //{
        //    using (var context = new LibraryDBEntities1())
        //    {
        //        if (context.WishList.FirstOrDefault(x => x.UserId == id) == null)
        //        { return null; }
        //        WishListDTO wishList = new WishListDTO();
        //        WishList wL = context.WishList.FirstOrDefault(x => x.UserId == id);
        //        wishList.UserId = wL.UserId;
        //        wishList.CodeWishList = wL.CodeWishList;
        //        wishList.BookCode = wL.BookCode;
        //        return  wishList;

        //    }
        //}


        //הוספה
        public static int Add(WishList wishList)
        {
            using (var context = new LibraryDBEntities1())
            {
                context.WishList.Add(wishList);
                context.SaveChanges();
                int code = 0;
                foreach (WishList item in context.WishList)
                {
                    code = item.CodeWishList;
                }
                return code;
            }

        }

        //מחיקה

        public static bool Delete(int code)
        {
            using (var context = new LibraryDBEntities1())
            {
                try
                {
                    WishList toDel = context.WishList.FirstOrDefault(x => x.CodeWishList == code);
                    if (toDel != null)
                    {
                        context.Entry(toDel).State = System.Data.Entity.EntityState.Deleted;
                        context.SaveChanges();
                    }
                    return true;
                }
                catch { return false; }
            }

        }




        //עדכון
        public static bool Update(WishList wishList)
        {
            try
            {
                using (var context = new LibraryDBEntities1())
                {


                    WishList old = context.WishList.FirstOrDefault(x => x.CodeWishList == wishList.CodeWishList);
                    if (old != null)
                    {
                       
                        old.BookCode = wishList.BookCode;
                        old.UserId = wishList.UserId;

                        context.SaveChanges();
                    }

                }
                return true;
            }

            catch
            {
                return false;
            }
        }
    }
}
