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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void girisyap_Click(object sender, EventArgs e)
        {
            // Kullanıcı adı ve şifre kontrolü
            string kullaniciAdi = "kiliclarlazer";
            string sifre = "123";

            // Kullanıcı girişi ile formdaki TextBox'lardan alınan bilgiler
            string girilenKullaniciAdi = txtkullaniciadi.Text; // Kullanıcı adı TextBox'ı
            string girilenSifre = txtsifre.Text; // Şifre TextBox'ı

            // Kullanıcı adı ve şifre doğruysa
            if (girilenKullaniciAdi == kullaniciAdi && girilenSifre == sifre)
            {
                // Form1 adlı yeni formu aç
                Form1 anaForm = new Form1();
                anaForm.Show();

                // Giriş formunu kapat
                this.Hide(); // `this.Close()` yerine `this.Hide()` kullanarak LoginForm'un kapanmasını önleyebilirsin, program tamamen kapanmaz.
            }
            else
            {
                // Hata mesajı göster
                MessageBox.Show("Kullanıcı adı veya şifre hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cikisyap_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
