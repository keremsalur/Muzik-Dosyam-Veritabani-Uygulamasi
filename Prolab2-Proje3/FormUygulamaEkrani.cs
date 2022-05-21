using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prolab2_Proje3
{
    public partial class FormUygulamaEkrani : Form
    {

        SqlConnection baglanti = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename="+Application.StartupPath.ToString()+"Veritabani.mdf;Integrated Security=True");

        public bool adminGirisi;

        public int adminId;
        public string adminAdi;
        public string adminSifre;

        public int kullaniciId;
        public bool kullaniciVIP;
        public string kullaniciAdi;
        public string kullaniciSifre;
        public string kullaniciEmail;
        public int kullaniciUlkeId;

        int secilenAlbumId = 0, secilenCalmaListesiId = 0,secilenTakipEdilenKullaniciId = 0,secilenTakipEdilenKullaniciCalmaListesiId = 0,secilenOtomatikCalmaListesiId = 0,secilenSanatciId = 0,secilenSarkiId = 0, secilenSarkiDinlenmeSayisi = 0;

        enum ButonTuru
        {
            Ekle,Edit,Sil,TakipEt,TakiptenCikar,ListeyeEkle,ListedenCikar,AdminDuzenle,AdminSil
        }

        enum PanelTuru
        {
            BireyselCalmaListesi,GenelCalmaListesi,Albumler,Sanatcilar,Takipciler,TumKullanıcılar,Sarkilar,TakipEdilenKullaniciCalmaListesi
        }

        enum ResimTuru
        {
            KullaniciResim, AlbumResim, SanatciResim,ListeResim,BosResim
        }

        enum MuzikTuru
        {
            Bos,Pop, Jazz,Klasik,Rap,Rock
        }

        private void AdminDuzenle_Click(object sender, EventArgs e)
        {
            Control adminDuzenlePanel = ((Control)sender);
            string adminİslemTuru = adminDuzenlePanel.Name.Split('-')[0].ToString();
            string adminİslemYapılacakId = adminDuzenlePanel.Name.Split('-')[1].ToString();
            if (adminİslemTuru.Equals("kullaniciAdminDuzenleButon"))
            {
                // Kullanıcı Bilgileri Güncelleme
                try
                {
                    FormKullaniciBilgileriGuncelle formKBG = new FormKullaniciBilgileriGuncelle();
                    baglanti.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Kullanicilar WHERE Id = " + adminİslemYapılacakId, baglanti);
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        formKBG.abonelikTuru = Convert.ToBoolean(dr[4]);
                        formKBG.odendi = Convert.ToBoolean(dr[5]);
                        formKBG.kullaniciAdi = Convert.ToString(dr[1]);
                        formKBG.kullaniciEmail = Convert.ToString(dr[2]);
                        formKBG.kullaniciSifre = Convert.ToString(dr[3]);
                        formKBG.kullaniciId = Convert.ToInt32(dr[0]);
                        formKBG.ulkelerId = Convert.ToInt32(dr[6]);
                    }
                    baglanti.Close();
                    formKBG.ShowDialog();
                    TumKullanicilariGoster();
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
            else if (adminİslemTuru.Equals("sanatciAdminDuzenleButon"))
            {
                // Sanatcı Bilgileri Güncelleme
                try
                {
                    FormSanatciEkle formSE = new FormSanatciEkle();
                    baglanti.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Sanatcilar WHERE Id = " + adminİslemYapılacakId, baglanti);
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        formSE.sanatciId = Convert.ToInt32(dr[0]);
                        formSE.sanatciAdi = Convert.ToString(dr[1]);
                        formSE.sanatciUlkeId = Convert.ToInt32(dr[2]);
                    }
                    baglanti.Close();
                    formSE.ShowDialog();
                    SanatcilariGoster();
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
            else if (adminİslemTuru.Equals("albumAdminDuzenleButon"))
            {
                // Albüm Bilgileri Güncelleme
                try
                {
                    FormAlbumEkle formAE = new FormAlbumEkle();
                    baglanti.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Albumler WHERE Id = " + adminİslemYapılacakId, baglanti);
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        formAE.albumId = Convert.ToInt32(dr[0]);
                        formAE.albumAdi = Convert.ToString(dr[1]);
                        formAE.albumTarihi = Convert.ToDateTime(dr[2]);
                        formAE.albumTuruId = Convert.ToInt32(dr[3]);
                    }
                    baglanti.Close();
                    formAE.ShowDialog();
                    AlbumleriGoster();
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
            else if (adminİslemTuru.Equals("sarkiAdminDuzenleButon"))
            {
                // Şarkı Bilgileri Güncelleme
                try
                {
                    FormSarkiEkle formSE = new FormSarkiEkle();
                    baglanti.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Sarkilar WHERE Id = " + adminİslemYapılacakId, baglanti);
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        formSE.sarkiId = Convert.ToInt32(dr[0]);
                        formSE.turId = Convert.ToInt32(dr[5]);
                        formSE.sarkiAdi = Convert.ToString(dr[1]);
                        formSE.sarkiTarih = Convert.ToDateTime(dr[4]);
                    }
                    baglanti.Close();
                    formSE.ShowDialog();
                    SarkilariGoster();
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




        }
        private void AdminSil_Click(object sender, EventArgs e)
        {
            Control adminSilPanel = ((Control)sender);
            string adminİslemTuru = adminSilPanel.Name.Split('-')[0].ToString();
            string adminİslemYapılacakId = adminSilPanel.Name.Split('-')[1].ToString();
            if (adminİslemTuru.Equals("kullaniciAdminSilButon"))
            {
                DialogResult sonuc = MessageBox.Show("Silmek istediğinize emin misiniz?", "Silmek", MessageBoxButtons.YesNo);
                if (sonuc == DialogResult.Yes)
                {
                    // Kullanıcıyı Sil
                    try
                    {
                        baglanti.Open();
                        SqlCommand cmd = new SqlCommand("DELETE FROM Kullanicilar WHERE Id = " + adminİslemYapılacakId, baglanti);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Kullanıcı Silindi!");
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
                TumKullanicilariGoster();
            }
            else if (adminİslemTuru.Equals("sanatciAdminSilButon"))
            {
                
                DialogResult sonuc = MessageBox.Show("Silmek istediğinize emin misiniz?", "Silmek", MessageBoxButtons.YesNo);
                if (sonuc == DialogResult.Yes)
                {
                    // Sanatcı Sil
                    try
                    {
                        baglanti.Open();
                        SqlCommand cmd = new SqlCommand("DELETE FROM Sanatcilar WHERE Id = " + adminİslemYapılacakId, baglanti);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Sanatcı Silindi!");
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
                SanatcilariGoster();
            }
            else if (adminİslemTuru.Equals("albumAdminSilButon"))
            {
                DialogResult sonuc = MessageBox.Show("Silmek istediğinize emin misiniz?", "Silmek", MessageBoxButtons.YesNo);
                if (sonuc == DialogResult.Yes)
                {
                    // Album Sil
                    try
                    {
                        baglanti.Open();
                        SqlCommand cmd = new SqlCommand("DELETE FROM Albumler WHERE Id = " + adminİslemYapılacakId, baglanti);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Album Silindi!");
                    }
                    catch (Exception hata)
                    {
                        MessageBox.Show(hata.Message);
                    }
                    finally
                    {
                        baglanti.Close();
                    }
                    AlbumleriGoster();
                }
            }
            else if (adminİslemTuru.Equals("sarkiAdminSilButon"))
            {
                DialogResult sonuc = MessageBox.Show("Silmek istediğinize emin misiniz?", "Silmek", MessageBoxButtons.YesNo);
                if (sonuc == DialogResult.Yes)
                {
                    // Şarkı Sil
                    try
                    {
                        baglanti.Open();
                        SqlCommand cmd = new SqlCommand("DELETE FROM Sarkilar WHERE Id = " + adminİslemYapılacakId, baglanti);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Şarki Silindi!");
                    }
                    catch (Exception hata)
                    {
                        MessageBox.Show(hata.Message);
                    }
                    finally
                    {
                        baglanti.Close();
                    }
                    SarkilariGoster();
                }
            }

        }



        void ButonEkle(Control sahibi, Point konum, ButonTuru turu, string panelAdi)
        {
            // butonTuru -> 0 : ekle, 1 : edit, 2 : sil, takipEt, TakiptenÇıkar, Listeye Ekle Listeden Çıkar

            Panel yoneticiButonPanel = new Panel();
            yoneticiButonPanel.Name = panelAdi;
            yoneticiButonPanel.Size = new Size(20, 20);
            yoneticiButonPanel.BackColor = Color.FromArgb(5, 17, 28);
            yoneticiButonPanel.Parent = sahibi;
            yoneticiButonPanel.BackgroundImageLayout = ImageLayout.Zoom;
            switch (turu)
            {
                case ButonTuru.Ekle:
                    yoneticiButonPanel.BackgroundImage = Image.FromFile(".\\Resimler\\ekle.png");
                    break;
                case ButonTuru.Edit:
                    yoneticiButonPanel.BackgroundImage = Image.FromFile(".\\Resimler\\edit.png");
                    break;
                case ButonTuru.Sil:
                    yoneticiButonPanel.BackgroundImage = Image.FromFile(".\\Resimler\\sil.png");
                    break;
                case ButonTuru.TakipEt:
                    yoneticiButonPanel.BackgroundImage = Image.FromFile(".\\Resimler\\takipEt.png");
                    yoneticiButonPanel.Click += new EventHandler(panelKullaniciTakipEt_Click);
                    break;
                case ButonTuru.TakiptenCikar:
                    yoneticiButonPanel.BackgroundImage = Image.FromFile(".\\Resimler\\takiptenCikar.png");
                    yoneticiButonPanel.Click += new EventHandler(panelKullaniciTakipdenCikar_Click);
                    break;
                case ButonTuru.ListeyeEkle:
                    yoneticiButonPanel.BackgroundImage = Image.FromFile(".\\Resimler\\ekle.png");
                    yoneticiButonPanel.Click += new EventHandler(CalmaListesineSarkiEkle_Click);
                    break;
                case ButonTuru.ListedenCikar:
                    yoneticiButonPanel.BackgroundImage = Image.FromFile(".\\Resimler\\sil.png");
                    yoneticiButonPanel.Click += new EventHandler(CalmaListesindenSarkiCikar_Click);
                    break;
                case ButonTuru.AdminDuzenle:
                    yoneticiButonPanel.BackgroundImage = Image.FromFile(".\\Resimler\\edit.png");
                    yoneticiButonPanel.Click += new EventHandler(AdminDuzenle_Click);
                    break;
                case ButonTuru.AdminSil:
                    yoneticiButonPanel.BackgroundImage = Image.FromFile(".\\Resimler\\sil.png");
                    yoneticiButonPanel.Click += new EventHandler(AdminSil_Click);
                    break;
                default:
                    yoneticiButonPanel.BackgroundImage = null;
                    break;
            }
            yoneticiButonPanel.Location = konum;
            sahibi.Controls.Add(yoneticiButonPanel);
        }

        void AlbumleriGoster()
        {
            panelAlbumler.Controls.Clear();

            try
            {
                int konumX = 10, konumY = 10;
                baglanti.Open();
                SqlCommand cmd = new SqlCommand(" SELECT * FROM Albumler ORDER BY albumAdi", baglanti);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (konumX > 550)
                    {
                        konumY += 125;
                        konumX = 10;
                    }
                    PanelEkle(panelAlbumler, "panelAlbum-" + Convert.ToString(dr[0]), new Point(konumX, konumY), PanelTuru.Albumler, Convert.ToString(dr[1]), adminGirisi, Convert.ToString(dr[2]),Convert.ToInt32(dr[3]));
                    if (adminGirisi)
                    {
                        // Admin Girişi Olduysa
                        ButonEkle(panelAlbumler.Controls.Find("panelAlbum-" + Convert.ToString(dr[0]), false)[0], new Point(10, 10), ButonTuru.AdminDuzenle, "albumAdminDuzenleButon-" + Convert.ToInt32(dr[0]).ToString());
                        ButonEkle(panelAlbumler.Controls.Find("panelAlbum-" + Convert.ToString(dr[0]), false)[0], new Point(10, 35), ButonTuru.AdminSil, "albumAdminSilButon-" + Convert.ToInt32(dr[0]).ToString());
                    }
                    konumX += 135;
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

            panelAlbumler.Refresh();
        }
        void SanatcilariGoster()
        {
            panelSanatcilar.Controls.Clear();

            try
            {
                int konumX = 10, konumY = 10;
                baglanti.Open();
                SqlCommand cmd = new SqlCommand(" SELECT S.Id, S.sanatciAdi, U.ulkeAdi FROM Sanatcilar as S, Ulkeler as U WHERE S.Ulkeler_Id = U.Id ORDER BY S.sanatciAdi", baglanti);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (konumX > 550)
                    {
                        konumY += 125;
                        konumX = 10;
                    }
                    PanelEkle(panelSanatcilar, "panelSanatci-" + Convert.ToString(dr[0]), new Point(konumX, konumY), PanelTuru.Sanatcilar, Convert.ToString(dr[1]), adminGirisi, Convert.ToString(dr[2]));
                    if (adminGirisi)
                    {
                        // Admin Girişi Olduysa
                        ButonEkle(panelSanatcilar.Controls.Find("panelSanatci-" + Convert.ToString(dr[0]), false)[0], new Point(10, 10), ButonTuru.AdminDuzenle, "sanatciAdminDuzenleButon-" + Convert.ToInt32(dr[0]).ToString());
                        ButonEkle(panelSanatcilar.Controls.Find("panelSanatci-" + Convert.ToString(dr[0]), false)[0], new Point(10, 35), ButonTuru.AdminSil, "sanatciAdminSilButon-" + Convert.ToInt32(dr[0]).ToString());
                    }
                    konumX += 135;
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

            panelSanatcilar.Refresh();
        }

        void CalmaListeleriniGoster()
        {
            panelCalmaListeleri.Controls.Clear();

            try
            {
                int konumX = 20, konumY = 5;
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("SELECT CL.Id, CL.listeAdi FROM CalmaListeleri as CL, KullaniciCalmaListeleri as KCL WHERE CL.Id = KCL.CalmaListeleri_Id AND KCL.Kullanicilar_kullaniciId = " + kullaniciId + "", baglanti);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    PanelEkle(panelCalmaListeleri, "panelCalmaListesi-" + Convert.ToString(dr[0]), new Point(konumX, konumY), PanelTuru.BireyselCalmaListesi, Convert.ToString(dr[1]),adminGirisi,kullaniciAdi);
                    konumY += 125;
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


            panelCalmaListeleri.Refresh();
        }

        void GenelListeleriGoster()
        {
            panelOtomatikListeler.Controls.Clear();

            // En Çok Dinlenen 10 Şarkı
            PanelEkle(panelOtomatikListeler, "panelEnCokDinlenenCalmaListesi", new Point(20, 5), PanelTuru.GenelCalmaListesi, "Top 10", adminGirisi, "Müzik Dosyam");
            // En Çok Dinlenen 10 Pop Şarkı
            PanelEkle(panelOtomatikListeler, "panelEnCokDinlenenPopListesi", new Point(20, 130), PanelTuru.GenelCalmaListesi, "Pop Top 10", adminGirisi, "Müzik Dosyam");
            // En Çok Dinlenen 10 Jazz Şarkı
            PanelEkle(panelOtomatikListeler, "panelEnCokDinlenenJazzListesi", new Point(20, 255), PanelTuru.GenelCalmaListesi, "Jazz Top 10", adminGirisi, "Müzik Dosyam");
            // En Çok Dinlenen 10 Klasik Şarkı
            PanelEkle(panelOtomatikListeler, "panelEnCokDinlenenKlasikListesi", new Point(20, 380), PanelTuru.GenelCalmaListesi, "Klasik Top 10", adminGirisi, "Müzik Dosyam");
            // En Çok Dinlenen 10 Rap Şarkı
            PanelEkle(panelOtomatikListeler, "panelEnCokDinlenenRapListesi", new Point(20, 505), PanelTuru.GenelCalmaListesi, "Rap Top 10", adminGirisi, "Müzik Dosyam");
            // En Çok Dinlenen 10 Rock Şarkı
            PanelEkle(panelOtomatikListeler, "panelEnCokDinlenenRockListesi", new Point(20, 630), PanelTuru.GenelCalmaListesi, "Rock Top 10", adminGirisi, "Müzik Dosyam");

            panelOtomatikListeler.Refresh();
        }

        void TakipEdilenleriGoster()
        {
            panelTakipEdilenKullanicilar.Controls.Clear();

            try
            {
                int konumX = 10, konumY = 10;
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("SELECT K.Id,K.kullaniciAdi FROM Kullanicilar as K, Takiplesme as T WHERE T.TakiplesmeTakipEden_Id = " + kullaniciId + " and T.TakiplesmeTakipEdilen_Id = K.Id", baglanti);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    PanelEkle(panelTakipEdilenKullanicilar, "panelTakipEdilenKullanicilar-" + Convert.ToString(dr[0]), new Point(konumX, konumY), PanelTuru.Takipciler, Convert.ToString(dr[1]), adminGirisi);
                    ButonEkle(panelTakipEdilenKullanicilar.Controls.Find("panelTakipEdilenKullanicilar-" + Convert.ToString(dr[0]), false)[0], new Point(100, 10), ButonTuru.TakiptenCikar, "kullaniciTakipdenCikarButon-" + Convert.ToInt32(dr[0]).ToString());
                    konumY += 125;
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

            panelTakipEdilenKullanicilar.Refresh();
        }
        void TakipEdilenKullanicininCalmaListeleriniGoster()
        {
            panelTakipEdilenKullaniciCalmaListeleri.Controls.Clear();
            try
            {
                int konumX = 10, konumY = 10;
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("SELECT CL.Id, CL.listeAdi FROM CalmaListeleri as CL, KullaniciCalmaListeleri as KCL WHERE CL.Id = KCL.CalmaListeleri_Id AND KCL.Kullanicilar_kullaniciId = " + secilenTakipEdilenKullaniciId + "", baglanti);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (konumX > 550)
                    {
                        konumY += 125;
                        konumX = 10;
                    }
                    PanelEkle(panelTakipEdilenKullaniciCalmaListeleri, "panelTakipEdilenKullaniciCalmaListesi-" + Convert.ToString(dr[0]), new Point(konumX, konumY), PanelTuru.TakipEdilenKullaniciCalmaListesi, Convert.ToString(dr[1]), adminGirisi);
                    konumX += 135;
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
            panelTakipEdilenKullaniciCalmaListeleri.Refresh();
        }

        void TumKullanicilariGoster()
        {
            panelTumKullanicilar.Controls.Clear();

            try
            {
                int konumX = 10, konumY = 10;
                List<int> takipEdilenKullaniciIdler = new List<int>();
                baglanti.Open();
                SqlCommand cmdTakipEdilenler = new SqlCommand("SELECT * FROM Takiplesme WHERE TakiplesmeTakipEden_Id = " + kullaniciId , baglanti);
                SqlDataReader drTakipEdilenler = cmdTakipEdilenler.ExecuteReader();
                while (drTakipEdilenler.Read())
                {
                    takipEdilenKullaniciIdler.Add(Convert.ToInt32(drTakipEdilenler[3]));
                }
                baglanti.Close();
                // Takip Edilenler
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Kullanicilar", baglanti);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (Convert.ToInt32(dr[0]) != kullaniciId && takipEdilenKullaniciIdler.IndexOf(Convert.ToInt32(dr[0])) < 0)
                    {
                        
                        PanelEkle(panelTumKullanicilar, "panelTumKullanicilar-" + Convert.ToString(dr[0]), new Point(konumX, konumY), PanelTuru.TumKullanıcılar, Convert.ToString(dr[1]), adminGirisi);
                        if (adminGirisi)
                        {
                            // Admin Girişi Olduysa
                            ButonEkle(panelTumKullanicilar.Controls.Find("panelTumKullanicilar-" + Convert.ToString(dr[0]), false)[0], new Point(10, 10), ButonTuru.AdminDuzenle, "kullaniciAdminDuzenleButon-" + Convert.ToInt32(dr[0]).ToString());
                            ButonEkle(panelTumKullanicilar.Controls.Find("panelTumKullanicilar-" + Convert.ToString(dr[0]), false)[0], new Point(10, 35), ButonTuru.AdminSil, "kullaniciAdminSilButon-" + Convert.ToInt32(dr[0]).ToString());
                        }
                        else
                        {
                            // Admin Girişi Olmadıysa
                            if (Convert.ToBoolean(dr[4]))
                            {
                                ButonEkle(panelTumKullanicilar.Controls.Find("panelTumKullanicilar-" + Convert.ToString(dr[0]), false)[0], new Point(100, 10), ButonTuru.TakipEt, "kullaniciTakipEtButon-" + Convert.ToInt32(dr[0]).ToString());
                            }
                        }
                        
                        konumY += 125;
                    }
                       
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

            panelTumKullanicilar.Refresh();
        }

        void SarkilariGoster()
        {
            panelSarkilar.Controls.Clear();
            List<int> sarkiIdler = new List<int>();
            if(secilenAlbumId != 0)
            {
                try
                {
                    int konumX = 10, konumY = 10;
                    baglanti.Open();
                    SqlCommand cmd = new SqlCommand("SELECT S.Id, S.sarkiAdi, S.yayinlanmaTarihi, S.SarkiTurleri_Id FROM Sarkilar as S, SarkiAlbum as SA WHERE SA.Albumler_Id = " + secilenAlbumId + " and SA.Sarkilar_Id = S.Id", baglanti);
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        if (konumX > 550)
                        {
                            konumY += 125;
                            konumX = 10;
                        }
                        PanelEkle(panelSarkilar, "panelSarkilar-" + Convert.ToString(dr[0]), new Point(konumX, konumY), PanelTuru.Sarkilar, Convert.ToString(dr[1]), adminGirisi,Convert.ToString(dr[2]),Convert.ToInt32(dr[3]));
                        if (adminGirisi)
                        {
                            // Admin Girişi Olduysa
                            ButonEkle(panelSarkilar.Controls.Find("panelSarkilar-" + Convert.ToString(dr[0]), false)[0], new Point(10, 10), ButonTuru.AdminDuzenle, "sarkiAdminDuzenleButon-" + Convert.ToInt32(dr[0]).ToString());
                            ButonEkle(panelSarkilar.Controls.Find("panelSarkilar-" + Convert.ToString(dr[0]), false)[0], new Point(10, 35), ButonTuru.AdminSil, "sarkiAdminSilButon-" + Convert.ToInt32(dr[0]).ToString());
                        }
                        konumX += 135;

                        sarkiIdler.Add(Convert.ToInt32(dr[0]));
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
            else if(secilenCalmaListesiId != 0)
            {
                try
                {
                    int konumX = 10, konumY = 10;
                    baglanti.Open();
                    SqlCommand cmd = new SqlCommand("SELECT S.Id, S.sarkiAdi, S.yayinlanmaTarihi, S.SarkiTurleri_Id FROM Sarkilar as S, CalmaListesiSarkilar as CLS, CalmaListeleri as CL, KullaniciCalmaListeleri as KCL, Kullanicilar as K WHERE K.Id = " + kullaniciId + " and KCL.Kullanicilar_kullaniciId = K.Id and CL.Id = " + secilenCalmaListesiId + " and CL.Id = KCL.CalmaListeleri_Id and CLS.CalmaListeleri_Id = CL.Id and CLS.Sarkilar_Id = S.Id", baglanti);
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        if (konumX > 550)
                        {
                            konumY += 125;
                            konumX = 10;
                        }
                        PanelEkle(panelSarkilar, "panelSarkilar-" + Convert.ToString(dr[0]), new Point(konumX, konumY), PanelTuru.Sarkilar, Convert.ToString(dr[1]), adminGirisi, Convert.ToString(dr[2]), Convert.ToInt32(dr[3]));
                        if (adminGirisi)
                        {
                            // Admin Girişi Olduysa
                            ButonEkle(panelSarkilar.Controls.Find("panelSarkilar-" + Convert.ToString(dr[0]), false)[0], new Point(10, 10), ButonTuru.AdminDuzenle, "sarkiAdminDuzenleButon-" + Convert.ToInt32(dr[0]).ToString());
                            ButonEkle(panelSarkilar.Controls.Find("panelSarkilar-" + Convert.ToString(dr[0]), false)[0], new Point(10, 35), ButonTuru.AdminSil, "sarkiAdminSilButon-" + Convert.ToInt32(dr[0]).ToString());
                        }
                        konumX += 135;

                        sarkiIdler.Add(Convert.ToInt32(dr[0]));
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
            else if (secilenSanatciId != 0)
            {
                try
                {
                    int konumX = 10, konumY = 10;
                    baglanti.Open();
                    SqlCommand cmd = new SqlCommand("SELECT S.Id, S.sarkiAdi, S.yayinlanmaTarihi, S.SarkiTurleri_Id FROM Sarkilar as S, Sanatcilar as Sanat, SanatciSarki as SA WHERE Sanat.Id = " + secilenSanatciId + " and SA.Sanatcilar_Id = Sanat.Id and S.Id = SA.Sarkilar_Id", baglanti);
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        if (konumX > 550)
                        {
                            konumY += 125;
                            konumX = 10;
                        }
                        PanelEkle(panelSarkilar, "panelSarkilar-" + Convert.ToString(dr[0]), new Point(konumX, konumY), PanelTuru.Sarkilar, Convert.ToString(dr[1]), adminGirisi, Convert.ToString(dr[2]), Convert.ToInt32(dr[3]));
                        if (adminGirisi)
                        {
                            // Admin Girişi Olduysa
                            ButonEkle(panelSarkilar.Controls.Find("panelSarkilar-" + Convert.ToString(dr[0]), false)[0], new Point(10, 10), ButonTuru.AdminDuzenle, "sarkiAdminDuzenleButon-" + Convert.ToInt32(dr[0]).ToString());
                            ButonEkle(panelSarkilar.Controls.Find("panelSarkilar-" + Convert.ToString(dr[0]), false)[0], new Point(10, 35), ButonTuru.AdminSil, "sarkiAdminSilButon-" + Convert.ToInt32(dr[0]).ToString());
                        }
                        konumX += 135;
                        sarkiIdler.Add(Convert.ToInt32(dr[0]));
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
            else if (secilenOtomatikCalmaListesiId != 0)
            {
                if (secilenOtomatikCalmaListesiId == 1)
                {
                    try
                    {
                        int konumX = 10, konumY = 10;
                        baglanti.Open();
                        SqlCommand cmd = new SqlCommand("SELECT Id, sarkiAdi, yayinlanmaTarihi, SarkiTurleri_Id FROM Sarkilar ORDER BY dinlenmeSayisi DESC", baglanti);
                        SqlDataReader dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            if (konumX > 550)
                            {
                                konumY += 125;
                                konumX = 10;
                            }
                            PanelEkle(panelSarkilar, "panelSarkilar-" + Convert.ToString(dr[0]), new Point(konumX, konumY), PanelTuru.Sarkilar, Convert.ToString(dr[1]), adminGirisi, Convert.ToString(dr[2]), Convert.ToInt32(dr[3]));
                            if (adminGirisi)
                            {
                                // Admin Girişi Olduysa
                                ButonEkle(panelSarkilar.Controls.Find("panelSarkilar-" + Convert.ToString(dr[0]), false)[0], new Point(10, 10), ButonTuru.AdminDuzenle, "sarkiAdminDuzenleButon-" + Convert.ToInt32(dr[0]).ToString());
                                ButonEkle(panelSarkilar.Controls.Find("panelSarkilar-" + Convert.ToString(dr[0]), false)[0], new Point(10, 35), ButonTuru.AdminSil, "sarkiAdminSilButon-" + Convert.ToInt32(dr[0]).ToString());
                            }
                            konumX += 135;
                            sarkiIdler.Add(Convert.ToInt32(dr[0]));
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
                else
                {
                    try
                    {
                        int konumX = 10, konumY = 10;
                        baglanti.Open();
                        SqlCommand cmd = new SqlCommand("SELECT Id, sarkiAdi, yayinlanmaTarihi, SarkiTurleri_Id FROM Sarkilar WHERE SarkiTurleri_Id = "+ (secilenOtomatikCalmaListesiId - 1) + " ORDER BY dinlenmeSayisi DESC", baglanti);
                        SqlDataReader dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            if (konumX > 550)
                            {
                                konumY += 125;
                                konumX = 10;
                            }
                            PanelEkle(panelSarkilar, "panelSarkilar-" + Convert.ToString(dr[0]), new Point(konumX, konumY), PanelTuru.Sarkilar, Convert.ToString(dr[1]), adminGirisi, Convert.ToString(dr[2]), Convert.ToInt32(dr[3]));
                            if (adminGirisi)
                            {
                                // Admin Girişi Olduysa
                                ButonEkle(panelSarkilar.Controls.Find("panelSarkilar-" + Convert.ToString(dr[0]), false)[0], new Point(10, 10), ButonTuru.AdminDuzenle, "sarkiAdminDuzenleButon-" + Convert.ToInt32(dr[0]).ToString());
                                ButonEkle(panelSarkilar.Controls.Find("panelSarkilar-" + Convert.ToString(dr[0]), false)[0], new Point(10, 35), ButonTuru.AdminSil, "sarkiAdminSilButon-" + Convert.ToInt32(dr[0]).ToString());
                            }
                            konumX += 135;
                            sarkiIdler.Add(Convert.ToInt32(dr[0]));
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
            }
            else if (secilenTakipEdilenKullaniciCalmaListesiId != 0)
            {
                try
                {
                    int konumX = 10, konumY = 10;
                    baglanti.Open();
                    SqlCommand cmd = new SqlCommand("SELECT S.Id, S.sarkiAdi, S.yayinlanmaTarihi, S.SarkiTurleri_Id FROM Sarkilar as S, CalmaListesiSarkilar as CLS, CalmaListeleri as CL, KullaniciCalmaListeleri as KCL, Kullanicilar as K WHERE K.Id = " + secilenTakipEdilenKullaniciId + " and KCL.Kullanicilar_kullaniciId = K.Id and CL.Id = " + secilenTakipEdilenKullaniciCalmaListesiId + " and CL.Id = KCL.CalmaListeleri_Id and CLS.CalmaListeleri_Id = CL.Id and CLS.Sarkilar_Id = S.Id", baglanti);
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        if (konumX > 550)
                        {
                            konumY += 125;
                            konumX = 10;
                        }
                        PanelEkle(panelSarkilar, "panelSarkilar-" + Convert.ToString(dr[0]), new Point(konumX, konumY), PanelTuru.Sarkilar, Convert.ToString(dr[1]), adminGirisi, Convert.ToString(dr[2]), Convert.ToInt32(dr[3]));
                        if (adminGirisi)
                        {
                            // Admin Girişi Olduysa
                            ButonEkle(panelSarkilar.Controls.Find("panelSarkilar-" + Convert.ToString(dr[0]), false)[0], new Point(10, 10), ButonTuru.AdminDuzenle, "sarkiAdminDuzenleButon-" + Convert.ToInt32(dr[0]).ToString());
                            ButonEkle(panelSarkilar.Controls.Find("panelSarkilar-" + Convert.ToString(dr[0]), false)[0], new Point(10, 35), ButonTuru.AdminSil, "sarkiAdminSilButon-" + Convert.ToInt32(dr[0]).ToString());
                        }
                        konumX += 135;

                        sarkiIdler.Add(Convert.ToInt32(dr[0]));
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

            if (!adminGirisi)
            {
                try
                {
                    for (int i = 0; i < sarkiIdler.Count; i++)
                    {
                        baglanti.Open();
                        SqlCommand cmdSarkiListeKontrol = new SqlCommand("SELECT * FROM Sarkilar as S, CalmaListesiSarkilar as CLS, CalmaListeleri as CL, KullaniciCalmaListeleri as KCL, Kullanicilar as K  WHERE S.Id = " + sarkiIdler[i] + " and S.Id = CLS.Sarkilar_Id and CLS.CalmaListeleri_Id = CL.Id and CLS.CalmaListeleri_Id = KCL.CalmaListeleri_Id and KCL.Kullanicilar_kullaniciId = K.Id and K.Id = " + kullaniciId, baglanti);
                        SqlDataReader drSarkiListeKontrol = cmdSarkiListeKontrol.ExecuteReader();

                        if (drSarkiListeKontrol.HasRows)
                        {
                            // Çalma Listesinden Çıkarma Butonu
                            ButonEkle(panelSarkilar.Controls.Find("panelSarkilar-" + sarkiIdler[i], false)[0], new Point(100, 10), ButonTuru.ListedenCikar, "panelSarkilarListedenCikar-" + sarkiIdler[i].ToString());

                        }
                        else
                        {
                            // Çalma Listesine Ekle Butonu
                            ButonEkle(panelSarkilar.Controls.Find("panelSarkilar-" + sarkiIdler[i], false)[0], new Point(100, 10), ButonTuru.ListeyeEkle, "panelSarkilarListeyeEkle-" + sarkiIdler[i].ToString());
                        }
                        baglanti.Close();
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
            
            panelSarkilar.Refresh();
        }
       
        void PanelEkle(Control sahibi, string panelAdi, Point konum, PanelTuru turu, string buyukLabel,bool adminGirisi, string kucukLabel = "", int muzikTuru = 0)
        {
            // panelTuru -> 0 : Bireysel Çalma Listesi, 1 : Genel Çalma Listesi, 2 : Albumler Panel, 3 : Sanatçılar Panel, 4 : Takipciler Panel, 5 : Tum Kullanıcılar Panel
            Panel uygulamaIcıPanel = new Panel();
            uygulamaIcıPanel.Name = panelAdi;
            uygulamaIcıPanel.Size = new Size(130, 120);
            uygulamaIcıPanel.BackColor = Color.FromArgb(5, 17, 28);
            uygulamaIcıPanel.Parent = sahibi;
            uygulamaIcıPanel.BackgroundImageLayout = ImageLayout.Zoom;
            uygulamaIcıPanel.BorderStyle = BorderStyle.FixedSingle;
            uygulamaIcıPanel.Location = konum;

            Panel panelIcıResim = new Panel();
            panelIcıResim.Name = panelAdi + "-ResimPanel";
            panelIcıResim.Size = new Size(50, 50);
            panelIcıResim.Location = new Point(40, 10);
            panelIcıResim.BackColor = Color.FromArgb(5, 17, 28);
            panelIcıResim.Parent = uygulamaIcıPanel;
            panelIcıResim.BackgroundImageLayout = ImageLayout.Zoom;

            Label panelIcıBuyukLabel = new Label();
            panelIcıBuyukLabel.Name = panelAdi + "-BuyukLabel";
            panelIcıBuyukLabel.Size = new Size(130,20);
            panelIcıBuyukLabel.Location = new Point(0, 65);
            panelIcıBuyukLabel.ForeColor = Color.FromArgb(255, 235, 77);
            panelIcıBuyukLabel.BackColor = Color.FromArgb(5, 17, 28);
            panelIcıBuyukLabel.TextAlign = ContentAlignment.MiddleCenter;
            panelIcıBuyukLabel.Font = new Font("Segoe Print", 8.25f);
            panelIcıBuyukLabel.Text = buyukLabel;
            panelIcıBuyukLabel.Parent = uygulamaIcıPanel;
            uygulamaIcıPanel.Controls.Add(panelIcıBuyukLabel);

            Label panelIcıKucukLabel = new Label();
            panelIcıKucukLabel.Name = panelAdi + "-KucukLabel";
            panelIcıKucukLabel.Size = new Size(130, 20);
            panelIcıKucukLabel.Location = new Point(0, 90);
            panelIcıKucukLabel.ForeColor = Color.FromArgb(189, 198, 198);
            panelIcıKucukLabel.BackColor = Color.FromArgb(5, 17, 28);
            panelIcıKucukLabel.TextAlign = ContentAlignment.MiddleCenter;
            panelIcıKucukLabel.Font = new Font("Segoe Print", 6.0f);
            panelIcıKucukLabel.Text = kucukLabel;
            panelIcıKucukLabel.Parent = uygulamaIcıPanel;
            uygulamaIcıPanel.Controls.Add(panelIcıKucukLabel);

            switch (turu)
            {
                case PanelTuru.BireyselCalmaListesi:
                    panelIcıResim.BackgroundImage = Image.FromFile(".\\Resimler\\playlist.png");
                    uygulamaIcıPanel.Click += new EventHandler(CalmaListesiSecme_Click);
                    break;
                case PanelTuru.GenelCalmaListesi:
                    panelIcıResim.BackgroundImage = Image.FromFile(".\\Resimler\\playlist.png");
                    uygulamaIcıPanel.Click += new EventHandler(OtomatikListeGetir_Click);
                    break;
                case PanelTuru.Albumler:

                    uygulamaIcıPanel.Click += new EventHandler(AlbumSecme_Click);

                    switch (muzikTuru)
                    {
                        case 2:
                            panelIcıResim.BackgroundImage = Image.FromFile(".\\Resimler\\jazz.png");
                            break;
                        case 3:
                            panelIcıResim.BackgroundImage = Image.FromFile(".\\Resimler\\klasik.png");
                            break;
                        case 1:
                            panelIcıResim.BackgroundImage = Image.FromFile(".\\Resimler\\pop.png");
                            break;
                        case 4:
                            panelIcıResim.BackgroundImage = Image.FromFile(".\\Resimler\\rap.png");
                            break;
                        case 5:
                            panelIcıResim.BackgroundImage = Image.FromFile(".\\Resimler\\rock.png");
                            break;
                    }
                    break;
                case PanelTuru.Sarkilar:
                    uygulamaIcıPanel.Click += new EventHandler(SarkiSecme_Click);
                    switch (muzikTuru)
                    {
                        case 2:
                            panelIcıResim.BackgroundImage = Image.FromFile(".\\Resimler\\jazz.png");
                            break;
                        case 3:
                            panelIcıResim.BackgroundImage = Image.FromFile(".\\Resimler\\klasik.png");
                            break;
                        case 1:
                            panelIcıResim.BackgroundImage = Image.FromFile(".\\Resimler\\pop.png");
                            break;
                        case 4:
                            panelIcıResim.BackgroundImage = Image.FromFile(".\\Resimler\\rap.png");
                            break;
                        case 5:
                            panelIcıResim.BackgroundImage = Image.FromFile(".\\Resimler\\rock.png");
                            break;
                    }
                    break;
                case PanelTuru.Sanatcilar:
                    uygulamaIcıPanel.Click += new EventHandler(SanatciSecme_Click);
                    panelIcıResim.BackgroundImage = Image.FromFile(".\\Resimler\\erkekKucuk.png");
                    break;
                case PanelTuru.Takipciler:
                    uygulamaIcıPanel.Click += new EventHandler(takipEdilenKullaniciSecme_Click);
                    panelIcıResim.BackgroundImage = Image.FromFile(".\\Resimler\\erkekKucuk.png");
                    break;
                case PanelTuru.TumKullanıcılar:
                    panelIcıResim.BackgroundImage = Image.FromFile(".\\Resimler\\erkekKucuk.png");
                    break;
                case PanelTuru.TakipEdilenKullaniciCalmaListesi:
                    panelIcıResim.BackgroundImage = Image.FromFile(".\\Resimler\\playlist.png");
                    uygulamaIcıPanel.Click += new EventHandler(takipEdilenKullaniciCalmaListesiSecme_Click);
                    break;
            }

            uygulamaIcıPanel.Controls.Add(panelIcıResim);
            sahibi.Controls.Add(uygulamaIcıPanel);


        }

        public FormUygulamaEkrani()
        {
            InitializeComponent();
           
        }

        bool Dragging = false;
        int mouseX = 0, mouseY = 0;

        private void panelUygulamaEkraniBar_MouseDown(object sender, MouseEventArgs e)
        {
            Dragging = true;
            mouseX = Cursor.Position.X - this.Left;
            mouseY = Cursor.Position.Y - this.Top;
        }

        private void panelUygulamaEkraniBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (Dragging)
            {
                this.Top = (int)(Cursor.Position.Y - mouseY);
                this.Left = (int)(Cursor.Position.X - mouseX);
            }
        }

        private void buttonLoginExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        private void panelUygulamaEkraniBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelÇalmaListeleri_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormUygulamaEkrani_Load(object sender, EventArgs e)
        {
            if (adminGirisi)
            {
                // Yönetici
                labelUygulamaEkranHosgeldiniz.Text = "Hoşgeldin " + adminAdi;
                panelVip.BackgroundImage = Image.FromFile(".\\Resimler\\gear.png");
                panelVip.Visible = true;
                panelAdminAlbumEkle.Visible = true;
                panelAdminSanatciEkle.Visible = true;
                panelSarkiEkleBtn.Visible = true;
                TumKullanicilariGoster();//
                SanatcilariGoster();
                AlbumleriGoster();
               
            }
            else
            {
                // Kullanıcı
                labelUygulamaEkranHosgeldiniz.Text = "Hoşgeldin " + kullaniciAdi;
                panelVip.BackgroundImage = (kullaniciVIP) ? Image.FromFile(".\\Resimler\\vipLogo.png") : null;
                panelVip.Visible = true;

                TumKullanicilariGoster();
                CalmaListeleriniGoster();
                SanatcilariGoster();
                AlbumleriGoster();
                GenelListeleriGoster();
                TakipEdilenleriGoster();


            }
        }

        private void AlbumSecme_Click(object sender, EventArgs e)
        {
            Control albumPanel = ((Control)sender);
            string albumId = albumPanel.Name.Split('-')[1].ToString();
            string albumAdi = albumPanel.Controls.Find(albumPanel.Name.ToString() + "-BuyukLabel",true)[0].Text;

            labelUstBaslik.Text = albumAdi;

            secilenAlbumId = Convert.ToInt32(albumId);
            secilenCalmaListesiId = 0;
            secilenSanatciId = 0;
            secilenOtomatikCalmaListesiId = 0;

            panelAlbumlereDonBtn.Visible = true;
            panelAlbumler.SendToBack();
            panelSarkilar.BringToFront();
            SarkilariGoster();
            panelTakipEdilenKullanicilar.BringToFront();

            
            //MessageBox.Show(albumAdi);
        }

        private void SarkiSecme_Click(object sender, EventArgs e)
        {
            Control sarkiPanel = ((Control)sender);
            string sarkiId = sarkiPanel.Name.Split('-')[1].ToString();
            secilenSarkiId = Convert.ToInt32(sarkiId);
            

            labelSarkiAdi.Text = "";
            labelSarkiDinlenmeSayisi.Text = "";
            labelSarkiSanatcilar.Text = "";
            labelSarkiSuresi.Text = "";
            panelSarkiResim.BackgroundImage = null;
            // Şarkı Özelliklerini Çekme

            try
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("SELECT S.Id, S.sarkiAdi, S.sure, S.dinlenmeSayisi, S.SarkiTurleri_Id, Sanat.sanatciAdi FROM Sarkilar as S, SanatciSarki as SA, Sanatcilar as Sanat WHERE S.Id = " + Convert.ToInt32(sarkiId) + " and SA.Sarkilar_Id = S.Id and SA.Sanatcilar_Id = Sanat.Id", baglanti);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    labelSarkiAdi.Text = Convert.ToString(dr[1]);
                    labelSarkiDinlenmeSayisi.Text = "Dinlenme Sayısı: " + Convert.ToString(dr[3]);
                    secilenSarkiDinlenmeSayisi = Convert.ToInt32(dr[3]);
                    labelSarkiSanatcilar.Text += " " + Convert.ToString(dr[5]);
                    labelSarkiSuresi.Text = Convert.ToString(dr[2]);
                    switch (Convert.ToInt32(dr[4]))
                    {

                        case 2:
                            panelSarkiResim.BackgroundImage = Image.FromFile(".\\Resimler\\jazz.png");
                            break;
                        case 3:
                            panelSarkiResim.BackgroundImage = Image.FromFile(".\\Resimler\\klasik.png");
                            break;
                        case 1:
                            panelSarkiResim.BackgroundImage = Image.FromFile(".\\Resimler\\pop.png");
                            break;
                        case 4:
                            panelSarkiResim.BackgroundImage = Image.FromFile(".\\Resimler\\rap.png");
                            break;
                        case 5:
                            panelSarkiResim.BackgroundImage = Image.FromFile(".\\Resimler\\rock.png");
                            break;
                    }
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

        private void SanatciSecme_Click(object sender, EventArgs e)
        {
            Control sanatciPanel = ((Control)sender);
            string sanatciId = sanatciPanel.Name.Split('-')[1].ToString();
            string sanatciAdi = sanatciPanel.Controls.Find(sanatciPanel.Name.ToString() + "-BuyukLabel", true)[0].Text;
            labelUstBaslik.Text = sanatciAdi;

            secilenSanatciId = Convert.ToInt32(sanatciId);
            secilenCalmaListesiId = 0;
            secilenAlbumId = 0;
            secilenOtomatikCalmaListesiId = 0;

            panelAlbumlereDonBtn.Visible = true;
            panelAlbumler.SendToBack();
            panelSarkilar.BringToFront();
            SarkilariGoster();
            panelTakipEdilenKullanicilar.BringToFront();

        }

        private void CalmaListesiSecme_Click(object sender, EventArgs e)
        {
            Control calmaListesiPanel = ((Control)sender);
            string calmaListesiId = calmaListesiPanel.Name.Split('-')[1].ToString();
            string calmaListesiAdi = calmaListesiPanel.Controls.Find(calmaListesiPanel.Name.ToString() + "-BuyukLabel", true)[0].Text;

            labelUstBaslik.Text = calmaListesiAdi;

            secilenCalmaListesiId = Convert.ToInt32(calmaListesiId);
            secilenSanatciId = 0;
            secilenAlbumId = 0;
            secilenOtomatikCalmaListesiId = 0;

            panelAlbumlereDonBtn.Visible = true;
            panelAlbumler.SendToBack();
            panelSarkilar.BringToFront();
            SarkilariGoster();
            panelTakipEdilenKullanicilar.BringToFront();
        }

        private void CalmaListesineSarkiEkle_Click(object sender, EventArgs e)
        {
            Control calmaListesiSarkiEklemePanel = ((Control)sender);
            string calmaListesEklenecekSarkiId = calmaListesiSarkiEklemePanel.Parent.Name.Split('-')[1].ToString();
            string sarkiTuru = "";
            int calmaListesiId = 0;
            //SELECT ST.turAdi FROM Sarkilar as S, SarkiTurleri as ST WHERE S.Id = 12 and S.SarkiTurleri_Id = ST.Id 
            //SELECT CL.Id, CL.listeAdi FROM Kullanicilar as K, KullaniciCalmaListeleri as KCL, CalmaListeleri as CL WHERE K.Id = 11 and KCL.Kullanicilar_kullaniciId = K.Id and KCL.CalmaListeleri_Id = CL.Id and CL.listeAdi LIKE '%yavuz POP%'
            try
            {
                baglanti.Open();
                // Şarkı türü Çekme
                SqlCommand cmdSarkiTuruCek = new SqlCommand("SELECT ST.turAdi FROM Sarkilar as S, SarkiTurleri as ST WHERE S.Id = "+Convert.ToInt32(calmaListesEklenecekSarkiId)+" and S.SarkiTurleri_Id = ST.Id", baglanti);
                SqlDataReader drSarkiTuru = cmdSarkiTuruCek.ExecuteReader();
                while (drSarkiTuru.Read())
                {
                    sarkiTuru = Convert.ToString(drSarkiTuru[0]);
                }
                baglanti.Close();

                // Kullanıcının Çalma Listesini Bulma
                baglanti.Open();
                SqlCommand cmdCalmaListesiniBul = new SqlCommand("SELECT CL.Id, CL.listeAdi FROM Kullanicilar as K, KullaniciCalmaListeleri as KCL, CalmaListeleri as CL WHERE K.Id = "+kullaniciId+" and KCL.Kullanicilar_kullaniciId = K.Id and KCL.CalmaListeleri_Id = CL.Id and CL.listeAdi LIKE '%"+kullaniciAdi+" "+sarkiTuru+"%'", baglanti);
                SqlDataReader drCalmaListesiBul = cmdCalmaListesiniBul.ExecuteReader();
                while (drCalmaListesiBul.Read())
                {
                    calmaListesiId = Convert.ToInt32(drCalmaListesiBul[0]);
                }
                baglanti.Close();

                // Şarkıyi Kullanıcı Listesine Ekleme
                SqlCommand cmdSarkiyiCalmaListesineEkle = new SqlCommand("INSERT INTO CalmaListesiSarkilar (CalmaListeleri_Id,Sarkilar_Id) VALUES (" + calmaListesiId + "," + Convert.ToInt32(calmaListesEklenecekSarkiId) + ")", baglanti);
                baglanti.Open();
                cmdSarkiyiCalmaListesineEkle.ExecuteNonQuery();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
            finally
            {
                baglanti.Close();
            }

            SarkilariGoster();
        }

        private void CalmaListesindenSarkiCikar_Click(object sender, EventArgs e)
        {
            Control calmaListesiSarkiCikarPanel = ((Control)sender);
            string calmaListesiCikarilacakSarkiId = calmaListesiSarkiCikarPanel.Parent.Name.Split('-')[1].ToString();
            string sarkiTuru = "";
            int calmaListesiId = 0;
            //SELECT ST.turAdi FROM Sarkilar as S, SarkiTurleri as ST WHERE S.Id = 12 and S.SarkiTurleri_Id = ST.Id 
            //SELECT CL.Id, CL.listeAdi FROM Kullanicilar as K, KullaniciCalmaListeleri as KCL, CalmaListeleri as CL WHERE K.Id = 11 and KCL.Kullanicilar_kullaniciId = K.Id and KCL.CalmaListeleri_Id = CL.Id and CL.listeAdi LIKE '%yavuz POP%'
            try
            {
                baglanti.Open();
                // Şarkı türü Çekme
                SqlCommand cmdSarkiTuruCek = new SqlCommand("SELECT ST.turAdi FROM Sarkilar as S, SarkiTurleri as ST WHERE S.Id = " + Convert.ToInt32(calmaListesiCikarilacakSarkiId) + " and S.SarkiTurleri_Id = ST.Id", baglanti);
                SqlDataReader drSarkiTuru = cmdSarkiTuruCek.ExecuteReader();
                while (drSarkiTuru.Read())
                {
                    sarkiTuru = Convert.ToString(drSarkiTuru[0]);
                }
                baglanti.Close();

                // Kullanıcının Çalma Listesini Bulma
                baglanti.Open();
                SqlCommand cmdCalmaListesiniBul = new SqlCommand("SELECT CL.Id, CL.listeAdi FROM Kullanicilar as K, KullaniciCalmaListeleri as KCL, CalmaListeleri as CL WHERE K.Id = " + kullaniciId + " and KCL.Kullanicilar_kullaniciId = K.Id and KCL.CalmaListeleri_Id = CL.Id and CL.listeAdi LIKE '%" + kullaniciAdi + " " + sarkiTuru + "%'", baglanti);
                SqlDataReader drCalmaListesiBul = cmdCalmaListesiniBul.ExecuteReader();
                while (drCalmaListesiBul.Read())
                {
                    calmaListesiId = Convert.ToInt32(drCalmaListesiBul[0]);
                }
                baglanti.Close();

                // Şarkıyi Kullanıcı Listesinden Çıkarma
                SqlCommand cmdSarkiyiCalmaListesindenCikar = new SqlCommand("DELETE FROM CalmaListesiSarkilar WHERE CalmaListeleri_Id = " + calmaListesiId + " and Sarkilar_Id = " + calmaListesiCikarilacakSarkiId, baglanti);
                baglanti.Open();
                cmdSarkiyiCalmaListesindenCikar.ExecuteNonQuery();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
            finally
            {
                baglanti.Close();
            }

            SarkilariGoster();

            // DELETE FROM CalmaListesiSarkilar as CLS WHERE CLS.CalmaListeleri_Id = 24 and CLS.Sarkilar_Id = 12
        }

        private void OtomatikListeGetir_Click(object sender, EventArgs e)
        {
            Control otomatikCalmaListesiPanel = ((Control)sender);
            string panelAdi = otomatikCalmaListesiPanel.Name;

            if (panelAdi.Equals("panelEnCokDinlenenCalmaListesi"))
            {
                // En çok dinlelen 10 şarkı
                labelUstBaslik.Text = "Top 10";
                secilenCalmaListesiId = 0;
                secilenSanatciId = 0;
                secilenAlbumId = 0;
                secilenOtomatikCalmaListesiId = 1;
            }
            else if (panelAdi.Equals("panelEnCokDinlenenPopListesi"))
            {
                labelUstBaslik.Text = "Pop Top 10";
                secilenCalmaListesiId = 0;
                secilenSanatciId = 0;
                secilenAlbumId = 0;
                secilenOtomatikCalmaListesiId = 2;
            }
            else if (panelAdi.Equals("panelEnCokDinlenenJazzListesi"))
            {
                labelUstBaslik.Text = "Jazz Top 10";
                secilenCalmaListesiId = 0;
                secilenSanatciId = 0;
                secilenAlbumId = 0;
                secilenOtomatikCalmaListesiId = 3;
            }
            else if (panelAdi.Equals("panelEnCokDinlenenKlasikListesi"))
            {
                labelUstBaslik.Text = "Klasik Top 10";
                secilenCalmaListesiId = 0;
                secilenSanatciId = 0;
                secilenAlbumId = 0;
                secilenOtomatikCalmaListesiId = 4;
            }
            else if (panelAdi.Equals("panelEnCokDinlenenRapListesi"))
            {
                labelUstBaslik.Text = "Rap Top 10";
                secilenCalmaListesiId = 0;
                secilenSanatciId = 0;
                secilenAlbumId = 0;
                secilenOtomatikCalmaListesiId = 5;
            }
            else if (panelAdi.Equals("panelEnCokDinlenenRockListesi"))
            {
                labelUstBaslik.Text = "Rock Top 10";
                secilenCalmaListesiId = 0;
                secilenSanatciId = 0;
                secilenAlbumId = 0;
                secilenOtomatikCalmaListesiId = 6;
            }
            


            panelAlbumlereDonBtn.Visible = true;
            panelAlbumler.SendToBack();
            panelSarkilar.BringToFront();
            SarkilariGoster();
            panelTakipEdilenKullanicilar.BringToFront();



        }
        private void panelKullaniciTakipEt_Click(object sender, EventArgs e)
        {
            Control takipEdilecekKullaniciPnael = ((Control)sender);
            string takipEdilecekKullaniciId = takipEdilecekKullaniciPnael.Parent.Name.Split("-")[1].ToString();
            DateTime t = DateTime.Now;
            string tarih = t.ToString().Split(' ')[0].Split('.')[2] + "-" + t.ToString().Split(' ')[0].Split('.')[1] + "-" + t.ToString().Split(' ')[0].Split('.')[0];
            try
            {
                
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Takiplesme (takipTarihi,TakiplesmeTakipEden_Id,TakiplesmeTakipEdilen_Id) VALUES (" + tarih + "," + kullaniciId + "," + Convert.ToInt32(takipEdilecekKullaniciId) + ")", baglanti);
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
            TakipEdilenleriGoster();
            TumKullanicilariGoster();
        }
        private void panelKullaniciTakipdenCikar_Click(object sender, EventArgs e)
        {
            Control takipdenCikartilacakKullaniciPnael = ((Control)sender);
            string takipdenCikartilacakKullaniciId = takipdenCikartilacakKullaniciPnael.Parent.Name.Split("-")[1].ToString();
            try
            {

                baglanti.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Takiplesme WHERE TakiplesmeTakipEden_Id = " + kullaniciId + " and TakiplesmeTakipEdilen_Id = " + Convert.ToInt32(takipdenCikartilacakKullaniciId), baglanti);
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
            TumKullanicilariGoster();
            TakipEdilenleriGoster();
        }

        private void panelSarkiPlayer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxTumKullanicilarAra_TextChanged(object sender, EventArgs e)
        {

        }

        private void panelTakipEdilenKullanicilar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelVip_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelAlbumeSarkiEkle_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panelKullaniciPP_Click(object sender, EventArgs e)
        {
            // Kullanıcı Bilgileri Güncelleme
            try
            {
                FormKullaniciBilgileriGuncelle formKBG = new FormKullaniciBilgileriGuncelle();
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Kullanicilar WHERE Id = " + kullaniciId, baglanti);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    formKBG.abonelikTuru = Convert.ToBoolean(dr[4]);
                    formKBG.odendi = Convert.ToBoolean(dr[5]);
                    formKBG.kullaniciAdi = Convert.ToString(dr[1]);
                    formKBG.kullaniciEmail = Convert.ToString(dr[2]);
                    formKBG.kullaniciSifre = Convert.ToString(dr[3]);
                    formKBG.kullaniciId = Convert.ToInt32(dr[0]);
                    formKBG.ulkelerId = Convert.ToInt32(dr[6]);
                }
                baglanti.Close();
                formKBG.ShowDialog();
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

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelAdminSanatciEkle_Click(object sender, EventArgs e)
        {
            FormSanatciEkle sanatciEkleForm = new FormSanatciEkle();
            sanatciEkleForm.ShowDialog();
            SanatcilariGoster();
        }

        private void panelSanatcilaraDonBtn_Click(object sender, EventArgs e)
        {
            labelAltBaslik.Text = "Sanatcılar";
            
            panelSanatcilaraDonBtn.Visible = false;
            panelTakipEdilenKullaniciCalmaListeleri.SendToBack();
            panelSanatcilar.BringToFront();
            panelTumKullanicilar.BringToFront();
        }

        private void takipEdilenKullaniciSecme_Click(object sender, EventArgs e)
        {
            Control takipEdilenKullaniciPnael = ((Control)sender);
            string takipEdilenKullaniciId = takipEdilenKullaniciPnael.Name.Split("-")[1].ToString();
            string takipEdilenKullaniciAdi = takipEdilenKullaniciPnael.Controls.Find(takipEdilenKullaniciPnael.Name.ToString() + "-BuyukLabel", true)[0].Text;
            
            //secilenTakipEdilenKullaniciCalmaListesiId
            
            labelAltBaslik.Text = takipEdilenKullaniciAdi + " Çalma Listeleri";
            secilenTakipEdilenKullaniciId = Convert.ToInt32(takipEdilenKullaniciId);
            

            TakipEdilenKullanicininCalmaListeleriniGoster();
            
            panelSanatcilaraDonBtn.Visible = true;
            panelSanatcilar.SendToBack();
            panelTakipEdilenKullaniciCalmaListeleri.BringToFront();
            panelTumKullanicilar.BringToFront();

        }

        private void takipEdilenKullaniciCalmaListesiSecme_Click(object sender, EventArgs e)
        {
            Control takipEdilenKullaniciPnael = ((Control)sender);
            string takipEdilenKullaniciId = takipEdilenKullaniciPnael.Name.Split("-")[1].ToString();
            string takipEdilenKullaniciCalmaListesiAdi = takipEdilenKullaniciPnael.Controls.Find(takipEdilenKullaniciPnael.Name.ToString() + "-BuyukLabel", true)[0].Text;

            secilenOtomatikCalmaListesiId = 0;
            secilenCalmaListesiId = 0;
            
            secilenTakipEdilenKullaniciCalmaListesiId = Convert.ToInt32(takipEdilenKullaniciId);

            labelUstBaslik.Text = takipEdilenKullaniciCalmaListesiAdi;

            panelAlbumlereDonBtn.Visible = true;
            panelAlbumler.SendToBack();
            panelSarkilar.BringToFront();

            panelTakipEdilenKullanicilar.BringToFront();

            SarkilariGoster();
        }


        private void panelAdminAlbumEkle_Click(object sender, EventArgs e)
        {
            FormAlbumEkle albumEkleForm = new FormAlbumEkle();
            albumEkleForm.ShowDialog();
            AlbumleriGoster();
        }

        private void panelSarkiEkleBtn_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonSarkiOynat_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Secilen Sarki Id: " + secilenSarkiId);
            if (!adminGirisi)
            {
                try
                {
                    baglanti.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Sarkilar SET dinlenmeSayisi = " + (secilenSarkiDinlenmeSayisi + 1) + " WHERE Id = " + secilenSarkiId + "", baglanti);
                    cmd.ExecuteNonQuery();
                    secilenSarkiDinlenmeSayisi += 1;
                    labelSarkiDinlenmeSayisi.Text = "Dinlenme Sayısı: " + secilenSarkiDinlenmeSayisi.ToString();
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
                MessageBox.Show("Yönetici Girişinde Player Çalışmaz");
            }
            
        }

        private void panelAlbumlereDonBtn_Click(object sender, EventArgs e)
        {
            labelUstBaslik.Text = "Albumler";
            secilenAlbumId = 0;
            secilenCalmaListesiId = 0;
            secilenSanatciId = 0;
            panelAlbumlereDonBtn.Visible = false;
            panelSarkilar.SendToBack();
            panelAlbumler.BringToFront();
            panelTakipEdilenKullanicilar.BringToFront();
        }

        private void panelSarkiEkleBtn_Click(object sender, EventArgs e)
        {
            FormSarkiEkle sarkiForm = new FormSarkiEkle();
            sarkiForm.ShowDialog();
        }

        private void panelUygulamaEkraniBar_MouseUp(object sender, MouseEventArgs e)
        {
            Dragging = false;
        }
    }
}
