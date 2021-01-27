using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;

namespace BLL
{
   public class ReadingBooksBLL
    {
        ReadingBooksDAL ReadingBooksDAL = new ReadingBooksDAL();

        public void Add(ReadingBooks readingBook)
        {
            ReadingBooksDAL.Add(readingBook);
        }

        public List<ReadingBooks> Get()
        {
            return ReadingBooksDAL.Get();
        }

        public void Delete(ReadingBooks readingBook)
        {
            ReadingBooksDAL.Delete(readingBook);
        }
    }
}
