﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL
{
   public class UsersDAL
    {
        //שליפה להכל
        public static List<Users> GetAll()
        {
            using (var context = new LibraryDBEntities1())
            {

                List<Users> listUsers = context.Users.ToList();
                
                return listUsers;
            }
          

        }

        //שליפה ע"י נתון

        public static Users GetById(string id)
        {
            using (var context = new LibraryDBEntities1())
            {
                if(context.Users.FirstOrDefault(a => a.IdUser == id)==null)
                {
                    return null;
                }
                return context.Users.FirstOrDefault(a => a.IdUser == id);
            }
              
        }
        //הוספה
        public static string Add(Users user)
        {
            using (var context = new LibraryDBEntities1())
            {
                context.Users.Add(user);
                context.SaveChanges();
                //int code = 0;
                //foreach (Users item in context.Users)
                //{
                //    code = item.IdUser;
                //}
                return "";
            }

        }

        //מחיקה

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




        //עדכון
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
