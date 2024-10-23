namespace YonetimBilgiSistemleri
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            pictureBox1 = new PictureBox();
            txtkullaniciadi = new TextBox();
            txtsifre = new TextBox();
            label2 = new Label();
            label3 = new Label();
            girisyap = new Button();
            cikisyap = new Button();
            checkBox1 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Black;
            pictureBox1.BackgroundImage = Properties.Resources.KILIÇLARLAZERSİYAHLOGO;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(-21, -5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(496, 457);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // txtkullaniciadi
            // 
            txtkullaniciadi.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtkullaniciadi.Location = new Point(485, 139);
            txtkullaniciadi.Name = "txtkullaniciadi";
            txtkullaniciadi.Size = new Size(196, 29);
            txtkullaniciadi.TabIndex = 1;
            // 
            // txtsifre
            // 
            txtsifre.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtsifre.Location = new Point(485, 233);
            txtsifre.Name = "txtsifre";
            txtsifre.PasswordChar = '*';
            txtsifre.Size = new Size(196, 29);
            txtsifre.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(462, 92);
            label2.Name = "label2";
            label2.Size = new Size(130, 25);
            label2.TabIndex = 2;
            label2.Text = "Kullanıcı Adı";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Black;
            label3.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(462, 193);
            label3.Name = "label3";
            label3.Size = new Size(56, 25);
            label3.TabIndex = 2;
            label3.Text = "Şifre";
            // 
            // girisyap
            // 
            girisyap.Cursor = Cursors.Hand;
            girisyap.FlatAppearance.BorderColor = Color.White;
            girisyap.FlatAppearance.BorderSize = 3;
            girisyap.FlatAppearance.MouseDownBackColor = Color.Gray;
            girisyap.FlatAppearance.MouseOverBackColor = Color.Gray;
            girisyap.FlatStyle = FlatStyle.Flat;
            girisyap.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            girisyap.ForeColor = Color.White;
            girisyap.Location = new Point(553, 343);
            girisyap.Name = "girisyap";
            girisyap.Size = new Size(128, 57);
            girisyap.TabIndex = 4;
            girisyap.Text = "GİRİŞ YAP";
            girisyap.UseVisualStyleBackColor = true;
            girisyap.Click += girisyap_Click;
            // 
            // cikisyap
            // 
            cikisyap.Cursor = Cursors.Hand;
            cikisyap.FlatAppearance.BorderColor = Color.White;
            cikisyap.FlatAppearance.BorderSize = 3;
            cikisyap.FlatAppearance.MouseDownBackColor = Color.Gray;
            cikisyap.FlatAppearance.MouseOverBackColor = Color.Gray;
            cikisyap.FlatStyle = FlatStyle.Flat;
            cikisyap.Font = new Font("Franklin Gothic Medium", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cikisyap.ForeColor = Color.White;
            cikisyap.Location = new Point(674, 12);
            cikisyap.Name = "cikisyap";
            cikisyap.Size = new Size(47, 44);
            cikisyap.TabIndex = 5;
            cikisyap.Text = "X";
            cikisyap.Click += cikisyap_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.FlatStyle = FlatStyle.Flat;
            checkBox1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            checkBox1.ForeColor = Color.White;
            checkBox1.Location = new Point(472, 290);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(120, 25);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Beni Hatırla";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImageLayout = ImageLayout.Stretch;
            CancelButton = cikisyap;
            ClientSize = new Size(733, 454);
            Controls.Add(checkBox1);
            Controls.Add(cikisyap);
            Controls.Add(girisyap);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtsifre);
            Controls.Add(txtkullaniciadi);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoginForm";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GİRİŞ YAP";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox txtkullaniciadi;
        private TextBox txtsifre;
        private Label label2;
        private Label label3;
        private Button girisyap;
        private Button cikisyap;
        private CheckBox checkBox1;
    }
}