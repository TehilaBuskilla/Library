using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;

namespace BLL
{
   public class StatusUserBLL
    {
        StatusUserDAL StatusUserDAL = new StatusUserDAL();

        public void Add(StatusUser statusUser)
        {
            StatusUserDAL.Add(statusUser);
        }

        public List<StatusUser> Get()
        {
            return StatusUserDAL.Get();
        }

        public void Delete(StatusUser statusUser)
        {
            StatusUserDAL.Delete(statusUser);
        }
    }
}
