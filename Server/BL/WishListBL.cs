using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataObject;
using DAL;


namespace BL
{
   public class WishListBL
    {
       

        //הוספה
        public static int Add(WishListDTO wishListDTO)
        {
            return WishListDAL.Add(Convert(wishListDTO));
        }

        //שליפה
        public static List<WishListDTO> GetAll()
        {
            List<WishListDTO> listWishListDTO = new List<WishListDTO>();
            List<WishList> listWishList = WishListDAL.GetAll();


            foreach (var item in listWishList)
            {
                listWishListDTO.Add(Convert(item));
            }
            return listWishListDTO;
        }

        public static List<WishListDTO> GetById(string id)
        {
            
           
            return GetAll().FindAll(w => w.UserId == id);
            //return WishList.FindAll(x => x.codeuser == iduser);

        }

        //מחיקה
        public static bool Delete(int CodeWishList)
        {
            return WishListDAL.Delete(CodeWishList);
        }

        //עדכון
        public static bool Update(WishListDTO wishListDTO)
        {
            WishList wishList = new WishList();
            wishList = Convert(wishListDTO);
            return WishListDAL.Update(wishList);

        }

        public static WishList Convert(WishListDTO wishListDTO)
        {
            WishList wishList = new WishList();
            wishList.CodeWishList = wishListDTO.CodeWishList;
            wishList.BookCode = wishListDTO.BookCode;
            wishList.UserId = wishListDTO.UserId.ToString();
            
            return wishList;


        }
        public static WishListDTO Convert(WishList wishList)
        {
            WishListDTO wishListDTO = new WishListDTO();
            wishListDTO.CodeWishList = wishList.CodeWishList;
            wishListDTO.BookCode = wishList.BookCode;
            wishListDTO.UserId = (string)wishList.UserId;
            
            return wishListDTO;
        }
    }
}
