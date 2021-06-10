using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataObject;
using DAL;

namespace BL
{
    public class AuthorsForUsersBL
    {
        //הוספה
        public static int Add(AuthorsForUsersDTO authorsForUsersDTO)
        {
            return AuthorsForUsersDAL.Add(Convert(authorsForUsersDTO));
        }

        //שליפה
        public static List<AuthorsForUsersDTO> GetAll()
        {
            List<AuthorsForUsersDTO> listAuthorsForUsersDTO = new List<AuthorsForUsersDTO>();
            List<AuthorsForUsers> listAuthorsForUsers = AuthorsForUsersDAL.GetAll();


            foreach (var item in listAuthorsForUsers)
            {
                listAuthorsForUsersDTO.Add(Convert(item));
            }
            return listAuthorsForUsersDTO;
        }

        //שליפה עי נתון
        //מחזיר את כל המחברים ללקוח
         public static List<AuthorsForUsersDTO> GetById(string id)
        {
            List<AuthorsForUsersDTO> listAuthorsForUsers = AuthorsForUsersBL.GetAll();
            return listAuthorsForUsers.FindAll(x => x.AuthorCode == int.Parse(id));
        }
        //מחיקה
        public static bool Delete(int CodeAuthorsForUsers)
        {
            return AuthorsForUsersDAL.Delete(CodeAuthorsForUsers);
        }

        //עדכון
        public static bool Update(AuthorsForUsersDTO authorsForUsersDTO)
        {
            AuthorsForUsers authorForUser = new AuthorsForUsers();
            authorForUser = Convert(authorsForUsersDTO);
            return AuthorsForUsersDAL.Update(authorForUser);

        }

        public static AuthorsForUsers Convert(AuthorsForUsersDTO authorsForUsersDTO)
        {
            AuthorsForUsers authorForUser = new AuthorsForUsers();
            authorForUser.CodeAuthorsForUsers = authorsForUsersDTO.CodeAuthorsForUsers;
            authorForUser.AuthorCode = authorsForUsersDTO.AuthorCode;
            authorForUser.UserId = authorsForUsersDTO.UserId;

            return authorForUser;


        }
        public static AuthorsForUsersDTO Convert(AuthorsForUsers authorForUser)
        {
            AuthorsForUsersDTO authorsForUsersDTO = new AuthorsForUsersDTO();
            authorsForUsersDTO.CodeAuthorsForUsers = authorForUser.CodeAuthorsForUsers;
            authorsForUsersDTO.AuthorCode = authorForUser.AuthorCode;
            authorsForUsersDTO.UserId = authorForUser.UserId;

            return authorsForUsersDTO;
        }
    }
}
