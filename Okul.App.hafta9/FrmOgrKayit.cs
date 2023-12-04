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
	public partial class FrmOgrKayit : Form
	{
		public FrmOgrKayit()
		{
			InitializeComponent();
		}

		private void btnKaydet_Click(object sender, EventArgs e)
		{
			SqlConnection cn = null;
			try
			{
				 cn = new SqlConnection(@"Data Source =DESKTOP-UM8PRBC\MSSQLSERVER01; Initial Catalog=OkulDb;Integrated Security=true");

				SqlCommand cmd = new SqlCommand($"Insert into Ogrenciler values ('{txtAd.Text.Trim()}','{txtSoyad.Text.Trim()}','{txtNumara.Text.Trim()}')", cn);
				cn.Open();
				int sonuc = cmd.ExecuteNonQuery();
				cn.Close();
				MessageBox.Show(sonuc > 0 ? "Ekleme başarılı " : "Ekleme Başarısız");
			}

			catch(SqlException ex ) 
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
				MessageBox.Show("Bir hata oluştu");
			}
			finally
			{
				if (cn != null&&cn.State!=ConnectionState.Closed)
				{
					cn.Close();
				}
			}
		}
	}
}
