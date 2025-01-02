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
using System.Net.Mail;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace GorselProgramlama
{
    public partial class SifremiUnuttum : Form
    {
        public SifremiUnuttum()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(giris.b_adres);
        private int dogrulamakodu;
        string AliciEposta;

        int dakika = 3;
        int saniye = 0;
        int tiklama = 0;

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
            baglanti.Open();


            // E-posta formatını kontrol etmek için bir Regex deseni kullanalım
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Regex regex = new Regex(emailPattern);

            if (!regex.IsMatch(txt_Eposta.Text.Trim()))
            {
                MessageBox.Show("Geçersiz e-posta formatı! Lüften e-postanızı tekrar gözden geçiriniz.");
                baglanti.Close();
                return;
            }

            // Kullanıcı adı ve e-posta adresi zaten kayıtlı mı diye kontrol edelim
            string kontrolSorgusu = "SELECT COUNT(*) FROM Kullanici WHERE eposta = @eposta";
            SqlCommand kontrolKomut = new SqlCommand(kontrolSorgusu, baglanti);
            kontrolKomut.Parameters.AddWithValue("@eposta", txt_Eposta.Text.Trim());
            int kayitSayisi = (int)kontrolKomut.ExecuteScalar();
            if (kayitSayisi <= 0)
            {
                MessageBox.Show("E-posta Sistemde Kayıtlı Değil!");
                baglanti.Close();
                return;
            }

            Random rnd = new Random();
            dogrulamakodu = rnd.Next(100000, 999999);

            //EPOSTA İŞLEMLERİ AÇILIŞ
            
            string GondericiEposta = "";//
            string GondericiSifre = "";//gerekli epostalar girilecek
            AliciEposta = txt_Eposta.Text.Trim();

            MailMessage mail = new MailMessage();
            mail.From = new MailAddress(GondericiEposta);
            mail.To.Add(AliciEposta);

            mail.Subject = "WellApps Şifre Değiştirme";
            mail.Body = "Merhaba, şifrenizi sıfırlamak için bu doğrulama kodunu kullanabilirsiniz: " + dogrulamakodu.ToString();

           
            SmtpClient smtp = new SmtpClient("smtp-mail.outlook.com", 587);

            smtp.Credentials = new System.Net.NetworkCredential(GondericiEposta, GondericiSifre);
            smtp.EnableSsl = true;

            smtp.Send(mail);

            baglanti.Close();
            
            //EPOSTA İŞLEMLERİ KAPANIŞ

            btnKayit.Visible = false;
            btnKayit.Enabled = false;

            label2.Text = "Doğrulama Kodunu Giriniz";
            txt_Eposta.Clear();

            button2.Enabled = true;
            button2.Visible = true;
            button1.Enabled = false;
            button1.Visible = false;

            lbl_dakika.Visible = true;
            lbl_saniye.Visible = true;
            labelSure.Visible = true;
            labelNokta.Visible = true;

            //SAYAÇ

            timer1.Start();
            

            //SAYAÇ

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tiklama == 6)
            {
                timer1.Stop();
                baglanti.Close();
                giris girisform = new giris();
                girisform.Show();

                this.Close();

                MessageBox.Show("Çok fazla hatalı giriş yaptığınız için giriş ekranına yönlendirildiniz.");
            }

            string yazilan = txt_Eposta.Text;

            if (!int.TryParse(yazilan, out _))
            {
                label2.Text = "Lütfen Sayı girişi yapınız.";
                label2.ForeColor = Color.Red;
                return;
            }

            int yazilankod = Convert.ToInt32(yazilan.Trim());



            if (yazilankod == dogrulamakodu)
            {
                timer1.Stop();
                SifreUnuttumDegistir sifredegistirform = new SifreUnuttumDegistir(AliciEposta);
                sifredegistirform.Show();
                this.Close();
            }
            else
            {
                label2.Text = "Girdiğiniz kod hatalı";
                label2.ForeColor = Color.Red;

            }
            tiklama++;

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
            button1.BackColor = Color.DarkSlateGray;
        }

        private void SifremiUnuttum_Load(object sender, EventArgs e)
        {
            lbl_dakika.Text = dakika.ToString();
            lbl_saniye.Text = saniye.ToString().PadLeft(2, '0');
            timer1.Interval = 1000;
            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (dakika == 0 && saniye == 0)
            {
                timer1.Stop();
                baglanti.Close();
                giris girisform = new giris();
                girisform.Show();

                this.Close();

                MessageBox.Show("Belirtilen süre içinde doğrulama kodunu girmediğiniz için giriş ekranına yönlendirildiniz.");
            }
            else
            {
                if (saniye == 0)
                {
                    dakika--;
                    saniye = 59;
                }
                else
                {
                    saniye--;
                }

                lbl_dakika.Text = dakika.ToString();
                lbl_saniye.Text = saniye.ToString().PadLeft(2, '0');
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

        private void txt_Eposta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !string.IsNullOrWhiteSpace(txt_Eposta.Text))
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
            }

            if (e.KeyCode == Keys.Enter)
            {
                if (btnKayit.Enabled && !button2.Enabled)
                {
                    btnKayit.PerformClick();
                }
                else if (!btnKayit.Enabled && button2.Enabled)
                {
                    button2.PerformClick();
                }
            }

            
        }
    }
}
