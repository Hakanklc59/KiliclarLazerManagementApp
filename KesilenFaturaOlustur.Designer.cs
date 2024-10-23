namespace YonetimBilgiSistemleri
{
    partial class KesilenFaturaOlustur
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            TXTGonderimTarihi = new DateTimePicker();
            TXTFaturaTarihi = new DateTimePicker();
            KesilenFaturaTablo = new DataGridView();
            SatirGetir = new Button();
            Guncelle = new Button();
            Sil = new Button();
            Ekle = new Button();
            label21 = new Label();
            label11 = new Label();
            label20 = new Label();
            label10 = new Label();
            label19 = new Label();
            label9 = new Label();
            label18 = new Label();
            label8 = new Label();
            label17 = new Label();
            label7 = new Label();
            label16 = new Label();
            label6 = new Label();
            label15 = new Label();
            label5 = new Label();
            label14 = new Label();
            label4 = new Label();
            label13 = new Label();
            label12 = new Label();
            TXTMalHizmetTutari = new TextBox();
            TXTIban = new TextBox();
            TXTFaturaAciklamasi = new TextBox();
            TXTHizmetTuru = new TextBox();
            TXTVergilerDahilTutar = new TextBox();
            TXTHesaplananKdvTutari = new TextBox();
            TXTVergiDairesi = new TextBox();
            TXTAdres = new TextBox();
            TXTTelNo = new TextBox();
            TXTFaturaSenaryo = new TextBox();
            TXTVKN = new TextBox();
            TXTNetTutar = new TextBox();
            TXTFaturaNo = new TextBox();
            TXTToplamIskontoTutari = new TextBox();
            TXTCariAd = new TextBox();
            TXTTCKN = new TextBox();
            TXTMusteriAdi = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            TXTMusteriID = new TextBox();
            button1 = new Button();
            label1 = new Label();
            belgesec = new Button();
            txtbelge = new TextBox();
            label22 = new Label();
            radioodenecek = new RadioButton();
            radioodendi = new RadioButton();
            FormTemizle = new Button();
            txtGenelArama = new TextBox();
            label23 = new Label();
            ((System.ComponentModel.ISupportInitialize)KesilenFaturaTablo).BeginInit();
            SuspendLayout();
            // 
            // TXTGonderimTarihi
            // 
            TXTGonderimTarihi.Anchor = AnchorStyles.Top;
            TXTGonderimTarihi.Location = new Point(685, 152);
            TXTGonderimTarihi.Name = "TXTGonderimTarihi";
            TXTGonderimTarihi.Size = new Size(120, 23);
            TXTGonderimTarihi.TabIndex = 35;
            // 
            // TXTFaturaTarihi
            // 
            TXTFaturaTarihi.Anchor = AnchorStyles.Top;
            TXTFaturaTarihi.Location = new Point(685, 122);
            TXTFaturaTarihi.Name = "TXTFaturaTarihi";
            TXTFaturaTarihi.Size = new Size(120, 23);
            TXTFaturaTarihi.TabIndex = 34;
            // 
            // KesilenFaturaTablo
            // 
            KesilenFaturaTablo.AllowUserToOrderColumns = true;
            KesilenFaturaTablo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.DarkBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            KesilenFaturaTablo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            KesilenFaturaTablo.Location = new Point(6, 213);
            KesilenFaturaTablo.Name = "KesilenFaturaTablo";
            KesilenFaturaTablo.Size = new Size(1257, 475);
            KesilenFaturaTablo.TabIndex = 46;
            KesilenFaturaTablo.CellDoubleClick += KesilenFaturaTablo_CellDoubleClick;
            KesilenFaturaTablo.CellFormatting += KesilenFaturaTablo_CellFormatting;
            KesilenFaturaTablo.ColumnHeaderMouseClick += KesilenFaturaTablo_ColumnHeaderMouseClick;
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
            SatirGetir.Location = new Point(1138, 173);
            SatirGetir.Name = "SatirGetir";
            SatirGetir.Size = new Size(105, 35);
            SatirGetir.TabIndex = 44;
            SatirGetir.Text = "SATIR GETİR";
            SatirGetir.UseVisualStyleBackColor = false;
            SatirGetir.Click += SatirGetir_Click;
            // 
            // Guncelle
            // 
            Guncelle.Anchor = AnchorStyles.Top;
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
            Guncelle.Location = new Point(1138, 134);
            Guncelle.Name = "Guncelle";
            Guncelle.Size = new Size(105, 35);
            Guncelle.TabIndex = 43;
            Guncelle.Text = "GÜNCELLE";
            Guncelle.UseVisualStyleBackColor = false;
            Guncelle.Click += Guncelle_Click;
            // 
            // Sil
            // 
            Sil.Anchor = AnchorStyles.Top;
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
            Sil.Location = new Point(1138, 96);
            Sil.Name = "Sil";
            Sil.Size = new Size(105, 35);
            Sil.TabIndex = 42;
            Sil.Text = "SİL";
            Sil.UseVisualStyleBackColor = false;
            Sil.Click += Sil_Click;
            // 
            // Ekle
            // 
            Ekle.Anchor = AnchorStyles.Top;
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
            Ekle.Location = new Point(1138, 57);
            Ekle.Name = "Ekle";
            Ekle.Size = new Size(105, 35);
            Ekle.TabIndex = 41;
            Ekle.Text = "EKLE";
            Ekle.UseVisualStyleBackColor = false;
            Ekle.Click += Ekle_Click;
            // 
            // label21
            // 
            label21.Anchor = AnchorStyles.Top;
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label21.Location = new Point(539, 94);
            label21.Name = "label21";
            label21.Size = new Size(121, 17);
            label21.TabIndex = 13;
            label21.Text = "Fatura Açıklaması:";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top;
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label11.Location = new Point(540, 124);
            label11.Name = "label11";
            label11.Size = new Size(90, 17);
            label11.TabIndex = 14;
            label11.Text = "Fatura Tarihi:";
            // 
            // label20
            // 
            label20.Anchor = AnchorStyles.Top;
            label20.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label20.Location = new Point(296, 140);
            label20.Name = "label20";
            label20.Size = new Size(91, 36);
            label20.TabIndex = 10;
            label20.Text = "Hizmet ve Ödeme Türü:";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label10.Location = new Point(298, 117);
            label10.Name = "label10";
            label10.Size = new Size(91, 17);
            label10.TabIndex = 9;
            label10.Text = "Vergi Dairesi:";
            // 
            // label19
            // 
            label19.Anchor = AnchorStyles.Top;
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label19.Location = new Point(838, 155);
            label19.Name = "label19";
            label19.Size = new Size(71, 17);
            label19.TabIndex = 20;
            label19.Text = "Net Tutar:";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label9.Location = new Point(298, 91);
            label9.Name = "label9";
            label9.Size = new Size(47, 17);
            label9.TabIndex = 8;
            label9.Text = "Adres:";
            // 
            // label18
            // 
            label18.Anchor = AnchorStyles.Top;
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label18.Location = new Point(837, 126);
            label18.Name = "label18";
            label18.Size = new Size(134, 17);
            label18.TabIndex = 19;
            label18.Text = "Vergiler Dahil Tutar:";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label8.Location = new Point(298, 63);
            label8.Name = "label8";
            label8.Size = new Size(80, 17);
            label8.TabIndex = 7;
            label8.Text = "Telefon No:";
            // 
            // label17
            // 
            label17.Anchor = AnchorStyles.Top;
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label17.Location = new Point(837, 97);
            label17.Name = "label17";
            label17.Size = new Size(155, 17);
            label17.TabIndex = 18;
            label17.Text = "Hesaplanan KDV Tutarı:";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label7.Location = new Point(298, 34);
            label7.Name = "label7";
            label7.Size = new Size(39, 17);
            label7.TabIndex = 6;
            label7.Text = "VKN:";
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.Top;
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label16.Location = new Point(836, 67);
            label16.Name = "label16";
            label16.Size = new Size(148, 17);
            label16.TabIndex = 17;
            label16.Text = "Toplam İskonto Tutarı:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label6.Location = new Point(19, 154);
            label6.Name = "label6";
            label6.Size = new Size(46, 17);
            label6.TabIndex = 5;
            label6.Text = "TCKN:";
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Top;
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label15.Location = new Point(837, 38);
            label15.Name = "label15";
            label15.Size = new Size(123, 17);
            label15.TabIndex = 16;
            label15.Text = "Mal Hizmet Tutarı:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label5.Location = new Point(19, 125);
            label5.Name = "label5";
            label5.Size = new Size(73, 17);
            label5.TabIndex = 4;
            label5.Text = "Fatura No:";
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Top;
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label14.Location = new Point(539, 65);
            label14.Name = "label14";
            label14.Size = new Size(85, 17);
            label14.TabIndex = 12;
            label14.Text = "İBAN Bilgisi:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label4.Location = new Point(19, 96);
            label4.Name = "label4";
            label4.Size = new Size(57, 17);
            label4.TabIndex = 3;
            label4.Text = "Cari Ad:";
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top;
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label13.Location = new Point(540, 37);
            label13.Name = "label13";
            label13.Size = new Size(119, 17);
            label13.TabIndex = 11;
            label13.Text = "Fatura Senaryosu:";
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top;
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label12.Location = new Point(540, 154);
            label12.Name = "label12";
            label12.Size = new Size(81, 17);
            label12.TabIndex = 15;
            label12.Text = "Vade Tarihi:";
            // 
            // TXTMalHizmetTutari
            // 
            TXTMalHizmetTutari.Anchor = AnchorStyles.Top;
            TXTMalHizmetTutari.Location = new Point(992, 36);
            TXTMalHizmetTutari.Name = "TXTMalHizmetTutari";
            TXTMalHizmetTutari.Size = new Size(120, 23);
            TXTMalHizmetTutari.TabIndex = 36;
            // 
            // TXTIban
            // 
            TXTIban.Anchor = AnchorStyles.Top;
            TXTIban.Location = new Point(685, 63);
            TXTIban.Name = "TXTIban";
            TXTIban.Size = new Size(120, 23);
            TXTIban.TabIndex = 32;
            // 
            // TXTFaturaAciklamasi
            // 
            TXTFaturaAciklamasi.Anchor = AnchorStyles.Top;
            TXTFaturaAciklamasi.Location = new Point(685, 93);
            TXTFaturaAciklamasi.Name = "TXTFaturaAciklamasi";
            TXTFaturaAciklamasi.Size = new Size(120, 23);
            TXTFaturaAciklamasi.TabIndex = 33;
            // 
            // TXTHizmetTuru
            // 
            TXTHizmetTuru.Anchor = AnchorStyles.Top;
            TXTHizmetTuru.Location = new Point(393, 150);
            TXTHizmetTuru.Name = "TXTHizmetTuru";
            TXTHizmetTuru.Size = new Size(120, 23);
            TXTHizmetTuru.TabIndex = 30;
            // 
            // TXTVergilerDahilTutar
            // 
            TXTVergilerDahilTutar.Anchor = AnchorStyles.Top;
            TXTVergilerDahilTutar.Location = new Point(992, 124);
            TXTVergilerDahilTutar.Name = "TXTVergilerDahilTutar";
            TXTVergilerDahilTutar.Size = new Size(120, 23);
            TXTVergilerDahilTutar.TabIndex = 39;
            // 
            // TXTHesaplananKdvTutari
            // 
            TXTHesaplananKdvTutari.Anchor = AnchorStyles.Top;
            TXTHesaplananKdvTutari.Location = new Point(992, 95);
            TXTHesaplananKdvTutari.Name = "TXTHesaplananKdvTutari";
            TXTHesaplananKdvTutari.Size = new Size(120, 23);
            TXTHesaplananKdvTutari.TabIndex = 38;
            // 
            // TXTVergiDairesi
            // 
            TXTVergiDairesi.Anchor = AnchorStyles.Top;
            TXTVergiDairesi.Location = new Point(393, 119);
            TXTVergiDairesi.Name = "TXTVergiDairesi";
            TXTVergiDairesi.Size = new Size(120, 23);
            TXTVergiDairesi.TabIndex = 29;
            // 
            // TXTAdres
            // 
            TXTAdres.Anchor = AnchorStyles.Top;
            TXTAdres.Location = new Point(393, 90);
            TXTAdres.Name = "TXTAdres";
            TXTAdres.Size = new Size(120, 23);
            TXTAdres.TabIndex = 28;
            // 
            // TXTTelNo
            // 
            TXTTelNo.Anchor = AnchorStyles.Top;
            TXTTelNo.Location = new Point(393, 61);
            TXTTelNo.Name = "TXTTelNo";
            TXTTelNo.Size = new Size(120, 23);
            TXTTelNo.TabIndex = 27;
            // 
            // TXTFaturaSenaryo
            // 
            TXTFaturaSenaryo.Anchor = AnchorStyles.Top;
            TXTFaturaSenaryo.Location = new Point(685, 34);
            TXTFaturaSenaryo.Name = "TXTFaturaSenaryo";
            TXTFaturaSenaryo.Size = new Size(120, 23);
            TXTFaturaSenaryo.TabIndex = 31;
            // 
            // TXTVKN
            // 
            TXTVKN.Anchor = AnchorStyles.Top;
            TXTVKN.Location = new Point(393, 32);
            TXTVKN.Name = "TXTVKN";
            TXTVKN.Size = new Size(120, 23);
            TXTVKN.TabIndex = 26;
            // 
            // TXTNetTutar
            // 
            TXTNetTutar.Anchor = AnchorStyles.Top;
            TXTNetTutar.Location = new Point(992, 152);
            TXTNetTutar.Name = "TXTNetTutar";
            TXTNetTutar.Size = new Size(120, 23);
            TXTNetTutar.TabIndex = 40;
            // 
            // TXTFaturaNo
            // 
            TXTFaturaNo.Anchor = AnchorStyles.Top;
            TXTFaturaNo.Location = new Point(147, 121);
            TXTFaturaNo.Name = "TXTFaturaNo";
            TXTFaturaNo.Size = new Size(120, 23);
            TXTFaturaNo.TabIndex = 24;
            // 
            // TXTToplamIskontoTutari
            // 
            TXTToplamIskontoTutari.Anchor = AnchorStyles.Top;
            TXTToplamIskontoTutari.Location = new Point(992, 65);
            TXTToplamIskontoTutari.Name = "TXTToplamIskontoTutari";
            TXTToplamIskontoTutari.Size = new Size(120, 23);
            TXTToplamIskontoTutari.TabIndex = 37;
            // 
            // TXTCariAd
            // 
            TXTCariAd.Anchor = AnchorStyles.Top;
            TXTCariAd.Location = new Point(147, 92);
            TXTCariAd.Name = "TXTCariAd";
            TXTCariAd.Size = new Size(120, 23);
            TXTCariAd.TabIndex = 23;
            // 
            // TXTTCKN
            // 
            TXTTCKN.Anchor = AnchorStyles.Top;
            TXTTCKN.Location = new Point(147, 150);
            TXTTCKN.Name = "TXTTCKN";
            TXTTCKN.Size = new Size(120, 23);
            TXTTCKN.TabIndex = 25;
            // 
            // TXTMusteriAdi
            // 
            TXTMusteriAdi.Anchor = AnchorStyles.Top;
            TXTMusteriAdi.FormattingEnabled = true;
            TXTMusteriAdi.Location = new Point(147, 37);
            TXTMusteriAdi.Name = "TXTMusteriAdi";
            TXTMusteriAdi.Size = new Size(120, 23);
            TXTMusteriAdi.TabIndex = 21;
            TXTMusteriAdi.SelectedIndexChanged += TXTMusteriAdi_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label3.Location = new Point(19, 68);
            label3.Name = "label3";
            label3.Size = new Size(124, 17);
            label3.TabIndex = 2;
            label3.Text = "Kayıtlı Muşteri No:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label2.Location = new Point(18, 39);
            label2.Name = "label2";
            label2.Size = new Size(129, 17);
            label2.TabIndex = 1;
            label2.Text = "Musteri Adı Soyadı:";
            // 
            // TXTMusteriID
            // 
            TXTMusteriID.Anchor = AnchorStyles.Top;
            TXTMusteriID.Location = new Point(147, 65);
            TXTMusteriID.Name = "TXTMusteriID";
            TXTMusteriID.Size = new Size(120, 23);
            TXTMusteriID.TabIndex = 22;
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
            button1.Location = new Point(-1, -1);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(25, 24);
            button1.TabIndex = 45;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(539, -1);
            label1.Name = "label1";
            label1.Size = new Size(209, 30);
            label1.TabIndex = 0;
            label1.Text = "SATIŞ FATURALARI";
            // 
            // belgesec
            // 
            belgesec.Anchor = AnchorStyles.Top;
            belgesec.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            belgesec.Location = new Point(293, 182);
            belgesec.Name = "belgesec";
            belgesec.Size = new Size(89, 23);
            belgesec.TabIndex = 50;
            belgesec.Text = "Belge Yükle";
            belgesec.UseVisualStyleBackColor = true;
            belgesec.Click += belgesec_Click;
            // 
            // txtbelge
            // 
            txtbelge.Anchor = AnchorStyles.Top;
            txtbelge.Location = new Point(393, 184);
            txtbelge.Name = "txtbelge";
            txtbelge.Size = new Size(120, 23);
            txtbelge.TabIndex = 49;
            // 
            // label22
            // 
            label22.Anchor = AnchorStyles.Top;
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label22.Location = new Point(540, 184);
            label22.Name = "label22";
            label22.Size = new Size(106, 17);
            label22.TabIndex = 53;
            label22.Text = "Fatura Durumu:";
            // 
            // radioodenecek
            // 
            radioodenecek.Anchor = AnchorStyles.Top;
            radioodenecek.AutoSize = true;
            radioodenecek.Checked = true;
            radioodenecek.Location = new Point(674, 184);
            radioodenecek.Name = "radioodenecek";
            radioodenecek.Size = new Size(78, 19);
            radioodenecek.TabIndex = 51;
            radioodenecek.TabStop = true;
            radioodenecek.Text = "Ödenecek";
            radioodenecek.UseVisualStyleBackColor = true;
            // 
            // radioodendi
            // 
            radioodendi.Anchor = AnchorStyles.Top;
            radioodendi.AutoSize = true;
            radioodendi.Location = new Point(763, 185);
            radioodendi.Name = "radioodendi";
            radioodendi.Size = new Size(64, 19);
            radioodendi.TabIndex = 52;
            radioodendi.TabStop = true;
            radioodendi.Text = "Ödendi";
            radioodendi.UseVisualStyleBackColor = true;
            // 
            // FormTemizle
            // 
            FormTemizle.Anchor = AnchorStyles.Top;
            FormTemizle.AutoSize = true;
            FormTemizle.BackColor = Color.Black;
            FormTemizle.Cursor = Cursors.Hand;
            FormTemizle.FlatAppearance.BorderColor = Color.White;
            FormTemizle.FlatAppearance.BorderSize = 3;
            FormTemizle.FlatAppearance.CheckedBackColor = Color.Gray;
            FormTemizle.FlatAppearance.MouseDownBackColor = Color.Gray;
            FormTemizle.FlatAppearance.MouseOverBackColor = Color.Gray;
            FormTemizle.FlatStyle = FlatStyle.Flat;
            FormTemizle.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            FormTemizle.ForeColor = SystemColors.ButtonHighlight;
            FormTemizle.Location = new Point(1138, 18);
            FormTemizle.Name = "FormTemizle";
            FormTemizle.Size = new Size(105, 38);
            FormTemizle.TabIndex = 54;
            FormTemizle.Text = "TEMİZLE";
            FormTemizle.UseVisualStyleBackColor = false;
            FormTemizle.Click += FormTemizle_Click;
            // 
            // txtGenelArama
            // 
            txtGenelArama.Anchor = AnchorStyles.Top;
            txtGenelArama.Location = new Point(147, 182);
            txtGenelArama.Name = "txtGenelArama";
            txtGenelArama.Size = new Size(120, 23);
            txtGenelArama.TabIndex = 56;
            txtGenelArama.TextChanged += txtGenelArama_TextChanged;
            // 
            // label23
            // 
            label23.Anchor = AnchorStyles.Top;
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label23.Location = new Point(20, 185);
            label23.Name = "label23";
            label23.Size = new Size(85, 17);
            label23.TabIndex = 5;
            label23.Text = "Tabloda Bul:";
            // 
            // KesilenFaturaOlustur
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(1269, 691);
            Controls.Add(txtGenelArama);
            Controls.Add(FormTemizle);
            Controls.Add(label22);
            Controls.Add(radioodenecek);
            Controls.Add(radioodendi);
            Controls.Add(belgesec);
            Controls.Add(txtbelge);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(TXTMusteriAdi);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(TXTMusteriID);
            Controls.Add(TXTGonderimTarihi);
            Controls.Add(TXTFaturaTarihi);
            Controls.Add(KesilenFaturaTablo);
            Controls.Add(SatirGetir);
            Controls.Add(Guncelle);
            Controls.Add(Sil);
            Controls.Add(Ekle);
            Controls.Add(label21);
            Controls.Add(label11);
            Controls.Add(label20);
            Controls.Add(label10);
            Controls.Add(label19);
            Controls.Add(label9);
            Controls.Add(label18);
            Controls.Add(label8);
            Controls.Add(label17);
            Controls.Add(label7);
            Controls.Add(label16);
            Controls.Add(label23);
            Controls.Add(label6);
            Controls.Add(label15);
            Controls.Add(label5);
            Controls.Add(label14);
            Controls.Add(label4);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(TXTMalHizmetTutari);
            Controls.Add(TXTIban);
            Controls.Add(TXTFaturaAciklamasi);
            Controls.Add(TXTHizmetTuru);
            Controls.Add(TXTVergilerDahilTutar);
            Controls.Add(TXTHesaplananKdvTutari);
            Controls.Add(TXTVergiDairesi);
            Controls.Add(TXTAdres);
            Controls.Add(TXTTelNo);
            Controls.Add(TXTFaturaSenaryo);
            Controls.Add(TXTVKN);
            Controls.Add(TXTNetTutar);
            Controls.Add(TXTFaturaNo);
            Controls.Add(TXTToplamIskontoTutari);
            Controls.Add(TXTCariAd);
            Controls.Add(TXTTCKN);
            Name = "KesilenFaturaOlustur";
            Text = "SATIŞ FATURALARI";
            Load += KesilenFaturaOlustur_Load;
            ((System.ComponentModel.ISupportInitialize)KesilenFaturaTablo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker TXTGonderimTarihi;
        private DateTimePicker TXTFaturaTarihi;
        private DataGridView KesilenFaturaTablo;
        private Button SatirGetir;
        private Button Guncelle;
        private Button Sil;
        private Button Ekle;
        private Label label21;
        private Label label11;
        private Label label20;
        private Label label10;
        private Label label19;
        private Label label9;
        private Label label18;
        private Label label8;
        private Label label17;
        private Label label7;
        private Label label16;
        private Label label6;
        private Label label15;
        private Label label5;
        private Label label14;
        private Label label4;
        private Label label13;
        private Label label12;
        private TextBox TXTMalHizmetTutari;
        private TextBox TXTIban;
        private TextBox TXTFaturaAciklamasi;
        private TextBox TXTHizmetTuru;
        private TextBox TXTVergilerDahilTutar;
        private TextBox TXTHesaplananKdvTutari;
        private TextBox TXTVergiDairesi;
        private TextBox TXTAdres;
        private TextBox TXTTelNo;
        private TextBox TXTFaturaSenaryo;
        private TextBox TXTVKN;
        private TextBox TXTNetTutar;
        private TextBox TXTFaturaNo;
        private TextBox TXTToplamIskontoTutari;
        private TextBox TXTCariAd;
        private TextBox TXTTCKN;
        private ComboBox TXTMusteriAdi;
        private Label label3;
        private Label label2;
        private TextBox TXTMusteriID;
        private Button button1;
        private Label label1;
        private Button belgesec;
        private TextBox txtbelge;
        private Label label22;
        private RadioButton radioodenecek;
        private RadioButton radioodendi;
        private Button FormTemizle;
        private TextBox txtGenelArama;
        private Label label23;
    }
}