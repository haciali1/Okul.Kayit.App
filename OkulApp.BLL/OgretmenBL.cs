using Okul.App.DAL;
using OkulApp.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace OkulApp.BLL
{
	public class OgretmenBL
	{
		public bool OgretmenKaydet(Ogretmen ogrt)
		{
			var hlp = new Helper();
			var p = new SqlParameter[]
			{
				new SqlParameter("TC",ogrt.TCNO),
				new SqlParameter("Ad",ogrt.Ad),
				new SqlParameter("Soyad",ogrt.Soyad)
			};
			return hlp.ExcuteNonQuery("Insert Into Ogretmenler values(@TC,@Ad,@Soyad)", p) > 0;

		}

	}
}
