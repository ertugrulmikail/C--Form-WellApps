using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GorselProgramlama
{
    public partial class telefonrehberi : Form
    {
        private List<Kisi> telefonRehberi = new List<Kisi>();
        private int KullaniciId = giris.KullaniciID; 

        SqlConnection baglanti = new SqlConnection(giris.b_adres);

        public telefonrehberi()
        {
            InitializeComponent();
        }

        private void telefonrehberi_Load(object sender, EventArgs e)
        {
            VerileriGetir();
        }

        private void VerileriGetir()
        {
            telefonRehberi.Clear();

            using (SqlCommand komut = new SqlCommand("SELECT * FROM telefonrehberi WHERE kullanici_id = @kullaniciId", baglanti))
            {
                komut.Parameters.AddWithValue("@kullaniciId", KullaniciId);
                baglanti.Open();
                using (SqlDataReader reader = komut.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        telefonRehberi.Add(new Kisi
                        {
                            Ad = reader["isim"].ToString(),
                            Soyad = reader["soyisim"].ToString(),
                            TelefonNumarasi = reader["telefon_no"].ToString()
                        });
                    }
                }
                baglanti.Close();
            }

            ListeyiGuncelle();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            // Ekleme işlemi
            Kisi yeniKisi = new Kisi
            {
                Ad = txtAd.Text,
                Soyad = txtSoyad.Text,
                TelefonNumarasi = txtTelefon.Text
            };

            // Veritabanına ekleme işlemi
            using (SqlCommand komut = new SqlCommand("INSERT INTO telefonrehberi (isim, soyisim, telefon_no, kullanici_id) VALUES (@isim, @soyisim, @telefon_no, @kullanici_id)", baglanti))
            {
                komut.Parameters.AddWithValue("@isim", yeniKisi.Ad);
                komut.Parameters.AddWithValue("@soyisim", yeniKisi.Soyad);
                komut.Parameters.AddWithValue("@telefon_no", yeniKisi.TelefonNumarasi);
                komut.Parameters.AddWithValue("@kullanici_id", KullaniciId);

                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
            }

            VerileriGetir();
            Temizle();
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            if (lstRehber.SelectedItems.Count > 0)
            {
                // Güncelleme işlemi
                int seciliIndex = lstRehber.SelectedIndex;

                // Veritabanında güncelleme işlemi
                using (SqlCommand komut = new SqlCommand("UPDATE telefonrehberi SET isim = @isim, soyisim = @soyisim, telefon_no = @telefon_no WHERE kullanici_id = @kullanici_id AND isim = @eskiIsim AND soyisim = @eskiSoyisim", baglanti))
                {
                    komut.Parameters.AddWithValue("@isim", txtAd.Text);
                    komut.Parameters.AddWithValue("@soyisim", txtSoyad.Text);
                    komut.Parameters.AddWithValue("@telefon_no", txtTelefon.Text);
                    komut.Parameters.AddWithValue("@kullanici_id", KullaniciId);
                    komut.Parameters.AddWithValue("@eskiIsim", telefonRehberi[seciliIndex].Ad);
                    komut.Parameters.AddWithValue("@eskiSoyisim", telefonRehberi[seciliIndex].Soyad);

                    baglanti.Open();
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                }

                VerileriGetir();
                Temizle();
            }
            else
            {
                MessageBox.Show("Lütfen güncellemek için bir kişi seçin.");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lstRehber.SelectedItems.Count > 0)
            {
                // Silme işlemi
                int seciliIndex = lstRehber.SelectedIndex;

                // Veritabanından silme işlemi
                using (SqlCommand komut = new SqlCommand("DELETE FROM telefonrehberi WHERE kullanici_id = @kullanici_id AND isim = @isim AND soyisim = @soyisim AND telefon_no = @telefon_no", baglanti))
                {
                    komut.Parameters.AddWithValue("@kullanici_id", KullaniciId);
                    komut.Parameters.AddWithValue("@isim", telefonRehberi[seciliIndex].Ad);
                    komut.Parameters.AddWithValue("@soyisim", telefonRehberi[seciliIndex].Soyad);
                    komut.Parameters.AddWithValue("@telefon_no", telefonRehberi[seciliIndex].TelefonNumarasi);

                    baglanti.Open();
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                }

                VerileriGetir();
                Temizle();
            }
            else
            {
                MessageBox.Show("Lütfen silmek için bir kişi seçin.");
            }
        }

        private void lstRehber_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstRehber.SelectedItems.Count > 0)
            {
                int seciliIndex = lstRehber.SelectedIndex;
                Kisi seciliKisi = telefonRehberi[seciliIndex];

                txtAd.Text = seciliKisi.Ad;
                txtSoyad.Text = seciliKisi.Soyad;
                txtTelefon.Text = seciliKisi.TelefonNumarasi;
            }
        }

        private void ListeyiGuncelle()
        {
            lstRehber.Items.Clear();

            foreach (var kisi in telefonRehberi)
            {
                lstRehber.Items.Add($"{kisi.Ad} {kisi.Soyad} - {kisi.TelefonNumarasi}");
            }
        }

        private void Temizle()
        {
            txtAd.Clear();
            txtSoyad.Clear();
            txtTelefon.Clear();
            lstRehber.ClearSelected();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult Cikis;
            Cikis = MessageBox.Show("Program Kapatılacak Emin misiniz?", "Kapatma Uyarı", MessageBoxButtons.YesNo);
            if (Cikis == DialogResult.Yes)
            {
                Application.Exit();
            }
            // No seçeneği için ek bir işlem yapılmasına gerek yok.
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
            // No seçeneği için ek bir işlem yapılmasına gerek yok.
        }
    }

    public class Kisi
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TelefonNumarasi { get; set; }
    }
}
