using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataObject;
using DAL;

namespace BL
{
    public class GendersBL
    {
        //הוספה
        public static int Add(GendersDTO gendersDTO)
        {
            return GendersDAL.Add(Convert(gendersDTO));
        }

        //שליפה
        public static List<GendersDTO> GetAll()
        {
            List<GendersDTO> listGendersDTO = new List<GendersDTO>();
            List<Genders> listGenders = GendersDAL.GetAll();


            foreach (var item in listGenders)
            {
                listGendersDTO.Add(Convert(item));
            }
            return listGendersDTO;
        }

        //מחיקה
        public static bool Delete(int CodeGender)
        {
            return GendersDAL.Delete(CodeGender);
        }

        //עדכון
        public static bool Update(GendersDTO gendersDTO)
        {
            Genders gender = new Genders();
            gender = Convert(gendersDTO);
            return GendersDAL.Update(gender);

        }

        public static Genders Convert(GendersDTO gendersDTO)
        {
            Genders gender = new Genders();
            gender.CodeGender = gendersDTO.CodeGender;
            gender.KindGender = gendersDTO.KindGender;

            return gender;


        }
        public static GendersDTO Convert(Genders gender)
        {
            GendersDTO gendersDTO = new GendersDTO();
            gendersDTO.CodeGender = gender.CodeGender;
            gendersDTO.KindGender = gender.KindGender;

            return gendersDTO;
        }
    }
}
