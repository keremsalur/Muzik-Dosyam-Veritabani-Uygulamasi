
namespace Prolab2_Proje3
{
    partial class FormAdmin
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelLogin = new System.Windows.Forms.Label();
            this.buttonLoginExit = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.textBoxLoginAdminSifre = new System.Windows.Forms.TextBox();
            this.textBoxLoginAdminKullaniciAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.labelAdminDogrulama = new System.Windows.Forms.Label();
            this.checkBoxUyeAdminEkran = new System.Windows.Forms.CheckBox();
            this.panelAdminUyeGiris = new System.Windows.Forms.Panel();
            this.panelAdminKayitOl = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxAdminUyeOlKullaniciAdi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxAdminUyeOlSifre = new System.Windows.Forms.TextBox();
            this.buttonAdminKayitOl = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            this.panelAdminUyeGiris.SuspendLayout();
            this.panelAdminKayitOl.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.labelLogin);
            this.panelTop.Controls.Add(this.buttonLoginExit);
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(300, 50);
            this.panelTop.TabIndex = 0;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
            this.panelTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseMove);
            this.panelTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseUp);
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Segoe Print", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelLogin.Location = new System.Drawing.Point(12, 7);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(147, 33);
            this.labelLogin.TabIndex = 2;
            this.labelLogin.Text = "Yönetici Girişi";
            // 
            // buttonLoginExit
            // 
            this.buttonLoginExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(17)))), ((int)(((byte)(28)))));
            this.buttonLoginExit.BackgroundImage = global::Prolab2_Proje3.Properties.Resources.xa;
            this.buttonLoginExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonLoginExit.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonLoginExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(17)))), ((int)(((byte)(28)))));
            this.buttonLoginExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(17)))), ((int)(((byte)(28)))));
            this.buttonLoginExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(17)))), ((int)(((byte)(28)))));
            this.buttonLoginExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoginExit.Location = new System.Drawing.Point(257, 9);
            this.buttonLoginExit.Name = "buttonLoginExit";
            this.buttonLoginExit.Size = new System.Drawing.Size(31, 33);
            this.buttonLoginExit.TabIndex = 1;
            this.buttonLoginExit.TabStop = false;
            this.buttonLoginExit.UseVisualStyleBackColor = true;
            this.buttonLoginExit.Click += new System.EventHandler(this.buttonLoginExit_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackgroundImage = global::Prolab2_Proje3.Properties.Resources.loginIcon;
            this.buttonLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(17)))), ((int)(((byte)(28)))));
            this.buttonLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(17)))), ((int)(((byte)(28)))));
            this.buttonLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(17)))), ((int)(((byte)(28)))));
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Location = new System.Drawing.Point(85, 65);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(40, 40);
            this.buttonLogin.TabIndex = 12;
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // textBoxLoginAdminSifre
            // 
            this.textBoxLoginAdminSifre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(17)))), ((int)(((byte)(28)))));
            this.textBoxLoginAdminSifre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLoginAdminSifre.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxLoginAdminSifre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(77)))));
            this.textBoxLoginAdminSifre.Location = new System.Drawing.Point(122, 33);
            this.textBoxLoginAdminSifre.Name = "textBoxLoginAdminSifre";
            this.textBoxLoginAdminSifre.PasswordChar = '*';
            this.textBoxLoginAdminSifre.PlaceholderText = "Giriniz";
            this.textBoxLoginAdminSifre.Size = new System.Drawing.Size(100, 24);
            this.textBoxLoginAdminSifre.TabIndex = 11;
            this.textBoxLoginAdminSifre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxLoginAdminKullaniciAdi
            // 
            this.textBoxLoginAdminKullaniciAdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(17)))), ((int)(((byte)(28)))));
            this.textBoxLoginAdminKullaniciAdi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLoginAdminKullaniciAdi.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxLoginAdminKullaniciAdi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(77)))));
            this.textBoxLoginAdminKullaniciAdi.Location = new System.Drawing.Point(118, 8);
            this.textBoxLoginAdminKullaniciAdi.Name = "textBoxLoginAdminKullaniciAdi";
            this.textBoxLoginAdminKullaniciAdi.PlaceholderText = "Giriniz";
            this.textBoxLoginAdminKullaniciAdi.Size = new System.Drawing.Size(100, 24);
            this.textBoxLoginAdminKullaniciAdi.TabIndex = 10;
            this.textBoxLoginAdminKullaniciAdi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(63, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 28);
            this.label2.TabIndex = 9;
            this.label2.Text = "Şifre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 28);
            this.label1.TabIndex = 8;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // panelLogo
            // 
            this.panelLogo.BackgroundImage = global::Prolab2_Proje3.Properties.Resources.adminLoginLogo1;
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelLogo.Location = new System.Drawing.Point(115, 70);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(70, 70);
            this.panelLogo.TabIndex = 13;
            // 
            // labelAdminDogrulama
            // 
            this.labelAdminDogrulama.AutoSize = true;
            this.labelAdminDogrulama.Font = new System.Drawing.Font("Segoe Print", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAdminDogrulama.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.labelAdminDogrulama.Location = new System.Drawing.Point(53, 272);
            this.labelAdminDogrulama.Name = "labelAdminDogrulama";
            this.labelAdminDogrulama.Size = new System.Drawing.Size(194, 19);
            this.labelAdminDogrulama.TabIndex = 14;
            this.labelAdminDogrulama.Text = "Kullanıcı Adı Ve/Veya Şifre Yanlış";
            this.labelAdminDogrulama.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelAdminDogrulama.Visible = false;
            // 
            // checkBoxUyeAdminEkran
            // 
            this.checkBoxUyeAdminEkran.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxUyeAdminEkran.AutoSize = true;
            this.checkBoxUyeAdminEkran.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(77)))));
            this.checkBoxUyeAdminEkran.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(77)))));
            this.checkBoxUyeAdminEkran.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(17)))), ((int)(((byte)(28)))));
            this.checkBoxUyeAdminEkran.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxUyeAdminEkran.Font = new System.Drawing.Font("Segoe Print", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxUyeAdminEkran.Location = new System.Drawing.Point(12, 56);
            this.checkBoxUyeAdminEkran.Name = "checkBoxUyeAdminEkran";
            this.checkBoxUyeAdminEkran.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBoxUyeAdminEkran.Size = new System.Drawing.Size(69, 29);
            this.checkBoxUyeAdminEkran.TabIndex = 15;
            this.checkBoxUyeAdminEkran.Text = "Giriş Yap";
            this.checkBoxUyeAdminEkran.UseVisualStyleBackColor = true;
            this.checkBoxUyeAdminEkran.CheckedChanged += new System.EventHandler(this.checkBoxUyeAdminEkran_CheckedChanged);
            // 
            // panelAdminUyeGiris
            // 
            this.panelAdminUyeGiris.Controls.Add(this.label1);
            this.panelAdminUyeGiris.Controls.Add(this.textBoxLoginAdminKullaniciAdi);
            this.panelAdminUyeGiris.Controls.Add(this.label2);
            this.panelAdminUyeGiris.Controls.Add(this.textBoxLoginAdminSifre);
            this.panelAdminUyeGiris.Controls.Add(this.buttonLogin);
            this.panelAdminUyeGiris.Location = new System.Drawing.Point(45, 150);
            this.panelAdminUyeGiris.Name = "panelAdminUyeGiris";
            this.panelAdminUyeGiris.Size = new System.Drawing.Size(210, 110);
            this.panelAdminUyeGiris.TabIndex = 16;
            this.panelAdminUyeGiris.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panelAdminKayitOl
            // 
            this.panelAdminKayitOl.Controls.Add(this.label3);
            this.panelAdminKayitOl.Controls.Add(this.textBoxAdminUyeOlKullaniciAdi);
            this.panelAdminKayitOl.Controls.Add(this.label4);
            this.panelAdminKayitOl.Controls.Add(this.textBoxAdminUyeOlSifre);
            this.panelAdminKayitOl.Controls.Add(this.buttonAdminKayitOl);
            this.panelAdminKayitOl.Location = new System.Drawing.Point(45, 150);
            this.panelAdminKayitOl.Name = "panelAdminKayitOl";
            this.panelAdminKayitOl.Size = new System.Drawing.Size(210, 110);
            this.panelAdminKayitOl.TabIndex = 17;
            this.panelAdminKayitOl.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(0, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 28);
            this.label3.TabIndex = 8;
            this.label3.Text = "Kullanıcı Adı";
            // 
            // textBoxAdminUyeOlKullaniciAdi
            // 
            this.textBoxAdminUyeOlKullaniciAdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(17)))), ((int)(((byte)(28)))));
            this.textBoxAdminUyeOlKullaniciAdi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAdminUyeOlKullaniciAdi.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxAdminUyeOlKullaniciAdi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(77)))));
            this.textBoxAdminUyeOlKullaniciAdi.Location = new System.Drawing.Point(118, 8);
            this.textBoxAdminUyeOlKullaniciAdi.Name = "textBoxAdminUyeOlKullaniciAdi";
            this.textBoxAdminUyeOlKullaniciAdi.PlaceholderText = "Giriniz";
            this.textBoxAdminUyeOlKullaniciAdi.Size = new System.Drawing.Size(100, 24);
            this.textBoxAdminUyeOlKullaniciAdi.TabIndex = 10;
            this.textBoxAdminUyeOlKullaniciAdi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(63, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 28);
            this.label4.TabIndex = 9;
            this.label4.Text = "Şifre";
            // 
            // textBoxAdminUyeOlSifre
            // 
            this.textBoxAdminUyeOlSifre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(17)))), ((int)(((byte)(28)))));
            this.textBoxAdminUyeOlSifre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAdminUyeOlSifre.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxAdminUyeOlSifre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(77)))));
            this.textBoxAdminUyeOlSifre.Location = new System.Drawing.Point(122, 33);
            this.textBoxAdminUyeOlSifre.Name = "textBoxAdminUyeOlSifre";
            this.textBoxAdminUyeOlSifre.PasswordChar = '*';
            this.textBoxAdminUyeOlSifre.PlaceholderText = "Giriniz";
            this.textBoxAdminUyeOlSifre.Size = new System.Drawing.Size(100, 24);
            this.textBoxAdminUyeOlSifre.TabIndex = 11;
            this.textBoxAdminUyeOlSifre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonAdminKayitOl
            // 
            this.buttonAdminKayitOl.BackgroundImage = global::Prolab2_Proje3.Properties.Resources.kayitOl;
            this.buttonAdminKayitOl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonAdminKayitOl.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(17)))), ((int)(((byte)(28)))));
            this.buttonAdminKayitOl.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(17)))), ((int)(((byte)(28)))));
            this.buttonAdminKayitOl.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(17)))), ((int)(((byte)(28)))));
            this.buttonAdminKayitOl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdminKayitOl.Location = new System.Drawing.Point(85, 65);
            this.buttonAdminKayitOl.Name = "buttonAdminKayitOl";
            this.buttonAdminKayitOl.Size = new System.Drawing.Size(40, 40);
            this.buttonAdminKayitOl.TabIndex = 12;
            this.buttonAdminKayitOl.UseVisualStyleBackColor = true;
            this.buttonAdminKayitOl.Click += new System.EventHandler(this.buttonAdminKayitOl_Click);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(17)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.checkBoxUyeAdminEkran);
            this.Controls.Add(this.labelAdminDogrulama);
            this.Controls.Add(this.panelLogo);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelAdminUyeGiris);
            this.Controls.Add(this.panelAdminKayitOl);
            this.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(77)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(300, 300);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "FormAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAdmin";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelAdminUyeGiris.ResumeLayout(false);
            this.panelAdminUyeGiris.PerformLayout();
            this.panelAdminKayitOl.ResumeLayout(false);
            this.panelAdminKayitOl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button buttonLoginExit;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TextBox textBoxLoginAdminSifre;
        private System.Windows.Forms.TextBox textBoxLoginAdminKullaniciAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label labelAdminDogrulama;
        private System.Windows.Forms.CheckBox checkBoxUyeAdminEkran;
        private System.Windows.Forms.Panel panelAdminUyeGiris;
        private System.Windows.Forms.Panel panelAdminKayitOl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxAdminUyeOlKullaniciAdi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxAdminUyeOlSifre;
        private System.Windows.Forms.Button buttonAdminKayitOl;
    }
}