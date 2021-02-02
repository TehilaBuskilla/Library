using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObject
{
  public  class BorrowedBooksDTO
    {
        public int CodeBorrowedBooks { get; set; }

        public int BookCode { get; set; }

        public int UserId { get; set; }

        public DateTime BorrowingDate  { get; set; }

        public bool IsBorrowed { get; set; }
    }
}
