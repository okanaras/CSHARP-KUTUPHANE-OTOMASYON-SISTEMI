using System.Data.SqlClient;

namespace sql_ve_c_sharp_uygulaması
{
    public partial class FormGiris : Form
        
    {
        FormKitaplar formKitaplar;
        public FormGiris()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=DbOAKutuphane;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            string sifre = "";
            try
            {
                baglanti.Open();
                SqlCommand sqlKomut = new SqlCommand("SELECT Sifre FROM tableYoneticiler WHERE KullaniciAdi=@p1", baglanti);
                sqlKomut.Parameters.AddWithValue("@p1", textBoxKullaniciAdi.Text);
                SqlDataReader sqlDataReader = sqlKomut.ExecuteReader();


                while (sqlDataReader.Read())
                {
                    sifre = Convert.ToString(sqlDataReader[0]);
                }
                //label4.Text = sifre;

                if (sifre == textBoxSifre.Text)
                { 
                    label4.Text = "Şifreyi doğru girdiniz!!";
                    formKitaplar = new FormKitaplar();
                    this.Hide();
                    formKitaplar.Show();
                }
                
                else
                {
                    MessageBox.Show("Şifre veya kullanıcı yanlış girdiniz lütfen tekrar deneyiniz");
                    textBoxKullaniciAdi.Text = "";
                    textBoxSifre.Text = "";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Kullanıcı hatas!!!" + ex.Message);     
            }       
            finally
            {
                baglanti.Close();
            }
        }
    }
}