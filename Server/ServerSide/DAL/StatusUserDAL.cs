using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAL
{
   public class StatusUserDAL
    {

        LibraryDBEntities DB = new LibraryDBEntities();
        public void Add(StatusUser statusUser)
        {
            DB.StatusUser.Add(statusUser);
            DB.SaveChanges();
        }

        public List<StatusUser> Get()
        {
            return DB.StatusUser.ToList();

        }

        public void Delete(StatusUser statusUser)
        {
            DB.StatusUser.Remove(statusUser);
            DB.SaveChanges();
        }
    }
}
