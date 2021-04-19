using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataObject;
using DAL;

namespace BLL
{
   public class ProfileBookBLL
    {
        //הוספה
        public static int Add(ProfileBookDTO profileBookDTO)
        {
            return ProfileBookDAL.Add(Convert(profileBookDTO));
        }

        //שליפה
        public static List<ProfileBookDTO> GetAll()
        {
            List<ProfileBookDTO> listProfileBookDTO = new List<ProfileBookDTO>();
            List<ProfileBook> listProfileBook = ProfileBookDAL.GetAll();


            foreach (var item in listProfileBook)
            {
                listProfileBookDTO.Add(Convert(item));
            }
            return listProfileBookDTO;
        }

        //מחיקה
        public static bool Delete(int CodeProfileBook)
        {
            return ProfileBookDAL.Delete(CodeProfileBook);
        }

        //עדכון
        public static bool Update(ProfileBookDTO profileBookDTO)
        {
            ProfileBook profileBook = new ProfileBook();
            profileBook = Convert(profileBookDTO);
            return ProfileBookDAL.Update(profileBook);

        }

        public static ProfileBook Convert(ProfileBookDTO profileBookDTO)
        {
            ProfileBook profileBook = new ProfileBook();
            profileBook.CodeProfileBook = profileBookDTO.CodeProfileBook;
            profileBook.BookCode = profileBookDTO.BookCode;
            profileBook.KindBook = profileBookDTO.KindBook;
            profileBook.AudienceAge = profileBookDTO.AudienceAge;
            profileBook.AudienceStatus = profileBookDTO.AudienceStatus;
            profileBook.AudienceGender = profileBookDTO.AudienceGender;
            return profileBook;


        }
        public static ProfileBookDTO Convert(ProfileBook profileBook)
        {
            ProfileBookDTO profileBookDTO = new ProfileBookDTO();
            profileBookDTO.CodeProfileBook = profileBook.CodeProfileBook;
            profileBookDTO.BookCode = profileBook.BookCode;
            profileBookDTO.KindBook = profileBook.KindBook;
            profileBookDTO.AudienceAge = profileBook.AudienceAge;
            profileBookDTO.AudienceStatus = profileBook.AudienceStatus;
            profileBookDTO.AudienceGender = profileBook.AudienceGender;
            return profileBookDTO;
        }
    }
}
