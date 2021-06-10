using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataObject;
using DAL;
using
using System.Reflection;

namespace BL
{
    public class BookToUserBL
    {

        //הוספה
        public static void Add(List <BookToUserDTO> bookToUserDTO)
        {
            List<BookToUserDTO> bookToUser = BookToUserBL.GetAll();
            bookToUserDTO.ForEach(x =>
            {
                if (bookToUser.FirstOrDefault(i => i.UserId == x.UserId && i.BookCode==x.BookCode) == null)
                    BookToUserDAL.Add(Convert(x));
                //if the book exist add else update
                else
                    BookToUserDAL.Update(Convert(x));

            });
            
        }
        public static List<BookToUser> getById(int id)
        {
            List<BookToUser> listBookToUser = BookToUserDAL.GetAll();
            return listBookToUser.FindAll(x => int.Parse(x.UserId) == id);
        }

        //שליפה
        public static List<BookToUserDTO> GetAll()
        {
            List<BookToUserDTO> listBookToUserDTO = new List<BookToUserDTO>();
            List<BookToUser> listBookToUser = BookToUserDAL.GetAll();
            foreach (var item in listBookToUser)
            {
                listBookToUserDTO.Add(Convert(item));
            }

            Dictionary<string, Dictionary<int, int>> dictionaryOfBookToUser = new Dictionary<string, Dictionary<int, int>>();
            dictionaryOfBookToUser.Add("Author", null);
            dictionaryOfBookToUser.Add("Audience", null);
            dictionaryOfBookToUser.Add("KindOfBook", null);
            dictionaryOfBookToUser.Add("StatusUser", null);
            dictionaryOfBookToUser.Add("Gender", null);

            listBookToUserDTO.ForEach(x =>
            {
                ReadingBooksDTO readingBooks = ReadingBooksBL.GetById(x.BookCode);
                foreach (PropertyInfo prop in readingBooks.GetType().GetProperties())
                {
                    var type = Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType;
                    if (type == typeof(object))
                        foreach (var key in dictionaryOfBookToUser[prop.Name])
                        {
                            //if(key.Key==prop.GetValue())
                            
                        }

                }


            });

            return listBookToUserDTO;

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
            bookToUser.UserId = bookToUserDTO.UserId.IdUser;
            return bookToUser;


        }
        public static BookToUserDTO Convert(BookToUser bookToUser)
        {
            BookToUserDTO bookToUserDTO = new BookToUserDTO();
            bookToUserDTO.CodeBookToUser = bookToUser.CodeBookToUser;
            //bookToUserDTO.BookCode = bookToUser;
            //bookToUserDTO.UserId = bookToUser.UserId;

            return bookToUserDTO;
        }

    }
}
