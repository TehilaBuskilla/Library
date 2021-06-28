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

        public int BookCode { get; set; }

        public string UserId { get; set; }

        public Boolean Like { get; set; }

        public DateTime LastDate { get; set; }

        public int Count { get; set; }

    }
}
