using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAL
{
   public class KindsOfBooksDAL
    {
        LibraryDBEntities DB = new LibraryDBEntities();
        public void Add(KindsOfBooks kindOfBook)
        {
            DB.KindsOfBooks.Add(kindOfBook);
            DB.SaveChanges();
        }

        public List<KindsOfBooks> Get()
        {
            return DB.KindsOfBooks.ToList();

        }

        public void Delete(KindsOfBooks kindOfBook)
        {
            DB.KindsOfBooks.Remove(kindOfBook);
            DB.SaveChanges();
        }
    }
}
