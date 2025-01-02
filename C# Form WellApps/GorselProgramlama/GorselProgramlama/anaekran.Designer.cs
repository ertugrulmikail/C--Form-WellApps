namespace GorselProgramlama
{
    partial class anaekran
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(anaekran));
            this.panelUygulamalar = new System.Windows.Forms.Panel();
            this.btnDigerUygulamalar = new System.Windows.Forms.Button();
            this.btnOyunlar = new System.Windows.Forms.Button();
            this.btnUygulamalar = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panelAyarlar = new System.Windows.Forms.Panel();
            this.btn_destek = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnAyarlar = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panelEkran = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelUygulamalar.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panelAyarlar.SuspendLayout();
            this.panelEkran.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelUygulamalar
            // 
            this.panelUygulamalar.Controls.Add(this.btnDigerUygulamalar);
            this.panelUygulamalar.Controls.Add(this.btnOyunlar);
            this.panelUygulamalar.Controls.Add(this.btnUygulamalar);
            this.panelUygulamalar.Location = new System.Drawing.Point(3, 143);
            this.panelUygulamalar.MaximumSize = new System.Drawing.Size(255, 132);
            this.panelUygulamalar.MinimumSize = new System.Drawing.Size(255, 58);
            this.panelUygulamalar.Name = "panelUygulamalar";
            this.panelUygulamalar.Size = new System.Drawing.Size(255, 58);
            this.panelUygulamalar.TabIndex = 16;
            // 
            // btnDigerUygulamalar
            // 
            this.btnDigerUygulamalar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnDigerUygulamalar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDigerUygulamalar.FlatAppearance.BorderSize = 0;
            this.btnDigerUygulamalar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDigerUygulamalar.Font = new System.Drawing.Font("Haettenschweiler", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDigerUygulamalar.ForeColor = System.Drawing.Color.White;
            this.btnDigerUygulamalar.Location = new System.Drawing.Point(0, 95);
            this.btnDigerUygulamalar.Name = "btnDigerUygulamalar";
            this.btnDigerUygulamalar.Size = new System.Drawing.Size(255, 37);
            this.btnDigerUygulamalar.TabIndex = 22;
            this.btnDigerUygulamalar.Text = "DİĞER UYGULAMALAR";
            this.btnDigerUygulamalar.UseVisualStyleBackColor = false;
            this.btnDigerUygulamalar.Click += new System.EventHandler(this.btnDigerUygulamalar_Click);
            // 
            // btnOyunlar
            // 
            this.btnOyunlar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnOyunlar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOyunlar.FlatAppearance.BorderSize = 0;
            this.btnOyunlar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOyunlar.Font = new System.Drawing.Font("Haettenschweiler", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOyunlar.ForeColor = System.Drawing.Color.White;
            this.btnOyunlar.Location = new System.Drawing.Point(0, 58);
            this.btnOyunlar.Name = "btnOyunlar";
            this.btnOyunlar.Size = new System.Drawing.Size(255, 37);
            this.btnOyunlar.TabIndex = 21;
            this.btnOyunlar.Text = "OYUNLAR";
            this.btnOyunlar.UseVisualStyleBackColor = false;
            this.btnOyunlar.Click += new System.EventHandler(this.btnOyunlar_Click);
            // 
            // btnUygulamalar
            // 
            this.btnUygulamalar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUygulamalar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUygulamalar.FlatAppearance.BorderSize = 0;
            this.btnUygulamalar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUygulamalar.Font = new System.Drawing.Font("Haettenschweiler", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUygulamalar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnUygulamalar.Location = new System.Drawing.Point(0, 0);
            this.btnUygulamalar.Name = "btnUygulamalar";
            this.btnUygulamalar.Size = new System.Drawing.Size(255, 58);
            this.btnUygulamalar.TabIndex = 20;
            this.btnUygulamalar.Text = "UYGULAMALAR";
            this.btnUygulamalar.UseVisualStyleBackColor = false;
            this.btnUygulamalar.Click += new System.EventHandler(this.btnUygulamalar_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.flowLayoutPanel1.Controls.Add(this.pictureBox2);
            this.flowLayoutPanel1.Controls.Add(this.panelUygulamalar);
            this.flowLayoutPanel1.Controls.Add(this.panelAyarlar);
            this.flowLayoutPanel1.Controls.Add(this.btnCikis);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(263, 550);
            this.flowLayoutPanel1.TabIndex = 18;
            // 
            // panelAyarlar
            // 
            this.panelAyarlar.Controls.Add(this.btn_destek);
            this.panelAyarlar.Controls.Add(this.button2);
            this.panelAyarlar.Controls.Add(this.btnAyarlar);
            this.panelAyarlar.Location = new System.Drawing.Point(3, 207);
            this.panelAyarlar.MaximumSize = new System.Drawing.Size(255, 133);
            this.panelAyarlar.MinimumSize = new System.Drawing.Size(255, 55);
            this.panelAyarlar.Name = "panelAyarlar";
            this.panelAyarlar.Size = new System.Drawing.Size(255, 55);
            this.panelAyarlar.TabIndex = 23;
            // 
            // btn_destek
            // 
            this.btn_destek.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_destek.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_destek.FlatAppearance.BorderSize = 0;
            this.btn_destek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_destek.Font = new System.Drawing.Font("Haettenschweiler", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_destek.ForeColor = System.Drawing.Color.White;
            this.btn_destek.Location = new System.Drawing.Point(0, 95);
            this.btn_destek.Name = "btn_destek";
            this.btn_destek.Size = new System.Drawing.Size(255, 37);
            this.btn_destek.TabIndex = 22;
            this.btn_destek.Text = "DESTEK";
            this.btn_destek.UseVisualStyleBackColor = false;
            this.btn_destek.Click += new System.EventHandler(this.btn_destek_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Haettenschweiler", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(0, 58);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(255, 37);
            this.button2.TabIndex = 21;
            this.button2.Text = "ŞİFRE DEĞİŞTİR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAyarlar
            // 
            this.btnAyarlar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAyarlar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAyarlar.FlatAppearance.BorderSize = 0;
            this.btnAyarlar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAyarlar.Font = new System.Drawing.Font("Haettenschweiler", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAyarlar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAyarlar.Location = new System.Drawing.Point(0, 0);
            this.btnAyarlar.Name = "btnAyarlar";
            this.btnAyarlar.Size = new System.Drawing.Size(255, 58);
            this.btnAyarlar.TabIndex = 20;
            this.btnAyarlar.Text = "AYARLAR";
            this.btnAyarlar.UseVisualStyleBackColor = false;
            this.btnAyarlar.Click += new System.EventHandler(this.btnAyarlar_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(85)))));
            this.btnCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCikis.FlatAppearance.BorderSize = 0;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikis.Font = new System.Drawing.Font("Haettenschweiler", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCikis.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCikis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCikis.Location = new System.Drawing.Point(3, 268);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(255, 58);
            this.btnCikis.TabIndex = 20;
            this.btnCikis.Text = "ÇIKIŞ YAP";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Haettenschweiler", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(31, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 34);
            this.label1.TabIndex = 24;
            this.label1.Text = "Hoşgeldiniz";
            // 
            // timer1
            // 
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 15;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // panelEkran
            // 
            this.panelEkran.Controls.Add(this.pictureBox1);
            this.panelEkran.Controls.Add(this.label1);
            this.panelEkran.Location = new System.Drawing.Point(264, 0);
            this.panelEkran.Name = "panelEkran";
            this.panelEkran.Size = new System.Drawing.Size(649, 550);
            this.panelEkran.TabIndex = 20;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::GorselProgramlama.Properties.Resources.x_button;
            this.pictureBox1.Location = new System.Drawing.Point(596, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GorselProgramlama.Properties.Resources.sonhaltemiz;
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(260, 134);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // anaekran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(913, 550);
            this.Controls.Add(this.panelEkran);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "anaekran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Ekran";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelUygulamalar.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panelAyarlar.ResumeLayout(false);
            this.panelEkran.ResumeLayout(false);
            this.panelEkran.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelUygulamalar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnDigerUygulamalar;
        private System.Windows.Forms.Button btnOyunlar;
        private System.Windows.Forms.Button btnUygulamalar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panelAyarlar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnAyarlar;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Panel panelEkran;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btn_destek;
        private System.Windows.Forms.Label label1;
    }
}

