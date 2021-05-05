using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class BookToUserDAL
    {

        //שליפה להכל
        public static List<BookToUser> GetAll()
        {
            using (var context = new LibraryDBEntities1())
            {
                List<BookToUser> listBookToUser = context.BookToUser.ToList();
                return listBookToUser;
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
                context.BookToUser.Add(bookToUser);
                context.SaveChanges();
                int code = 0;
                foreach (BookToUser item in context.BookToUser)
                {
                    code = item.CodeBookToUser;
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
                        old.CodeBookToUser = bookToUser.CodeBookToUser;
                        old.BookCode = bookToUser.BookCode;
                        old.UserId = bookToUser.bookToUser;
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
