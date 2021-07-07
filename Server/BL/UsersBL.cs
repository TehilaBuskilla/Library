using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataObject;
using DAL;

namespace BL
{
    public class UsersBL
    {
        //Add
        public static string Add(UsersDTO usersDTO)
        {
            return UsersDAL.Add(Convert(usersDTO));
        }

        //Get
        public static List<UsersDTO> GetAll()
        {
            List<UsersDTO> listUsersDTO = new List<UsersDTO>();
            List<Users> listUsers = UsersDAL.GetAll();


            foreach (var item in listUsers)
            {
                listUsersDTO.Add(Convert(item));
            }
            return listUsersDTO;
        }

        //GetByCode
        public static UsersDTO GetByCode(UsersDTO existUser)   //user signIn
        {

            return UsersDAL.GetById(existUser.IdUser);
        }
        //Delete
        public static bool Delete(string IdUser)
        {
            return UsersDAL.Delete(IdUser);
        }

        //Update
        public static bool Update(UsersDTO usersDTO)
        {
            Users user = new Users();
            user = Convert(usersDTO);
            return UsersDAL.Update(user);

        }

        public static Users Convert(UsersDTO usersDTO)
        {
            Users user = new Users();
            user.IdUser = usersDTO.IdUser;
            user.NameUser = usersDTO.NameUser;
            user.AgeUser = usersDTO.AgeUser;
            user.GenderCode = usersDTO.Gender.CodeGender;
            user.StatusCode = usersDTO.Status.CodeStatus;
            return user;


        }
        public static UsersDTO Convert(Users user)
        {
            if (user == null)
                return null;
            UsersDTO usersDTO = new UsersDTO();
            usersDTO.IdUser = user.IdUser;
            usersDTO.NameUser = user.NameUser;
            usersDTO.AgeUser = user.AgeUser;
            //usersDTO.Gender = GendersBL.Convert(user.GenderCode);
            //usersDTO.Status = StatusUserBL.Convert(user.StatusUser);
            return usersDTO;
        }
    }
}
