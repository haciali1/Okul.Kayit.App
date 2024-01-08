using OkulApp.BLL;
using OkulApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Okul.App.hafta9
{
	public partial class FrmBul : Form
	{
		FrmOgrKayit frm;

		public FrmBul(FrmOgrKayit frm)
		{
			InitializeComponent();
			this.frm = frm;
		}


		private void btnAra_Click(object sender, EventArgs e)
		{
			OgrenciBL  obl = new OgrenciBL();
			Ogrenci ogr = obl.OgrenciBul(txtNumara.Text.Trim());
			if (ogr!=null)
			{
				frm.txtAd.Text = ogr.Ad;
				frm.txtSoyad.Text = ogr.Soyad;
				frm.txtNumara.Text = ogr.Numara;
				frm.OgrenciId = ogr.OgrenciId;

				frm.deger = true;
				this.Close();
			}
			else 
			{
				MessageBox.Show("Öğrenci Bulunamadı");
				frm.deger=false;
			}
			frm.KontrolEt();
			
		} 
		


	}
}
