using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObject
{
   public class KindsOfBooksForUsersDTO
    {
        public int CodeKindsOfBooksForUsers { get; set; }

        public UsersDTO UserId { get; set; }

        public KindsOfBooksDTO KindOfBook { get; set; }
    }
}
