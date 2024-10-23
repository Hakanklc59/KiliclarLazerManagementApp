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
    public partial class SiparisOlusturma : Form
    {
        public Siparis selectedSiparis; // Seçili sipariş için değişken

        public SiparisOlusturma()
        {
            InitializeComponent();

        }

        private void SiparisOlusturma_Load(object sender, EventArgs e)
        {
            using (var context = new MyDbContext())
            {
                // Müşteri listesini yükle
                MusteriAdi.DataSource = context.Musteriler.ToList();
                MusteriAdi.DisplayMember = "MusteriAdSoyad"; // Müşteri adını göster
                MusteriAdi.ValueMember = "MusteriAdSoyad"; // Değer olarak Id kullan
                // Siparişleri yükle
                SiparislerTablo.DataSource = context.Siparisler.ToList();

                SiparislerTablo.Columns["MusteriID"].Visible = false;
                SiparislerTablo.Columns["SiparisID"].Visible = false;
            }
            SiparislerTablo.Columns["Fiyat"].HeaderText = "Brüt Fiyat"; // Fiyat sütun başlığını değiştir
            SiparislerTablo.Columns["ToplamFiyat"].HeaderText = "Net Fiyat"; // Toplam Fiyat sütun başlığını değiştir
            // Başlık stili
            SiparislerTablo.EnableHeadersVisualStyles = false;
            SiparislerTablo.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 45, 48); // Daha yumuşak bir koyu renk
            SiparislerTablo.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            SiparislerTablo.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel); // Kalın (bold) font
            SiparislerTablo.ColumnHeadersHeight = 45; // Sütun başlık yüksekliği

            // Alternatif satır renkleri ve arka plan
            SiparislerTablo.RowsDefaultCellStyle.BackColor = Color.White;
            SiparislerTablo.RowsDefaultCellStyle.ForeColor = Color.Black;
            SiparislerTablo.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240); // Hafif gri ton

            // Satır kenar çizgileri için stil
            SiparislerTablo.CellBorderStyle = DataGridViewCellBorderStyle.None; // Hücre çizgilerini kaldırıyoruz

            // Satırlar arasındaki boşluk
            SiparislerTablo.RowTemplate.DividerHeight = 5; // Satırlar arasına boşluk ekliyoruz (arttırıldı)
            SiparislerTablo.RowTemplate.Height = 40; // Satır yüksekliği (biraz daha yüksek olabilir)

            // Satır başlıklarını görünür yaparak sol tarafa seçim işareti ekliyoruz
            SiparislerTablo.RowHeadersVisible = true; // Satır başlıkları görünüyor
            SiparislerTablo.RowHeadersWidth = 29; // Başlıklar için genişlik azaltıldı
            SiparislerTablo.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 45, 48); // Sol başlık arka plan rengi
            SiparislerTablo.RowHeadersDefaultCellStyle.ForeColor = Color.White; // Sol başlık metin rengi
            SiparislerTablo.RowHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(30, 30, 30); // Seçildiğinde başlık arka planı
                                                                                                        // DataGridView sütunlarının otomatik boyutlandırma ayarı
                                                                                                        // DataGridView'de hücrelerin sarılması
            SiparislerTablo.DefaultCellStyle.WrapMode = DataGridViewTriState.True; // Hücre içeriğini sar

            // DataGridView'deki satırların otomatik yüksekliğini ayarlama
            SiparislerTablo.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells; // Tüm hücreler için satır yüksekliğini ayarla


            // Seçilen hücreler için stil
           SiparislerTablo.DefaultCellStyle.SelectionBackColor = Color.FromArgb(45, 45, 48); // Modern bir mavi ton
            SiparislerTablo.DefaultCellStyle.SelectionForeColor = Color.White;

            // DataGridView kenarlık stili (kenarlık renklerini ayarlıyoruz)
            SiparislerTablo.AdvancedColumnHeadersBorderStyle.All = DataGridViewAdvancedCellBorderStyle.Single; // Sütun başlık kenarlıkları
            SiparislerTablo.AdvancedCellBorderStyle.All = DataGridViewAdvancedCellBorderStyle.Single; // Hücreler arası kenarlık

            // Hücrelerin köşelerine ve gölgelerine benzer bir efekt için padding ekleyebiliriz
            SiparislerTablo.DefaultCellStyle.Padding = new Padding(5); // Hücrelerin içerisine padding ekleyerek ferah bir görünüm
            SiparislerTablo.AlternatingRowsDefaultCellStyle.Padding = new Padding(5);

            // DataGridView için çizgi renklerini belirleyebiliriz
            SiparislerTablo.GridColor = Color.LightGray; // Hücreler arası çizgi rengi

            // Arka plan rengini yumuşak bir renkle değiştirme
            SiparislerTablo.BackgroundColor = Color.WhiteSmoke; // Arka planı modern ve yumuşak bir renk

            // Satır başlıklarının kenarlık stilini kaldırabiliriz, böylece daha sade bir görünüm olur
            SiparislerTablo.AdvancedRowHeadersBorderStyle.All = DataGridViewAdvancedCellBorderStyle.None; // Satır başlık kenarlıkları kaldırıldı

            // İlk sütunun genişliğini azaltma
            SiparislerTablo.Columns[0].Width = 45; // İlk sütun genişliği azaltıldı

            SiparislerTablo.Columns["SiparisAlisTarihi"].DefaultCellStyle.Format = "dd.MM.yyyy"; // Sadece tarihi gösterecek
            SiparislerTablo.Columns["SiparisTeslimTarihi"].DefaultCellStyle.Format = "dd.MM.yyyy"; // Sadece tarihi gösterecek

          



        }

        private void SiparisEkle_Click(object sender, EventArgs e)
        {
            // Giriş Kontrolleri
            if (string.IsNullOrWhiteSpace(SiparisDetayi.Text) ||
                string.IsNullOrWhiteSpace(MakinaCalismaSaati.Text) ||
                string.IsNullOrWhiteSpace(MusteriAdi.Text) ||
                string.IsNullOrWhiteSpace(KDVOrani.Text) ||
                string.IsNullOrWhiteSpace(ToplamFiyat.Text) ||
                string.IsNullOrWhiteSpace(Fiyat.Text) ||
                string.IsNullOrWhiteSpace(ToplamFiyat.Text) ||
                string.IsNullOrWhiteSpace(IskontoOrani.Text) ||
                string.IsNullOrWhiteSpace(SiparisNotu.Text) ||
                string.IsNullOrWhiteSpace(CariAdi.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var context = new MyDbContext())
            {
                try
                {
                    // Sipariş durumu
                    string siparisDurumu = radioSiparisAlindi.Checked ? "Sipariş Alındı" :
                                            radioSiparisImalatta.Checked ? "Sipariş İmalatta" :
                                            radioSiparisSonuclandi.Checked ? "Sipariş Sonuçlandı" : "";

                    // Fiyat ve İskonto oranını al
                    double fiyat = Convert.ToDouble(Fiyat.Text);
                    double iskontoOrani = Convert.ToDouble(IskontoOrani.Text) / 100.0;

                    // İskontolu fiyat hesapla
                    double iskontoTutari = fiyat * iskontoOrani;
                    double iskontoSonrasiFiyat = fiyat - iskontoTutari;

                    // KDV oranını al ve hesapla
                    double kdvOrani = Convert.ToDouble(KDVOrani.Text) / 100.0;
                    double kdvTutari = iskontoSonrasiFiyat * kdvOrani;

                    // Toplam fiyatı hesapla
                    double toplamFiyat = iskontoSonrasiFiyat + kdvTutari;

                    // İskonto tutarı, KDV tutarı ve toplam fiyatı uygun yerlere yaz
                    ToplamFiyat.Text = toplamFiyat.ToString();

                    var yeniSiparis = new Siparis
                    {
                        MusteriAdSoyad = MusteriAdi.SelectedValue.ToString(),
                        CariAd = CariAdi.Text,
                        SiparisDetayi = SiparisDetayi.Text,
                        KDVOrani = kdvOrani * 100,
                        KDVTutari = kdvTutari,
                        Fiyat = fiyat,
                        IskontoOrani = iskontoOrani * 100,
                        IskontoTutari = iskontoTutari,
                        ToplamFiyat = toplamFiyat,
                        MakinaCalismaSaati = MakinaCalismaSaati.Text,
                        SiparisNotu = SiparisNotu.Text,
                        SiparisAlisTarihi = SiparisAlisTarihi.Value,
                        SiparisTeslimTarihi = SiparisTeslimTarihi.Value,
                        SiparisDurumu = siparisDurumu // Sipariş durumunu atayın

                    };

                    context.Siparisler.Add(yeniSiparis);
                    context.SaveChanges();
                    SiparislerTablo.DataSource = context.Siparisler.ToList();
                    MessageBox.Show("Sipariş başarıyla eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void SiparisSil_Click(object sender, EventArgs e)
        {
            if (SiparislerTablo.SelectedRows.Count > 0) // Seçili bir sipariş var mı kontrolü
            {
                // İlk seçili satırı al
                var selectedRow = SiparislerTablo.SelectedRows[0];
                int siparisId = Convert.ToInt32(selectedRow.Cells["SiparisID"].Value); // Sipariş ID'sini al

                using (var context = new MyDbContext())
                {
                    // Seçili siparişi bul
                    var selectedSiparis = context.Siparisler.FirstOrDefault(s => s.SiparisID == siparisId);

                    if (selectedSiparis != null)
                    {
                        // Silme onayı penceresi
                        DialogResult result = MessageBox.Show("Seçili sipariş silinsin mi?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            try
                            {
                                // Siparişi sil
                                context.Siparisler.Remove(selectedSiparis);
                                context.SaveChanges(); // Değişiklikleri kaydet

                                // Tabloyu güncelle
                                SiparislerTablo.DataSource = context.Siparisler.ToList();

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



        private void SiparisGuncelle_Click(object sender, EventArgs e)
        {

            if (SiparislerTablo.SelectedRows.Count > 0) // Seçili bir sipariş var mı kontrolü
            {
                DataGridViewRow selectedRow = SiparislerTablo.SelectedRows[0]; // Seçili satırı al
                int siparisId = Convert.ToInt32(selectedRow.Cells["SiparisID"].Value); // ID'yi al

                using (var context = new MyDbContext())
                {
                    try
                    {
                        // Siparişi veritabanı bağlamına alın
                        var siparisToUpdate = context.Siparisler.SingleOrDefault(s => s.SiparisID == siparisId);

                        if (siparisToUpdate != null)
                        {
                            // Sipariş durumu belirle
                            string siparisDurumu = "";
                            if (radioSiparisAlindi.Checked)
                                siparisDurumu = "Sipariş Alındı";
                            else if (radioSiparisImalatta.Checked)
                                siparisDurumu = "Sipariş İmalatta";
                            else if (radioSiparisSonuclandi.Checked)
                                siparisDurumu = "Sipariş Sonuçlandı";

                            // Alanların boş olup olmadığını kontrol et


                            // Fiyat ve İskonto oranını al
                            double fiyat = Convert.ToDouble(Fiyat.Text);
                            double iskontoOrani = Convert.ToDouble(IskontoOrani.Text) / 100.0;

                            // İskontolu fiyat hesapla
                            double iskontoTutari = fiyat * iskontoOrani;
                            double iskontoSonrasiFiyat = fiyat - iskontoTutari;

                            // KDV oranını al ve hesapla
                            double kdvOrani = Convert.ToDouble(KDVOrani.Text) / 100.0;
                            double kdvTutari = iskontoSonrasiFiyat * kdvOrani;

                            // Toplam fiyatı hesapla
                            double toplamFiyat = iskontoSonrasiFiyat + kdvTutari;

                            // Güncellemeleri burada yapın
                            siparisToUpdate.MusteriAdSoyad = MusteriAdi.SelectedValue.ToString();
                            siparisToUpdate.SiparisDetayi = SiparisDetayi.Text;
                            siparisToUpdate.MakinaCalismaSaati = MakinaCalismaSaati.Text;
                            siparisToUpdate.KDVOrani = kdvOrani * 100; // KDV oranını yüzde olarak sakla
                            siparisToUpdate.KDVTutari = kdvTutari;     // Veritabanına KDV tutarını ekle
                            siparisToUpdate.ToplamFiyat = toplamFiyat; // Toplam fiyatı güncelle
                            siparisToUpdate.Fiyat = fiyat;
                            siparisToUpdate.IskontoOrani = iskontoOrani * 100; // İskonto oranını yüzde olarak sakla
                            siparisToUpdate.IskontoTutari = iskontoTutari;     // İskonto tutarını veritabanına ekle
                            siparisToUpdate.SiparisNotu = SiparisNotu.Text;
                            siparisToUpdate.SiparisAlisTarihi = SiparisAlisTarihi.Value;
                            siparisToUpdate.SiparisTeslimTarihi = SiparisTeslimTarihi.Value;
                            siparisToUpdate.CariAd = CariAdi.Text;
                            siparisToUpdate.SiparisDurumu = siparisDurumu;
                            ToplamFiyat.Text = toplamFiyat.ToString();
                            context.SaveChanges(); // Güncellemeleri kaydet

                            // Tabloyu güncelle
                            SiparislerTablo.DataSource = context.Siparisler.ToList(); // Güncellenen veriyi tabloya yükle
                            SiparislerTablo.ClearSelection(); // Seçimi kaldır

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


        private void SatirGetir_Click(object sender, EventArgs e)
        {
            if (SiparislerTablo.SelectedRows.Count > 0)
            {
                var selectedRow = SiparislerTablo.SelectedRows[0];
                selectedSiparis = (Siparis)selectedRow.DataBoundItem;


                MusteriAdi.SelectedValue = selectedSiparis.MusteriAdSoyad;
                SiparisAlisTarihi.Value = selectedSiparis.SiparisAlisTarihi;
                if (selectedSiparis.SiparisTeslimTarihi.HasValue) // Null değilse
                {
                    SiparisTeslimTarihi.Value = selectedSiparis.SiparisTeslimTarihi.Value; // Değeri atayın
                }
                else
                {
                    // Eğer null ise, burada bir varsayılan değer atayabilir veya kullanıcıya bir bilgi verebilirsiniz
                    SiparisTeslimTarihi.Value = DateTime.Now; // Örneğin, şu anki tarihi varsayılan olarak atayabilirsiniz
                }
                CariAdi.Text = selectedSiparis.CariAd;
                SiparisDetayi.Text = selectedSiparis.SiparisDetayi;
                MakinaCalismaSaati.Text = selectedSiparis.MakinaCalismaSaati;
                KDVOrani.Text = selectedSiparis.KDVOrani.ToString();
                ToplamFiyat.Text = selectedSiparis.ToplamFiyat.ToString();
                Fiyat.Text = selectedSiparis.Fiyat.ToString();
                IskontoOrani.Text = selectedSiparis.IskontoOrani.ToString();
                SiparisNotu.Text = selectedSiparis.SiparisNotu;

                // Sipariş durumuna göre radio butonları ayarla
                if (selectedSiparis.SiparisDurumu == "Sipariş Alındı")
                    radioSiparisAlindi.Checked = true;
                else if (selectedSiparis.SiparisDurumu == "Sipariş İmalatta")
                    radioSiparisImalatta.Checked = true;
                else if (selectedSiparis.SiparisDurumu == "Sipariş Sonuçlandı")
                    radioSiparisSonuclandi.Checked = true;
            }
            else
            {
                MessageBox.Show("Lütfen bir satır seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        private void MusteriAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Seçilen müşteri nesnesini al
            var selectedMusteri = MusteriAdi.SelectedItem as Musteri; // Musteri, müşteri nesnelerinin tutulduğu sınıf


            if (selectedMusteri != null)
            {
                // Seçilen müşterinin musteriId'sini al ve TextBox'a ata

                CariAdi.Text = selectedMusteri.CariAd; // CariAdTextBox, cari adını tutacak TextBox'ın adı

            }

        }

        private void cik_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
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
                // Eğer kontrol bir RichTextBox ise, içeriğini temizle
                else if (control is RichTextBox richTextBox)
                {
                    richTextBox.Clear(); // RichTextBox içeriğini temizler
                }
                // Eğer kontrol bir DateTimePicker ise, bugünkü tarihe ayarla
                else if (control is DateTimePicker dateTimePicker)
                {
                    dateTimePicker.Value = DateTime.Now; // Şu anki tarihi ayarlar
                }
            }
        }

        private void SiparislerTablo_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Hücrelerin TL formatında görünmesini sağlamak için
            if (SiparislerTablo.Columns[e.ColumnIndex].Name == "KDVTutari" ||
                SiparislerTablo.Columns[e.ColumnIndex].Name == "IskontoTutari" ||
                SiparislerTablo.Columns[e.ColumnIndex].Name == "ToplamFiyat" ||
                SiparislerTablo.Columns[e.ColumnIndex].Name == "Fiyat")
            {
                if (e.Value != null)
                {
                    // Değeri double olarak al
                    double value;
                    if (double.TryParse(e.Value.ToString(), out value))
                    {
                        // TL formatında hücre içeriğini ayarla
                        e.Value = value.ToString("N2") + " TL"; // Virgülden sonra iki hane ve " TL" ekle
                        e.FormattingApplied = true; // Biçim uygulandığını belirt
                    }
                }
            }
            if (SiparislerTablo.Columns[e.ColumnIndex].Name == "KDVOrani" ||
       SiparislerTablo.Columns[e.ColumnIndex].Name == "IskontoOrani"
       )
            {
                if (e.Value != null)
                {
                    // Değeri double olarak al
                    double value;
                    if (double.TryParse(e.Value.ToString(), out value))
                    {
                        // TL formatında hücre içeriğini ayarla
                        e.Value = " %" + value.ToString(); // Virgülden sonra iki hane ve " TL" ekle
                        e.FormattingApplied = true; // Biçim uygulandığını belirt
                    }
                }
            }
        }
        public void SetValues(string toplam, string saat, string kdvorani, string iskontoorani, string ilkfiyat)
        {
            ToplamFiyat.Text = toplam;
            IskontoOrani.Text = Convert.ToString(iskontoorani);
            KDVOrani.Text = Convert.ToString(kdvorani);
            Fiyat.Text = Convert.ToString(ilkfiyat);
            MakinaCalismaSaati.Text = saat;


        }
        private void degerlerial_Click(object sender, EventArgs e)
        {

        }

        private void txtGenelArama_TextChanged(object sender, EventArgs e)
        {
            using (var context = new MyDbContext())
            {
                // TextBox'tan aranan metni al
                string searchText = txtGenelArama.Text.ToLower();

                // Tarih için değişkenler
                DateTime searchDate;
                bool isDate = DateTime.TryParse(searchText, out searchDate); // Kullanıcıdan gelen metni tarih olarak dene

                // Arama yapılacak sütunların her birine karşılık gelen değerleri arayalım
                var filteredData = context.Siparisler
                    .Where(f =>
                        f.SiparisID.ToString().Contains(searchText) ||
                        f.MusteriID.ToString().Contains(searchText) ||
                        f.CariAd.ToLower().Contains(searchText) ||
                        f.MusteriAdSoyad.ToLower().Contains(searchText) ||
                        f.SiparisDurumu.ToLower().Contains(searchText) ||
                        f.Fiyat.ToString().Contains(searchText) ||
                        f.SiparisNotu.ToLower().Contains(searchText) ||
                        (isDate && f.SiparisAlisTarihi.Date == searchDate.Date) || // Tarih karşılaştırması
                        (isDate && f.SiparisTeslimTarihi.HasValue && f.SiparisTeslimTarihi.Value.Date == searchDate.Date) || // Nullable tarih kontrolü
                        f.ToplamFiyat.ToString().Contains(searchText)
                    ).ToList();

                // DataGridView'e filtrelenmiş veriyi yükle
                SiparislerTablo.DataSource = filteredData;
            }
        }

        private void SiparislerTablo_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string columnName = SiparislerTablo.Columns[e.ColumnIndex].DataPropertyName;
            if (!string.IsNullOrEmpty(columnName))
            {
                var dataSource = (List<Siparis>)SiparislerTablo.DataSource;
                var sortedData = dataSource.OrderBy(x => x.GetType().GetProperty(columnName).GetValue(x, null)).ToList();
                SiparislerTablo.DataSource = sortedData;
            }
        }
    }

}

