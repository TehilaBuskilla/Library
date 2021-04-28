using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataObject;
using DAL;

namespace BLL
{
   public class ReadingBooksBLL
    {
        //הוספה
        public static int Add(ReadingBooksDTO readingBooksDTO)
        {
            return ReadingBooksDAL.Add(Convert(readingBooksDTO));
        }

        //שליפה
        public static List<ReadingBooksDTO> GetAll()
        {
            List<ReadingBooksDTO> listReadingBooksDTO = ReadingBooksDAL.GetAll();
            //List<ReadingBooks> listReadingBooks = 


            //foreach (var item in listReadingBooks)
            //{
            //    listReadingBooksDTO.Add(Convert(item));
            //}
            return listReadingBooksDTO;
        }

        //מחיקה
        public static bool Delete(int CodeBook)
        {
            return ReadingBooksDAL.Delete(CodeBook);
        }

        //עדכון
        public static bool Update(ReadingBooksDTO readingBooksDTO)
        {
            ReadingBooks readingBook = new ReadingBooks();
            readingBook = Convert(readingBooksDTO);
            return ReadingBooksDAL.Update(readingBook);

        }

        public static ReadingBooks Convert(ReadingBooksDTO readingBooksDTO)
        {
            ReadingBooks readingBook = new ReadingBooks();

            readingBook.NameBook = readingBooksDTO.NameBook;
            readingBook.CodeBook = readingBooksDTO.CodeBook;
            readingBook.AuthorCode = readingBooksDTO.Author.CodeAuthor;
            readingBook.KindBookCode = readingBooksDTO.KindOfBook.CodeKindBook;
            readingBook.AudienceCode = readingBooksDTO.Audience.CodeAudience;
            readingBook.LengthBook = readingBooksDTO.LengthBook;
            readingBook.IsBorrowed = readingBooksDTO.IsBorrowed;
            readingBook.StatusCode = readingBooksDTO.StatusUser.CodeStatus;
            readingBook.GenderCode = readingBooksDTO.Gender.CodeGender;
            return readingBook;


        }
        public static ReadingBooksDTO Convert(ReadingBooks readingBook)
        {
            ReadingBooksDTO readingBooksDTO = new ReadingBooksDTO();

            //readingBooksDTO.NameBook = readingBook.NameBook;
            //readingBooksDTO.CodeBook = readingBook.CodeBook;
            //readingBooksDTO.AuthorCode = readingBook.AuthorCode;
            //readingBooksDTO.KindBookCode = readingBook.KindBookCode;
            //readingBooksDTO.AudienceCode = readingBook.AudienceCode;
            //readingBooksDTO.LengthBook = readingBook.LengthBook;
            //readingBooksDTO.IsBorrowed = readingBook.IsBorrowed;
            //readingBooksDTO.StatusCode = readingBook.StatusCode;
            //readingBooksDTO.GenderCode = readingBook.GenderCode;
            
            return readingBooksDTO;
        }
    }
}
