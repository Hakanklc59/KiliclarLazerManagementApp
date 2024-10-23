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
    public partial class SiparisVerme : Form
    {

        public Siparis selectedVerilenSiparis; // Seçili sipariş için değişken
        public SiparisVerme()
        {
            InitializeComponent();
        }

        private void SiparisVerme_Load(object sender, EventArgs e)
        {
            using (var context = new MyDbContext())
            {
                // Tedarikçi listesini yükle
                TedarikciAdi.DataSource = context.Tedarikciler.ToList();
                TedarikciAdi.DisplayMember = "TedarikciAdSoyad"; // Tedarikçi adını göster
                TedarikciAdi.ValueMember = "TedarikciAdSoyad";   // Değer olarak Id kullan
                // Siparişleri yükle
                VerilenSiparislerTablo.DataSource = context.VerilenSiparisler.ToList();

                VerilenSiparislerTablo.Columns["TedarikciID"].Visible = false;
                VerilenSiparislerTablo.Columns["SiparisID"].Visible = false;
            }
            VerilenSiparislerTablo.Columns["Fiyat"].HeaderText = "Brüt Fiyat"; // Fiyat sütun başlığını değiştir
            VerilenSiparislerTablo.Columns["ToplamFiyat"].HeaderText = "Net Fiyat"; // Toplam Fiyat sütun başlığını değiştir
            // Başlık stili
            VerilenSiparislerTablo.EnableHeadersVisualStyles = false;
            VerilenSiparislerTablo.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 45, 48); // Daha yumuşak bir koyu renk
            VerilenSiparislerTablo.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            VerilenSiparislerTablo.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel); // Kalın (bold) font
            VerilenSiparislerTablo.ColumnHeadersHeight = 45; // Sütun başlık yüksekliği

            // Alternatif satır renkleri ve arka plan
            VerilenSiparislerTablo.RowsDefaultCellStyle.BackColor = Color.White;
            VerilenSiparislerTablo.RowsDefaultCellStyle.ForeColor = Color.Black;
            VerilenSiparislerTablo.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240); // Hafif gri ton

            // Satır kenar çizgileri için stil
            VerilenSiparislerTablo.CellBorderStyle = DataGridViewCellBorderStyle.None; // Hücre çizgilerini kaldırıyoruz

            // Satırlar arasındaki boşluk
            VerilenSiparislerTablo.RowTemplate.DividerHeight = 5; // Satırlar arasına boşluk ekliyoruz (arttırıldı)
            VerilenSiparislerTablo.RowTemplate.Height = 40; // Satır yüksekliği (biraz daha yüksek olabilir)

            // Satır başlıklarını görünür yaparak sol tarafa seçim işareti ekliyoruz
            VerilenSiparislerTablo.RowHeadersVisible = true; // Satır başlıkları görünüyor
            VerilenSiparislerTablo.RowHeadersWidth = 29; // Başlıklar için genişlik azaltıldı
            VerilenSiparislerTablo.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 45, 48); // Sol başlık arka plan rengi
            VerilenSiparislerTablo.RowHeadersDefaultCellStyle.ForeColor = Color.White; // Sol başlık metin rengi
            VerilenSiparislerTablo.RowHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(30, 30, 30); // Seçildiğinde başlık arka planı
                                                                                                               // DataGridView sütunlarının otomatik boyutlandırma ayarı
                                                                                                               // DataGridView'de hücrelerin sarılması
            VerilenSiparislerTablo.DefaultCellStyle.WrapMode = DataGridViewTriState.True; // Hücre içeriğini sar

            // DataGridView'deki satırların otomatik yüksekliğini ayarlama
            VerilenSiparislerTablo.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells; // Tüm hücreler için satır yüksekliğini ayarla


            // Seçilen hücreler için stil
            VerilenSiparislerTablo.DefaultCellStyle.SelectionBackColor = Color.FromArgb(45, 45, 48); // Modern bir mavi ton
            VerilenSiparislerTablo.DefaultCellStyle.SelectionForeColor = Color.White;

            // DataGridView kenarlık stili (kenarlık renklerini ayarlıyoruz)
            VerilenSiparislerTablo.AdvancedColumnHeadersBorderStyle.All = DataGridViewAdvancedCellBorderStyle.Single; // Sütun başlık kenarlıkları
            VerilenSiparislerTablo.AdvancedCellBorderStyle.All = DataGridViewAdvancedCellBorderStyle.Single; // Hücreler arası kenarlık

            // Hücrelerin köşelerine ve gölgelerine benzer bir efekt için padding ekleyebiliriz
            VerilenSiparislerTablo.DefaultCellStyle.Padding = new Padding(5); // Hücrelerin içerisine padding ekleyerek ferah bir görünüm
            VerilenSiparislerTablo.AlternatingRowsDefaultCellStyle.Padding = new Padding(5);

            // DataGridView için çizgi renklerini belirleyebiliriz
            VerilenSiparislerTablo.GridColor = Color.LightGray; // Hücreler arası çizgi rengi

            // Arka plan rengini yumuşak bir renkle değiştirme
            VerilenSiparislerTablo.BackgroundColor = Color.WhiteSmoke; // Arka planı modern ve yumuşak bir renk

            // Satır başlıklarının kenarlık stilini kaldırabiliriz, böylece daha sade bir görünüm olur
            VerilenSiparislerTablo.AdvancedRowHeadersBorderStyle.All = DataGridViewAdvancedCellBorderStyle.None; // Satır başlık kenarlıkları kaldırıldı

            // İlk sütunun genişliğini azaltma
            VerilenSiparislerTablo.Columns[0].Width = 45; // İlk sütun genişliği azaltıldı

            VerilenSiparislerTablo.Columns["SiparisAlisTarihi"].DefaultCellStyle.Format = "dd.MM.yyyy"; // Sadece tarihi gösterecek
            VerilenSiparislerTablo.Columns["SiparisTeslimTarihi"].DefaultCellStyle.Format = "dd.MM.yyyy"; // Sadece tarihi gösterecek

           

            // Double değerlerin olduğu sütun için format ayarlama
            VerilenSiparislerTablo.Columns["KDVTutari"].DefaultCellStyle.Format = "N2"; // "N2" formatı sayıyı virgülden sonra iki hane gösterecek şekilde biçimlendirir
            VerilenSiparislerTablo.Columns["IskontoTutari"].DefaultCellStyle.Format = "N2"; // "N2" formatı sayıyı virgülden sonra iki hane gösterecek şekilde biçimlendirir
            VerilenSiparislerTablo.Columns["ToplamFiyat"].DefaultCellStyle.Format = "N2"; // "N2" formatı sayıyı virgülden sonra iki hane gösterecek şekilde biçimlendirir
            VerilenSiparislerTablo.Columns["Fiyat"].DefaultCellStyle.Format = "N2"; // "N2" formatı sayıyı virgülden sonra iki hane gösterecek şekilde biçimlendirir




        }

        private void SiparisEkle_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(SiparisDetayi.Text) ||
        string.IsNullOrWhiteSpace(TedarikciAdi.Text) ||
        string.IsNullOrWhiteSpace(KDVOrani.Text) ||
        string.IsNullOrWhiteSpace(ToplamFiyat.Text) ||
        string.IsNullOrWhiteSpace(Fiyat.Text) ||
        string.IsNullOrWhiteSpace(IskontoOrani.Text) ||
        string.IsNullOrWhiteSpace(SiparisNotu.Text)
        )


            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            try
            {
                // Sipariş durumu
                string siparisDurumu = radioSiparisVerildi.Checked ? "Sipariş Verildi" :
                                        radioSiparisHazırlanıyor.Checked ? "Sipariş Yolda" :
                                        radioSiparisGeldi.Checked ? "Sipariş Sonuçlandı" : "";

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

                using (var context = new MyDbContext())
                {
                    var yeniSiparis = new VerilenSiparis
                    {
                        TedarikciAdSoyad = TedarikciAdi.SelectedValue.ToString(),
                        CariAd = CariAdi.Text,
                        SiparisDetayi = SiparisDetayi.Text,
                        KDVOrani = kdvOrani * 100,  // KDV oranını yüzde olarak sakla
                        KDVTutari = kdvTutari,     // Veritabanına KDV tutarını ekle
                        Fiyat = fiyat,
                        IskontoOrani = iskontoOrani * 100, // İskonto oranını yüzde olarak sakla
                        IskontoTutari = iskontoTutari,     // İskonto tutarını veritabanına ekle
                        ToplamFiyat = toplamFiyat,
                        SiparisNotu = SiparisNotu.Text,
                        SiparisAlisTarihi = SiparisAlisTarihi.Value,
                        SiparisTeslimTarihi = SiparisTeslimTarihi.Value,
                        SiparisDurumu = siparisDurumu // Sipariş durumunu ekle
                    };

                    context.VerilenSiparisler.Add(yeniSiparis);
                    context.SaveChanges();
                    VerilenSiparislerTablo.DataSource = context.VerilenSiparisler.ToList();

                    MessageBox.Show("Sipariş başarıyla eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SiparisSil_Click(object sender, EventArgs e)
        {
            if (VerilenSiparislerTablo.SelectedRows.Count > 0)
            {
                var selectedRow = VerilenSiparislerTablo.SelectedRows[0];
                int siparisId = Convert.ToInt32(selectedRow.Cells["SiparisID"].Value);

                using (var context = new MyDbContext())
                {
                    var selectedSiparis = context.VerilenSiparisler.FirstOrDefault(s => s.SiparisID == siparisId);

                    if (selectedSiparis != null)
                    {
                        DialogResult result = MessageBox.Show("Seçili sipariş silinsin mi?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            try
                            {
                                context.VerilenSiparisler.Remove(selectedSiparis);
                                context.SaveChanges();
                                VerilenSiparislerTablo.DataSource = context.VerilenSiparisler.ToList();
                                MessageBox.Show("Sipariş başarıyla silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (VerilenSiparislerTablo.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = VerilenSiparislerTablo.SelectedRows[0];
                int siparisId = Convert.ToInt32(selectedRow.Cells["SiparisID"].Value);

                using (var context = new MyDbContext())
                {
                    try
                    {
                        // Siparişi veritabanı bağlamına alın
                        var siparisToUpdate = context.VerilenSiparisler.SingleOrDefault(s => s.SiparisID == siparisId);

                        if (siparisToUpdate != null)
                        {
                            // Formdaki değerleri al
                            double fiyat = Convert.ToDouble(Fiyat.Text);
                            double iskontoOrani = Convert.ToDouble(IskontoOrani.Text) / 100.0;
                            double kdvOrani = Convert.ToDouble(KDVOrani.Text) / 100.0;

                            // İskontolu fiyat hesapla
                            double iskontoTutari = fiyat * iskontoOrani;
                            double iskontoSonrasiFiyat = fiyat - iskontoTutari;

                            // KDV tutarını hesapla
                            double kdvTutari = iskontoSonrasiFiyat * kdvOrani;

                            // Toplam fiyatı hesapla
                            double toplamFiyat = iskontoSonrasiFiyat + kdvTutari;

                            // Sipariş durumu
                            string siparisDurumu = "";
                            if (radioSiparisVerildi.Checked)
                                siparisDurumu = "Sipariş Verildi";
                            else if (radioSiparisHazırlanıyor.Checked)
                                siparisDurumu = "Sipariş Yolda";
                            else if (radioSiparisGeldi.Checked)
                                siparisDurumu = "Sipariş Geldi";

                            // Verileri güncelle
                            siparisToUpdate.TedarikciAdSoyad = TedarikciAdi.SelectedValue.ToString();
                            siparisToUpdate.SiparisDetayi = SiparisDetayi.Text;
                            siparisToUpdate.KDVOrani = kdvOrani * 100;  // KDV oranını yüzde olarak sakla
                            siparisToUpdate.KDVTutari = kdvTutari;       // Veritabanına KDV tutarını ekle
                            siparisToUpdate.Fiyat = fiyat;
                            siparisToUpdate.IskontoOrani = iskontoOrani * 100; // İskonto oranını yüzde olarak sakla
                            siparisToUpdate.IskontoTutari = iskontoTutari;     // İskonto tutarını veritabanına ekle
                            siparisToUpdate.ToplamFiyat = toplamFiyat;
                            siparisToUpdate.SiparisNotu = SiparisNotu.Text;
                            siparisToUpdate.SiparisAlisTarihi = SiparisAlisTarihi.Value;
                            siparisToUpdate.SiparisTeslimTarihi = SiparisTeslimTarihi.Value;
                            siparisToUpdate.CariAd = CariAdi.Text;
                            siparisToUpdate.SiparisDurumu = siparisDurumu; // Sipariş durumunu ekle
                            ToplamFiyat.Text = toplamFiyat.ToString();
                            context.SaveChanges();
                            VerilenSiparislerTablo.DataSource = context.VerilenSiparisler.ToList();
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
            if (VerilenSiparislerTablo.SelectedRows.Count > 0)
            {
                var selectedRow = VerilenSiparislerTablo.SelectedRows[0];
                var selectedSiparis = (VerilenSiparis)selectedRow.DataBoundItem;

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
                TedarikciAdi.SelectedValue = selectedSiparis.TedarikciAdSoyad;
                CariAdi.Text = selectedSiparis.CariAd;
                SiparisDetayi.Text = selectedSiparis.SiparisDetayi;
                KDVOrani.Text = selectedSiparis.KDVOrani.ToString();
                ToplamFiyat.Text = selectedSiparis.ToplamFiyat.ToString();
                Fiyat.Text = selectedSiparis.Fiyat.ToString();
                IskontoOrani.Text = selectedSiparis.IskontoOrani.ToString();
                SiparisNotu.Text = selectedSiparis.SiparisNotu;
            }
            else
            {
                MessageBox.Show("Lütfen bir satır seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void TedarikciAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Seçilen tedarikçi nesnesini al

            var selectedTedarikci = TedarikciAdi.SelectedItem as Tedarikci; // Musteri, müşteri nesnelerinin tutulduğu sınıf


            if (selectedTedarikci != null)
            {
                // Seçilen müşterinin musteriId'sini al ve TextBox'a ata
                CariAdi.Text = selectedTedarikci.CariAd; // CariAdTextBox, cari adını tutacak TextBox'ın adı

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

        private void FormTemizle_Click(object sender, EventArgs e)
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

        private void VerilenSiparislerTablo_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Hücrelerin TL formatında görünmesini sağlamak için
            if (VerilenSiparislerTablo.Columns[e.ColumnIndex].Name == "KDVTutari" ||
                VerilenSiparislerTablo.Columns[e.ColumnIndex].Name == "IskontoTutari" ||
                VerilenSiparislerTablo.Columns[e.ColumnIndex].Name == "ToplamFiyat" ||
                VerilenSiparislerTablo.Columns[e.ColumnIndex].Name == "Fiyat")
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
            if (VerilenSiparislerTablo.Columns[e.ColumnIndex].Name == "KDVOrani" ||
       VerilenSiparislerTablo.Columns[e.ColumnIndex].Name == "IskontoOrani"
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
                var filteredData = context.VerilenSiparisler
                    .Where(f =>
                        f.SiparisID.ToString().Contains(searchText) ||
                        f.TedarikciAdSoyad.ToLower().Contains(searchText) ||
                        f.CariAd.ToLower().Contains(searchText) ||
                        f.TedarikciID.ToString().Contains(searchText) ||
                        f.SiparisDurumu.ToLower().Contains(searchText) ||
                        f.Fiyat.ToString().Contains(searchText) ||
                        f.SiparisNotu.ToLower().Contains(searchText) ||
                        (isDate && f.SiparisAlisTarihi.Date == searchDate.Date) || // Tarih karşılaştırması
                        (isDate && f.SiparisTeslimTarihi.HasValue && f.SiparisTeslimTarihi.Value.Date == searchDate.Date) || // Nullable tarih kontrolü
                        f.ToplamFiyat.ToString().Contains(searchText)
                    ).ToList();

                // DataGridView'e filtrelenmiş veriyi yükle
                VerilenSiparislerTablo.DataSource = filteredData;
            }
        }

        private void VerilenSiparislerTablo_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string columnName = VerilenSiparislerTablo.Columns[e.ColumnIndex].DataPropertyName;
            if (!string.IsNullOrEmpty(columnName))
            {
                var dataSource = (List<VerilenSiparis>)VerilenSiparislerTablo.DataSource;
                var sortedData = dataSource.OrderBy(x => x.GetType().GetProperty(columnName).GetValue(x, null)).ToList();
                VerilenSiparislerTablo.DataSource = sortedData;
            }
        }
    }
}
