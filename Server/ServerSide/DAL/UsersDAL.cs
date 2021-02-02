using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAL
{
   public class UsersDAL
    {
        //שליפה להכל
        public static List<Users> GetAll()
        {
            using (var context = new LibraryDBEntities())
            {
                List<Users> listUsers = context.Users.ToList();
                return listUsers;
            }

        }

        //שליפת נתון

        //public static Get()
        // {
        //using (var context = new LibraryDBEntities())
        //{
        //    return context.Users.
        //}
        //  }
        //הוספה
        public static int Add(Users user)
        {
            using (var context = new LibraryDBEntities())
            {
                context.Users.Add(user);
                context.SaveChanges();
                int code = 0;
                foreach (Users item in context.Users)
                {
                    code = item.IdUser;
                }
                return code;
            }

        }

        //מחיקה

        public static bool Delete(int code)
        {
            using (var context = new LibraryDBEntities())
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




        //עדכון
        public static bool Update(Users user)
        {
            try
            {
                using (var context = new LibraryDBEntities())
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
