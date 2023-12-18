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
		public FrmOgrKayit()
		{
			InitializeComponent();
		}
		
		
		private void btnKaydet_Click(object sender, EventArgs e)
		{
			try
			{
				var obl = new OgrenciBL();
				bool a = obl.ogrencikaydet(new Ogrenci { Ad = txtAd.Text, Soyad = txtSoyad.Text, Numara = txtNumara.Text });
				MessageBox.Show(a ? "Ekleme başarılı " : "Ekleme Başarısız");

			}
			catch (SqlException ex)
			{

				switch (ex.Number)
				{
					case 2627:
						MessageBox.Show("Bu numara daha önce girilmiştir");
						break;
					default:
						MessageBox.Show("Veritabanı hatası");
						break;
				}
			}
			catch (Exception)
			{
				MessageBox.Show("Bilinmeyen hata");
			}
		}
	}
}
