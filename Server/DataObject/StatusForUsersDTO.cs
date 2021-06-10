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

        public int StatusCode { get; set; }

        public string UserId { get; set; }

        public int Count { get; set; }

        public DateTime LastDate { get; set; }
    }
}
