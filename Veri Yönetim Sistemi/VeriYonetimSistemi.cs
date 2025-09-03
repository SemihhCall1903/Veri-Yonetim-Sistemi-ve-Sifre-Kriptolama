using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Veri_Yönetim_Sistemi
{
    public partial class VeriYonetimSistemi : Form
    {
        public VeriYonetimSistemi()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-ARGOF7B5\\SQLEXPRESS;Initial Catalog=VeriYonetimSistemi;Integrated Security=True;Encrypt=False");

        public string[] KullaniciTur = { "Yönetici", "Kullanıcı", "Stajyer" };
        bool varMi = false;

        void DGWListele()
        {
            conn.Close();

            conn.Open();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT KullaniciIdPk as 'Kullanıcı ID',Ad,Soyad,KullaniciAd as 'Kullanıcı Ad',KullaniciSifre as 'Kullanıcı Şifre',KullaniciTuru as 'Kullanıcı Türü' FROM Kullanici", conn);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            conn.Close();
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            try 
            {
                conn.Close();

                conn.Open();


                DialogResult onay = MessageBox.Show("Kullanıcı eklemeyi onaylıyor musunuz ?", "Onaylama Mesajı", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (onay == DialogResult.OK)
                {

                    SqlCommand veriGuncelle = new SqlCommand("INSERT INTO Kullanici(Ad,Soyad,KullaniciAd,KullaniciSifre,KullaniciTuru) VALUES(@ad,@soyad,@kullaniciAd,@kullaniciSifre,@kullaniciTur)", conn);
                    veriGuncelle.Parameters.AddWithValue("@ad", txtAd.Text);
                    veriGuncelle.Parameters.AddWithValue("@soyad", txtSoyad.Text);
                    veriGuncelle.Parameters.AddWithValue("@kullaniciAd", txtKAd.Text);
                    veriGuncelle.Parameters.AddWithValue("@kullaniciSifre", Kriptolama.SHA256HexHashString(txtKSifre.Text));
                    veriGuncelle.Parameters.AddWithValue("@kullaniciTur", cmbKullaniciTur.Text);
                    veriGuncelle.ExecuteNonQuery();

                    conn.Close();

                    MessageBox.Show("Veri ekleme başarılı !", "Veri Eklendi !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata meydana geldi\n" + ex.ToString(), "Hata !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            txtKSifre.Text = "";

            DGWListele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {

                conn.Close();

                conn.Open();

                SqlCommand veriVarMi = new SqlCommand("SELECT * FROM Kullanici WHERE KullaniciIdPk=@kullaniciIdPk AND Ad=@ad AND Soyad=@soyad AND KullaniciAd=@kullaniciAd AND KullaniciTuru=@kullaniciTur", conn);
                veriVarMi.Parameters.AddWithValue("@kullaniciIdPk", txtId.Text);
                veriVarMi.Parameters.AddWithValue("@ad", txtAd.Text);
                veriVarMi.Parameters.AddWithValue("@soyad", txtSoyad.Text);
                veriVarMi.Parameters.AddWithValue("@kullaniciAd", txtKAd.Text);
                veriVarMi.Parameters.AddWithValue("@kullaniciTur", cmbKullaniciTur.Text);
                SqlDataReader oku = veriVarMi.ExecuteReader();

                if (oku.Read())
                {
                    varMi = true;
                }
                if (varMi == true)
                {
                    DialogResult onay = MessageBox.Show("Kullanıcı güncellemeyi onaylıyor musunuz ?", "Onaylama Mesajı", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                    if (onay == DialogResult.OK)
                    {
                        conn.Close();

                        conn.Open();

                        SqlCommand veriGuncelle = new SqlCommand("UPDATE Kullanici SET Ad=@ad,Soyad=@soyad,KullaniciAd=@kullaniciAd,KullaniciSifre=@kullaniciSifre,KullaniciTuru=@kullaniciTur WHERE KullaniciIdPk=@kullaniciIdPk", conn);
                        veriGuncelle.Parameters.AddWithValue("@kullaniciIdPk", txtId.Text);
                        veriGuncelle.Parameters.AddWithValue("@ad", txtAd.Text);
                        veriGuncelle.Parameters.AddWithValue("@soyad", txtSoyad.Text);
                        veriGuncelle.Parameters.AddWithValue("@kullaniciAd", txtKAd.Text);
                        veriGuncelle.Parameters.AddWithValue("@kullaniciSifre", Kriptolama.SHA256HexHashString(txtKSifre.Text));
                        veriGuncelle.Parameters.AddWithValue("@kullaniciTur", cmbKullaniciTur.Text);
                        veriGuncelle.ExecuteNonQuery();

                        conn.Close();

                        MessageBox.Show("Veri güncelleme başarılı !", "Veri Güncellendi !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {

                    }
                }
                else
                {
                    MessageBox.Show("Veri bulunamadı,", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    varMi = false;
                }
                txtKSifre.Text = "";

                DGWListele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata meydana geldi\n" + ex.ToString(), "Hata !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void VeriYonetimSistemi_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < KullaniciTur.Length; i++)
            {
                cmbKullaniciTur.Items.Add(KullaniciTur[i]);
            }

            DGWListele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtKAd.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            cmbKullaniciTur.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Close();

                conn.Open();

                SqlCommand veriVarMi = new SqlCommand("SELECT * FROM Kullanici WHERE KullaniciIdPk=@kullaniciIdPk AND Ad=@ad AND Soyad=@soyad AND KullaniciAd=@kullaniciAd AND KullaniciTuru=@kullaniciTur", conn);
                veriVarMi.Parameters.AddWithValue("@kullaniciIdPk", txtId.Text);
                veriVarMi.Parameters.AddWithValue("@ad", txtAd.Text);
                veriVarMi.Parameters.AddWithValue("@soyad", txtSoyad.Text);
                veriVarMi.Parameters.AddWithValue("@kullaniciAd", txtKAd.Text);
                veriVarMi.Parameters.AddWithValue("@kullaniciTur", cmbKullaniciTur.Text);
                SqlDataReader oku = veriVarMi.ExecuteReader();

                if (oku.Read())
                {
                    varMi = true;
                }
                conn.Close();

                if (varMi == true)
                {

                    DialogResult onay = MessageBox.Show("Kullanıcı silmeyi onaylıyor musunuz ?", "Onaylama Mesajı", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                    if (onay == DialogResult.OK)
                    {
                        conn.Close();

                        conn.Open();

                        SqlCommand veriSil = new SqlCommand("DELETE FROM Kullanici WHERE KullaniciIdPk=@kullaniciIdPk", conn);
                        veriSil.Parameters.AddWithValue("@kullaniciIdPk", txtId.Text);
               
                        veriSil.ExecuteNonQuery();

                        conn.Close();

                        MessageBox.Show("Veri silme başarılı !", "Veri Silindi !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {

                    }
                }
                else
                {
                    MessageBox.Show("Veri mevcut değil", "Veri Silinemedi !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    varMi = false;
                }

                DGWListele();

                txtKSifre.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata meydana geldi\n" + ex.ToString(), "Hata !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
