using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObject
{
   public class StatusForUsersDTO
    {
        public int CodeStatusForUsers { get; set; }

        public StatusForUsersDTO Status { get; set; }

        public UsersDTO UserId { get; set; }
    }
}
