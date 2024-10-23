namespace YonetimBilgiSistemleri
{
    partial class SiparisVerme
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
            radioSiparisGeldi = new RadioButton();
            radioSiparisHazırlanıyor = new RadioButton();
            radioSiparisVerildi = new RadioButton();
            TedarikciAdi = new ComboBox();
            SiparisAlisTarihi = new DateTimePicker();
            SiparisTeslimTarihi = new DateTimePicker();
            SatirGetir = new Button();
            SiparisGuncelle = new Button();
            SiparisSil = new Button();
            SiparisEkle = new Button();
            VerilenSiparislerTablo = new DataGridView();
            label12 = new Label();
            label8 = new Label();
            label11 = new Label();
            label4 = new Label();
            label13 = new Label();
            label10 = new Label();
            label7 = new Label();
            label6 = new Label();
            label9 = new Label();
            label1 = new Label();
            ToplamFiyat = new TextBox();
            IskontoOrani = new TextBox();
            KDVOrani = new TextBox();
            Fiyat = new TextBox();
            CariAdi = new TextBox();
            label2 = new Label();
            SiparisNotu = new RichTextBox();
            SiparisDetayi = new RichTextBox();
            button1 = new Button();
            label3 = new Label();
            FormTemizle = new Button();
            txtGenelArama = new TextBox();
            label23 = new Label();
            ((System.ComponentModel.ISupportInitialize)VerilenSiparislerTablo).BeginInit();
            SuspendLayout();
            // 
            // radioSiparisGeldi
            // 
            radioSiparisGeldi.Anchor = AnchorStyles.Top;
            radioSiparisGeldi.AutoSize = true;
            radioSiparisGeldi.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            radioSiparisGeldi.Location = new Point(928, 127);
            radioSiparisGeldi.Name = "radioSiparisGeldi";
            radioSiparisGeldi.Size = new Size(103, 21);
            radioSiparisGeldi.TabIndex = 24;
            radioSiparisGeldi.TabStop = true;
            radioSiparisGeldi.Text = "Sipariş Geldi";
            radioSiparisGeldi.UseVisualStyleBackColor = true;
            // 
            // radioSiparisHazırlanıyor
            // 
            radioSiparisHazırlanıyor.Anchor = AnchorStyles.Top;
            radioSiparisHazırlanıyor.AutoSize = true;
            radioSiparisHazırlanıyor.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            radioSiparisHazırlanıyor.Location = new Point(928, 97);
            radioSiparisHazırlanıyor.Name = "radioSiparisHazırlanıyor";
            radioSiparisHazırlanıyor.Size = new Size(105, 21);
            radioSiparisHazırlanıyor.TabIndex = 23;
            radioSiparisHazırlanıyor.TabStop = true;
            radioSiparisHazırlanıyor.Text = "Sipariş Yolda";
            radioSiparisHazırlanıyor.UseVisualStyleBackColor = true;
            // 
            // radioSiparisVerildi
            // 
            radioSiparisVerildi.Anchor = AnchorStyles.Top;
            radioSiparisVerildi.AutoSize = true;
            radioSiparisVerildi.Checked = true;
            radioSiparisVerildi.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            radioSiparisVerildi.Location = new Point(927, 70);
            radioSiparisVerildi.Name = "radioSiparisVerildi";
            radioSiparisVerildi.Size = new Size(111, 21);
            radioSiparisVerildi.TabIndex = 22;
            radioSiparisVerildi.TabStop = true;
            radioSiparisVerildi.Text = "Sipariş Verildi";
            radioSiparisVerildi.UseVisualStyleBackColor = true;
            // 
            // TedarikciAdi
            // 
            TedarikciAdi.Anchor = AnchorStyles.Top;
            TedarikciAdi.FormattingEnabled = true;
            TedarikciAdi.Location = new Point(52, 48);
            TedarikciAdi.Name = "TedarikciAdi";
            TedarikciAdi.Size = new Size(120, 23);
            TedarikciAdi.TabIndex = 12;
            TedarikciAdi.SelectedIndexChanged += TedarikciAdi_SelectedIndexChanged;
            // 
            // SiparisAlisTarihi
            // 
            SiparisAlisTarihi.Anchor = AnchorStyles.Top;
            SiparisAlisTarihi.Location = new Point(448, 104);
            SiparisAlisTarihi.Name = "SiparisAlisTarihi";
            SiparisAlisTarihi.Size = new Size(150, 23);
            SiparisAlisTarihi.TabIndex = 18;
            // 
            // SiparisTeslimTarihi
            // 
            SiparisTeslimTarihi.Anchor = AnchorStyles.Top;
            SiparisTeslimTarihi.Location = new Point(448, 158);
            SiparisTeslimTarihi.Name = "SiparisTeslimTarihi";
            SiparisTeslimTarihi.Size = new Size(150, 23);
            SiparisTeslimTarihi.TabIndex = 19;
            // 
            // SatirGetir
            // 
            SatirGetir.Anchor = AnchorStyles.Top;
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
            SatirGetir.Location = new Point(1112, 63);
            SatirGetir.Name = "SatirGetir";
            SatirGetir.Size = new Size(120, 40);
            SatirGetir.TabIndex = 27;
            SatirGetir.Text = "Satır Getir";
            SatirGetir.UseVisualStyleBackColor = false;
            SatirGetir.Click += SatirGetir_Click;
            // 
            // SiparisGuncelle
            // 
            SiparisGuncelle.Anchor = AnchorStyles.Top;
            SiparisGuncelle.BackColor = Color.Black;
            SiparisGuncelle.Cursor = Cursors.Hand;
            SiparisGuncelle.FlatAppearance.BorderColor = Color.White;
            SiparisGuncelle.FlatAppearance.BorderSize = 3;
            SiparisGuncelle.FlatAppearance.CheckedBackColor = Color.Gray;
            SiparisGuncelle.FlatAppearance.MouseDownBackColor = Color.Gray;
            SiparisGuncelle.FlatAppearance.MouseOverBackColor = Color.Gray;
            SiparisGuncelle.FlatStyle = FlatStyle.Flat;
            SiparisGuncelle.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            SiparisGuncelle.ForeColor = SystemColors.ButtonHighlight;
            SiparisGuncelle.Location = new Point(1112, 17);
            SiparisGuncelle.Name = "SiparisGuncelle";
            SiparisGuncelle.Size = new Size(120, 40);
            SiparisGuncelle.TabIndex = 28;
            SiparisGuncelle.Text = "Güncelle";
            SiparisGuncelle.UseVisualStyleBackColor = false;
            SiparisGuncelle.Click += SiparisGuncelle_Click;
            // 
            // SiparisSil
            // 
            SiparisSil.Anchor = AnchorStyles.Top;
            SiparisSil.BackColor = Color.Black;
            SiparisSil.Cursor = Cursors.Hand;
            SiparisSil.FlatAppearance.BorderColor = Color.White;
            SiparisSil.FlatAppearance.BorderSize = 3;
            SiparisSil.FlatAppearance.CheckedBackColor = Color.Gray;
            SiparisSil.FlatAppearance.MouseDownBackColor = Color.Gray;
            SiparisSil.FlatAppearance.MouseOverBackColor = Color.Gray;
            SiparisSil.FlatStyle = FlatStyle.Flat;
            SiparisSil.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            SiparisSil.ForeColor = SystemColors.ButtonHighlight;
            SiparisSil.Location = new Point(1112, 112);
            SiparisSil.Name = "SiparisSil";
            SiparisSil.Size = new Size(120, 40);
            SiparisSil.TabIndex = 26;
            SiparisSil.Text = "Sil";
            SiparisSil.UseVisualStyleBackColor = false;
            SiparisSil.Click += SiparisSil_Click;
            // 
            // SiparisEkle
            // 
            SiparisEkle.Anchor = AnchorStyles.Top;
            SiparisEkle.BackColor = Color.Black;
            SiparisEkle.Cursor = Cursors.Hand;
            SiparisEkle.FlatAppearance.BorderColor = Color.White;
            SiparisEkle.FlatAppearance.BorderSize = 3;
            SiparisEkle.FlatAppearance.CheckedBackColor = Color.Gray;
            SiparisEkle.FlatAppearance.MouseDownBackColor = Color.Gray;
            SiparisEkle.FlatAppearance.MouseOverBackColor = Color.Gray;
            SiparisEkle.FlatStyle = FlatStyle.Flat;
            SiparisEkle.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            SiparisEkle.ForeColor = SystemColors.ButtonHighlight;
            SiparisEkle.Location = new Point(1112, 158);
            SiparisEkle.Name = "SiparisEkle";
            SiparisEkle.Size = new Size(120, 40);
            SiparisEkle.TabIndex = 25;
            SiparisEkle.Text = "Ekle";
            SiparisEkle.UseVisualStyleBackColor = false;
            SiparisEkle.Click += SiparisEkle_Click;
            // 
            // VerilenSiparislerTablo
            // 
            VerilenSiparislerTablo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            VerilenSiparislerTablo.Location = new Point(6, 228);
            VerilenSiparislerTablo.Name = "VerilenSiparislerTablo";
            VerilenSiparislerTablo.Size = new Size(1257, 451);
            VerilenSiparislerTablo.TabIndex = 30;
            VerilenSiparislerTablo.CellFormatting += VerilenSiparislerTablo_CellFormatting;
            VerilenSiparislerTablo.ColumnHeaderMouseClick += VerilenSiparislerTablo_ColumnHeaderMouseClick;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top;
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label12.Location = new Point(660, 102);
            label12.Name = "label12";
            label12.Size = new Size(84, 17);
            label12.TabIndex = 10;
            label12.Text = "Sipariş Notu";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label8.Location = new Point(253, 139);
            label8.Name = "label8";
            label8.Size = new Size(92, 17);
            label8.TabIndex = 5;
            label8.Text = "İskonto Oranı";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top;
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label11.Location = new Point(448, 87);
            label11.Name = "label11";
            label11.Size = new Size(115, 17);
            label11.TabIndex = 7;
            label11.Text = "Siparis Alış Tarihi";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label4.Location = new Point(665, 14);
            label4.Name = "label4";
            label4.Size = new Size(93, 17);
            label4.TabIndex = 9;
            label4.Text = "Siparis Detayı";
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top;
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 162);
            label13.Location = new Point(913, 35);
            label13.Name = "label13";
            label13.Size = new Size(117, 20);
            label13.TabIndex = 11;
            label13.Text = "Sipariş Durumu";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label10.Location = new Point(448, 139);
            label10.Name = "label10";
            label10.Size = new Size(132, 17);
            label10.TabIndex = 8;
            label10.Text = "Sipariş Teslim Tarihi";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label7.Location = new Point(254, 27);
            label7.Name = "label7";
            label7.Size = new Size(68, 17);
            label7.TabIndex = 3;
            label7.Text = "Brüt Fiyat";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label6.Location = new Point(253, 82);
            label6.Name = "label6";
            label6.Size = new Size(69, 17);
            label6.TabIndex = 4;
            label6.Text = "Kdv Oranı";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label9.Location = new Point(448, 26);
            label9.Name = "label9";
            label9.Size = new Size(64, 17);
            label9.TabIndex = 6;
            label9.Text = "Net Fiyat";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label1.Location = new Point(52, 32);
            label1.Name = "label1";
            label1.Size = new Size(88, 17);
            label1.TabIndex = 1;
            label1.Text = "Tedarikçi Adı";
            // 
            // ToplamFiyat
            // 
            ToplamFiyat.Anchor = AnchorStyles.Top;
            ToplamFiyat.Location = new Point(448, 45);
            ToplamFiyat.Name = "ToplamFiyat";
            ToplamFiyat.Size = new Size(120, 23);
            ToplamFiyat.TabIndex = 17;
            // 
            // IskontoOrani
            // 
            IskontoOrani.Anchor = AnchorStyles.Top;
            IskontoOrani.Location = new Point(254, 158);
            IskontoOrani.Name = "IskontoOrani";
            IskontoOrani.Size = new Size(120, 23);
            IskontoOrani.TabIndex = 16;
            // 
            // KDVOrani
            // 
            KDVOrani.Anchor = AnchorStyles.Top;
            KDVOrani.Location = new Point(254, 102);
            KDVOrani.Name = "KDVOrani";
            KDVOrani.Size = new Size(120, 23);
            KDVOrani.TabIndex = 15;
            // 
            // Fiyat
            // 
            Fiyat.Anchor = AnchorStyles.Top;
            Fiyat.Location = new Point(254, 45);
            Fiyat.Name = "Fiyat";
            Fiyat.Size = new Size(120, 23);
            Fiyat.TabIndex = 14;
            // 
            // CariAdi
            // 
            CariAdi.Anchor = AnchorStyles.Top;
            CariAdi.Location = new Point(52, 105);
            CariAdi.Name = "CariAdi";
            CariAdi.Size = new Size(120, 23);
            CariAdi.TabIndex = 13;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label2.Location = new Point(52, 85);
            label2.Name = "label2";
            label2.Size = new Size(57, 17);
            label2.TabIndex = 2;
            label2.Text = "Cari Adi";
            // 
            // SiparisNotu
            // 
            SiparisNotu.Anchor = AnchorStyles.Top;
            SiparisNotu.Location = new Point(660, 122);
            SiparisNotu.Name = "SiparisNotu";
            SiparisNotu.Size = new Size(220, 65);
            SiparisNotu.TabIndex = 21;
            SiparisNotu.Text = "";
            // 
            // SiparisDetayi
            // 
            SiparisDetayi.Anchor = AnchorStyles.Top;
            SiparisDetayi.Location = new Point(660, 34);
            SiparisDetayi.Name = "SiparisDetayi";
            SiparisDetayi.Size = new Size(220, 65);
            SiparisDetayi.TabIndex = 20;
            SiparisDetayi.Text = "";
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
            button1.Location = new Point(-1, -2);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(23, 22);
            button1.TabIndex = 29;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold | FontStyle.Italic);
            label3.Location = new Point(25, -2);
            label3.Name = "label3";
            label3.Size = new Size(162, 30);
            label3.TabIndex = 0;
            label3.Text = "ALIM SİPARİŞİ";
            // 
            // FormTemizle
            // 
            FormTemizle.Anchor = AnchorStyles.Top;
            FormTemizle.AutoSize = true;
            FormTemizle.BackColor = Color.Black;
            FormTemizle.Cursor = Cursors.Hand;
            FormTemizle.FlatAppearance.BorderColor = Color.White;
            FormTemizle.FlatAppearance.MouseDownBackColor = Color.Gray;
            FormTemizle.FlatAppearance.MouseOverBackColor = Color.Gray;
            FormTemizle.FlatStyle = FlatStyle.Flat;
            FormTemizle.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            FormTemizle.ForeColor = SystemColors.ButtonHighlight;
            FormTemizle.Location = new Point(928, 162);
            FormTemizle.Name = "FormTemizle";
            FormTemizle.Size = new Size(75, 29);
            FormTemizle.TabIndex = 34;
            FormTemizle.Text = "TEMİZLE";
            FormTemizle.UseVisualStyleBackColor = false;
            FormTemizle.Click += FormTemizle_Click;
            // 
            // txtGenelArama
            // 
            txtGenelArama.Anchor = AnchorStyles.Top;
            txtGenelArama.Location = new Point(97, 199);
            txtGenelArama.Name = "txtGenelArama";
            txtGenelArama.Size = new Size(120, 23);
            txtGenelArama.TabIndex = 58;
            txtGenelArama.TextChanged += txtGenelArama_TextChanged;
            // 
            // label23
            // 
            label23.Anchor = AnchorStyles.Top;
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label23.Location = new Point(6, 201);
            label23.Name = "label23";
            label23.Size = new Size(85, 17);
            label23.TabIndex = 57;
            label23.Text = "Tabloda Bul:";
            // 
            // SiparisVerme
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(1269, 691);
            Controls.Add(txtGenelArama);
            Controls.Add(label23);
            Controls.Add(FormTemizle);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(SiparisDetayi);
            Controls.Add(SiparisNotu);
            Controls.Add(CariAdi);
            Controls.Add(radioSiparisGeldi);
            Controls.Add(radioSiparisHazırlanıyor);
            Controls.Add(radioSiparisVerildi);
            Controls.Add(TedarikciAdi);
            Controls.Add(SiparisAlisTarihi);
            Controls.Add(SiparisTeslimTarihi);
            Controls.Add(SatirGetir);
            Controls.Add(SiparisGuncelle);
            Controls.Add(SiparisSil);
            Controls.Add(SiparisEkle);
            Controls.Add(VerilenSiparislerTablo);
            Controls.Add(label12);
            Controls.Add(label8);
            Controls.Add(label11);
            Controls.Add(label4);
            Controls.Add(label13);
            Controls.Add(label10);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label9);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ToplamFiyat);
            Controls.Add(IskontoOrani);
            Controls.Add(KDVOrani);
            Controls.Add(Fiyat);
            Name = "SiparisVerme";
            Text = "ALIM SİPARİŞİ OLUŞTURMA";
            Load += SiparisVerme_Load;
            ((System.ComponentModel.ISupportInitialize)VerilenSiparislerTablo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton radioSiparisGeldi;
        private RadioButton radioSiparisHazırlanıyor;
        private RadioButton radioSiparisVerildi;
        private ComboBox TedarikciAdi;
        private DateTimePicker SiparisAlisTarihi;
        private DateTimePicker SiparisTeslimTarihi;
        private Button SatirGetir;
        private Button SiparisGuncelle;
        private Button SiparisSil;
        private Button SiparisEkle;
        private DataGridView VerilenSiparislerTablo;
        private Label label12;
        private Label label8;
        private Label label11;
        private Label label4;
        private Label label13;
        private Label label10;
        private Label label7;
        private Label label6;
        private Label label9;
        private Label label1;
        private TextBox ToplamFiyat;
        private TextBox IskontoOrani;
        private TextBox KDVOrani;
        private TextBox Fiyat;
        private TextBox CariAdi;
        private Label label2;
        private RichTextBox SiparisNotu;
        private RichTextBox SiparisDetayi;
        private Button button1;
        private Label label3;
        private Button FormTemizle;
        private TextBox txtGenelArama;
        private Label label23;
    }
}