namespace YonetimBilgiSistemleri
{
    partial class MusteriEkleme
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
            button1 = new Button();
            label3 = new Label();
            MusteriEkle = new Button();
            MusteriSil = new Button();
            MusteriGuncelle = new Button();
            SatirGetir = new Button();
            MusteriAdiSoyadi = new TextBox();
            TelefonNo = new TextBox();
            Eposta = new TextBox();
            CariAdi = new TextBox();
            VergiNo = new TextBox();
            TcNo = new TextBox();
            VergiDairesi = new TextBox();
            label2 = new Label();
            label4 = new Label();
            label6 = new Label();
            label8 = new Label();
            label1 = new Label();
            label9 = new Label();
            label5 = new Label();
            label11 = new Label();
            label7 = new Label();
            Adres = new RichTextBox();
            IbanBilgisi = new RichTextBox();
            MusterilerTablo = new DataGridView();
            txtGenelArama = new TextBox();
            label23 = new Label();
            ((System.ComponentModel.ISupportInitialize)MusterilerTablo).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.FromArgb(192, 0, 0);
            button1.FlatAppearance.BorderSize = 40;
            button1.FlatAppearance.MouseDownBackColor = Color.Red;
            button1.FlatAppearance.MouseOverBackColor = Color.Red;
            button1.Font = new Font("Segoe UI", 6.25F, FontStyle.Bold);
            button1.ForeColor = Color.Red;
            button1.Location = new Point(0, -1);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(25, 24);
            button1.TabIndex = 23;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label3.Location = new Point(26, -3);
            label3.Name = "label3";
            label3.Size = new Size(320, 30);
            label3.TabIndex = 0;
            label3.Text = "Yeni Müşteri Kaydı Oluşturma";
            // 
            // MusteriEkle
            // 
            MusteriEkle.Anchor = AnchorStyles.Left;
            MusteriEkle.BackColor = Color.Black;
            MusteriEkle.Cursor = Cursors.Hand;
            MusteriEkle.FlatAppearance.BorderColor = Color.White;
            MusteriEkle.FlatAppearance.BorderSize = 3;
            MusteriEkle.FlatAppearance.CheckedBackColor = Color.Gray;
            MusteriEkle.FlatAppearance.MouseDownBackColor = Color.Gray;
            MusteriEkle.FlatAppearance.MouseOverBackColor = Color.Gray;
            MusteriEkle.FlatStyle = FlatStyle.Flat;
            MusteriEkle.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            MusteriEkle.ForeColor = SystemColors.ButtonHighlight;
            MusteriEkle.Location = new Point(44, 552);
            MusteriEkle.Name = "MusteriEkle";
            MusteriEkle.Size = new Size(100, 40);
            MusteriEkle.TabIndex = 19;
            MusteriEkle.Text = "Ekle";
            MusteriEkle.UseVisualStyleBackColor = false;
            MusteriEkle.Click += MusteriEkle_Click;
            // 
            // MusteriSil
            // 
            MusteriSil.Anchor = AnchorStyles.Left;
            MusteriSil.BackColor = Color.Black;
            MusteriSil.Cursor = Cursors.Hand;
            MusteriSil.FlatAppearance.BorderColor = Color.White;
            MusteriSil.FlatAppearance.BorderSize = 3;
            MusteriSil.FlatAppearance.CheckedBackColor = Color.Gray;
            MusteriSil.FlatAppearance.MouseDownBackColor = Color.Gray;
            MusteriSil.FlatAppearance.MouseOverBackColor = Color.Gray;
            MusteriSil.FlatStyle = FlatStyle.Flat;
            MusteriSil.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            MusteriSil.ForeColor = SystemColors.ButtonHighlight;
            MusteriSil.Location = new Point(44, 509);
            MusteriSil.Name = "MusteriSil";
            MusteriSil.Size = new Size(100, 40);
            MusteriSil.TabIndex = 20;
            MusteriSil.Text = "Sil";
            MusteriSil.UseVisualStyleBackColor = false;
            MusteriSil.Click += MusteriSil_Click;
            // 
            // MusteriGuncelle
            // 
            MusteriGuncelle.Anchor = AnchorStyles.Left;
            MusteriGuncelle.BackColor = Color.Black;
            MusteriGuncelle.Cursor = Cursors.Hand;
            MusteriGuncelle.FlatAppearance.BorderColor = Color.White;
            MusteriGuncelle.FlatAppearance.BorderSize = 3;
            MusteriGuncelle.FlatAppearance.CheckedBackColor = Color.Gray;
            MusteriGuncelle.FlatAppearance.MouseDownBackColor = Color.Gray;
            MusteriGuncelle.FlatAppearance.MouseOverBackColor = Color.Gray;
            MusteriGuncelle.FlatStyle = FlatStyle.Flat;
            MusteriGuncelle.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            MusteriGuncelle.ForeColor = SystemColors.ButtonHighlight;
            MusteriGuncelle.Location = new Point(180, 509);
            MusteriGuncelle.Name = "MusteriGuncelle";
            MusteriGuncelle.Size = new Size(100, 40);
            MusteriGuncelle.TabIndex = 22;
            MusteriGuncelle.Text = "Güncelle";
            MusteriGuncelle.UseVisualStyleBackColor = false;
            MusteriGuncelle.Click += MusteriGuncelle_Click;
            // 
            // SatirGetir
            // 
            SatirGetir.Anchor = AnchorStyles.Left;
            SatirGetir.BackColor = Color.Black;
            SatirGetir.Cursor = Cursors.Hand;
            SatirGetir.FlatAppearance.BorderColor = Color.White;
            SatirGetir.FlatAppearance.BorderSize = 3;
            SatirGetir.FlatAppearance.CheckedBackColor = Color.Gray;
            SatirGetir.FlatAppearance.MouseDownBackColor = Color.Gray;
            SatirGetir.FlatAppearance.MouseOverBackColor = Color.Gray;
            SatirGetir.FlatStyle = FlatStyle.Flat;
            SatirGetir.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            SatirGetir.ForeColor = SystemColors.ButtonHighlight;
            SatirGetir.Location = new Point(180, 552);
            SatirGetir.Name = "SatirGetir";
            SatirGetir.Size = new Size(100, 40);
            SatirGetir.TabIndex = 21;
            SatirGetir.Text = "Satır Getir";
            SatirGetir.UseVisualStyleBackColor = false;
            SatirGetir.Click += SatirGetir_Click;
            // 
            // MusteriAdiSoyadi
            // 
            MusteriAdiSoyadi.Anchor = AnchorStyles.Left;
            MusteriAdiSoyadi.Location = new Point(21, 80);
            MusteriAdiSoyadi.Name = "MusteriAdiSoyadi";
            MusteriAdiSoyadi.Size = new Size(120, 23);
            MusteriAdiSoyadi.TabIndex = 10;
            // 
            // TelefonNo
            // 
            TelefonNo.Anchor = AnchorStyles.Left;
            TelefonNo.Location = new Point(21, 244);
            TelefonNo.MaxLength = 11;
            TelefonNo.Name = "TelefonNo";
            TelefonNo.Size = new Size(120, 23);
            TelefonNo.TabIndex = 12;
            // 
            // Eposta
            // 
            Eposta.Anchor = AnchorStyles.Left;
            Eposta.Location = new Point(21, 336);
            Eposta.Name = "Eposta";
            Eposta.Size = new Size(120, 23);
            Eposta.TabIndex = 13;
            // 
            // CariAdi
            // 
            CariAdi.Anchor = AnchorStyles.Left;
            CariAdi.Location = new Point(21, 167);
            CariAdi.Name = "CariAdi";
            CariAdi.Size = new Size(120, 23);
            CariAdi.TabIndex = 11;
            // 
            // VergiNo
            // 
            VergiNo.Anchor = AnchorStyles.Left;
            VergiNo.Location = new Point(178, 80);
            VergiNo.MaxLength = 10;
            VergiNo.Name = "VergiNo";
            VergiNo.Size = new Size(120, 23);
            VergiNo.TabIndex = 15;
            // 
            // TcNo
            // 
            TcNo.Anchor = AnchorStyles.Left;
            TcNo.Location = new Point(21, 426);
            TcNo.MaxLength = 11;
            TcNo.Name = "TcNo";
            TcNo.Size = new Size(120, 23);
            TcNo.TabIndex = 14;
            // 
            // VergiDairesi
            // 
            VergiDairesi.Anchor = AnchorStyles.Left;
            VergiDairesi.Location = new Point(178, 167);
            VergiDairesi.Name = "VergiDairesi";
            VergiDairesi.Size = new Size(120, 23);
            VergiDairesi.TabIndex = 16;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label2.Location = new Point(21, 60);
            label2.Name = "label2";
            label2.Size = new Size(125, 17);
            label2.TabIndex = 1;
            label2.Text = "Müşteri Adı Soyadı";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label4.Location = new Point(21, 224);
            label4.Name = "label4";
            label4.Size = new Size(54, 17);
            label4.TabIndex = 3;
            label4.Text = "Telefon";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label6.Location = new Point(179, 234);
            label6.Name = "label6";
            label6.Size = new Size(43, 17);
            label6.TabIndex = 8;
            label6.Text = "Adres";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Left;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label8.Location = new Point(179, 60);
            label8.Name = "label8";
            label8.Size = new Size(62, 17);
            label8.TabIndex = 6;
            label8.Text = "Vergi No";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label1.Location = new Point(179, 364);
            label1.Name = "label1";
            label1.Size = new Size(81, 17);
            label1.TabIndex = 9;
            label1.Text = "İBAN Bilgisi";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Left;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label9.Location = new Point(21, 406);
            label9.Name = "label9";
            label9.Size = new Size(43, 17);
            label9.TabIndex = 5;
            label9.Text = "Tc No";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label5.Location = new Point(21, 316);
            label5.Name = "label5";
            label5.Size = new Size(42, 17);
            label5.TabIndex = 4;
            label5.Text = "Email";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Left;
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label11.Location = new Point(21, 147);
            label11.Name = "label11";
            label11.Size = new Size(57, 17);
            label11.TabIndex = 2;
            label11.Text = "Cari Adı";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label7.Location = new Point(179, 147);
            label7.Name = "label7";
            label7.Size = new Size(87, 17);
            label7.TabIndex = 7;
            label7.Text = "Vergi Dairesi";
            // 
            // Adres
            // 
            Adres.Anchor = AnchorStyles.Left;
            Adres.Location = new Point(179, 254);
            Adres.Name = "Adres";
            Adres.Size = new Size(140, 65);
            Adres.TabIndex = 17;
            Adres.Text = "";
            // 
            // IbanBilgisi
            // 
            IbanBilgisi.Anchor = AnchorStyles.Left;
            IbanBilgisi.Location = new Point(179, 384);
            IbanBilgisi.Name = "IbanBilgisi";
            IbanBilgisi.Size = new Size(140, 65);
            IbanBilgisi.TabIndex = 18;
            IbanBilgisi.Text = "";
            // 
            // MusterilerTablo
            // 
            MusterilerTablo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            MusterilerTablo.Location = new Point(345, 35);
            MusterilerTablo.Name = "MusterilerTablo";
            MusterilerTablo.Size = new Size(900, 574);
            MusterilerTablo.TabIndex = 24;
            // 
            // txtGenelArama
            // 
            txtGenelArama.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtGenelArama.Location = new Point(442, 7);
            txtGenelArama.Name = "txtGenelArama";
            txtGenelArama.Size = new Size(120, 23);
            txtGenelArama.TabIndex = 58;
            txtGenelArama.TextChanged += txtGenelArama_TextChanged;
            // 
            // label23
            // 
            label23.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label23.Location = new Point(351, 9);
            label23.Name = "label23";
            label23.Size = new Size(85, 17);
            label23.TabIndex = 57;
            label23.Text = "Tabloda Bul:";
            // 
            // MusteriEkleme
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(1269, 621);
            Controls.Add(txtGenelArama);
            Controls.Add(label23);
            Controls.Add(MusterilerTablo);
            Controls.Add(label3);
            Controls.Add(IbanBilgisi);
            Controls.Add(button1);
            Controls.Add(Adres);
            Controls.Add(SatirGetir);
            Controls.Add(MusteriGuncelle);
            Controls.Add(MusteriSil);
            Controls.Add(MusteriEkle);
            Controls.Add(label7);
            Controls.Add(label11);
            Controls.Add(label5);
            Controls.Add(label9);
            Controls.Add(label1);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(VergiDairesi);
            Controls.Add(TcNo);
            Controls.Add(VergiNo);
            Controls.Add(CariAdi);
            Controls.Add(Eposta);
            Controls.Add(TelefonNo);
            Controls.Add(MusteriAdiSoyadi);
            Name = "MusteriEkleme";
            Text = "MÜŞTERİ OLUŞTURMA";
            Load += MusteriEkleme_Load;
            ((System.ComponentModel.ISupportInitialize)MusterilerTablo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Label label3;
        private Button MusteriEkle;
        private Button MusteriSil;
        private Button MusteriGuncelle;
        private Button SatirGetir;
        private TextBox MusteriAdiSoyadi;
        private TextBox TelefonNo;
        private TextBox Eposta;
        private TextBox CariAdi;
        private TextBox VergiNo;
        private TextBox TcNo;
        private TextBox VergiDairesi;
        private Label label2;
        private Label label4;
        private Label label6;
        private Label label8;
        private Label label1;
        private Label label9;
        private Label label5;
        private Label label11;
        private Label label7;
        private RichTextBox Adres;
        private RichTextBox IbanBilgisi;
        private DataGridView MusterilerTablo;
        private TextBox txtGenelArama;
        private Label label23;
    }
}