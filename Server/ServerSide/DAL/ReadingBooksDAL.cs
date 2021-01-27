using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAL
{
   public class ReadingBooksDAL
    {
        LibraryDBEntities DB = new LibraryDBEntities();
        public void Add(ReadingBooks readingBook)
        {
            DB.ReadingBooks.Add(readingBook);
            DB.SaveChanges();
        }

        public List<ReadingBooks> Get()
        {
            return DB.ReadingBooks.ToList();

        }

        public void Delete(ReadingBooks readingBook)
        {
            DB.ReadingBooks.Remove(readingBook);
            DB.SaveChanges();
        }
    }
}
