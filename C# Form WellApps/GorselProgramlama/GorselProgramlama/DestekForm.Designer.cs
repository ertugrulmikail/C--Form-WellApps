namespace GorselProgramlama
{
    partial class DestekForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnYolla = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(90, 143);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(488, 247);
            this.textBox1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GorselProgramlama.Properties.Resources.x_button11;
            this.pictureBox1.Location = new System.Drawing.Point(594, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 43);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnYolla
            // 
            this.btnYolla.BackColor = System.Drawing.Color.Gray;
            this.btnYolla.FlatAppearance.BorderSize = 0;
            this.btnYolla.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnYolla.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYolla.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnYolla.Location = new System.Drawing.Point(260, 396);
            this.btnYolla.Name = "btnYolla";
            this.btnYolla.Size = new System.Drawing.Size(163, 65);
            this.btnYolla.TabIndex = 22;
            this.btnYolla.Text = "Yolla";
            this.btnYolla.UseVisualStyleBackColor = false;
            this.btnYolla.Click += new System.EventHandler(this.btnYolla_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(33, 490);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 32);
            this.label2.TabIndex = 43;
            this.label2.Text = "Yaşadığınız Sorunu Destek Birimlerine\r\n İletmek İçin Yazabilirsiniz.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(272, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 39);
            this.label1.TabIndex = 44;
            this.label1.Text = "DESTEK";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(395, 490);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(242, 32);
            this.label3.TabIndex = 45;
            this.label3.Text = "Sorunun Çözümü İçin E-Posta Adresinizi\r\n Kontrol Etmeyi Unutmayınız.";
            // 
            // DestekForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(106)))), ((int)(((byte)(90)))));
            this.ClientSize = new System.Drawing.Size(649, 550);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnYolla);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DestekForm";
            this.Text = "DestekForm";
            this.Load += new System.EventHandler(this.DestekForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnYolla;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}