using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataObject;
using DAL;

namespace BL
{
    public class KindsOfBooksForUsersBL
    {
        //הוספה
        public static int Add(KindsOfBooksForUsersDTO kindsOfBooksForUsersDTO)
        {
            return KindsOfBooksForUsersDAL.Add(Convert(kindsOfBooksForUsersDTO));
        }

        //שליפה
        public static List<KindsOfBooksForUsersDTO> GetAll()
        {
            List<KindsOfBooksForUsersDTO> listKindsOfBooksForUsersDTO = new List<KindsOfBooksForUsersDTO>();
            List<KindsOfBooksForUsers> listKindsOfBooksForUsers = KindsOfBooksForUsersDAL.GetAll();


            foreach (var item in listKindsOfBooksForUsers)
            {
                listKindsOfBooksForUsersDTO.Add(Convert(item));
            }
            return listKindsOfBooksForUsersDTO;
        }

        //מחיקה
        public static bool Delete(int CodeKindsOfBooksForUsers)
        {
            return KindsOfBooksForUsersDAL.Delete(CodeKindsOfBooksForUsers);
        }

        //עדכון
        public static bool Update(KindsOfBooksForUsersDTO kindsOfBooksForUsersDTO)
        {
            KindsOfBooksForUsers kindOfBookForUser = new KindsOfBooksForUsers();
            kindOfBookForUser = Convert(kindsOfBooksForUsersDTO);
            return KindsOfBooksForUsersDAL.Update(kindOfBookForUser);

        }

        public static KindsOfBooksForUsers Convert(KindsOfBooksForUsersDTO kindsOfBooksForUsersDTO)
        {
            KindsOfBooksForUsers kindOfBookForUser = new KindsOfBooksForUsers();
            kindOfBookForUser.CodeKindsOfBooksForUsers = kindsOfBooksForUsersDTO.CodeKindsOfBooksForUsers;
            kindOfBookForUser.UserId = kindsOfBooksForUsersDTO.UserId;
            kindOfBookForUser.KindBookCode = kindsOfBooksForUsersDTO.KindOfBookCode;
            return kindOfBookForUser;


        }
        public static KindsOfBooksForUsersDTO Convert(KindsOfBooksForUsers kindOfBookForUser)
        {
            KindsOfBooksForUsersDTO kindsOfBooksForUserDTO = new KindsOfBooksForUsersDTO();
            kindsOfBooksForUserDTO.CodeKindsOfBooksForUsers = kindOfBookForUser.CodeKindsOfBooksForUsers;
            kindsOfBooksForUserDTO.UserId = kindOfBookForUser.UserId;
            kindsOfBooksForUserDTO.KindOfBookCode = kindOfBookForUser.KindBookCode;
            return kindsOfBooksForUserDTO;
        }
    }
}
