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
	public partial class OgrKayitlar : Form
	{
		
			private readonly SqlConnection connection; 
			public OgrKayitlar()
			{
				InitializeComponent();
				connection = new SqlConnection("Data Source=DESKTOP-UM8PRBC\\MSSQLSERVER01;Initial Catalog=OkulDb;Integrated Security=true;"); 
				ShowData(); 
			}

			private void ShowData()
			{
				try
				{
					connection.Open(); 

					
					string query = "SELECT * FROM Ogretmenler";
					SqlDataAdapter a = new SqlDataAdapter(query, connection);
					DataTable dataTable = new DataTable();
					a.Fill(dataTable);

					dataGridView1.DataSource = dataTable; 

					connection.Close(); 
				}
				catch (Exception ex)
				{
					MessageBox.Show("Veri alınırken bir hata oluştu: " + ex.Message);
				}
				finally
				{
					if (connection.State == ConnectionState.Open)
					{
						connection.Close(); 
					}
				}
			}
		}
	}

