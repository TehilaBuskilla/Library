using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;


namespace BLL
{
   public class AuthorsForUsersBLL
    {
        AuthorsForUsersDAL AuthorsForUsersDAL = new AuthorsForUsersDAL();

        public void Add(AuthorsForUsers authorForUser)
        {
            AuthorsForUsersDAL.Add(authorForUser);
        }

        public List<AuthorsForUsers> Get()
        {
            return AuthorsForUsersDAL.Get();
        }

        public void Delete(AuthorsForUsers authorForUser)
        {
            AuthorsForUsersDAL.Delete(authorForUser);
        }
    }
}
