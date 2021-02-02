using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObject
{
   public class ReadingBooksDTO
    {
        public int CodeBook { get; set; }

        public string NameBook { get; set; }

        public int AuthorCode { get; set; }

        public int KindBookCode { get; set; }

        public int AudienceCode { get; set; }

        public int LengthBook { get; set; }

        public bool IsBorrowed { get; set; }

        public int StatusCode { get; set; }

        public int GenderCode { get; set; }
    }
}
