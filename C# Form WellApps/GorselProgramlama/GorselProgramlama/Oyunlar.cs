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
    public partial class Oyunlar : Form
    {
        public Oyunlar()
        {
            InitializeComponent();
            
            
        }
        

        private void xox_oyun_btn_Click(object sender, EventArgs e)
        {
            DialogResult Cikis;
            Cikis = MessageBox.Show("XOX oyununa girilecek emin misiniz?", "Uyarı", MessageBoxButtons.YesNo);
            if (Cikis == DialogResult.Yes)
            {
                xox_oyun xox = new xox_oyun();
                xox.Show();

                this.ParentForm.Close();
            }

        }

        private void ucaksavasi_btn_Click(object sender, EventArgs e)
        {
            DialogResult Cikis;
            Cikis = MessageBox.Show("Uçak Savaşı oyununa girilecek emin misiniz?", "Uyarı", MessageBoxButtons.YesNo);
            if (Cikis == DialogResult.Yes)
            {
                ucaksavasimenu ucaksavasiForm = new ucaksavasimenu();
                ucaksavasiForm.Show();

                this.ParentForm.Close();
            }
            
        }

        private void Oyunlar_Load(object sender, EventArgs e)
        {

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

        private void xox_arkadas_oyun_btn_Click(object sender, EventArgs e)
        {
            DialogResult Cikis;
            Cikis = MessageBox.Show("XOX oyununa girilecek emin misiniz?", "Uyarı", MessageBoxButtons.YesNo);
            if (Cikis == DialogResult.Yes)
            {
                xox_arkadas xox = new xox_arkadas();
                xox.Show();

                this.ParentForm.Close();
            }
        }
    }
}
