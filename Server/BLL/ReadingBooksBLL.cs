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
            List<ReadingBooksDTO> listReadingBooksDTO = new List<ReadingBooksDTO>();
            List<ReadingBooks> listReadingBooks = ReadingBooksDAL.GetAll();


            foreach (var item in listReadingBooks)
            {
                listReadingBooksDTO.Add(Convert(item));
            }
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

            readingBook.AuthorCode = readingBooksDTO.AuthorCode;
            readingBook.KindBookCode = readingBooksDTO.KindBookCode;
            readingBook.AudienceCode = readingBooksDTO.AudienceCode;
            readingBook.LengthBook = readingBooksDTO.LengthBook;
            readingBook.IsBorrowed = readingBooksDTO.IsBorrowed;
            readingBook.StatusCode = readingBooksDTO.StatusCode;
            readingBook.GenderCode = readingBooksDTO.GenderCode;
            return readingBook;


        }
        public static ReadingBooksDTO Convert(ReadingBooks readingBook)
        {
            ReadingBooksDTO readingBooksDTO = new ReadingBooksDTO();

            readingBooksDTO.NameBook = readingBook.NameBook;
            readingBooksDTO.CodeBook = readingBook.CodeBook;
            readingBooksDTO.AuthorCode = readingBook.AuthorCode;
            readingBooksDTO.KindBookCode = readingBook.KindBookCode;
            readingBooksDTO.AudienceCode = readingBook.AudienceCode;
            readingBooksDTO.LengthBook = readingBook.LengthBook;
            readingBooksDTO.IsBorrowed = readingBook.IsBorrowed;
            readingBooksDTO.StatusCode = readingBook.StatusCode;
            readingBooksDTO.GenderCode = readingBook.GenderCode;
            
            return readingBooksDTO;
        }
    }
}
