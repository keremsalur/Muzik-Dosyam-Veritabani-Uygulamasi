
namespace Prolab2_Proje3
{
    partial class FormSanatciEkle
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
            this.buttonSanatciEkleExit = new System.Windows.Forms.Button();
            this.comboBoxUlke = new System.Windows.Forms.ComboBox();
            this.textBoxSanatciAdi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelKayitDogrulama = new System.Windows.Forms.Label();
            this.buttonSanatciKayitEt = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.labelSanatciEkle);
            this.panelTop.Controls.Add(this.buttonSanatciEkleExit);
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(300, 50);
            this.panelTop.TabIndex = 1;
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
            this.labelSanatciEkle.Size = new System.Drawing.Size(133, 33);
            this.labelSanatciEkle.TabIndex = 2;
            this.labelSanatciEkle.Text = "Sanatcı Ekle";
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
            // comboBoxUlke
            // 
            this.comboBoxUlke.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.comboBoxUlke.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUlke.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxUlke.Font = new System.Drawing.Font("Segoe Print", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxUlke.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(77)))));
            this.comboBoxUlke.FormattingEnabled = true;
            this.comboBoxUlke.Location = new System.Drawing.Point(151, 110);
            this.comboBoxUlke.MaxDropDownItems = 5;
            this.comboBoxUlke.Name = "comboBoxUlke";
            this.comboBoxUlke.Size = new System.Drawing.Size(121, 27);
            this.comboBoxUlke.TabIndex = 12;
            // 
            // textBoxSanatciAdi
            // 
            this.textBoxSanatciAdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.textBoxSanatciAdi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSanatciAdi.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxSanatciAdi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(77)))));
            this.textBoxSanatciAdi.Location = new System.Drawing.Point(151, 82);
            this.textBoxSanatciAdi.Name = "textBoxSanatciAdi";
            this.textBoxSanatciAdi.PlaceholderText = "Giriniz";
            this.textBoxSanatciAdi.Size = new System.Drawing.Size(121, 24);
            this.textBoxSanatciAdi.TabIndex = 11;
            this.textBoxSanatciAdi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(77)))));
            this.label6.Location = new System.Drawing.Point(39, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 28);
            this.label6.TabIndex = 10;
            this.label6.Text = "Sanatcı Adı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(77)))));
            this.label1.Location = new System.Drawing.Point(99, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 28);
            this.label1.TabIndex = 13;
            this.label1.Text = "Ulke";
            // 
            // labelKayitDogrulama
            // 
            this.labelKayitDogrulama.AutoSize = true;
            this.labelKayitDogrulama.Font = new System.Drawing.Font("Segoe Print", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelKayitDogrulama.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(77)))));
            this.labelKayitDogrulama.Location = new System.Drawing.Point(109, 222);
            this.labelKayitDogrulama.Name = "labelKayitDogrulama";
            this.labelKayitDogrulama.Size = new System.Drawing.Size(82, 19);
            this.labelKayitDogrulama.TabIndex = 15;
            this.labelKayitDogrulama.Text = "Kayıt Başarılı";
            this.labelKayitDogrulama.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelKayitDogrulama.Visible = false;
            // 
            // buttonSanatciKayitEt
            // 
            this.buttonSanatciKayitEt.BackgroundImage = global::Prolab2_Proje3.Properties.Resources.kayitOl;
            this.buttonSanatciKayitEt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonSanatciKayitEt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.buttonSanatciKayitEt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.buttonSanatciKayitEt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.buttonSanatciKayitEt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSanatciKayitEt.Location = new System.Drawing.Point(130, 160);
            this.buttonSanatciKayitEt.Name = "buttonSanatciKayitEt";
            this.buttonSanatciKayitEt.Size = new System.Drawing.Size(40, 40);
            this.buttonSanatciKayitEt.TabIndex = 16;
            this.buttonSanatciKayitEt.UseVisualStyleBackColor = true;
            this.buttonSanatciKayitEt.Click += new System.EventHandler(this.buttonSanatciKayitEt_Click);
            // 
            // FormSanatciEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(300, 250);
            this.Controls.Add(this.buttonSanatciKayitEt);
            this.Controls.Add(this.labelKayitDogrulama);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxUlke);
            this.Controls.Add(this.textBoxSanatciAdi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panelTop);
            this.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(300, 250);
            this.MinimumSize = new System.Drawing.Size(300, 250);
            this.Name = "FormSanatciEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SanatciEkle";
            this.Load += new System.EventHandler(this.FormSanatciEkle_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label labelSanatciEkle;
        private System.Windows.Forms.Button buttonSanatciEkleExit;
        private System.Windows.Forms.ComboBox comboBoxUlke;
        private System.Windows.Forms.TextBox textBoxSanatciAdi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelKayitDogrulama;
        private System.Windows.Forms.Button buttonSanatciKayitEt;
    }
}