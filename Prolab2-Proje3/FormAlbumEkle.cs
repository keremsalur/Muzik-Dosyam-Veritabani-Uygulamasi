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
    public partial class FormAlbumEkle : Form
    {
        public FormAlbumEkle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath.ToString() + "Veritabani.mdf;Integrated Security=True");

        public int albumId = Int32.MaxValue,albumTuruId = Int32.MaxValue;
        public string albumAdi = "";
        public DateTime albumTarihi = DateTime.MaxValue;


        bool Dragging = false;
        int mouseX = 0, mouseY = 0;

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

        private void buttonSanatciEkleExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormAlbumEkle_Load(object sender, EventArgs e)
        {
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

            if (albumId != Int32.MaxValue && !albumAdi.Equals("") && albumTarihi != DateTime.MaxValue && albumTuruId != Int32.MaxValue)
            {
                // Album Güncelleme
                comboBoxMuzikTuru.SelectedIndex = albumTuruId - 1;
                textBoxAlbumAdi.Text = albumAdi;
                dateTimePickerTarih.Value = albumTarihi;
            }
            else
            {
                dateTimePickerTarih.Value = DateTime.Today;
                comboBoxMuzikTuru.SelectedIndex = 0;
            }

        }

        private void buttonAlbumKayitEt_Click(object sender, EventArgs e)
        {
            if (albumId != Int32.MaxValue && !albumAdi.Equals("") && albumTarihi != DateTime.MaxValue && albumTuruId != Int32.MaxValue)
            {
                // Album Güncelleme
                string tarih = dateTimePickerTarih.Value.ToString().Split(' ')[0].Split('.')[2] + "-" + dateTimePickerTarih.Value.ToString().Split(' ')[0].Split('.')[1] + "-" + dateTimePickerTarih.Value.ToString().Split(' ')[0].Split('.')[0];
                if (!textBoxAlbumAdi.Text.Trim().Equals(""))
                {

                    SqlCommand cmd = new SqlCommand("UPDATE Albumler SET albumAdi = '"+textBoxAlbumAdi.Text+"',tarihi = "+tarih+",SarkiTurleri_Id = "+ (comboBoxMuzikTuru.SelectedIndex + 1)+ " WHERE Id = "+albumId, baglanti);
                    try
                    {
                        baglanti.Open();
                        cmd.ExecuteNonQuery();
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
                // Yeni Kayıt
                string tarih = dateTimePickerTarih.Value.ToString().Split(' ')[0].Split('.')[2] + "-" + dateTimePickerTarih.Value.ToString().Split(' ')[0].Split('.')[1] + "-" + dateTimePickerTarih.Value.ToString().Split(' ')[0].Split('.')[0];
                //MessageBox.Show(dateTimePickerTarih.Value.ToString());
                if (!textBoxAlbumAdi.Text.Trim().Equals(""))
                {

                    SqlCommand cmd = new SqlCommand("INSERT INTO Albumler (albumAdi,tarihi,SarkiTurleri_Id) VALUES ('" + textBoxAlbumAdi.Text.Trim().ToString() + "', " + tarih + "  , " + (comboBoxMuzikTuru.SelectedIndex + 1) + ")", baglanti);
                    try
                    {
                        baglanti.Open();
                        cmd.ExecuteNonQuery();
                        labelKayitDogrulama.Text = "Kayıt Başarılı";
                        labelKayitDogrulama.Visible = true;
                        textBoxAlbumAdi.Text = "";
                        comboBoxMuzikTuru.SelectedIndex = 0;
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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBoxAlbumAdi_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxMuzikTuru_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePickerTarih_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            Dragging = true;
            mouseX = Cursor.Position.X - this.Left;
            mouseY = Cursor.Position.Y - this.Top;
        }
    }
}
