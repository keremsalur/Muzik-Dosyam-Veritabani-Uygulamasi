
namespace Prolab2_Proje3
{
    partial class FromLogin
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
            this.buttonLoginExit = new System.Windows.Forms.Button();
            this.labelLogin = new System.Windows.Forms.Label();
            this.panelLoginBar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxLoginKullaniciAdi = new System.Windows.Forms.TextBox();
            this.textBoxLoginSifre = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.buttonAdminLogin = new System.Windows.Forms.Button();
            this.labelDogrulama = new System.Windows.Forms.Label();
            this.checkBoxUyeEkran = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panelGirisYap = new System.Windows.Forms.Panel();
            this.panelUyeOl = new System.Windows.Forms.Panel();
            this.checkBoxVIP = new System.Windows.Forms.CheckBox();
            this.comboBoxUlke = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxUyeEkleEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonKayitOl = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxUyeOlSifre = new System.Windows.Forms.TextBox();
            this.textBoxUyeOlKullaniciAdi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panelLoginBar.SuspendLayout();
            this.panelGirisYap.SuspendLayout();
            this.panelUyeOl.SuspendLayout();
            this.SuspendLayout();
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
            this.buttonLoginExit.TabIndex = 0;
            this.buttonLoginExit.TabStop = false;
            this.buttonLoginExit.UseVisualStyleBackColor = true;
            this.buttonLoginExit.Click += new System.EventHandler(this.buttonLoginExit_Click);
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Segoe Print", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelLogin.Location = new System.Drawing.Point(12, 7);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(154, 33);
            this.labelLogin.TabIndex = 1;
            this.labelLogin.Text = "Müzik Dosyam";
            this.labelLogin.Click += new System.EventHandler(this.labelLogin_Click);
            // 
            // panelLoginBar
            // 
            this.panelLoginBar.Controls.Add(this.labelLogin);
            this.panelLoginBar.Controls.Add(this.buttonLoginExit);
            this.panelLoginBar.Location = new System.Drawing.Point(0, 0);
            this.panelLoginBar.Name = "panelLoginBar";
            this.panelLoginBar.Size = new System.Drawing.Size(300, 50);
            this.panelLoginBar.TabIndex = 2;
            this.panelLoginBar.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLoginBar_Paint);
            this.panelLoginBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelLoginBar_MouseDown);
            this.panelLoginBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelLoginBar_MouseMove);
            this.panelLoginBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelLoginBar_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Şifre";
            // 
            // textBoxLoginKullaniciAdi
            // 
            this.textBoxLoginKullaniciAdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(17)))), ((int)(((byte)(28)))));
            this.textBoxLoginKullaniciAdi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLoginKullaniciAdi.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxLoginKullaniciAdi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(77)))));
            this.textBoxLoginKullaniciAdi.Location = new System.Drawing.Point(122, 47);
            this.textBoxLoginKullaniciAdi.Name = "textBoxLoginKullaniciAdi";
            this.textBoxLoginKullaniciAdi.PlaceholderText = "Giriniz";
            this.textBoxLoginKullaniciAdi.Size = new System.Drawing.Size(100, 24);
            this.textBoxLoginKullaniciAdi.TabIndex = 5;
            this.textBoxLoginKullaniciAdi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxLoginSifre
            // 
            this.textBoxLoginSifre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(17)))), ((int)(((byte)(28)))));
            this.textBoxLoginSifre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLoginSifre.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxLoginSifre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(77)))));
            this.textBoxLoginSifre.Location = new System.Drawing.Point(122, 77);
            this.textBoxLoginSifre.Name = "textBoxLoginSifre";
            this.textBoxLoginSifre.PasswordChar = '*';
            this.textBoxLoginSifre.PlaceholderText = "Giriniz";
            this.textBoxLoginSifre.Size = new System.Drawing.Size(100, 24);
            this.textBoxLoginSifre.TabIndex = 6;
            this.textBoxLoginSifre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackgroundImage = global::Prolab2_Proje3.Properties.Resources.loginIcon;
            this.buttonLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(17)))), ((int)(((byte)(28)))));
            this.buttonLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(17)))), ((int)(((byte)(28)))));
            this.buttonLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(17)))), ((int)(((byte)(28)))));
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Location = new System.Drawing.Point(85, 119);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(40, 40);
            this.buttonLogin.TabIndex = 7;
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackgroundImage = global::Prolab2_Proje3.Properties.Resources.logo;
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelLogo.Location = new System.Drawing.Point(90, 100);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(120, 120);
            this.panelLogo.TabIndex = 8;
            // 
            // buttonAdminLogin
            // 
            this.buttonAdminLogin.BackgroundImage = global::Prolab2_Proje3.Properties.Resources.adminLogib;
            this.buttonAdminLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonAdminLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(17)))), ((int)(((byte)(28)))));
            this.buttonAdminLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(17)))), ((int)(((byte)(28)))));
            this.buttonAdminLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(17)))), ((int)(((byte)(28)))));
            this.buttonAdminLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdminLogin.Location = new System.Drawing.Point(12, 448);
            this.buttonAdminLogin.Name = "buttonAdminLogin";
            this.buttonAdminLogin.Size = new System.Drawing.Size(40, 40);
            this.buttonAdminLogin.TabIndex = 9;
            this.buttonAdminLogin.UseVisualStyleBackColor = true;
            this.buttonAdminLogin.Click += new System.EventHandler(this.buttonAdminLogin_Click);
            // 
            // labelDogrulama
            // 
            this.labelDogrulama.AutoSize = true;
            this.labelDogrulama.Font = new System.Drawing.Font("Segoe Print", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDogrulama.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.labelDogrulama.Location = new System.Drawing.Point(58, 460);
            this.labelDogrulama.Name = "labelDogrulama";
            this.labelDogrulama.Size = new System.Drawing.Size(194, 19);
            this.labelDogrulama.TabIndex = 10;
            this.labelDogrulama.Text = "Kullanıcı Adı Ve/Veya Şifre Yanlış";
            this.labelDogrulama.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelDogrulama.Visible = false;
            // 
            // checkBoxUyeEkran
            // 
            this.checkBoxUyeEkran.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxUyeEkran.AutoSize = true;
            this.checkBoxUyeEkran.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(77)))));
            this.checkBoxUyeEkran.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(77)))));
            this.checkBoxUyeEkran.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(17)))), ((int)(((byte)(28)))));
            this.checkBoxUyeEkran.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxUyeEkran.Font = new System.Drawing.Font("Segoe Print", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxUyeEkran.Location = new System.Drawing.Point(12, 56);
            this.checkBoxUyeEkran.Name = "checkBoxUyeEkran";
            this.checkBoxUyeEkran.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBoxUyeEkran.Size = new System.Drawing.Size(69, 29);
            this.checkBoxUyeEkran.TabIndex = 11;
            this.checkBoxUyeEkran.Text = "Giriş Yap";
            this.checkBoxUyeEkran.UseVisualStyleBackColor = true;
            this.checkBoxUyeEkran.CheckedChanged += new System.EventHandler(this.checkBoxUyeEkran_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(48, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 28);
            this.label3.TabIndex = 12;
            this.label3.Text = "Giriş Yapınız";
            // 
            // panelGirisYap
            // 
            this.panelGirisYap.Controls.Add(this.label3);
            this.panelGirisYap.Controls.Add(this.buttonLogin);
            this.panelGirisYap.Controls.Add(this.label2);
            this.panelGirisYap.Controls.Add(this.textBoxLoginSifre);
            this.panelGirisYap.Controls.Add(this.textBoxLoginKullaniciAdi);
            this.panelGirisYap.Controls.Add(this.label1);
            this.panelGirisYap.Location = new System.Drawing.Point(45, 260);
            this.panelGirisYap.Name = "panelGirisYap";
            this.panelGirisYap.Size = new System.Drawing.Size(210, 160);
            this.panelGirisYap.TabIndex = 13;
            this.panelGirisYap.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panelUyeOl
            // 
            this.panelUyeOl.Controls.Add(this.checkBoxVIP);
            this.panelUyeOl.Controls.Add(this.comboBoxUlke);
            this.panelUyeOl.Controls.Add(this.label7);
            this.panelUyeOl.Controls.Add(this.textBoxUyeEkleEmail);
            this.panelUyeOl.Controls.Add(this.label4);
            this.panelUyeOl.Controls.Add(this.buttonKayitOl);
            this.panelUyeOl.Controls.Add(this.label5);
            this.panelUyeOl.Controls.Add(this.textBoxUyeOlSifre);
            this.panelUyeOl.Controls.Add(this.textBoxUyeOlKullaniciAdi);
            this.panelUyeOl.Controls.Add(this.label6);
            this.panelUyeOl.Location = new System.Drawing.Point(45, 240);
            this.panelUyeOl.Name = "panelUyeOl";
            this.panelUyeOl.Size = new System.Drawing.Size(210, 200);
            this.panelUyeOl.TabIndex = 14;
            this.panelUyeOl.Visible = false;
            this.panelUyeOl.Paint += new System.Windows.Forms.PaintEventHandler(this.panelUyeOl_Paint);
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
            this.checkBoxVIP.CheckedChanged += new System.EventHandler(this.checkBoxVIP_CheckedChanged);
            this.checkBoxVIP.Click += new System.EventHandler(this.checkBoxVIP_Click);
            // 
            // comboBoxUlke
            // 
            this.comboBoxUlke.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(17)))), ((int)(((byte)(28)))));
            this.comboBoxUlke.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUlke.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxUlke.Font = new System.Drawing.Font("Segoe Print", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxUlke.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(77)))));
            this.comboBoxUlke.FormattingEnabled = true;
            this.comboBoxUlke.Items.AddRange(new object[] {
            "Abhazya",
            "Afganistan",
            "Almanya",
            "Amerika Birleşik Devletleri",
            "Andorra",
            "Angola",
            "Antigua ve Barbuda",
            "Arjantin",
            "Arnavutluk",
            "Avustralya",
            "Avusturya",
            "Azerbaycan",
            "Bahamalar",
            "Bahreyn",
            "Bangladeş",
            "Barbados",
            "Batı Sahra",
            "Belçika",
            "Belize",
            "Benin",
            "Beyaz Rusya",
            "Bhutan",
            "Birleşik Arap Emirlikleri",
            "Bolivya",
            "Bosna Hersek",
            "Botsvana",
            "Brezilya",
            "Brunei",
            "Bulgaristan",
            "Burkina Faso",
            "Burundi",
            "Cezayir",
            "Cibuti",
            "Çad",
            "Çek Cumhuriyeti",
            "Çin Halk Cumhuriyeti",
            "Dağlık Karabağ Cumhuriyeti",
            "Danimarka",
            "Doğu Timor",
            "Dominik Cumhuriyeti",
            "Dominika",
            "Ekvador",
            "Ekvator Ginesi",
            "El Salvador",
            "Endonezya",
            "Eritre",
            "Ermenistan",
            "Estonya",
            "Etiyopya",
            "Fas",
            "Fiji",
            "Fildişi Sahilleri",
            "Filipinler",
            "Filistin",
            "Finlandiya",
            "Fransa",
            "Gabon",
            "Gambiya",
            "Gana",
            "Gine",
            "Gine Bissau Gine Bissau Batı Afrika",
            "Grenada",
            "Guyana",
            "Guatemala",
            "Güney Afrika Cumhuriyeti",
            "Güney Kore",
            "Güney Osetya",
            "Güney Sudan",
            "Gürcistan",
            "Haiti",
            "Hırvatistan",
            "Hindistan",
            "Hollanda",
            "Honduras",
            "Irak",
            "İngiltere",
            "İran",
            "İrlanda",
            "İspanya",
            "İsrail",
            "İsveç",
            "İsviçre",
            "İtalya",
            "İzlanda",
            "Jamaika",
            "Japonya",
            "Kamboçya",
            "Kamerun",
            "Kanada",
            "Karadağ Katar",
            "Kazakistan",
            "Kenya",
            "Kırgızistan",
            "Kıbrıs Cumhuriyeti",
            "Kiribati",
            "Kolombiya",
            "Komorlar",
            "Kongo",
            "Kongo Demokratik Cumhuriyeti",
            "Kosova",
            "Kosta Rika",
            "Kuveyt",
            "Kuzey Kıbrıs Türk Cumhuriyeti",
            "Kuzey Kore",
            "Küba",
            "Laos",
            "Lesotho",
            "Letonya",
            "Liberya",
            "Libya",
            "Liechtenstein",
            "Litvanya",
            "Lübnan",
            "Lüksemburg",
            "Macaristan",
            "Madagaskar",
            "Makedonya Cumhuriyeti",
            "Malavi",
            "Maldivler",
            "Malezya",
            "Mali",
            "Malta",
            "Marshall Adaları",
            "Meksika",
            "Mısır",
            "Mikronezya",
            "Moğolistan",
            "Moldova",
            "Monako",
            "Moritanya",
            "Moritius",
            "Mozambik",
            "Myanmar",
            "Namibya",
            "Nauru",
            "Nepal",
            "Nikaragua",
            "Nijer",
            "Nijerya",
            "Norveç",
            "Orta Afrika Cumhuriyeti",
            "Özbekistan",
            "Pakistan",
            "Palau",
            "Panama",
            "Papua",
            "Paraguay",
            "Peru",
            "Polonya",
            "Portekiz",
            "Porto Riko",
            "Romanya",
            "Ruanda",
            "Rusya Federasyonu",
            "Saint Kitts",
            "Saint Lucia",
            "Saint Vincent ve Grenadinler",
            "Samoa",
            "San Marino",
            "Sao Tome ve Principe",
            "Sealand",
            "Senegal",
            "Seyşeller",
            "Sırbistan",
            "Sierra Leone",
            "Singapur",
            "Slovakya",
            "Slovenya",
            "Solomon Adaları",
            "Somali",
            "Somaliland",
            "Sri Lanka",
            "Sudan",
            "Surinam",
            "Suriye",
            "Suudi Arabistan",
            "Svaziland",
            "Şili",
            "Tacikistan",
            "Tanzanya",
            "Tayland",
            "Tayvan",
            "Togo",
            "Tonga",
            "Transdinyester",
            "Trinidad ve Tobago",
            "Tunus",
            "Tuvalu",
            "Türkiye",
            "Türkmenistan",
            "Uganda",
            "Ukrayna",
            "Umman",
            "Uruguay",
            "Ürdün",
            "Vanuatu",
            "Vatikan",
            "Venezuela",
            "Vietnam",
            "Yemen",
            "Yeni Zelanda",
            "Yeşil Burun",
            "Yunanistan",
            "Zambiyav",
            "Zimbabve"});
            this.comboBoxUlke.Location = new System.Drawing.Point(74, 123);
            this.comboBoxUlke.MaxDropDownItems = 5;
            this.comboBoxUlke.Name = "comboBoxUlke";
            this.comboBoxUlke.Size = new System.Drawing.Size(121, 27);
            this.comboBoxUlke.TabIndex = 9;
            this.comboBoxUlke.SelectedIndexChanged += new System.EventHandler(this.comboBoxUlke_SelectedIndexChanged);
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
            // textBoxUyeEkleEmail
            // 
            this.textBoxUyeEkleEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(17)))), ((int)(((byte)(28)))));
            this.textBoxUyeEkleEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUyeEkleEmail.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxUyeEkleEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(77)))));
            this.textBoxUyeEkleEmail.Location = new System.Drawing.Point(122, 95);
            this.textBoxUyeEkleEmail.Name = "textBoxUyeEkleEmail";
            this.textBoxUyeEkleEmail.PlaceholderText = "Giriniz";
            this.textBoxUyeEkleEmail.Size = new System.Drawing.Size(100, 24);
            this.textBoxUyeEkleEmail.TabIndex = 7;
            this.textBoxUyeEkleEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(72, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 28);
            this.label4.TabIndex = 12;
            this.label4.Text = "Üye Ol";
            // 
            // buttonKayitOl
            // 
            this.buttonKayitOl.BackgroundImage = global::Prolab2_Proje3.Properties.Resources.kayitOl;
            this.buttonKayitOl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonKayitOl.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(17)))), ((int)(((byte)(28)))));
            this.buttonKayitOl.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(17)))), ((int)(((byte)(28)))));
            this.buttonKayitOl.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(17)))), ((int)(((byte)(28)))));
            this.buttonKayitOl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKayitOl.Location = new System.Drawing.Point(85, 159);
            this.buttonKayitOl.Name = "buttonKayitOl";
            this.buttonKayitOl.Size = new System.Drawing.Size(40, 40);
            this.buttonKayitOl.TabIndex = 10;
            this.buttonKayitOl.UseVisualStyleBackColor = true;
            this.buttonKayitOl.Click += new System.EventHandler(this.buttonKayitOl_Click);
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
            // textBoxUyeOlSifre
            // 
            this.textBoxUyeOlSifre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(17)))), ((int)(((byte)(28)))));
            this.textBoxUyeOlSifre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUyeOlSifre.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxUyeOlSifre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(77)))));
            this.textBoxUyeOlSifre.Location = new System.Drawing.Point(122, 67);
            this.textBoxUyeOlSifre.Name = "textBoxUyeOlSifre";
            this.textBoxUyeOlSifre.PasswordChar = '*';
            this.textBoxUyeOlSifre.PlaceholderText = "Giriniz";
            this.textBoxUyeOlSifre.Size = new System.Drawing.Size(100, 24);
            this.textBoxUyeOlSifre.TabIndex = 6;
            this.textBoxUyeOlSifre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxUyeOlKullaniciAdi
            // 
            this.textBoxUyeOlKullaniciAdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(17)))), ((int)(((byte)(28)))));
            this.textBoxUyeOlKullaniciAdi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUyeOlKullaniciAdi.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxUyeOlKullaniciAdi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(77)))));
            this.textBoxUyeOlKullaniciAdi.Location = new System.Drawing.Point(122, 37);
            this.textBoxUyeOlKullaniciAdi.Name = "textBoxUyeOlKullaniciAdi";
            this.textBoxUyeOlKullaniciAdi.PlaceholderText = "Giriniz";
            this.textBoxUyeOlKullaniciAdi.Size = new System.Drawing.Size(100, 24);
            this.textBoxUyeOlKullaniciAdi.TabIndex = 5;
            this.textBoxUyeOlKullaniciAdi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // FromLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(17)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(300, 500);
            this.Controls.Add(this.panelGirisYap);
            this.Controls.Add(this.checkBoxUyeEkran);
            this.Controls.Add(this.labelDogrulama);
            this.Controls.Add(this.buttonAdminLogin);
            this.Controls.Add(this.panelLogo);
            this.Controls.Add(this.panelLoginBar);
            this.Controls.Add(this.panelUyeOl);
            this.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(77)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 500);
            this.MinimumSize = new System.Drawing.Size(300, 500);
            this.Name = "FromLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FromLogin_Load);
            this.panelLoginBar.ResumeLayout(false);
            this.panelLoginBar.PerformLayout();
            this.panelGirisYap.ResumeLayout(false);
            this.panelGirisYap.PerformLayout();
            this.panelUyeOl.ResumeLayout(false);
            this.panelUyeOl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLoginExit;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Panel panelLoginBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxLoginKullaniciAdi;
        private System.Windows.Forms.TextBox textBoxLoginSifre;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button buttonAdminLogin;
        private System.Windows.Forms.Label labelDogrulama;
        private System.Windows.Forms.CheckBox checkBoxUyeEkran;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelGirisYap;
        private System.Windows.Forms.Panel panelUyeOl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonKayitOl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxUyeOlSifre;
        private System.Windows.Forms.TextBox textBoxUyeOlKullaniciAdi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxUyeEkleEmail;
        private System.Windows.Forms.ComboBox comboBoxUlke;
        private System.Windows.Forms.CheckBox checkBoxVIP;
    }
}

