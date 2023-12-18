using Okul.App.DAL;
using OkulApp.Model;
using System;
using System.Data;
using System.Data.SqlClient;


namespace OkulApp.BLL
{
	public class OgrenciBL
	{
		public bool ogrencikaydet(Ogrenci ogr)
		{
			var hlp = new Helper();
			var p = new SqlParameter[]
			{
				new SqlParameter("Ad",ogr.Ad),
				new SqlParameter("Soyad",ogr.Soyad),
				new SqlParameter("Numara",ogr.Numara)
			};
			return hlp.ExcuteNonQuery("Insert Into tblOgrenciler values(@Ad,@Soyad,@Numara)",p)>0;
		}
	}
}
