using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAL
{
   public class AuthorsForUsersDAL
    {
        LibraryDBEntities DB = new LibraryDBEntities();
        public void Add(AuthorsForUsers authorForUser)
        {
            DB.AuthorsForUsers.Add(authorForUser);
            DB.SaveChanges();
        }

        public List<AuthorsForUsers> Get()
        {
            return DB.AuthorsForUsers.ToList();

        }

        public void Delete(AuthorsForUsers authorForUser)
        {
            DB.AuthorsForUsers.Remove(authorForUser);
            DB.SaveChanges();
        }
    }
}
