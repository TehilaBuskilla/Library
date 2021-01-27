using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;


namespace BLL
{
   public class StatusForUsersBLL
    {
        StatusForUsersDAL StatusForUsersDAL = new StatusForUsersDAL();

        public void Add(StatusForUsers statusForUser)
        {
            StatusForUsersDAL.Add(statusForUser);
        }

        public List<StatusForUsers> Get()
        {
            return StatusForUsersDAL.Get();
        }

        public void Delete(StatusForUsers statusForUser)
        {
            StatusForUsersDAL.Delete(statusForUser);
        }
    }
}
