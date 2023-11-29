using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace CustomerO
{
    public partial class Form1 : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=ProjelerVT;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            verileriGoster();
            textBoxMusteriID.Text = "0";
        }

        private void verileriGoster()
        {
            try
            {
                string cmd = "SELECT MusteriID, Ad, Soyad, AylikGelir, KrediyeUygunMu, Sehir FROM Musteri";
                SqlDataAdapter adapter = new SqlDataAdapter(cmd, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanýndan veriler çekerken hata oluþtu, Hata Kodu : H001\n" + ex.Message);
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilenSatir = dataGridView1.SelectedCells[0].RowIndex;
            textBoxMusteriID.Text = dataGridView1.Rows[secilenSatir].Cells[0].Value.ToString();
            textBoxAd.Text = dataGridView1.Rows[secilenSatir].Cells[1].Value.ToString();
            textBoxSoyad.Text = dataGridView1.Rows[secilenSatir].Cells[2].Value.ToString();
            textBoxAylikGelir.Text = dataGridView1.Rows[secilenSatir].Cells[3].Value.ToString();
            textBoxSehir.Text = dataGridView1.Rows[secilenSatir].Cells[5].Value.ToString();

            string metin = dataGridView1.Rows[secilenSatir].Cells[4].Value.ToString();

            if (metin.Equals("True"))
            {
                textBoxKrediyeUygunMu.Text = "Evet";
            }
            else
            {
                textBoxKrediyeUygunMu.Text = "Hayýr";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                SqlCommand sqlcmd = new SqlCommand("INSERT INTO Musteri (Ad, Soyad, AylikGelir, KrediyeUygunMu, Sehir) VALUES (@P1, @P2, @P3, @P4, @P5)", connection);

                sqlcmd.Parameters.AddWithValue("@P1", textBoxAd.Text);
                sqlcmd.Parameters.AddWithValue("@P2", textBoxSoyad.Text);
                sqlcmd.Parameters.AddWithValue("@P3", textBoxAylikGelir.Text);
                if (Convert.ToInt32(textBoxAylikGelir.Text) >= 14000)
                {
                    sqlcmd.Parameters.AddWithValue("@P4", 1);
                }
                else
                {
                    sqlcmd.Parameters.AddWithValue("@P4", 0);
                }
                sqlcmd.Parameters.AddWithValue("@P5", textBoxSehir.Text);
                sqlcmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kayýt eklenirken hata oluþtu, Hata Kodu: H002\n" + ex.Message);
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }

            verileriGoster();
            metinKutulariniTemizle();
        }

        private void metinKutulariniTemizle()
        {
            textBoxMusteriID.Clear();
            textBoxAd.Clear();
            textBoxSoyad.Clear();
            textBoxAylikGelir.Clear();
            textBoxKrediyeUygunMu.Clear();
            textBoxSehir.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            metinKutulariniTemizle();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBoxMusteriID.Text.Equals("0"))
            {
                MessageBox.Show("Lütfen bir müþteri seçiniz!");
            }
            else
            {
                try
                {
                    connection.Open();
                    SqlCommand sqlc = new SqlCommand("DELETE FROM Musteri WHERE MusteriID = @P1", connection);
                    sqlc.Parameters.AddWithValue("@P1", textBoxMusteriID.Text);
                    sqlc.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kayýt silinirken hata oluþtu, Hata Kodu: H003\n" + ex.Message);
                }
                finally
                {
                    if (connection != null)
                        connection.Close();
                }
            }

            verileriGoster();
            metinKutulariniTemizle();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBoxMusteriID.Text.Equals("0"))
            {
                MessageBox.Show("Lütfen bir müþteri seçiniz!");
            }
            else
            {
                try
                {
                    connection.Open();
                    SqlCommand sqlcmmd = new SqlCommand("UPDATE Musteri SET Ad = @P1, Soyad = @P2, AylikGelir = @P3, KrediyeUygunMu = @P4, Sehir = @P5 WHERE MusteriID = @P6", connection);
                    sqlcmmd.Parameters.AddWithValue("@P1", textBoxAd.Text);
                    sqlcmmd.Parameters.AddWithValue("@P2", textBoxSoyad.Text);
                    sqlcmmd.Parameters.AddWithValue("@P3", textBoxAylikGelir.Text);
                    if (Convert.ToInt32(textBoxAylikGelir.Text) >= 14000)
                    {
                        sqlcmmd.Parameters.AddWithValue("@P4", 1);
                    }
                    else
                    {
                        sqlcmmd.Parameters.AddWithValue("@P4", 0);
                    }
                    sqlcmmd.Parameters.AddWithValue("@P5", textBoxSehir.Text);
                    sqlcmmd.Parameters.AddWithValue("@P6", textBoxMusteriID.Text);
                    sqlcmmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kayýt silinirken hata oluþtu, Hata Kodu: H004\n" + ex.Message);
                }
                finally
                {
                    if (connection != null)
                        connection.Close();
                }
            }

            verileriGoster();
            metinKutulariniTemizle();
        }
    }
}
