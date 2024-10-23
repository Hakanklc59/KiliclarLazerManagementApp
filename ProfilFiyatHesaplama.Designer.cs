namespace YonetimBilgiSistemleri
{
    partial class ProfilFiyatHesaplama
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
            printDialog1 = new PrintDialog();
            FormTemizle = new Button();
            cmbprofilturu = new ComboBox();
            txtsiparistanimi = new RichTextBox();
            profilhesaplamatablosu = new DataGridView();
            txt_siparisismi = new TextBox();
            txtsaatucreti = new TextBox();
            txtmakinesaati = new TextBox();
            cmbmusteriadi = new ComboBox();
            txtsiparisino = new TextBox();
            label1 = new Label();
            txtkdvorani = new TextBox();
            txtiskontoorani = new TextBox();
            label10 = new Label();
            label7 = new Label();
            label4 = new Label();
            label2 = new Label();
            btnekle = new Button();
            btn_guncelle = new Button();
            btnsatirgetir = new Button();
            btnsil = new Button();
            btnsaatfiyathesapla = new Button();
            txtparcasayisi = new TextBox();
            txtboy = new TextBox();
            btnagirlikhesapla = new Button();
            txtkalinlik = new ComboBox();
            txtgenislik = new ComboBox();
            txtyukseklık = new ComboBox();
            lbl_tumagirlik = new Label();
            lbl_tumtoplam = new Label();
            label22 = new Label();
            lblnetfiyat = new Label();
            label20 = new Label();
            label19 = new Label();
            lblkdvtutar = new Label();
            label18 = new Label();
            lblilkfiyat = new Label();
            lbliskontotutar = new Label();
            lbliskontolufiyat = new Label();
            label9 = new Label();
            label21 = new Label();
            lbl1 = new Label();
            lblagirliksonuc = new Label();
            lbl30 = new Label();
            label15 = new Label();
            label3 = new Label();
            label6 = new Label();
            label11 = new Label();
            label16 = new Label();
            label13 = new Label();
            label12 = new Label();
            label8 = new Label();
            label25 = new Label();
            label24 = new Label();
            label28 = new Label();
            label17 = new Label();
            label26 = new Label();
            label5 = new Label();
            txtsiparisnosorgula = new TextBox();
            tumdegerleribul = new Button();
            label14 = new Label();
            lbltoplamsaat = new Label();
            lbltoplamiskonto = new Label();
            lbltoplamkdv = new Label();
            label23 = new Label();
            label27 = new Label();
            label29 = new Label();
            label30 = new Label();
            degerlerigonder = new Button();
            button1 = new Button();
            txtGenelArama = new TextBox();
            label31 = new Label();
            label32 = new Label();
            lblbrutfiyat = new Label();
            lblkdvorani = new Label();
            lbliskontoorani = new Label();
            ((System.ComponentModel.ISupportInitialize)profilhesaplamatablosu).BeginInit();
            SuspendLayout();
            // 
            // printDialog1
            // 
            printDialog1.UseEXDialog = true;
            // 
            // FormTemizle
            // 
            FormTemizle.Anchor = AnchorStyles.Top;
            FormTemizle.BackColor = Color.Black;
            FormTemizle.Cursor = Cursors.Hand;
            FormTemizle.FlatAppearance.BorderColor = Color.White;
            FormTemizle.FlatAppearance.BorderSize = 3;
            FormTemizle.FlatAppearance.CheckedBackColor = Color.Gray;
            FormTemizle.FlatAppearance.MouseDownBackColor = Color.Gray;
            FormTemizle.FlatAppearance.MouseOverBackColor = Color.Gray;
            FormTemizle.FlatStyle = FlatStyle.Flat;
            FormTemizle.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            FormTemizle.ForeColor = Color.White;
            FormTemizle.Location = new Point(27, 6);
            FormTemizle.Name = "FormTemizle";
            FormTemizle.Size = new Size(125, 33);
            FormTemizle.TabIndex = 114;
            FormTemizle.Text = "FORMU TEMİZLE";
            FormTemizle.UseVisualStyleBackColor = false;
            FormTemizle.Click += FormTemizle_Click;
            // 
            // cmbprofilturu
            // 
            cmbprofilturu.Anchor = AnchorStyles.Top;
            cmbprofilturu.FormattingEnabled = true;
            cmbprofilturu.Items.AddRange(new object[] { "KUTU PROFİL", "H PROFİL", "L PROFİL", "T PROFİL", "U PROFİL", "", "" });
            cmbprofilturu.Location = new Point(153, 60);
            cmbprofilturu.Name = "cmbprofilturu";
            cmbprofilturu.Size = new Size(119, 23);
            cmbprofilturu.TabIndex = 113;
            // 
            // txtsiparistanimi
            // 
            txtsiparistanimi.Anchor = AnchorStyles.Top;
            txtsiparistanimi.Location = new Point(153, 116);
            txtsiparistanimi.Name = "txtsiparistanimi";
            txtsiparistanimi.Size = new Size(119, 83);
            txtsiparistanimi.TabIndex = 112;
            txtsiparistanimi.Text = "";
            // 
            // profilhesaplamatablosu
            // 
            profilhesaplamatablosu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            profilhesaplamatablosu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            profilhesaplamatablosu.Location = new Point(6, 268);
            profilhesaplamatablosu.Name = "profilhesaplamatablosu";
            profilhesaplamatablosu.Size = new Size(1217, 411);
            profilhesaplamatablosu.TabIndex = 111;
            profilhesaplamatablosu.CellFormatting += profilhesaplamatablosu_CellFormatting;
            // 
            // txt_siparisismi
            // 
            txt_siparisismi.Anchor = AnchorStyles.Top;
            txt_siparisismi.Location = new Point(11, 120);
            txt_siparisismi.Name = "txt_siparisismi";
            txt_siparisismi.Size = new Size(121, 23);
            txt_siparisismi.TabIndex = 110;
            // 
            // txtsaatucreti
            // 
            txtsaatucreti.Anchor = AnchorStyles.Top;
            txtsaatucreti.Location = new Point(428, 114);
            txtsaatucreti.Name = "txtsaatucreti";
            txtsaatucreti.Size = new Size(120, 23);
            txtsaatucreti.TabIndex = 109;
            // 
            // txtmakinesaati
            // 
            txtmakinesaati.Anchor = AnchorStyles.Top;
            txtmakinesaati.Location = new Point(428, 176);
            txtmakinesaati.Name = "txtmakinesaati";
            txtmakinesaati.Size = new Size(120, 23);
            txtmakinesaati.TabIndex = 108;
            // 
            // cmbmusteriadi
            // 
            cmbmusteriadi.Anchor = AnchorStyles.Top;
            cmbmusteriadi.FormattingEnabled = true;
            cmbmusteriadi.Location = new Point(11, 60);
            cmbmusteriadi.Name = "cmbmusteriadi";
            cmbmusteriadi.Size = new Size(121, 23);
            cmbmusteriadi.TabIndex = 107;
            // 
            // txtsiparisino
            // 
            txtsiparisino.Anchor = AnchorStyles.Top;
            txtsiparisino.Location = new Point(11, 174);
            txtsiparisino.Name = "txtsiparisino";
            txtsiparisino.Size = new Size(121, 23);
            txtsiparisino.TabIndex = 100;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label1.ForeColor = SystemColors.Desktop;
            label1.Location = new Point(468, 4);
            label1.Name = "label1";
            label1.Size = new Size(487, 30);
            label1.TabIndex = 71;
            label1.Text = "PROFİL FİYAT VE AĞIRLIK HESAPLAMA ARACI";
            // 
            // txtkdvorani
            // 
            txtkdvorani.Anchor = AnchorStyles.Top;
            txtkdvorani.Location = new Point(566, 174);
            txtkdvorani.Margin = new Padding(4, 3, 4, 3);
            txtkdvorani.Name = "txtkdvorani";
            txtkdvorani.Size = new Size(120, 23);
            txtkdvorani.TabIndex = 99;
            // 
            // txtiskontoorani
            // 
            txtiskontoorani.Anchor = AnchorStyles.Top;
            txtiskontoorani.Location = new Point(566, 119);
            txtiskontoorani.Margin = new Padding(4, 3, 4, 3);
            txtiskontoorani.Name = "txtiskontoorani";
            txtiskontoorani.Size = new Size(120, 23);
            txtiskontoorani.TabIndex = 98;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label10.Location = new Point(561, 157);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(56, 17);
            label10.TabIndex = 74;
            label10.Text = "KDV(%)";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label7.Location = new Point(149, 95);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(95, 17);
            label7.TabIndex = 76;
            label7.Text = "Sipariş Tanımı";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label4.Location = new Point(11, 157);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(112, 17);
            label4.TabIndex = 75;
            label4.Text = "Siparis Numarası";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label2.Location = new Point(561, 99);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(90, 17);
            label2.TabIndex = 73;
            label2.Text = "İSKONTO (%)";
            // 
            // btnekle
            // 
            btnekle.Anchor = AnchorStyles.Top;
            btnekle.BackColor = Color.Black;
            btnekle.Cursor = Cursors.Hand;
            btnekle.FlatAppearance.BorderColor = Color.White;
            btnekle.FlatAppearance.BorderSize = 3;
            btnekle.FlatAppearance.CheckedBackColor = Color.Gray;
            btnekle.FlatAppearance.MouseDownBackColor = Color.Gray;
            btnekle.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnekle.FlatStyle = FlatStyle.Flat;
            btnekle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnekle.ForeColor = Color.White;
            btnekle.Location = new Point(1115, 162);
            btnekle.Margin = new Padding(4, 3, 4, 3);
            btnekle.Name = "btnekle";
            btnekle.Size = new Size(114, 37);
            btnekle.TabIndex = 105;
            btnekle.Text = "EKLE";
            btnekle.UseVisualStyleBackColor = false;
            btnekle.Click += btnekle_Click;
            // 
            // btn_guncelle
            // 
            btn_guncelle.Anchor = AnchorStyles.Top;
            btn_guncelle.BackColor = Color.Black;
            btn_guncelle.Cursor = Cursors.Hand;
            btn_guncelle.FlatAppearance.BorderColor = Color.White;
            btn_guncelle.FlatAppearance.BorderSize = 3;
            btn_guncelle.FlatAppearance.CheckedBackColor = Color.Gray;
            btn_guncelle.FlatAppearance.MouseDownBackColor = Color.Gray;
            btn_guncelle.FlatAppearance.MouseOverBackColor = Color.Gray;
            btn_guncelle.FlatStyle = FlatStyle.Flat;
            btn_guncelle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_guncelle.ForeColor = Color.White;
            btn_guncelle.Location = new Point(1115, 71);
            btn_guncelle.Margin = new Padding(4, 3, 4, 3);
            btn_guncelle.Name = "btn_guncelle";
            btn_guncelle.Size = new Size(114, 40);
            btn_guncelle.TabIndex = 106;
            btn_guncelle.Text = "GÜNCELLE";
            btn_guncelle.UseVisualStyleBackColor = false;
            btn_guncelle.Click += btn_guncelle_Click;
            // 
            // btnsatirgetir
            // 
            btnsatirgetir.Anchor = AnchorStyles.Top;
            btnsatirgetir.BackColor = Color.Black;
            btnsatirgetir.Cursor = Cursors.Hand;
            btnsatirgetir.FlatAppearance.BorderColor = Color.White;
            btnsatirgetir.FlatAppearance.BorderSize = 3;
            btnsatirgetir.FlatAppearance.CheckedBackColor = Color.Gray;
            btnsatirgetir.FlatAppearance.MouseDownBackColor = Color.Gray;
            btnsatirgetir.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnsatirgetir.FlatStyle = FlatStyle.Flat;
            btnsatirgetir.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnsatirgetir.ForeColor = Color.White;
            btnsatirgetir.Location = new Point(1115, 33);
            btnsatirgetir.Margin = new Padding(4, 3, 4, 3);
            btnsatirgetir.Name = "btnsatirgetir";
            btnsatirgetir.Size = new Size(114, 40);
            btnsatirgetir.TabIndex = 103;
            btnsatirgetir.Text = "SATIR GETİR";
            btnsatirgetir.UseVisualStyleBackColor = false;
            btnsatirgetir.Click += btnsatirgetir_Click;
            // 
            // btnsil
            // 
            btnsil.Anchor = AnchorStyles.Top;
            btnsil.BackColor = Color.Black;
            btnsil.Cursor = Cursors.Hand;
            btnsil.FlatAppearance.BorderColor = Color.White;
            btnsil.FlatAppearance.BorderSize = 3;
            btnsil.FlatAppearance.CheckedBackColor = Color.Gray;
            btnsil.FlatAppearance.MouseDownBackColor = Color.Gray;
            btnsil.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnsil.FlatStyle = FlatStyle.Flat;
            btnsil.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnsil.ForeColor = Color.White;
            btnsil.Location = new Point(1115, 123);
            btnsil.Margin = new Padding(4, 3, 4, 3);
            btnsil.Name = "btnsil";
            btnsil.Size = new Size(114, 40);
            btnsil.TabIndex = 104;
            btnsil.Text = "SİL";
            btnsil.UseVisualStyleBackColor = false;
            btnsil.Click += btnsil_Click;
            // 
            // btnsaatfiyathesapla
            // 
            btnsaatfiyathesapla.Anchor = AnchorStyles.Top;
            btnsaatfiyathesapla.BackColor = Color.Black;
            btnsaatfiyathesapla.Cursor = Cursors.Hand;
            btnsaatfiyathesapla.FlatAppearance.BorderColor = Color.White;
            btnsaatfiyathesapla.FlatAppearance.BorderSize = 3;
            btnsaatfiyathesapla.FlatAppearance.CheckedBackColor = Color.Gray;
            btnsaatfiyathesapla.FlatAppearance.MouseDownBackColor = Color.Gray;
            btnsaatfiyathesapla.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnsaatfiyathesapla.FlatStyle = FlatStyle.Flat;
            btnsaatfiyathesapla.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnsaatfiyathesapla.ForeColor = Color.White;
            btnsaatfiyathesapla.Location = new Point(719, 43);
            btnsaatfiyathesapla.Margin = new Padding(4, 3, 4, 3);
            btnsaatfiyathesapla.Name = "btnsaatfiyathesapla";
            btnsaatfiyathesapla.Size = new Size(169, 40);
            btnsaatfiyathesapla.TabIndex = 102;
            btnsaatfiyathesapla.Text = " FİYAT HESAPLA";
            btnsaatfiyathesapla.UseVisualStyleBackColor = false;
            btnsaatfiyathesapla.Click += btnsaatfiyathesapla_Click;
            // 
            // txtparcasayisi
            // 
            txtparcasayisi.Anchor = AnchorStyles.Top;
            txtparcasayisi.Location = new Point(566, 60);
            txtparcasayisi.Margin = new Padding(4, 3, 4, 3);
            txtparcasayisi.Name = "txtparcasayisi";
            txtparcasayisi.Size = new Size(120, 23);
            txtparcasayisi.TabIndex = 97;
            // 
            // txtboy
            // 
            txtboy.Anchor = AnchorStyles.Top;
            txtboy.Location = new Point(428, 60);
            txtboy.Margin = new Padding(4, 3, 4, 3);
            txtboy.Name = "txtboy";
            txtboy.Size = new Size(120, 23);
            txtboy.TabIndex = 96;
            // 
            // btnagirlikhesapla
            // 
            btnagirlikhesapla.Anchor = AnchorStyles.Top;
            btnagirlikhesapla.BackColor = Color.Black;
            btnagirlikhesapla.Cursor = Cursors.Hand;
            btnagirlikhesapla.FlatAppearance.BorderColor = Color.White;
            btnagirlikhesapla.FlatAppearance.BorderSize = 3;
            btnagirlikhesapla.FlatAppearance.CheckedBackColor = Color.Gray;
            btnagirlikhesapla.FlatAppearance.MouseDownBackColor = Color.Gray;
            btnagirlikhesapla.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnagirlikhesapla.FlatStyle = FlatStyle.Flat;
            btnagirlikhesapla.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnagirlikhesapla.ForeColor = Color.White;
            btnagirlikhesapla.Location = new Point(933, 42);
            btnagirlikhesapla.Margin = new Padding(4, 3, 4, 3);
            btnagirlikhesapla.Name = "btnagirlikhesapla";
            btnagirlikhesapla.Size = new Size(161, 41);
            btnagirlikhesapla.TabIndex = 101;
            btnagirlikhesapla.Text = "AĞIRLIK HESAPLA";
            btnagirlikhesapla.UseVisualStyleBackColor = false;
            btnagirlikhesapla.Click += btnagirlikhesapla_Click;
            // 
            // txtkalinlik
            // 
            txtkalinlik.Anchor = AnchorStyles.Top;
            txtkalinlik.FormattingEnabled = true;
            txtkalinlik.Items.AddRange(new object[] { "0.6", "0.7", "0.8", "0.9", "1.0", "1.2", "1.5" });
            txtkalinlik.Location = new Point(289, 176);
            txtkalinlik.Margin = new Padding(4, 3, 4, 3);
            txtkalinlik.Name = "txtkalinlik";
            txtkalinlik.Size = new Size(120, 23);
            txtkalinlik.TabIndex = 95;
            // 
            // txtgenislik
            // 
            txtgenislik.Anchor = AnchorStyles.Top;
            txtgenislik.FormattingEnabled = true;
            txtgenislik.Items.AddRange(new object[] { "10", "15", "20", "25", "30", "40", "50", "60", "70", "80", "90", "100", "120", "150", "180", "200", "250", "300", "350", "400", "450", "500" });
            txtgenislik.Location = new Point(290, 60);
            txtgenislik.Margin = new Padding(4, 3, 4, 3);
            txtgenislik.Name = "txtgenislik";
            txtgenislik.Size = new Size(120, 23);
            txtgenislik.TabIndex = 93;
            // 
            // txtyukseklık
            // 
            txtyukseklık.Anchor = AnchorStyles.Top;
            txtyukseklık.FormattingEnabled = true;
            txtyukseklık.Items.AddRange(new object[] { "40", "50", "60", "70", "80", "90", "100", "120", "150", "180", "200", "250", "300", "350", "400", "450", "500" });
            txtyukseklık.Location = new Point(290, 116);
            txtyukseklık.Margin = new Padding(4, 3, 4, 3);
            txtyukseklık.Name = "txtyukseklık";
            txtyukseklık.Size = new Size(120, 23);
            txtyukseklık.TabIndex = 94;
            // 
            // lbl_tumagirlik
            // 
            lbl_tumagirlik.Anchor = AnchorStyles.Top;
            lbl_tumagirlik.AutoSize = true;
            lbl_tumagirlik.BackColor = SystemColors.ControlDarkDark;
            lbl_tumagirlik.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic);
            lbl_tumagirlik.ForeColor = Color.White;
            lbl_tumagirlik.Location = new Point(1154, 236);
            lbl_tumagirlik.Margin = new Padding(4, 0, 4, 0);
            lbl_tumagirlik.Name = "lbl_tumagirlik";
            lbl_tumagirlik.Size = new Size(38, 21);
            lbl_tumagirlik.TabIndex = 92;
            lbl_tumagirlik.Text = "----";
            lbl_tumagirlik.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_tumtoplam
            // 
            lbl_tumtoplam.Anchor = AnchorStyles.Top;
            lbl_tumtoplam.AutoSize = true;
            lbl_tumtoplam.BackColor = SystemColors.ControlDarkDark;
            lbl_tumtoplam.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic);
            lbl_tumtoplam.ForeColor = Color.White;
            lbl_tumtoplam.Location = new Point(1065, 236);
            lbl_tumtoplam.Margin = new Padding(4, 0, 4, 0);
            lbl_tumtoplam.Name = "lbl_tumtoplam";
            lbl_tumtoplam.Size = new Size(38, 21);
            lbl_tumtoplam.TabIndex = 91;
            lbl_tumtoplam.Text = "----";
            lbl_tumtoplam.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label22
            // 
            label22.Anchor = AnchorStyles.Top;
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Underline);
            label22.ForeColor = SystemColors.ControlText;
            label22.Location = new Point(1149, 214);
            label22.Margin = new Padding(4, 0, 4, 0);
            label22.Name = "label22";
            label22.Size = new Size(57, 17);
            label22.TabIndex = 84;
            label22.Text = "AĞIRLIK";
            // 
            // lblnetfiyat
            // 
            lblnetfiyat.Anchor = AnchorStyles.Top;
            lblnetfiyat.AutoSize = true;
            lblnetfiyat.BackColor = SystemColors.ControlDarkDark;
            lblnetfiyat.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic);
            lblnetfiyat.ForeColor = Color.White;
            lblnetfiyat.Location = new Point(433, 236);
            lblnetfiyat.Margin = new Padding(4, 0, 4, 0);
            lblnetfiyat.Name = "lblnetfiyat";
            lblnetfiyat.Size = new Size(38, 21);
            lblnetfiyat.TabIndex = 90;
            lblnetfiyat.Text = "----";
            lblnetfiyat.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            label20.Anchor = AnchorStyles.Top;
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Underline);
            label20.ForeColor = SystemColors.ControlText;
            label20.Location = new Point(1062, 214);
            label20.Margin = new Padding(4, 0, 4, 0);
            label20.Name = "label20";
            label20.Size = new Size(71, 17);
            label20.TabIndex = 83;
            label20.Text = "NET FİYAT";
            // 
            // label19
            // 
            label19.Anchor = AnchorStyles.Top;
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Underline);
            label19.ForeColor = SystemColors.ControlText;
            label19.Location = new Point(430, 214);
            label19.Margin = new Padding(4, 0, 4, 0);
            label19.Name = "label19";
            label19.Size = new Size(71, 17);
            label19.TabIndex = 82;
            label19.Text = "NET FİYAT";
            // 
            // lblkdvtutar
            // 
            lblkdvtutar.Anchor = AnchorStyles.Top;
            lblkdvtutar.AutoSize = true;
            lblkdvtutar.BackColor = SystemColors.ControlDarkDark;
            lblkdvtutar.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic);
            lblkdvtutar.ForeColor = Color.White;
            lblkdvtutar.Location = new Point(324, 236);
            lblkdvtutar.Margin = new Padding(4, 0, 4, 0);
            lblkdvtutar.Name = "lblkdvtutar";
            lblkdvtutar.Size = new Size(38, 21);
            lblkdvtutar.TabIndex = 89;
            lblkdvtutar.Text = "----";
            lblkdvtutar.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            label18.Anchor = AnchorStyles.Top;
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Underline);
            label18.ForeColor = SystemColors.ControlText;
            label18.Location = new Point(317, 214);
            label18.Margin = new Padding(4, 0, 4, 0);
            label18.Name = "label18";
            label18.Size = new Size(84, 17);
            label18.TabIndex = 81;
            label18.Text = "KDV TUTARI";
            // 
            // lblilkfiyat
            // 
            lblilkfiyat.Anchor = AnchorStyles.Top;
            lblilkfiyat.AutoSize = true;
            lblilkfiyat.BackColor = SystemColors.ControlDarkDark;
            lblilkfiyat.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic);
            lblilkfiyat.ForeColor = Color.White;
            lblilkfiyat.Location = new Point(9, 236);
            lblilkfiyat.Margin = new Padding(4, 0, 4, 0);
            lblilkfiyat.Name = "lblilkfiyat";
            lblilkfiyat.Size = new Size(38, 21);
            lblilkfiyat.TabIndex = 86;
            lblilkfiyat.Text = "----";
            lblilkfiyat.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbliskontotutar
            // 
            lbliskontotutar.Anchor = AnchorStyles.Top;
            lbliskontotutar.AutoSize = true;
            lbliskontotutar.BackColor = SystemColors.ControlDarkDark;
            lbliskontotutar.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic);
            lbliskontotutar.ForeColor = Color.White;
            lbliskontotutar.Location = new Point(92, 236);
            lbliskontotutar.Margin = new Padding(4, 0, 4, 0);
            lbliskontotutar.Name = "lbliskontotutar";
            lbliskontotutar.Size = new Size(38, 21);
            lbliskontotutar.TabIndex = 87;
            lbliskontotutar.Text = "----";
            lbliskontotutar.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbliskontolufiyat
            // 
            lbliskontolufiyat.Anchor = AnchorStyles.Top;
            lbliskontolufiyat.AutoSize = true;
            lbliskontolufiyat.BackColor = SystemColors.ControlDarkDark;
            lbliskontolufiyat.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic);
            lbliskontolufiyat.ForeColor = Color.White;
            lbliskontolufiyat.Location = new Point(198, 236);
            lbliskontolufiyat.Margin = new Padding(4, 0, 4, 0);
            lbliskontolufiyat.Name = "lbliskontolufiyat";
            lbliskontolufiyat.Size = new Size(38, 21);
            lbliskontolufiyat.TabIndex = 88;
            lbliskontolufiyat.Text = "----";
            lbliskontolufiyat.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Underline);
            label9.ForeColor = SystemColors.ControlText;
            label9.Location = new Point(92, 214);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(65, 17);
            label9.TabIndex = 79;
            label9.Text = "İSKONTO";
            // 
            // label21
            // 
            label21.Anchor = AnchorStyles.Top;
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Underline);
            label21.ForeColor = SystemColors.ControlText;
            label21.Location = new Point(181, 214);
            label21.Margin = new Padding(4, 0, 4, 0);
            label21.Name = "label21";
            label21.Size = new Size(119, 17);
            label21.TabIndex = 80;
            label21.Text = "İSKONTOLU FİYAT";
            label21.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl1
            // 
            lbl1.Anchor = AnchorStyles.Top;
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Underline);
            lbl1.ForeColor = SystemColors.ControlText;
            lbl1.Location = new Point(6, 214);
            lbl1.Margin = new Padding(4, 0, 4, 0);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(42, 17);
            lbl1.TabIndex = 78;
            lbl1.Text = "FİYAT";
            // 
            // lblagirliksonuc
            // 
            lblagirliksonuc.Anchor = AnchorStyles.Top;
            lblagirliksonuc.AutoSize = true;
            lblagirliksonuc.BackColor = SystemColors.ControlDarkDark;
            lblagirliksonuc.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic);
            lblagirliksonuc.ForeColor = Color.White;
            lblagirliksonuc.Location = new Point(555, 236);
            lblagirliksonuc.Margin = new Padding(4, 0, 4, 0);
            lblagirliksonuc.Name = "lblagirliksonuc";
            lblagirliksonuc.Size = new Size(38, 21);
            lblagirliksonuc.TabIndex = 85;
            lblagirliksonuc.Text = "----";
            lblagirliksonuc.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl30
            // 
            lbl30.Anchor = AnchorStyles.Top;
            lbl30.AutoSize = true;
            lbl30.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Underline);
            lbl30.Location = new Point(521, 214);
            lbl30.Margin = new Padding(4, 0, 4, 0);
            lbl30.Name = "lbl30";
            lbl30.Size = new Size(147, 17);
            lbl30.TabIndex = 77;
            lbl30.Text = "HESAPLANAN AĞIRLIK";
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Top;
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label15.Location = new Point(458, 40);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(30, 17);
            label15.TabIndex = 70;
            label15.Text = "(m)";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label3.Location = new Point(425, 39);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(34, 17);
            label3.TabIndex = 69;
            label3.Text = "BOY";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label6.Location = new Point(290, 155);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(65, 17);
            label6.TabIndex = 67;
            label6.Text = "KALINLIK";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top;
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label11.Location = new Point(290, 97);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(74, 17);
            label11.TabIndex = 65;
            label11.Text = "YÜKSEKLİK";
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.Top;
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label16.Location = new Point(362, 155);
            label16.Margin = new Padding(4, 0, 4, 0);
            label16.Name = "label16";
            label16.Size = new Size(36, 17);
            label16.TabIndex = 68;
            label16.Text = "(cm)";
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top;
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label13.Location = new Point(369, 97);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(42, 17);
            label13.TabIndex = 66;
            label13.Text = "(mm)";
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top;
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label12.Location = new Point(363, 39);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(42, 17);
            label12.TabIndex = 64;
            label12.Text = "(mm)";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label8.Location = new Point(566, 43);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(91, 17);
            label8.TabIndex = 72;
            label8.Text = "PARÇA SAYISI";
            // 
            // label25
            // 
            label25.Anchor = AnchorStyles.Top;
            label25.AutoSize = true;
            label25.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label25.Location = new Point(425, 94);
            label25.Margin = new Padding(4, 0, 4, 0);
            label25.Name = "label25";
            label25.Size = new Size(74, 17);
            label25.TabIndex = 62;
            label25.Text = "Saat Ücreti";
            // 
            // label24
            // 
            label24.Anchor = AnchorStyles.Top;
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label24.Location = new Point(422, 156);
            label24.Margin = new Padding(4, 0, 4, 0);
            label24.Name = "label24";
            label24.Size = new Size(139, 17);
            label24.TabIndex = 61;
            label24.Text = "Makine Çalışma Saati";
            // 
            // label28
            // 
            label28.Anchor = AnchorStyles.Top;
            label28.AutoSize = true;
            label28.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label28.Location = new Point(11, 100);
            label28.Margin = new Padding(4, 0, 4, 0);
            label28.Name = "label28";
            label28.Size = new Size(79, 17);
            label28.TabIndex = 60;
            label28.Text = "Sipariş İsmi";
            // 
            // label17
            // 
            label17.Anchor = AnchorStyles.Top;
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label17.Location = new Point(153, 40);
            label17.Margin = new Padding(4, 0, 4, 0);
            label17.Name = "label17";
            label17.Size = new Size(74, 17);
            label17.TabIndex = 59;
            label17.Text = "Profil Türü";
            // 
            // label26
            // 
            label26.Anchor = AnchorStyles.Top;
            label26.AutoSize = true;
            label26.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label26.Location = new Point(11, 40);
            label26.Margin = new Padding(4, 0, 4, 0);
            label26.Name = "label26";
            label26.Size = new Size(80, 17);
            label26.TabIndex = 63;
            label26.Text = "Müşteri Adı";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label5.Location = new Point(287, 40);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(64, 17);
            label5.TabIndex = 58;
            label5.Text = "GENİŞLİK";
            // 
            // txtsiparisnosorgula
            // 
            txtsiparisnosorgula.Anchor = AnchorStyles.Top;
            txtsiparisnosorgula.Location = new Point(723, 145);
            txtsiparisnosorgula.Name = "txtsiparisnosorgula";
            txtsiparisnosorgula.Size = new Size(120, 23);
            txtsiparisnosorgula.TabIndex = 115;
            // 
            // tumdegerleribul
            // 
            tumdegerleribul.Anchor = AnchorStyles.Top;
            tumdegerleribul.BackColor = Color.Black;
            tumdegerleribul.Cursor = Cursors.Hand;
            tumdegerleribul.FlatAppearance.BorderColor = Color.White;
            tumdegerleribul.FlatAppearance.BorderSize = 3;
            tumdegerleribul.FlatAppearance.CheckedBackColor = Color.Gray;
            tumdegerleribul.FlatAppearance.MouseDownBackColor = Color.Gray;
            tumdegerleribul.FlatAppearance.MouseOverBackColor = Color.Gray;
            tumdegerleribul.FlatStyle = FlatStyle.Flat;
            tumdegerleribul.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            tumdegerleribul.ForeColor = Color.White;
            tumdegerleribul.Location = new Point(862, 141);
            tumdegerleribul.Name = "tumdegerleribul";
            tumdegerleribul.Size = new Size(84, 29);
            tumdegerleribul.TabIndex = 116;
            tumdegerleribul.Text = "TOPLA";
            tumdegerleribul.UseVisualStyleBackColor = false;
            tumdegerleribul.Click += tumdegerleribul_Click;
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Top;
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 162);
            label14.Location = new Point(709, 99);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(399, 25);
            label14.TabIndex = 72;
            label14.Text = "Hesaplanması İstediğin Sipariş Numarası";
            // 
            // lbltoplamsaat
            // 
            lbltoplamsaat.Anchor = AnchorStyles.Top;
            lbltoplamsaat.AutoSize = true;
            lbltoplamsaat.BackColor = SystemColors.ControlDarkDark;
            lbltoplamsaat.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic);
            lbltoplamsaat.ForeColor = Color.White;
            lbltoplamsaat.Location = new Point(986, 236);
            lbltoplamsaat.Margin = new Padding(4, 0, 4, 0);
            lbltoplamsaat.Name = "lbltoplamsaat";
            lbltoplamsaat.Size = new Size(38, 21);
            lbltoplamsaat.TabIndex = 85;
            lbltoplamsaat.Text = "----";
            lbltoplamsaat.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbltoplamiskonto
            // 
            lbltoplamiskonto.Anchor = AnchorStyles.Top;
            lbltoplamiskonto.AutoSize = true;
            lbltoplamiskonto.BackColor = SystemColors.ControlDarkDark;
            lbltoplamiskonto.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic);
            lbltoplamiskonto.ForeColor = Color.White;
            lbltoplamiskonto.Location = new Point(801, 236);
            lbltoplamiskonto.Margin = new Padding(4, 0, 4, 0);
            lbltoplamiskonto.Name = "lbltoplamiskonto";
            lbltoplamiskonto.Size = new Size(38, 21);
            lbltoplamiskonto.TabIndex = 85;
            lbltoplamiskonto.Text = "----";
            lbltoplamiskonto.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbltoplamkdv
            // 
            lbltoplamkdv.Anchor = AnchorStyles.Top;
            lbltoplamkdv.AutoSize = true;
            lbltoplamkdv.BackColor = SystemColors.ControlDarkDark;
            lbltoplamkdv.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic);
            lbltoplamkdv.ForeColor = Color.White;
            lbltoplamkdv.Location = new Point(896, 236);
            lbltoplamkdv.Margin = new Padding(4, 0, 4, 0);
            lbltoplamkdv.Name = "lbltoplamkdv";
            lbltoplamkdv.Size = new Size(38, 21);
            lbltoplamkdv.TabIndex = 85;
            lbltoplamkdv.Text = "----";
            lbltoplamkdv.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label23
            // 
            label23.Anchor = AnchorStyles.Top;
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 162);
            label23.ForeColor = Color.DarkRed;
            label23.Location = new Point(853, 178);
            label23.Margin = new Padding(4, 0, 4, 0);
            label23.Name = "label23";
            label23.Size = new Size(195, 25);
            label23.TabIndex = 83;
            label23.Text = "TOPLAM DEĞERLER";
            // 
            // label27
            // 
            label27.Anchor = AnchorStyles.Top;
            label27.AutoSize = true;
            label27.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Underline);
            label27.ForeColor = SystemColors.ControlText;
            label27.Location = new Point(992, 214);
            label27.Margin = new Padding(4, 0, 4, 0);
            label27.Name = "label27";
            label27.Size = new Size(40, 17);
            label27.TabIndex = 83;
            label27.Text = "SAAT";
            // 
            // label29
            // 
            label29.Anchor = AnchorStyles.Top;
            label29.AutoSize = true;
            label29.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Underline);
            label29.ForeColor = SystemColors.ControlText;
            label29.Location = new Point(774, 214);
            label29.Margin = new Padding(4, 0, 4, 0);
            label29.Name = "label29";
            label29.Size = new Size(114, 17);
            label29.TabIndex = 83;
            label29.Text = "İSKONTO TUTARI";
            // 
            // label30
            // 
            label30.Anchor = AnchorStyles.Top;
            label30.AutoSize = true;
            label30.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Underline);
            label30.ForeColor = SystemColors.ControlText;
            label30.Location = new Point(891, 214);
            label30.Margin = new Padding(4, 0, 4, 0);
            label30.Name = "label30";
            label30.Size = new Size(84, 17);
            label30.TabIndex = 84;
            label30.Text = "KDV TUTARI";
            // 
            // degerlerigonder
            // 
            degerlerigonder.Anchor = AnchorStyles.Top;
            degerlerigonder.BackColor = Color.DarkRed;
            degerlerigonder.Cursor = Cursors.Hand;
            degerlerigonder.FlatAppearance.BorderColor = Color.White;
            degerlerigonder.FlatAppearance.BorderSize = 3;
            degerlerigonder.FlatAppearance.CheckedBackColor = Color.Gray;
            degerlerigonder.FlatAppearance.MouseDownBackColor = Color.Gray;
            degerlerigonder.FlatAppearance.MouseOverBackColor = Color.Gray;
            degerlerigonder.FlatStyle = FlatStyle.Flat;
            degerlerigonder.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            degerlerigonder.ForeColor = Color.White;
            degerlerigonder.Location = new Point(952, 140);
            degerlerigonder.Name = "degerlerigonder";
            degerlerigonder.Size = new Size(142, 29);
            degerlerigonder.TabIndex = 116;
            degerlerigonder.Text = "SİPARİŞ OLUŞTUR";
            degerlerigonder.UseVisualStyleBackColor = false;
            degerlerigonder.Click += degerlerigonder_Click;
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
            button1.TabIndex = 117;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtGenelArama
            // 
            txtGenelArama.Anchor = AnchorStyles.Top;
            txtGenelArama.Location = new Point(287, 10);
            txtGenelArama.Name = "txtGenelArama";
            txtGenelArama.Size = new Size(120, 23);
            txtGenelArama.TabIndex = 119;
            txtGenelArama.TextChanged += txtGenelArama_TextChanged;
            // 
            // label31
            // 
            label31.Anchor = AnchorStyles.Top;
            label31.AutoSize = true;
            label31.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label31.Location = new Point(196, 11);
            label31.Name = "label31";
            label31.Size = new Size(85, 17);
            label31.TabIndex = 118;
            label31.Text = "Tabloda Bul:";
            // 
            // label32
            // 
            label32.Anchor = AnchorStyles.Top;
            label32.AutoSize = true;
            label32.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Underline);
            label32.ForeColor = SystemColors.ControlText;
            label32.Location = new Point(687, 214);
            label32.Margin = new Padding(4, 0, 4, 0);
            label32.Name = "label32";
            label32.Size = new Size(79, 17);
            label32.TabIndex = 83;
            label32.Text = "BRÜT FİYAT";
            // 
            // lblbrutfiyat
            // 
            lblbrutfiyat.Anchor = AnchorStyles.Top;
            lblbrutfiyat.AutoSize = true;
            lblbrutfiyat.BackColor = SystemColors.ControlDarkDark;
            lblbrutfiyat.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic);
            lblbrutfiyat.ForeColor = Color.White;
            lblbrutfiyat.Location = new Point(687, 236);
            lblbrutfiyat.Margin = new Padding(4, 0, 4, 0);
            lblbrutfiyat.Name = "lblbrutfiyat";
            lblbrutfiyat.Size = new Size(38, 21);
            lblbrutfiyat.TabIndex = 85;
            lblbrutfiyat.Text = "----";
            lblbrutfiyat.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblkdvorani
            // 
            lblkdvorani.Anchor = AnchorStyles.Top;
            lblkdvorani.AutoSize = true;
            lblkdvorani.Location = new Point(723, 179);
            lblkdvorani.Name = "lblkdvorani";
            lblkdvorani.Size = new Size(44, 15);
            lblkdvorani.TabIndex = 120;
            lblkdvorani.Text = "label33";
            lblkdvorani.Visible = false;
            // 
            // lbliskontoorani
            // 
            lbliskontoorani.Anchor = AnchorStyles.Top;
            lbliskontoorani.AutoSize = true;
            lbliskontoorani.Location = new Point(776, 177);
            lbliskontoorani.Name = "lbliskontoorani";
            lbliskontoorani.Size = new Size(44, 15);
            lbliskontoorani.TabIndex = 120;
            lbliskontoorani.Text = "label33";
            lbliskontoorani.Visible = false;
            // 
            // ProfilFiyatHesaplama
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(1235, 691);
            Controls.Add(lbliskontoorani);
            Controls.Add(lblkdvorani);
            Controls.Add(txtGenelArama);
            Controls.Add(label31);
            Controls.Add(button1);
            Controls.Add(degerlerigonder);
            Controls.Add(tumdegerleribul);
            Controls.Add(txtsiparisnosorgula);
            Controls.Add(FormTemizle);
            Controls.Add(cmbprofilturu);
            Controls.Add(txtsiparistanimi);
            Controls.Add(profilhesaplamatablosu);
            Controls.Add(txt_siparisismi);
            Controls.Add(txtsaatucreti);
            Controls.Add(txtmakinesaati);
            Controls.Add(cmbmusteriadi);
            Controls.Add(txtsiparisino);
            Controls.Add(label1);
            Controls.Add(txtkdvorani);
            Controls.Add(txtiskontoorani);
            Controls.Add(label10);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(btnekle);
            Controls.Add(btn_guncelle);
            Controls.Add(btnsatirgetir);
            Controls.Add(btnsil);
            Controls.Add(btnsaatfiyathesapla);
            Controls.Add(txtparcasayisi);
            Controls.Add(txtboy);
            Controls.Add(btnagirlikhesapla);
            Controls.Add(txtkalinlik);
            Controls.Add(txtgenislik);
            Controls.Add(txtyukseklık);
            Controls.Add(lbl_tumagirlik);
            Controls.Add(lbl_tumtoplam);
            Controls.Add(label30);
            Controls.Add(label22);
            Controls.Add(lblnetfiyat);
            Controls.Add(label23);
            Controls.Add(label27);
            Controls.Add(label32);
            Controls.Add(label29);
            Controls.Add(label20);
            Controls.Add(label19);
            Controls.Add(lblkdvtutar);
            Controls.Add(label18);
            Controls.Add(lblilkfiyat);
            Controls.Add(lbliskontotutar);
            Controls.Add(lbliskontolufiyat);
            Controls.Add(label9);
            Controls.Add(label21);
            Controls.Add(lbl1);
            Controls.Add(lbltoplamkdv);
            Controls.Add(lblbrutfiyat);
            Controls.Add(lbltoplamiskonto);
            Controls.Add(lbltoplamsaat);
            Controls.Add(lblagirliksonuc);
            Controls.Add(lbl30);
            Controls.Add(label15);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(label11);
            Controls.Add(label16);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label14);
            Controls.Add(label8);
            Controls.Add(label25);
            Controls.Add(label24);
            Controls.Add(label28);
            Controls.Add(label17);
            Controls.Add(label26);
            Controls.Add(label5);
            Margin = new Padding(4, 3, 4, 3);
            Name = "ProfilFiyatHesaplama";
            Text = "PROFİL FİYAT VE AĞIRLIK HESAPLAMA ARACI";
            Load += ProfilFiyatHesaplama_Load;
            ((System.ComponentModel.ISupportInitialize)profilhesaplamatablosu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PrintDialog printDialog1;
        private Button FormTemizle;
        private ComboBox cmbprofilturu;
        private RichTextBox txtsiparistanimi;
        private DataGridView profilhesaplamatablosu;
        private TextBox txt_siparisismi;
        private TextBox txtsaatucreti;
        private TextBox txtmakinesaati;
        private ComboBox cmbmusteriadi;
        private TextBox txtsiparisino;
        private Label label1;
        private TextBox txtkdvorani;
        private TextBox txtiskontoorani;
        private Label label10;
        private Label label7;
        private Label label4;
        private Label label2;
        private Button btnekle;
        private Button btn_guncelle;
        private Button btnsatirgetir;
        private Button btnsil;
        private Button btnsaatfiyathesapla;
        private TextBox txtparcasayisi;
        private TextBox txtboy;
        private Button btnagirlikhesapla;
        private ComboBox txtkalinlik;
        private ComboBox txtgenislik;
        private ComboBox txtyukseklık;
        private Label lbl_tumagirlik;
        private Label lbl_tumtoplam;
        private Label label22;
        private Label lblnetfiyat;
        private Label label20;
        private Label label19;
        private Label lblkdvtutar;
        private Label label18;
        private Label lblilkfiyat;
        private Label lbliskontotutar;
        private Label lbliskontolufiyat;
        private Label label9;
        private Label label21;
        private Label lbl1;
        private Label lblagirliksonuc;
        private Label lbl30;
        private Label label15;
        private Label label3;
        private Label label6;
        private Label label11;
        private Label label16;
        private Label label13;
        private Label label12;
        private Label label8;
        private Label label25;
        private Label label24;
        private Label label28;
        private Label label17;
        private Label label26;
        private Label label5;
        private TextBox txtsiparisnosorgula;
        private Button tumdegerleribul;
        private Label label14;
        private Label lbltoplamsaat;
        private Label lbltoplamiskonto;
        private Label lbltoplamkdv;
        private Label label23;
        private Label label27;
        private Label label29;
        private Label label30;
        private Button degerlerigonder;
        private Button button1;
        private TextBox txtGenelArama;
        private Label label31;
        private Label label32;
        private Label lblbrutfiyat;
        private Label lblkdvorani;
        private Label lbliskontoorani;
    }

       
    }
