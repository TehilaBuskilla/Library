﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAL
{
   public class AuthorsDAL
    {
        //שליפה להכל
        public static List<Authors> GetAll()
        {
            using (var context = new LibraryDBEntities())
            {
                List<Authors> listAuthors = context.Authors.ToList();
                return listAuthors;
            }

        }

        //שליפת נתון

        //public static Get()
        // {
        //using (var context = new LibraryDBEntities())
        //{
        //    return context.Authors.
        //}
        //  }
        //הוספה
        public static int Add(Authors author)
        {
            using (var context = new LibraryDBEntities())
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

        //מחיקה

        public static bool Delete(int code)
        {
            using (var context = new LibraryDBEntities())
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




        //עדכון
        public static bool Update(Authors author)
        {
            try
            {
                using (var context = new LibraryDBEntities())
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
