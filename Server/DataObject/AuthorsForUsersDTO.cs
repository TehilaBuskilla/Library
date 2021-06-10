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
        
        public int AuthorCode { get; set; }

        public string UserId { get; set; }

        public int Count { get; set; }

        public DateTime LastDate { get; set; }
    }
}
