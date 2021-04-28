using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObject
{
   public class AuthorsForUsersDTO
    {
        public int CodeAuthorsForUsers { get; set; }
        
        public AuthorsDTO Author { get; set; }

        public UsersDTO UserId { get; set; }
    }
}
