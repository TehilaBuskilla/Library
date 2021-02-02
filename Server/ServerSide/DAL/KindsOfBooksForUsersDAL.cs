using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAL
{
   public class KindsOfBooksForUsersDAL
    {
        //שליפה להכל
        public static List<KindsOfBooksForUsers> GetAll()
        {
            using (var context = new LibraryDBEntities())
            {
                List<KindsOfBooksForUsers> listKindsOfBooksForUsers = context.KindsOfBooksForUsers.ToList();
                return listKindsOfBooksForUsers;
            }

        }

        //שליפת נתון

        //public static Get()
        // {
        //using (var context = new LibraryDBEntities())
        //{
        //    return context.Audiences.
        //}
        //  }
        //הוספה
        public static int Add(KindsOfBooksForUsers kindsOfBooksForUser)
        {
            using (var context = new LibraryDBEntities())
            {
                context.KindsOfBooksForUsers.Add(kindsOfBooksForUser);
                context.SaveChanges();
                int code = 0;
                foreach (KindsOfBooksForUsers item in context.KindsOfBooksForUsers)
                {
                    code = item.CodeAudience;
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
                    KindsOfBooksForUsers toDel = context.KindsOfBooksForUsers.FirstOrDefault(x => x.CodeKindsOfBooksForUsers == code);
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
        public static bool Update(KindsOfBooksForUsers kindsOfBooksForUser)
        {
            try
            {
                using (var context = new LibraryDBEntities())
                {


                    KindsOfBooksForUsers old = context.KindsOfBooksForUsers.FirstOrDefault(x => x.CodeKindsOfBooksForUsers == kindsOfBooksForUser.CodeKindsOfBooksForUsers);
                    if (old != null)
                    {
                        old.UserId = kindsOfBooksForUser.UserId;
                        old.KindBookCode = kindsOfBooksForUser.KindBookCode;
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
