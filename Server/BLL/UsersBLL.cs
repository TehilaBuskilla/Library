using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataObject;
using DAL;


namespace BLL
{
    public class UsersBLL
    {
        //הוספה
        public static int Add(UsersDTO usersDTO)
        {
            return UsersDAL.Add(Convert(usersDTO));
        }

        //שליפה
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
        
        //התחברות משתמש
        public static UsersDTO GetByCode(UsersDTO existUser)
        {
            List<Users> listUsers = UsersDAL.GetAll();
            return Convert( listUsers.First(x=>x.NameUser==existUser.NameUser && x.IdUser==existUser.IdUser));
        }
        //מחיקה
        public static bool Delete(int IdUser)
        {
            return UsersDAL.Delete(IdUser);
        }

        //עדכון
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
            user.GenderCode = usersDTO.GenderCode;
            user.StatusCode = usersDTO.StatusCode;
            return user;


        }
        public static UsersDTO Convert(Users user)
        {
            UsersDTO usersDTO = new UsersDTO();
            usersDTO.IdUser = user.IdUser;
            usersDTO.NameUser = user.NameUser;
            usersDTO.AgeUser = user.AgeUser;
            usersDTO.GenderCode = user.GenderCode;
            usersDTO.StatusCode = user.StatusCode;
            return usersDTO;
        }
    }
}
