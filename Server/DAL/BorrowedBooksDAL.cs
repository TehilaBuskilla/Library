using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL
{
   public class BorrowedBooksDAL
    {
        //שליפה להכל
        public static List<BorrowedBooks> GetAll()
        {
            using (var context = new LibraryDBEntities())
            {
                List<BorrowedBooks> listBorrowedBooks = context.BorrowedBooks.ToList();
                return listBorrowedBooks;
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
        public static int Add(BorrowedBooks borrowedBook)
        {
            using (var context = new LibraryDBEntities())
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

        //מחיקה

        public static bool Delete(int code)
        {
            using (var context = new LibraryDBEntities())
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




        //עדכון
        public static bool Update(BorrowedBooks borrowedBook)
        {
            try
            {
                using (var context = new LibraryDBEntities())
                {


                    BorrowedBooks old = context.BorrowedBooks.FirstOrDefault(x => x.CodeBorrowedBooks == borrowedBook.CodeBorrowedBooks);
                    if (old != null)
                    {
                        old.BookCode = borrowedBook.BookCode;
                        old.UserId = borrowedBook.UserId;
                        old.BorrowingDate = borrowedBook.BorrowingDate;
                        old.IsBorrowed = borrowedBook.IsBorrowed;
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
