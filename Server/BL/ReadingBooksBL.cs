using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataObject;
using DAL;

namespace BL
{
    public class ReadingBooksBL
    {
        //Add
        public static int Add(ReadingBooksDTO readingBooksDTO)
        {
            return ReadingBooksDAL.Add(Convert(readingBooksDTO));
        }

        //Update
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

        public static ReadingBooksDTO GetById(int id)
        {
            ReadingBooksDTO listReadingBooksDTO = DAL.ReadingBooksDAL.GetAll().Find(r =>r.CodeBook == id);
            return listReadingBooksDTO;
        }

        //Delete
        public static bool Delete(int CodeBook)
        {
            return ReadingBooksDAL.Delete(CodeBook);
        }

        //Update
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
           
            readingBook.StatusCode = readingBooksDTO.StatusUser.CodeStatus;
            readingBook.GenderCode = readingBooksDTO.Gender.CodeGender;
            readingBook.ImgBook = readingBooksDTO.ImgBook;
            return readingBook;


        }
        public static ReadingBooksDTO Convert(ReadingBooks item)
        {
            return new ReadingBooksDTO
            {
                NameBook = item.NameBook,
                CodeBook = item.CodeBook,
                LengthBook = item.LengthBook,
                ImgBook = item.ImgBook,


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
                Audience = new AudiencesDTO
                {
                    CodeAudience = item.Audiences.CodeAudience,
                    KindAudience = item.Audiences.KindAudience,
                    Age = item.Audiences.Age
                },
                StatusUser = new StatusUserDTO
                {
                    CodeStatus = item.StatusUser.CodeStatus,
                    KindStatus = item.StatusUser.KindStatus
                },
                Gender = new GendersDTO
                {
                    CodeGender = item.Genders.CodeGender,
                    KindGender = item.Genders.KindGender
                }






            }; 
        }
    }
}
