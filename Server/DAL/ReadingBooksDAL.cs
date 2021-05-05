using DataObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL
{
    public class ReadingBooksDAL
    {
        //שליפה להכל
        public static List<ReadingBooksDTO> GetAll()
        {
            using (var context = new LibraryDBEntities1())
            {
                List<ReadingBooksDTO> listReadingBooksDTO = new List<ReadingBooksDTO>();
                List<ReadingBooks> listReadingBooks = context.ReadingBooks.ToList();
                foreach (var item in listReadingBooks)
                {
                    listReadingBooksDTO.Add(new ReadingBooksDTO
                    {
                        CodeBook = item.CodeBook,
                        NameBook = item.NameBook,
                        IsBorrowed = item.IsBorrowed,
                        LengthBook = item.LengthBook,
                        Author = new AuthorsDTO
                        {
                            CodeAuthor = item.Authors.CodeAuthor,
                            NameAuthor = item.Authors.NameAuthor
                        },
                        KindOfBook = new KindsOfBooksDTO
                        {
                            CodeKindBook = item.KindsOfBooks.CodeKindBook,
                            KindBook = item.KindsOfBooks.KindBook
                        },
                        Gender = new GendersDTO {
                            CodeGender = item.Genders.CodeGender,
                            KindGender = item.Genders.KindGender
                        },
                        Audience = new AudiencesDTO
                        {
                            KindAudience = item.Audiences.KindAudience,
                            Age = item.Audiences.Age,
                            CodeAudience = item.Audiences.CodeAudience
                        },
                        StatusUser = new StatusUserDTO
                        {
                            CodeStatus = item.StatusUser.CodeStatus,
                            KindStatus = item.StatusUser.KindStatus
                        },
                        

                    });
                }
                return listReadingBooksDTO;
            }

        }

        //שליפת נתון

        //public static Get()
        // {
        //using (var context = new LibraryDBEntities())
        //{
        //    return context.ReadingBooks.
        //}
        //  }
        //הוספה
        public static int Add(ReadingBooks readingBook)
        {
            using (var context = new LibraryDBEntities1())
            {
                context.ReadingBooks.Add(readingBook);
                context.SaveChanges();
                int code = 0;
                foreach (ReadingBooks item in context.ReadingBooks)
                {
                    code = item.KindBookCode;
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
                    ReadingBooks toDel = context.ReadingBooks.FirstOrDefault(x => x.KindBookCode == code);
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
        public static bool Update(ReadingBooks readingBook)
        {
            try
            {
                using (var context = new LibraryDBEntities1())
                {


                    ReadingBooks old = context.ReadingBooks.FirstOrDefault(x => x.KindBookCode == readingBook.KindBookCode);
                    if (old != null)
                    {
                        old.NameBook = readingBook.NameBook;
                        old.AuthorCode = readingBook.AuthorCode;
                        old.KindBookCode = readingBook.KindBookCode;
                        old.AudienceCode = readingBook.AudienceCode;
                        old.LengthBook = readingBook.LengthBook;
                        old.IsBorrowed = readingBook.IsBorrowed;
                        old.StatusCode = readingBook.StatusCode;
                        old.GenderCode = readingBook.GenderCode;

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
