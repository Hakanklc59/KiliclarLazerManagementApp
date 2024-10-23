namespace YonetimBilgiSistemleri
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            musteriEklemeToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            siparisOlusturmaToolStripMenuItem = new ToolStripMenuItem();
            siparisVermeToolStripMenuItem = new ToolStripMenuItem();
            kesilenFaturaToolStripMenuItem = new ToolStripMenuItem();
            alinanFaturaToolStripMenuItem = new ToolStripMenuItem();
            toolStripAgirlik = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.LightGray;
            menuStrip1.BackgroundImageLayout = ImageLayout.Stretch;
            menuStrip1.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            menuStrip1.Items.AddRange(new ToolStripItem[] { musteriEklemeToolStripMenuItem, toolStripMenuItem2, siparisOlusturmaToolStripMenuItem, siparisVermeToolStripMenuItem, kesilenFaturaToolStripMenuItem, alinanFaturaToolStripMenuItem, toolStripAgirlik });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(3, 5, 3, 3);
            menuStrip1.Size = new Size(1264, 44);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // musteriEklemeToolStripMenuItem
            // 
            musteriEklemeToolStripMenuItem.BackColor = Color.Black;
            musteriEklemeToolStripMenuItem.Checked = true;
            musteriEklemeToolStripMenuItem.CheckState = CheckState.Checked;
            musteriEklemeToolStripMenuItem.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold | FontStyle.Italic);
            musteriEklemeToolStripMenuItem.ForeColor = SystemColors.ButtonHighlight;
            musteriEklemeToolStripMenuItem.Margin = new Padding(4, 2, 2, 2);
            musteriEklemeToolStripMenuItem.Name = "musteriEklemeToolStripMenuItem";
            musteriEklemeToolStripMenuItem.Padding = new Padding(4);
            musteriEklemeToolStripMenuItem.ShowShortcutKeys = false;
            musteriEklemeToolStripMenuItem.Size = new Size(163, 32);
            musteriEklemeToolStripMenuItem.Text = "MÜŞTERİ OLUŞTUR";
            musteriEklemeToolStripMenuItem.Click += musteriEklemeToolStripMenuItem_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.BackColor = Color.Black;
            toolStripMenuItem2.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold | FontStyle.Italic);
            toolStripMenuItem2.ForeColor = SystemColors.ButtonHighlight;
            toolStripMenuItem2.Margin = new Padding(6, 2, 2, 2);
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Padding = new Padding(4);
            toolStripMenuItem2.Size = new Size(175, 32);
            toolStripMenuItem2.Text = "TEDARİKÇİ OLUŞTUR";
            toolStripMenuItem2.Click += tedarikciEklemeToolStripMenuItem_Click;
            // 
            // siparisOlusturmaToolStripMenuItem
            // 
            siparisOlusturmaToolStripMenuItem.BackColor = Color.Black;
            siparisOlusturmaToolStripMenuItem.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold | FontStyle.Italic);
            siparisOlusturmaToolStripMenuItem.ForeColor = SystemColors.ButtonHighlight;
            siparisOlusturmaToolStripMenuItem.Margin = new Padding(6, 2, 2, 2);
            siparisOlusturmaToolStripMenuItem.Name = "siparisOlusturmaToolStripMenuItem";
            siparisOlusturmaToolStripMenuItem.Padding = new Padding(4);
            siparisOlusturmaToolStripMenuItem.Size = new Size(133, 32);
            siparisOlusturmaToolStripMenuItem.Text = "SATIŞ SİPARİŞİ";
            siparisOlusturmaToolStripMenuItem.Click += siparisOlusturmaToolStripMenuItem_Click;
            // 
            // siparisVermeToolStripMenuItem
            // 
            siparisVermeToolStripMenuItem.BackColor = Color.Black;
            siparisVermeToolStripMenuItem.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold | FontStyle.Italic);
            siparisVermeToolStripMenuItem.ForeColor = SystemColors.ButtonHighlight;
            siparisVermeToolStripMenuItem.Margin = new Padding(6, 2, 2, 2);
            siparisVermeToolStripMenuItem.Name = "siparisVermeToolStripMenuItem";
            siparisVermeToolStripMenuItem.Padding = new Padding(4);
            siparisVermeToolStripMenuItem.Size = new Size(128, 32);
            siparisVermeToolStripMenuItem.Text = "ALIM SİPARİŞİ";
            siparisVermeToolStripMenuItem.Click += siparisVermeToolStripMenuItem_Click;
            // 
            // kesilenFaturaToolStripMenuItem
            // 
            kesilenFaturaToolStripMenuItem.BackColor = Color.Black;
            kesilenFaturaToolStripMenuItem.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold | FontStyle.Italic);
            kesilenFaturaToolStripMenuItem.ForeColor = SystemColors.ButtonHighlight;
            kesilenFaturaToolStripMenuItem.Margin = new Padding(6, 2, 2, 2);
            kesilenFaturaToolStripMenuItem.Name = "kesilenFaturaToolStripMenuItem";
            kesilenFaturaToolStripMenuItem.Padding = new Padding(4);
            kesilenFaturaToolStripMenuItem.Size = new Size(164, 32);
            kesilenFaturaToolStripMenuItem.Text = "SATIŞ FATURALARI";
            kesilenFaturaToolStripMenuItem.Click += kesilenFaturaToolStripMenuItem_Click;
            // 
            // alinanFaturaToolStripMenuItem
            // 
            alinanFaturaToolStripMenuItem.BackColor = Color.Black;
            alinanFaturaToolStripMenuItem.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold | FontStyle.Italic);
            alinanFaturaToolStripMenuItem.ForeColor = SystemColors.ButtonHighlight;
            alinanFaturaToolStripMenuItem.Margin = new Padding(6, 2, 2, 2);
            alinanFaturaToolStripMenuItem.Name = "alinanFaturaToolStripMenuItem";
            alinanFaturaToolStripMenuItem.Padding = new Padding(4);
            alinanFaturaToolStripMenuItem.Size = new Size(159, 32);
            alinanFaturaToolStripMenuItem.Text = "ALIM FATURALARI";
            alinanFaturaToolStripMenuItem.Click += alinanFaturaToolStripMenuItem_Click;
            // 
            // toolStripAgirlik
            // 
            toolStripAgirlik.Alignment = ToolStripItemAlignment.Right;
            toolStripAgirlik.BackColor = Color.Maroon;
            toolStripAgirlik.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            toolStripAgirlik.ForeColor = Color.White;
            toolStripAgirlik.Margin = new Padding(0, 0, 4, 0);
            toolStripAgirlik.Name = "toolStripAgirlik";
            toolStripAgirlik.Size = new Size(169, 36);
            toolStripAgirlik.Text = "FİYAT HESAPLA";
            toolStripAgirlik.Click += toolStripAgirlik_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1264, 661);
            Controls.Add(menuStrip1);
            DoubleBuffered = true;
            ForeColor = SystemColors.ActiveCaptionText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KILIÇLAR LAZER KESİM";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem musteriEklemeToolStripMenuItem;
        private ToolStripMenuItem siparisOlusturmaToolStripMenuItem;
        private ToolStripMenuItem siparisVermeToolStripMenuItem;
        private ToolStripMenuItem kesilenFaturaToolStripMenuItem;
        private ToolStripMenuItem alinanFaturaToolStripMenuItem;
        private ToolStripMenuItem toolStripAgirlik;
        private ToolStripMenuItem toolStripMenuItem2;
    }
}
