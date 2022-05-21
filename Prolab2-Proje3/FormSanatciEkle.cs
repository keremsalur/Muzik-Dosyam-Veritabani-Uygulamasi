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
    public partial class FormSanatciEkle : Form
    {
        public FormSanatciEkle()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath.ToString() + "Veritabani.mdf;Integrated Security=True");
        public string sanatciAdi = "";
        public int sanatciUlkeId = Int32.MaxValue, sanatciId = Int32.MaxValue;


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

        private void FormSanatciEkle_Load(object sender, EventArgs e)
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

            if (!sanatciAdi.Equals("") && sanatciUlkeId != Int32.MaxValue && sanatciId != Int32.MaxValue)
            {
                labelSanatciEkle.Text = "Sanatci Güncelleme";
                textBoxSanatciAdi.Text = sanatciAdi;
                comboBoxUlke.SelectedIndex = sanatciUlkeId - 1;
            }
            else
            {
                comboBoxUlke.SelectedIndex = 0;
            }
        }

        private void buttonSanatciKayitEt_Click(object sender, EventArgs e)
        {
            if (!sanatciAdi.Equals("") && sanatciUlkeId != Int32.MaxValue && sanatciId != Int32.MaxValue)
            {
                if (!textBoxSanatciAdi.Text.Trim().Equals(""))
                {
                    // Sanatcı Ekleme
                    SqlCommand cmd = new SqlCommand("UPDATE Sanatcilar SET sanatciAdi = '"+textBoxSanatciAdi.Text+"', Ulkeler_Id = "+ (comboBoxUlke.SelectedIndex + 1) + " WHERE Id = " + sanatciId, baglanti);
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
                if (!textBoxSanatciAdi.Text.Trim().Equals(""))
                {
                    // Sanatcı Ekleme
                    SqlCommand cmd = new SqlCommand("INSERT INTO Sanatcilar (sanatciAdi,Ulkeler_Id) VALUES ('"+ textBoxSanatciAdi.Text.Trim().ToString() +"', "+ (comboBoxUlke.SelectedIndex + 1) +")", baglanti);
                    try
                    {
                        baglanti.Open();
                        cmd.ExecuteNonQuery();
                        labelKayitDogrulama.Text = "Kayıt Başarılı";
                        labelKayitDogrulama.Visible = true;
                        textBoxSanatciAdi.Text = "";
                        comboBoxUlke.SelectedIndex = 0;
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
