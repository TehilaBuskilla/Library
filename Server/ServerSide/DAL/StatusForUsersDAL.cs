using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAL
{
   public class StatusForUsersDAL
    {
        LibraryDBEntities DB = new LibraryDBEntities();
        public void Add(StatusForUsers statusForUser)
        {
            DB.StatusForUsers.Add(statusForUser);
            DB.SaveChanges();
        }

        public List<StatusForUsers> Get()
        {
            return DB.StatusForUsers.ToList();

        }

        public void Delete(StatusForUsers statusForUser)
        {
            DB.StatusForUsers.Remove(statusForUser);
            DB.SaveChanges();
        }
    }
}
