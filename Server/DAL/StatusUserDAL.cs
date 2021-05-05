using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL
{
   public class StatusUserDAL
    {

        //שליפה להכל
        public static List<StatusUser> GetAll()
        {
            using (var context = new LibraryDBEntities1())
            {
                List<StatusUser> listStatusUser = context.StatusUser.ToList();
                return listStatusUser;
            }

        }

        //שליפת נתון

        //public static Get()
        // {
        //using (var context = new LibraryDBEntities())
        //{
        //    return context.StatusUser.
        //}
        //  }
        //הוספה
        public static int Add(StatusUser statusUser)
        {
            using (var context = new LibraryDBEntities1())
            {
                context.StatusUser.Add(statusUser);
                context.SaveChanges();
                int code = 0;
                foreach (StatusUser item in context.StatusUser)
                {
                    code = item.CodeStatus;
                }
                return code;
            }

        }

        //מחיקה

        public static bool Delete(int code)
        {
            using (var context = new LibraryDBEntities1())
            {
                try
                {
                    StatusUser toDel = context.StatusUser.FirstOrDefault(x => x.CodeStatus == code);
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
        public static bool Update(StatusUser statusUser)
        {
            try
            {
                using (var context = new LibraryDBEntities1())
                {


                    StatusUser old = context.StatusUser.FirstOrDefault(x => x.CodeStatus == statusUser.CodeStatus);
                    if (old != null)
                    {
                        old.KindStatus = statusUser.KindStatus;
                        
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
