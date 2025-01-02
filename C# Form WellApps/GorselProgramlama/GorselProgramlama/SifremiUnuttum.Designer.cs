namespace GorselProgramlama
{
    partial class SifremiUnuttum
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_Eposta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnKayit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.lbl_dakika = new System.Windows.Forms.Label();
            this.lbl_saniye = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelSure = new System.Windows.Forms.Label();
            this.labelNokta = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(456, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 50);
            this.button1.TabIndex = 41;
            this.button1.Text = "Giriş Ekranına Dön";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // txt_Eposta
            // 
            this.txt_Eposta.BackColor = System.Drawing.SystemColors.Menu;
            this.txt_Eposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Eposta.Location = new System.Drawing.Point(169, 193);
            this.txt_Eposta.Multiline = true;
            this.txt_Eposta.Name = "txt_Eposta";
            this.txt_Eposta.Size = new System.Drawing.Size(302, 36);
            this.txt_Eposta.TabIndex = 43;
            this.txt_Eposta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Eposta_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(152, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 39);
            this.label2.TabIndex = 42;
            this.label2.Text = "E-Posta";
            // 
            // btnKayit
            // 
            this.btnKayit.BackColor = System.Drawing.Color.Gray;
            this.btnKayit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKayit.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKayit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnKayit.Location = new System.Drawing.Point(491, 163);
            this.btnKayit.Name = "btnKayit";
            this.btnKayit.Size = new System.Drawing.Size(129, 83);
            this.btnKayit.TabIndex = 44;
            this.btnKayit.Text = "Kod Gönder";
            this.btnKayit.UseVisualStyleBackColor = false;
            this.btnKayit.Click += new System.EventHandler(this.btnKayit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GorselProgramlama.Properties.Resources.x_button11;
            this.pictureBox1.Location = new System.Drawing.Point(578, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 41);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gray;
            this.button2.Enabled = false;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(265, 248);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 83);
            this.button2.TabIndex = 45;
            this.button2.Text = "Kodu Onayla";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbl_dakika
            // 
            this.lbl_dakika.AutoSize = true;
            this.lbl_dakika.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_dakika.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_dakika.Location = new System.Drawing.Point(258, 80);
            this.lbl_dakika.Name = "lbl_dakika";
            this.lbl_dakika.Size = new System.Drawing.Size(34, 39);
            this.lbl_dakika.TabIndex = 46;
            this.lbl_dakika.Text = "3";
            this.lbl_dakika.Visible = false;
            // 
            // lbl_saniye
            // 
            this.lbl_saniye.AutoSize = true;
            this.lbl_saniye.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_saniye.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_saniye.Location = new System.Drawing.Point(298, 80);
            this.lbl_saniye.Name = "lbl_saniye";
            this.lbl_saniye.Size = new System.Drawing.Size(51, 39);
            this.lbl_saniye.TabIndex = 47;
            this.lbl_saniye.Text = "00";
            this.lbl_saniye.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelSure
            // 
            this.labelSure.AutoSize = true;
            this.labelSure.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSure.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelSure.Location = new System.Drawing.Point(236, 41);
            this.labelSure.Name = "labelSure";
            this.labelSure.Size = new System.Drawing.Size(158, 39);
            this.labelSure.TabIndex = 48;
            this.labelSure.Text = "Kalan Süre";
            this.labelSure.Visible = false;
            // 
            // labelNokta
            // 
            this.labelNokta.Font = new System.Drawing.Font("Impact", 22F);
            this.labelNokta.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelNokta.Location = new System.Drawing.Point(284, 80);
            this.labelNokta.Name = "labelNokta";
            this.labelNokta.Size = new System.Drawing.Size(20, 39);
            this.labelNokta.TabIndex = 49;
            this.labelNokta.Text = ":";
            this.labelNokta.Visible = false;
            // 
            // SifremiUnuttum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(654, 362);
            this.Controls.Add(this.labelNokta);
            this.Controls.Add(this.labelSure);
            this.Controls.Add(this.lbl_saniye);
            this.Controls.Add(this.lbl_dakika);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnKayit);
            this.Controls.Add(this.txt_Eposta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SifremiUnuttum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SifremiUnuttum";
            this.Load += new System.EventHandler(this.SifremiUnuttum_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_Eposta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnKayit;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbl_dakika;
        private System.Windows.Forms.Label lbl_saniye;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelSure;
        private System.Windows.Forms.Label labelNokta;
    }
}