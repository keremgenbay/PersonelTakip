﻿using DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.DAO;

namespace BLL
{
    public class PersonelBLL
    {
        public static PersonelDTO GetAll()
        {
            PersonelDTO dto = new PersonelDTO();
            dto.Departmanlar = DepartmanDAO.DepartmanGetir();
            dto.Pozisyonlar = PozisyonDAO.PozisyonGetir();
            
            
            return dto;
        }

        public static bool isUnique(int v)
        {
            List<PERSONEL> list = PersonelDAO.PersonelGetir(v);
            if (list.Count > 0)
                return true;
            else
                return false;
        }

        public static void PersonelEkle(PERSONEL pr)
        {
            PersonelDAO.PersonelEkle(pr);
        }
    }
}
