namespace Okul.App.hafta9
{
	partial class FrmGiris
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
			this.lblGiris = new System.Windows.Forms.Label();
			this.btnOgr = new System.Windows.Forms.Button();
			this.btnOgretmen = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblGiris
			// 
			this.lblGiris.AutoSize = true;
			this.lblGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblGiris.Location = new System.Drawing.Point(194, 93);
			this.lblGiris.Name = "lblGiris";
			this.lblGiris.Size = new System.Drawing.Size(442, 32);
			this.lblGiris.TabIndex = 0;
			this.lblGiris.Text = "Hangi işlemi yapmak istersiniz?";
			// 
			// btnOgr
			// 
			this.btnOgr.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnOgr.Location = new System.Drawing.Point(132, 287);
			this.btnOgr.Name = "btnOgr";
			this.btnOgr.Size = new System.Drawing.Size(199, 38);
			this.btnOgr.TabIndex = 1;
			this.btnOgr.Text = "Yeni öğrenci kayıt";
			this.btnOgr.UseVisualStyleBackColor = true;
			this.btnOgr.Click += new System.EventHandler(this.btnOgr_Click);
			// 
			// btnOgretmen
			// 
			this.btnOgretmen.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnOgretmen.Location = new System.Drawing.Point(463, 287);
			this.btnOgretmen.Name = "btnOgretmen";
			this.btnOgretmen.Size = new System.Drawing.Size(199, 38);
			this.btnOgretmen.TabIndex = 2;
			this.btnOgretmen.Text = "Yeni öğretmen kayıt";
			this.btnOgretmen.UseVisualStyleBackColor = true;
			this.btnOgretmen.Click += new System.EventHandler(this.btnOgretmen_Click);
			// 
			// FrmGiris
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnOgretmen);
			this.Controls.Add(this.btnOgr);
			this.Controls.Add(this.lblGiris);
			this.Name = "FrmGiris";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblGiris;
		private System.Windows.Forms.Button btnOgr;
		private System.Windows.Forms.Button btnOgretmen;
	}
}