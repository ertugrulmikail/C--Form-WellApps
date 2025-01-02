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
    public partial class SifreUnuttumDegistir : Form
    {
        SqlConnection baglanti = new SqlConnection(giris.b_adres);
        private string Eposta;

        public SifreUnuttumDegistir(string aliciEposta)
        {
            InitializeComponent();
            Eposta = aliciEposta;
        }

        

       

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            if (txtSifre.Text.Trim() != txtSifre2.Text.Trim())
            {
                MessageBox.Show("Şifreler eşleşmiyor!");
                baglanti.Close();
                return;
            }

            // yeni şifre kayıt
            string updateQuery = "UPDATE Kullanici SET sifre = @sifre WHERE eposta = @eposta";
            SqlCommand cmd = new SqlCommand(updateQuery, baglanti);
            cmd.Parameters.AddWithValue("@sifre", txtSifre.Text.Trim());
            cmd.Parameters.AddWithValue("@eposta", Eposta);

            int rowsAffected = cmd.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                MessageBox.Show("Şifre başarıyla güncellendi!");
                giris girisform = new giris();
                girisform.Show();

                this.Close();
            }
            else
            {
                MessageBox.Show("Şifre güncelleme işlemi başarısız oldu!");
            }

            baglanti.Close();
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
