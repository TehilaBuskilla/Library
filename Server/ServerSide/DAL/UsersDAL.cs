using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAL
{
   public class UsersDAL
    {
        LibraryDBEntities DB = new LibraryDBEntities();
        public void Add(Users user)
        {
            DB.Users.Add(user);
            DB.SaveChanges();
        }

        public List<Users> Get()
        {
            return DB.Users.ToList();

        }

        public void Delete(Users user)
        {
            DB.Users.Remove(user);
            DB.SaveChanges();
        }
    }
}
