using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAL
{
   public class ProfileBookDAL
    {
        LibraryDBEntities DB = new LibraryDBEntities();
        public void Add(ProfileBook profileBook)
        {
            DB.ProfileBook.Add(profileBook);
            DB.SaveChanges();
        }

        public List<ProfileBook> Get()
        {
            return DB.ProfileBook.ToList();

        }

        public void Delete(ProfileBook profileBook)
        {
            DB.ProfileBook.Remove(profileBook);
            DB.SaveChanges();
        }
    }
}
