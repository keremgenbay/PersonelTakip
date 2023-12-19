using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAO
{
    public class PersonelDAO : PersonelDataContext
    {
        public static void PersonelEkle(PERSONEL pr)
        {
			try
			{
				db.PERSONELs.InsertOnSubmit(pr);
				db.SubmitChanges();
			}
			catch (Exception ex)
			{

				throw ex;
			}
        }

        public static List<PERSONEL> PersonelGetir(int v)
        {
            return db.PERSONELs.Where(x => x.UserNo == v).ToList();
        }
    }
}
