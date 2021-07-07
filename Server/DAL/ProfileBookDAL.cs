using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL
{
   public class ProfileBookDAL
    {

        // Get
        public static List<ProfileBook> GetAll()
        {
            using (var context = new LibraryDBEntities1())
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
            using (var context = new LibraryDBEntities1())
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
            using (var context = new LibraryDBEntities1())
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
        public static bool Update(ProfileBook profileBook)
        {
            try
            {
                using (var context = new LibraryDBEntities1())
                {


                    ProfileBook old = context.ProfileBook.FirstOrDefault(x => x.CodeProfileBook == profileBook.CodeProfileBook);
                    if (old != null)
                    {
                        old.BookCode = profileBook.BookCode;
                        old.KindBook = profileBook.KindBook;
                        old.AudienceAge = profileBook.AudienceAge;
                        old.AudienceStatus = profileBook.AudienceStatus;
                        old.AudienceGender = profileBook.AudienceGender;
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
