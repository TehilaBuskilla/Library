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

        //Add
        public static void Add(BookToUserDTO bookToUserDTO)
        {
            List<BookToUser> bookToUser = BookToUserDAL.GetAll();
            var bookToUserItem = bookToUser.FirstOrDefault(r => r.UserId == bookToUserDTO.UserId && r.BookCode == bookToUserDTO.BookCode);
                if (bookToUserItem==null)
                    BookToUserDAL.Add(Convert(bookToUserDTO));
                //if the book exist add else update
                else
                    BookToUserDAL.Update(bookToUserItem);

           

        }
        
        //Get
        public static List<ReadingBooksDTO> GetAll(string id,bool? love)
        {
            List<BookToUser> bookToUsers = BookToUserDAL.GetAll().FindAll(a => a.UserId == id);
            if (love == true)
                bookToUsers = bookToUsers.Where(x => x.Like == true).ToList();
            return bookToUsers.Select(r => ReadingBooksBL.Convert(r.ReadingBooks)).ToList();
        }


        //Algorithm
        public static Dictionary<string, Dictionary<int, int>> GetById(string id)
        {
            List<BookToUserDTO> listBookToUserDTO = new List<BookToUserDTO>();
           //create list of all books from history of user and filter books only from last 3 month.
            List <BookToUser> listBookToUser = BookToUserDAL.GetAll().FindAll(x =>x.UserId==id && DateTime.Compare(x.LastDate.Value, DateTime.Today.AddMonths(-3)) >= 1);     
            foreach (var item in listBookToUser)
            {
                listBookToUserDTO.Add(Convert(item));
            }

            Dictionary<string, Dictionary<int, int>> dictionaryOfBookToUser = new Dictionary<string, Dictionary<int, int>>();
            dictionaryOfBookToUser.Add("Author", new Dictionary<int, int>());
            dictionaryOfBookToUser.Add("Audience", new Dictionary<int, int>());//create dictionary that contain the all parameters 
            dictionaryOfBookToUser.Add("KindOfBook", new Dictionary<int, int>());
            dictionaryOfBookToUser.Add("StatusUser", new Dictionary<int, int>());
            dictionaryOfBookToUser.Add("Gender", new Dictionary<int, int>());

            listBookToUserDTO.ForEach(x =>
            {
                ReadingBooksDTO readingBooks = ReadingBooksBL.GetById(x.BookCode);    
                if (x.Like == true)  //for on every book :if this book is like -add to count 
                    x.Count++;
                foreach (PropertyInfo prop in readingBooks.GetType().GetProperties()) //bring the book from database and for on it
                {
                    var type = Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType;
                    if (type.BaseType.Name == "Object"&&prop.PropertyType.Name!="String")
                    {//if this object
                        PropertyInfo obj = prop.PropertyType.GetProperties()[0];//insert code parameter to obj
                        int codeObj = (int)obj.GetValue(prop.GetValue(readingBooks, null), null); //insert value of code parameter to codeObj
                        if (dictionaryOfBookToUser[prop.Name].ContainsKey(codeObj))  //if exist in dictionary this key :
                            dictionaryOfBookToUser[prop.Name][codeObj]+=x.Count;        //  insert count to this key 
                        else                                                           //if no exist in dictionary:
                            dictionaryOfBookToUser[prop.Name].Add(codeObj, x.Count);   //add in key the count
                    }
                }
            });
            int mone = 0;                                          //dictionary of percents
            Dictionary<string, Dictionary<int, int>> percent = new Dictionary<string, Dictionary<int, int>>();
            foreach (var key in dictionaryOfBookToUser.Keys)   
            {
                percent.Add(key, new Dictionary<int, int>());
                foreach (var count in dictionaryOfBookToUser[key])
                {                                                                      
                        mone += count.Value;
                }                                                      //change the count to percents
                foreach (var count in dictionaryOfBookToUser[key])
                {
                    percent[key].Add(count.Key, (count.Value * 100) / mone);

                }
                mone = 0;
            }
            return percent;                                       //return dictionary of percents

        }



        //Update
        public static bool Update(BookToUserDTO bookToUserDTO)
        {
            BookToUser bookToUser = new BookToUser();
            bookToUser = Convert(bookToUserDTO);
            return BookToUserDAL.Update(bookToUser);

        }

        //Delete
        public static bool Delete(int CodeBookToUser)
        {
            return BookToUserDAL.Delete(CodeBookToUser);
        }
        public static BookToUser Convert(BookToUserDTO bookToUserDTO)
        {
            BookToUser bookToUser = new BookToUser();
            bookToUser.CodeBookToUser = bookToUserDTO.CodeBookToUser;
            bookToUser.BookCode = bookToUserDTO.BookCode;
            bookToUser.UserId = bookToUserDTO.UserId;
            bookToUser.LastDate = bookToUserDTO.LastDate;
            bookToUser.Count = bookToUserDTO.Count;
            bookToUser.Like = bookToUserDTO.Like;
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


