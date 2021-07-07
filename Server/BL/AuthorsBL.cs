using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataObject;
using DAL;

namespace BL
{
    public class AuthorsBL
    {
        //Add
        public static int Add(AuthorsDTO authorsDTO)
        {
            return AuthorsDAL.Add(Convert(authorsDTO));
        }

        //Get
        public static List<AuthorsDTO> GetAll()
        {
            List<AuthorsDTO> listAuthorsDTO = new List<AuthorsDTO>();
            List<Authors> listAuthors = AuthorsDAL.GetAll();


            foreach (var item in listAuthors)
            {
                listAuthorsDTO.Add(Convert(item));
            }
            return listAuthorsDTO;
        }

        //Delete
        public static bool Delete(int CodeAuthor)
        {
            return AuthorsDAL.Delete(CodeAuthor);
        }

        //Update
        public static bool Update(AuthorsDTO authorsDTO)
        {
            Authors author = new Authors();
            author = Convert(authorsDTO);
            return AuthorsDAL.Update(author);

        }

        public static Authors Convert(AuthorsDTO authorsDTO)
        {
            Authors author = new Authors();
            author.CodeAuthor = authorsDTO.CodeAuthor;
            author.NameAuthor = authorsDTO.NameAuthor;

            return author;


        }
        public static AuthorsDTO Convert(Authors author)
        {
            AuthorsDTO authorsDTO = new AuthorsDTO();
            authorsDTO.CodeAuthor = author.CodeAuthor;
            authorsDTO.NameAuthor = author.NameAuthor;

            return authorsDTO;
        }
    }
}
