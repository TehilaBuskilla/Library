using System;
using System.Collections;
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

        //public int AuthorCode { get; set; }

        //public string AuthorName { get; set; }


        //public int KindBookCode { get; set; }

        //public string KindBookName { get; set; }

        

        public int LengthBook { get; set; }

        public bool IsBorrowed { get; set; }

        //public int StatusCode { get; set; }

        //public string SatatusName { get; set; }

        //public int GenderCode { get; set; }

        //public string GenderName { get; set; }

        public AuthorsDTO Author { get; set; }

        public AudiencesDTO Audience { get; set; }

        public KindsOfBooksDTO KindOfBook { get; set; }

        public StatusUserDTO StatusUser { get; set; }

        public GendersDTO Gender { get; set; }
        public string ImgBook { get; set; }
    }
}
