using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient; //veritabanı kütüphanesi

namespace GorselProgramlama
{
    public partial class giris : Form
    {
        public giris()
        {
            InitializeComponent();
            

        }
        //public int KullaniciID { get; private set; }

        public static int KullaniciID;
        
        public static string b_adres = @"Data Source=DESKTOP-33UK2TB\SQLEXPRESS;Initial Catalog=WellApps;Integrated Security=True;Encrypt=False";
        SqlConnection baglanti = new SqlConnection(b_adres);
        

        private void btnGiris_Click(object sender, EventArgs e)
        {
            try
            {             
                baglanti.Open();
                string sifrem = txtSifre.Text.Trim();

                if (txtAd.Text.Trim() == "" || txtSifre.Text.Trim() == "")
                {
                    MessageBox.Show("Kullanıcı Adı veya Şifre Boş Bırakılamaz!");
                    baglanti.Close();
                    return;
                }
                string sorgu = "Select id from Kullanici WHERE kullanici_ad=@k_adi AND sifre=@sifre";



                SqlParameter prm1 = new SqlParameter("k_adi", txtAd.Text.Trim());
                SqlParameter prm2 = new SqlParameter("sifre", txtSifre.Text.Trim());
                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.Add(prm1);
                komut.Parameters.Add(prm2);
                DataTable dt = new DataTable();
                SqlDataAdapter da= new SqlDataAdapter(komut);
                da.Fill(dt);



                
                if (dt.Rows.Count > 0)
                {

                    KullaniciID = Convert.ToInt32(dt.Rows[0]["id"]);
                    
                    anaekran form = new anaekran();
                    form.Show();
                    this.Hide();
                    
                    



                    baglanti.Close();
                }    
                else {

                    MessageBox.Show("Kullanıcı Adı veya Şifre Yanlış!");
                    baglanti.Close();
                    txtSifre.Text = sifrem;
                }
                

            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı Giriş");
                baglanti.Close();
            }
        }

        private void btn_Kayit_Click(object sender, EventArgs e)
        {
            kayitol kayitform = new kayitol();
            kayitform.Show();

            this.Hide();
        }

        private void btn_Sifre_Click(object sender, EventArgs e)
        {
            SifremiUnuttum sifreform = new SifremiUnuttum();
            sifreform.Show();

            this.Hide();
        }

        

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState==CheckState.Checked)
            {
                txtSifre.UseSystemPasswordChar = true;
            }
            else if (checkBox1.CheckState == CheckState.Unchecked)
            {
                txtSifre.UseSystemPasswordChar = false;
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
            pictureBox1.BackColor= Color.DarkCyan;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Transparent;
        }

        private void btn_Sifre_MouseEnter(object sender, EventArgs e)
        {
            btn_Sifre.BackColor = Color.Teal;
            btn_Sifre.ForeColor = Color.White;
        }

        private void btn_Sifre_MouseLeave(object sender, EventArgs e)
        {
            btn_Sifre.BackColor = Color.LightCyan;
            btn_Sifre.ForeColor = Color.DarkOliveGreen;
        }

        private void txtAd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !string.IsNullOrWhiteSpace(txtAd.Text))
            {
                e.SuppressKeyPress = true; // Tuş vuruşunu engelle
                e.Handled = true; // Olayın işlenip işlenmediğini belirt
            }

            if(e.KeyCode == Keys.Enter)
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
                btnGiris.PerformClick();
            }


        }
    }
}
