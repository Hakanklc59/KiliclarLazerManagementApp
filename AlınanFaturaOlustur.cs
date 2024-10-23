using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YonetimBilgiSistemleri
{
    public partial class AlınanFaturaOlustur : Form
    {
        public AlinanFatura selectedFatura; // Seçili sipariş için değişken

        public AlınanFaturaOlustur()
        {
            InitializeComponent();
        }
        private void InitializeDataGridView1()
        {
            using (var context = new MyDbContext())
            {
                // DataGridView kontrolünü ayarlayın
                AlinanFaturaTablo.AutoGenerateColumns = false; // Otomatik sütun oluşturmayı kapatın

                // Sütun tanımları
                var columns = new (string ColumnName, string HeaderText, int DisplayIndex)[]
                {
        ("FaturaNo", "Fatura No", 0),
        ("TedarikciAdSoyad", "Tedarikçi Adı Soyadı", 1),
        ("CariAd", "Cari Ad", 2),
        ("TedarikciID", "Tedarikçi ID", 3),
        ("Tckn", "TCKN", 4),
        ("Vkn", "VKN", 5),
        ("TelNo", "Telefon No", 6),
        ("Adres", "Adres", 7),
        ("VergiDairesi", "Vergi Dairesi", 8),
        ("GiderTuru", "Gider ve Ödeme Türü", 9),
        ("FaturaSenaryo", "Fatura Senaryosu", 10),
        ("IbanBilgi", "IBAN Bilgisi", 11),
        ("Aciklama", "Fatura Açıklaması", 12),
        ("FaturaTarihi", "Fatura Tarihi", 13),
        ("FaturaGonderimTarihi", "Fatura Vade Tarihi", 14),
        ("MalHizmetTutari", "Mal Hizmet Tutarı", 15),
        ("ToplamIskonto", "Toplam İskonto", 16),
        ("HesaplananKdv", "Hesaplanan KDV", 17),
        ("VergilerDahilTutar", "Vergiler Dahil Tutar", 18),
        ("NetTutar", "Net Tutar", 19),("FaturaDurumu", "Fatura Durumu", 20),("Belge", "Belge", 21),("Belgeadi", "Belgeadi", 22),("FaturaID", "Fatura ID", 23)
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

                    AlinanFaturaTablo.Columns.Add(dataGridViewColumn);
                }

                // DataGridView'i doldurun
                // Örnek veri kaynağı olarak context kullanıldı, kendi veri kaynağınızı buraya ekleyin
                AlinanFaturaTablo.DataSource = context.AlinanFaturalar.ToList(); // Burada 'context.Faturalar' ile fatura verilerinizi çekin
            }


            // Başlık stili
            AlinanFaturaTablo.EnableHeadersVisualStyles = false;
            AlinanFaturaTablo.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 45, 48); // Daha yumuşak bir koyu renk
            AlinanFaturaTablo.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            AlinanFaturaTablo.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel); // Kalın (bold) font
            AlinanFaturaTablo.ColumnHeadersHeight = 45; // Sütun başlık yüksekliği

            // Alternatif satır renkleri ve arka plan
            AlinanFaturaTablo.RowsDefaultCellStyle.BackColor = Color.White;
            AlinanFaturaTablo.RowsDefaultCellStyle.ForeColor = Color.Black;
            AlinanFaturaTablo.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240); // Hafif gri ton

            // Satır kenar çizgileri için stil
            AlinanFaturaTablo.CellBorderStyle = DataGridViewCellBorderStyle.None; // Hücre çizgilerini kaldırıyoruz

            // Satırlar arasındaki boşluk
            AlinanFaturaTablo.RowTemplate.DividerHeight = 5; // Satırlar arasına boşluk ekliyoruz (arttırıldı)
            AlinanFaturaTablo.RowTemplate.Height = 40; // Satır yüksekliği (biraz daha yüksek olabilir)

            // Satır başlıklarını görünür yaparak sol tarafa seçim işareti ekliyoruz
            AlinanFaturaTablo.RowHeadersVisible = true; // Satır başlıkları görünüyor
            AlinanFaturaTablo.RowHeadersWidth = 29; // Başlıklar için genişlik azaltıldı
            AlinanFaturaTablo.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 45, 48); // Sol başlık arka plan rengi
            AlinanFaturaTablo.RowHeadersDefaultCellStyle.ForeColor = Color.White; // Sol başlık metin rengi
            AlinanFaturaTablo.RowHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(30, 30, 30); // Seçildiğinde başlık arka planı
                                                                                                          // DataGridView sütunlarının otomatik boyutlandırma ayarı
                                                                                                          // DataGridView'de hücrelerin sarılması
            AlinanFaturaTablo.DefaultCellStyle.WrapMode = DataGridViewTriState.True; // Hücre içeriğini sar

            // DataGridView'deki satırların otomatik yüksekliğini ayarlama
            AlinanFaturaTablo.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells; // Tüm hücreler için satır yüksekliğini ayarla


            // Seçilen hücreler için stil
            AlinanFaturaTablo.DefaultCellStyle.SelectionBackColor = Color.FromArgb(45, 45, 48); // Modern bir mavi ton
            AlinanFaturaTablo.DefaultCellStyle.SelectionForeColor = Color.White;

            // DataGridView kenarlık stili (kenarlık renklerini ayarlıyoruz)
            AlinanFaturaTablo.AdvancedColumnHeadersBorderStyle.All = DataGridViewAdvancedCellBorderStyle.Single; // Sütun başlık kenarlıkları
            AlinanFaturaTablo.AdvancedCellBorderStyle.All = DataGridViewAdvancedCellBorderStyle.Single; // Hücreler arası kenarlık

            // Hücrelerin köşelerine ve gölgelerine benzer bir efekt için padding ekleyebiliriz
            AlinanFaturaTablo.DefaultCellStyle.Padding = new Padding(5); // Hücrelerin içerisine padding ekleyerek ferah bir görünüm
            AlinanFaturaTablo.AlternatingRowsDefaultCellStyle.Padding = new Padding(5);

            // DataGridView için çizgi renklerini belirleyebiliriz
            AlinanFaturaTablo.GridColor = Color.LightGray; // Hücreler arası çizgi rengi

            // Arka plan rengini yumuşak bir renkle değiştirme
            AlinanFaturaTablo.BackgroundColor = Color.WhiteSmoke; // Arka planı modern ve yumuşak bir renk

            // Satır başlıklarının kenarlık stilini kaldırabiliriz, böylece daha sade bir görünüm olur
            AlinanFaturaTablo.AdvancedRowHeadersBorderStyle.All = DataGridViewAdvancedCellBorderStyle.None; // Satır başlık kenarlıkları kaldırıldı

            // İlk sütunun genişliğini azaltma
            AlinanFaturaTablo.Columns[0].Width = 45; // İlk sütun genişliği azaltıldı

            AlinanFaturaTablo.Columns["FaturaTarihi"].DefaultCellStyle.Format = "dd.MM.yyyy"; // Sadece tarihi gösterecek
            AlinanFaturaTablo.Columns["FaturaGonderimTarihi"].DefaultCellStyle.Format = "dd.MM.yyyy"; // Sadece tarihi gösterecek

         

        }

        private void AlınanFaturaOlustur_Load(object sender, EventArgs e)
        {
            InitializeDataGridView1();

            using (var context = new MyDbContext())
            {
                // Müşteri listesini yükle
                TXTTedarikciAdi.DataSource = context.Tedarikciler.ToList();
                TXTTedarikciAdi.DisplayMember = "TedarikciAdSoyad"; // Müşteri adını göster
                TXTTedarikciAdi.ValueMember = "TedarikciAdSoyad"; // Değer olarak Id kullan
                // Siparişleri yükle
                AlinanFaturaTablo.DataSource = context.AlinanFaturalar.ToList();

                AlinanFaturaTablo.Columns["TedarikciId"].Visible = false;




            }
        }

        private void Ekle_Click(object sender, EventArgs e)
        {

            // Giriş Kontrolleri
            if (string.IsNullOrWhiteSpace(TXTFaturaNo.Text) ||
                string.IsNullOrWhiteSpace(TXTTedarikciAdi.Text) ||
                string.IsNullOrWhiteSpace(TXTTCKN.Text) ||
                string.IsNullOrWhiteSpace(TXTVKN.Text) ||
                string.IsNullOrWhiteSpace(TXTTelNo.Text) ||
                string.IsNullOrWhiteSpace(TXTAdres.Text) ||
                string.IsNullOrWhiteSpace(TXTVergiDairesi.Text) ||
                string.IsNullOrWhiteSpace(TXTFaturaTarihi.Text) ||
                string.IsNullOrWhiteSpace(TXTFaturaSenaryo.Text) ||
                string.IsNullOrWhiteSpace(TXTIban.Text) ||
                string.IsNullOrWhiteSpace(TXTMalHizmetTutari.Text) ||
                string.IsNullOrWhiteSpace(TXTToplamIskontoTutari.Text) ||
                string.IsNullOrWhiteSpace(TXTHesaplananKdvTutari.Text) ||
                string.IsNullOrWhiteSpace(TXTVergilerDahilTutar.Text) ||
                string.IsNullOrWhiteSpace(TXTNetTutar.Text) ||
                string.IsNullOrWhiteSpace(TXTGiderTuru.Text) ||
                string.IsNullOrWhiteSpace(TXTFaturaAciklamasi.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var context = new MyDbContext())
            {
                try
                {
                    string Faturadurumu = radioodenecek.Checked ? "FATURA ÖDENECEK" :
                                          radioodendi.Checked ? "FATURA ÖDENDİ" : "";

                    var yeniFatura = new AlinanFatura
                    {


                        FaturaNo = TXTFaturaNo.Text,
                        TedarikciAdSoyad = TXTTedarikciAdi.SelectedValue.ToString(),
                        CariAd = TXTCariAdi.Text,
                        TedarikciID = Convert.ToInt32(TXTTedarikciID.Text),
                        Tckn = TXTTCKN.Text,
                        Vkn = TXTVKN.Text,
                        TelNo = TXTTelNo.Text,
                        Adres = TXTAdres.Text,
                        VergiDairesi = TXTVergiDairesi.Text,
                        GiderTuru = TXTGiderTuru.Text,
                        FaturaSenaryo = TXTFaturaSenaryo.Text,
                        IbanBilgi = TXTIban.Text,
                        Aciklama = TXTFaturaAciklamasi.Text,
                        FaturaTarihi = TXTFaturaTarihi.Value,
                        FaturaGonderimTarihi = TXTGonderimTarihi.Value,
                        MalHizmetTutari = Convert.ToDouble(TXTMalHizmetTutari.Text),
                        ToplamIskonto = Convert.ToDouble(TXTToplamIskontoTutari.Text),
                        HesaplananKdv = Convert.ToDouble(TXTHesaplananKdvTutari.Text),
                        VergilerDahilTutar = Convert.ToDouble(TXTVergilerDahilTutar.Text),
                        NetTutar = Convert.ToDouble(TXTNetTutar.Text),
                        Belge = dosyaBytes,
                        Belgeadi = dosyaAdi,
                        FaturaDurumu = Faturadurumu

                    };

                    context.AlinanFaturalar.Add(yeniFatura);
                    context.SaveChanges();
                    AlinanFaturaTablo.DataSource = context.AlinanFaturalar.ToList();
                    MessageBox.Show("Fatura başarıyla eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Sil_Click(object sender, EventArgs e)
        {
            if (AlinanFaturaTablo.SelectedRows.Count > 0) // Seçili bir fatura var mı kontrolü
            {
                // İlk seçili satırı al
                var selectedRow = AlinanFaturaTablo.SelectedRows[0];
                int faturaId = Convert.ToInt32(selectedRow.Cells["FaturaID"].Value); // FaturaID'yi al

                using (var context = new MyDbContext())
                {
                    var selectedFatura = context.AlinanFaturalar.FirstOrDefault(f => f.FaturaID == faturaId);

                    if (selectedFatura != null)
                    {
                        // Silme onayı penceresi
                        DialogResult result = MessageBox.Show("Seçili fatura silinsin mi?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            try
                            {
                                // Faturayı sil
                                context.AlinanFaturalar.Remove(selectedFatura);
                                context.SaveChanges(); // Değişiklikleri kaydet

                                // Tabloyu güncelle
                                AlinanFaturaTablo.DataSource = context.AlinanFaturalar.ToList();
                                MessageBox.Show("Fatura başarıyla silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Bir hata oluştu: " + ex.Message + "\n" + ex.InnerException?.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Silmek için bir fatura seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("Silinecek fatura seçilmedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Guncelle_Click(object sender, EventArgs e)
        {
            if (AlinanFaturaTablo.SelectedRows.Count > 0) // Seçili satır var mı kontrolü
            {
                DataGridViewRow selectedRow = AlinanFaturaTablo.SelectedRows[0]; // Seçili satırı al
                int id = Convert.ToInt32(selectedRow.Cells["FaturaID"].Value); // ID'yi al

                using (var context = new MyDbContext())
                {
                    var faturaToUpdate = context.AlinanFaturalar.FirstOrDefault(f => f.FaturaID == id);
                    if (faturaToUpdate != null)
                    {
                        // Gerekli alanların boş olup olmadığını kontrol et
                        if (string.IsNullOrWhiteSpace(TXTFaturaNo.Text) ||
                            string.IsNullOrWhiteSpace(TXTTedarikciID.Text) ||
                            string.IsNullOrWhiteSpace(TXTCariAdi.Text))
                        {
                            MessageBox.Show("Fatura No, Müşteri ID ve Cari Ad alanları boş olamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        string Faturadurumu = radioodenecek.Checked ? "FATURA ÖDENECEK" :
                                               radioodendi.Checked ? "FATURA ÖDENDİ" : "";

                        try
                        {
                            // Güncelleme işlemi
                            faturaToUpdate.TedarikciAdSoyad = TXTTedarikciAdi.SelectedValue.ToString();

                            faturaToUpdate.FaturaNo = TXTFaturaNo.Text;
                            faturaToUpdate.TedarikciID = Convert.ToInt32(TXTTedarikciID.Text);
                            faturaToUpdate.CariAd = TXTCariAdi.Text;
                            faturaToUpdate.FaturaTarihi = TXTFaturaTarihi.Value;
                            faturaToUpdate.FaturaGonderimTarihi = TXTGonderimTarihi.Value;
                            faturaToUpdate.Tckn = TXTTCKN.Text;
                            faturaToUpdate.Vkn = TXTVKN.Text;
                            faturaToUpdate.TelNo = TXTTelNo.Text;
                            faturaToUpdate.Adres = TXTAdres.Text;
                            faturaToUpdate.VergiDairesi = TXTVergiDairesi.Text;
                            faturaToUpdate.FaturaSenaryo = TXTFaturaSenaryo.Text;
                            faturaToUpdate.IbanBilgi = TXTIban.Text;
                            faturaToUpdate.MalHizmetTutari = Convert.ToDouble(TXTMalHizmetTutari.Text);
                            faturaToUpdate.ToplamIskonto = Convert.ToDouble(TXTToplamIskontoTutari.Text);
                            faturaToUpdate.HesaplananKdv = Convert.ToDouble(TXTHesaplananKdvTutari.Text);
                            faturaToUpdate.VergilerDahilTutar = Convert.ToDouble(TXTVergilerDahilTutar.Text);
                            faturaToUpdate.NetTutar = Convert.ToDouble(TXTNetTutar.Text);
                            faturaToUpdate.GiderTuru = TXTGiderTuru.Text;
                            faturaToUpdate.Aciklama = TXTFaturaAciklamasi.Text;
                            faturaToUpdate.FaturaDurumu = Faturadurumu;

                           

                            faturaToUpdate.Belge = dosyaBytes;
                            faturaToUpdate.Belgeadi = dosyaAdi;
                            faturaToUpdate.FaturaDurumu = Faturadurumu;

                            try
                            {
                                context.SaveChanges(); // Değişiklikleri kaydet
                            }
                            catch (DbUpdateException dbEx)
                            {
                                MessageBox.Show("Veritabanı güncelleme hatası: " + dbEx.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            AlinanFaturaTablo.DataSource = context.AlinanFaturalar.ToList(); // Tabloyu güncelle

                            MessageBox.Show("Fatura başarıyla güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (FormatException formatEx)
                        {
                            MessageBox.Show("Lütfen sayı içeren alanları doğru formatta girin: " + formatEx.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Fatura bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("Güncellemek için bir fatura seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void SatirGetir_Click(object sender, EventArgs e)
        {
            if (AlinanFaturaTablo.SelectedRows.Count > 0)
            {
                try
                {
                    // Seçili satırı al
                    var selectedRow = AlinanFaturaTablo.SelectedRows[0];
                    selectedFatura = (AlinanFatura)selectedRow.DataBoundItem; // Burada seçili faturayı ayarlıyoruz

                    // Seçili faturanın bilgilerini textbox'lara doldur
                    TXTFaturaNo.Text = selectedFatura.FaturaNo;
                    TXTFaturaTarihi.Value = selectedFatura.FaturaTarihi;
                    TXTTedarikciAdi.SelectedValue = selectedFatura.TedarikciAdSoyad; // Eğer ID yerine isim gösteriyorsanız
                    TXTCariAdi.Text = selectedFatura.CariAd;
                    TXTTedarikciID.Text = selectedFatura.TedarikciID.ToString();
                    TXTTCKN.Text = selectedFatura.Tckn;
                    TXTVKN.Text = selectedFatura.Vkn;
                    TXTTelNo.Text = selectedFatura.TelNo;
                    TXTAdres.Text = selectedFatura.Adres;
                    TXTVergiDairesi.Text = selectedFatura.VergiDairesi;
                    TXTGonderimTarihi.Value = selectedFatura.FaturaGonderimTarihi;
                    TXTFaturaTarihi.Value = selectedFatura.FaturaTarihi;
                    TXTFaturaSenaryo.Text = selectedFatura.FaturaSenaryo;
                    TXTIban.Text = selectedFatura.IbanBilgi;
                    TXTMalHizmetTutari.Text = selectedFatura.MalHizmetTutari.ToString();
                    TXTToplamIskontoTutari.Text = selectedFatura.ToplamIskonto.ToString();
                    TXTHesaplananKdvTutari.Text = selectedFatura.HesaplananKdv.ToString();
                    TXTVergilerDahilTutar.Text = selectedFatura.VergilerDahilTutar.ToString();
                    TXTNetTutar.Text = selectedFatura.NetTutar.ToString();
                    TXTGiderTuru.Text = selectedFatura.GiderTuru;
                    TXTFaturaAciklamasi.Text = selectedFatura.Aciklama;
                }
                catch (InvalidCastException castEx)
                {
                    MessageBox.Show("Seçili fatura bilgileri alınamadı: " + castEx.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (NullReferenceException nullEx)
                {
                    MessageBox.Show("Seçili fatura bilgileri eksik: " + nullEx.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Seçili bir fatura yok.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }



        private void cik_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TXTTedarikciAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Seçilen müşteri nesnesini al
            var selectedMusteri = TXTTedarikciAdi.SelectedItem as Tedarikci; // Musteri, müşteri nesnelerinin tutulduğu sınıf


            if (selectedMusteri != null)
            {
                // Seçilen müşterinin musteriId'sini al ve TextBox'a ata
                TXTTedarikciID.Text = selectedMusteri.TedarikciID.ToString(); // txtMusteriId, TextBox'ın adı
                TXTCariAdi.Text = selectedMusteri.CariAd; // CariAdTextBox, cari adını tutacak TextBox'ın adı
                TXTTCKN.Text = selectedMusteri.TcKimlikNo; // CariAdTextBox, cari adını tutacak TextBox'ın adı
                TXTVKN.Text = selectedMusteri.VergiNo; // CariAdTextBox, cari adını tutacak TextBox'ın adı
                TXTTelNo.Text = selectedMusteri.Telefon; // CariAdTextBox, cari adını tutacak TextBox'ın adı
                TXTVergiDairesi.Text = selectedMusteri.VergiDairesi; // CariAdTextBox, cari adını tutacak TextBox'ın adı
                TXTAdres.Text = selectedMusteri.Adres; // CariAdTextBox, cari adını tutacak TextBox'ın adı
                TXTIban.Text = selectedMusteri.IbanBilgisi; // CariAdTextBox, cari adını tutacak TextBox'ın adı




            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label21_Click(object sender, EventArgs e)
        {

        }








        private string dosyaAdi = null;
        private byte[] dosyaBytes;


        private byte[] dosyayiByteDizisineDonustur(string dosyaYolu)
        {
            return File.ReadAllBytes(dosyaYolu);
        }



        public void belgesec_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Tüm Dosyalar|*.*|Resim Dosyaları|*.jpg;*.jpeg;*.png;*.bmp|" +
                                        "PDF Dosyaları|*.pdf|" +
                                        "Word Belgeleri|*.doc;*.docx|" +
                                        "PowerPoint Sunumları|*.ppt;*.pptx|" +
                                        "Metin Dosyaları|*.txt|" +
                                        "Not Defteri Dosyaları|*.rtf";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Dosya adını ve uzantısını alma
                        dosyaAdi = Path.GetFileName(openFileDialog.FileName);
                        dosyaBytes = File.ReadAllBytes(openFileDialog.FileName); // Dosyayı byte dizisine dönüştürme

                        // TextBox'a yükleme sonucunu yazma
                        txtbelge.Text = $"Dosya başarıyla yüklendi: {dosyaAdi}";
                    }
                    catch (Exception ex)
                    {
                        txtbelge.Text = "Yükleme başarısız";
                        MessageBox.Show($"Dosya yüklenirken bir hata oluştu: {ex.Message}");
                    }
                }
            }

        }

        private void AlinanFaturaTablo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && AlinanFaturaTablo.Columns[e.ColumnIndex].Name == "Belge")
            {
                // Seçili satırı alma
                DataGridViewRow row = AlinanFaturaTablo.Rows[e.RowIndex];

                // Belge byte dizisini alma
                byte[] dosyaBytes = row.Cells["Belge"].Value as byte[];

                // Dosya adını alma
                string dosyaAdi = row.Cells["Belgeadi"].Value.ToString();
                string uzanti = Path.GetExtension(dosyaAdi).ToLower();

                // Geçici dosya yolu
                string dosyaYolu = Path.Combine(Path.GetTempPath(), dosyaAdi);

                // Byte dizisini geçici dosyaya yazma
                File.WriteAllBytes(dosyaYolu, dosyaBytes);

                // Uygun programla dosyayı açma (web tarayıcıda veya uygun uygulama)
                try
                {
                    if (uzanti == ".pdf" || uzanti == ".png" || uzanti == ".jpg")
                    {
                        // PDF, PNG, JPG dosyalarını tarayıcıda açma
                        System.Diagnostics.ProcessStartInfo psi = new System.Diagnostics.ProcessStartInfo
                        {
                            FileName = dosyaYolu,
                            UseShellExecute = true // Varsayılan tarayıcıda aç
                        };
                        System.Diagnostics.Process.Start(psi);
                    }
                    else if (uzanti == ".doc" || uzanti == ".docx")
                    {
                        // Word dosyalarını varsayılan uygulama ile açma
                        System.Diagnostics.ProcessStartInfo psi = new System.Diagnostics.ProcessStartInfo
                        {
                            FileName = dosyaYolu,
                            UseShellExecute = true // Varsayılan uygulamada aç (Word)
                        };
                        System.Diagnostics.Process.Start(psi);
                    }
                    else
                    {
                        MessageBox.Show("Sadece PDF, PNG, JPG, DOC ve DOCX dosyalarını açabilirsiniz.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Dosya açılamadı: " + ex.Message);
                }
            }
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

        private void AlinanFaturaTablo_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Hücrelerin TL formatında görünmesini sağlamak için
            if (AlinanFaturaTablo.Columns[e.ColumnIndex].Name == "MalHizmetTutari" ||
                AlinanFaturaTablo.Columns[e.ColumnIndex].Name == "ToplamIskonto" ||
                AlinanFaturaTablo.Columns[e.ColumnIndex].Name == "HesaplananKdv" ||
                 AlinanFaturaTablo.Columns[e.ColumnIndex].Name == "VergilerDahilTutar" ||
                AlinanFaturaTablo.Columns[e.ColumnIndex].Name == "NetTutar")
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
                var filteredData = context.AlinanFaturalar
                    .Where(f =>
                        f.FaturaNo.ToLower().Contains(searchText) ||
                        f.TedarikciAdSoyad.ToLower().Contains(searchText) ||
                        f.CariAd.ToLower().Contains(searchText) ||
                        f.Tckn.ToLower().Contains(searchText) ||
                        f.Vkn.ToLower().Contains(searchText) ||
                        f.TelNo.ToLower().Contains(searchText) ||
                        f.Adres.ToLower().Contains(searchText) ||
                        f.VergiDairesi.ToLower().Contains(searchText) ||
                        f.GiderTuru.ToLower().Contains(searchText) ||
                        f.IbanBilgi.ToLower().Contains(searchText) ||
                        f.Aciklama.ToLower().Contains(searchText) ||
                        (isDate && f.FaturaTarihi.Date == searchDate.Date) || // Tarih karşılaştırması
                        (isDate && f.FaturaGonderimTarihi.Date == searchDate.Date) || // Nullable tarih için kontrol
                        f.MalHizmetTutari.ToString().Contains(searchText) ||
                        f.ToplamIskonto.ToString().Contains(searchText) ||
                        f.HesaplananKdv.ToString().Contains(searchText) ||
                        f.VergilerDahilTutar.ToString().Contains(searchText) ||
                        f.NetTutar.ToString().Contains(searchText) ||
                        f.FaturaDurumu.ToLower().Contains(searchText)
                    ).ToList();

                // DataGridView'e filtrelenmiş veriyi yükle
                AlinanFaturaTablo.DataSource = filteredData;
            }
        }

        private void AlinanFaturaTablo_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
                string columnName = AlinanFaturaTablo.Columns[e.ColumnIndex].DataPropertyName;
                if (!string.IsNullOrEmpty(columnName))
                {
                    var dataSource = (List<AlinanFatura>)AlinanFaturaTablo.DataSource;
                    var sortedData = dataSource.OrderBy(x => x.GetType().GetProperty(columnName).GetValue(x, null)).ToList();
                    AlinanFaturaTablo.DataSource = sortedData;
                }
            
        }
    }
}

