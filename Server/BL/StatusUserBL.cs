using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataObject;
using DAL;

namespace BL
{
    public class StatusUserBL
    {
        //הוספה
        public static int Add(StatusUserDTO statusUserDTO)
        {
            return StatusUserDAL.Add(Convert(statusUserDTO));
        }

        //שליפה
        public static List<StatusUserDTO> GetAll()
        {
            List<StatusUserDTO> listStatusUserDTO = new List<StatusUserDTO>();
            List<StatusUser> listStatusUser = StatusUserDAL.GetAll();


            foreach (var item in listStatusUser)
            {
                listStatusUserDTO.Add(Convert(item));
            }
            return listStatusUserDTO;
        }

        //מחיקה
        public static bool Delete(int CodeStatus)
        {
            return StatusUserDAL.Delete(CodeStatus);
        }

        //עדכון
        public static bool Update(StatusUserDTO statusUserDTO)
        {
            StatusUser statusUser = new StatusUser();
            statusUser = Convert(statusUserDTO);
            return StatusUserDAL.Update(statusUser);

        }

        public static StatusUser Convert(StatusUserDTO statusUserDTO)
        {
            StatusUser statusUser = new StatusUser();
            statusUser.CodeStatus = statusUserDTO.CodeStatus;
            statusUser.KindStatus = statusUserDTO.KindStatus;

            return statusUser;


        }
        public static StatusUserDTO Convert(StatusUser statusUser)
        {
            StatusUserDTO statusUserDTO = new StatusUserDTO();
            statusUserDTO.CodeStatus = statusUser.CodeStatus;
            statusUserDTO.KindStatus = statusUser.KindStatus;

            return statusUserDTO;
        }
    }
}
