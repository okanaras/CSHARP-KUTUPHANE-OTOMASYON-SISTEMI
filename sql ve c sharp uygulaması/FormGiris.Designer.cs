namespace sql_ve_c_sharp_uygulaması
{
    partial class FormGiris
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.button1 = new System.Windows.Forms.Button();
			this.textBoxSifre = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.textBoxKullaniciAdi = new System.Windows.Forms.TextBox();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(285, 224);
			this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(82, 22);
			this.button1.TabIndex = 0;
			this.button1.Text = "Giriş";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// textBoxSifre
			// 
			this.textBoxSifre.Location = new System.Drawing.Point(267, 188);
			this.textBoxSifre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textBoxSifre.Name = "textBoxSifre";
			this.textBoxSifre.Size = new System.Drawing.Size(123, 23);
			this.textBoxSifre.TabIndex = 2;
			this.textBoxSifre.UseSystemPasswordChar = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(167, 148);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(79, 15);
			this.label1.TabIndex = 3;
			this.label1.Text = "Kullanıcı Adı: ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(167, 193);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(36, 15);
			this.label2.TabIndex = 4;
			this.label2.Text = "Şifre: ";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.panel1.Controls.Add(this.label3);
			this.panel1.Location = new System.Drawing.Point(-2, -2);
			this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(609, 98);
			this.panel1.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
			this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label3.Location = new System.Drawing.Point(212, 40);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(173, 25);
			this.label3.TabIndex = 0;
			this.label3.Text = "SQL SERVER DERSİ";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.White;
			this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
			this.label4.Location = new System.Drawing.Point(267, 284);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(0, 19);
			this.label4.TabIndex = 6;
			// 
			// textBoxKullaniciAdi
			// 
			this.textBoxKullaniciAdi.Location = new System.Drawing.Point(267, 145);
			this.textBoxKullaniciAdi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textBoxKullaniciAdi.Name = "textBoxKullaniciAdi";
			this.textBoxKullaniciAdi.Size = new System.Drawing.Size(123, 23);
			this.textBoxKullaniciAdi.TabIndex = 7;
			this.textBoxKullaniciAdi.UseSystemPasswordChar = true;
			// 
			// FormGiris
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.ClientSize = new System.Drawing.Size(598, 342);
			this.Controls.Add(this.textBoxKullaniciAdi);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBoxSifre);
			this.Controls.Add(this.button1);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "FormGiris";
			this.Text = "Form1";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private Button button1;
        private TextBox textBoxSifre;
        private Label label1;
        private Label label2;
        private Panel panel1;
        private Label label3;
        private Label label4;
		private TextBox textBoxKullaniciAdi;
	}
}