namespace Okul.App.hafta9
{
	partial class FrmOgretmenKayit
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtOSoyad = new System.Windows.Forms.TextBox();
			this.txtOAd = new System.Windows.Forms.TextBox();
			this.txtOTC = new System.Windows.Forms.TextBox();
			this.lblSoyad = new System.Windows.Forms.Label();
			this.lblAd = new System.Windows.Forms.Label();
			this.lblTc = new System.Windows.Forms.Label();
			this.btnKaydet = new System.Windows.Forms.Button();
			this.btnKayit = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtOSoyad);
			this.groupBox1.Controls.Add(this.txtOAd);
			this.groupBox1.Controls.Add(this.txtOTC);
			this.groupBox1.Controls.Add(this.lblSoyad);
			this.groupBox1.Controls.Add(this.lblAd);
			this.groupBox1.Controls.Add(this.lblTc);
			this.groupBox1.Location = new System.Drawing.Point(165, 69);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(457, 232);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Öğretmen Kayıt";
			// 
			// txtOSoyad
			// 
			this.txtOSoyad.Location = new System.Drawing.Point(191, 130);
			this.txtOSoyad.Name = "txtOSoyad";
			this.txtOSoyad.Size = new System.Drawing.Size(175, 22);
			this.txtOSoyad.TabIndex = 5;
			// 
			// txtOAd
			// 
			this.txtOAd.Location = new System.Drawing.Point(191, 75);
			this.txtOAd.Name = "txtOAd";
			this.txtOAd.Size = new System.Drawing.Size(175, 22);
			this.txtOAd.TabIndex = 4;
			// 
			// txtOTC
			// 
			this.txtOTC.Location = new System.Drawing.Point(191, 29);
			this.txtOTC.Name = "txtOTC";
			this.txtOTC.Size = new System.Drawing.Size(175, 22);
			this.txtOTC.TabIndex = 3;
			// 
			// lblSoyad
			// 
			this.lblSoyad.AutoSize = true;
			this.lblSoyad.Location = new System.Drawing.Point(44, 136);
			this.lblSoyad.Name = "lblSoyad";
			this.lblSoyad.Size = new System.Drawing.Size(47, 16);
			this.lblSoyad.TabIndex = 2;
			this.lblSoyad.Text = "Soyad";
			// 
			// lblAd
			// 
			this.lblAd.AutoSize = true;
			this.lblAd.Location = new System.Drawing.Point(44, 81);
			this.lblAd.Name = "lblAd";
			this.lblAd.Size = new System.Drawing.Size(27, 16);
			this.lblAd.TabIndex = 1;
			this.lblAd.Text = "Adı";
			// 
			// lblTc
			// 
			this.lblTc.AutoSize = true;
			this.lblTc.Location = new System.Drawing.Point(44, 32);
			this.lblTc.Name = "lblTc";
			this.lblTc.Size = new System.Drawing.Size(84, 16);
			this.lblTc.TabIndex = 0;
			this.lblTc.Text = "TC Kimlik No";
			// 
			// btnKaydet
			// 
			this.btnKaydet.Location = new System.Drawing.Point(296, 307);
			this.btnKaydet.Name = "btnKaydet";
			this.btnKaydet.Size = new System.Drawing.Size(191, 51);
			this.btnKaydet.TabIndex = 1;
			this.btnKaydet.Text = "Kaydet";
			this.btnKaydet.UseVisualStyleBackColor = true;
			this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
			// 
			// btnKayit
			// 
			this.btnKayit.Location = new System.Drawing.Point(306, 374);
			this.btnKayit.Name = "btnKayit";
			this.btnKayit.Size = new System.Drawing.Size(164, 47);
			this.btnKayit.TabIndex = 2;
			this.btnKayit.Text = "Kayıtları Göster";
			this.btnKayit.UseVisualStyleBackColor = true;
			this.btnKayit.Click += new System.EventHandler(this.btnKayit_Click);
			// 
			// FrmOgretmenKayit
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnKayit);
			this.Controls.Add(this.btnKaydet);
			this.Controls.Add(this.groupBox1);
			this.Name = "FrmOgretmenKayit";
			this.Text = "FrmOgretmenKayit";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtOSoyad;
		private System.Windows.Forms.TextBox txtOAd;
		private System.Windows.Forms.TextBox txtOTC;
		private System.Windows.Forms.Label lblSoyad;
		private System.Windows.Forms.Label lblAd;
		private System.Windows.Forms.Label lblTc;
		private System.Windows.Forms.Button btnKaydet;
		private System.Windows.Forms.Button btnKayit;
	}
}