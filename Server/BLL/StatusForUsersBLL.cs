using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataObject;
using DAL;


namespace BLL
{
    public class StatusForUsersBLL
    {
        //הוספה
        public static int Add(StatusForUsersDTO statusForUsersDTO)
        {
            return StatusForUsersDAL.Add(Convert(statusForUsersDTO));
        }

        //שליפה
        public static List<StatusForUsersDTO> GetAll()
        {
            List<StatusForUsersDTO> listStatusForUsersDTO = new List<StatusForUsersDTO>();
            List<StatusForUsers> listStatusForUsers = StatusForUsersDAL.GetAll();


            foreach (var item in listStatusForUsers)
            {
                listStatusForUsersDTO.Add(Convert(item));
            }
            return listStatusForUsersDTO;
        }

        //מחיקה
        public static bool Delete(int CodeStatusForUsers)
        {
            return StatusForUsersDAL.Delete(CodeStatusForUsers);
        }

        //עדכון
        public static bool Update(StatusForUsersDTO statusForUsersDTO)
        {
            StatusForUsers statusForUser = new StatusForUsers();
            statusForUser = Convert(statusForUsersDTO);
            return StatusForUsersDAL.Update(statusForUser);

        }

        public static StatusForUsers Convert(StatusForUsersDTO statusForUsersDTO)
        {
            StatusForUsers statusForUser = new StatusForUsers();
            statusForUser.CodeStatusForUsers = statusForUsersDTO.CodeStatusForUsers;
            statusForUser.StatusCode = statusForUsersDTO.StatusCode;
            statusForUser.UserId = statusForUsersDTO.UserId;
            return statusForUser;


        }
        public static StatusForUsersDTO Convert(StatusForUsers statusForUser)
        {
            StatusForUsersDTO statusForUsersDTO = new StatusForUsersDTO();
            statusForUsersDTO.CodeStatusForUsers = statusForUser.CodeStatusForUsers;
            statusForUsersDTO.StatusCode = statusForUser.StatusCode;
            statusForUsersDTO.UserId = statusForUser.UserId;
            return statusForUsersDTO;
        }
    }
}
