using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL; 
namespace BLL
{
   public class GendersBLL
    {
        GendersDAL GendersDAL = new GendersDAL();

        public void Add(Genders gender)
        {
            GendersDAL.Add(gender);
        }

        public List <Genders> Get()
        {
            return GendersDAL.Get();
        }

        public void Delete(Genders gender)
        {
            GendersDAL.Delete(gender);
        }
    }
}
