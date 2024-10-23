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
    public partial class TedarikciOlustur : Form
    {
        private Tedarikci selectedTedarikci; // Seçili müşteri için değişken
        public TedarikciOlustur()
        {
            InitializeComponent();
            TedarikciTablo.SelectionChanged += TedarikciTablo_SelectionChanged; // Olayı bağla
        }

        private void TedarikciEkle_Load(object sender, EventArgs e)
        {
            using (var context = new MyDbContext())
            {
                TedarikciTablo.DataSource = context.Tedarikciler.ToList();
            }
            // Başlık stili
            TedarikciTablo.EnableHeadersVisualStyles = false;
            TedarikciTablo.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 45, 48); // Daha yumuşak bir koyu renk
            TedarikciTablo.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            TedarikciTablo.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel); // Kalın (bold) font
            TedarikciTablo.ColumnHeadersHeight = 45; // Sütun başlık yüksekliği

            // Alternatif satır renkleri ve arka plan
            TedarikciTablo.RowsDefaultCellStyle.BackColor = Color.White;
            TedarikciTablo.RowsDefaultCellStyle.ForeColor = Color.Black;
            TedarikciTablo.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240); // Hafif gri ton

            // Satır kenar çizgileri için stil
            TedarikciTablo.CellBorderStyle = DataGridViewCellBorderStyle.None; // Hücre çizgilerini kaldırıyoruz

            // Satırlar arasındaki boşluk
            TedarikciTablo.RowTemplate.DividerHeight = 5; // Satırlar arasına boşluk ekliyoruz (arttırıldı)
            TedarikciTablo.RowTemplate.Height = 40; // Satır yüksekliği (biraz daha yüksek olabilir)

            // Satır başlıklarını görünür yaparak sol tarafa seçim işareti ekliyoruz
            TedarikciTablo.RowHeadersVisible = true; // Satır başlıkları görünüyor
            TedarikciTablo.RowHeadersWidth = 29; // Başlıklar için genişlik azaltıldı
            TedarikciTablo.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 45, 48); // Sol başlık arka plan rengi
            TedarikciTablo.RowHeadersDefaultCellStyle.ForeColor = Color.White; // Sol başlık metin rengi
            TedarikciTablo.RowHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(30, 30, 30); // Seçildiğinde başlık arka planı
                                                                                                       // DataGridView sütunlarının otomatik boyutlandırma ayarı
                                                                                                       // DataGridView'de hücrelerin sarılması
            TedarikciTablo.DefaultCellStyle.WrapMode = DataGridViewTriState.True; // Hücre içeriğini sar

            // DataGridView'deki satırların otomatik yüksekliğini ayarlama
            TedarikciTablo.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells; // Tüm hücreler için satır yüksekliğini ayarla


            // Seçilen hücreler için stil
            TedarikciTablo.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 120, 215); // Modern bir mavi ton
            TedarikciTablo.DefaultCellStyle.SelectionForeColor = Color.White;

            // DataGridView kenarlık stili (kenarlık renklerini ayarlıyoruz)
            TedarikciTablo.AdvancedColumnHeadersBorderStyle.All = DataGridViewAdvancedCellBorderStyle.Single; // Sütun başlık kenarlıkları
            TedarikciTablo.AdvancedCellBorderStyle.All = DataGridViewAdvancedCellBorderStyle.Single; // Hücreler arası kenarlık

            // Hücrelerin köşelerine ve gölgelerine benzer bir efekt için padding ekleyebiliriz
            TedarikciTablo.DefaultCellStyle.Padding = new Padding(5); // Hücrelerin içerisine padding ekleyerek ferah bir görünüm
            TedarikciTablo.AlternatingRowsDefaultCellStyle.Padding = new Padding(5);

            // DataGridView için çizgi renklerini belirleyebiliriz
            TedarikciTablo.GridColor = Color.LightGray; // Hücreler arası çizgi rengi

            // Arka plan rengini yumuşak bir renkle değiştirme
            TedarikciTablo.BackgroundColor = Color.WhiteSmoke; // Arka planı modern ve yumuşak bir renk

            // Satır başlıklarının kenarlık stilini kaldırabiliriz, böylece daha sade bir görünüm olur
            TedarikciTablo.AdvancedRowHeadersBorderStyle.All = DataGridViewAdvancedCellBorderStyle.None; // Satır başlık kenarlıkları kaldırıldı

            // İlk sütunun genişliğini azaltma
            TedarikciTablo.Columns[0].Width = 45; // İlk sütun genişliği azaltıldı
            TedarikciTablo.Columns["OlusturulmaTarihi"].DefaultCellStyle.Format = "dd.MM.yyyy"; // Sadece tarihi gösterecek

            TedarikciTablo.RowsDefaultCellStyle.SelectionForeColor = Color.White;
            TedarikciTablo.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(50, 90, 100);


        }

        private void Ekle_Click(object sender, EventArgs e)
        {
            // İNPUT KONTROLLERİ
            if (string.IsNullOrWhiteSpace(TedarikciAdiSoyadi.Text) ||
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
                    var yeniTedarikci = new Tedarikci
                    {
                        TedarikciAdSoyad = TedarikciAdiSoyadi.Text,
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

                    context.Tedarikciler.Add(yeniTedarikci);
                    context.SaveChanges();
                    TedarikciTablo.DataSource = context.Tedarikciler.ToList();
                    MessageBox.Show("Müşteri başarıyla eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Sil_Click(object sender, EventArgs e)
        {
            if (TedarikciTablo.SelectedRows.Count > 0)
            {
                // İlk seçili satırı al
                var selectedRow = TedarikciTablo.SelectedRows[0];
                int tedarikciId = Convert.ToInt32(selectedRow.Cells["TedarikciID"].Value);

                using (var context = new MyDbContext())
                {
                    var selectedTedarikci = context.Tedarikciler.FirstOrDefault(t => t.TedarikciID == tedarikciId);

                    if (selectedTedarikci != null)
                    {
                        DialogResult result = MessageBox.Show("Seçili müşteri silinsin mi?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            try
                            {
                                context.Tedarikciler.Remove(selectedTedarikci);
                                context.SaveChanges();

                                // Tabloyu güncelle
                                TedarikciTablo.DataSource = context.Tedarikciler.ToList();

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

        private void Guncelle_Click(object sender, EventArgs e)
        {
            if (TedarikciTablo.SelectedRows.Count > 0) // Seçili bir satır var mı kontrolü
            {
                DataGridViewRow selectedRow = TedarikciTablo.SelectedRows[0]; // Seçili satırı al
                int tedarikciId = Convert.ToInt32(selectedRow.Cells["TedarikciID"].Value); // ID'yi al

                using (var context = new MyDbContext())
                {
                    try
                    {
                        // Seçili müşteri kaydını bul
                        var selectedTedarikci = context.Tedarikciler.FirstOrDefault(t => t.TedarikciID == tedarikciId);
                        if (selectedTedarikci != null)
                        {
                            // Güncellenmek istenen alanların değerlerini ata
                            selectedTedarikci.TedarikciAdSoyad = TedarikciAdiSoyadi.Text;
                            selectedTedarikci.CariAd = CariAdi.Text;
                            selectedTedarikci.Telefon = TelefonNo.Text;
                            selectedTedarikci.Email = Eposta.Text;
                            selectedTedarikci.Adres = Adres.Text;
                            selectedTedarikci.IbanBilgisi = IbanBilgisi.Text;
                            selectedTedarikci.VergiNo = VergiNo.Text;
                            selectedTedarikci.VergiDairesi = VergiDairesi.Text;
                            selectedTedarikci.TcKimlikNo = TcNo.Text;

                            context.SaveChanges(); // Değişiklikleri kaydet

                            // Tabloyu güncelle
                            TedarikciTablo.DataSource = context.Tedarikciler.ToList(); // Tüm müşteri verilerini tekrar yükle

                            // Seçimi kaldır
                            TedarikciTablo.ClearSelection(); // Seçimi temizle

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
            if (TedarikciTablo.SelectedRows.Count > 0)
            {
                var selectedRow = TedarikciTablo.SelectedRows[0];
                var tedarikci = (Tedarikci)selectedRow.DataBoundItem;

                TedarikciAdiSoyadi.Text = tedarikci.TedarikciAdSoyad;
                CariAdi.Text = tedarikci.CariAd;
                TelefonNo.Text = tedarikci.Telefon;
                Eposta.Text = tedarikci.Email;
                Eposta.Text = tedarikci.Email;

                Adres.Text = tedarikci.Adres;
                IbanBilgisi.Text = tedarikci.IbanBilgisi;

                VergiNo.Text = tedarikci.VergiNo;
                VergiDairesi.Text = tedarikci.VergiDairesi;
                TcNo.Text = tedarikci.TcKimlikNo;


            }
            else
            {
                MessageBox.Show("Lütfen bir satır seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void TedarikciTablo_SelectionChanged(object sender, EventArgs e)
        {
            if (TedarikciTablo.SelectedRows.Count > 0)
            {
                var selectedRow = TedarikciTablo.SelectedRows[0];
                selectedTedarikci = (Tedarikci)selectedRow.DataBoundItem; // Seçilen müşteri
            }
            else
            {
                selectedTedarikci = null; // Hiçbir satır seçilmezse
            }
        }

        private void Git_Click(object sender, EventArgs e)
        {
            SiparisVerme siparisVermeForm = new SiparisVerme();
            siparisVermeForm.Show(); // Show() opens the form modelessly
        }

        private void cik_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            // Formu kapat
            this.Close();
        }

        private void txtGenelArama_TextChanged(object sender, EventArgs e)
        {
            using (var context = new MyDbContext())
            {
                // TextBox'tan aranan metni al
                string searchText = txtGenelArama.Text.ToLower();

                // Arama yapılacak sütunların her birine karşılık gelen değerleri arayalım
                var filteredData = context.Tedarikciler
                    .Where(f =>
                        f.Telefon.ToLower().Contains(searchText) ||
                        f.TedarikciAdSoyad.ToLower().Contains(searchText) ||
                         f.TedarikciID.ToString().Contains(searchText) ||
                        f.CariAd.ToLower().Contains(searchText) ||
                        f.TcKimlikNo.ToLower().Contains(searchText) ||
                        f.IbanBilgisi.ToLower().Contains(searchText) ||
                        f.Email.ToLower().Contains(searchText) ||
                       f.TedarikciAdSoyad.ToLower().Contains(searchText) ||
                        f.VergiDairesi.ToLower().Contains(searchText) ||
                        f.Adres.ToLower().Contains(searchText) ||
                        f.VergiNo.ToLower().Contains(searchText)
                    ).ToList();

                // DataGridView'e filtrelenmiş veriyi yükle
                TedarikciTablo.DataSource = filteredData;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
