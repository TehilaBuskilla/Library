using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;

namespace BLL
{
   public class KindsOfBooksForUsersBLL
    {
        KindsOfBooksForUsersDAL KindsOfBooksForUsersDAL = new KindsOfBooksForUsersDAL();

        public void Add(KindsOfBooksForUsers kindOfBookForUser)
        {
            KindsOfBooksForUsersDAL.Add(kindOfBookForUser);
        }

        public List<KindsOfBooksForUsers> Get()
        {
            return KindsOfBooksForUsersDAL.Get();
        }

        public void Delete(KindsOfBooksForUsers kindOfBookForUser)
        {
            KindsOfBooksForUsersDAL.Delete(kindOfBookForUser);
        }
    }
}
