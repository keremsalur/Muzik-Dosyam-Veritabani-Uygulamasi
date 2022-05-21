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
    public partial class FormKullaniciBilgileriGuncelle : Form
    {
        public FormKullaniciBilgileriGuncelle()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath.ToString() + "Veritabani.mdf;Integrated Security=True");

        bool Dragging = false;
        int mouseX = 0, mouseY = 0;

        public string kullaniciAdi, kullaniciSifre, kullaniciEmail;
        public bool abonelikTuru, odendi;
        public int ulkelerId,kullaniciId;

        private void FormKullaniciBilgileriGuncelle_Load(object sender, EventArgs e)
        {

            comboBoxUlke.Items.Clear();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Ulkeler", baglanti);
            try
            {
                baglanti.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    comboBoxUlke.Items.Add(Convert.ToString(dr[1]));
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

            textBoxGuncelleKullaniciAdi.Text = kullaniciAdi;
            textBoxGuncelleEmail.Text = kullaniciEmail;
            textBoxGuncelleSifre.Text = kullaniciSifre;
            checkBoxVIP.Checked = abonelikTuru;
            comboBoxUlke.SelectedIndex = ulkelerId - 1;
        }

        private void panelTop_MouseUp(object sender, MouseEventArgs e)
        {
            Dragging = false;
        }

        private void panelTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (Dragging)
            {
                this.Top = (int)(Cursor.Position.Y - mouseY);
                this.Left = (int)(Cursor.Position.X - mouseX);
            }
        }

        private void buttonSarkiEkleExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            if (!textBoxGuncelleKullaniciAdi.Text.Equals(String.Empty) && !textBoxGuncelleSifre.Text.Equals(String.Empty) && !textBoxGuncelleEmail.Text.Equals(String.Empty))
            {
                // Kullanici Bİlgileri Guncelleme
                int abonelik = (checkBoxVIP.Checked) ? 1 : 0;
                try
                {
                    SqlCommand cmd = new SqlCommand("UPDATE Kullanicilar SET kullaniciAdi = '" + textBoxGuncelleKullaniciAdi.Text + "', email = '" + textBoxGuncelleEmail.Text + "', sifre = '" + textBoxGuncelleSifre.Text + "', abonelikTuru = " + abonelik + ", odeme = " + abonelik + ", Ulkeler_Id = " + (comboBoxUlke.SelectedIndex + 1) + "  WHERE Id = " + kullaniciId,baglanti);
                    baglanti.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception hata)
                {
                    MessageBox.Show(hata.Message);
                }
                finally
                {
                    baglanti.Close();
                }
                labelDogrulama.Text = "Güncelleme Başarılı";
                labelDogrulama.Visible = true;
            }
            else
            {
                labelDogrulama.Text = "Gerekli Alanları Dondurun";
                labelDogrulama.Visible = true;
            }
        }

        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            Dragging = true;
            mouseX = Cursor.Position.X - this.Left;
            mouseY = Cursor.Position.Y - this.Top;
        }
    }
}
