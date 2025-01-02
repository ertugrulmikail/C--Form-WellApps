using HesapMakinesi;
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
using System.Text.RegularExpressions;

namespace GorselProgramlama
{
    public partial class kayitol : Form
    {
        public kayitol()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(giris.b_adres);


        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult Cikis;
            Cikis = MessageBox.Show("Giriş ekranına dönülecek emin misiniz?", "Uyarı", MessageBoxButtons.YesNo);
            if (Cikis == DialogResult.Yes)
            {
                giris girisform = new giris();
                girisform.Show();

                this.Close();
            }
            if (Cikis == DialogResult.No)
            {

            }

            
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();

                // E-posta formatını kontrol etmek için bir Regex deseni kullanalım
                string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
                Regex regex = new Regex(emailPattern);

                // E-postayı kontrol edelim
                if (!regex.IsMatch(txt_Eposta.Text.Trim()))
                {
                    MessageBox.Show("Geçersiz e-posta formatı!");
                    baglanti.Close();
                    return; // Eğer e-posta geçerli değilse işlemi sonlandır
                }

                if (txtSifre.Text.Trim() != txtSifre2.Text.Trim())
                {
                    MessageBox.Show("Şifreler eşleşmiyor!");
                    baglanti.Close();
                    return; // Eğer şifreler eşleşmiyorsa işlemi sonlandır
                }

                if (txtSifre.Text.Trim()==""|| txtSifre2.Text.Trim() == "")
                {
                    MessageBox.Show("Şifre boş bırakılamaz!");
                    baglanti.Close();
                    return;
                }

                else if (txtSifre.Text.Trim().Length < 6 || txtSifre2.Text.Trim().Length < 6)
                {
                    MessageBox.Show("Şifre en az 6 karakter olmalıdır!");
                    baglanti.Close();
                    return;
                }

                else if (txtSifre.Text.Trim().Length > 40 || txtSifre2.Text.Trim().Length > 40)
                {
                    MessageBox.Show("Şifre bu kadar uzun olamaz!");
                    baglanti.Close();
                    return;
                }



                // Kullanıcı adı ve e-posta adresi zaten kayıtlı mı diye kontrol edelim
                string kontrolSorgusu = "SELECT COUNT(*) FROM Kullanici WHERE kullanici_ad = @k_adi OR eposta = @eposta";
                SqlCommand kontrolKomut = new SqlCommand(kontrolSorgusu, baglanti);
                kontrolKomut.Parameters.AddWithValue("@k_adi", txtAd.Text.Trim());
                kontrolKomut.Parameters.AddWithValue("@eposta", txt_Eposta.Text.Trim());
                int kayitSayisi = (int)kontrolKomut.ExecuteScalar();

                if (kayitSayisi > 0)
                {
                    MessageBox.Show("Bu kullanıcı adı veya e-posta zaten kayıtlı!");
                    baglanti.Close();
                    return; // Eğer kullanıcı adı veya e-posta zaten kayıtlıysa işlemi sonlandır
                }



                string sorgu = "INSERT INTO Kullanici (kullanici_ad, sifre, eposta) VALUES (@k_adi, @sifre, @eposta)";
                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@k_adi", txtAd.Text.Trim());
                komut.Parameters.AddWithValue("@sifre", txtSifre.Text.Trim());
                komut.Parameters.AddWithValue("@eposta", txt_Eposta.Text.Trim());
                komut.ExecuteNonQuery();
                MessageBox.Show("Kayıt başarıyla oluşturuldu.");
                giris girisform = new giris();
                girisform.Show();
                this.Close();
                baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kayıt oluşturulamadı: " + ex.Message);
                baglanti.Close();
            }
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult Cikis;
            Cikis = MessageBox.Show("Program Kapatılacak Emin siniz?", "Kapatma Uyarı", MessageBoxButtons.YesNo);
            if (Cikis == DialogResult.Yes)
            {
                Application.Exit();
            }
            if (Cikis == DialogResult.No)
            {

            }
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.DarkCyan;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Transparent;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.DarkCyan;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor= Color.DarkSlateGray;
        }

        private void txtAd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !string.IsNullOrWhiteSpace(txtAd.Text))
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
            }

            if (e.KeyCode == Keys.Enter)
            {
                txt_Eposta.Focus();
            }
        }

        private void txt_Eposta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !string.IsNullOrWhiteSpace(txt_Eposta.Text))
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
            }

            if (e.KeyCode == Keys.Enter)
            {
                txtSifre.Focus();
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
            if (e.KeyCode == Keys.Enter && !string.IsNullOrWhiteSpace(txtSifre.Text))
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
            }

            if (e.KeyCode == Keys.Enter)
            {
                btnKayit.PerformClick();
            }
        }
    }
}
