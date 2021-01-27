using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAL
{
   public class AudiencesDAL
    {
        LibraryDBEntities DB = new LibraryDBEntities();
        public void Add(Audiences audience)
        {
            DB.Audiences.Add(audience);
            DB.SaveChanges();
        }



        public List <Audiences> Get()
        {
            return DB.Audiences.ToList();

        }

        public void Delete(Audiences audience)
        {
            DB.Audiences.Remove(audience);
            DB.SaveChanges();
        }
    }

    
}
