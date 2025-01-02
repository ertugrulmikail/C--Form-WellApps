using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GorselProgramlama;

namespace HesapMakinesi
{
    public partial class hesapmakinesi_form : Form
    {
        bool operatorDurum = false;
        double sonuc;
        string eskiOperator = " ";


        public hesapmakinesi_form()
        {
            InitializeComponent();

        }

        private void RakamOlay(object sender, EventArgs e)
        {

            if (operatorDurum)
            {
                textBox.Clear();
            }
            operatorDurum = false;
            Button btn = (Button)sender;
            textBox.Text += btn.Text;
        }

        private void OperatorIslem(object sender, EventArgs e)
        {
            operatorDurum = true;
            Button btn = (Button)sender;
            string yeniOperator = btn.Text;


            textBox1.Text = textBox1.Text + " " + textBox.Text + " " + yeniOperator;
            if (textBox.Text != "")
            {
                switch (eskiOperator)
                {
                    case "+": textBox.Text = (sonuc + Double.Parse(textBox.Text)).ToString(); break;
                    case "-": textBox.Text = (sonuc - Double.Parse(textBox.Text)).ToString(); break;
                    case "/": textBox.Text = (sonuc / Double.Parse(textBox.Text)).ToString(); break;
                    case "x": textBox.Text = (sonuc * Double.Parse(textBox.Text)).ToString(); break;
                    case "log": textBox.Text = Math.Log10(Double.Parse(textBox.Text)).ToString(); break;
                    case "Mod": textBox.Text = (sonuc % Double.Parse(textBox.Text)).ToString(); break;
                    case "^": textBox.Text = Math.Pow(sonuc, Double.Parse(textBox.Text)).ToString(); break;
                    case "=": textBox.Text = (Double.Parse(textBox.Text)).ToString(); break;
                }

                sonuc = Double.Parse(textBox.Text);
                textBox.Text = sonuc.ToString();
                eskiOperator = yeniOperator;
            }
            else textBox.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void eSayisi_Click(object sender, EventArgs e)
        {
            double eSayisi = 2.71828;
            double sayi;
            if (textBox.Text != "")
            {

                sayi = Double.Parse(textBox.Text);
                sonuc = sayi * eSayisi;

                textBox.Text = sonuc.ToString();

            }
            else
                textBox.Text = eSayisi.ToString();
            textBox1.Text = "e";


        }

        private void Button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            if (textBox.Text != "")
            {
                sonuc = Convert.ToDouble(textBox.Text);
                textBox.Text = Convert.ToString(sonuc);
                textBox1.Text = textBox.Text;
            }
            else
                textBox.Text = "";


        }




        private void VirgulButonu_Click(object sender, EventArgs e)
        {
            if (textBox.Text != "")
            {
                textBox.Text = (Double.Parse(textBox.Text) + ",").ToString();
            }
            else
                textBox.Text = "";

        }



        private void SinButonu_Click(object sender, EventArgs e)
        {
            if (textBox.Text != "")
            {
                double sinDegeri;
                sinDegeri = Convert.ToDouble(textBox.Text);
                double radyanSin = (sinDegeri * (Math.PI)) / 180;
                radyanSin = Math.Sin(radyanSin);
                textBox.Text = Convert.ToString(radyanSin);
            }
            else
                textBox.Text = "";


        }

        private void TanButonu_Click(object sender, EventArgs e)
        {
            if (textBox.Text != "")
            {
                double tanDegeri;
                tanDegeri = Convert.ToDouble(textBox.Text);
                double radyanTan = (tanDegeri * (Math.PI)) / 180;
                radyanTan = Math.Tan(radyanTan);
                textBox.Text = Convert.ToString(radyanTan);
            }
            else
                textBox.Text = "";
        }

        private void CEButonu_Click(object sender, EventArgs e)
        {
            textBox.Text = "";

        }

        private void C_Butonu_Click(object sender, EventArgs e)
        {
            textBox.Text = "";
            textBox1.Text = "";
            eskiOperator = "";
            sonuc = 0;
            operatorDurum = false;

        }



        private void FaktoriyelButonu_Click(object sender, EventArgs e)
        {
            sonuc = 1;
            int fDegeri;
            if (textBox.Text != "")
            {
                fDegeri = Convert.ToInt32(textBox.Text);

                for (int i = 1; i <= fDegeri; i++)
                {
                    sonuc *= i;
                }
                textBox1.Text = fDegeri + "!" + "=" + sonuc.ToString();
                textBox.Text = sonuc.ToString();
            }
            else
                textBox.Text = "";
        }

        private void CosButonu_Click(object sender, EventArgs e)
        {
            if (textBox.Text != "")
            {
                double cosDegeri;
                cosDegeri = Convert.ToDouble(textBox.Text);
                double radyanCos = (cosDegeri * (Math.PI)) / 180;
                radyanCos = Math.Cos(radyanCos);
                textBox.Text = Convert.ToString(radyanCos);
            }
            else
                textBox.Text = "";
        }

        private void XKareButon_Click(object sender, EventArgs e)
        {
            if (textBox.Text != "")
            {
                double sayi;
                sayi = Convert.ToDouble(textBox.Text);
                sonuc = sayi * sayi;
                textBox.Text = Convert.ToString(sonuc);
            }
            else
                textBox.Text = "";
        }

        private void PiSayisiButon_Click(object sender, EventArgs e)
        {
            double Pi = 3.14159;
            double sayi;
            if (textBox.Text != "")
            {

                sayi = Double.Parse(textBox.Text);
                sonuc = sayi * Pi;

                textBox.Text = sonuc.ToString();

            }
            else
                textBox.Text = Pi.ToString();
            textBox1.Text = "π";
        }



        private void KarekokButonu_Click(object sender, EventArgs e)
        {
            if (textBox.Text != "")
            {
                textBox1.Text = "√" + textBox.Text;
                double sayi;
                sayi = Convert.ToDouble(textBox.Text);
                sayi = Math.Sqrt(sayi);
                textBox.Text = Convert.ToString(sayi);
            }
            else
                textBox.Text = "";
        }

        private void Label1_Click(object sender, EventArgs e)
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
            if (Cikis == DialogResult.No)
            {

            }
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
    }
}
