using OkulApp.BLL;
using OkulApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Okul.App.hafta9
{
	public partial class FrmOgrKayit : Form
	{
        public int OgrenciId { get; set; }
        public bool deger { get; set; }


        public FrmOgrKayit()
		{
			InitializeComponent();
			
		}
		
		private void btnKaydet_Click(object sender, EventArgs e)
		{
			try
			{
				var obl = new OgrenciBL();
				bool eklemeBasarili = obl.ogrencikaydet(new Ogrenci { Ad = txtAd.Text, Soyad = txtSoyad.Text, Numara = txtNumara.Text });
				if (eklemeBasarili)
				{
					MessageBox.Show("Ekleme Başarılı.");
					Clear();
				}
				else
				{
					MessageBox.Show("Ekleme Başarısız!!");
					Clear();
				}
				

			}
			catch (SqlException ex)
			{

				switch (ex.Number)
				{
					case 2627:
						MessageBox.Show("Bu numara daha önce girilmiştir");
						break;
					default:
						MessageBox.Show("Veritabanı hatası"+ex.Message);
						break;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Bilinmeyen hataaa "+ex.Message);
			}
		}

		private void btnbul_Click(object sender, EventArgs e)
		{
			var frm=new FrmBul(this);
			frm.Show();
		}
		
		
		private void btnSil_Click(object sender, EventArgs e)
		{
			try
			{
				var obl = new OgrenciBL();
				bool silmeBasarili = obl.OgrenciSil(OgrenciId);

				if (silmeBasarili)
				{
					MessageBox.Show("Silme Başarılı");
					Clear();
				}
				else
				{
					MessageBox.Show("Silme Başarısız!!");
					Clear();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Bir hata oluştu: " + ex.Message);
			}

		}

		private void btnGuncelle_Click(object sender, EventArgs e)
		{
			
			try
			{
				var obl = new OgrenciBL();
				bool guncellemeBasarili = obl.OgrenciGuncelle(new Ogrenci { Ad = txtAd.Text, Soyad = txtSoyad.Text, Numara = txtNumara.Text, OgrenciId = OgrenciId });

				if (guncellemeBasarili)
				{
					MessageBox.Show("Güncelleme Başarılı");
					Clear();
				}
				else
				{
					MessageBox.Show("Güncelleme başarısız!!");
					Clear();
				}
			}
			catch (Exception ex)
			{

				MessageBox.Show("Bir hata oluştu: " + ex.Message); 
			}

		}
		public void KontrolEt()
		{
			try
			{
				if (deger == true)
				{
					btnSil.Enabled = true;
					btnGuncelle.Enabled = true;
				}
				else
				{
					btnSil.Enabled = false;
					btnGuncelle.Enabled = false;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Kontrol sırasında bir hata oluştu: " + ex.Message);
			}
		}

		public void Clear()
		{
			try
			{
				txtAd.Clear();
				txtSoyad.Clear();
				txtNumara.Clear();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Temizleme işlemi sırasında bir hata oluştu: " + ex.Message);
			}
		}


	}
}
