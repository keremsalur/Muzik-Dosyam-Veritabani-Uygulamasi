
namespace Prolab2_Proje3
{
    partial class FormAlbumEkle
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
            this.labelAlbumEkle = new System.Windows.Forms.Label();
            this.buttonSanatciEkleExit = new System.Windows.Forms.Button();
            this.buttonAlbumKayitEt = new System.Windows.Forms.Button();
            this.labelKayitDogrulama = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxMuzikTuru = new System.Windows.Forms.ComboBox();
            this.textBoxAlbumAdi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerTarih = new System.Windows.Forms.DateTimePicker();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.labelAlbumEkle);
            this.panelTop.Controls.Add(this.buttonSanatciEkleExit);
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(300, 50);
            this.panelTop.TabIndex = 2;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
            this.panelTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseMove);
            this.panelTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseUp);
            // 
            // labelAlbumEkle
            // 
            this.labelAlbumEkle.AutoSize = true;
            this.labelAlbumEkle.Font = new System.Drawing.Font("Segoe Print", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAlbumEkle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(77)))));
            this.labelAlbumEkle.Location = new System.Drawing.Point(12, 7);
            this.labelAlbumEkle.Name = "labelAlbumEkle";
            this.labelAlbumEkle.Size = new System.Drawing.Size(124, 33);
            this.labelAlbumEkle.TabIndex = 2;
            this.labelAlbumEkle.Text = "Albüm Ekle";
            // 
            // buttonSanatciEkleExit
            // 
            this.buttonSanatciEkleExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.buttonSanatciEkleExit.BackgroundImage = global::Prolab2_Proje3.Properties.Resources.xa;
            this.buttonSanatciEkleExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonSanatciEkleExit.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonSanatciEkleExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.buttonSanatciEkleExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.buttonSanatciEkleExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.buttonSanatciEkleExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSanatciEkleExit.Location = new System.Drawing.Point(257, 9);
            this.buttonSanatciEkleExit.Name = "buttonSanatciEkleExit";
            this.buttonSanatciEkleExit.Size = new System.Drawing.Size(31, 33);
            this.buttonSanatciEkleExit.TabIndex = 1;
            this.buttonSanatciEkleExit.TabStop = false;
            this.buttonSanatciEkleExit.UseVisualStyleBackColor = false;
            this.buttonSanatciEkleExit.Click += new System.EventHandler(this.buttonSanatciEkleExit_Click);
            // 
            // buttonAlbumKayitEt
            // 
            this.buttonAlbumKayitEt.BackgroundImage = global::Prolab2_Proje3.Properties.Resources.playlist;
            this.buttonAlbumKayitEt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonAlbumKayitEt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.buttonAlbumKayitEt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.buttonAlbumKayitEt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.buttonAlbumKayitEt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAlbumKayitEt.Location = new System.Drawing.Point(126, 210);
            this.buttonAlbumKayitEt.Name = "buttonAlbumKayitEt";
            this.buttonAlbumKayitEt.Size = new System.Drawing.Size(50, 50);
            this.buttonAlbumKayitEt.TabIndex = 22;
            this.buttonAlbumKayitEt.UseVisualStyleBackColor = true;
            this.buttonAlbumKayitEt.Click += new System.EventHandler(this.buttonAlbumKayitEt_Click);
            // 
            // labelKayitDogrulama
            // 
            this.labelKayitDogrulama.AutoSize = true;
            this.labelKayitDogrulama.Font = new System.Drawing.Font("Segoe Print", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelKayitDogrulama.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(77)))));
            this.labelKayitDogrulama.Location = new System.Drawing.Point(111, 272);
            this.labelKayitDogrulama.Name = "labelKayitDogrulama";
            this.labelKayitDogrulama.Size = new System.Drawing.Size(82, 19);
            this.labelKayitDogrulama.TabIndex = 21;
            this.labelKayitDogrulama.Text = "Kayıt Başarılı";
            this.labelKayitDogrulama.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelKayitDogrulama.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(77)))));
            this.label1.Location = new System.Drawing.Point(32, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 28);
            this.label1.TabIndex = 20;
            this.label1.Text = "Müzik Türü";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBoxMuzikTuru
            // 
            this.comboBoxMuzikTuru.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.comboBoxMuzikTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMuzikTuru.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxMuzikTuru.Font = new System.Drawing.Font("Segoe Print", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxMuzikTuru.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(77)))));
            this.comboBoxMuzikTuru.FormattingEnabled = true;
            this.comboBoxMuzikTuru.Items.AddRange(new object[] {
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
            this.comboBoxMuzikTuru.Location = new System.Drawing.Point(150, 127);
            this.comboBoxMuzikTuru.MaxDropDownItems = 5;
            this.comboBoxMuzikTuru.Name = "comboBoxMuzikTuru";
            this.comboBoxMuzikTuru.Size = new System.Drawing.Size(121, 27);
            this.comboBoxMuzikTuru.TabIndex = 19;
            this.comboBoxMuzikTuru.SelectedIndexChanged += new System.EventHandler(this.comboBoxMuzikTuru_SelectedIndexChanged);
            // 
            // textBoxAlbumAdi
            // 
            this.textBoxAlbumAdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.textBoxAlbumAdi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAlbumAdi.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxAlbumAdi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(77)))));
            this.textBoxAlbumAdi.Location = new System.Drawing.Point(150, 99);
            this.textBoxAlbumAdi.Name = "textBoxAlbumAdi";
            this.textBoxAlbumAdi.PlaceholderText = "Giriniz";
            this.textBoxAlbumAdi.Size = new System.Drawing.Size(121, 24);
            this.textBoxAlbumAdi.TabIndex = 18;
            this.textBoxAlbumAdi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxAlbumAdi.TextChanged += new System.EventHandler(this.textBoxAlbumAdi_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(77)))));
            this.label6.Location = new System.Drawing.Point(38, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 28);
            this.label6.TabIndex = 17;
            this.label6.Text = "Albüm Adı";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(77)))));
            this.label2.Location = new System.Drawing.Point(81, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 28);
            this.label2.TabIndex = 23;
            this.label2.Text = "Tarih";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dateTimePickerTarih
            // 
            this.dateTimePickerTarih.CalendarFont = new System.Drawing.Font("Segoe Print", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerTarih.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(77)))));
            this.dateTimePickerTarih.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.dateTimePickerTarih.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(77)))));
            this.dateTimePickerTarih.Font = new System.Drawing.Font("Segoe Print", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerTarih.Location = new System.Drawing.Point(150, 166);
            this.dateTimePickerTarih.Name = "dateTimePickerTarih";
            this.dateTimePickerTarih.Size = new System.Drawing.Size(121, 26);
            this.dateTimePickerTarih.TabIndex = 24;
            this.dateTimePickerTarih.ValueChanged += new System.EventHandler(this.dateTimePickerTarih_ValueChanged);
            // 
            // FormAlbumEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.dateTimePickerTarih);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonAlbumKayitEt);
            this.Controls.Add(this.labelKayitDogrulama);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxMuzikTuru);
            this.Controls.Add(this.textBoxAlbumAdi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panelTop);
            this.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(77)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(300, 300);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "FormAlbumEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Album Ekle";
            this.Load += new System.EventHandler(this.FormAlbumEkle_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label labelAlbumEkle;
        private System.Windows.Forms.Button buttonSanatciEkleExit;
        private System.Windows.Forms.Button buttonAlbumKayitEt;
        private System.Windows.Forms.Label labelKayitDogrulama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxMuzikTuru;
        private System.Windows.Forms.TextBox textBoxAlbumAdi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerTarih;
    }
}