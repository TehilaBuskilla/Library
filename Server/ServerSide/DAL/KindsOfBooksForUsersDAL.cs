using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAL
{
   public class KindsOfBooksForUsersDAL
    {
        LibraryDBEntities DB = new LibraryDBEntities();
        public void Add(KindsOfBooksForUsers kindOfBookForUser)
        {
            DB.KindsOfBooksForUsers.Add(kindOfBookForUser);
            DB.SaveChanges();
        }

        public List<KindsOfBooksForUsers> Get()
        {
            return DB.KindsOfBooksForUsers.ToList();

        }

        public void Delete(KindsOfBooksForUsers kindOfBookForUser)
        {
            DB.KindsOfBooksForUsers.Remove(kindOfBookForUser);
            DB.SaveChanges();
        }
    }
}
