using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace DAL
{
   public class AudiencesDAL
    {
        //שליפה להכל
        public static List<Audiences> GetAll()
        {
            using (var context = new LibraryDBEntities1())
            {
                List<Audiences> listAudiences = context.Audiences.ToList();
                return listAudiences;
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
        public static int Add(Audiences audience)
        {
            using (var context = new LibraryDBEntities1())
            {
                context.Audiences.Add(audience);
                context.SaveChanges();
                int code = 0;
                foreach(Audiences item in context.Audiences)
                {
                    code = item.CodeAudience;
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
                    Audiences toDel = context.Audiences.FirstOrDefault(x => x.CodeAudience == code);
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
                using (var context = new LibraryDBEntities1())
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
