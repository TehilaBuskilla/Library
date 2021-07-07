using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL
{
   public class BorrowedBooksDAL
    {
        //Get
        public static List<BorrowedBooks> GetAll()
        {
            using (var context = new LibraryDBEntities1())
            {
                List<BorrowedBooks> listBorrowedBooks = context.BorrowedBooks.ToList();
                return listBorrowedBooks;
            }

        }

        //Add
        public static int Add(BorrowedBooks borrowedBook)
        {
            using (var context = new LibraryDBEntities1())
            {
                context.BorrowedBooks.Add(borrowedBook);
                context.SaveChanges();
                int code = 0;
                foreach (BorrowedBooks item in context.BorrowedBooks)
                {
                    code = item.CodeBorrowedBooks;
                }
                return code;
            }

        }

        //Delete

        public static bool Delete(int code)
        {
            using (var context = new LibraryDBEntities1())
            {
                try
                {
                    BorrowedBooks toDel = context.BorrowedBooks.FirstOrDefault(x => x.CodeBorrowedBooks == code);
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
        public static bool Update(BorrowedBooks borrowedBook)
        {
            try
            {
                using (var context = new LibraryDBEntities1())
                {


                    BorrowedBooks old = context.BorrowedBooks.FirstOrDefault(x => x.CodeBorrowedBooks == borrowedBook.CodeBorrowedBooks);
                    if (old != null)
                    {
                        old.BookCode = borrowedBook.BookCode;
                        old.UserId = borrowedBook.UserId;
                        old.BorrowingDate = borrowedBook.BorrowingDate;
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
