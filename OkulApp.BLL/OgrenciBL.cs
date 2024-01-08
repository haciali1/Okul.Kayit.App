using Okul.App.DAL;
using OkulApp.Model;
using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;


namespace OkulApp.BLL
{
	public class OgrenciBL
	{
		public bool ogrencikaydet(Ogrenci ogr)
		{
			try
			{
				var hlp = new Helper();
				var p = new SqlParameter[]
				{
			new SqlParameter("Ad",ogr.Ad),
			new SqlParameter("Soyad",ogr.Soyad),
			new SqlParameter("Numara",ogr.Numara)
				};
				return hlp.ExcuteNonQuery("Insert Into Ogrenciler values(@Ad,@Soyad,@Numara)", p) > 0;
			}
			catch (Exception ex)
			{
				// Hata durumunu ele alabilir veya istediğiniz gibi işleyebiliriz.
				throw; // Yakalanan hatayı tekrar fırlatmak için kullanıyoruz.
			}
		}
		public Ogrenci OgrenciBul (string numara)
		{
			  
		
			try
			{
				var hlp = new Helper();
				SqlParameter[] p = { new SqlParameter("@Numara", numara) };
				var dr = hlp.ExecuteReader("Select OgrenciId,OgrenciAdi,OgrenciSoyad,OgrenciNo from Ogrenciler where OgrenciNo =@Numara", p);
				Ogrenci ogr = null;
				if (dr.Read())
				{
					ogr = new Ogrenci();
					ogr.Ad = (string)dr["OgrenciAdi"];
					ogr.Soyad = (string)dr["OgrenciSoyad"];
					ogr.Numara = (string)dr["OgrenciNo"];
					ogr.OgrenciId = Convert.ToInt32(dr["OgrenciId"]);

				}
				dr.Close();
				return ogr;
			}
			catch (Exception)
			{

				throw; //Metodun çağırıldığı yere fırlatıyor hatayı
			}
		}
		public bool OgrenciSil(int Id)
		{
			SqlParameter[] p = { new SqlParameter("@Id", Id) };
			Helper hlp=new Helper();
			return hlp.ExcuteNonQuery("Delete from Ogrenciler where OgrenciId=@Id", p) > 0;
		}
		public bool OgrenciGuncelle(Ogrenci ogr)
		{
			try
			{
				var hlp = new Helper();
				SqlParameter[] p = { new SqlParameter("@Ad",ogr.Ad),
								 new SqlParameter("@Soyad",ogr.Soyad),
								 new SqlParameter("@Numara",ogr.Numara),
								 new SqlParameter("@Id",ogr.OgrenciId)};
				return hlp.ExcuteNonQuery("Update Ogrenciler set OgrenciAdi=@Ad,OgrenciSoyad=@Soyad,OgrenciNo=@Numara where OgrenciId=@Id", p) > 0;

			}
			catch (Exception)
			{

				throw;
			}
			
		}
	}
}
