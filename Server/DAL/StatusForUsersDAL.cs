using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL
{
   public class StatusForUsersDAL
    {
        //שליפה להכל
        public static List<StatusForUsers> GetAll()
        {
            using (var context = new LibraryDBEntities())
            {
                List<StatusForUsers> listStatusForUsers = context.StatusForUsers.ToList();
                return listStatusForUsers;
            }

        }

        //שליפת נתון

        //public static Get()
        // {
        //using (var context = new LibraryDBEntities())
        //{
        //    return context.StatusForUsers.
        //}
        //  }
        //הוספה
        public static int Add(StatusForUsers statusForUser)
        {
            using (var context = new LibraryDBEntities())
            {
                context.StatusForUsers.Add(statusForUser);
                context.SaveChanges();
                int code = 0;
                foreach (StatusForUsers item in context.StatusForUsers)
                {
                    code = item.CodeStatusForUsers;
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
                    StatusForUsers toDel = context.StatusForUsers.FirstOrDefault(x => x.CodeStatusForUsers == code);
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
        public static bool Update(StatusForUsers statusForUser)
        {
            try
            {
                using (var context = new LibraryDBEntities())
                {


                    StatusForUsers old = context.StatusForUsers.FirstOrDefault(x => x.CodeStatusForUsers == statusForUser.CodeStatusForUsers);
                    if (old != null)
                    {
                        old.StatusCode = statusForUser.StatusCode;
                        old.UserId = statusForUser.UserId;
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
