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
    public partial class KesilenFaturaOlustur : Form
    {
        public KesilenFatura selectedFatura; // Seçili sipariş için değişken

        public KesilenFaturaOlustur()
        {
            InitializeComponent();

        }
        private void InitializeDataGridView()
        {
            using (var context = new MyDbContext())
            {

                KesilenFaturaTablo.AllowUserToOrderColumns = true; // Sütunları sürükleyip bırakabilme
                KesilenFaturaTablo.AllowUserToResizeColumns = true; // Sütun boyutlarını değiştirme
                KesilenFaturaTablo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                KesilenFaturaTablo.MultiSelect = false;


                // DataGridView kontrolünü ayarlayın
                KesilenFaturaTablo.AutoGenerateColumns = false; // Otomatik sütun oluşturmayı kapatın

                // Sütun tanımları
                var columns = new (string ColumnName, string HeaderText, int DisplayIndex)[]
                {
        ("FaturaNo", "Fatura No", 0),
        ("MusteriAdSoyad", "Müşteri Adı Soyadı", 1),
        ("CariAd", "Cari Ad", 2),
        ("MusteriID", "Müşteri ID", 3),
        ("Tckn", "TCKN", 4),
        ("Vkn", "VKN", 5),
        ("TelNo", "Telefon No", 6),
        ("Adres", "Adres", 7),
        ("VergiDairesi", "Vergi Dairesi", 8),
        ("HizmetTuru", "Hizmet ve Ödeme Türü", 9),
        ("FaturaSenaryo", "Fatura Senaryosu", 10),
        ("IbanBilgi", "IBAN Bilgisi", 11),
        ("Aciklama", "Fatura Açıklaması", 12),
        ("FaturaTarihi", "Fatura Tarihi", 13),
        ("FaturaGonderimTarihi", "Fatura Vade Tarihi", 14),
        ("MalHizmetTutari", "Mal Hizmet Tutarı", 15),
        ("ToplamIskonto", "Toplam İskonto", 16),
        ("HesaplananKdv", "Hesaplanan KDV", 17),
        ("VergilerDahilTutar", "Vergiler Dahil Tutar", 18),
        ("NetTutar", "Net Tutar", 19), ("FaturaDurumu", "Fatura Durumu", 20),("Belge", "Belge", 21),("Belgeadi", "Belgeadi", 22),("FaturaID", "Fatura ID", 23)

            };

                // Sütunları DataGridView'e ekleyin
                foreach (var column in columns)
                {
                    var dataGridViewColumn = new DataGridViewTextBoxColumn
                    {
                        Name = column.ColumnName,
                        HeaderText = column.HeaderText,
                        DataPropertyName = column.ColumnName,
                        DisplayIndex = column.DisplayIndex,
                        SortMode = DataGridViewColumnSortMode.Programmatic // Programatik sıralama                

                    };

                    KesilenFaturaTablo.Columns.Add(dataGridViewColumn);
                }

                // DataGridView'i doldurun
                // Örnek veri kaynağı olarak context kullanıldı, kendi veri kaynağınızı buraya ekleyin
                KesilenFaturaTablo.DataSource = context.KesilenFaturalar.ToList(); // Burada 'context.Faturalar' ile fatura verilerinizi çekin
                // Başlık stili
                KesilenFaturaTablo.EnableHeadersVisualStyles = false;
                KesilenFaturaTablo.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 45, 48); // Daha yumuşak bir koyu renk
                KesilenFaturaTablo.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                KesilenFaturaTablo.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel); // Kalın (bold) font
                KesilenFaturaTablo.ColumnHeadersHeight = 45; // Sütun başlık yüksekliği

                // Alternatif satır renkleri ve arka plan
                KesilenFaturaTablo.RowsDefaultCellStyle.BackColor = Color.White;
                KesilenFaturaTablo.RowsDefaultCellStyle.ForeColor = Color.Black;
                KesilenFaturaTablo.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240); // Hafif gri ton

                // Satır kenar çizgileri için stil
                KesilenFaturaTablo.CellBorderStyle = DataGridViewCellBorderStyle.None; // Hücre çizgilerini kaldırıyoruz

                // Satırlar arasındaki boşluk
                KesilenFaturaTablo.RowTemplate.DividerHeight = 5; // Satırlar arasına boşluk ekliyoruz (arttırıldı)
                KesilenFaturaTablo.RowTemplate.Height = 40; // Satır yüksekliği (biraz daha yüksek olabilir)

                // Satır başlıklarını görünür yaparak sol tarafa seçim işareti ekliyoruz
                KesilenFaturaTablo.RowHeadersVisible = true; // Satır başlıkları görünüyor
                KesilenFaturaTablo.RowHeadersWidth = 29; // Başlıklar için genişlik azaltıldı
                KesilenFaturaTablo.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 45, 48); // Sol başlık arka plan rengi
                KesilenFaturaTablo.RowHeadersDefaultCellStyle.ForeColor = Color.White; // Sol başlık metin rengi
                KesilenFaturaTablo.RowHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(30, 30, 30); // Seçildiğinde başlık arka planı
                                                                                                               // DataGridView sütunlarının otomatik boyutlandırma ayarı
                                                                                                               // DataGridView'de hücrelerin sarılması
                KesilenFaturaTablo.DefaultCellStyle.WrapMode = DataGridViewTriState.True; // Hücre içeriğini sar

                // DataGridView'deki satırların otomatik yüksekliğini ayarlama
                KesilenFaturaTablo.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells; // Tüm hücreler için satır yüksekliğini ayarla


                // Seçilen hücreler için stil
                KesilenFaturaTablo.DefaultCellStyle.SelectionBackColor = Color.FromArgb(45, 45, 48); // Modern bir mavi ton                KesilenFaturaTablo.DefaultCellStyle.SelectionForeColor = Color.White;

                // DataGridView kenarlık stili (kenarlık renklerini ayarlıyoruz)
                KesilenFaturaTablo.AdvancedColumnHeadersBorderStyle.All = DataGridViewAdvancedCellBorderStyle.Single; // Sütun başlık kenarlıkları
                KesilenFaturaTablo.AdvancedCellBorderStyle.All = DataGridViewAdvancedCellBorderStyle.Single; // Hücreler arası kenarlık

                // Hücrelerin köşelerine ve gölgelerine benzer bir efekt için padding ekleyebiliriz
                KesilenFaturaTablo.DefaultCellStyle.Padding = new Padding(5); // Hücrelerin içerisine padding ekleyerek ferah bir görünüm
                KesilenFaturaTablo.AlternatingRowsDefaultCellStyle.Padding = new Padding(5);

                // DataGridView için çizgi renklerini belirleyebiliriz
                KesilenFaturaTablo.GridColor = Color.LightGray; // Hücreler arası çizgi rengi

                // Arka plan rengini yumuşak bir renkle değiştirme
                KesilenFaturaTablo.BackgroundColor = Color.WhiteSmoke; // Arka planı modern ve yumuşak bir renk

                // Satır başlıklarının kenarlık stilini kaldırabiliriz, böylece daha sade bir görünüm olur
                KesilenFaturaTablo.AdvancedRowHeadersBorderStyle.All = DataGridViewAdvancedCellBorderStyle.None; // Satır başlık kenarlıkları kaldırıldı

                // İlk sütunun genişliğini azaltma
                KesilenFaturaTablo.Columns[0].Width = 45; // İlk sütun genişliği azaltıldı

                KesilenFaturaTablo.Columns["FaturaTarihi"].DefaultCellStyle.Format = "dd.MM.yyyy"; // Sadece tarihi gösterecek
                KesilenFaturaTablo.Columns["FaturaGonderimTarihi"].DefaultCellStyle.Format = "dd.MM.yyyy"; // Sadece tarihi gösterecek

               






            }
        }


        private void KesilenFaturaOlustur_Load(object sender, EventArgs e)
        {
            InitializeDataGridView();
            using (var context = new MyDbContext())
            {
                // Müşteri listesini yükle
                TXTMusteriAdi.DataSource = context.Musteriler.ToList();
                TXTMusteriAdi.DisplayMember = "MusteriAdSoyad"; // Müşteri adını göster
                TXTMusteriAdi.ValueMember = "MusteriAdSoyad"; // Değer olarak Id kullan
                // Siparişleri yükle
                KesilenFaturaTablo.DataSource = context.KesilenFaturalar.ToList();

                KesilenFaturaTablo.Columns["MusteriId"].Visible = false;

            }
        }

        private void Ekle_Click(object sender, EventArgs e)
        {

            // Giriş Kontrolleri
            if (string.IsNullOrWhiteSpace(TXTFaturaNo.Text) ||
                string.IsNullOrWhiteSpace(TXTMusteriAdi.Text) ||
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
                string.IsNullOrWhiteSpace(TXTHizmetTuru.Text) ||
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
                  
                    var yeniFatura = new KesilenFatura
                    {
                        FaturaNo = TXTFaturaNo.Text,

                        MusteriAdSoyad = TXTMusteriAdi.SelectedValue.ToString(),
                        CariAd = TXTCariAd.Text,
                        MusteriID = Convert.ToInt32(TXTMusteriID.Text),
                        Tckn = TXTTCKN.Text,
                        Vkn = TXTVKN.Text,
                        TelNo = TXTTelNo.Text,
                        Adres = TXTAdres.Text,
                        VergiDairesi = TXTVergiDairesi.Text,
                        HizmetTuru = TXTHizmetTuru.Text,
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
                        Belgeadi = string.IsNullOrWhiteSpace(dosyaAdi) ? null : dosyaAdi, // Eğer dosyaAdi boşsa null yapıyoruz
                        FaturaDurumu = Faturadurumu
                    };


                    context.KesilenFaturalar.Add(yeniFatura);
                    context.SaveChanges();
                    KesilenFaturaTablo.DataSource = context.KesilenFaturalar.ToList();
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
            if (KesilenFaturaTablo.SelectedRows.Count > 0) // Seçili bir fatura var mı kontrolü
            {
                // İlk seçili satırı al
                var selectedRow = KesilenFaturaTablo.SelectedRows[0];
                int faturaId = Convert.ToInt32(selectedRow.Cells["FaturaID"].Value); // FaturaID'yi al

                using (var context = new MyDbContext())
                {
                    var selectedFatura = context.KesilenFaturalar.FirstOrDefault(f => f.FaturaID == faturaId);

                    if (selectedFatura != null)
                    {
                        // Silme onayı penceresi
                        DialogResult result = MessageBox.Show("Seçili fatura silinsin mi?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            try
                            {
                                // Faturayı sil
                                context.KesilenFaturalar.Remove(selectedFatura);
                                context.SaveChanges(); // Değişiklikleri kaydet

                                // Tabloyu güncelle
                                KesilenFaturaTablo.DataSource = context.KesilenFaturalar.ToList();
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
            if (KesilenFaturaTablo.SelectedRows.Count > 0) // Seçili satır var mı kontrolü
            {
                try
                {
                    DataGridViewRow selectedRow = KesilenFaturaTablo.SelectedRows[0]; // Seçili satırı al
                    int id = Convert.ToInt32(selectedRow.Cells["FaturaID"].Value); // ID'yi al

                    using (var context = new MyDbContext())
                    {
                        var faturaToUpdate = context.KesilenFaturalar.FirstOrDefault(f => f.FaturaID == id);
                        if (faturaToUpdate != null)
                        {
                            // Gerekli alanların boş olup olmadığını kontrol et
                            if (string.IsNullOrWhiteSpace(TXTFaturaNo.Text) ||
                                string.IsNullOrWhiteSpace(TXTMusteriID.Text) ||
                                string.IsNullOrWhiteSpace(TXTCariAd.Text))
                            {
                                MessageBox.Show("Fatura No, Müşteri ID ve Cari Ad alanları boş olamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            string Faturadurumu = radioodenecek.Checked ? "FATURA ÖDENECEK" :
                                                  radioodendi.Checked ? "FATURA ÖDENDİ" : "";

                            // Fatura bilgilerini güncelle
                            faturaToUpdate.FaturaNo = TXTFaturaNo.Text;
                            faturaToUpdate.FaturaTarihi = TXTFaturaTarihi.Value;
                            faturaToUpdate.MusteriID = Convert.ToInt32(TXTMusteriID.Text);

                            faturaToUpdate.MusteriAdSoyad = TXTMusteriAdi.SelectedValue.ToString();
                            faturaToUpdate.CariAd = TXTCariAd.Text;
                            faturaToUpdate.Tckn = TXTTCKN.Text;
                            faturaToUpdate.Vkn = TXTVKN.Text;
                            faturaToUpdate.TelNo = TXTTelNo.Text;
                            faturaToUpdate.Adres = TXTAdres.Text;
                            faturaToUpdate.VergiDairesi = TXTVergiDairesi.Text;
                            faturaToUpdate.FaturaGonderimTarihi = TXTGonderimTarihi.Value;
                            faturaToUpdate.FaturaSenaryo = TXTFaturaSenaryo.Text;
                            faturaToUpdate.IbanBilgi = TXTIban.Text;
                            faturaToUpdate.MalHizmetTutari = Convert.ToDouble(TXTMalHizmetTutari.Text);
                            faturaToUpdate.ToplamIskonto = Convert.ToDouble(TXTToplamIskontoTutari.Text);
                            faturaToUpdate.HesaplananKdv = Convert.ToDouble(TXTHesaplananKdvTutari.Text);
                            faturaToUpdate.VergilerDahilTutar = Convert.ToDouble(TXTVergilerDahilTutar.Text);
                            faturaToUpdate.NetTutar = Convert.ToDouble(TXTNetTutar.Text);
                            faturaToUpdate.HizmetTuru = TXTHizmetTuru.Text;
                            faturaToUpdate.Aciklama = TXTFaturaAciklamasi.Text;
                            faturaToUpdate.Belge = dosyaBytes;
                            faturaToUpdate.Belgeadi = dosyaAdi;
                            faturaToUpdate.FaturaDurumu = Faturadurumu;

                            context.SaveChanges(); // Değişiklikleri kaydet
                            KesilenFaturaTablo.DataSource = context.KesilenFaturalar.ToList();

                            MessageBox.Show("Fatura başarıyla güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Seçimi kaldır
                            KesilenFaturaTablo.ClearSelection();
                        }
                        else
                        {
                            MessageBox.Show("Güncellenecek fatura bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (FormatException formatEx)
                {
                    MessageBox.Show("Girdiğiniz bilgilerde bir hata var: " + formatEx.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (InvalidOperationException invalidOpEx)
                {
                    MessageBox.Show("Veritabanı ile ilgili bir hata oluştu: " + invalidOpEx.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz bir satır seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SatirGetir_Click(object sender, EventArgs e)
        {
            if (KesilenFaturaTablo.SelectedRows.Count > 0)
            {
                try
                {
                    // Seçili satırı al
                    var selectedRow = KesilenFaturaTablo.SelectedRows[0];
                    selectedFatura = (KesilenFatura)selectedRow.DataBoundItem; // Burada seçili faturayı ayarlıyoruz

                    // Seçili faturanın bilgilerini textbox'lara doldur
                    TXTFaturaNo.Text = selectedFatura.FaturaNo;
                    TXTFaturaTarihi.Value = selectedFatura.FaturaTarihi;
                    TXTMusteriAdi.SelectedValue = selectedFatura.MusteriAdSoyad; // Eğer ID yerine isim gösteriyorsanız
                    TXTCariAd.Text = selectedFatura.CariAd;
                    TXTMusteriID.Text = selectedFatura.MusteriID.ToString();
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
                    TXTHizmetTuru.Text = selectedFatura.HizmetTuru;
                    TXTFaturaAciklamasi.Text = selectedFatura.Aciklama;
                }
                catch (InvalidCastException castEx)
                {
                    MessageBox.Show("Seçili fatura bilgileri okunamadı: " + castEx.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void TXTMusteriAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Seçilen müşteri nesnesini al
            var selectedMusteri = TXTMusteriAdi.SelectedItem as Musteri; // Musteri, müşteri nesnelerinin tutulduğu sınıf


            if (selectedMusteri != null)
            {
                // Seçilen müşterinin musteriId'sini al ve TextBox'a ata
                TXTMusteriID.Text = selectedMusteri.MusteriId.ToString(); // txtMusteriId, TextBox'ın adı
                TXTCariAd.Text = selectedMusteri.CariAd; // CariAdTextBox, cari adını tutacak TextBox'ın adı
                TXTTCKN.Text = selectedMusteri.TcKimlikNo; // CariAdTextBox, cari adını tutacak TextBox'ın adı
                TXTVKN.Text = selectedMusteri.VergiNo; // CariAdTextBox, cari adını tutacak TextBox'ın adı
                TXTTelNo.Text = selectedMusteri.Telefon; // CariAdTextBox, cari adını tutacak TextBox'ın adı
                TXTVergiDairesi.Text = selectedMusteri.VergiDairesi; // CariAdTextBox, cari adını tutacak TextBox'ın adı
                TXTAdres.Text = selectedMusteri.Adres; // CariAdTextBox, cari adını tutacak TextBox'ın adı
                TXTIban.Text = selectedMusteri.IbanBilgisi; // CariAdTextBox, cari adını tutacak TextBox'ın adı




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










        private string dosyaAdi = null;
        private byte[] dosyaBytes;

        private byte[] dosyayiByteDizisineDonustur(string dosyaYolu)
        {
            return File.ReadAllBytes(dosyaYolu);
        }


        private void belgesec_Click(object sender, EventArgs e)
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

        private void KesilenFaturaTablo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && KesilenFaturaTablo.Columns[e.ColumnIndex].Name == "Belge")
            {
                // Seçili satırı alma
                DataGridViewRow row = KesilenFaturaTablo.Rows[e.RowIndex];

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

        private void KesilenFaturaTablo_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            // Hücrelerin TL formatında görünmesini sağlamak için
            if (KesilenFaturaTablo.Columns[e.ColumnIndex].Name == "MalHizmetTutari" ||
                KesilenFaturaTablo.Columns[e.ColumnIndex].Name == "ToplamIskonto" ||
                KesilenFaturaTablo.Columns[e.ColumnIndex].Name == "HesaplananKdv" ||
                KesilenFaturaTablo.Columns[e.ColumnIndex].Name == "VergilerDahilTutar" ||
                KesilenFaturaTablo.Columns[e.ColumnIndex].Name == "NetTutar")
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
        private void KesilenFaturaTablo_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string columnName = KesilenFaturaTablo.Columns[e.ColumnIndex].DataPropertyName;
            if (!string.IsNullOrEmpty(columnName))
            {
                var dataSource = (List<KesilenFatura>)KesilenFaturaTablo.DataSource;
                var sortedData = dataSource.OrderBy(x => x.GetType().GetProperty(columnName).GetValue(x, null)).ToList();
                KesilenFaturaTablo.DataSource = sortedData;
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
                var filteredData = context.KesilenFaturalar
                    .Where(f =>
                        f.FaturaNo.ToLower().Contains(searchText) ||
                        f.MusteriAdSoyad.ToLower().Contains(searchText) ||
                        f.CariAd.ToLower().Contains(searchText) ||
                        f.Tckn.ToLower().Contains(searchText) ||
                        f.Vkn.ToLower().Contains(searchText) ||
                        f.TelNo.ToLower().Contains(searchText) ||
                        f.Adres.ToLower().Contains(searchText) ||
                        f.VergiDairesi.ToLower().Contains(searchText) ||
                        f.HizmetTuru.ToLower().Contains(searchText) ||
                        f.IbanBilgi.ToLower().Contains(searchText) ||
                        f.Aciklama.ToLower().Contains(searchText) ||
                        f.MalHizmetTutari.ToString().Contains(searchText) ||
                        f.ToplamIskonto.ToString().Contains(searchText) ||
                        f.HesaplananKdv.ToString().Contains(searchText) ||
                        f.VergilerDahilTutar.ToString().Contains(searchText) ||
                        f.NetTutar.ToString().Contains(searchText) ||
                        f.FaturaDurumu.ToLower().Contains(searchText) ||
                        (isDate && f.FaturaTarihi.Date == searchDate.Date) || // Tarih karşılaştırması
                        (isDate && f.FaturaGonderimTarihi.Date == searchDate.Date)  // Nullable tarih için kontrol
                    ).ToList();

                // DataGridView'e filtrelenmiş veriyi yükle
                KesilenFaturaTablo.DataSource = filteredData;
            }
        }
    }
}

