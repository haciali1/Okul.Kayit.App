using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Okul.App.hafta9
{
	internal static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new FrmGiris());
		}
	}
}
//Öğrenci bulunma durumuna göre Sil ve Güncelle Butonları Aktifliği YAPILDI
//Textbox'ların text'lerinin temizlenmesi YAPILDI
//Öğrenci bulunduğunda bul formunun kapanması 
//Try-Catch'ler Katmanlar arası exception yönetimi
//Dispose Pattern - IDisposeble Interface
//Singleton Design Pattern