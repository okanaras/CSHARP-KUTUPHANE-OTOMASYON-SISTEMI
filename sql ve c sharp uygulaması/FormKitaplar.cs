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

namespace sql_ve_c_sharp_uygulaması
{
    public partial class FormKitaplar : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=DbOAKutuphane;Integrated Security=True");
        public FormKitaplar()
        {
            InitializeComponent();
        }

        private void buttonKitapEkle_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();

                SqlCommand sqlCommand = new SqlCommand("INSERT INTO TableKitaplar (KitapAdi,YazarAdi, YazarSoyadi,ISBN,Durum,KitapTurKodu) VALUES (@P1, @P2, @P3, @P4, @P5, @P6)", baglanti);
                sqlCommand.Parameters.AddWithValue("@P1", textBoxKitapAdi.Text);
                sqlCommand.Parameters.AddWithValue("@P2", textBoxYazarAdi.Text);
                sqlCommand.Parameters.AddWithValue("@P3", textBoxYazarSoyadi.Text);
                sqlCommand.Parameters.AddWithValue("@P4", textBoxISBN.Text);
                sqlCommand.Parameters.AddWithValue("@P5", "true");
                sqlCommand.Parameters.AddWithValue("@P6", textBoxKitapTurKodu.Text);

                sqlCommand.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Kitap Eklenirken Bir Hata Oluştu!!!" + ex.Message);
            }

            finally
            {
                baglanti.Close();
            }

            verileriGoster();
        }

        private void verileriGoster()
        {
            try
            {
                string q = "SELECT*FROM TableKitaplar";
                SqlDataAdapter da = new SqlDataAdapter(q, baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    dataGridViewKitaplar.DataSource = dt;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormKitaplar_Load(object sender, EventArgs e)
        {
            verileriGoster();
        }

        private void dataGridViewKitaplar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            labelGecikmeBedeli.Text = "0";
            int secilenSatir = dataGridViewKitaplar.SelectedCells[0].RowIndex;
            labelID.Text = dataGridViewKitaplar.Rows[secilenSatir].Cells[0].Value.ToString();
            textBoxKitapAdi.Text = dataGridViewKitaplar.Rows[secilenSatir].Cells[1].Value.ToString();
            textBoxYazarAdi.Text = dataGridViewKitaplar.Rows[secilenSatir].Cells[2].Value.ToString();
            textBoxYazarSoyadi.Text = dataGridViewKitaplar.Rows[secilenSatir].Cells[3].Value.ToString();
            textBoxISBN.Text = dataGridViewKitaplar.Rows[secilenSatir].Cells[4].Value.ToString();
            textBoxKitapTurKodu.Text = dataGridViewKitaplar.Rows[secilenSatir].Cells[8].Value.ToString();

            textBoxOduncAlan.Text = dataGridViewKitaplar.Rows[secilenSatir].Cells[6].Value.ToString();

            if (dataGridViewKitaplar.Rows[secilenSatir].Cells[7].Value != DBNull.Value)
                dateTimePickerKitapOduncTarih.Value = (DateTime)dataGridViewKitaplar.Rows[secilenSatir].Cells[7].Value;
        }

        private void buttonKitapGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();

                SqlCommand sqlCommand = new SqlCommand("UPDATE TableKitaplar SET KitapAdi = @P1 , YazarAdi = @P2 , YazarSoyadi = @P3 , ISBN = @P4 , KitapTurKodu = @P5"
                                                     + " WHERE ID = @P6 ", baglanti);

                sqlCommand.Parameters.AddWithValue("@P1", textBoxKitapAdi.Text);
                sqlCommand.Parameters.AddWithValue("@P2", textBoxYazarAdi.Text);
                sqlCommand.Parameters.AddWithValue("@P3", textBoxYazarSoyadi.Text);
                sqlCommand.Parameters.AddWithValue("@P4", textBoxISBN.Text);
                sqlCommand.Parameters.AddWithValue("@P5", textBoxKitapTurKodu.Text);
                sqlCommand.Parameters.AddWithValue("@P6", labelID.Text);

                sqlCommand.ExecuteNonQuery();

            }

            catch (Exception ex)
            {
                MessageBox.Show("Kitap Güncellenirken Bir Hata Oluştu!!!" + ex.Message);
            }

            finally
            {
                baglanti.Close();
            }

            verileriGoster();
        }

        private void buttonKitapOdunAl_Click(object sender, EventArgs e)
        {
            if (labelID.Text != "-")
            {
                try
                {
                    baglanti.Open();

                    SqlCommand sqlCommand = new SqlCommand("UPDATE TableKitaplar SET OduncAlan = @P1 , OduncAlmaTarihi = @P2 , Durum = @P3 WHERE ID = @P4 ", baglanti);
                    sqlCommand.Parameters.AddWithValue("@P1", textBoxOduncAlan.Text);
                    sqlCommand.Parameters.Add("@P2", SqlDbType.Date).Value = dateTimePickerKitapOduncTarih.Value.Date;
                    sqlCommand.Parameters.AddWithValue("@P3", "false");
                    sqlCommand.Parameters.AddWithValue("@P4", labelID.Text);

                    sqlCommand.ExecuteNonQuery();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Kitap Odünç Alınırken Bir Hata Oluştu!!!" + ex.Message);
                }

                finally
                {
                    baglanti.Close();
                }

                verileriGoster();

            }
            else
            {
                MessageBox.Show("Listeden Bir Kitap Seçiniz!");
            }
        }

        private void buttonGecikmeBedeli_Click(object sender, EventArgs e)
        {
            if (labelID.Text != "-")
            {
                DateTime bugununTarihi = DateTime.Now;
                int gunFarki = (int)(bugununTarihi - dateTimePickerKitapOduncTarih.Value.Date).TotalDays;
                if (gunFarki > 10)
                {
                    int gecikmeBedeli = (gunFarki - 10) * 1;
                    labelGecikmeBedeli.Text = gecikmeBedeli.ToString() + " " + "TL";
                }
            }
            else
            {
                MessageBox.Show("Lütfen Listeden Bir Kitap Seçiniz!");
            }
        }

        private void buttonKitapIadeEt_Click(object sender, EventArgs e)
        {
            if (labelID.Text != "-")
            {
                try
                {
                    baglanti.Open();

                    SqlCommand sqlCommand = new SqlCommand("UPDATE TableKitaplar SET OduncAlan = @P1 , OduncAlmaTarihi = @P2 , Durum = @P3 WHERE ID = @P4 ", baglanti);
                    sqlCommand.Parameters.AddWithValue("@P1", "");
                    sqlCommand.Parameters.Add("@P2", SqlDbType.Date).Value = DBNull.Value;
                    sqlCommand.Parameters.AddWithValue("@P3", "true");
                    sqlCommand.Parameters.AddWithValue("@P4", labelID.Text);
                    textBoxOduncAlan.Text = "";

                    sqlCommand.ExecuteNonQuery();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Kitap İade Edilirken Bir Hata Oluştu!!!" + ex.Message);
                }

                finally
                {
                    baglanti.Close();
                }

                verileriGoster();

            }
            else
            {
                MessageBox.Show("Lütfen Listeden Bir Kitap Seçiniz!");
            }

        }

        private void buttonTemizle_Click(object sender, EventArgs e)
        {
            metindekiBosluklariTemizle();
        }

        private void buttonAra_Click(object sender, EventArgs e)
        {
            aramaSonuclariniGoster();
        }

        private void aramaSonuclariniGoster()
        {
            try
            {
                string q = "SELECT * FROM TableKitaplar WHERE KitapAdi LIKE '" + textBoxKitapAdi.Text  
                                                                             + "%' AND YazarAdi LIKE '" + textBoxYazarAdi.Text + "%'"
                                                                             + " AND YazarSoyadi LIKE '" + textBoxYazarSoyadi.Text + "%'"
                                                                             + " AND ISBN LIKE '" + textBoxISBN.Text + "%'"
                                                                             + " AND KitapTurKodu LIKE '" + textBoxKitapTurKodu.Text + "%'"
                                                                             + " AND OduncAlan LIKE '" + textBoxOduncAlan.Text + "%'";
                SqlDataAdapter da = new SqlDataAdapter(q, baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    dataGridViewKitaplar.DataSource = dt;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Girdiğiniz Değer Bulunamadı, Lütfen Tekrar Deneyin!" + ex.Message);
            }
        }

        private void buttonTumKitaplariGoster_Click(object sender, EventArgs e)
        {
            verileriGoster();
            metindekiBosluklariTemizle();    
        }

        private void metindekiBosluklariTemizle()
        {
            labelID.Text = "-";
            textBoxKitapAdi.Text = "";
            textBoxYazarAdi.Text = "";
            textBoxYazarSoyadi.Text = "";
            textBoxISBN.Text = "";
            textBoxKitapTurKodu.Text = "";
            textBoxOduncAlan.Text = "";
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            if (labelID.Text == "-" || labelID.Text == "")
            {
                MessageBox.Show("Lütfen Bir Kitap Seçerek Tekrar Deneyiniz!!");
            }
            else
            {            
                try
                {
                    baglanti.Open();

                    SqlCommand sqlCommand = new SqlCommand("DELETE TableKitaplar WHERE ID = @P1", baglanti);
                    sqlCommand.Parameters.AddWithValue("@P1", labelID.Text);
               

                    sqlCommand.ExecuteNonQuery();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Kitap Silinirken Bir Hata Oluştu!!!" + ex.Message);
                }

                finally
                {
                    baglanti.Close();
                }
            }

            verileriGoster();
            metindekiBosluklariTemizle();
        }

        private void FormKitaplar_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
