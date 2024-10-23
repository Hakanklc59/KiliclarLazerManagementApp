
using System.Windows.Forms;

namespace YonetimBilgiSistemleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void CloseAllForms()
        {
            foreach (Form childForm in this.MdiChildren)
            {
                childForm.Close();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            this.BackColor = Color.Black; // Form arka planı siyah

            menuStrip1.BackColor = Color.DimGray; // MenuStrip arka planı siyah
            menuStrip1.ForeColor = Color.White; // MenuStrip yazı rengi beyaz
            foreach (Control ctl in this.Controls)
            {
                if (ctl is MdiClient)
                {
                    ctl.BackColor = Color.Black; // MDIClient arka planını siyah yap
                }
            }

        }
        private Form GetOpenForm(string formTypeName)
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form.GetType().Name == formTypeName)
                {
                    return form; // Eğer form açıksa onu döndür
                }
            }
            return null; // Eğer form açık değilse null döndür
        }
        // Formun açık olup olmadığını kontrol eden metod
        // Formları göstermek için genel bir metod
        private void ShowForm(Type formType)
        {
            // Eğer form açıksa onu ekrana getir
            Form openForm = GetOpenForm(formType.Name);
            if (openForm != null)
            {
                openForm.BringToFront();
                return;
            }

            // Formu aç
            Form formInstance = (Form)Activator.CreateInstance(formType);
            formInstance.MdiParent = this;
            formInstance.WindowState = FormWindowState.Maximized;
            formInstance.Show();
        }
        private void musteriEklemeToolStripMenuItem_Click(object sender, EventArgs e)
        {


            // Eğer form açıksa onu ekrana getir
            ShowForm(typeof(MusteriEkleme));
        }

        private void tedarikciEklemeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ShowForm(typeof(TedarikciOlustur));
        }

        private void siparisOlusturmaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ShowForm(typeof(SiparisOlusturma));

        }

        private void siparisVermeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(typeof(SiparisVerme));


        }

        private void kesilenFaturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(typeof(KesilenFaturaOlustur));

        }

        private void alinanFaturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(typeof(AlınanFaturaOlustur));

        }

        private void toolStripAgirlik_Click(object sender, EventArgs e)
        {
            ShowForm(typeof(ProfilFiyatHesaplama));
        }
    }
}