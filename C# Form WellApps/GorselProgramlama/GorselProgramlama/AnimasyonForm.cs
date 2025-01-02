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
    public partial class AnimasyonForm : Form
    {
        public AnimasyonForm()
        {
            InitializeComponent();
        }
        bool s=false;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!s)
            {
                this.Opacity +=0.009;
            }
            if (this.Opacity == 1.0)
            {
                s= true;
            }
            if (s)
            {
                this.Opacity -= 0.009;
                if(this.Opacity == 0)
                {
                    giris giris = new giris();
                    giris.Show();
                    this.Hide();
                    timer1.Enabled = false;
                    
                }
            }
        }
    }
}
