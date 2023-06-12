namespace sql_ve_c_sharp_uygulaması
{
    partial class FormKitaplar
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
            this.groupBoxKitapKayitveGuncelleme = new System.Windows.Forms.GroupBox();
            this.buttonKitapEkle = new System.Windows.Forms.Button();
            this.buttonTemizle = new System.Windows.Forms.Button();
            this.buttonSil = new System.Windows.Forms.Button();
            this.buttonTumKitaplariGoster = new System.Windows.Forms.Button();
            this.buttonAra = new System.Windows.Forms.Button();
            this.buttonKitapGuncelle = new System.Windows.Forms.Button();
            this.textBoxYazarAdi = new System.Windows.Forms.TextBox();
            this.textBoxYazarSoyadi = new System.Windows.Forms.TextBox();
            this.textBoxISBN = new System.Windows.Forms.TextBox();
            this.textBoxKitapTurKodu = new System.Windows.Forms.TextBox();
            this.textBoxKitapAdi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxKitapOduncAlma = new System.Windows.Forms.GroupBox();
            this.buttonKitapOdunAl = new System.Windows.Forms.Button();
            this.dateTimePickerKitapOduncTarih = new System.Windows.Forms.DateTimePicker();
            this.textBoxOduncAlan = new System.Windows.Forms.TextBox();
            this.labelKitapOduncAlan = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBoxKitapIade = new System.Windows.Forms.GroupBox();
            this.buttonGecikmeBedeli = new System.Windows.Forms.Button();
            this.buttonKitapIadeEt = new System.Windows.Forms.Button();
            this.labelGecikmeBedeli = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.groupBoxKitapListesi = new System.Windows.Forms.GroupBox();
            this.dataGridViewKitaplar = new System.Windows.Forms.DataGridView();
            this.groupBoxKitapKayitveGuncelleme.SuspendLayout();
            this.groupBoxKitapOduncAlma.SuspendLayout();
            this.groupBoxKitapIade.SuspendLayout();
            this.groupBoxKitapListesi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKitaplar)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxKitapKayitveGuncelleme
            // 
            this.groupBoxKitapKayitveGuncelleme.Controls.Add(this.buttonKitapEkle);
            this.groupBoxKitapKayitveGuncelleme.Controls.Add(this.buttonTemizle);
            this.groupBoxKitapKayitveGuncelleme.Controls.Add(this.buttonSil);
            this.groupBoxKitapKayitveGuncelleme.Controls.Add(this.buttonTumKitaplariGoster);
            this.groupBoxKitapKayitveGuncelleme.Controls.Add(this.buttonAra);
            this.groupBoxKitapKayitveGuncelleme.Controls.Add(this.buttonKitapGuncelle);
            this.groupBoxKitapKayitveGuncelleme.Controls.Add(this.textBoxYazarAdi);
            this.groupBoxKitapKayitveGuncelleme.Controls.Add(this.textBoxYazarSoyadi);
            this.groupBoxKitapKayitveGuncelleme.Controls.Add(this.textBoxISBN);
            this.groupBoxKitapKayitveGuncelleme.Controls.Add(this.textBoxKitapTurKodu);
            this.groupBoxKitapKayitveGuncelleme.Controls.Add(this.textBoxKitapAdi);
            this.groupBoxKitapKayitveGuncelleme.Controls.Add(this.label7);
            this.groupBoxKitapKayitveGuncelleme.Controls.Add(this.labelID);
            this.groupBoxKitapKayitveGuncelleme.Controls.Add(this.label3);
            this.groupBoxKitapKayitveGuncelleme.Controls.Add(this.label4);
            this.groupBoxKitapKayitveGuncelleme.Controls.Add(this.label5);
            this.groupBoxKitapKayitveGuncelleme.Controls.Add(this.label6);
            this.groupBoxKitapKayitveGuncelleme.Controls.Add(this.label1);
            this.groupBoxKitapKayitveGuncelleme.Location = new System.Drawing.Point(10, 9);
            this.groupBoxKitapKayitveGuncelleme.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxKitapKayitveGuncelleme.Name = "groupBoxKitapKayitveGuncelleme";
            this.groupBoxKitapKayitveGuncelleme.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxKitapKayitveGuncelleme.Size = new System.Drawing.Size(382, 331);
            this.groupBoxKitapKayitveGuncelleme.TabIndex = 0;
            this.groupBoxKitapKayitveGuncelleme.TabStop = false;
            this.groupBoxKitapKayitveGuncelleme.Text = "Kitap Kayıt ve Güncelleme";
            // 
            // buttonKitapEkle
            // 
            this.buttonKitapEkle.Location = new System.Drawing.Point(30, 242);
            this.buttonKitapEkle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonKitapEkle.Name = "buttonKitapEkle";
            this.buttonKitapEkle.Size = new System.Drawing.Size(101, 32);
            this.buttonKitapEkle.TabIndex = 21;
            this.buttonKitapEkle.Text = "Kitap Ekle";
            this.buttonKitapEkle.UseVisualStyleBackColor = true;
            this.buttonKitapEkle.Click += new System.EventHandler(this.buttonKitapEkle_Click);
            // 
            // buttonTemizle
            // 
            this.buttonTemizle.Location = new System.Drawing.Point(154, 288);
            this.buttonTemizle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonTemizle.Name = "buttonTemizle";
            this.buttonTemizle.Size = new System.Drawing.Size(101, 32);
            this.buttonTemizle.TabIndex = 24;
            this.buttonTemizle.Text = "Aramayı Temizle";
            this.buttonTemizle.UseVisualStyleBackColor = true;
            this.buttonTemizle.Click += new System.EventHandler(this.buttonTemizle_Click);
            // 
            // buttonSil
            // 
            this.buttonSil.Location = new System.Drawing.Point(276, 242);
            this.buttonSil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(101, 32);
            this.buttonSil.TabIndex = 22;
            this.buttonSil.Text = "Kitap Sil";
            this.buttonSil.UseVisualStyleBackColor = true;
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // buttonTumKitaplariGoster
            // 
            this.buttonTumKitaplariGoster.Location = new System.Drawing.Point(276, 288);
            this.buttonTumKitaplariGoster.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonTumKitaplariGoster.Name = "buttonTumKitaplariGoster";
            this.buttonTumKitaplariGoster.Size = new System.Drawing.Size(101, 32);
            this.buttonTumKitaplariGoster.TabIndex = 21;
            this.buttonTumKitaplariGoster.Text = "Tümünü Göster";
            this.buttonTumKitaplariGoster.UseVisualStyleBackColor = true;
            this.buttonTumKitaplariGoster.Click += new System.EventHandler(this.buttonTumKitaplariGoster_Click);
            // 
            // buttonAra
            // 
            this.buttonAra.Location = new System.Drawing.Point(30, 288);
            this.buttonAra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAra.Name = "buttonAra";
            this.buttonAra.Size = new System.Drawing.Size(101, 32);
            this.buttonAra.TabIndex = 20;
            this.buttonAra.Text = "Kitap Sorgula";
            this.buttonAra.UseVisualStyleBackColor = true;
            this.buttonAra.Click += new System.EventHandler(this.buttonAra_Click);
            // 
            // buttonKitapGuncelle
            // 
            this.buttonKitapGuncelle.Location = new System.Drawing.Point(154, 242);
            this.buttonKitapGuncelle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonKitapGuncelle.Name = "buttonKitapGuncelle";
            this.buttonKitapGuncelle.Size = new System.Drawing.Size(101, 32);
            this.buttonKitapGuncelle.TabIndex = 18;
            this.buttonKitapGuncelle.Text = "Kitap Güncelle";
            this.buttonKitapGuncelle.UseVisualStyleBackColor = true;
            this.buttonKitapGuncelle.Click += new System.EventHandler(this.buttonKitapGuncelle_Click);
            // 
            // textBoxYazarAdi
            // 
            this.textBoxYazarAdi.Location = new System.Drawing.Point(156, 94);
            this.textBoxYazarAdi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxYazarAdi.Name = "textBoxYazarAdi";
            this.textBoxYazarAdi.Size = new System.Drawing.Size(110, 23);
            this.textBoxYazarAdi.TabIndex = 13;
            // 
            // textBoxYazarSoyadi
            // 
            this.textBoxYazarSoyadi.Location = new System.Drawing.Point(156, 128);
            this.textBoxYazarSoyadi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxYazarSoyadi.Name = "textBoxYazarSoyadi";
            this.textBoxYazarSoyadi.Size = new System.Drawing.Size(110, 23);
            this.textBoxYazarSoyadi.TabIndex = 14;
            // 
            // textBoxISBN
            // 
            this.textBoxISBN.Location = new System.Drawing.Point(156, 163);
            this.textBoxISBN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxISBN.Name = "textBoxISBN";
            this.textBoxISBN.Size = new System.Drawing.Size(110, 23);
            this.textBoxISBN.TabIndex = 15;
            // 
            // textBoxKitapTurKodu
            // 
            this.textBoxKitapTurKodu.Location = new System.Drawing.Point(156, 198);
            this.textBoxKitapTurKodu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxKitapTurKodu.Name = "textBoxKitapTurKodu";
            this.textBoxKitapTurKodu.Size = new System.Drawing.Size(110, 23);
            this.textBoxKitapTurKodu.TabIndex = 16;
            // 
            // textBoxKitapAdi
            // 
            this.textBoxKitapAdi.Location = new System.Drawing.Point(156, 61);
            this.textBoxKitapAdi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxKitapAdi.Name = "textBoxKitapAdi";
            this.textBoxKitapAdi.Size = new System.Drawing.Size(110, 23);
            this.textBoxKitapAdi.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(17, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 23);
            this.label7.TabIndex = 9;
            this.label7.Text = "Kitap Tür Kodu: ";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelID.Location = new System.Drawing.Point(156, 27);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(17, 23);
            this.labelID.TabIndex = 3;
            this.labelID.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(17, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kitap Adı: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(17, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Yazar Adı: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(17, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "Yazar Soyad: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(17, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 23);
            this.label6.TabIndex = 7;
            this.label6.Text = "ISBN: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(17, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kitap ID: ";
            // 
            // groupBoxKitapOduncAlma
            // 
            this.groupBoxKitapOduncAlma.Controls.Add(this.buttonKitapOdunAl);
            this.groupBoxKitapOduncAlma.Controls.Add(this.dateTimePickerKitapOduncTarih);
            this.groupBoxKitapOduncAlma.Controls.Add(this.textBoxOduncAlan);
            this.groupBoxKitapOduncAlma.Controls.Add(this.labelKitapOduncAlan);
            this.groupBoxKitapOduncAlma.Controls.Add(this.label8);
            this.groupBoxKitapOduncAlma.Location = new System.Drawing.Point(399, 9);
            this.groupBoxKitapOduncAlma.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxKitapOduncAlma.Name = "groupBoxKitapOduncAlma";
            this.groupBoxKitapOduncAlma.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxKitapOduncAlma.Size = new System.Drawing.Size(250, 331);
            this.groupBoxKitapOduncAlma.TabIndex = 1;
            this.groupBoxKitapOduncAlma.TabStop = false;
            this.groupBoxKitapOduncAlma.Text = "Kitap Ödünç Alma";
            // 
            // buttonKitapOdunAl
            // 
            this.buttonKitapOdunAl.Location = new System.Drawing.Point(143, 94);
            this.buttonKitapOdunAl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonKitapOdunAl.Name = "buttonKitapOdunAl";
            this.buttonKitapOdunAl.Size = new System.Drawing.Size(101, 32);
            this.buttonKitapOdunAl.TabIndex = 18;
            this.buttonKitapOdunAl.Text = "Kitap Ödünç Al";
            this.buttonKitapOdunAl.UseVisualStyleBackColor = true;
            this.buttonKitapOdunAl.Click += new System.EventHandler(this.buttonKitapOdunAl_Click);
            // 
            // dateTimePickerKitapOduncTarih
            // 
            this.dateTimePickerKitapOduncTarih.Location = new System.Drawing.Point(120, 61);
            this.dateTimePickerKitapOduncTarih.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerKitapOduncTarih.Name = "dateTimePickerKitapOduncTarih";
            this.dateTimePickerKitapOduncTarih.Size = new System.Drawing.Size(120, 23);
            this.dateTimePickerKitapOduncTarih.TabIndex = 12;
            // 
            // textBoxOduncAlan
            // 
            this.textBoxOduncAlan.Location = new System.Drawing.Point(120, 27);
            this.textBoxOduncAlan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxOduncAlan.Name = "textBoxOduncAlan";
            this.textBoxOduncAlan.Size = new System.Drawing.Size(120, 23);
            this.textBoxOduncAlan.TabIndex = 11;
            // 
            // labelKitapOduncAlan
            // 
            this.labelKitapOduncAlan.AutoSize = true;
            this.labelKitapOduncAlan.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelKitapOduncAlan.Location = new System.Drawing.Point(4, 26);
            this.labelKitapOduncAlan.Name = "labelKitapOduncAlan";
            this.labelKitapOduncAlan.Size = new System.Drawing.Size(104, 23);
            this.labelKitapOduncAlan.TabIndex = 4;
            this.labelKitapOduncAlan.Text = "Ödünç Alan :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(4, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 23);
            this.label8.TabIndex = 3;
            this.label8.Text = "Tarih :";
            // 
            // groupBoxKitapIade
            // 
            this.groupBoxKitapIade.Controls.Add(this.buttonGecikmeBedeli);
            this.groupBoxKitapIade.Controls.Add(this.buttonKitapIadeEt);
            this.groupBoxKitapIade.Controls.Add(this.labelGecikmeBedeli);
            this.groupBoxKitapIade.Controls.Add(this.label25);
            this.groupBoxKitapIade.Location = new System.Drawing.Point(655, 9);
            this.groupBoxKitapIade.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxKitapIade.Name = "groupBoxKitapIade";
            this.groupBoxKitapIade.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxKitapIade.Size = new System.Drawing.Size(258, 331);
            this.groupBoxKitapIade.TabIndex = 1;
            this.groupBoxKitapIade.TabStop = false;
            this.groupBoxKitapIade.Text = "Kitap İade Etme";
            // 
            // buttonGecikmeBedeli
            // 
            this.buttonGecikmeBedeli.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonGecikmeBedeli.Location = new System.Drawing.Point(128, 70);
            this.buttonGecikmeBedeli.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonGecikmeBedeli.Name = "buttonGecikmeBedeli";
            this.buttonGecikmeBedeli.Size = new System.Drawing.Size(101, 35);
            this.buttonGecikmeBedeli.TabIndex = 21;
            this.buttonGecikmeBedeli.Text = "Gecikme Bedeli Hesapla";
            this.buttonGecikmeBedeli.UseVisualStyleBackColor = true;
            this.buttonGecikmeBedeli.Click += new System.EventHandler(this.buttonGecikmeBedeli_Click);
            // 
            // buttonKitapIadeEt
            // 
            this.buttonKitapIadeEt.Location = new System.Drawing.Point(21, 70);
            this.buttonKitapIadeEt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonKitapIadeEt.Name = "buttonKitapIadeEt";
            this.buttonKitapIadeEt.Size = new System.Drawing.Size(101, 35);
            this.buttonKitapIadeEt.TabIndex = 20;
            this.buttonKitapIadeEt.Text = "Kitap İade Et";
            this.buttonKitapIadeEt.UseVisualStyleBackColor = true;
            this.buttonKitapIadeEt.Click += new System.EventHandler(this.buttonKitapIadeEt_Click);
            // 
            // labelGecikmeBedeli
            // 
            this.labelGecikmeBedeli.AutoSize = true;
            this.labelGecikmeBedeli.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelGecikmeBedeli.Location = new System.Drawing.Point(128, 26);
            this.labelGecikmeBedeli.Name = "labelGecikmeBedeli";
            this.labelGecikmeBedeli.Size = new System.Drawing.Size(45, 23);
            this.labelGecikmeBedeli.TabIndex = 4;
            this.labelGecikmeBedeli.Text = "0 TL";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label25.Location = new System.Drawing.Point(7, 26);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(130, 23);
            this.label25.TabIndex = 13;
            this.label25.Text = "Gecikme Bedeli: ";
            // 
            // groupBoxKitapListesi
            // 
            this.groupBoxKitapListesi.Controls.Add(this.dataGridViewKitaplar);
            this.groupBoxKitapListesi.Location = new System.Drawing.Point(10, 344);
            this.groupBoxKitapListesi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxKitapListesi.Name = "groupBoxKitapListesi";
            this.groupBoxKitapListesi.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxKitapListesi.Size = new System.Drawing.Size(903, 200);
            this.groupBoxKitapListesi.TabIndex = 2;
            this.groupBoxKitapListesi.TabStop = false;
            this.groupBoxKitapListesi.Text = "Kitap Listesi";
            // 
            // dataGridViewKitaplar
            // 
            this.dataGridViewKitaplar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewKitaplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKitaplar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewKitaplar.Location = new System.Drawing.Point(3, 18);
            this.dataGridViewKitaplar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewKitaplar.Name = "dataGridViewKitaplar";
            this.dataGridViewKitaplar.RowHeadersWidth = 51;
            this.dataGridViewKitaplar.RowTemplate.Height = 29;
            this.dataGridViewKitaplar.Size = new System.Drawing.Size(897, 180);
            this.dataGridViewKitaplar.TabIndex = 0;
            this.dataGridViewKitaplar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewKitaplar_CellClick);
            // 
            // FormKitaplar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(917, 555);
            this.Controls.Add(this.groupBoxKitapListesi);
            this.Controls.Add(this.groupBoxKitapIade);
            this.Controls.Add(this.groupBoxKitapOduncAlma);
            this.Controls.Add(this.groupBoxKitapKayitveGuncelleme);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormKitaplar";
            this.Text = "Kütüphane Yönetim Sistemi";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormKitaplar_FormClosed);
            this.Load += new System.EventHandler(this.FormKitaplar_Load);
            this.groupBoxKitapKayitveGuncelleme.ResumeLayout(false);
            this.groupBoxKitapKayitveGuncelleme.PerformLayout();
            this.groupBoxKitapOduncAlma.ResumeLayout(false);
            this.groupBoxKitapOduncAlma.PerformLayout();
            this.groupBoxKitapIade.ResumeLayout(false);
            this.groupBoxKitapIade.PerformLayout();
            this.groupBoxKitapListesi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKitaplar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBoxKitapKayitveGuncelleme;
        private Label labelID;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label1;
        private GroupBox groupBoxKitapOduncAlma;
        private Label label7;
        private GroupBox groupBoxKitapIade;
        private Button buttonKitapGuncelle;
        private TextBox textBoxYazarAdi;
        private TextBox textBoxYazarSoyadi;
        private TextBox textBoxISBN;
        private TextBox textBoxKitapTurKodu;
        private TextBox textBoxKitapAdi;
        private DateTimePicker dateTimePickerKitapOduncTarih;
        private TextBox textBoxOduncAlan;
        private Label labelKitapOduncAlan;
        private Label label8;
        private GroupBox groupBoxKitapListesi;
        private DataGridView dataGridViewKitaplar;
        private Label label25;
        private Label labelGecikmeBedeli;
        private Button buttonKitapOdunAl;
        private Button buttonGecikmeBedeli;
        private Button buttonKitapIadeEt;
        private Button buttonAra;
        private Button buttonTumKitaplariGoster;
        private Button buttonSil;
        private Button buttonTemizle;
        private Button buttonKitapEkle;
    }
}