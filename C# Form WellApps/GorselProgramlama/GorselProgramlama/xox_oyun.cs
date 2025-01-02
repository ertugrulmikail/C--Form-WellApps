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
    public partial class xox_oyun : Form
    {
        string oyuncu = "X";
        int oynamasayisi = 0;
        bool oyunvar = true;

        public xox_oyun()
        {
            InitializeComponent();
            bilgisayarHamleTimer = new Timer();
            bilgisayarHamleTimer.Interval = 1000;
            bilgisayarHamleTimer.Tick += new EventHandler(bilgisayarHamleTimer_Tick);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            if (label.Text == "")
            {
                if (!bilgisayarHamleTimer.Enabled) 
                {
                    oynamasayisi++;

                    
                    label.Text = oyuncu;
                    label.Enabled = false;

                    
                    KazananiKontrolEt();

                    
                    if (oyuncu == "X" && oynamasayisi >= 1)
                    {
                        oyuncu = "O";
                       
                        bilgisayarHamleTimer.Start();

                
                        foreach (Control kontrol in Controls)
                        {
                            if (kontrol is Label)
                            {
                                kontrol.Enabled = false;
                            }
                        }
                    }
                    else
                    {
                        oyuncu = "X";
                    }
                }
            }
            

        }
        private void OyunuSifirla()
        {
            oyunvar=true;
            bilgisayarHamleTimer.Stop();
            oyuncu = "X";
            foreach (Control kontrol in Controls)
            {
                if (kontrol is Label)
                {
                    Label label = (Label)kontrol;
                    label.Text = "";
                    label.Enabled = true;
                }
            }



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

        private void BilgisayarHamlesiYap()
        {
            if (oyunvar)
            {
                Random random = new Random();
                List<Label> bosHuceler = new List<Label>();

                ////////////// Boş hücreleri bul
                foreach (Control kontrol in Controls)
                {
                    if (kontrol is Label)
                    {
                        Label label = (Label)kontrol;
                        if (label.Text == "")
                        {
                            bosHuceler.Add(label);
                        }
                    }
                }


                if (bosHuceler.Count > 0)
                {
                    int rastgeleIndex = random.Next(0, bosHuceler.Count);
                    bosHuceler[rastgeleIndex].Text = oyuncu;
                    bosHuceler[rastgeleIndex].Enabled = false;
                    oyuncu = "X";
                    oynamasayisi++;


                    KazananiKontrolEt();
                }
                /*else
                {
                    MessageBox.Show("Oyun berabere!");
                    OyunuSifirla();
                }*/
            }

        }

        private void KazananiKontrolEt()
        {

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
            else if (label1.Text + label2.Text + label3.Text == "OOO" ||
                    label4.Text + label5.Text + label6.Text == "OOO" ||
                    label7.Text + label8.Text + label9.Text == "OOO" ||
                    label2.Text + label5.Text + label8.Text == "OOO" ||
                    label3.Text + label6.Text + label9.Text == "OOO" ||
                    label1.Text + label4.Text + label7.Text == "OOO" ||
                    label1.Text + label5.Text + label9.Text == "OOO" ||
                    label3.Text + label5.Text + label7.Text == "OOO")
            {
                oyunvar = false;
                DialogResult result = MessageBox.Show("O Kazandı", "Uyarı", MessageBoxButtons.OK);
                if (result == DialogResult.OK)
                {
                   
                    OyunuSifirla();
                }
                
                
            }
            else if (oynamasayisi == 9)
            {
                MessageBox.Show("BERABERE");
                OyunuSifirla();
            }
        }

        private void bilgisayarHamleTimer_Tick(object sender, EventArgs e)
        {
          
            BilgisayarHamlesiYap();

          
            bilgisayarHamleTimer.Stop();

            
            foreach (Control kontrol in Controls)
            {
                if (kontrol is Label)
                {
                    kontrol.Enabled = true;
                }
            }
        }
    }
}
