using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;

namespace BLL
{
   public class AudiencesBLL
    {
        AudiencesDAL AudiencesDAL = new AudiencesDAL();

        public void Add(Audiences audience)
        {
            AudiencesDAL.Add(audience);
        }

        public List<Audiences> Get()
        {
            return AudiencesDAL.Get();
        }

        public void Delete(Audiences audience)
        {
            AudiencesDAL.Delete(audience);
        }
    }
}
