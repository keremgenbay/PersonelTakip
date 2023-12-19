using DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAO
{
    public class PozisyonDAO : PersonelDataContext
    {
        public static void PozisyonEkle(POZISYON pzs)
        {
			try
			{
				db.POZISYONs.InsertOnSubmit(pzs);
				db.SubmitChanges();
			}
			catch (Exception ex)
			{

				throw ex;
			}
        }

        public static List<PozisyonDTO> PozisyonGetir()
        {
			try
			{
				var list = (from p in db.POZISYONs
							join d in db.DEPARTMANs on p.DepartmanID equals d.ID
							select new
							{
								PozisyonID = p.ID,
								PozisyonAd = p.PozisyonAd,
								DepartmanID = p.DepartmanID,
								DepartmanAd=d.DepartmanAd
							}).OrderBy(x=>x.PozisyonID).ToList();
				List<PozisyonDTO> liste= new List<PozisyonDTO>();
				foreach (var item in list)
				{ 
					PozisyonDTO pzt= new PozisyonDTO();
					pzt.ID = item.PozisyonID;
					pzt.PozisyonAd = item.PozisyonAd;
					pzt.DepartmanAd = item.DepartmanAd;
					pzt.DepartmanID = item.DepartmanID;
					liste.Add(pzt);
				}
				return liste;
			}
			catch (Exception ex)
			{

				throw ex;
			}
        }
    }
}
