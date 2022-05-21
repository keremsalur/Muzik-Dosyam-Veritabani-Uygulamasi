using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Prolab2_Proje3
{
    public partial class FromLogin : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath.ToString() + "Veritabani.mdf;Integrated Security=True");
        public FromLogin()
        {
            InitializeComponent();
        }

        private void buttonLoginExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        bool Dragging = false;
        int mouseX = 0,mouseY= 0;
        private void panelLoginBar_MouseDown(object sender, MouseEventArgs e)
        {
            Dragging = true;
            mouseX = Cursor.Position.X - this.Left;
            mouseY = Cursor.Position.Y - this.Top;
        }

        private void panelLoginBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (Dragging)
            {
                this.Top = (int)(Cursor.Position.Y - mouseY);
                this.Left = (int)(Cursor.Position.X - mouseX);
            }
        }

        private void buttonAdminLogin_Click(object sender, EventArgs e)
        {
            FormAdmin adminForm = new FormAdmin();
            adminForm.Show();
            this.Visible = false;
            //this.Close();
        }

        private void panelLoginBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelLogin_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                //Kullanıcı Girişi
                if (!textBoxLoginKullaniciAdi.Text.Equals("") && !textBoxLoginSifre.Text.Equals(""))
                {
                    SqlCommand cmd = new SqlCommand("Select * From Kullanicilar Where kullaniciAdi='" + textBoxLoginKullaniciAdi.Text + "' and sifre='" + textBoxLoginSifre.Text + "'", baglanti);
                    baglanti.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (!dr.HasRows)
                    {
                        labelDogrulama.Text = "Kullancı Adı ve/veya Şifre Yanlış!";
                        labelDogrulama.Visible = true;
                    }
                    else
                    {
                        FormUygulamaEkrani uygulamaEkrani = new FormUygulamaEkrani();
                        while (dr.Read())
                        {
                            uygulamaEkrani.adminGirisi = false;
                            uygulamaEkrani.kullaniciId = Convert.ToInt32(dr[0]);
                            uygulamaEkrani.kullaniciAdi = Convert.ToString(dr[1]);
                            uygulamaEkrani.kullaniciEmail = Convert.ToString(dr[2]);
                            uygulamaEkrani.kullaniciSifre = Convert.ToString(dr[3]);
                            uygulamaEkrani.kullaniciVIP = Convert.ToBoolean(dr[4]);
                            uygulamaEkrani.kullaniciUlkeId = Convert.ToInt32(dr[5]);
                        }
                        uygulamaEkrani.Show();
                        this.Visible = false;
                    }
                }
                else
                {
                    labelDogrulama.Text = "Gerekli Alanları Doldurun!";
                    labelDogrulama.Visible = true;
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBoxUyeEkran_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxUyeEkran.Checked)
            {
                checkBoxUyeEkran.ForeColor = Color.FromArgb(5, 17, 28);
                checkBoxUyeEkran.Text = "Üye Ol";
                checkBoxUyeEkran.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 235, 77);
                checkBoxUyeEkran.FlatAppearance.CheckedBackColor = Color.FromArgb(255, 235, 77);
                checkBoxUyeEkran.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 235, 77);
                panelGirisYap.Visible = false;
                panelUyeOl.Visible = true;
                labelDogrulama.Visible = false;
            }
            else
            {
                checkBoxUyeEkran.ForeColor = Color.FromArgb(255, 235, 77);
                checkBoxUyeEkran.Text = "Giriş Yap";
                checkBoxUyeEkran.FlatAppearance.MouseDownBackColor = Color.FromArgb(5, 17, 28);
                checkBoxUyeEkran.FlatAppearance.MouseOverBackColor = Color.FromArgb(5, 17, 28);
                checkBoxUyeEkran.FlatAppearance.CheckedBackColor = Color.FromArgb(5, 17, 28);
                panelGirisYap.Visible = true;
                panelUyeOl.Visible = false;
                labelDogrulama.Visible = false;
            }
        }

        private void panelUyeOl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBoxVIP_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxVIP.Checked)
            {
                checkBoxVIP.ForeColor = Color.FromArgb(5, 17, 28);
                checkBoxVIP.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 235, 77);
                checkBoxVIP.FlatAppearance.CheckedBackColor = Color.FromArgb(255, 235, 77);
                checkBoxVIP.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 235, 77);
            }
            else
            {
                checkBoxVIP.ForeColor = Color.FromArgb(255, 235, 77);
                checkBoxVIP.FlatAppearance.MouseDownBackColor = Color.FromArgb(5, 17, 28);
                checkBoxVIP.FlatAppearance.MouseOverBackColor = Color.FromArgb(5, 17, 28);
                checkBoxVIP.FlatAppearance.CheckedBackColor = Color.FromArgb(5, 17, 28);
            }
        }
        
        private void FromLogin_Load(object sender, EventArgs e)
        {

            // Ülkeleri Listeleme
            comboBoxUlke.Items.Clear();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Ulkeler",baglanti);
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

            comboBoxUlke.SelectedIndex = 0;
        }

        int idCekme(SqlCommand cmd)
        {
            int id = -1;
            try
            {
                baglanti.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    id = Convert.ToInt32(dr[0]);
                    break;
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
            return id;
        }

        private void buttonKayitOl_Click(object sender, EventArgs e)
        {
            //Kullanici Kaydı
            if (!textBoxUyeOlKullaniciAdi.Text.Equals(String.Empty) && !textBoxUyeOlSifre.Text.Equals(String.Empty) && !textBoxUyeEkleEmail.Text.Equals(String.Empty))
            {
                try
                {
                    //Kullanıcı Ekleme
                    int abonelik = (checkBoxVIP.Checked) ? 1 : 0;
                    int kullaniciId, kullaniciPopListesi, kullaniciJazzListesi, kullaniciKlasikListesi, kullaniciRapListesi, kullaniciRockListesi;
                    SqlCommand cmdKullaniciEkle = new SqlCommand("INSERT INTO Kullanicilar (kullaniciAdi,email,sifre,abonelikTuru,odeme,Ulkeler_Id) VALUES ('"+textBoxUyeOlKullaniciAdi.Text+ "', '" + textBoxUyeEkleEmail.Text + "', '" + textBoxUyeOlSifre.Text + "', " + abonelik + ", " + abonelik + ", " + (comboBoxUlke.SelectedIndex + 1) + " )", baglanti);
                    baglanti.Open();
                    cmdKullaniciEkle.ExecuteNonQuery();
                    baglanti.Close();

                    kullaniciId = idCekme(new SqlCommand("SELECT Id FROM Kullanicilar WHERE kullaniciAdi LIKE '%" + textBoxUyeOlKullaniciAdi.Text + "%'", baglanti));
                    //MessageBox.Show("Kullanıcı Id: " + kullaniciId.ToString());
                    // Otomatik Çalma Listeleri Ekleme (Pop, Jazz, Klasik,Rap,Rock)
                    SqlCommand cmdCalmaListesiEklePop = new SqlCommand("INSERT INTO CalmaListeleri (listeAdi) VALUES ('" + (textBoxUyeOlKullaniciAdi.Text + " Pop") + "')", baglanti);
                    SqlCommand cmdCalmaListesiEkleJazz = new SqlCommand("INSERT INTO CalmaListeleri (listeAdi) VALUES ('" + (textBoxUyeOlKullaniciAdi.Text + " Jazz") + "')", baglanti);
                    SqlCommand cmdCalmaListesiEkleKlasik = new SqlCommand("INSERT INTO CalmaListeleri (listeAdi) VALUES ('" + (textBoxUyeOlKullaniciAdi.Text + " Klasik") + "')", baglanti);
                    SqlCommand cmdCalmaListesiEkleRap = new SqlCommand("INSERT INTO CalmaListeleri (listeAdi) VALUES ('" + (textBoxUyeOlKullaniciAdi.Text + " Rap") + "')", baglanti);
                    SqlCommand cmdCalmaListesiEkleRock = new SqlCommand("INSERT INTO CalmaListeleri (listeAdi) VALUES ('" + (textBoxUyeOlKullaniciAdi.Text + " Rock") + "')", baglanti);
                    baglanti.Open();
                    cmdCalmaListesiEklePop.ExecuteNonQuery();
                    cmdCalmaListesiEkleJazz.ExecuteNonQuery();
                    cmdCalmaListesiEkleKlasik.ExecuteNonQuery();
                    cmdCalmaListesiEkleRap.ExecuteNonQuery();
                    cmdCalmaListesiEkleRock.ExecuteNonQuery();

                    baglanti.Close();
                    // Çalma Listelerini Kullanıcıya Eşleme
                    kullaniciPopListesi = idCekme(new SqlCommand("SELECT Id FROM CalmaListeleri WHERE listeAdi LIKE '%" + (textBoxUyeOlKullaniciAdi.Text + " Pop") + "%'", baglanti));
                    kullaniciJazzListesi = idCekme(new SqlCommand("SELECT Id FROM CalmaListeleri WHERE listeAdi LIKE '%" + (textBoxUyeOlKullaniciAdi.Text + " Jazz") + "%'", baglanti));
                    kullaniciKlasikListesi = idCekme(new SqlCommand("SELECT Id FROM CalmaListeleri WHERE listeAdi LIKE '%" + (textBoxUyeOlKullaniciAdi.Text + " Klasik") + "%'", baglanti));
                    kullaniciRapListesi = idCekme(new SqlCommand("SELECT Id FROM CalmaListeleri WHERE listeAdi LIKE '%" + (textBoxUyeOlKullaniciAdi.Text + " Rap") + "%'", baglanti));
                    kullaniciRockListesi = idCekme(new SqlCommand("SELECT Id FROM CalmaListeleri WHERE listeAdi LIKE '%" + (textBoxUyeOlKullaniciAdi.Text + " Rock") + "%'", baglanti));
                    

                    SqlCommand cmdKullaniciyaEslePop = new SqlCommand("INSERT INTO KullaniciCalmaListeleri (CalmaListeleri_Id,Kullanicilar_kullaniciId) VALUES (" + kullaniciPopListesi + ", "+ kullaniciId + ")", baglanti);
                    SqlCommand cmdKullaniciyaEsleJazz = new SqlCommand("INSERT INTO KullaniciCalmaListeleri (CalmaListeleri_Id,Kullanicilar_kullaniciId) VALUES (" + kullaniciJazzListesi + ", " + kullaniciId + ")", baglanti);
                    SqlCommand cmdKullaniciyaEsleKlasik = new SqlCommand("INSERT INTO KullaniciCalmaListeleri (CalmaListeleri_Id,Kullanicilar_kullaniciId) VALUES (" + kullaniciKlasikListesi + ", " + kullaniciId + ")", baglanti);
                    SqlCommand cmdKullaniciyaEsleRap = new SqlCommand("INSERT INTO KullaniciCalmaListeleri (CalmaListeleri_Id,Kullanicilar_kullaniciId) VALUES (" + kullaniciRapListesi + ", " + kullaniciId + ")", baglanti);
                    SqlCommand cmdKullaniciyaEsleRock = new SqlCommand("INSERT INTO KullaniciCalmaListeleri (CalmaListeleri_Id,Kullanicilar_kullaniciId) VALUES (" + kullaniciRockListesi + ", " + kullaniciId + ")", baglanti);

                    //Takiplesme Listelerini Ekleme
                    SqlCommand cmdkullaniciTakipEt = new SqlCommand("INSERT INTO TakiplesmeTakipEden (Kullanicilar_kullanici_Id) VALUES(" + kullaniciId + ")", baglanti);
                    SqlCommand cmdkullaniciTakipEdilen = new SqlCommand("INSERT INTO TakiplesmeTakipEdilen (Kullanicilar_kullanici_Id) VALUES(" + kullaniciId + ")", baglanti);

                    baglanti.Open();
                    cmdKullaniciyaEslePop.ExecuteNonQuery();
                    cmdKullaniciyaEsleJazz.ExecuteNonQuery();
                    cmdKullaniciyaEsleKlasik.ExecuteNonQuery();
                    cmdKullaniciyaEsleRap.ExecuteNonQuery();
                    cmdKullaniciyaEsleRock.ExecuteNonQuery();
                    cmdkullaniciTakipEt.ExecuteNonQuery();
                    cmdkullaniciTakipEdilen.ExecuteNonQuery();


                    labelDogrulama.Text = "Kayıt Başarılı";
                    textBoxUyeOlKullaniciAdi.Text = "";
                    textBoxUyeEkleEmail.Text = "";
                    textBoxUyeOlSifre.Text = "";
                    checkBoxVIP.Checked = false;
                    abonelik = 0;
                    comboBoxUlke.SelectedIndex = 0;
                    labelDogrulama.Visible = true;
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
                labelDogrulama.Text = "Gerekli Alanları Doldurun!";
                labelDogrulama.Visible = true;
            }
        }

        private void comboBoxUlke_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxVIP_Click(object sender, EventArgs e)
        {
            if (checkBoxVIP.Checked)
            {
                DialogResult sonuc = MessageBox.Show("Ödeme Yapıldı", "Ödeme Kontrol", MessageBoxButtons.YesNo);
                if (sonuc == DialogResult.Yes)
                {
                    checkBoxVIP.Checked = true;
                }
                else
                {
                    checkBoxVIP.Checked = false;
                }
            }
            
        }

        private void panelLoginBar_MouseUp(object sender, MouseEventArgs e)
        {
            Dragging = false;
        }
    }
}
