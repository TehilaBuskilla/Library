using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataObject;

namespace BL
{
    
   public class AlgoritemBL
    {
        public static List<ReadingBooksDTO> GetAll()
        {
            List<ReadingBooksDTO> listBook = ReadingBooksBL.GetAll();
            //נשלוף את כל הספרים שאותו משתמש קרא ונכניס למילון ואז נבצע אחוזים ונציע את הספרים עם אחוזי התאמה הגבוהים היותר
            //לא להציג ספר שהוא כבר קרא
            return listBook;
        }
        public static void Add(Dictionary<string, Dictionary<int, int>> dictionaryAlgo, UsersDTO userIn)
        {
            foreach (var item in dictionaryAlgo)
            {
                string a = item.Key + "BL";
                List<AuthorsForUsersDTO> listAuthor = AuthorsForUsersBL.GetById(userIn.IdUser);

                foreach (var valueItem in item.Value)
                {
                    AuthorsForUsersDTO b = listAuthor.FirstOrDefault(x => x.AuthorCode == valueItem.Key);

                    if (listAuthor.FirstOrDefault(x => x.AuthorCode == valueItem.Key) != null)
                    {
                       
                        //AuthorsForUsersBL.Update(b.Count+valueItem.Value);
                    }
                    else
                        AuthorsForUsersBL.Add(b);
                }
            }
        }
    }
}
