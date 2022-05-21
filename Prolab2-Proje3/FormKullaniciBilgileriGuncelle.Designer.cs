
namespace Prolab2_Proje3
{
    partial class FormKullaniciBilgileriGuncelle
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
            this.labelKullaniciGuncelle = new System.Windows.Forms.Label();
            this.buttonSarkiEkleExit = new System.Windows.Forms.Button();
            this.panelUyeOl = new System.Windows.Forms.Panel();
            this.checkBoxVIP = new System.Windows.Forms.CheckBox();
            this.comboBoxUlke = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxGuncelleEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonGuncelle = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxGuncelleSifre = new System.Windows.Forms.TextBox();
            this.textBoxGuncelleKullaniciAdi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.labelDogrulama = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            this.panelUyeOl.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.labelKullaniciGuncelle);
            this.panelTop.Controls.Add(this.buttonSarkiEkleExit);
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(300, 50);
            this.panelTop.TabIndex = 3;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
            this.panelTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseMove);
            this.panelTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseUp);
            // 
            // labelKullaniciGuncelle
            // 
            this.labelKullaniciGuncelle.AutoSize = true;
            this.labelKullaniciGuncelle.Font = new System.Drawing.Font("Segoe Print", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelKullaniciGuncelle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(77)))));
            this.labelKullaniciGuncelle.Location = new System.Drawing.Point(12, 7);
            this.labelKullaniciGuncelle.Name = "labelKullaniciGuncelle";
            this.labelKullaniciGuncelle.Size = new System.Drawing.Size(212, 33);
            this.labelKullaniciGuncelle.TabIndex = 2;
            this.labelKullaniciGuncelle.Text = "Kullanıcı Güncelleme";
            // 
            // buttonSarkiEkleExit
            // 
            this.buttonSarkiEkleExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.buttonSarkiEkleExit.BackgroundImage = global::Prolab2_Proje3.Properties.Resources.xa;
            this.buttonSarkiEkleExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonSarkiEkleExit.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonSarkiEkleExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.buttonSarkiEkleExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.buttonSarkiEkleExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.buttonSarkiEkleExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSarkiEkleExit.Location = new System.Drawing.Point(257, 9);
            this.buttonSarkiEkleExit.Name = "buttonSarkiEkleExit";
            this.buttonSarkiEkleExit.Size = new System.Drawing.Size(31, 33);
            this.buttonSarkiEkleExit.TabIndex = 1;
            this.buttonSarkiEkleExit.TabStop = false;
            this.buttonSarkiEkleExit.UseVisualStyleBackColor = false;
            this.buttonSarkiEkleExit.Click += new System.EventHandler(this.buttonSarkiEkleExit_Click);
            // 
            // panelUyeOl
            // 
            this.panelUyeOl.Controls.Add(this.checkBoxVIP);
            this.panelUyeOl.Controls.Add(this.comboBoxUlke);
            this.panelUyeOl.Controls.Add(this.label7);
            this.panelUyeOl.Controls.Add(this.textBoxGuncelleEmail);
            this.panelUyeOl.Controls.Add(this.label4);
            this.panelUyeOl.Controls.Add(this.buttonGuncelle);
            this.panelUyeOl.Controls.Add(this.label5);
            this.panelUyeOl.Controls.Add(this.textBoxGuncelleSifre);
            this.panelUyeOl.Controls.Add(this.textBoxGuncelleKullaniciAdi);
            this.panelUyeOl.Controls.Add(this.label6);
            this.panelUyeOl.Location = new System.Drawing.Point(45, 50);
            this.panelUyeOl.Name = "panelUyeOl";
            this.panelUyeOl.Size = new System.Drawing.Size(210, 200);
            this.panelUyeOl.TabIndex = 15;
            // 
            // checkBoxVIP
            // 
            this.checkBoxVIP.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxVIP.AutoSize = true;
            this.checkBoxVIP.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(77)))));
            this.checkBoxVIP.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(17)))), ((int)(((byte)(28)))));
            this.checkBoxVIP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(17)))), ((int)(((byte)(28)))));
            this.checkBoxVIP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxVIP.Font = new System.Drawing.Font("Segoe Print", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxVIP.Location = new System.Drawing.Point(23, 121);
            this.checkBoxVIP.Name = "checkBoxVIP";
            this.checkBoxVIP.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBoxVIP.Size = new System.Drawing.Size(38, 29);
            this.checkBoxVIP.TabIndex = 8;
            this.checkBoxVIP.Text = "VIP";
            this.checkBoxVIP.UseVisualStyleBackColor = true;
            // 
            // comboBoxUlke
            // 
            this.comboBoxUlke.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.comboBoxUlke.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUlke.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxUlke.Font = new System.Drawing.Font("Segoe Print", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxUlke.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(77)))));
            this.comboBoxUlke.FormattingEnabled = true;
            this.comboBoxUlke.Location = new System.Drawing.Point(74, 123);
            this.comboBoxUlke.MaxDropDownItems = 5;
            this.comboBoxUlke.Name = "comboBoxUlke";
            this.comboBoxUlke.Size = new System.Drawing.Size(121, 27);
            this.comboBoxUlke.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 28);
            this.label7.TabIndex = 13;
            this.label7.Text = "E-mail";
            // 
            // textBoxGuncelleEmail
            // 
            this.textBoxGuncelleEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.textBoxGuncelleEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxGuncelleEmail.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxGuncelleEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(77)))));
            this.textBoxGuncelleEmail.Location = new System.Drawing.Point(122, 95);
            this.textBoxGuncelleEmail.Name = "textBoxGuncelleEmail";
            this.textBoxGuncelleEmail.PlaceholderText = "Giriniz";
            this.textBoxGuncelleEmail.Size = new System.Drawing.Size(88, 24);
            this.textBoxGuncelleEmail.TabIndex = 7;
            this.textBoxGuncelleEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(29, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 28);
            this.label4.TabIndex = 12;
            this.label4.Text = "Kullanıcı Bilgileri";
            // 
            // buttonGuncelle
            // 
            this.buttonGuncelle.BackgroundImage = global::Prolab2_Proje3.Properties.Resources.kayitOl;
            this.buttonGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonGuncelle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(17)))), ((int)(((byte)(28)))));
            this.buttonGuncelle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(17)))), ((int)(((byte)(28)))));
            this.buttonGuncelle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(17)))), ((int)(((byte)(28)))));
            this.buttonGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGuncelle.Location = new System.Drawing.Point(85, 159);
            this.buttonGuncelle.Name = "buttonGuncelle";
            this.buttonGuncelle.Size = new System.Drawing.Size(40, 40);
            this.buttonGuncelle.TabIndex = 10;
            this.buttonGuncelle.UseVisualStyleBackColor = true;
            this.buttonGuncelle.Click += new System.EventHandler(this.buttonGuncelle_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 28);
            this.label5.TabIndex = 4;
            this.label5.Text = "Şifre";
            // 
            // textBoxGuncelleSifre
            // 
            this.textBoxGuncelleSifre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.textBoxGuncelleSifre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxGuncelleSifre.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxGuncelleSifre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(77)))));
            this.textBoxGuncelleSifre.Location = new System.Drawing.Point(122, 67);
            this.textBoxGuncelleSifre.Name = "textBoxGuncelleSifre";
            this.textBoxGuncelleSifre.PasswordChar = '*';
            this.textBoxGuncelleSifre.PlaceholderText = "Giriniz";
            this.textBoxGuncelleSifre.Size = new System.Drawing.Size(88, 24);
            this.textBoxGuncelleSifre.TabIndex = 6;
            this.textBoxGuncelleSifre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxGuncelleKullaniciAdi
            // 
            this.textBoxGuncelleKullaniciAdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.textBoxGuncelleKullaniciAdi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxGuncelleKullaniciAdi.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxGuncelleKullaniciAdi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(77)))));
            this.textBoxGuncelleKullaniciAdi.Location = new System.Drawing.Point(122, 37);
            this.textBoxGuncelleKullaniciAdi.Name = "textBoxGuncelleKullaniciAdi";
            this.textBoxGuncelleKullaniciAdi.PlaceholderText = "Giriniz";
            this.textBoxGuncelleKullaniciAdi.Size = new System.Drawing.Size(88, 24);
            this.textBoxGuncelleKullaniciAdi.TabIndex = 5;
            this.textBoxGuncelleKullaniciAdi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 28);
            this.label6.TabIndex = 3;
            this.label6.Text = "Kullanıcı Adı";
            // 
            // labelDogrulama
            // 
            this.labelDogrulama.AutoSize = true;
            this.labelDogrulama.Font = new System.Drawing.Font("Segoe Print", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDogrulama.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(77)))));
            this.labelDogrulama.Location = new System.Drawing.Point(46, 272);
            this.labelDogrulama.Name = "labelDogrulama";
            this.labelDogrulama.Size = new System.Drawing.Size(194, 19);
            this.labelDogrulama.TabIndex = 16;
            this.labelDogrulama.Text = "Kullanıcı Adı Ve/Veya Şifre Yanlış";
            this.labelDogrulama.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelDogrulama.Visible = false;
            // 
            // FormKullaniciBilgileriGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.labelDogrulama);
            this.Controls.Add(this.panelUyeOl);
            this.Controls.Add(this.panelTop);
            this.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(77)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormKullaniciBilgileriGuncelle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Kullanici Bilgileri Guncelle";
            this.Load += new System.EventHandler(this.FormKullaniciBilgileriGuncelle_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelUyeOl.ResumeLayout(false);
            this.panelUyeOl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label labelKullaniciGuncelle;
        private System.Windows.Forms.Button buttonSarkiEkleExit;
        private System.Windows.Forms.Panel panelUyeOl;
        private System.Windows.Forms.CheckBox checkBoxVIP;
        private System.Windows.Forms.ComboBox comboBoxUlke;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxGuncelleEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonGuncelle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxGuncelleSifre;
        private System.Windows.Forms.TextBox textBoxGuncelleKullaniciAdi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelDogrulama;
    }
}