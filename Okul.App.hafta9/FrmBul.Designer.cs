namespace Okul.App.hafta9
{
	partial class FrmBul
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
			this.btnAra = new System.Windows.Forms.Button();
			this.txtNumara = new System.Windows.Forms.TextBox();
			this.lblNumara = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.lblNumara);
			this.groupBox1.Controls.Add(this.txtNumara);
			this.groupBox1.Controls.Add(this.btnAra);
			this.groupBox1.Location = new System.Drawing.Point(116, 59);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(462, 238);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Öğrenci Bulma Ekranı";
			// 
			// btnAra
			// 
			this.btnAra.Location = new System.Drawing.Point(155, 165);
			this.btnAra.Name = "btnAra";
			this.btnAra.Size = new System.Drawing.Size(122, 33);
			this.btnAra.TabIndex = 0;
			this.btnAra.Text = "Ara";
			this.btnAra.UseVisualStyleBackColor = true;
			this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
			// 
			// txtNumara
			// 
			this.txtNumara.Location = new System.Drawing.Point(143, 127);
			this.txtNumara.Name = "txtNumara";
			this.txtNumara.Size = new System.Drawing.Size(153, 22);
			this.txtNumara.TabIndex = 1;
			// 
			// lblNumara
			// 
			this.lblNumara.AutoSize = true;
			this.lblNumara.Location = new System.Drawing.Point(140, 90);
			this.lblNumara.Name = "lblNumara";
			this.lblNumara.Size = new System.Drawing.Size(149, 16);
			this.lblNumara.TabIndex = 2;
			this.lblNumara.Text = "Öğrenci numarası giriniz";
			// 
			// FrmBul
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.groupBox1);
			this.Name = "FrmBul";
			this.Text = "FrmBul";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label lblNumara;
		private System.Windows.Forms.TextBox txtNumara;
		private System.Windows.Forms.Button btnAra;
	}
}