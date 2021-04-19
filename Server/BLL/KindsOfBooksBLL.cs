using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataObject;
using DAL;


namespace BLL
{
   public class KindsOfBooksBLL
    {
        //הוספה
        public static int Add(KindsOfBooksDTO kindsOfBooksDTO)
        {
            return KindsOfBooksDAL.Add(Convert(kindsOfBooksDTO));
        }

        //שליפה
        public static List<KindsOfBooksDTO> GetAll()
        {
            List<KindsOfBooksDTO> listkindsOfBooksDTO = new List<KindsOfBooksDTO>();
            List<KindsOfBooks> listKindsOfBooks = KindsOfBooksDAL.GetAll();


            foreach (var item in listKindsOfBooks)
            {
                listkindsOfBooksDTO.Add(Convert(item));
            }
            return listkindsOfBooksDTO;
        }

        //מחיקה
        public static bool Delete(int CodeKindBook)
        {
            return KindsOfBooksDAL.Delete(CodeKindBook);
        }

        //עדכון
        public static bool Update(KindsOfBooksDTO kindsOfBooksDTO)
        {
            KindsOfBooks kindOfBook = new KindsOfBooks();
            kindOfBook = Convert(kindsOfBooksDTO);
            return KindsOfBooksDAL.Update(kindOfBook);

        }

        public static KindsOfBooks Convert(KindsOfBooksDTO kindsOfBooksDTO)
        {
            KindsOfBooks kindOfBook = new KindsOfBooks();
            kindOfBook.CodeKindBook = kindsOfBooksDTO.CodeKindBook;
            kindOfBook.KindBook = kindsOfBooksDTO.KindBook;
          
            return kindOfBook;


        }
        public static KindsOfBooksDTO Convert(KindsOfBooks kindOfBook)
        {
            KindsOfBooksDTO kindsOfBooksDTO = new KindsOfBooksDTO();
            kindsOfBooksDTO.CodeKindBook = kindOfBook.CodeKindBook;
            kindsOfBooksDTO.KindBook = kindOfBook.KindBook;
          
            return kindsOfBooksDTO;
        }
    }
}
