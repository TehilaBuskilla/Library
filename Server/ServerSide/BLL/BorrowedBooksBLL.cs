using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;

namespace BLL
{
   public class BorrowedBooksBLL
    {
        BorrowedBooksDAL BorrowedBooksDAL = new BorrowedBooksDAL();

        public void Add(BorrowedBooks borrowedBook)
        {
            BorrowedBooksDAL.Add(borrowedBook);
        }

        public List<BorrowedBooks> Get()
        {
            return BorrowedBooksDAL.Get();
        }

        public void Delete(BorrowedBooks borrowedBook)
        {
            BorrowedBooksDAL.Delete(borrowedBook);
        }
    }
}
