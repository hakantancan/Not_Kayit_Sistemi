using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Not_Kayit_Sistemi
{
    public partial class FrmOgrenciDetay : Form
    {
        public FrmOgrenciDetay()
        {
            InitializeComponent();
        }

        public string numara;

        private void FrmOgrenciDetay_Load(object sender, EventArgs e)
        {
            LblNumara.Text = numara;



            // LocalDB bağlantı dizesi
            string connectionString = @"Server=(localdb)\MSSQLLocalDB;Integrated Security=true;Database=DbNotKayit;";

            using (var connection = new SqlConnection(connectionString))
            {

                try
                {
                    connection.Open(); // Veritabanı bağlantısını açıyoruz
                    SqlCommand komut = new SqlCommand("Select * From TBLDERS where OGRNUMARA=@p1", connection);
                    komut.Parameters.AddWithValue("@p1", numara);
                    SqlDataReader dr = komut.ExecuteReader();
                    while (dr.Read())
                    {
                        LblAdSoyad.Text = dr[2].ToString()+" " + dr[3].ToString();
                        LblSinav1.Text = dr[4].ToString();
                        LblSinav2.Text= dr[5].ToString();
                        LblSinav3.Text= dr[6].ToString();
                        LblOrtalama.Text = dr[7].ToString();
                        LblDurum.Text = dr[8].ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bağlantı hatası: " + ex.Message); // Hata olursa mesaj göster
                }
            }



        }

        private void label8_Click(object sender, EventArgs e)
        {
            // Buraya label8 için gerekli kodları ekleyebilirsiniz
        }
    }
}
