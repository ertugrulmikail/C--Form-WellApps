namespace GorselProgramlama
{
    partial class ucaksavasi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucaksavasi));
            this.skorYazi = new System.Windows.Forms.Label();
            this.oyunZaman = new System.Windows.Forms.Timer(this.components);
            this.oyuncu = new System.Windows.Forms.PictureBox();
            this.Mermi = new System.Windows.Forms.PictureBox();
            this.dusmanUc = new System.Windows.Forms.PictureBox();
            this.dusmaniki = new System.Windows.Forms.PictureBox();
            this.dusmanBir = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.anaekran_Btn = new System.Windows.Forms.Button();
            this.basla_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.oyuncu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mermi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dusmanUc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dusmaniki)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dusmanBir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // skorYazi
            // 
            this.skorYazi.BackColor = System.Drawing.Color.Transparent;
            this.skorYazi.Font = new System.Drawing.Font("Futura Book", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skorYazi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.skorYazi.Location = new System.Drawing.Point(12, 227);
            this.skorYazi.Name = "skorYazi";
            this.skorYazi.Size = new System.Drawing.Size(910, 108);
            this.skorYazi.TabIndex = 5;
            this.skorYazi.Text = "0";
            this.skorYazi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // oyunZaman
            // 
            this.oyunZaman.Interval = 20;
            this.oyunZaman.Tick += new System.EventHandler(this.anaOyunZamanlayiciOlay);
            // 
            // oyuncu
            // 
            this.oyuncu.BackColor = System.Drawing.Color.Transparent;
            this.oyuncu.Image = global::GorselProgramlama.Properties.Resources.Adsız;
            this.oyuncu.Location = new System.Drawing.Point(417, 458);
            this.oyuncu.Name = "oyuncu";
            this.oyuncu.Size = new System.Drawing.Size(100, 120);
            this.oyuncu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.oyuncu.TabIndex = 4;
            this.oyuncu.TabStop = false;
            // 
            // Mermi
            // 
            this.Mermi.BackColor = System.Drawing.Color.Transparent;
            this.Mermi.Image = global::GorselProgramlama.Properties.Resources.Bullet_PNG_Pic;
            this.Mermi.Location = new System.Drawing.Point(465, 351);
            this.Mermi.Name = "Mermi";
            this.Mermi.Size = new System.Drawing.Size(23, 50);
            this.Mermi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Mermi.TabIndex = 3;
            this.Mermi.TabStop = false;
            // 
            // dusmanUc
            // 
            this.dusmanUc.BackColor = System.Drawing.Color.Transparent;
            this.dusmanUc.Image = global::GorselProgramlama.Properties.Resources.dusman3;
            this.dusmanUc.Location = new System.Drawing.Point(697, 39);
            this.dusmanUc.Name = "dusmanUc";
            this.dusmanUc.Size = new System.Drawing.Size(138, 105);
            this.dusmanUc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dusmanUc.TabIndex = 2;
            this.dusmanUc.TabStop = false;
            // 
            // dusmaniki
            // 
            this.dusmaniki.BackColor = System.Drawing.Color.Transparent;
            this.dusmaniki.Image = global::GorselProgramlama.Properties.Resources.dusman2;
            this.dusmaniki.Location = new System.Drawing.Point(381, 39);
            this.dusmaniki.Name = "dusmaniki";
            this.dusmaniki.Size = new System.Drawing.Size(119, 105);
            this.dusmaniki.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dusmaniki.TabIndex = 1;
            this.dusmaniki.TabStop = false;
            // 
            // dusmanBir
            // 
            this.dusmanBir.BackColor = System.Drawing.Color.Transparent;
            this.dusmanBir.Image = global::GorselProgramlama.Properties.Resources.dusman;
            this.dusmanBir.Location = new System.Drawing.Point(54, 39);
            this.dusmanBir.Name = "dusmanBir";
            this.dusmanBir.Size = new System.Drawing.Size(119, 105);
            this.dusmanBir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dusmanBir.TabIndex = 0;
            this.dusmanBir.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GorselProgramlama.Properties.Resources.close1;
            this.pictureBox1.Location = new System.Drawing.Point(892, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // anaekran_Btn
            // 
            this.anaekran_Btn.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.anaekran_Btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.anaekran_Btn.Location = new System.Drawing.Point(17, 492);
            this.anaekran_Btn.Name = "anaekran_Btn";
            this.anaekran_Btn.Size = new System.Drawing.Size(108, 61);
            this.anaekran_Btn.TabIndex = 36;
            this.anaekran_Btn.TabStop = false;
            this.anaekran_Btn.Text = "ANA EKRAN";
            this.anaekran_Btn.UseVisualStyleBackColor = true;
            this.anaekran_Btn.Visible = false;
            this.anaekran_Btn.Click += new System.EventHandler(this.anaekran_Btn_Click);
            // 
            // basla_btn
            // 
            this.basla_btn.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.basla_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.basla_btn.Location = new System.Drawing.Point(17, 425);
            this.basla_btn.Name = "basla_btn";
            this.basla_btn.Size = new System.Drawing.Size(108, 61);
            this.basla_btn.TabIndex = 38;
            this.basla_btn.TabStop = false;
            this.basla_btn.Text = "Yeniden Başla";
            this.basla_btn.UseVisualStyleBackColor = true;
            this.basla_btn.Visible = false;
            this.basla_btn.Click += new System.EventHandler(this.basla_btn_Click);
            // 
            // ucaksavasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.BackgroundImage = global::GorselProgramlama.Properties.Resources.arkapln1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(934, 590);
            this.Controls.Add(this.basla_btn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.anaekran_Btn);
            this.Controls.Add(this.oyuncu);
            this.Controls.Add(this.Mermi);
            this.Controls.Add(this.dusmanUc);
            this.Controls.Add(this.dusmaniki);
            this.Controls.Add(this.dusmanBir);
            this.Controls.Add(this.skorYazi);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ucaksavasi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ucaksavasi_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.asagi_yonu_tus);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.yukari_yonu_tus);
            ((System.ComponentModel.ISupportInitialize)(this.oyuncu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mermi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dusmanUc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dusmaniki)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dusmanBir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox dusmanBir;
        private System.Windows.Forms.PictureBox dusmaniki;
        private System.Windows.Forms.PictureBox dusmanUc;
        private System.Windows.Forms.PictureBox Mermi;
        private System.Windows.Forms.PictureBox oyuncu;
        private System.Windows.Forms.Label skorYazi;
        private System.Windows.Forms.Timer oyunZaman;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button anaekran_Btn;
        private System.Windows.Forms.Button basla_btn;
    }
}