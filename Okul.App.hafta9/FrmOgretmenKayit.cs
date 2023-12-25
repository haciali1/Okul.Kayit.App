using OkulApp.BLL;
using OkulApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Okul.App.hafta9
{
	public partial class FrmOgretmenKayit : Form
	{
		public FrmOgretmenKayit()
		{
			InitializeComponent();
		}

		private void btnKaydet_Click(object sender, EventArgs e)
		{
			try
			{
				var obl = new OgretmenBL();
				bool a = obl.OgretmenKaydet(new Ogretmen { Ad = txtOAd.Text.Trim(), Soyad = txtOSoyad.Text.Trim(), TCNO = txtOTC.Text.Trim() });
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
			catch (Exception ex)
			{
				MessageBox.Show("Bilinmeyen hata " + ex.Message);
			}
		}
	}
}
