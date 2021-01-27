using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAL
{
   public class BorrowedBooksDAL
    {
        LibraryDBEntities DB = new LibraryDBEntities();
        public void Add(BorrowedBooks borrowedBook)
        {
            DB.BorrowedBooks.Add(borrowedBook);
            DB.SaveChanges();
        }

        public List<BorrowedBooks> Get()
        {
            return DB.BorrowedBooks.ToList();

        }

        public void Delete(BorrowedBooks borrowedBook)
        {
            DB.BorrowedBooks.Remove(borrowedBook);
            DB.SaveChanges();
        }
    }
}
