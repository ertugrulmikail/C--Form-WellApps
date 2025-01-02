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
    public partial class xox_arkadas : Form
    {
        string oyuncu = "X";
        int oynamasayisi = 0;
        public xox_arkadas()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            oynamasayisi++;



            Label label = (Label)sender;
            label.Text = oyuncu;
            label.Enabled = false;

            if (oyuncu == "X")
            {
                oyuncu = "O";
            }
            else oyuncu = "X";





            if (label1.Text + label2.Text + label3.Text == "XXX" ||
               label4.Text + label5.Text + label6.Text == "XXX" ||
               label7.Text + label8.Text + label9.Text == "XXX" ||
               label2.Text + label5.Text + label8.Text == "XXX" ||
               label3.Text + label6.Text + label9.Text == "XXX" ||
               label1.Text + label4.Text + label7.Text == "XXX" ||
               label1.Text + label5.Text + label9.Text == "XXX" ||
               label3.Text + label5.Text + label7.Text == "XXX")
            {
                MessageBox.Show("X Kazandı ");
                OyunuSifirla();
            }
            if (label1.Text + label2.Text + label3.Text == "OOO" ||
               label4.Text + label5.Text + label6.Text == "OOO" ||
               label7.Text + label8.Text + label9.Text == "OOO" ||
               label2.Text + label5.Text + label8.Text == "OOO" ||
               label3.Text + label6.Text + label9.Text == "OOO" ||
               label1.Text + label4.Text + label7.Text == "OOO" ||
               label1.Text + label5.Text + label9.Text == "OOO" ||
               label3.Text + label5.Text + label7.Text == "OOO")
            {
                MessageBox.Show("O Kazandı ");
                OyunuSifirla();
            }

            if (oynamasayisi == 9)
            {
                MessageBox.Show("BERABERE");
                OyunuSifirla();
            }

        }
        private void OyunuSifirla()
        {

            foreach (Control kontrol in Controls)
            {
                if (kontrol is Label)
                {
                    Label label = (Label)kontrol;
                    label.Text = "";
                    label.Enabled = true;
                }
            }


            oyuncu = "X";
            oynamasayisi = 0;
        }

        private void anaekran_btn_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            OyunuSifirla();
        }
    }
}
