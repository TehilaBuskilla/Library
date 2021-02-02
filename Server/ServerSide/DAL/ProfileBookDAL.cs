using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAL
{
   public class ProfileBookDAL
    {
       
        //שליפה להכל
        public static List<ProfileBook> GetAll()
        {
            using (var context = new LibraryDBEntities())
            {
                List<ProfileBook> listProfileBook = context.ProfileBook.ToList();
                return listProfileBook;
            }



        }

        //שליפת נתון

        //public static Get()
        // {
        //using (var context = new LibraryDBEntities())
        //{
        //    return context.ProfileBook.
        //}
        //  }

        //הוספה
        public static int Add(ProfileBook profileBook)
        {
            using (var context = new LibraryDBEntities())
            {
                context.ProfileBook.Add(profileBook);
                context.SaveChanges();
                int code = 0;
                foreach (ProfileBook item in context.ProfileBook)
                {
                    code = item.CodeProfileBook;
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
                    ProfileBook toDel = context.ProfileBook.FirstOrDefault(x => x.CodeProfileBook == code);
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
        public static bool Update(Audiences audience)
        {
            try
            {
                using (var context = new LibraryDBEntities())
                {


                    Audiences old = context.Audiences.FirstOrDefault(x => x.CodeAudience == audience.CodeAudience);
                    if (old != null)
                    {
                        old.KindAudience = audience.KindAudience;
                        old.Age = audience.Age;
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
