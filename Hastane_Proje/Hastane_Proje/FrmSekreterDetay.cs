using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hastane_Proje
{
    public partial class FrmSekreterDetay : Form
    {
        public FrmSekreterDetay()
        {
            InitializeComponent();
        }

        public string sekreterTC;
        SqlBaglanti sqlBaglanti = new SqlBaglanti();
       
        private void FrmSekreterDetay_Load(object sender, EventArgs e)
        {
            //TC YAZDIRMA
            lbl_TC.Text = sekreterTC;
            //SQL DEN AD SOYAD ÇEKME
            SqlCommand komut = new SqlCommand("Select SekreterAdSoyad from Tbl_Sekreter where sekretertc=@a1", sqlBaglanti.Baglanti());
            komut.Parameters.AddWithValue("@a1", lbl_TC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lbl_AdSoyad.Text = dr[0].ToString();
            }
            sqlBaglanti.Baglanti().Close();


            // BRANŞLARI DATAGRİD'E AKTARMA
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select *From Tbl_Branslar", sqlBaglanti.Baglanti());
            da1.Fill(dt1);
            dataGridView_Branslar.DataSource = dt1;
            sqlBaglanti.Baglanti().Close();

            //DOKTORLARI DATAGRİD'E AKTARMA
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select (DoktorAd + ' ' + DoktorSoyad) as 'Doktorlar',DoktorBrans from Tbl_Doktorlar", sqlBaglanti.Baglanti());
            da2.Fill(dt2);
            dataGridView_Doktorlar.DataSource = dt2;
            sqlBaglanti.Baglanti().Close();

            //BRANŞ VE DOKTORLARI COMBOBOX'A AKTARMA
            SqlCommand komut2 = new SqlCommand("Select BransAd from Tbl_Branslar", sqlBaglanti.Baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmbBox_Brans.Items.Add(dr2[0]);
            }
            sqlBaglanti.Baglanti().Close();
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            //RANDEVU KAYDETME
            SqlCommand komutKaydet = new SqlCommand("Insert into Tbl_Randevular (RandevuTarih,randevusaat,randevubrans,randevudoktor) values (@r1,@r2,@r3,@r4)", sqlBaglanti.Baglanti());
            komutKaydet.Parameters.AddWithValue("@r1", mskTxt_Tarih.Text);
            komutKaydet.Parameters.AddWithValue("@r2", mskTxt_Saat.Text);
            komutKaydet.Parameters.AddWithValue("@r3", cmbBox_Brans.Text);
            komutKaydet.Parameters.AddWithValue("@r4", cmbBox_Doktor.Text);
            komutKaydet.ExecuteNonQuery();
            sqlBaglanti.Baglanti().Close();
            MessageBox.Show("Randevu Oluşturuldu!");
        }

        private void cmbBox_Brans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbBox_Doktor.Items.Clear();
            cmbBox_Doktor.Text = "";
            SqlCommand komut = new SqlCommand("Select DoktorAd,DoktorSoyad from Tbl_Doktorlar where DoktorBrans=@b1", sqlBaglanti.Baglanti());
            komut.Parameters.AddWithValue("@b1", cmbBox_Brans.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbBox_Doktor.Items.Add(dr[0] + " " + dr[1]);
            }
            sqlBaglanti.Baglanti().Close();
        }

        private void btn_DuyuruOlustur_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Insert into Tbl_Duyurular (Duyuru) values (@d1)", sqlBaglanti.Baglanti());
            komut.Parameters.AddWithValue("@d1", richTxt_Duyuru.Text);
            komut.ExecuteNonQuery();
            sqlBaglanti.Baglanti().Close();
            MessageBox.Show("Duyuru Oluşturuldu!");
        }

        private void btn_DoktorPaneli_Click(object sender, EventArgs e)
        {
            FrmDoktorPaneli doktorPaneli = new FrmDoktorPaneli();
            doktorPaneli.Show();
        }

        private void btn_BransPaneli_Click(object sender, EventArgs e)
        {
            FrmBransPaneli bransPaneli = new FrmBransPaneli();
            bransPaneli.Show();

        }

        private void btn_RandevuListe_Click(object sender, EventArgs e)
        {
            FrmRandevuListesi frmRandevu = new FrmRandevuListesi();
            frmRandevu.Show();
        }

        private void btn_Duyurular_Click(object sender, EventArgs e)
        {
            FrmDuyurular frmDuyurular = new FrmDuyurular();
            frmDuyurular.Show();
        }
    }
}
