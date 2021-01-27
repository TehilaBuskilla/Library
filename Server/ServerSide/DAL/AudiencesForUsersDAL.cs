using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAL
{
   public class AudiencesForUsersDAL
    {
        LibraryDBEntities DB = new LibraryDBEntities();
        public void Add(AudiencesForUsers audienceForUser)
        {
            DB.AudiencesForUsers.Add(audienceForUser);
            DB.SaveChanges();
        }

        public List<AudiencesForUsers> Get()
        {
            return DB.AudiencesForUsers.ToList();

        }

        public void Delete(AudiencesForUsers audienceForUser)
        {
            DB.AudiencesForUsers.Remove(audienceForUser);
            DB.SaveChanges();
        }
    }
}
