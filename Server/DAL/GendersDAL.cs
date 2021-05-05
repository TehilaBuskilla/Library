using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL
{
   public class GendersDAL
    {
        //שליפה להכל
        public static List<Genders> GetAll()
        {
            using (var context = new LibraryDBEntities1())
            {
                List<Genders> listGenders = context.Genders.ToList();
                return listGenders;
            }

        }

        //שליפת נתון

        //public static Get()
        // {
        //using (var context = new LibraryDBEntities())
        //{
        //    return context.Genders.
        //}
        //  }
        //הוספה
        public static int Add(Genders gender)
        {
            using (var context = new LibraryDBEntities1())
            {
                context.Genders.Add(gender);
                context.SaveChanges();
                int code = 0;
                foreach (Genders item in context.Genders)
                {
                    code = item.CodeGender;
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
                    Genders toDel = context.Genders.FirstOrDefault(x => x.CodeGender == code);
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
        public static bool Update(Genders gender)
        {
            try
            {
                using (var context = new LibraryDBEntities1())
                {


                    Genders old = context.Genders.FirstOrDefault(x => x.CodeGender == gender.CodeGender);
                    if (old != null)
                    {
                        old.KindGender= gender.KindGender;
                       
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
