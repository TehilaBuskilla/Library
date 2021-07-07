using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class AuthorsDAL
    {
        //Get
        public static List<Authors> GetAll()
        {
            using (var context = new LibraryDBEntities1())
            {
                List<Authors> listAuthors = context.Authors.ToList();
                return listAuthors;
            }

        }

        //Add
        public static int Add(Authors author)
        {
            using (var context = new LibraryDBEntities1())
            {
                context.Authors.Add(author);
                context.SaveChanges();
                int code = 0;
                foreach (Authors item in context.Authors)
                {
                    code = item.CodeAuthor;
                }
                return code;
            }

        }

        //Delete

        public static bool Delete(int code)
        {
            using (var context = new LibraryDBEntities1())
            {
                try
                {
                    Authors toDel = context.Authors.FirstOrDefault(x => x.CodeAuthor == code);
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


        //Update
        public static bool Update(Authors author)
        {
            try
            {
                using (var context = new LibraryDBEntities1())
                {


                    Authors old = context.Authors.FirstOrDefault(x => x.CodeAuthor == author.CodeAuthor);
                    if (old != null)
                    {
                        old.NameAuthor = author.NameAuthor;
                       
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
