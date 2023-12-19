using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DAO;

namespace BLL
{
    public class PozisyonBLL
    {
        public static void PozisyonEkle(POZISYON pzs)
        {
            PozisyonDAO.PozisyonEkle(pzs);
        }
    }
}
