using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObject
{
   public class BookToUserDTO
    {
        public int CodeBookToUser { get; set; }

        public ReadingBooksDTO BookCode { get; set; }

        public UsersDTO UserId { get; set; }

        public Boolean Like { get; set; }

        public DateTime LastDate { get; set; }

        public int Count { get; set; }

    }
}
