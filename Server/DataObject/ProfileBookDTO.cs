using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObject
{
  public  class ProfileBookDTO
    {
        public int CodeProfileBook { get; set; }

        public ReadingBooksDTO BookCode { get; set; }

        public int KindBook { get; set; }

        public int AudienceAge { get; set; }

        public int AudienceStatus { get; set; }

        public int AudienceGender { get; set; }
    }
}
