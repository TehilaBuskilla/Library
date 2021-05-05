using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataObject;
using DAL;

namespace BL
{
    public class AudiencesForUsersBL
    {

        //הוספה
        public static int Add(AudiencesForUsersDTO audiencesForUsersDTO)
        {
            return AudiencesForUsersDAL.Add(Convert(audiencesForUsersDTO));
        }

        //שליפה
        public static List<AudiencesForUsersDTO> GetAll()
        {
            List<AudiencesForUsersDTO> listAudiencesForUsersDTO = new List<AudiencesForUsersDTO>();
            List<AudiencesForUsers> listAudiencesForUsers = AudiencesForUsersDAL.GetAll();


            foreach (var item in listAudiencesForUsers)
            {
                listAudiencesForUsersDTO.Add(Convert(item));
            }
            return listAudiencesForUsersDTO;
        }
        public static List<AudiencesForUsersDTO> getById(string id)
        {
            List<AudiencesForUsersDTO> listAudiencesForUsersDTO = new List<AudiencesForUsersDTO>();
            List<AudiencesForUsers> listAudiencesForUsers = AudiencesForUsersDAL.GetAll();


            foreach (var item in listAudiencesForUsers)
            {
                listAudiencesForUsersDTO.Add(Convert(item));
            }
            return listAudiencesForUsersDTO.FindAll(x => x.UserId == id);
        }
        //מחיקה
        public static bool Delete(int CodeAudiencesForUsers)
        {
            return AudiencesForUsersDAL.Delete(CodeAudiencesForUsers);
        }

        //עדכון
        public static bool Update(AudiencesForUsersDTO audiencesForUsersDTO)
        {
            AudiencesForUsers audienceForUser = new AudiencesForUsers();
            audienceForUser = Convert(audiencesForUsersDTO);
            return AudiencesForUsersDAL.Update(audienceForUser);

        }

        public static AudiencesForUsers Convert(AudiencesForUsersDTO audiencesForUsersDTO)
        {
            AudiencesForUsers audienceForUser = new AudiencesForUsers();
            audienceForUser.CodeAudiencesForUsers = audiencesForUsersDTO.CodeAudiencesForUsers;
            audienceForUser.AudienceCode = audiencesForUsersDTO.AudienceCode;
            audienceForUser.UserId = audiencesForUsersDTO.UserId;
            return audienceForUser;


        }
        public static AudiencesForUsersDTO Convert(AudiencesForUsers audienceForUser)
        {
            AudiencesForUsersDTO audiencesForUsersDTO = new AudiencesForUsersDTO();
            audiencesForUsersDTO.CodeAudiencesForUsers = audienceForUser.CodeAudiencesForUsers;
            audiencesForUsersDTO.AudienceCode = audienceForUser.AudienceCode;
            audiencesForUsersDTO.UserId = audienceForUser.UserId;

            return audiencesForUsersDTO;
        }
    }
}
