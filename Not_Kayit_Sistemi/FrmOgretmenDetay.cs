using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Not_Kayit_Sistemi
{
    public partial class FrmOgretmenDetay : Form
    {
        public FrmOgretmenDetay()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DbNotKayit;Integrated Security=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM dbo.TBLDERS"; // Tablodan tüm verileri çekmek için sorgu
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();

                try
                {
                    connection.Open(); // Bağlantıyı aç
                    adapter.Fill(dataTable); // Verileri DataTable'a doldur
                    dataGridView1.DataSource = dataTable; // DataGridView'ı doldur
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DbNotKayit;Integrated Security=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM dbo.TBLDERS"; // Tablodan tüm verileri çekmek için sorgu
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();

                try
                {
                    connection.Open(); // Bağlantıyı aç
                    SqlCommand komut = new SqlCommand("insert into TBLDERS (OGRNUMARA,OGRAD,OGRSOYAD) values (@P1,@P2,@P3)", connection);
                    komut.Parameters.AddWithValue("@P1", MskNumara.Text);
                    komut.Parameters.AddWithValue("@P2", TxtAd.Text);
                    komut.Parameters.AddWithValue("@P3", TxtSoyad.Text);
                    komut.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Öğrenci Sisteme Eklendi");


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            MskNumara.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TxtAd.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            TxtSoyad.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            TxtSinav1.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            TxtSinav2.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            TxtSinav3.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DbNotKayit;Integrated Security=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM dbo.TBLDERS"; // Tablodan tüm verileri çekmek için sorgu
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();

                try
                {
                    

                    double ortalama, s1, s2, s3;
                    string durum;
                    s1 = Convert.ToDouble(TxtSinav1.Text);
                    s2 = Convert.ToDouble(TxtSinav2.Text);
                    s3 = Convert.ToDouble(TxtSinav3.Text);

                    ortalama = (s1 + s2 + s3) / 3;
                    LblOrtalama.Text = ortalama.ToString();

                    if (ortalama>=50)
                    {
                        durum = "True";
                    }
                    else
                    {
                        durum = "False";
                    }
                   connection.Open(); 

                    SqlCommand komut = new SqlCommand("update TBLDERS.set OGRS1=@P1,OGRS2=@P2,OGRS3=@P3,ORTALAMA=@P4,DURUM=@P5 WHERE OGRNUMARA=@P6", connection);
                    komut.Parameters.AddWithValue("@P1", TxtSinav1.Text);
                    komut.Parameters.AddWithValue("@P2", TxtSinav2.Text);
                    komut.Parameters.AddWithValue("@P3", TxtSinav3.Text);
                    komut.Parameters.AddWithValue("@P4", decimal.Parse(LblOrtalama.Text) );
                    komut.Parameters.AddWithValue("@P5", durum );
                    komut.Parameters.AddWithValue("@P6", MskNumara.Text);
                    connection.Close();
                    MessageBox.Show("Öğrenci Notları Güncellendi");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }


    }
}

    
    



