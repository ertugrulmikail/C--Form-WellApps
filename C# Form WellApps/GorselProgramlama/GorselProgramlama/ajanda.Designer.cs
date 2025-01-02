namespace GorselProgramlama
{
    partial class ajanda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ajanda));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.lstAjanda = new System.Windows.Forms.ListBox();
            this.txtOlayAdi = new System.Windows.Forms.TextBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.anaekran_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(43, 36);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 0;
            this.monthCalendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar_DateSelected);
            // 
            // lstAjanda
            // 
            this.lstAjanda.FormattingEnabled = true;
            this.lstAjanda.Location = new System.Drawing.Point(250, 19);
            this.lstAjanda.Name = "lstAjanda";
            this.lstAjanda.Size = new System.Drawing.Size(332, 173);
            this.lstAjanda.TabIndex = 3;
            this.lstAjanda.SelectedIndexChanged += new System.EventHandler(this.lstAjanda_SelectedIndexChanged);
            // 
            // txtOlayAdi
            // 
            this.txtOlayAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOlayAdi.Location = new System.Drawing.Point(30, 65);
            this.txtOlayAdi.Multiline = true;
            this.txtOlayAdi.Name = "txtOlayAdi";
            this.txtOlayAdi.Size = new System.Drawing.Size(391, 49);
            this.txtOlayAdi.TabIndex = 4;
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Lavender;
            this.btnSil.Font = new System.Drawing.Font("Ebrima", 24F, System.Drawing.FontStyle.Bold);
            this.btnSil.Location = new System.Drawing.Point(213, 133);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(99, 57);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.Lavender;
            this.btnEkle.Font = new System.Drawing.Font("Ebrima", 24F, System.Drawing.FontStyle.Bold);
            this.btnEkle.Location = new System.Drawing.Point(86, 133);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(107, 57);
            this.btnEkle.TabIndex = 1;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.lstAjanda);
            this.panel1.Location = new System.Drawing.Point(-8, 227);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(850, 249);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.anaekran_btn);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.monthCalendar);
            this.panel2.Location = new System.Drawing.Point(427, -7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(415, 238);
            this.panel2.TabIndex = 6;
            // 
            // anaekran_btn
            // 
            this.anaekran_btn.BackColor = System.Drawing.Color.Crimson;
            this.anaekran_btn.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.anaekran_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.anaekran_btn.Location = new System.Drawing.Point(344, 63);
            this.anaekran_btn.Name = "anaekran_btn";
            this.anaekran_btn.Size = new System.Drawing.Size(47, 46);
            this.anaekran_btn.TabIndex = 37;
            this.anaekran_btn.Text = "ANA EKRAN";
            this.anaekran_btn.UseVisualStyleBackColor = false;
            this.anaekran_btn.Click += new System.EventHandler(this.anaekran_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GorselProgramlama.Properties.Resources.close1;
            this.pictureBox1.Location = new System.Drawing.Point(361, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(34, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 39);
            this.label1.TabIndex = 9;
            this.label1.Text = "Olay";
            // 
            // ajanda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(830, 472);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOlayAdi);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ajanda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ajanda";
            this.Load += new System.EventHandler(this.ajanda_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.ListBox lstAjanda;
        private System.Windows.Forms.TextBox txtOlayAdi;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button anaekran_btn;
        private System.Windows.Forms.Label label1;
    }
}