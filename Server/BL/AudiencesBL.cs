﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataObject;
using DAL;


namespace BL
{
    public class AudiencesBL
    {

        //Add
        public static int Add(AudiencesDTO audiencesDTO)
        {
            return AudiencesDAL.Add(Convert(audiencesDTO));
        }

        //Get
        public static List<AudiencesDTO> GetAll()
        {
            List<AudiencesDTO> listAudiencesDTO = new List<AudiencesDTO>();
            List<Audiences> listAudiences = AudiencesDAL.GetAll();


            foreach (var item in listAudiences)
            {
                listAudiencesDTO.Add(Convert(item));
            }
            return listAudiencesDTO;
        }

        //Delete
        public static bool Delete(int CodeAudience)
        {
            return AudiencesDAL.Delete(CodeAudience);
        }

        //Update
        public static bool Update(AudiencesDTO audiencesDTO)
        {
            Audiences audience = new Audiences();
            audience = Convert(audiencesDTO);
            return AudiencesDAL.Update(audience);

        }

        public static Audiences Convert(AudiencesDTO audiencesDTO)
        {
            Audiences audience = new Audiences();
            audience.CodeAudience = audiencesDTO.CodeAudience;
            audience.KindAudience = audiencesDTO.KindAudience;
            audience.Age = audiencesDTO.Age;
            return audience;


        }
        public static AudiencesDTO Convert(Audiences audience)
        {
            AudiencesDTO audiencesDTO = new AudiencesDTO();
            audiencesDTO.CodeAudience = audience.CodeAudience;
            audiencesDTO.KindAudience = audience.KindAudience;
            audiencesDTO.Age = audience.Age;
            return audiencesDTO;
        }
    }
}
