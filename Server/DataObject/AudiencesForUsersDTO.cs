using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObject
{
   public class AudiencesForUsersDTO
    {
        public int CodeAudiencesForUsers { get; set; }

        public AudiencesDTO  Audience { get; set; }

        public UsersDTO UserId { get; set; }
    }
}
