using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataObject;
using DAL;

namespace BL
{
    public class BookToUserBL
    {

        //הוספה
        public static int Add(BookToUserDTO bookToUserDTO)
        {
            return BookToUserDAL.Add(Convert(bookToUserDTO));
        }

        //שליפה
        public static List<BookToUserDTO> GetAll()
        {
            List<BookToUserDTO> listBookToUserDTO = new List<BookToUserDTO>();
            List<BookToUser> listBookToUser = BookToUserDAL.GetAll();


            foreach (var item in listBookToUser)
            {
                listBookToUserDTO.Add(Convert(item));
            }
            return listBookToUserDTO;
        }
        public static List<BookToUserDTO> getById(int id)
        {
            List<BookToUserDTO> listBookToUserDTO = new List<BookToUserDTO>();
            List<BookToUser> listBookToUser = BookToUserDAL.GetAll();


            foreach (var item in listBookToUser)
            {
                listBookToUserDTO.Add(Convert(item));
            }
            return listBookToUserDTO.FindAll(x => x.CodeBookToUser ==id);
        }
        //מחיקה
        public static bool Delete(int CodeBookToUser)
        {
            return BookToUserDAL.Delete(CodeBookToUser);
        }

        //עדכון
        public static bool Update(BookToUserDTO bookToUserDTO)
        {
            BookToUser bookToUser = new BookToUser();
            bookToUser = Convert(bookToUserDTO);
            return BookToUserDAL.Update(bookToUser);

        }

        public static BookToUser Convert(BookToUserDTO bookToUserDTO)
        {
            BookToUser bookToUser = new BookToUser();
            bookToUser.CodeBookToUser = bookToUserDTO.CodeBookToUser;
            bookToUser.BookCode = bookToUserDTO.BookCode;
            bookToUser.UserId = bookToUserDTO.UserId;
            return bookToUser;


        }
        public static BookToUserDTO Convert(BookToUser bookToUser)
        {
            BookToUserDTO bookToUserDTO = new BookToUserDTO();
            bookToUserDTO.CodeBookToUser = bookToUser.CodeBookToUser;
            bookToUserDTO.BookCode = bookToUser.BookCode;
            bookToUserDTO.UserId = bookToUser.UserId;

            return bookToUserDTO;
        }

    }
}
