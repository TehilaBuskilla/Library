using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;

namespace BLL
{
   public class AudiencesForUsersBLL
    {
        AudiencesForUsersDAL AudiencesForUsersDAL = new AudiencesForUsersDAL();

        public void Add(AudiencesForUsers audienceForUser)
        {
            AudiencesForUsersDAL.Add(audienceForUser);
        }

        public List<AudiencesForUsers> Get()
        {
            return AudiencesForUsersDAL.Get();
        }

        public void Delete(AudiencesForUsers audienceForUser)
        {
            AudiencesForUsersDAL.Delete(audienceForUser);
        }
    }
}
