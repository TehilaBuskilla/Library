using DataObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL
{
   public class UsersDAL
    {
        // Get
        public static List<Users> GetAll()
        {
            using (var context = new LibraryDBEntities1())
            {

                List<Users> listUsers = context.Users.ToList();
                
                return listUsers;
            }
          

        }

        // GetById 

        public static UsersDTO GetById(string id)
        {
            using (var context = new LibraryDBEntities1())
            {
                if(context.Users.FirstOrDefault(a => a.IdUser == id)==null)
                {
                    return null;
                }
                UsersDTO user = new UsersDTO();
                Users u = context.Users.FirstOrDefault(a => a.IdUser == id);
                user.IdUser = u.IdUser;
                user.NameUser = u.NameUser;
                user.AgeUser = u.AgeUser;
                user.Gender = new GendersDTO() { CodeGender = u.Genders.CodeGender, KindGender = u.Genders.KindGender };
                user.Status = new StatusUserDTO() { CodeStatus = u.StatusUser.CodeStatus, KindStatus = u.StatusUser.KindStatus };
                return user;
            }
              
        }
        //Add
        public static string Add(Users user)
        {
            using (var context = new LibraryDBEntities1())
            {
                context.Users.Add(user);
                context.SaveChanges();
            
                return "";
            }

        }

        //Delete

        public static bool Delete(string code)
        {
            using (var context = new LibraryDBEntities1())
            {
                try
                {
                    Users toDel = context.Users.FirstOrDefault(x => x.IdUser == code);
                    if (toDel != null)
                    {
                        context.Entry(toDel).State = System.Data.Entity.EntityState.Deleted;
                        context.SaveChanges();
                    }
                    return true;
                }
                catch { return false; }
            }

        }




        //Update
        public static bool Update(Users user)
        {
            try
            {
                using (var context = new LibraryDBEntities1())
                {


                    Users old = context.Users.FirstOrDefault(x => x.IdUser == user.IdUser);
                    if (old != null)
                    {
                        old.NameUser = user.NameUser;
                        old.AgeUser = user.AgeUser;
                        old.GenderCode = user.GenderCode;
                        old.StatusCode = user.StatusCode;
                        context.SaveChanges();
                    }

                }
                return true;
            }

            catch
            {
                return false;
            }
        }
    }
}
