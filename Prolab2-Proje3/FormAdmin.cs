using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prolab2_Proje3
{
    public partial class FormAdmin : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath.ToString() + "Veritabani.mdf;Integrated Security=True");
        public FormAdmin()
        {
            InitializeComponent();
        }

        bool Dragging = false;
        int mouseX = 0, mouseY = 0;

        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            Dragging = true;
            mouseX = Cursor.Position.X - this.Left;
            mouseY = Cursor.Position.Y - this.Top;
        }

        private void panelTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (Dragging)
            {
                this.Top = (int)(Cursor.Position.Y - mouseY);
                this.Left = (int)(Cursor.Position.X - mouseX);
            }
        }

        private void buttonLoginExit_Click(object sender, EventArgs e)
        {
            FromLogin loginForm = new FromLogin();
            loginForm.Show();
            this.Close();
        }

        private void checkBoxUyeAdminEkran_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxUyeAdminEkran.Checked)
            {
                checkBoxUyeAdminEkran.ForeColor = Color.FromArgb(5, 17, 28);
                checkBoxUyeAdminEkran.Text = "Üye Ol";
                checkBoxUyeAdminEkran.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 235, 77);
                checkBoxUyeAdminEkran.FlatAppearance.CheckedBackColor = Color.FromArgb(255, 235, 77);
                checkBoxUyeAdminEkran.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 235, 77);
                panelAdminUyeGiris.Visible = false;
                panelAdminKayitOl.Visible = true;
            }
            else
            {
                checkBoxUyeAdminEkran.ForeColor = Color.FromArgb(255, 235, 77);
                checkBoxUyeAdminEkran.Text = "Giriş Yap";
                checkBoxUyeAdminEkran.FlatAppearance.MouseDownBackColor = Color.FromArgb(5, 17, 28);
                checkBoxUyeAdminEkran.FlatAppearance.MouseOverBackColor = Color.FromArgb(5, 17, 28);
                checkBoxUyeAdminEkran.FlatAppearance.CheckedBackColor = Color.FromArgb(5, 17, 28);
                panelAdminUyeGiris.Visible = true;
                panelAdminKayitOl.Visible = false;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {

            
                // Admin Girişi
                if (!textBoxLoginAdminKullaniciAdi.Text.Equals("") && !textBoxLoginAdminSifre.Text.Equals(""))
                {
                        SqlCommand cmd = new SqlCommand("Select * From Adminler Where adminAdi='" + textBoxLoginAdminKullaniciAdi.Text + "' and sifre='" + textBoxLoginAdminSifre.Text + "'", baglanti);
                        baglanti.Open();
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (!dr.HasRows)
                        {
                            labelAdminDogrulama.Text = "Yönetici Adı ve/veya Şifre Yanlış!";
                            labelAdminDogrulama.Visible = true;
                        }
                        else
                        {
                            FormUygulamaEkrani uygulamaEkrani = new FormUygulamaEkrani();
                            while (dr.Read())
                            {
                                uygulamaEkrani.adminGirisi = true;
                                uygulamaEkrani.adminId = Convert.ToInt32(dr[0]);
                                uygulamaEkrani.adminAdi = Convert.ToString(dr[1]);
                                uygulamaEkrani.adminSifre = Convert.ToString(dr[2]);
                        
                            }
                            uygulamaEkrani.Show();
                            this.Visible = false;
                        }
                
                }
                else
                {
                    labelAdminDogrulama.Text = "Gerekli Alanları Doldurun!";
                    labelAdminDogrulama.Visible = true;
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void buttonAdminKayitOl_Click(object sender, EventArgs e)
        {
            // Yönetici Ekleme
            if (!textBoxAdminUyeOlKullaniciAdi.Text.Equals(String.Empty) && !textBoxAdminUyeOlSifre.Text.Equals(String.Empty))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO Adminler (adminAdi,sifre) VALUES ('" + textBoxAdminUyeOlKullaniciAdi.Text + "', '" + textBoxAdminUyeOlSifre.Text + "')", baglanti);
                    baglanti.Open();
                    cmd.ExecuteNonQuery();
                    labelAdminDogrulama.Text = "Kayıt Başarılı";
                    textBoxAdminUyeOlKullaniciAdi.Text = "";
                    textBoxAdminUyeOlSifre.Text = "";
                    labelAdminDogrulama.Visible = true;
                }
                catch (Exception hata)
                {

                    MessageBox.Show(hata.Message);
                }
                finally
                {
                    baglanti.Close();
                }
            }
            else
            {
                labelAdminDogrulama.Text = "Gerekli Alanları Doldurun!";
                labelAdminDogrulama.Visible = true;
            }


        }

        private void panelTop_MouseUp(object sender, MouseEventArgs e)
        {
            Dragging = false;
        }
    }
}
