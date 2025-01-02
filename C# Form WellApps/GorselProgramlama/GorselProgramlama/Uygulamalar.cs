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

namespace GorselProgramlama
{
    public partial class Uygulamalar : Form
    {
        public Uygulamalar()
        {
            InitializeComponent();
        }

        private void ajanda_btn_Click(object sender, EventArgs e)
        {
            DialogResult Cikis;
            Cikis = MessageBox.Show("Ajanda'ya girilecek emin misiniz?", "Uyarı", MessageBoxButtons.YesNo);
            if (Cikis == DialogResult.Yes)
            {
                ajanda ajandaForm = new ajanda();
                ajandaForm.Show();

                this.ParentForm.Close();
            }
        }

        private void hesap_m_btn_Click(object sender, EventArgs e)
        {
            DialogResult Cikis;
            Cikis = MessageBox.Show("Hesap Makinesine girilecek emin misiniz?", "Uyarı", MessageBoxButtons.YesNo);
            if (Cikis == DialogResult.Yes)
            {
                hesapmakinesi_form hesapMakinesiForm = new hesapmakinesi_form();
                hesapMakinesiForm.Show();

                this.ParentForm.Close();
            }
            if (Cikis == DialogResult.No)
            {

            }
        }

        private void t_rehberi_btn_Click(object sender, EventArgs e)
        {
            DialogResult Cikis;
            Cikis = MessageBox.Show("Telefon Rehberine girilecek emin misiniz?", "Uyarı", MessageBoxButtons.YesNo);
            if (Cikis == DialogResult.Yes)
            {
                telefonrehberi TelefonRehberiForm = new telefonrehberi();
                TelefonRehberiForm.Show();

                this.ParentForm.Close();
            }
            if (Cikis == DialogResult.No)
            {

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
    }
}
