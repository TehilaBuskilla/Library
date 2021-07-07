using DataObject;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DAL
{
   public class BookToUserDAL
    {

        //Add
        public static int Add(BookToUser bookToUser)
        {
            using (var context = new LibraryDBEntities1())
            {

                context.BookToUser.Add(bookToUser);
                context.SaveChanges();
                int id = 0;
                foreach (BookToUser item in context.BookToUser)
                {
                    id = item.CodeBookToUser;
                }

                return id;
            }

        }

        // Get
        public static List<BookToUser> GetAll()
        {
            using (var context = new LibraryDBEntities1())
            {
                List<BookToUser> listBookToUser = context.BookToUser
                    .Include(b => b.ReadingBooks)
                    .Include(b => b.ReadingBooks.Authors)
                    .Include(b => b.ReadingBooks.Audiences)
                    .Include(b => b.ReadingBooks.StatusUser)
                    .Include(b => b.ReadingBooks.Genders)
                    .Include(b => b.ReadingBooks.KindsOfBooks)
                     .ToList();
                return listBookToUser;



            }
        }
        //Delete

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




        //Update
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
                        if (old.Like == true|| bookToUser.Like==true)
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
