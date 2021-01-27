using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;

namespace BLL
{
   public class AuthorsBLL
    {
        AuthorsDAL AuthorsDAL = new AuthorsDAL();

        public void Add(Authors author)
        {
            AuthorsDAL.Add(author);
        }

        public List<Authors> Get()
        {
            return AuthorsDAL.Get();
        }

        public void Delete(Authors author)
        {
            AuthorsDAL.Delete(author);
        }
    }
}
