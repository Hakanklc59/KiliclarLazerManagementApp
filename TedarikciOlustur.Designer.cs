namespace YonetimBilgiSistemleri
{
    partial class TedarikciOlustur
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
            SatirGetir = new Button();
            TedarikciTablo = new DataGridView();
            Guncelle = new Button();
            Sil = new Button();
            Ekle = new Button();
            label7 = new Label();
            label11 = new Label();
            label5 = new Label();
            label9 = new Label();
            label8 = new Label();
            label6 = new Label();
            label4 = new Label();
            label2 = new Label();
            VergiDairesi = new TextBox();
            TcNo = new TextBox();
            VergiNo = new TextBox();
            CariAdi = new TextBox();
            Eposta = new TextBox();
            TelefonNo = new TextBox();
            TedarikciAdiSoyadi = new TextBox();
            Adres = new RichTextBox();
            button1 = new Button();
            IbanBilgisi = new RichTextBox();
            label1 = new Label();
            label3 = new Label();
            txtGenelArama = new TextBox();
            label23 = new Label();
            ((System.ComponentModel.ISupportInitialize)TedarikciTablo).BeginInit();
            SuspendLayout();
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
            SatirGetir.Location = new Point(180, 553);
            SatirGetir.Name = "SatirGetir";
            SatirGetir.Size = new Size(100, 40);
            SatirGetir.TabIndex = 21;
            SatirGetir.Text = "Satır Getir";
            SatirGetir.UseVisualStyleBackColor = false;
            SatirGetir.Click += SatirGetir_Click;
            // 
            // TedarikciTablo
            // 
            TedarikciTablo.AllowUserToOrderColumns = true;
            TedarikciTablo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TedarikciTablo.Location = new Point(345, 35);
            TedarikciTablo.Name = "TedarikciTablo";
            TedarikciTablo.Size = new Size(900, 574);
            TedarikciTablo.TabIndex = 24;
            TedarikciTablo.SelectionChanged += TedarikciTablo_SelectionChanged;
            // 
            // Guncelle
            // 
            Guncelle.Anchor = AnchorStyles.Left;
            Guncelle.BackColor = Color.Black;
            Guncelle.Cursor = Cursors.Hand;
            Guncelle.FlatAppearance.BorderColor = Color.White;
            Guncelle.FlatAppearance.BorderSize = 3;
            Guncelle.FlatAppearance.CheckedBackColor = Color.Gray;
            Guncelle.FlatAppearance.MouseDownBackColor = Color.Gray;
            Guncelle.FlatAppearance.MouseOverBackColor = Color.Gray;
            Guncelle.FlatStyle = FlatStyle.Flat;
            Guncelle.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            Guncelle.ForeColor = SystemColors.ButtonHighlight;
            Guncelle.Location = new Point(180, 509);
            Guncelle.Name = "Guncelle";
            Guncelle.Size = new Size(100, 40);
            Guncelle.TabIndex = 22;
            Guncelle.Text = "Güncelle";
            Guncelle.UseVisualStyleBackColor = false;
            Guncelle.Click += Guncelle_Click;
            // 
            // Sil
            // 
            Sil.Anchor = AnchorStyles.Left;
            Sil.BackColor = Color.Black;
            Sil.Cursor = Cursors.Hand;
            Sil.FlatAppearance.BorderColor = Color.White;
            Sil.FlatAppearance.BorderSize = 3;
            Sil.FlatAppearance.CheckedBackColor = Color.Gray;
            Sil.FlatAppearance.MouseDownBackColor = Color.Gray;
            Sil.FlatAppearance.MouseOverBackColor = Color.Gray;
            Sil.FlatStyle = FlatStyle.Flat;
            Sil.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            Sil.ForeColor = SystemColors.ButtonHighlight;
            Sil.Location = new Point(44, 509);
            Sil.Name = "Sil";
            Sil.Size = new Size(100, 40);
            Sil.TabIndex = 20;
            Sil.Text = "Sil";
            Sil.UseVisualStyleBackColor = false;
            Sil.Click += Sil_Click;
            // 
            // Ekle
            // 
            Ekle.Anchor = AnchorStyles.Left;
            Ekle.BackColor = Color.Black;
            Ekle.Cursor = Cursors.Hand;
            Ekle.FlatAppearance.BorderColor = Color.White;
            Ekle.FlatAppearance.BorderSize = 3;
            Ekle.FlatAppearance.CheckedBackColor = Color.Gray;
            Ekle.FlatAppearance.MouseDownBackColor = Color.Gray;
            Ekle.FlatAppearance.MouseOverBackColor = Color.Gray;
            Ekle.FlatStyle = FlatStyle.Flat;
            Ekle.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            Ekle.ForeColor = SystemColors.ButtonHighlight;
            Ekle.Location = new Point(44, 553);
            Ekle.Name = "Ekle";
            Ekle.Size = new Size(100, 40);
            Ekle.TabIndex = 19;
            Ekle.Text = "Ekle";
            Ekle.UseVisualStyleBackColor = false;
            Ekle.Click += Ekle_Click;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label7.Location = new Point(178, 147);
            label7.Name = "label7";
            label7.Size = new Size(87, 17);
            label7.TabIndex = 7;
            label7.Text = "Vergi Dairesi";
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
            // label9
            // 
            label9.Anchor = AnchorStyles.Left;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label9.Location = new Point(22, 406);
            label9.Name = "label9";
            label9.Size = new Size(43, 17);
            label9.TabIndex = 5;
            label9.Text = "Tc No";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Left;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label8.Location = new Point(178, 60);
            label8.Name = "label8";
            label8.Size = new Size(62, 17);
            label8.TabIndex = 6;
            label8.Text = "Vergi No";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label6.Location = new Point(178, 237);
            label6.Name = "label6";
            label6.Size = new Size(43, 17);
            label6.TabIndex = 8;
            label6.Text = "Adres";
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
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label2.Location = new Point(21, 60);
            label2.Name = "label2";
            label2.Size = new Size(133, 17);
            label2.TabIndex = 1;
            label2.Text = "Tedarikçi Adı Soyadı";
            // 
            // VergiDairesi
            // 
            VergiDairesi.Anchor = AnchorStyles.Left;
            VergiDairesi.Location = new Point(178, 167);
            VergiDairesi.Name = "VergiDairesi";
            VergiDairesi.Size = new Size(120, 23);
            VergiDairesi.TabIndex = 16;
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
            // VergiNo
            // 
            VergiNo.Anchor = AnchorStyles.Left;
            VergiNo.Location = new Point(178, 80);
            VergiNo.MaxLength = 10;
            VergiNo.Name = "VergiNo";
            VergiNo.Size = new Size(120, 23);
            VergiNo.TabIndex = 15;
            // 
            // CariAdi
            // 
            CariAdi.Anchor = AnchorStyles.Left;
            CariAdi.Location = new Point(21, 167);
            CariAdi.Name = "CariAdi";
            CariAdi.Size = new Size(120, 23);
            CariAdi.TabIndex = 11;
            // 
            // Eposta
            // 
            Eposta.Anchor = AnchorStyles.Left;
            Eposta.Location = new Point(21, 336);
            Eposta.Name = "Eposta";
            Eposta.Size = new Size(120, 23);
            Eposta.TabIndex = 13;
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
            // TedarikciAdiSoyadi
            // 
            TedarikciAdiSoyadi.Anchor = AnchorStyles.Left;
            TedarikciAdiSoyadi.Location = new Point(21, 80);
            TedarikciAdiSoyadi.Name = "TedarikciAdiSoyadi";
            TedarikciAdiSoyadi.Size = new Size(120, 23);
            TedarikciAdiSoyadi.TabIndex = 10;
            // 
            // Adres
            // 
            Adres.Anchor = AnchorStyles.Left;
            Adres.Location = new Point(178, 257);
            Adres.Name = "Adres";
            Adres.Size = new Size(140, 65);
            Adres.TabIndex = 17;
            Adres.Text = "";
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
            button1.Location = new Point(-1, 0);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(25, 24);
            button1.TabIndex = 23;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // IbanBilgisi
            // 
            IbanBilgisi.Anchor = AnchorStyles.Left;
            IbanBilgisi.Location = new Point(178, 384);
            IbanBilgisi.Name = "IbanBilgisi";
            IbanBilgisi.Size = new Size(140, 65);
            IbanBilgisi.TabIndex = 18;
            IbanBilgisi.Text = "";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label1.Location = new Point(178, 364);
            label1.Name = "label1";
            label1.Size = new Size(81, 17);
            label1.TabIndex = 9;
            label1.Text = "İBAN Bilgisi";
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold | FontStyle.Italic);
            label3.Location = new Point(24, -3);
            label3.Name = "label3";
            label3.Size = new Size(334, 30);
            label3.TabIndex = 0;
            label3.Text = "Yeni Tedarikçi Kaydı Oluşturma";
            // 
            // txtGenelArama
            // 
            txtGenelArama.Location = new Point(447, 7);
            txtGenelArama.Name = "txtGenelArama";
            txtGenelArama.Size = new Size(120, 23);
            txtGenelArama.TabIndex = 58;
            txtGenelArama.TextChanged += txtGenelArama_TextChanged;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label23.Location = new Point(356, 9);
            label23.Name = "label23";
            label23.Size = new Size(85, 17);
            label23.TabIndex = 57;
            label23.Text = "Tabloda Bul:";
            // 
            // TedarikciOlustur
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(1269, 621);
            Controls.Add(txtGenelArama);
            Controls.Add(label23);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(IbanBilgisi);
            Controls.Add(Adres);
            Controls.Add(SatirGetir);
            Controls.Add(TedarikciTablo);
            Controls.Add(Guncelle);
            Controls.Add(Sil);
            Controls.Add(Ekle);
            Controls.Add(label7);
            Controls.Add(label11);
            Controls.Add(label5);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label1);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(VergiDairesi);
            Controls.Add(TcNo);
            Controls.Add(VergiNo);
            Controls.Add(CariAdi);
            Controls.Add(Eposta);
            Controls.Add(TelefonNo);
            Controls.Add(TedarikciAdiSoyadi);
            Name = "TedarikciOlustur";
            Text = "TEDARİKÇİ OLUŞTURMA";
            Load += TedarikciEkle_Load;
            ((System.ComponentModel.ISupportInitialize)TedarikciTablo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SatirGetir;
        private DataGridView TedarikciTablo;
        private Button Guncelle;
        private Button Sil;
        private Button Ekle;
        private Label label7;
        private Label label11;
        private Label label5;
        private Label label9;
        private Label label8;
        private Label label6;
        private Label label4;
        private Label label2;
        private TextBox VergiDairesi;
        private TextBox TcNo;
        private TextBox VergiNo;
        private TextBox CariAdi;
        private TextBox Eposta;
        private TextBox TelefonNo;
        private TextBox TedarikciAdiSoyadi;
        private RichTextBox Adres;
        private Button button1;
        private RichTextBox IbanBilgisi;
        private Label label1;
        private Label label3;
        private TextBox txtGenelArama;
        private Label label23;
    }
}