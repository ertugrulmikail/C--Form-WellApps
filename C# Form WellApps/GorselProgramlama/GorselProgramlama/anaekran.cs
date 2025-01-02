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
using HesapMakinesi;


namespace GorselProgramlama
{
    public partial class anaekran : Form
    {
        
        int KullaniciId = giris.KullaniciID;
        string ad;

        SqlConnection baglanti = new SqlConnection(giris.b_adres);
        public anaekran()
        {
            
            InitializeComponent();
            

        }
        private bool kapaliMi=true;
        private bool kapaliMiAyarlar=true;
        private void Form1_Load(object sender, EventArgs e)
        {
           

            string sorgu = "Select * from Kullanici WHERE id=@k_id";
            SqlParameter prm1 = new SqlParameter("k_id", KullaniciId);
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.Add(prm1);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(komut);
            da.Fill(dt);

            ad = dt.Rows[0]["kullanici_ad"].ToString();
            label1.Text = "Hoşgeldin " + ad;
        }


        private void pictureBox1_Click_1(object sender, EventArgs e)
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (kapaliMi)
            {
                if (!kapaliMiAyarlar)
                {
                    timer2.Start();
                }
                panelUygulamalar.Height += 10;
                if (panelUygulamalar.Size==panelUygulamalar.MaximumSize)
                {
                    timer1.Stop();
                    kapaliMi = false;
                }
            }
            else
            {
                panelUygulamalar.Height -= 10;
                if (panelUygulamalar.Size == panelUygulamalar.MinimumSize)
                {
                    timer1.Stop();
                    kapaliMi = true;
                }
            }

        }

        private void btnUygulamalar_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnAyarlar_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (kapaliMiAyarlar)
            {
                if(!kapaliMi)
                {
                    timer1.Start();
                }
                panelAyarlar.Height += 10;
                if (panelAyarlar.Size == panelAyarlar.MaximumSize)
                {
                    timer2.Stop();
                    kapaliMiAyarlar = false;
                }
            }
            else
            {
                panelAyarlar.Height -= 10;
                if (panelAyarlar.Size == panelAyarlar.MinimumSize)
                {
                    timer2.Stop();
                    kapaliMiAyarlar = true;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelEkran.Controls.Clear();
            SifreDegistir sifreForm = new SifreDegistir();
            sifreForm.MdiParent = this;
            sifreForm.FormBorderStyle = FormBorderStyle.None;
            panelEkran.Controls.Add(sifreForm);
            sifreForm.Show();
        }

        private void btnOyunlar_Click(object sender, EventArgs e)
        {
            panelEkran.Controls.Clear();
            Oyunlar oyunlarForm = new Oyunlar();
            oyunlarForm.MdiParent = this;
            oyunlarForm.FormBorderStyle = FormBorderStyle.None;
            panelEkran.Controls.Add(oyunlarForm);
            oyunlarForm.Show();
        }

        private void btnDigerUygulamalar_Click(object sender, EventArgs e)
        {
            panelEkran.Controls.Clear();
            Uygulamalar uygulamalarForm = new Uygulamalar();
            uygulamalarForm.MdiParent = this;
            uygulamalarForm.FormBorderStyle = FormBorderStyle.None;
            panelEkran.Controls.Add(uygulamalarForm);
            uygulamalarForm.Show();
        }

        private void btnCikis_Click(object sender, EventArgs e)
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

        private void btn_destek_Click(object sender, EventArgs e)
        {
            panelEkran.Controls.Clear();
            DestekForm destekForm = new DestekForm();
            destekForm.MdiParent = this;
            destekForm.FormBorderStyle = FormBorderStyle.None;
            panelEkran.Controls.Add(destekForm);
            destekForm.Show();
        }
    }
}
