namespace RehberApp
{
    partial class Form1
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
            this.lbKisiler = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbCinsiyet = new System.Windows.Forms.ComboBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.btnYeni = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbKisiler
            // 
            this.lbKisiler.FormattingEnabled = true;
            this.lbKisiler.Location = new System.Drawing.Point(13, 78);
            this.lbKisiler.Name = "lbKisiler";
            this.lbKisiler.Size = new System.Drawing.Size(120, 368);
            this.lbKisiler.TabIndex = 0;
            this.lbKisiler.SelectedIndexChanged += new System.EventHandler(this.lbKisiler_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Tomato;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(12, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kişilerim";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(106, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Rehber Uygulaması\r\n";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(103, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(359, 53);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(15, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(82, 58);
            this.panel2.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RehberApp.Properties.Resources.rehber_ikon;
            this.pictureBox1.Location = new System.Drawing.Point(3, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // cbCinsiyet
            // 
            this.cbCinsiyet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCinsiyet.FormattingEnabled = true;
            this.cbCinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cbCinsiyet.Location = new System.Drawing.Point(325, 148);
            this.cbCinsiyet.Name = "cbCinsiyet";
            this.cbCinsiyet.Size = new System.Drawing.Size(121, 21);
            this.cbCinsiyet.TabIndex = 5;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(325, 78);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(121, 20);
            this.txtAd.TabIndex = 6;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(325, 112);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(121, 20);
            this.txtSoyad.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(140, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(139, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Soyad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(139, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Cinsiyet";
            // 
            // dtDogumTarihi
            // 
            this.dtDogumTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDogumTarihi.Location = new System.Drawing.Point(325, 191);
            this.dtDogumTarihi.Name = "dtDogumTarihi";
            this.dtDogumTarihi.Size = new System.Drawing.Size(121, 20);
            this.dtDogumTarihi.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(139, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Doğum Tarihi";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(325, 232);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(121, 20);
            this.txtTel.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(139, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Telefon";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(140, 275);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Adres";
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(325, 275);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(121, 55);
            this.txtAdres.TabIndex = 16;
            // 
            // btnYeni
            // 
            this.btnYeni.BackColor = System.Drawing.Color.YellowGreen;
            this.btnYeni.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnYeni.Location = new System.Drawing.Point(145, 383);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(75, 23);
            this.btnYeni.TabIndex = 17;
            this.btnYeni.Text = "Yeni";
            this.btnYeni.UseVisualStyleBackColor = false;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Red;
            this.btnSil.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSil.Location = new System.Drawing.Point(325, 383);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(47, 23);
            this.btnSil.TabIndex = 18;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnGuncelle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGuncelle.Location = new System.Drawing.Point(378, 383);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(67, 23);
            this.btnGuncelle.TabIndex = 19;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Violet;
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label9.Location = new System.Drawing.Point(149, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(313, 14);
            this.label9.TabIndex = 20;
            this.label9.Text = "Kişi Detayları:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnYeni);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtDogumTarihi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.cbCinsiyet);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbKisiler);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbKisiler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbCinsiyet;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtDogumTarihi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Label label9;
    }
}

