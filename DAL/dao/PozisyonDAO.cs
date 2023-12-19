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
    }
}
