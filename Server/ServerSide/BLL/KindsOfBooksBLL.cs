using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;


namespace BLL
{
   public class KindsOfBooksBLL
    {
        KindsOfBooksDAL KindsOfBooksDAL = new KindsOfBooksDAL();

        public void Add(KindsOfBooks kindOfBook)
        {
            KindsOfBooksDAL.Add(kindOfBook);
        }

        public List<KindsOfBooks> Get()
        {
            return KindsOfBooksDAL.Get();
        }

        public void Delete(KindsOfBooks kindOfBook)
        {
            KindsOfBooksDAL.Delete(kindOfBook);
        }
    }
}
