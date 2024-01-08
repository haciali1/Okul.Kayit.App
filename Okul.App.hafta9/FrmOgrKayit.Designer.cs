namespace Okul.App.hafta9
{
	partial class FrmOgrKayit
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.gboxÖğrenci = new System.Windows.Forms.GroupBox();
			this.lblAd = new System.Windows.Forms.Label();
			this.txtNumara = new System.Windows.Forms.TextBox();
			this.txtSoyad = new System.Windows.Forms.TextBox();
			this.lblNumara = new System.Windows.Forms.Label();
			this.lblSoyad = new System.Windows.Forms.Label();
			this.txtAd = new System.Windows.Forms.TextBox();
			this.btnKaydet = new System.Windows.Forms.Button();
			this.btnbul = new System.Windows.Forms.Button();
			this.btnSil = new System.Windows.Forms.Button();
			this.btnGuncelle = new System.Windows.Forms.Button();
			this.gboxÖğrenci.SuspendLayout();
			this.SuspendLayout();
			// 
			// gboxÖğrenci
			// 
			this.gboxÖğrenci.Controls.Add(this.lblAd);
			this.gboxÖğrenci.Controls.Add(this.txtNumara);
			this.gboxÖğrenci.Controls.Add(this.txtSoyad);
			this.gboxÖğrenci.Controls.Add(this.lblNumara);
			this.gboxÖğrenci.Controls.Add(this.lblSoyad);
			this.gboxÖğrenci.Controls.Add(this.txtAd);
			this.gboxÖğrenci.Location = new System.Drawing.Point(62, 30);
			this.gboxÖğrenci.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.gboxÖğrenci.Name = "gboxÖğrenci";
			this.gboxÖğrenci.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.gboxÖğrenci.Size = new System.Drawing.Size(388, 248);
			this.gboxÖğrenci.TabIndex = 0;
			this.gboxÖğrenci.TabStop = false;
			this.gboxÖğrenci.Text = "Öğrenci Bilgileri";
			// 
			// lblAd
			// 
			this.lblAd.AutoSize = true;
			this.lblAd.Location = new System.Drawing.Point(49, 45);
			this.lblAd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblAd.Name = "lblAd";
			this.lblAd.Size = new System.Drawing.Size(20, 13);
			this.lblAd.TabIndex = 1;
			this.lblAd.Text = "Ad";
			// 
			// txtNumara
			// 
			this.txtNumara.Location = new System.Drawing.Point(142, 100);
			this.txtNumara.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtNumara.MaxLength = 15;
			this.txtNumara.Name = "txtNumara";
			this.txtNumara.Size = new System.Drawing.Size(88, 20);
			this.txtNumara.TabIndex = 5;
			// 
			// txtSoyad
			// 
			this.txtSoyad.Location = new System.Drawing.Point(142, 70);
			this.txtSoyad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtSoyad.MaxLength = 30;
			this.txtSoyad.Name = "txtSoyad";
			this.txtSoyad.Size = new System.Drawing.Size(88, 20);
			this.txtSoyad.TabIndex = 6;
			// 
			// lblNumara
			// 
			this.lblNumara.AutoSize = true;
			this.lblNumara.Location = new System.Drawing.Point(49, 100);
			this.lblNumara.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblNumara.Name = "lblNumara";
			this.lblNumara.Size = new System.Drawing.Size(44, 13);
			this.lblNumara.TabIndex = 3;
			this.lblNumara.Text = "Numara";
			// 
			// lblSoyad
			// 
			this.lblSoyad.AutoSize = true;
			this.lblSoyad.Location = new System.Drawing.Point(49, 70);
			this.lblSoyad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblSoyad.Name = "lblSoyad";
			this.lblSoyad.Size = new System.Drawing.Size(37, 13);
			this.lblSoyad.TabIndex = 2;
			this.lblSoyad.Text = "Soyad";
			// 
			// txtAd
			// 
			this.txtAd.Location = new System.Drawing.Point(142, 42);
			this.txtAd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtAd.MaxLength = 20;
			this.txtAd.Name = "txtAd";
			this.txtAd.Size = new System.Drawing.Size(88, 20);
			this.txtAd.TabIndex = 4;
			// 
			// btnKaydet
			// 
			this.btnKaydet.Location = new System.Drawing.Point(217, 307);
			this.btnKaydet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnKaydet.Name = "btnKaydet";
			this.btnKaydet.Size = new System.Drawing.Size(67, 31);
			this.btnKaydet.TabIndex = 7;
			this.btnKaydet.Text = "Kaydet";
			this.btnKaydet.UseVisualStyleBackColor = true;
			this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
			// 
			// btnbul
			// 
			this.btnbul.Location = new System.Drawing.Point(495, 66);
			this.btnbul.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnbul.Name = "btnbul";
			this.btnbul.Size = new System.Drawing.Size(82, 28);
			this.btnbul.TabIndex = 8;
			this.btnbul.Text = "BUL";
			this.btnbul.UseVisualStyleBackColor = true;
			this.btnbul.Click += new System.EventHandler(this.btnbul_Click);
			// 
			// btnSil
			// 
			this.btnSil.Enabled = false;
			this.btnSil.Location = new System.Drawing.Point(495, 118);
			this.btnSil.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnSil.Name = "btnSil";
			this.btnSil.Size = new System.Drawing.Size(82, 30);
			this.btnSil.TabIndex = 9;
			this.btnSil.Text = "SİL";
			this.btnSil.UseVisualStyleBackColor = true;
			this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
			// 
			// btnGuncelle
			// 
			this.btnGuncelle.Enabled = false;
			this.btnGuncelle.Location = new System.Drawing.Point(495, 167);
			this.btnGuncelle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnGuncelle.Name = "btnGuncelle";
			this.btnGuncelle.Size = new System.Drawing.Size(82, 28);
			this.btnGuncelle.TabIndex = 10;
			this.btnGuncelle.Text = "Güncelle";
			this.btnGuncelle.UseVisualStyleBackColor = true;
			this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
			// 
			// FrmOgrKayit
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(600, 366);
			this.Controls.Add(this.btnGuncelle);
			this.Controls.Add(this.btnSil);
			this.Controls.Add(this.btnbul);
			this.Controls.Add(this.btnKaydet);
			this.Controls.Add(this.gboxÖğrenci);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "FrmOgrKayit";
			this.Text = "Öğrenci kayıt işlemleri";
			this.gboxÖğrenci.ResumeLayout(false);
			this.gboxÖğrenci.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox gboxÖğrenci;
		private System.Windows.Forms.Label lblAd;
		private System.Windows.Forms.Label lblNumara;
		private System.Windows.Forms.Label lblSoyad;
		private System.Windows.Forms.Button btnKaydet;
		private System.Windows.Forms.Button btnbul;
		private System.Windows.Forms.Button btnSil;
		public System.Windows.Forms.TextBox txtNumara;
		public System.Windows.Forms.TextBox txtSoyad;
		public System.Windows.Forms.TextBox txtAd;
		private System.Windows.Forms.Button btnGuncelle;
	}
}

