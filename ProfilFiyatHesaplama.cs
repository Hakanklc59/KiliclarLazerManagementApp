using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YonetimBilgiSistemleri
{
    public partial class ProfilFiyatHesaplama : Form
    {
        public Siparis selectedSiparis; // Seçili sipariş için değişken

        public ProfilFiyatHesaplama()
        {
            InitializeComponent();
        }
        private void InitializeDataGridView()
        {
            using (var context = new MyDbContext())
            {
                // DataGridView kontrolünü ayarlayın
                profilhesaplamatablosu.AutoGenerateColumns = false; // Otomatik sütun oluşturmayı kapatın

                // Sütun tanımları
                var columns = new (string ColumnName, string HeaderText, int DisplayIndex)[]
                {
        ("SiparisNumarasi", "Sipariş NO", 0),
        ("MusteriAdi", "Müşteri Adı", 1),
        ("SiparisIsmi", "Sipariş Adı", 2),
        ("SiparisAciklamasi", "Sipariş Açıklaması", 3),
         ("ProfilTuru", "Profil Türü", 4),
        ("SaatUcreti", "Makine Saat Ücreti", 5),
        ("MakineCalismaSaati", "Makine Çalışma Saati", 6),
        ("kdvsizindirimsiztutar", "Brüt Fiyat", 7),
        ("IskontoTutari", "İskonto Tutarı",8),
        ("kdvsizindirimlitutar", "İskontolu Tutar", 9),
        ("KDVTutari", "KDV Tutarı", 10),
        ("nettutar", "Net Tutar", 11),
        ("DisYukseklik", "Profil Yüksekliği", 12),
        ("DisGenislik", "Profil Genişliği", 13),
        ("Kalinlik", "Profil Et Kalınlığı", 14),
        ("Uzunluk", "Profil Uzunluğu", 15),
        ("ParcaSayi", "Adet Sayisi", 16),
          ("Agirlik", "Sipariş Ağırlığı", 17),
        ("KDVOrani", "KDV Oranı", 18),
        ("IskontoOrani", "Iskonto Oranı", 19),

                ("SiparisID", "SiparisID", 20)

                    };


                // Sütunları DataGridView'e ekleyin
                foreach (var column in columns)
                {
                    var dataGridViewColumn = new DataGridViewTextBoxColumn
                    {
                        Name = column.ColumnName,
                        HeaderText = column.HeaderText,
                        DataPropertyName = column.ColumnName,
                        DisplayIndex = column.DisplayIndex
                    };

                    profilhesaplamatablosu.Columns.Add(dataGridViewColumn);
                }

                // DataGridView'i doldurun
                // Örnek veri kaynağı olarak context kullanıldı, kendi veri kaynağınızı buraya ekleyin
                profilhesaplamatablosu.DataSource = context.profilhesaplama.ToList(); // Burada 'context.Faturalar' ile fatura verilerinizi çekin
            }



            profilhesaplamatablosu.EnableHeadersVisualStyles = false;
            profilhesaplamatablosu.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 45, 48); // Daha yumuşak bir koyu renk
            profilhesaplamatablosu.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            profilhesaplamatablosu.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel); // Kalın (bold) font
            profilhesaplamatablosu.ColumnHeadersHeight = 45; // Sütun başlık yüksekliği

            // Alternatif satır renkleri ve arka plan
            profilhesaplamatablosu.RowsDefaultCellStyle.BackColor = Color.White;
            profilhesaplamatablosu.RowsDefaultCellStyle.ForeColor = Color.Black;
            profilhesaplamatablosu.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240); // Hafif gri ton

            // Satır kenar çizgileri için stil
            profilhesaplamatablosu.CellBorderStyle = DataGridViewCellBorderStyle.None; // Hücre çizgilerini kaldırıyoruz

            // Satırlar arasındaki boşluk
            profilhesaplamatablosu.RowTemplate.DividerHeight = 5; // Satırlar arasına boşluk ekliyoruz (arttırıldı)
            profilhesaplamatablosu.RowTemplate.Height = 40; // Satır yüksekliği (biraz daha yüksek olabilir)

            // Satır başlıklarını görünür yaparak sol tarafa seçim işareti ekliyoruz
            profilhesaplamatablosu.RowHeadersVisible = true; // Satır başlıkları görünüyor
            profilhesaplamatablosu.RowHeadersWidth = 29; // Başlıklar için genişlik azaltıldı
            profilhesaplamatablosu.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 45, 48); // Sol başlık arka plan rengi
            profilhesaplamatablosu.RowHeadersDefaultCellStyle.ForeColor = Color.White; // Sol başlık metin rengi
            profilhesaplamatablosu.RowHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(30, 30, 30); // Seçildiğinde başlık arka planı
                                                                                                               // DataGridView sütunlarının otomatik boyutlandırma ayarı
                                                                                                               // DataGridView'de hücrelerin sarılması
            profilhesaplamatablosu.DefaultCellStyle.WrapMode = DataGridViewTriState.True; // Hücre içeriğini sar

            // DataGridView'deki satırların otomatik yüksekliğini ayarlama
            profilhesaplamatablosu.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells; // Tüm hücreler için satır yüksekliğini ayarla


            // Seçilen hücreler için stil
            profilhesaplamatablosu.DefaultCellStyle.SelectionBackColor = Color.FromArgb(45, 45, 48); // Modern bir mavi ton
            profilhesaplamatablosu.DefaultCellStyle.SelectionForeColor = Color.White;

            // DataGridView kenarlık stili (kenarlık renklerini ayarlıyoruz)
            profilhesaplamatablosu.AdvancedColumnHeadersBorderStyle.All = DataGridViewAdvancedCellBorderStyle.Single; // Sütun başlık kenarlıkları
            profilhesaplamatablosu.AdvancedCellBorderStyle.All = DataGridViewAdvancedCellBorderStyle.Single; // Hücreler arası kenarlık

            // Hücrelerin köşelerine ve gölgelerine benzer bir efekt için padding ekleyebiliriz
            profilhesaplamatablosu.DefaultCellStyle.Padding = new Padding(5); // Hücrelerin içerisine padding ekleyerek ferah bir görünüm
            profilhesaplamatablosu.AlternatingRowsDefaultCellStyle.Padding = new Padding(5);

            // DataGridView için çizgi renklerini belirleyebiliriz
            profilhesaplamatablosu.GridColor = Color.LightGray; // Hücreler arası çizgi rengi

            // Arka plan rengini yumuşak bir renkle değiştirme
            profilhesaplamatablosu.BackgroundColor = Color.WhiteSmoke; // Arka planı modern ve yumuşak bir renk

            // Satır başlıklarının kenarlık stilini kaldırabiliriz, böylece daha sade bir görünüm olur
            profilhesaplamatablosu.AdvancedRowHeadersBorderStyle.All = DataGridViewAdvancedCellBorderStyle.None; // Satır başlık kenarlıkları kaldırıldı

            // İlk sütunun genişliğini azaltma
            profilhesaplamatablosu.Columns[0].Width = 45; // İlk sütun genişliği azaltıldı



            


        }
        private void ProfilFiyatHesaplama_Load(object sender, EventArgs e)
        {

            InitializeDataGridView();

            using (var context = new MyDbContext())
            {
                // Müşteri listesini yükle
                cmbmusteriadi.DataSource = context.Musteriler.ToList();
                cmbmusteriadi.DisplayMember = "MusteriAdSoyad"; // Müşteri adını göster
                cmbmusteriadi.ValueMember = "MusteriAdSoyad"; // Değer olarak Id kullan
                // Siparişleri yükle
                profilhesaplamatablosu.DataSource = context.profilhesaplama.ToList();






            }
        }

        private void btnsaatfiyathesapla_Click(object sender, EventArgs e)
        {
            try
            {
                double makinesaatucreti = Convert.ToDouble(txtmakinesaati.Text);
                double makinecalismasaati = Convert.ToDouble(txtsaatucreti.Text);
                //indirimsiz kdvsiz fiyat
                double indirimsizkdvsizfiyat = makinesaatucreti * makinecalismasaati;

                double iskontoorani = Convert.ToDouble(txtiskontoorani.Text);
                double kdvorani = Convert.ToDouble(txtkdvorani.Text);

                double iskontotutari = indirimsizkdvsizfiyat * (iskontoorani / 100);
                // indirimli kdvsiz fiyat
                double indirimlikdvsizfiyat = indirimsizkdvsizfiyat - iskontotutari;
                double kdvtutari = indirimlikdvsizfiyat * (kdvorani / 100);
                // indirimli kdvli net tutar
                double indirimlikdvdahiltutar = indirimlikdvsizfiyat + kdvtutari;

                //YAZDIRMA KISMI
                lblilkfiyat.Text = (indirimsizkdvsizfiyat.ToString("N0") + "TL");
                lbliskontotutar.Text = (iskontotutari.ToString("N0") + "TL");
                lbliskontolufiyat.Text = (indirimlikdvsizfiyat.ToString("N0") + "TL");
                lblkdvtutar.Text = (kdvtutari.ToString("N0") + "TL");
                lblnetfiyat.Text = (indirimlikdvdahiltutar.ToString("N0") + "TL");
            }
            catch (Exception ex)
            {
                MessageBox.Show("BOŞ ALAN BIRAKMAYIN! " + ex.Message);

            }

        }

        public void btnagirlikhesapla_Click(object sender, EventArgs e)
        {
            try
            {
                // Ağırlık hesaplama
                double parcasayi = Convert.ToDouble(txtparcasayisi.Text);
                double disgenislik = Convert.ToDouble(txtgenislik.Text);
                double disyukseklik = Convert.ToDouble(txtyukseklık.Text);
                double kalinlik = Convert.ToDouble(txtkalinlik.Text);
                double uzunluk = Convert.ToDouble(txtboy.Text) * 1000;

                double dishacim = disgenislik * disyukseklik * uzunluk;
                double icgenislik = disgenislik - 2 * kalinlik;
                double icyukseklik = disyukseklik - 2 * kalinlik;
                double ichacim = icgenislik * icyukseklik * uzunluk;
                double nethacim = dishacim - ichacim;
                double metrenethacim = nethacim * 0.000000001;
                double agirlik = metrenethacim * 7850 * parcasayi;
                lblagirliksonuc.Text = agirlik.ToString("N0") + " KG"; // Tam sayı formatında gösterim
                MessageBox.Show("Ağırlık hesaplanmıştır, toplam ağırlığınız: " + agirlik.ToString("0") + " KG"); // Tam sayı formatında gösterim
            }
            catch (Exception ex)
            {
                MessageBox.Show("BOŞ ALAN BIRAKMAYIN! " + ex.Message);
            }
        }


        public void btnekle_Click(object sender, EventArgs e)
        {
            try
            {



                using (var context = new MyDbContext())
                {
                    // Ağırlık hesaplama
                    double parcasayi = Convert.ToDouble(txtparcasayisi.Text);
                    double disgenislik = Convert.ToDouble(txtgenislik.Text);
                    double disyukseklik = Convert.ToDouble(txtyukseklık.Text);
                    double kalinlik = Convert.ToDouble(txtkalinlik.Text);
                    double uzunluk = Convert.ToDouble(txtboy.Text) * 1000;

                    double dishacim = disgenislik * disyukseklik * uzunluk;
                    double icgenislik = disgenislik - 2 * kalinlik;
                    double icyukseklik = disyukseklik - 2 * kalinlik;
                    double ichacim = icgenislik * icyukseklik * uzunluk;
                    double nethacim = dishacim - ichacim;
                    double metrenethacim = nethacim * 0.000000001;
                    double agirlik = metrenethacim * 7850 * parcasayi;
                    double makinesaatucreti = Convert.ToDouble(txtmakinesaati.Text);
                    double makinecalismasaati = Convert.ToDouble(txtsaatucreti.Text);
                    //indirimsiz kdvsiz fiyat
                    double indirimsizkdvsizfiyat = makinesaatucreti * makinecalismasaati;

                    double iskontoorani = Convert.ToDouble(txtiskontoorani.Text);
                    double kdvorani = Convert.ToDouble(txtkdvorani.Text);

                    double iskontotutari = indirimsizkdvsizfiyat * (iskontoorani / 100);
                    // indirimli kdvsiz fiyat
                    double indirimlikdvsizfiyat = indirimsizkdvsizfiyat - iskontotutari;
                    double kdvtutari = indirimlikdvsizfiyat * (kdvorani / 100);
                    // indirimli kdvli net tutar
                    double indirimlikdvdahiltutar = indirimlikdvsizfiyat + kdvtutari;
                    try
                    {
                        var yenikayit = new ProfilHesaplama()
                        {

                            MusteriAdi = cmbmusteriadi.Text,
                            SiparisIsmi = txt_siparisismi.Text,
                            SiparisAciklamasi = txtsiparistanimi.Text,
                            SiparisNumarasi = txtsiparisino.Text,
                            ParcaSayi = Convert.ToDouble(txtparcasayisi.Text),
                            DisGenislik = Convert.ToDouble(txtgenislik.Text),
                            Kalinlik = Convert.ToDouble(txtkalinlik.Text),
                            DisYukseklik = Convert.ToDouble(txtyukseklık.Text),
                            KDVOrani = Convert.ToDouble(txtkdvorani.Text),
                            IskontoOrani = Convert.ToDouble(txtiskontoorani.Text),
                            MakineCalismaSaati = Convert.ToDouble(txtmakinesaati.Text),
                            SaatUcreti = Convert.ToDouble(txtsaatucreti.Text),
                            kdvsizindirimsiztutar = indirimsizkdvsizfiyat,
                            KDVTutari = Convert.ToDouble(kdvtutari),
                            IskontoTutari = Convert.ToDouble(iskontotutari),
                            kdvsizindirimlitutar = Convert.ToDouble(indirimlikdvsizfiyat),
                            nettutar = Convert.ToDouble(indirimlikdvdahiltutar),
                            Uzunluk = Convert.ToDouble(txtboy.Text),
                            ProfilTuru = cmbprofilturu.Text,
                            agirlik = Convert.ToDouble(agirlik)
                        };
                        context.profilhesaplama.Add(yenikayit);
                        context.SaveChanges();
                        profilhesaplamatablosu.DataSource = context.profilhesaplama.ToList();
                        MessageBox.Show("Sipariş başarıyla eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);



                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            try
            {
                if (profilhesaplamatablosu.SelectedRows.Count > 0) // Seçili bir sipariş var mı kontrolü
                {
                    // İlk seçili satırı al
                    var selectedRow = profilhesaplamatablosu.SelectedRows[0];
                    int siparisId = Convert.ToInt32(selectedRow.Cells["SiparisID"].Value); // Sipariş ID'sini al

                    using (var context = new MyDbContext())
                    {
                        // Seçili siparişi bul
                        var selectedSiparis = context.profilhesaplama.FirstOrDefault(s => s.SiparisID == siparisId);

                        if (selectedSiparis != null)
                        {
                            // Silme onayı penceresi
                            DialogResult result = MessageBox.Show("Seçili sipariş silinsin mi?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            if (result == DialogResult.Yes)
                            {
                                try
                                {
                                    // Siparişi sil
                                    context.profilhesaplama.Remove(selectedSiparis);
                                    context.SaveChanges(); // Değişiklikleri kaydet

                                    // Tabloyu güncelle
                                    profilhesaplamatablosu.DataSource = context.profilhesaplama.ToList();

                                    MessageBox.Show("Sipariş başarıyla silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Bir hata oluştu: " + ex.Message + "\n" + ex.InnerException?.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Silmek için bir sipariş seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Silmek için bir sipariş seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Silmek için bir sipariş seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void btn_guncelle_Click(object sender, EventArgs e)

        {
            try
            {
                if (profilhesaplamatablosu.SelectedRows.Count > 0) // Seçili bir sipariş var mı kontrolü
                {
                    DataGridViewRow selectedRow = profilhesaplamatablosu.SelectedRows[0]; // Seçili satırı al
                    int siparisId = Convert.ToInt32(selectedRow.Cells["SiparisID"].Value); // ID'yi al

                    using (var context = new MyDbContext())
                    {
                        try
                        {
                            // Siparişi veritabanı bağlamına alın
                            var siparisToUpdate = context.profilhesaplama.SingleOrDefault(s => s.SiparisID == siparisId);

                            if (siparisToUpdate != null)
                            {
                                // Ağırlık hesaplama
                                double parcasayi = Convert.ToDouble(txtparcasayisi.Text);
                                double disgenislik = Convert.ToDouble(txtgenislik.Text);
                                double disyukseklik = Convert.ToDouble(txtyukseklık.Text);
                                double kalinlik = Convert.ToDouble(txtkalinlik.Text);
                                double uzunluk = Convert.ToDouble(txtboy.Text) * 1000;

                                double dishacim = disgenislik * disyukseklik * uzunluk;
                                double icgenislik = disgenislik - 2 * kalinlik;
                                double icyukseklik = disyukseklik - 2 * kalinlik;
                                double ichacim = icgenislik * icyukseklik * uzunluk;
                                double nethacim = dishacim - ichacim;
                                double metrenethacim = nethacim * 0.000000001;
                                double agirlik = metrenethacim * 7850 * parcasayi;
                                double makinesaatucreti = Convert.ToDouble(txtmakinesaati.Text);
                                double makinecalismasaati = Convert.ToDouble(txtsaatucreti.Text);
                                //indirimsiz kdvsiz fiyat
                                double indirimsizkdvsizfiyat = makinesaatucreti * makinecalismasaati;

                                double iskontoorani = Convert.ToDouble(txtiskontoorani.Text);
                                double kdvorani = Convert.ToDouble(txtkdvorani.Text);

                                double iskontotutari = indirimsizkdvsizfiyat * (iskontoorani / 100);
                                // indirimli kdvsiz fiyat
                                double indirimlikdvsizfiyat = indirimsizkdvsizfiyat - iskontotutari;
                                double kdvtutari = indirimlikdvsizfiyat * (kdvorani / 100);
                                // indirimli kdvli net tutar
                                double indirimlikdvdahiltutar = indirimlikdvsizfiyat + kdvtutari;






                                // Güncellemeleri burada yapın
                                siparisToUpdate.MusteriAdi = cmbmusteriadi.SelectedValue.ToString();
                                siparisToUpdate.SiparisIsmi = txt_siparisismi.Text;
                                siparisToUpdate.SiparisAciklamasi = txtsiparistanimi.Text;
                                siparisToUpdate.SiparisNumarasi = txtsiparisino.Text;
                                siparisToUpdate.ParcaSayi = Convert.ToDouble(txtparcasayisi.Text);
                                siparisToUpdate.DisGenislik = Convert.ToDouble(txtgenislik.Text);
                                siparisToUpdate.DisYukseklik = Convert.ToDouble(txtyukseklık.Text);
                                siparisToUpdate.Kalinlik = Convert.ToDouble(txtkalinlik.Text);
                                siparisToUpdate.KDVOrani = kdvorani; // KDV oranını yüzde olarak sakla
                                siparisToUpdate.KDVTutari = kdvtutari;     // Veritabanına KDV tutarını ekle
                                siparisToUpdate.IskontoOrani = iskontoorani; // İskonto oranını yüzde olarak sakla
                                siparisToUpdate.IskontoTutari = iskontotutari;     // İskonto tutarını veritabanına ekle
                                siparisToUpdate.kdvsizindirimlitutar = indirimlikdvsizfiyat;
                                siparisToUpdate.kdvsizindirimsiztutar = indirimsizkdvsizfiyat;
                                siparisToUpdate.nettutar = indirimlikdvdahiltutar; // Toplam fiyatı güncelle
                                siparisToUpdate.MakineCalismaSaati = Convert.ToDouble(txtmakinesaati.Text);
                                siparisToUpdate.SaatUcreti = Convert.ToDouble(txtsaatucreti.Text);
                                siparisToUpdate.Uzunluk = Convert.ToDouble(txtboy.Text);
                                siparisToUpdate.ProfilTuru = cmbprofilturu.Text;
                                siparisToUpdate.agirlik = agirlik;


                                context.SaveChanges(); // Güncellemeleri kaydet
                                                       // Tabloyu güncelle
                                profilhesaplamatablosu.DataSource = context.profilhesaplama.ToList(); // Güncellenen veriyi tabloya yükle
                                profilhesaplamatablosu.ClearSelection(); // Seçimi kaldır


                                MessageBox.Show("Sipariş başarıyla güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Güncellenecek sipariş bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Güncellemek için bir sipariş seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btnsatirgetir_Click(object sender, EventArgs e)
        {
            try
            {
                if (profilhesaplamatablosu.SelectedRows.Count > 0) // Seçili satır var mı kontrol et
                {
                    // Seçili satırı al
                    DataGridViewRow selectedRow = profilhesaplamatablosu.SelectedRows[0];

                    // Satırdaki değerleri al ve ilgili alanlara ata
                    cmbmusteriadi.SelectedValue = selectedRow.Cells["MusteriAdi"].Value?.ToString();
                    txt_siparisismi.Text = selectedRow.Cells["SiparisIsmi"].Value?.ToString();
                    txtsiparistanimi.Text = selectedRow.Cells["SiparisAciklamasi"].Value?.ToString();
                    txtsiparisino.Text = selectedRow.Cells["SiparisNumarasi"].Value?.ToString();
                    txtparcasayisi.Text = selectedRow.Cells["ParcaSayi"].Value?.ToString();
                    txtgenislik.Text = selectedRow.Cells["DisGenislik"].Value?.ToString();
                    txtyukseklık.Text = selectedRow.Cells["DisYukseklik"].Value?.ToString();
                    txtkalinlik.Text = selectedRow.Cells["Kalinlik"].Value?.ToString();
                    txtkdvorani.Text = selectedRow.Cells["KDVOrani"].Value?.ToString();
                    txtiskontoorani.Text = selectedRow.Cells["IskontoOrani"].Value?.ToString();
                    txtmakinesaati.Text = selectedRow.Cells["MakineCalismaSaati"].Value?.ToString();
                    txtsaatucreti.Text = selectedRow.Cells["SaatUcreti"].Value?.ToString();
                    txtboy.Text = selectedRow.Cells["Uzunluk"].Value?.ToString();
                    cmbprofilturu.Text = selectedRow.Cells["ProfilTuru"].Value?.ToString();







                    // İşlemin tamamlandığını bildir
                    MessageBox.Show("Seçilen sipariş bilgileri getirildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Lütfen bir satır seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen bir satır seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }

        private void FormTemizle_Click(object sender, EventArgs e)
        {
            try
            {
                // Form üzerindeki tüm kontrolleri döner
                foreach (Control control in this.Controls)
                {
                    // Eğer kontrol bir TextBox ise, içeriğini temizle
                    if (control is TextBox)
                    {
                        control.Text = string.Empty;
                    }
                    // Eğer kontrol bir ComboBox ise, seçili öğeyi temizle
                    else if (control is ComboBox comboBox)
                    {
                        comboBox.SelectedIndex = -1; // Seçili öğeyi kaldırır
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen bir satır seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }

        private void profilhesaplamatablosu_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Hücrelerin TL formatında görünmesini sağlamak için
            if (profilhesaplamatablosu.Columns[e.ColumnIndex].Name == "kdvsizindirimsiztutar" ||
                profilhesaplamatablosu.Columns[e.ColumnIndex].Name == "kdvsizindirimlitutar" ||
                profilhesaplamatablosu.Columns[e.ColumnIndex].Name == "nettutar" ||
                profilhesaplamatablosu.Columns[e.ColumnIndex].Name == "IskontoTutari" ||
                profilhesaplamatablosu.Columns[e.ColumnIndex].Name == "KDVTutari" ||
                profilhesaplamatablosu.Columns[e.ColumnIndex].Name == "SaatUcreti")
            {
                if (e.Value != null)
                {
                    // Değeri double olarak al
                    double value;
                    if (double.TryParse(e.Value.ToString(), out value))
                    {
                        // TL formatında hücre içeriğini ayarla
                        e.Value = value.ToString("N0") + " TL"; // Virgülden sonra iki hane ve " TL" ekle
                        e.FormattingApplied = true; // Biçim uygulandığını belirt
                    }
                }
            }
            if (profilhesaplamatablosu.Columns[e.ColumnIndex].Name == "KDVOrani" ||
       profilhesaplamatablosu.Columns[e.ColumnIndex].Name == "IskontoOrani")
            {
                if (e.Value != null)
                {
                    // Değeri double olarak al
                    double value;
                    if (double.TryParse(e.Value.ToString(), out value))
                    {
                        // TL formatında hücre içeriğini ayarla
                        e.Value = " %" + value.ToString("N0"); // Virgülden sonra iki hane ve " TL" ekle
                        e.FormattingApplied = true; // Biçim uygulandığını belirt
                    }
                }
            }
            if (profilhesaplamatablosu.Columns[e.ColumnIndex].Name == "ParcaSayi")
            {
                if (e.Value != null)
                {
                    // Değeri double olarak al
                    double value;
                    if (double.TryParse(e.Value.ToString(), out value))
                    {
                        // TL formatında hücre içeriğini ayarla
                        e.Value = value.ToString("N0") + " Adet"; // Virgülden sonra iki hane ve " TL" ekle
                        e.FormattingApplied = true; // Biçim uygulandığını belirt
                    }
                }
            }
            if (profilhesaplamatablosu.Columns[e.ColumnIndex].Name == "DisGenislik" ||
                profilhesaplamatablosu.Columns[e.ColumnIndex].Name == "Kalinlik" ||
                profilhesaplamatablosu.Columns[e.ColumnIndex].Name == "DisYukseklik")
            {
                if (e.Value != null)
                {
                    // Değeri double olarak al
                    double value;
                    if (double.TryParse(e.Value.ToString(), out value))
                    {
                        // TL formatında hücre içeriğini ayarla
                        e.Value = value.ToString("N0") + " mm"; // Virgülden sonra iki hane ve " TL" ekle
                        e.FormattingApplied = true; // Biçim uygulandığını belirt
                    }
                }
            }
            if (profilhesaplamatablosu.Columns[e.ColumnIndex].Name == "Kalinlik")

            {
                if (e.Value != null)
                {
                    // Değeri double olarak al
                    double value;
                    if (double.TryParse(e.Value.ToString(), out value))
                    {
                        // TL formatında hücre içeriğini ayarla
                        e.Value = value.ToString("N0") + " mm"; // Virgülden sonra iki hane ve " TL" ekle
                        e.FormattingApplied = true; // Biçim uygulandığını belirt
                    }
                }
            }

            if (profilhesaplamatablosu.Columns[e.ColumnIndex].Name == "Uzunluk")

            {
                if (e.Value != null)
                {
                    // Değeri double olarak al
                    double value;
                    if (double.TryParse(e.Value.ToString(), out value))
                    {
                        // TL formatında hücre içeriğini ayarla
                        e.Value = value.ToString("N0") + " m"; // Virgülden sonra iki hane ve " TL" ekle
                        e.FormattingApplied = true; // Biçim uygulandığını belirt
                    }
                }
            }

            if (profilhesaplamatablosu.Columns[e.ColumnIndex].Name == "MakineCalismaSaati")
            {
                if (e.Value != null)
                {
                    // Değeri double olarak al
                    double value;
                    if (double.TryParse(e.Value.ToString(), out value))
                    {
                        // TL formatında hücre içeriğini ayarla
                        e.Value = value.ToString("N0") + " Saat"; // Virgülden sonra iki hane ve " TL" ekle
                        e.FormattingApplied = true; // Biçim uygulandığını belirt
                    }
                }
            }
            if (profilhesaplamatablosu.Columns[e.ColumnIndex].Name == "Agirlik")
            {
                if (e.Value != null)
                {
                    // Değeri double olarak al
                    double value;
                    if (double.TryParse(e.Value.ToString(), out value))
                    {
                        // TL formatında hücre içeriğini ayarla
                        e.Value = value.ToString("N0") + " kg"; // Virgülden sonra iki hane ve " TL" ekle
                        e.FormattingApplied = true; // Biçim uygulandığını belirt
                    }
                }
            }



        }

        private void tumdegerleribul_Click(object sender, EventArgs e)
        {
            try
            {
                // TextBox'tan sipariş numarasını al (string olarak)
                string girilenSiparisNo = txtsiparisnosorgula.Text;

                // DataGridView'deki satırlara eriş ve toplam net değerleri hesapla
                decimal toplamNetFiyat = 0;
                decimal toplamNetAgirlik = 0;
                decimal toplamNetIskonto = 0;
                decimal toplamNetKDV = 0;
                decimal toplamNetSaat = 0;
                decimal toplamBrutFiyat = 0;

                string kdvOrani = "0"; // KDV oranı için varsayılan değer
                string iskontoOrani = "0"; // İskonto oranı için varsayılan değer


                try
                {
                    foreach (DataGridViewRow row in profilhesaplamatablosu.Rows)
                    {
                        // Her satırdaki "SiparisNumarasi" hücresini kontrol et
                        if (row.Cells["SiparisNumarasi"].Value != null)
                        {
                            // SiparisNo hücresindeki değeri string olarak al
                            string mevcutSiparisNo = row.Cells["SiparisNumarasi"].Value.ToString();

                            if (mevcutSiparisNo == girilenSiparisNo)
                            {
                                // "NetTutar" sütununu al ve toplam fiyatı hesapla
                                decimal netFiyat;
                                bool fiyatIsValid = decimal.TryParse(row.Cells["nettutar"].Value.ToString(), out netFiyat);
                                if (fiyatIsValid)
                                {
                                    toplamNetFiyat += netFiyat;
                                }
                                else
                                {
                                    MessageBox.Show("Geçersiz net fiyat değeri!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }

                                // "Agirlik" sütununu al ve toplam ağırlığı hesapla
                                decimal agirlik;
                                bool agirlikIsValid = decimal.TryParse(row.Cells["agirlik"].Value.ToString(), out agirlik);
                                if (agirlikIsValid)
                                {
                                    toplamNetAgirlik += agirlik;
                                }
                                else
                                {
                                    MessageBox.Show("Geçersiz ağırlık değeri!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }

                                // "IskontoTutari" sütununu al ve toplam iskontoyu hesapla
                                decimal iskontoTutari;
                                bool iskontoIsValid = decimal.TryParse(row.Cells["IskontoTutari"].Value.ToString(), out iskontoTutari);
                                if (iskontoIsValid)
                                {
                                    toplamNetIskonto += iskontoTutari;
                                }
                                else
                                {
                                    MessageBox.Show("Geçersiz iskonto tutarı değeri!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }

                                // "KDVTutari" sütununu al ve toplam KDV'yi hesapla
                                decimal kdvTutari;
                                bool kdvIsValid = decimal.TryParse(row.Cells["KDVTutari"].Value.ToString(), out kdvTutari);
                                if (kdvIsValid)
                                {
                                    toplamNetKDV += kdvTutari;
                                }
                                else
                                {
                                    MessageBox.Show("Geçersiz KDV tutarı değeri!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }

                                // "MakineCalismaSaati" sütununu al ve toplam makine çalışma saatini hesapla
                                decimal makineCalismaSaati;
                                bool saatIsValid = decimal.TryParse(row.Cells["MakineCalismaSaati"].Value.ToString(), out makineCalismaSaati);
                                if (saatIsValid)
                                {
                                    toplamNetSaat += makineCalismaSaati;
                                }
                                else
                                {
                                    MessageBox.Show("Geçersiz makine çalışma saati değeri!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                // Form2'yi oluştur
                                // "MakineCalismaSaati" sütununu al ve toplam makine çalışma saatini hesapla
                                decimal brutfiyat;
                                bool brutIsValid = decimal.TryParse(row.Cells["kdvsizindirimsiztutar"].Value.ToString(), out brutfiyat);
                                if (brutIsValid)
                                {
                                    toplamBrutFiyat += brutfiyat;
                                }
                                else
                                {
                                    MessageBox.Show("Geçersiz makine çalışma saati değeri!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                // Form2'yi oluştur
                                if (row.Cells["KDVOrani"].Value != null)
                                {
                                    kdvOrani = row.Cells["KDVOrani"].Value.ToString();
                                }
                                if (row.Cells["IskontoOrani"].Value != null)
                                {
                                    iskontoOrani = row.Cells["IskontoOrani"].Value.ToString();
                                }


                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("DataGridView'deki satırları okurken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Sonuçları ilgili Label'lara yazdır
                try
                {
                    // Sonuçları ilgili Label'lara yazdır
                    lbl_tumtoplam.Text = toplamNetFiyat.ToString("N0") + "TL"; // Para formatında tam sayı olarak gösterim
                    lbl_tumagirlik.Text = toplamNetAgirlik.ToString("N0") + "KG"; // Ağırlık formatında tam sayı olarak gösterim
                    lbltoplamiskonto.Text = toplamNetIskonto.ToString("N0") + "TL"; // Para formatında tam sayı olarak gösterim
                    lbltoplamkdv.Text = toplamNetKDV.ToString("N0") + "TL"; // Para formatında tam sayı olarak gösterim
                    lbltoplamsaat.Text = toplamNetSaat.ToString("N0") + " SAAT"; // Saat formatında tam sayı olarak gösterim
                    lblbrutfiyat.Text = toplamBrutFiyat.ToString("N0") + "TL";
                    lblkdvorani.Text = kdvOrani.ToString();
                    lbliskontoorani.Text = iskontoOrani.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sonuçları yazdırırken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void degerlerigonder_Click(object sender, EventArgs e)
        {
            try
            {
                // " TL", " SAAT" ve birimlerden arındırma
                double tumToplam = Convert.ToDouble(lbl_tumtoplam.Text.Replace("TL", "").Trim());
                double toplamSaat = Convert.ToDouble(lbltoplamsaat.Text.Replace(" SAAT", "").Trim());
                double KDVtutar = Convert.ToDouble(lbltoplamkdv.Text.Replace("TL", "").Trim());
                double IskontoTutar = Convert.ToDouble(lbltoplamiskonto.Text.Replace("TL", "").Trim());
                double brutToplam = Convert.ToDouble(lblbrutfiyat.Text.Replace("TL", "").Trim());

                SiparisOlusturma form2 = new SiparisOlusturma();

                // Form2'ye değerleri gönder
                form2.SetValues(
                    Convert.ToString(tumToplam),
                    Convert.ToString(toplamSaat),
                    lblkdvorani.Text,
                    lbliskontoorani.Text,
                    Convert.ToString(brutToplam)
                );

                form2.Show();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Bir veya daha fazla değerin formatı hatalı: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtGenelArama_TextChanged(object sender, EventArgs e)
        {
            using (var context = new MyDbContext())
            {
                // TextBox'tan aranan metni al
                string searchText = txtGenelArama.Text.ToLower();

                // Arama yapılacak sütunların her birine karşılık gelen değerleri arayalım
                var filteredData = context.profilhesaplama
                    .Where(f =>
                        f.SiparisID.ToString().Contains(searchText) ||
                        f.SiparisIsmi.ToLower().Contains(searchText) ||
                        f.SiparisAciklamasi.ToLower().Contains(searchText) ||
                        f.SiparisNumarasi.ToLower().Contains(searchText) ||
                        f.nettutar.ToString().Contains(searchText) ||
                        f.agirlik.ToString().Contains(searchText) ||
                        f.Uzunluk.ToString().Contains(searchText) ||
                        f.ParcaSayi.ToString().Contains(searchText) ||
                        f.MusteriAdi.ToLower().Contains(searchText) 
                    ).ToList();

                // DataGridView'e filtrelenmiş veriyi yükle
               profilhesaplamatablosu.DataSource = filteredData;
            }
        }
    }
}