using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataObject;
using DAL;

using System.Reflection;

namespace BL
{
    public class BookToUserBL
    {

        //הוספה
        public static void Add(List<BookToUserDTO> bookToUserDTO)
        {
            List<BookToUser> bookToUser = BookToUserDAL.GetAll();
            List<BookToUserDTO> listbookToUserDTO = new List<BookToUserDTO>();
            bookToUser.ForEach(x => listbookToUserDTO.Add(Convert(x)));
            bookToUserDTO.ForEach(x =>
            {
                if (listbookToUserDTO.FirstOrDefault(i => i.UserId == x.UserId && i.BookCode == x.BookCode) == null)
                    BookToUserDAL.Add(Convert(x));
                //if the book exist add else update
                else
                    BookToUserDAL.Update(Convert(x));

            });

        }
        //public static List<BookToUser> getById(int id)
        //{
        //    List<BookToUser> listBookToUser = BookToUserDAL.GetAll();
        //    return listBookToUser.FindAll(x => int.Parse(x.UserId) == id);
        //}

        public static List<ReadingBooksDTO> GetAll(string id)
        {
            //List<BookToUserDTO> listBookToUserDTO = new List<BookToUserDTO>();
            //return listBookToUserDTO;
            return BookToUserDAL.GetAll().Select(r => ReadingBooksBL.Convert(r.ReadingBooks)).ToList();
        }


        //שליפה
        public static Dictionary<string, Dictionary<int, int>> GetById(string id)
        {
            List<BookToUserDTO> listBookToUserDTO = new List<BookToUserDTO>();
           
            List <BookToUser> listBookToUser = BookToUserDAL.GetAll().FindAll(x =>x.UserId==id && DateTime.Compare(x.LastDate.Value, DateTime.Today.AddMonths(-3)) >= 1);  //שליפה של הספרים שראה מלפני 3 חודש ומעלה
            foreach (var item in listBookToUser)
            {
                listBookToUserDTO.Add(Convert(item));
            }

            Dictionary<string, Dictionary<int, int>> dictionaryOfBookToUser = new Dictionary<string, Dictionary<int, int>>();
            dictionaryOfBookToUser.Add("Author", new Dictionary<int, int>());
            dictionaryOfBookToUser.Add("Audience", new Dictionary<int, int>());
            dictionaryOfBookToUser.Add("KindOfBook", new Dictionary<int, int>());
            dictionaryOfBookToUser.Add("StatusUser", new Dictionary<int, int>());
            dictionaryOfBookToUser.Add("Gender", new Dictionary<int, int>());

            listBookToUserDTO.ForEach(x =>
            {
                ReadingBooksDTO readingBooks = ReadingBooksBL.GetById(x.BookCode);
                if (x.Like == true)
                    x.Count++;
                foreach (PropertyInfo prop in readingBooks.GetType().GetProperties())
                {
                    var type = Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType;
                    if (type.BaseType.Name == "Object"&&prop.PropertyType.Name!="String")
                    {
                        PropertyInfo obj = prop.PropertyType.GetProperties()[0];
                        int codeObj = (int)obj.GetValue(prop.GetValue(readingBooks, null), null);
                        if (dictionaryOfBookToUser[prop.Name].ContainsKey(codeObj))   //  אם קיים לך קוד של אובגקט מסוים אז סימן שכבר נכנס פעם אחת לזה 
                            dictionaryOfBookToUser[prop.Name][codeObj]+=x.Count;        //מוסיפים אחד לכמות הקיימת
                        else                                  //אם לא אז מוסיפים אחד
                            dictionaryOfBookToUser[prop.Name].Add(codeObj, x.Count);
                    }
                }
            });
            int mone = 0;
            Dictionary<string, Dictionary<int, int>> percent = new Dictionary<string, Dictionary<int, int>>();
            foreach (var key in dictionaryOfBookToUser.Keys)   //מי שהכמות של הקוד הזה קטן משתיים אני מסירה אותו כי זה מאד מינורי ולא צריך להתייחס לכמות כזו
            {
                percent.Add(key, new Dictionary<int, int>());
                foreach (var count in dictionaryOfBookToUser[key])
                {
                    //if (count.Value <= 2)
                    //    key.Remove(count.Value);
                    //else                            //אם לא קטן משתיים תספור לי כמה היה מזה
                        mone += count.Value;
                }
                foreach (var count in dictionaryOfBookToUser[key])
                {
                    percent[key].Add(count.Key, (count.Value * 100) / mone);

                }
                mone = 0;
            }
            return percent;

        }



        //עדכון
        public static bool Update(BookToUserDTO bookToUserDTO)
        {
            BookToUser bookToUser = new BookToUser();
            bookToUser = Convert(bookToUserDTO);
            return BookToUserDAL.Update(bookToUser);

        }

        public static BookToUser Convert(BookToUserDTO bookToUserDTO)
        {
            BookToUser bookToUser = new BookToUser();
            bookToUser.CodeBookToUser = bookToUserDTO.CodeBookToUser;
            bookToUser.BookCode = bookToUserDTO.CodeBookToUser;
            bookToUser.UserId = bookToUserDTO.UserId;
            return bookToUser;


        }
        public static BookToUserDTO Convert(BookToUser bookToUser)
        {
            BookToUserDTO bookToUserDTO = new BookToUserDTO();
            bookToUserDTO.CodeBookToUser = bookToUser.CodeBookToUser;
            bookToUserDTO.BookCode = bookToUser.BookCode;
            bookToUserDTO.UserId = bookToUser.UserId;
            bookToUserDTO.LastDate =(DateTime) bookToUser.LastDate;
            bookToUserDTO.Count =(int) bookToUser.Count;
            bookToUserDTO.Like =(bool) bookToUser.Like;
            return bookToUserDTO;
        }

    }
}


