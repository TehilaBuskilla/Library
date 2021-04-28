using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObject
{
   public class UsersDTO
    {
        public int IdUser { get; set; }

        public string NameUser { get; set; }

        public int AgeUser { get; set; }

        public GendersDTO Gender { get; set; }

        public StatusUserDTO StatusUser { get; set; }
    }
}
