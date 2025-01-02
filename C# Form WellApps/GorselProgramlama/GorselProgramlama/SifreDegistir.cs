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

namespace GorselProgramlama
{
    public partial class SifreDegistir : Form
    {
        int KullaniciId = giris.KullaniciID;
        string eposta;
        SqlConnection baglanti = new SqlConnection(giris.b_adres);
        public SifreDegistir()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult Cikis;
            Cikis = MessageBox.Show("Program Kapatılacak Emin siniz?", "Kapatma Uyarı", MessageBoxButtons.YesNo);
            if (Cikis == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            if (txtSifre.Text.Trim() != txtSifre2.Text.Trim())
            {
                MessageBox.Show("Şifreler eşleşmiyor!");
                baglanti.Close();
                return; // Eğer şifreler eşleşmiyorsa işlemi sonlandır
            }

            // Yeni şifreyi veritabanına kaydetme
            string updateQuery = "UPDATE Kullanici SET sifre = @sifre WHERE eposta = @eposta";
            SqlCommand cmd = new SqlCommand(updateQuery, baglanti);
            cmd.Parameters.AddWithValue("@sifre", txtSifre.Text.Trim());
            cmd.Parameters.AddWithValue("@eposta", eposta);

            int rowsAffected = cmd.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                MessageBox.Show("Şifre başarıyla güncellendi!");
                txtSifre.Clear();
                txtSifre2.Clear();
                txtSifre.Focus();
            }
            else
            {
                MessageBox.Show("Şifre güncelleme işlemi başarısız oldu!");
            }

            baglanti.Close();
        }

        private void SifreDegistir_Load(object sender, EventArgs e)
        {
            string sorgu = "Select * from Kullanici WHERE id=@k_id";
            SqlParameter prm1 = new SqlParameter("k_id", KullaniciId);
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.Add(prm1);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(komut);
            da.Fill(dt);

            eposta = dt.Rows[0]["eposta"].ToString();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked)
            {
                txtSifre.UseSystemPasswordChar = true;
                txtSifre2.UseSystemPasswordChar = true;
            }
            else if (checkBox1.CheckState == CheckState.Unchecked)
            {
                txtSifre.UseSystemPasswordChar = false;
                txtSifre2.UseSystemPasswordChar = false;
            }
        }

        private void txtSifre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !string.IsNullOrWhiteSpace(txtSifre.Text))
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
            }

            if (e.KeyCode == Keys.Enter)
            {
                txtSifre2.Focus();
            }
        }

        private void txtSifre2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !string.IsNullOrWhiteSpace(txtSifre2.Text))
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
            }

            if (e.KeyCode == Keys.Enter)
            {
                button2.PerformClick();
            }
        }
    }
}
