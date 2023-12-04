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
			this.gboxÖğrenci.Location = new System.Drawing.Point(83, 37);
			this.gboxÖğrenci.Name = "gboxÖğrenci";
			this.gboxÖğrenci.Size = new System.Drawing.Size(455, 263);
			this.gboxÖğrenci.TabIndex = 0;
			this.gboxÖğrenci.TabStop = false;
			this.gboxÖğrenci.Text = "Öğrenci Bilgileri";
			// 
			// lblAd
			// 
			this.lblAd.AutoSize = true;
			this.lblAd.Location = new System.Drawing.Point(65, 55);
			this.lblAd.Name = "lblAd";
			this.lblAd.Size = new System.Drawing.Size(24, 16);
			this.lblAd.TabIndex = 1;
			this.lblAd.Text = "Ad";
			// 
			// txtNumara
			// 
			this.txtNumara.Location = new System.Drawing.Point(189, 123);
			this.txtNumara.MaxLength = 15;
			this.txtNumara.Name = "txtNumara";
			this.txtNumara.Size = new System.Drawing.Size(100, 22);
			this.txtNumara.TabIndex = 5;
			// 
			// txtSoyad
			// 
			this.txtSoyad.Location = new System.Drawing.Point(189, 86);
			this.txtSoyad.MaxLength = 30;
			this.txtSoyad.Name = "txtSoyad";
			this.txtSoyad.Size = new System.Drawing.Size(100, 22);
			this.txtSoyad.TabIndex = 6;
			// 
			// lblNumara
			// 
			this.lblNumara.AutoSize = true;
			this.lblNumara.Location = new System.Drawing.Point(65, 123);
			this.lblNumara.Name = "lblNumara";
			this.lblNumara.Size = new System.Drawing.Size(55, 16);
			this.lblNumara.TabIndex = 3;
			this.lblNumara.Text = "Numara";
			// 
			// lblSoyad
			// 
			this.lblSoyad.AutoSize = true;
			this.lblSoyad.Location = new System.Drawing.Point(65, 86);
			this.lblSoyad.Name = "lblSoyad";
			this.lblSoyad.Size = new System.Drawing.Size(47, 16);
			this.lblSoyad.TabIndex = 2;
			this.lblSoyad.Text = "Soyad";
			// 
			// txtAd
			// 
			this.txtAd.Location = new System.Drawing.Point(189, 52);
			this.txtAd.MaxLength = 20;
			this.txtAd.Name = "txtAd";
			this.txtAd.Size = new System.Drawing.Size(100, 22);
			this.txtAd.TabIndex = 4;
			// 
			// btnKaydet
			// 
			this.btnKaydet.Location = new System.Drawing.Point(375, 378);
			this.btnKaydet.Name = "btnKaydet";
			this.btnKaydet.Size = new System.Drawing.Size(89, 38);
			this.btnKaydet.TabIndex = 7;
			this.btnKaydet.Text = "Kaydet";
			this.btnKaydet.UseVisualStyleBackColor = true;
			this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
			// 
			// FrmOgrKayit
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnKaydet);
			this.Controls.Add(this.gboxÖğrenci);
			this.Name = "FrmOgrKayit";
			this.Text = "Öğrenci kayıt işlemleri";
			this.gboxÖğrenci.ResumeLayout(false);
			this.gboxÖğrenci.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox gboxÖğrenci;
		private System.Windows.Forms.Label lblAd;
		private System.Windows.Forms.TextBox txtNumara;
		private System.Windows.Forms.TextBox txtSoyad;
		private System.Windows.Forms.Label lblNumara;
		private System.Windows.Forms.Label lblSoyad;
		private System.Windows.Forms.TextBox txtAd;
		private System.Windows.Forms.Button btnKaydet;
	}
}

