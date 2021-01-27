using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAL
{
   public class AuthorsDAL
    {
        LibraryDBEntities DB = new LibraryDBEntities();
        public void Add(Authors author)
        {
            DB.Authors.Add(author);
            DB.SaveChanges();
        }

        public List<Authors> Get()
        {
            return DB.Authors.ToList();

        }

        public void Delete(Authors author)
        {
            DB.Authors.Remove(author);
            DB.SaveChanges();
        }
    }
}
