using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;

namespace BLL
{
   public class ProfileBookBLL
    {
        ProfileBookDAL ProfileBookDAL = new ProfileBookDAL();

        public void Add(ProfileBook profileBook)
        {
            ProfileBookDAL.Add(profileBook);
        }

        public List<ProfileBook> Get()
        {
            return ProfileBookDAL.Get();
        }

        public void Delete(ProfileBook profileBook)
        {
            ProfileBookDAL.Delete(profileBook);
        }
    }
}
