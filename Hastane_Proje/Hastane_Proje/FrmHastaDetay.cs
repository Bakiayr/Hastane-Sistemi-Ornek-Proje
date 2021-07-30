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
    public partial class FrmHastaDetay : Form
    {
        public FrmHastaDetay()
        {
            InitializeComponent();
        }

        SqlBaglanti sqlBaglanti = new SqlBaglanti();
        public string tc;
        
        private void lbl_TC_Click(object sender, EventArgs e)
        {
            
        }

        private void FrmHastaDetay_Load(object sender, EventArgs e)
        {
            //Tc yazdırma ve Ad-Soyad çekme işlemi
            lbl_TC.Text = tc;
            SqlCommand komut = new SqlCommand("Select HastaAd,hastasoyad from Tbl_Hastalar where HastaTC=@p1", sqlBaglanti.Baglanti());
            komut.Parameters.AddWithValue("@p1", lbl_TC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lbl_AdSoyad.Text = dr[0] + " " + dr[1];
            }
            sqlBaglanti.Baglanti().Close();

            //Randevu Geçmişi
            DataTable dt = new DataTable();
            //Datagride verileri aktarmak için kullandığımız command
            SqlDataAdapter da = new SqlDataAdapter("Select *From Tbl_Randevular where HastaTc=" + tc, sqlBaglanti.Baglanti());
            da.Fill(dt);
            dataGridView_RandevuGecmisi.DataSource = dt;
            sqlBaglanti.Baglanti().Close();

            //Branşları Çekme
            SqlCommand komut2 = new SqlCommand("Select BransAd from Tbl_Branslar", sqlBaglanti.Baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmbBox_Brans.Items.Add(dr2[0]);
            }
            sqlBaglanti.Baglanti().Close();
        }

        private void cmbBox_Brans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbBox_Doktor.Items.Clear();
            cmbBox_Doktor.Text = "";
            SqlCommand komut3 = new SqlCommand("Select DoktorAd,DoktorSoyad from Tbl_Doktorlar where DoktorBrans=@p1", sqlBaglanti.Baglanti());
            komut3.Parameters.AddWithValue("@p1", cmbBox_Brans.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                cmbBox_Doktor.Items.Add(dr3[0] + " " + dr3[1]);
            }
            sqlBaglanti.Baglanti().Close();
        }

        private void cmbBox_Doktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select *from Tbl_Randevular where RandevuBrans='" + cmbBox_Brans.Text + "'" + "and RandevuDoktor='"+cmbBox_Doktor.Text+"' and RandevuDurum=0", sqlBaglanti.Baglanti());
            da2.Fill(dt2);
            dataGridView_AktifRandevular.DataSource = dt2;
            sqlBaglanti.Baglanti().Close();
        }

        private void linkLbl_BilgileriDuzenle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmHastaBilgiDuzenle fr = new FrmHastaBilgiDuzenle();
            fr.TCNo = lbl_TC.Text;
            fr.Show();
        }

        private void dataGridView_AktifRandevular_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView_AktifRandevular.SelectedCells[0].RowIndex;
            txt_RandevuID.Text = dataGridView_AktifRandevular.Rows[secilen].Cells[0].Value.ToString();
        }

        private void btn_RandevuAl_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Tbl_Randevular set RandevuDurum=1,HastaTC=@h1, HastaSikayet=@h2 where RandevuID=@h3", sqlBaglanti.Baglanti());
            komut.Parameters.AddWithValue("@h1", lbl_TC.Text);
            komut.Parameters.AddWithValue("@h2", richTxt_Sikayet.Text);
            komut.Parameters.AddWithValue("@h3", txt_RandevuID.Text);
            komut.ExecuteNonQuery();
            sqlBaglanti.Baglanti().Close();
            MessageBox.Show("Randevunuz Alınmıştır", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView_RandevuGecmisi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
