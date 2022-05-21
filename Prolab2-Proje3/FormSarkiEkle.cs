using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prolab2_Proje3
{
    public partial class FormSarkiEkle : Form
    {
        public FormSarkiEkle()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath.ToString() + "Veritabani.mdf;Integrated Security=True");

        public int sarkiId = Int32.MaxValue, turId= Int32.MaxValue;
        public string sarkiAdi = "";
        public DateTime sarkiTarih = DateTime.MaxValue;
        


        bool Dragging = false;
        int mouseX = 0, mouseY = 0;

        private void buttonSarkiEkleExit_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void FormSarkiEkle_Load(object sender, EventArgs e)
        {
            if (sarkiId != Int32.MaxValue && !sarkiAdi.Equals("") && sarkiTarih != DateTime.MaxValue && turId != Int32.MaxValue)
            {
                // Şarkı Güncelleme

                textBoxSarkiAdi.Text = sarkiAdi;
                dateTimePickerTarih.Value = sarkiTarih;

                // Şarkı Türleri Çek
                comboBoxMuzikTuru.Items.Clear();
                SqlCommand cmd = new SqlCommand("SELECT * FROM SarkiTurleri", baglanti);
                try
                {
                    baglanti.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        comboBoxMuzikTuru.Items.Add(Convert.ToString(dr[1]));
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
                comboBoxMuzikTuru.SelectedIndex = turId - 1;
                label1.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                comboBoxMuzikTuru.Visible = false;
                checkedListBoxSanatcilar.Visible = false;
                comboBoxAlbum.Visible = false;
                numericUpDownDakika.Visible = false;
                numericUpDownSaat.Visible = false;
                numericUpDownSaniye.Visible = false;
            }
            else
            {
                // Şarkı Ekleme
                dateTimePickerTarih.Value = DateTime.Today;
                // Şarkı Türleri Çek
                comboBoxMuzikTuru.Items.Clear();
                SqlCommand cmd = new SqlCommand("SELECT * FROM SarkiTurleri", baglanti);
                try
                {
                    baglanti.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        comboBoxMuzikTuru.Items.Add(Convert.ToString(dr[1]));
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

                comboBoxMuzikTuru.SelectedIndex = 0;

                // Sanatçıları Çek
                checkedListBoxSanatcilar.Items.Clear();
                SqlCommand cmdSanatcilar = new SqlCommand("SELECT * FROM Sanatcilar", baglanti);
                try
                {
                    baglanti.Open();
                    SqlDataReader dr = cmdSanatcilar.ExecuteReader();
                    while (dr.Read())
                    {
                        checkedListBoxSanatcilar.Items.Add(Convert.ToString(dr[1]));
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

        private void comboBoxMuzikTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxAlbum.Items.Clear();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Albumler WHERE SarkiTurleri_Id = "+(comboBoxMuzikTuru.SelectedIndex + 1)+"", baglanti);
            try
            {
                baglanti.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    comboBoxAlbum.Items.Add(Convert.ToString(dr[1]));
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

            comboBoxAlbum.SelectedIndex = 0;
        }

        private void buttonAlbumKayitEt_Click(object sender, EventArgs e)
        {
            if (sarkiId != Int32.MaxValue && !sarkiAdi.Equals("") && sarkiTarih != DateTime.MaxValue && turId != Int32.MaxValue)
            {
                if (!textBoxSarkiAdi.Text.Trim().Equals("")){
                    // Şarkı Güncelleme
                    string tarih = dateTimePickerTarih.Value.ToString().Split(' ')[0].Split('.')[2] + "-" + dateTimePickerTarih.Value.ToString().Split(' ')[0].Split('.')[1] + "-" + dateTimePickerTarih.Value.ToString().Split(' ')[0].Split('.')[0];
                    try
                    {
                        baglanti.Open();
                        SqlCommand cmdSarkiGuncelle = new SqlCommand("UPDATE Sarkilar SET sarkiAdi = '" + textBoxSarkiAdi.Text + "', yayinlanmaTarihi = " + tarih + "  WHERE Id = " + sarkiId, baglanti);
                        cmdSarkiGuncelle.ExecuteNonQuery();
                        labelKayitDogrulama.Text = "Güncelleme Başarılı";
                        labelKayitDogrulama.Visible = true;
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
                    labelKayitDogrulama.Text = "Gerekli Alanları Doldurun";
                    labelKayitDogrulama.Visible = true;
                }
                

            }
            else
            {
                if (!textBoxSarkiAdi.Text.Trim().Equals("") && checkedListBoxSanatcilar.CheckedItems.Count > 0)
                {
                    try
                    {
                        // Şarkı Ekleme
                        string tarih = dateTimePickerTarih.Value.ToString().Split(' ')[0].Split('.')[2] + "-" + dateTimePickerTarih.Value.ToString().Split(' ')[0].Split('.')[1] + "-" + dateTimePickerTarih.Value.ToString().Split(' ')[0].Split('.')[0];
                        string sure = numericUpDownSaat.Value.ToString() + ":" + numericUpDownDakika.Value.ToString() + ":" + numericUpDownSaniye.Value.ToString();
                        baglanti.Open();
                        SqlCommand cmdSarkiEkle = new SqlCommand("INSERT INTO Sarkilar (sarkiAdi,sure,dinlenmeSayisi,yayinlanmaTarihi,SarkiTurleri_Id) VALUES ('" + textBoxSarkiAdi.Text + "','" + sure + "', 0 , " + tarih + "," + (comboBoxMuzikTuru.SelectedIndex + 1) + ")", baglanti);
                        cmdSarkiEkle.ExecuteNonQuery();
                        // Şarkı Sanatcı İlişkisi Ekleme
                        int sarkiId = 0, sanatciId = 0;
                        SqlCommand cmdSarkiId = new SqlCommand("SELECT * FROM Sarkilar WHERE sarkiAdi LIKE '%" + textBoxSarkiAdi.Text + "%'", baglanti);
                        SqlDataReader drSarki = cmdSarkiId.ExecuteReader();
                        while (drSarki.Read())
                        {
                            sarkiId = Convert.ToInt32(drSarki[0]);
                        }
                        baglanti.Close();
                        //MessageBox.Show("Sarkı Id: " + sarkiId.ToString());
                        // Listede seçilen Sanatcılar
                        for (int i = 0; i < checkedListBoxSanatcilar.CheckedItems.Count; i++)
                        {
                            baglanti.Open();
                            //MessageBox.Show(checkedListBoxSanatcilar.CheckedItems[i].ToString());
                            SqlCommand cmdSanatciiId = new SqlCommand("SELECT * FROM Sanatcilar WHERE sanatciAdi LIKE '%" + checkedListBoxSanatcilar.CheckedItems[i].ToString() + "%'", baglanti);
                            SqlDataReader drSanatci = cmdSanatciiId.ExecuteReader();
                            while (drSanatci.Read())
                            {
                                sanatciId = Convert.ToInt32(drSanatci[0]);
                            }
                            //MessageBox.Show("Sanacı Id: " + sanatciId.ToString());
                            baglanti.Close();
                            baglanti.Open();
                            SqlCommand cmdSanatciSarkiIlıskisi = new SqlCommand("INSERT INTO SanatciSarki (Sarkilar_Id,Sanatcilar_Id) VALUES (" + sarkiId + "," + sanatciId + ")", baglanti);
                            cmdSanatciSarkiIlıskisi.ExecuteNonQuery();
                            baglanti.Close();
                        }
                        baglanti.Open();
                        //MessageBox.Show(comboBoxAlbum.SelectedItem.ToString());
                        // Şarkı Albüm İlişkisi
                        int albumId = 0;
                        SqlCommand cmdAlbumiId = new SqlCommand("SELECT * FROM Albumler WHERE albumAdi LIKE '%" + comboBoxAlbum.SelectedItem.ToString() + "%'", baglanti);
                        SqlDataReader drAlbum = cmdAlbumiId.ExecuteReader();
                        while (drAlbum.Read())
                        {
                            albumId = Convert.ToInt32(drAlbum[0]);
                        }
                        baglanti.Close();

                        baglanti.Open();
                        SqlCommand cmdAlbumSarkiIlıskisi = new SqlCommand("INSERT INTO SarkiAlbum (Sarkilar_Id,Albumler_Id) VALUES (" + sarkiId + "," + albumId + ")", baglanti);
                        cmdAlbumSarkiIlıskisi.ExecuteNonQuery();

                        labelKayitDogrulama.Text = "Kayıt Başarılı";
                        labelKayitDogrulama.Visible = true;
                        textBoxSarkiAdi.Text = "";
                        comboBoxAlbum.SelectedItem = 0;
                        for (int i = 0; i < checkedListBoxSanatcilar.Items.Count; i++)
                        {
                            checkedListBoxSanatcilar.SetItemChecked(i, false);
                        }
                        numericUpDownDakika.Value = 0;
                        numericUpDownSaat.Value = 0;
                        numericUpDownSaniye.Value = 0;


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
                    labelKayitDogrulama.Text = "Gerekli Alanları Doldurun";
                    labelKayitDogrulama.Visible = true;
                }
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
