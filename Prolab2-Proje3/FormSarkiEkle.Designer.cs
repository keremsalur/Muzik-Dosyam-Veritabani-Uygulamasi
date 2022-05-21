
namespace Prolab2_Proje3
{
    partial class FormSarkiEkle
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
            this.labelSanatciEkle = new System.Windows.Forms.Label();
            this.buttonSarkiEkleExit = new System.Windows.Forms.Button();
            this.dateTimePickerTarih = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAlbumKayitEt = new System.Windows.Forms.Button();
            this.labelKayitDogrulama = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxMuzikTuru = new System.Windows.Forms.ComboBox();
            this.textBoxSarkiAdi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownSaat = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDakika = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSaniye = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxAlbum = new System.Windows.Forms.ComboBox();
            this.checkedListBoxSanatcilar = new System.Windows.Forms.CheckedListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSaat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDakika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSaniye)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.labelSanatciEkle);
            this.panelTop.Controls.Add(this.buttonSarkiEkleExit);
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(300, 50);
            this.panelTop.TabIndex = 2;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
            this.panelTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseMove);
            this.panelTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseUp);
            // 
            // labelSanatciEkle
            // 
            this.labelSanatciEkle.AutoSize = true;
            this.labelSanatciEkle.Font = new System.Drawing.Font("Segoe Print", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSanatciEkle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(77)))));
            this.labelSanatciEkle.Location = new System.Drawing.Point(12, 7);
            this.labelSanatciEkle.Name = "labelSanatciEkle";
            this.labelSanatciEkle.Size = new System.Drawing.Size(111, 33);
            this.labelSanatciEkle.TabIndex = 2;
            this.labelSanatciEkle.Text = "Şarkı Ekle";
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
            // dateTimePickerTarih
            // 
            this.dateTimePickerTarih.CalendarFont = new System.Drawing.Font("Segoe Print", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerTarih.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(77)))));
            this.dateTimePickerTarih.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.dateTimePickerTarih.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(77)))));
            this.dateTimePickerTarih.Font = new System.Drawing.Font("Segoe Print", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerTarih.Location = new System.Drawing.Point(145, 162);
            this.dateTimePickerTarih.Name = "dateTimePickerTarih";
            this.dateTimePickerTarih.Size = new System.Drawing.Size(121, 26);
            this.dateTimePickerTarih.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(77)))));
            this.label2.Location = new System.Drawing.Point(68, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 28);
            this.label2.TabIndex = 31;
            this.label2.Text = "Tarih";
            // 
            // buttonAlbumKayitEt
            // 
            this.buttonAlbumKayitEt.BackgroundImage = global::Prolab2_Proje3.Properties.Resources.playlist;
            this.buttonAlbumKayitEt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonAlbumKayitEt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.buttonAlbumKayitEt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.buttonAlbumKayitEt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.buttonAlbumKayitEt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAlbumKayitEt.Location = new System.Drawing.Point(116, 290);
            this.buttonAlbumKayitEt.Name = "buttonAlbumKayitEt";
            this.buttonAlbumKayitEt.Size = new System.Drawing.Size(50, 50);
            this.buttonAlbumKayitEt.TabIndex = 8;
            this.buttonAlbumKayitEt.UseVisualStyleBackColor = true;
            this.buttonAlbumKayitEt.Click += new System.EventHandler(this.buttonAlbumKayitEt_Click);
            // 
            // labelKayitDogrulama
            // 
            this.labelKayitDogrulama.AutoSize = true;
            this.labelKayitDogrulama.Font = new System.Drawing.Font("Segoe Print", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelKayitDogrulama.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(77)))));
            this.labelKayitDogrulama.Location = new System.Drawing.Point(100, 343);
            this.labelKayitDogrulama.Name = "labelKayitDogrulama";
            this.labelKayitDogrulama.Size = new System.Drawing.Size(82, 19);
            this.labelKayitDogrulama.TabIndex = 29;
            this.labelKayitDogrulama.Text = "Kayıt Başarılı";
            this.labelKayitDogrulama.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelKayitDogrulama.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(77)))));
            this.label1.Location = new System.Drawing.Point(19, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 28);
            this.label1.TabIndex = 28;
            this.label1.Text = "Müzik Türü";
            // 
            // comboBoxMuzikTuru
            // 
            this.comboBoxMuzikTuru.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.comboBoxMuzikTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMuzikTuru.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxMuzikTuru.Font = new System.Drawing.Font("Segoe Print", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxMuzikTuru.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(77)))));
            this.comboBoxMuzikTuru.FormattingEnabled = true;
            this.comboBoxMuzikTuru.Location = new System.Drawing.Point(145, 91);
            this.comboBoxMuzikTuru.MaxDropDownItems = 5;
            this.comboBoxMuzikTuru.Name = "comboBoxMuzikTuru";
            this.comboBoxMuzikTuru.Size = new System.Drawing.Size(121, 27);
            this.comboBoxMuzikTuru.TabIndex = 2;
            this.comboBoxMuzikTuru.SelectedIndexChanged += new System.EventHandler(this.comboBoxMuzikTuru_SelectedIndexChanged);
            // 
            // textBoxSarkiAdi
            // 
            this.textBoxSarkiAdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.textBoxSarkiAdi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSarkiAdi.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxSarkiAdi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(77)))));
            this.textBoxSarkiAdi.Location = new System.Drawing.Point(147, 59);
            this.textBoxSarkiAdi.Name = "textBoxSarkiAdi";
            this.textBoxSarkiAdi.PlaceholderText = "Giriniz";
            this.textBoxSarkiAdi.Size = new System.Drawing.Size(121, 24);
            this.textBoxSarkiAdi.TabIndex = 1;
            this.textBoxSarkiAdi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(77)))));
            this.label6.Location = new System.Drawing.Point(36, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 28);
            this.label6.TabIndex = 25;
            this.label6.Text = "Şarkı Adı";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(77)))));
            this.label3.Location = new System.Drawing.Point(75, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 28);
            this.label3.TabIndex = 33;
            this.label3.Text = "Süre";
            // 
            // numericUpDownSaat
            // 
            this.numericUpDownSaat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.numericUpDownSaat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDownSaat.Font = new System.Drawing.Font("Segoe Print", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericUpDownSaat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(77)))));
            this.numericUpDownSaat.Location = new System.Drawing.Point(145, 194);
            this.numericUpDownSaat.Name = "numericUpDownSaat";
            this.numericUpDownSaat.Size = new System.Drawing.Size(37, 22);
            this.numericUpDownSaat.TabIndex = 5;
            this.numericUpDownSaat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numericUpDownDakika
            // 
            this.numericUpDownDakika.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.numericUpDownDakika.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDownDakika.Font = new System.Drawing.Font("Segoe Print", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericUpDownDakika.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(77)))));
            this.numericUpDownDakika.Location = new System.Drawing.Point(188, 194);
            this.numericUpDownDakika.Name = "numericUpDownDakika";
            this.numericUpDownDakika.Size = new System.Drawing.Size(37, 22);
            this.numericUpDownDakika.TabIndex = 6;
            this.numericUpDownDakika.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numericUpDownSaniye
            // 
            this.numericUpDownSaniye.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.numericUpDownSaniye.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDownSaniye.Font = new System.Drawing.Font("Segoe Print", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericUpDownSaniye.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(77)))));
            this.numericUpDownSaniye.Location = new System.Drawing.Point(231, 194);
            this.numericUpDownSaniye.Name = "numericUpDownSaniye";
            this.numericUpDownSaniye.Size = new System.Drawing.Size(37, 22);
            this.numericUpDownSaniye.TabIndex = 7;
            this.numericUpDownSaniye.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(77)))));
            this.label4.Location = new System.Drawing.Point(59, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 28);
            this.label4.TabIndex = 40;
            this.label4.Text = "Albüm";
            // 
            // comboBoxAlbum
            // 
            this.comboBoxAlbum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.comboBoxAlbum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAlbum.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxAlbum.Font = new System.Drawing.Font("Segoe Print", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxAlbum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(77)))));
            this.comboBoxAlbum.FormattingEnabled = true;
            this.comboBoxAlbum.Location = new System.Drawing.Point(145, 124);
            this.comboBoxAlbum.MaxDropDownItems = 5;
            this.comboBoxAlbum.Name = "comboBoxAlbum";
            this.comboBoxAlbum.Size = new System.Drawing.Size(121, 27);
            this.comboBoxAlbum.TabIndex = 3;
            // 
            // checkedListBoxSanatcilar
            // 
            this.checkedListBoxSanatcilar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.checkedListBoxSanatcilar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBoxSanatcilar.Font = new System.Drawing.Font("Segoe Print", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkedListBoxSanatcilar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(77)))));
            this.checkedListBoxSanatcilar.FormattingEnabled = true;
            this.checkedListBoxSanatcilar.Items.AddRange(new object[] {
            "sdfsdfsd",
            "sd",
            "fsd",
            "fsd",
            "f",
            "sdf",
            "sd",
            "fsd",
            "f"});
            this.checkedListBoxSanatcilar.Location = new System.Drawing.Point(145, 226);
            this.checkedListBoxSanatcilar.Name = "checkedListBoxSanatcilar";
            this.checkedListBoxSanatcilar.Size = new System.Drawing.Size(120, 63);
            this.checkedListBoxSanatcilar.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(77)))));
            this.label5.Location = new System.Drawing.Point(29, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 28);
            this.label5.TabIndex = 42;
            this.label5.Text = "Sanatçılar";
            // 
            // FormSarkiEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(300, 371);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkedListBoxSanatcilar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxAlbum);
            this.Controls.Add(this.numericUpDownSaniye);
            this.Controls.Add(this.numericUpDownDakika);
            this.Controls.Add(this.numericUpDownSaat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePickerTarih);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonAlbumKayitEt);
            this.Controls.Add(this.labelKayitDogrulama);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxMuzikTuru);
            this.Controls.Add(this.textBoxSarkiAdi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panelTop);
            this.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(77)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSarkiEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Şarkı Ekle";
            this.Load += new System.EventHandler(this.FormSarkiEkle_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSaat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDakika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSaniye)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label labelSanatciEkle;
        private System.Windows.Forms.Button buttonSarkiEkleExit;
        private System.Windows.Forms.DateTimePicker dateTimePickerTarih;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAlbumKayitEt;
        private System.Windows.Forms.Label labelKayitDogrulama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxMuzikTuru;
        private System.Windows.Forms.TextBox textBoxSarkiAdi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownSaat;
        private System.Windows.Forms.NumericUpDown numericUpDownDakika;
        private System.Windows.Forms.NumericUpDown numericUpDownSaniye;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxAlbum;
        private System.Windows.Forms.CheckedListBox checkedListBoxSanatcilar;
        private System.Windows.Forms.Label label5;
    }
}