using System;
using System.Linq;
using System.Windows.Forms;

namespace YonetimBilgiSistemleri
{
    public partial class MusteriEkleme : Form
    {
        private Musteri selectedMusteri; // Seçili müşteri için değişken

        public MusteriEkleme()
        {
            InitializeComponent();
            MusterilerTablo.SelectionChanged += MusterilerTablo_SelectionChanged; // Olayı bağla

        }

        private void MusteriEkleme_Load(object sender, EventArgs e)
        {
            using (var context = new MyDbContext())
            {
                MusterilerTablo.DataSource = context.Musteriler.ToList();
            }
            // Başlık stili
            MusterilerTablo.EnableHeadersVisualStyles = false;
            MusterilerTablo.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 45, 48); // Daha yumuşak bir koyu renk
            MusterilerTablo.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            MusterilerTablo.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel); // Kalın (bold) font
            MusterilerTablo.ColumnHeadersHeight = 45; // Sütun başlık yüksekliği

            // Alternatif satır renkleri ve arka plan
            MusterilerTablo.RowsDefaultCellStyle.BackColor = Color.White;
            MusterilerTablo.RowsDefaultCellStyle.ForeColor = Color.Black;
            MusterilerTablo.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240); // Hafif gri ton

            // Satır kenar çizgileri için stil
            MusterilerTablo.CellBorderStyle = DataGridViewCellBorderStyle.None; // Hücre çizgilerini kaldırıyoruz

            // Satırlar arasındaki boşluk
            MusterilerTablo.RowTemplate.DividerHeight = 5; // Satırlar arasına boşluk ekliyoruz (arttırıldı)
            MusterilerTablo.RowTemplate.Height = 40; // Satır yüksekliği (biraz daha yüksek olabilir)

            // Satır başlıklarını görünür yaparak sol tarafa seçim işareti ekliyoruz
            MusterilerTablo.RowHeadersVisible = true; // Satır başlıkları görünüyor
            MusterilerTablo.RowHeadersWidth = 29; // Başlıklar için genişlik azaltıldı
            MusterilerTablo.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 45, 48); // Sol başlık arka plan rengi
            MusterilerTablo.RowHeadersDefaultCellStyle.ForeColor = Color.White; // Sol başlık metin rengi
            MusterilerTablo.RowHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(30, 30, 30); // Seçildiğinde başlık arka planı
                                                                                                        // DataGridView sütunlarının otomatik boyutlandırma ayarı
                                                                                                        // DataGridView'de hücrelerin sarılması
            MusterilerTablo.DefaultCellStyle.WrapMode = DataGridViewTriState.True; // Hücre içeriğini sar

            // DataGridView'deki satırların otomatik yüksekliğini ayarlama
            MusterilerTablo.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells; // Tüm hücreler için satır yüksekliğini ayarla


            // Seçilen hücreler için stil
            MusterilerTablo.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 120, 215); // Modern bir mavi ton
            MusterilerTablo.DefaultCellStyle.SelectionForeColor = Color.White;

            // DataGridView kenarlık stili (kenarlık renklerini ayarlıyoruz)
            MusterilerTablo.AdvancedColumnHeadersBorderStyle.All = DataGridViewAdvancedCellBorderStyle.Single; // Sütun başlık kenarlıkları
            MusterilerTablo.AdvancedCellBorderStyle.All = DataGridViewAdvancedCellBorderStyle.Single; // Hücreler arası kenarlık

            // Hücrelerin köşelerine ve gölgelerine benzer bir efekt için padding ekleyebiliriz
            MusterilerTablo.DefaultCellStyle.Padding = new Padding(5); // Hücrelerin içerisine padding ekleyerek ferah bir görünüm
            MusterilerTablo.AlternatingRowsDefaultCellStyle.Padding = new Padding(5);

            // DataGridView için çizgi renklerini belirleyebiliriz
            MusterilerTablo.GridColor = Color.LightGray; // Hücreler arası çizgi rengi

            // Arka plan rengini yumuşak bir renkle değiştirme
            MusterilerTablo.BackgroundColor = Color.WhiteSmoke; // Arka planı modern ve yumuşak bir renk

            // Satır başlıklarının kenarlık stilini kaldırabiliriz, böylece daha sade bir görünüm olur
            MusterilerTablo.AdvancedRowHeadersBorderStyle.All = DataGridViewAdvancedCellBorderStyle.None; // Satır başlık kenarlıkları kaldırıldı

            // İlk sütunun genişliğini azaltma
            MusterilerTablo.Columns[0].Width = 45; // İlk sütun genişliği azaltıldı
            MusterilerTablo.Columns["OlusturulmaTarihi"].DefaultCellStyle.Format = "dd.MM.yyyy"; // Sadece tarihi gösterecek

            MusterilerTablo.RowsDefaultCellStyle.SelectionForeColor = Color.White;
            MusterilerTablo.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(50, 90, 100);



        }

        private void MusteriEkle_Click(object sender, EventArgs e)
        {
            // İNPUT KONTROLLERİ
            if (string.IsNullOrWhiteSpace(MusteriAdiSoyadi.Text) ||
                string.IsNullOrWhiteSpace(CariAdi.Text) ||
                string.IsNullOrWhiteSpace(Eposta.Text) ||
                string.IsNullOrWhiteSpace(Adres.Text) ||
                string.IsNullOrWhiteSpace(VergiNo.Text) ||
                string.IsNullOrWhiteSpace(VergiDairesi.Text) ||
                string.IsNullOrWhiteSpace(TcNo.Text) ||
                string.IsNullOrWhiteSpace(TelefonNo.Text)
                )

            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var context = new MyDbContext())
            {
                try
                {
                    var yeniMusteri = new Musteri
                    {
                        MusteriAdSoyad = MusteriAdiSoyadi.Text,
                        CariAd = CariAdi.Text,
                        Telefon = TelefonNo.Text,
                        Email = Eposta.Text,
                        Adres = Adres.Text,
                        IbanBilgisi = IbanBilgisi.Text,
                        VergiNo = VergiNo.Text,
                        VergiDairesi = VergiDairesi.Text,
                        TcKimlikNo = TcNo.Text,
                        OlusturulmaTarihi = DateTime.Now

                    };

                    context.Musteriler.Add(yeniMusteri);
                    context.SaveChanges();
                    MusterilerTablo.DataSource = context.Musteriler.ToList();
                    MessageBox.Show("Müşteri başarıyla eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }




        private void MusteriSil_Click(object sender, EventArgs e)
        {
            if (MusterilerTablo.SelectedRows.Count > 0)
            {
                // İlk seçili satırı al
                var selectedRow = MusterilerTablo.SelectedRows[0];
                int musteriId = Convert.ToInt32(selectedRow.Cells["MusteriID"].Value);

                using (var context = new MyDbContext())
                {
                    var selectedMusteri = context.Musteriler.FirstOrDefault(m => m.MusteriId == musteriId);

                    if (selectedMusteri != null)
                    {
                        DialogResult result = MessageBox.Show("Seçili müşteri silinsin mi?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            try
                            {
                                context.Musteriler.Remove(selectedMusteri);
                                context.SaveChanges();

                                // Tabloyu güncelle
                                MusterilerTablo.DataSource = context.Musteriler.ToList();

                                MessageBox.Show("Müşteri silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Bir hata oluştu: " + ex.Message + "\n" + ex.InnerException?.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Silmek için bir müşteri seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("Silmek için bir müşteri seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void MusteriGuncelle_Click(object sender, EventArgs e)
        {
            if (MusterilerTablo.SelectedRows.Count > 0) // Seçili bir satır var mı kontrolü
            {
                DataGridViewRow selectedRow = MusterilerTablo.SelectedRows[0]; // Seçili satırı al
                int musteriId = Convert.ToInt32(selectedRow.Cells["MusteriID"].Value); // ID'yi al

                using (var context = new MyDbContext())
                {
                    try
                    {
                        // Seçili müşteri kaydını bul
                        var selectedMusteri = context.Musteriler.FirstOrDefault(m => m.MusteriId == musteriId);
                        if (selectedMusteri != null)
                        {
                            // Güncellenmek istenen alanların değerlerini ata
                            selectedMusteri.MusteriAdSoyad = MusteriAdiSoyadi.Text;
                            selectedMusteri.CariAd = CariAdi.Text;
                            selectedMusteri.Telefon = TelefonNo.Text;
                            selectedMusteri.Email = Eposta.Text;
                            selectedMusteri.Adres = Adres.Text;
                            selectedMusteri.IbanBilgisi = IbanBilgisi.Text;

                            selectedMusteri.VergiNo = VergiNo.Text;
                            selectedMusteri.VergiDairesi = VergiDairesi.Text;
                            selectedMusteri.TcKimlikNo = TcNo.Text;

                            context.SaveChanges(); // Değişiklikleri kaydet

                            // Tabloyu güncelle
                            MusterilerTablo.DataSource = context.Musteriler.ToList(); // Tüm müşteri verilerini tekrar yükle

                            // Seçimi kaldır
                            MusterilerTablo.ClearSelection(); // Seçimi temizle

                            MessageBox.Show("Müşteri başarıyla güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Güncellenecek müşteri bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Güncellemek için bir müşteri seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        private void SatirGetir_Click(object sender, EventArgs e)
        {
            if (MusterilerTablo.SelectedRows.Count > 0)
            {
                var selectedRow = MusterilerTablo.SelectedRows[0];
                var musteri = (Musteri)selectedRow.DataBoundItem;

                MusteriAdiSoyadi.Text = musteri.MusteriAdSoyad;
                CariAdi.Text = musteri.CariAd;
                TelefonNo.Text = musteri.Telefon;
                Eposta.Text = musteri.Email;
                Adres.Text = musteri.Adres;
                IbanBilgisi.Text = musteri.IbanBilgisi;
                VergiNo.Text = musteri.VergiNo;
                VergiDairesi.Text = musteri.VergiDairesi;
                TcNo.Text = musteri.TcKimlikNo;


            }
            else
            {
                MessageBox.Show("Lütfen bir satır seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void MusterilerTablo_SelectionChanged(object sender, EventArgs e)
        {

            if (MusterilerTablo.SelectedRows.Count > 0)
            {
                var selectedRow = MusterilerTablo.SelectedRows[0];
                selectedMusteri = (Musteri)selectedRow.DataBoundItem; // Seçilen müşteri
            }
            else
            {
                selectedMusteri = null; // Hiçbir satır seçilmezse
            }
        }
        private void Git_Click(object sender, EventArgs e)
        {
            SiparisOlusturma siparisOlusturmaForm = new SiparisOlusturma();
            siparisOlusturmaForm.Show(); // Show() opens the form modelessly
        }

        private void cik_Click(object sender, EventArgs e)
        {


            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void txtGenelArama_TextChanged(object sender, EventArgs e)
        {
            using (var context = new MyDbContext())
            {
                // TextBox'tan aranan metni al
                string searchText = txtGenelArama.Text.ToLower();

                // Arama yapılacak sütunların her birine karşılık gelen değerleri arayalım
                var filteredData = context.Musteriler
                    .Where(f =>
                        f.Telefon.ToLower().Contains(searchText) ||
                        f.MusteriAdSoyad.ToLower().Contains(searchText) ||
                        f.CariAd.ToLower().Contains(searchText) ||
                        f.TcKimlikNo.ToLower().Contains(searchText) ||
                        f.IbanBilgisi.ToLower().Contains(searchText) ||
                        f.Email.ToLower().Contains(searchText) ||
                       f.MusteriId.ToString().Contains(searchText) ||
                        f.VergiDairesi.ToLower().Contains(searchText) ||
                        f.Adres.ToLower().Contains(searchText) ||
                        f.VergiNo.ToLower().Contains(searchText) 
                    ).ToList();

                // DataGridView'e filtrelenmiş veriyi yükle
                MusterilerTablo.DataSource = filteredData;
            }
        }
    }
    
}
