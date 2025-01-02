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
    public partial class ajanda : Form
    {
        private List<Olay> ajandaa = new List<Olay>();
        SqlConnection baglanti = new SqlConnection(giris.b_adres);
        private int KullaniciId = giris.KullaniciID;

        public ajanda()
        {
            InitializeComponent();
            monthCalendar.DateSelected += monthCalendar_DateSelected;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            DateTime tarihSaat = monthCalendar.SelectionStart.Date;
            string olayAdi = txtOlayAdi.Text;

            int kullaniciAjandaID = KullaniciAjandaIDAl();

            
            if (kullaniciAjandaID == -1)
            {
                string eklemeSorgusu = "INSERT INTO KullaniciAjanda (KullaniciID) VALUES (@kullaniciID); SELECT SCOPE_IDENTITY();";
                SqlCommand eklemeKomutu = new SqlCommand(eklemeSorgusu, baglanti);
                eklemeKomutu.Parameters.AddWithValue("@kullaniciID", KullaniciId);

                baglanti.Open();
                kullaniciAjandaID = Convert.ToInt32(eklemeKomutu.ExecuteScalar());
                baglanti.Close();
            }

            // veritabanı olay ekleme
            string eklemeSorgusu2 = "INSERT INTO Olaylar (KullaniciAjandaID, TarihSaat, OlayAdi) VALUES (@kullaniciAjandaID, @tarihSaat, @olayAdi)";
            SqlCommand eklemeKomutu2 = new SqlCommand(eklemeSorgusu2, baglanti);
            eklemeKomutu2.Parameters.AddWithValue("@kullaniciAjandaID", kullaniciAjandaID);
            eklemeKomutu2.Parameters.AddWithValue("@tarihSaat", tarihSaat);
            eklemeKomutu2.Parameters.AddWithValue("@olayAdi", olayAdi);

            baglanti.Open();
            eklemeKomutu2.ExecuteNonQuery();
            baglanti.Close();

            VerileriGetir();
            Temizle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lstAjanda.SelectedItems.Count > 0)
            {
                int seciliIndex = lstAjanda.SelectedIndex;
                int seciliOlayID = ajandaa[seciliIndex].OlayID;

                // veritabanı olay silme kısmı
                string silmeSorgusu = "DELETE FROM Olaylar WHERE OlayID = @olayID";
                SqlCommand silmeKomutu = new SqlCommand(silmeSorgusu, baglanti);
                silmeKomutu.Parameters.AddWithValue("@olayID", seciliOlayID);

                baglanti.Open();
                silmeKomutu.ExecuteNonQuery();
                baglanti.Close();

                VerileriGetir();
                Temizle();
            }
            else
            {
                MessageBox.Show("Lütfen silmek için bir olay seçin.");
            }
        }

        private void ajanda_Load(object sender, EventArgs e)
        {
            VerileriGetir();
        }

        private void monthCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            ListeyiGuncelle(e.Start);
        }

        private void lstAjanda_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstAjanda.SelectedItems.Count > 0)
            {
                int seciliIndex = lstAjanda.SelectedIndex;
                Olay seciliOlay = ajandaa[seciliIndex];

                monthCalendar.SetDate(seciliOlay.TarihSaat);
                txtOlayAdi.Text = seciliOlay.OlayAdi;
            }
        }

        private void VerileriGetir()
        {
            ajandaa.Clear();

            // veritabanındaki olayları görüntüleme
            string sorgu = "SELECT * FROM Olaylar WHERE KullaniciAjandaID = @kullaniciAjandaID";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@kullaniciAjandaID", KullaniciAjandaIDAl());

            baglanti.Open();
            SqlDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {
                ajandaa.Add(new Olay
                {
                    OlayID = Convert.ToInt32(reader["OlayID"]),
                    TarihSaat = Convert.ToDateTime(reader["TarihSaat"]),
                    OlayAdi = reader["OlayAdi"].ToString()
                });
            }
            baglanti.Close();

            ListeyiGuncelle();
        }

        private int KullaniciAjandaIDAl()
        {
            int kullaniciAjandaID = -1;

            /////////// KullanıcıAjandaID'yi veritabanından alma 
            string sorgu = "SELECT KullaniciAjandaID FROM KullaniciAjanda WHERE KullaniciID = @kullaniciID";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@kullaniciID", KullaniciId);

            baglanti.Open();
            SqlDataReader reader = komut.ExecuteReader();
            if (reader.Read())
            {
                kullaniciAjandaID = Convert.ToInt32(reader["KullaniciAjandaID"]);
            }
            baglanti.Close();

            return kullaniciAjandaID;
        }

        private void ListeyiGuncelle(DateTime? seciliTarih = null)
        {
            lstAjanda.Items.Clear();

            foreach (var olay in ajandaa)
            {
                if (!seciliTarih.HasValue || olay.TarihSaat.Date == seciliTarih.Value.Date)
                {
                    lstAjanda.Items.Add($"{olay.TarihSaat} - {olay.OlayAdi}");
                }
            }
        }

        private void Temizle()
        {
            monthCalendar.SetDate(DateTime.Now);
            txtOlayAdi.Clear();
            lstAjanda.ClearSelected();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult Cikis;
            Cikis = MessageBox.Show("Program Kapatılacak Emin misiniz?", "Kapatma Uyarı", MessageBoxButtons.YesNo);
            if (Cikis == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }

        private void anaekran_btn_Click(object sender, EventArgs e)
        {
            DialogResult Cikis;
            Cikis = MessageBox.Show("Ana sayfaya dönülecek Emin misiniz?", "Uyarı", MessageBoxButtons.YesNo);
            if (Cikis == DialogResult.Yes)
            {
                anaekran form = new anaekran();
                form.Show();
                this.Close();
            }
            
        }
    }

    public class Olay
    {
        public int OlayID { get; set; }
        public DateTime TarihSaat { get; set; }
        public string OlayAdi { get; set; }
    }
}
