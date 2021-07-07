using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataObject;
using DAL;

namespace BL
{
    public class BorrowedBooksBL
    {
        //Add
        public static int Add(BorrowedBooksDTO borrowedBooksDTO)
        {
            return BorrowedBooksDAL.Add(Convert(borrowedBooksDTO));
        }

        //Get
        public static List<BorrowedBooksDTO> GetAll()
        {
            List<BorrowedBooksDTO> listBorrowedBooksDTO = new List<BorrowedBooksDTO>();
            List<BorrowedBooks> listBorrowedBooks = BorrowedBooksDAL.GetAll();


            foreach (var item in listBorrowedBooks)
            {
                listBorrowedBooksDTO.Add(Convert(item));
            }
            return listBorrowedBooksDTO;
        }
        //public static List<BorrowedBooksDTO> GetBy(string code)
        //{

        //    List<BorrowedBooksDTO> listBorroedBooksDTO = BorrowedBooksBL.GetAll().FindAll(a => a.UserId == code);
        //    foreach (var item in listBorroedBooks)
        //    {

        //    }

        //    //return listBorroedBooks;
        //}


        //Delete
        public static bool Delete(int CodeBorrowedBooks)
        {
            return BorrowedBooksDAL.Delete(CodeBorrowedBooks);
        }

        //Update
        public static bool Update(BorrowedBooksDTO borrowedBooksDTO)
        {
            BorrowedBooks borrowedBook = new BorrowedBooks();
            borrowedBook = Convert(borrowedBooksDTO);
            return BorrowedBooksDAL.Update(borrowedBook);

        }

        public static BorrowedBooks Convert(BorrowedBooksDTO borrowedBooksDTO)
        {
            BorrowedBooks borrowedBook = new BorrowedBooks();
            borrowedBook.CodeBorrowedBooks = borrowedBooksDTO.CodeBorrowedBooks;
            borrowedBook.BookCode = borrowedBooksDTO.BookCode;
            borrowedBook.UserId = borrowedBooksDTO.UserId;
            borrowedBook.BorrowingDate = borrowedBooksDTO.BorrowingDate;
            return borrowedBook;


        }
        public static BorrowedBooksDTO Convert(BorrowedBooks borrowedBook)
        {
            BorrowedBooksDTO borrowedBooksDTO = new BorrowedBooksDTO();
            borrowedBooksDTO.CodeBorrowedBooks = borrowedBook.CodeBorrowedBooks;
            borrowedBooksDTO.BookCode = borrowedBook.BookCode;
            borrowedBooksDTO.UserId = borrowedBook.UserId;
            borrowedBooksDTO.BorrowingDate = borrowedBook.BorrowingDate;
            return borrowedBooksDTO;
        }
    }
}
