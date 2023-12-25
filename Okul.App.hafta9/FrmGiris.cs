using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Okul.App.hafta9
{
	public partial class FrmGiris : Form
	{
		public FrmGiris()
		{
			InitializeComponent();
		}

		private void btnOgr_Click(object sender, EventArgs e)
		{
			FrmOgrKayit frm1 = new FrmOgrKayit();
			frm1.Show();
	        this.Hide();
		}

		private void btnOgretmen_Click(object sender, EventArgs e)
		{
			FrmOgretmenKayit frm2 = new FrmOgretmenKayit();
			frm2.Show();	
			this.Hide();
		}
	}
}
