using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL
{
   public class AuthorsForUsersDAL
    {
        //שליפה להכל
        public static List<AuthorsForUsers> GetAll()
        {
            using (var context = new LibraryDBEntities())
            {
                List<AuthorsForUsers> listAuthorsForUsers = context.AuthorsForUsers.ToList();
                return listAuthorsForUsers;
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
        public static int Add(AuthorsForUsers authorsForUser)
        {
            using (var context = new LibraryDBEntities())
            {
                context.AuthorsForUsers.Add(authorsForUser);
                context.SaveChanges();
                int code = 0;
                foreach (AuthorsForUsers item in context.AuthorsForUsers)
                {
                    code = item.CodeAuthorsForUsers;
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
                    AuthorsForUsers toDel = context.AuthorsForUsers.FirstOrDefault(x => x.CodeAuthorsForUsers == code);
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
        public static bool Update(AuthorsForUsers authorsForUser)
        {
            try
            {
                using (var context = new LibraryDBEntities())
                {


                    AuthorsForUsers old = context.AuthorsForUsers.FirstOrDefault(x => x.CodeAuthorsForUsers == authorsForUser.CodeAuthorsForUsers);
                    if (old != null)
                    {
                        old.AuthorCode = authorsForUser.AuthorCode;
                        old.UserId = authorsForUser.UserId;
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
