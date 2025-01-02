using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GorselProgramlama
{
    public partial class DestekForm : Form
    {
        public DestekForm()
        {
            InitializeComponent();
        }
        int KullaniciId = giris.KullaniciID;
        string SorunYasayanEposta,SorunYasayanAd;
        SqlConnection baglanti = new SqlConnection(giris.b_adres);

        private void btnYolla_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();

                string metin = textBox1.Text;

                string GondericiEposta = "";//gerekli eposta girilecek
                string GondericiSifre = "";//gerekli sifre girilecek
                string AliciEposta = "wellappsdestek@gmail.com";

                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(GondericiEposta);
                mail.To.Add(AliciEposta);

                mail.Subject = "Kullanıcı Destek: "+SorunYasayanAd;
                mail.Body = "\n Sorun yaşayan kişinin \n E-Postası: " + SorunYasayanEposta + "\n\n\n" + "Yaşanan Sorun: " + "\n\n" + metin;

                SmtpClient smtp = new SmtpClient("smtp-mail.outlook.com ", 587);

                smtp.Credentials = new System.Net.NetworkCredential(GondericiEposta, GondericiSifre);
                smtp.EnableSsl = true;

                smtp.Send(mail);
                MessageBox.Show("Mesajınız başarıyla destek birimlerine iletildi! \n Çözüm için lütfen E-Posta Adresinizi Kontrol Ediniz");
                textBox1.Clear();

                baglanti.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Destekle ilgili mesaj gönderilirken sıkıntı yaşandı");
                
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
        }

        private void DestekForm_Load(object sender, EventArgs e)
        {
            string sorgu = "Select * from Kullanici WHERE id=@k_id";
            SqlParameter prm1 = new SqlParameter("k_id", KullaniciId);
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.Add(prm1);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(komut);
            da.Fill(dt);

            SorunYasayanEposta = dt.Rows[0]["eposta"].ToString();
            SorunYasayanAd= dt.Rows[0]["kullanici_ad"].ToString();
        }
    }
}
