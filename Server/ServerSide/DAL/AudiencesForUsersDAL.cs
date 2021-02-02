using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAL
{
   public class AudiencesForUsersDAL
    {
        //שליפה להכל
        public static List<AudiencesForUsers> GetAll()
        {
            using (var context = new LibraryDBEntities())
            {
                List<AudiencesForUsers> listAudiencesForUsers = context.AudiencesForUsers.ToList();
                return listAudiencesForUsers;
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
        public static int Add(AudiencesForUsers audienceForUser)
        {
            using (var context = new LibraryDBEntities())
            {
                context.AudiencesForUsers.Add(audienceForUser);
                context.SaveChanges();
                int code = 0;
                foreach (AudiencesForUsers item in context.AudiencesForUsers)
                {
                    code = item.CodeAudiencesForUsers;
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
                    AudiencesForUsers toDel = context.AudiencesForUsers.FirstOrDefault(x => x.CodeAudiencesForUsers == code);
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
        public static bool Update(AudiencesForUsers audienceForUser)
        {
            try
            {
                using (var context = new LibraryDBEntities())
                {


                    AudiencesForUsers old = context.AudiencesForUsers.FirstOrDefault(x => x.CodeAudiencesForUsers == audienceForUser.CodeAudiencesForUsers);
                    if (old != null)
                    {
                        old.AudienceCode = audienceForUser.AudienceCode;
                        old.UserId = audienceForUser.UserId;
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
