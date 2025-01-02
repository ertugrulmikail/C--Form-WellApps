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
    public partial class ucaksavasiskor : Form
    {

        SqlConnection baglanti = new SqlConnection(giris.b_adres);
        private int KullaniciId = giris.KullaniciID;
        public ucaksavasiskor()
        {
            InitializeComponent();
        }

        private void ucaksavasiskor_Load(object sender, EventArgs e)
        {
            ///////////////////////////////////////
            SqlCommand cmdMevcutKullanici = new SqlCommand("SELECT enyuksekskor FROM ucaksavasi WHERE KullaniciId = @KullaniciId", baglanti);
            cmdMevcutKullanici.Parameters.AddWithValue("@KullaniciId", KullaniciId);
            baglanti.Open();
            SqlDataReader readerMevcutKullanici = cmdMevcutKullanici.ExecuteReader();

            if (readerMevcutKullanici.Read())
            {
                int mevcutKullaniciSkoru = Convert.ToInt32(readerMevcutKullanici["enyuksekskor"]);
                label2.Text = mevcutKullaniciSkoru.ToString();
            }
            else
            {
                label2.Text = "Henüz skor yok";
            }

            readerMevcutKullanici.Close();
            baglanti.Close();

            ///////////////////////////////////////////////

            SqlCommand cmd = new SqlCommand("SELECT TOP 15 Kullanici.kullanici_ad, ucaksavasi.enyuksekskor, " +
                                    "ROW_NUMBER() OVER (ORDER BY ucaksavasi.enyuksekskor DESC) AS sirano " +
                                    "FROM ucaksavasi " +
                                    "INNER JOIN Kullanici ON ucaksavasi.KullaniciId = Kullanici.id " +
                                    "ORDER BY ucaksavasi.enyuksekskor DESC", baglanti);
            baglanti.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            listBox1.Items.Clear(); 

            bool skorVar = false; 

            while (reader.Read())
            {
                int sirano = Convert.ToInt32(reader["sirano"]);
                string kullaniciAdi = reader["kullanici_ad"].ToString();
                int skor = Convert.ToInt32(reader["enyuksekskor"]);
                listBox1.Items.Add(sirano.ToString() + "- " + kullaniciAdi + " - Skor: " + skor); 
                skorVar = true; 
            }

            reader.Close();
            baglanti.Close();

            if (!skorVar)
            {
                listBox1.Items.Add("Henüz kayıtlı skor yok");
            }
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            DialogResult Cikis;
            Cikis = MessageBox.Show("Menüye geri dönülecek emin misiniz?", "Uyarı", MessageBoxButtons.YesNo);
            if (Cikis == DialogResult.Yes)
            {
                ucaksavasimenu ucaksavasiForm = new ucaksavasimenu();
                ucaksavasiForm.Show();

                this.Close();
            }
        }

        private void listBox1_DrawItem(object sender, DrawItemEventArgs e)
        {

        }
    }
}
