using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GorselProgramlama
{
    public partial class ucaksavasi : Form
    {
        bool solaGit, sagaGit, atesEtme, oyunBitti1;
        int skor,oyuncuHizi = 11, atisHizi, dusmanHizi;
        int enyuksekskor = 0;
        int kullaniciskor = 0;
        Random rstgle = new Random();

        private int KullaniciId = giris.KullaniciID;
        SqlConnection baglanti = new SqlConnection(giris.b_adres);

        public ucaksavasi()
        {
            InitializeComponent();
            oyunuSifirla();
            

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

        private void basla_btn_Click(object sender, EventArgs e)
        {
            oyunBitti1 = false;
            oyunuSifirla();
            
            

        }

        private void ucaksavasi_Load(object sender, EventArgs e)
        {
            
        }

        private void anaOyunZamanlayiciOlay(object sender, EventArgs e)
        {
            skorYazi.Text = skor.ToString();


            dusmanBir.Top += dusmanHizi;
            dusmaniki.Top += dusmanHizi;
            dusmanUc.Top += dusmanHizi;


            if (dusmanBir.Top > 700 || dusmaniki.Top > 700 || dusmanUc.Top > 700)
            {
                oyunBitti();
            }



            if (solaGit == true && oyuncu.Left > 0)
            {
                oyuncu.Left -= oyuncuHizi;
            }
            if (sagaGit == true && oyuncu.Left < 688)
            {
                oyuncu.Left += oyuncuHizi;
            }
           

            if (atesEtme == true)
            {
                atisHizi = 20;
                Mermi.Top -= atisHizi;
            }
            else
            {
                Mermi.Left = -300;
                atisHizi = 0;
            }

            if (Mermi.Top < -30)
            {
                atesEtme = false;
            }

            if (Mermi.Bounds.IntersectsWith(dusmanBir.Bounds))
            {
                skor += 1;
                dusmanBir.Top = -450;
                dusmanBir.Left = rstgle.Next(20, 600);
                atesEtme = false;
            }
            if (Mermi.Bounds.IntersectsWith(dusmaniki.Bounds))
            {
                skor += 1;
                dusmaniki.Top = -650;
                dusmaniki.Left = rstgle.Next(20, 600);
                atesEtme = false;
            }
            if (Mermi.Bounds.IntersectsWith(dusmanUc.Bounds))
            {
                skor += 1;
                dusmanUc.Top = -750;
                dusmanUc.Left = rstgle.Next(20, 600);
                atesEtme = false;
            }

            if (skor == 5)
            {
                dusmanHizi = 8;
            }
            if (skor == 10)
            {
                dusmanHizi = 9;
            }
            if (skor == 14)
            {
                dusmanHizi = 10;
            }
            if (skor == 19)
            {
                dusmanHizi = 11;
            }
            if (skor == 24)
            {
                dusmanHizi = 12;
            }
            if (skor == 30)
            {
                dusmanHizi = 13;
            }
            if (skor == 38)
            {
                dusmanHizi = 14;
            }
            if (skor == 45)
            {
                dusmanHizi = 15;
            }
            if (skor == 55)
            {
                dusmanHizi = 16;
            }

            if (skor > enyuksekskor)
            {
                enyuksekskor = skor;
            }

        }

        private void asagi_yonu_tus(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Left)
            {
                solaGit = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                sagaGit = true;
            }
        }

        private void yukari_yonu_tus(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Left)
            {
                solaGit = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                sagaGit = false;
            }
            if (e.KeyCode == Keys.Space && atesEtme == false)
            {
                atesEtme = true;

                Mermi.Top = oyuncu.Top - 30;
                Mermi.Left = oyuncu.Left + (oyuncu.Width / 2);

            }
            if (e.KeyCode == Keys.Enter && oyunBitti1 == true)
            {
                oyunuSifirla();
            }
        }

        private void anaekran_Btn_Click(object sender, EventArgs e)
        {
            DialogResult Cikis;
            Cikis = MessageBox.Show("Ana sayfaya dönülecek emin misiniz?", "Uyarı", MessageBoxButtons.YesNo);
            if (Cikis == DialogResult.Yes)
            {
                anaekran form = new anaekran();
                form.Show();

                this.Close();
            }
            if (Cikis == DialogResult.No)
            {

            }
        }

        private void oyunuSifirla()
        {
            
            skorYazi.SendToBack();
            basla_btn.Visible = false;
            anaekran_Btn.Visible = false;
            basla_btn.Enabled = false;
            anaekran_Btn.Enabled = false;
            oyunZaman.Start();
            dusmanHizi = 6;


            dusmanBir.Left = rstgle.Next(20, 600);
            dusmaniki.Left = rstgle.Next(20, 600);
            dusmanUc.Left = rstgle.Next(20, 600);

            dusmanBir.Top = rstgle.Next(0, 200) * -1;
            dusmaniki.Top = rstgle.Next(0, 500) * -1;
            dusmanUc.Top = rstgle.Next(0, 900) * -1;

            skor = 0;
            atisHizi = 0;
            Mermi.Left = -300;
            atesEtme = false;


            skorYazi.Text = skor.ToString();
        }

        private void oyunBitti()
        {
            anaekran_Btn.Visible = true;
            anaekran_Btn.Enabled = true;
            basla_btn.Visible = true;
            basla_btn.Enabled = true;


            SqlCommand cmd = new SqlCommand("SELECT enyuksekskor FROM ucaksavasi WHERE KullaniciId = @KullaniciId", baglanti);
            cmd.Parameters.AddWithValue("@KullaniciId", KullaniciId);
            baglanti.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            int eskiEnYuksekSkor = 0;
            if (reader.Read())
            {
                eskiEnYuksekSkor = Convert.ToInt32(reader["enyuksekskor"]);
            }
            reader.Close();

            // Eğer kullanıcı için bir en yüksek skor kaydı yoksa, yeni bir kayıt oluştur
            if (eskiEnYuksekSkor == 0)
            {
                SqlCommand insertCmd = new SqlCommand("INSERT INTO ucaksavasi (KullaniciId, enyuksekskor) VALUES (@KullaniciId, @enyuksekskor)", baglanti);
                insertCmd.Parameters.AddWithValue("@KullaniciId", KullaniciId);
                insertCmd.Parameters.AddWithValue("@enyuksekskor", enyuksekskor);
                insertCmd.ExecuteNonQuery();
                eskiEnYuksekSkor = enyuksekskor;
            }
            else
            {
                // Eğer kullanıcı için bir en yüksek skor kaydı varsa ve mevcut skor en yüksek skordan büyükse, güncelle
                if (enyuksekskor > eskiEnYuksekSkor)
                {
                    SqlCommand updateCmd = new SqlCommand("UPDATE ucaksavasi SET enyuksekskor = @enyuksekskor WHERE KullaniciId = @KullaniciId", baglanti);
                    updateCmd.Parameters.AddWithValue("@enyuksekskor", enyuksekskor);
                    updateCmd.Parameters.AddWithValue("@KullaniciId", KullaniciId);
                    updateCmd.ExecuteNonQuery();
                    eskiEnYuksekSkor=enyuksekskor;
                }
            }
            baglanti.Close();

            // Skor yazısını güncelle
            skorYazi.Text = "Skor: " + skor + Environment.NewLine +
                            "En Yüksek Skor: " + eskiEnYuksekSkor + Environment.NewLine +
                            "Enter'a basın ve yeniden deneyin";

            // Oyun bittiğini belirten işlemler
            skorYazi.BringToFront();
            oyunBitti1 = true;
            oyunZaman.Stop();
            
            
        }




    }
}
