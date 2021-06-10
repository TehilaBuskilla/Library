using DataObject;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class BookToUserDAL
    {

        //שליפה להכל
        //public static List<BookToUserDTO> GetAll()
        //{
        //    using (var context = new LibraryDBEntities1())
        //    {
        //        List<BookToUser> listBookToUser = context.BookToUser.ToList();
        //        List<BookToUserDTO> listBookToUserDTO = new List<BookToUserDTO>();
        //        foreach (var item in listBookToUser)
        //        {
        //            listBookToUserDTO.Add(
        //                new BookToUserDTO
        //                {
        //                    CodeBookToUser = item.CodeBookToUser,
        //                    BookCode = new ReadingBooksDTO
        //                    {
        //                        CodeBook = item.ReadingBooks.CodeBook,
        //                        NameBook = item.ReadingBooks.NameBook
        //                    },

        //                    UserId = new UsersDTO {
        //                        IdUser = item.Users.IdUser
        //                    }
        //                });
        //        }
        //        return listBookToUserDTO;
        //    }

        //}
        public static List<BookToUser> GetAll()
        {
            using(var context= new LibraryDBEntities1() )
            {
                List<BookToUser> list = context.BookToUser.ToList();
                return list;
            }
           
        }

        //שליפת נתון

        //public static Get()
        // {
        //using (var context = new LibraryDBEntities())
        //{
        //    return context.Audiences.
        //}
        //  }
        //הוספה
        public static int Add(BookToUser bookToUser)
        {
            using (var context = new LibraryDBEntities1())
            {
                DbChangeTracker tracker = context.ChangeTracker;

                context.BookToUser.Add(bookToUser);
                context.SaveChanges();
              
                return bookToUser.BookCode;
            }

        }

        //מחיקה

        public static bool Delete(int code)
        {
            using (var context = new LibraryDBEntities1())
            {
                try
                {
                    BookToUser toDel = context.BookToUser.FirstOrDefault(x => x.CodeBookToUser == code);
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
        public static bool Update(BookToUser bookToUser)
        {
            try
            {
                using (var context = new LibraryDBEntities1())
                {


                    BookToUser old = context.BookToUser.FirstOrDefault(x => x.CodeBookToUser == bookToUser.CodeBookToUser);
                    if (old != null)
                    {
                        old.BookCode = bookToUser.BookCode;
                        old.UserId = bookToUser.UserId;
                        if (old.Like == true)
                            old.Like = true;
                        else
                            old.Like = false;

                        old.LastDate = bookToUser.LastDate;
                        old.Count++;
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
