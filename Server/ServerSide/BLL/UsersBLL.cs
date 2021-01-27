using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;

namespace BLL
{
   public class UsersBLL
    {
        UsersDAL UsersDAL = new UsersDAL();

        public void Add(Users user)
        {
            UsersDAL.Add(user);
        }

        public List<Users> Get()
        {
            return UsersDAL.Get();
        }

        public void Delete(Users user)
        {
            UsersDAL.Delete(user);
        }
    }
}
