using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAL
{
   public class GendersDAL
    {
        LibraryDBEntities DB = new LibraryDBEntities();
        public void Add(Genders gender)
        {
            DB.Genders.Add(gender);
            DB.SaveChanges();
        }

        public List<Genders> Get()
        {
            return DB.Genders.ToList();

        }

        public void Delete(Genders gender)
        {
            DB.Genders.Remove(gender);
            DB.SaveChanges();
        }
    }
}
