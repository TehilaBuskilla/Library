using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAL
{
   public class KindsOfBooksDAL
    {
        //שליפה להכל
        public static List<KindsOfBooks> GetAll()
        {
            using (var context = new LibraryDBEntities())
            {
                List<KindsOfBooks> listKindsOfBooks = context.KindsOfBooks.ToList();
                return listKindsOfBooks;
            }

        }

        //שליפת נתון

        //public static Get()
        // {
        //using (var context = new LibraryDBEntities())
        //{
        //    return context.KindsOfBooks.
        //}
        //  }
        //הוספה
        public static int Add(KindsOfBooks kindsOfBook)
        {
            using (var context = new LibraryDBEntities())
            {
                context.KindsOfBooks.Add(kindsOfBook);
                context.SaveChanges();
                int code = 0;
                foreach (KindsOfBooks item in context.KindsOfBooks)
                {
                    code = item.CodeKindBook;
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
                    KindsOfBooks toDel = context.KindsOfBooks.FirstOrDefault(x => x.CodeKindBook == code);
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
        public static bool Update(KindsOfBooks kindsOfBook)
        {
            try
            {
                using (var context = new LibraryDBEntities())
                {


                    KindsOfBooks old = context.KindsOfBooks.FirstOrDefault(x => x.CodeKindBook == kindsOfBook.CodeKindBook);
                    if (old != null)
                    {
                        old.KindBook = kindsOfBook.KindBook;
                       
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
