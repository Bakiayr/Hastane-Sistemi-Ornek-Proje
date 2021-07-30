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
    public partial class FrmDoktorPaneli : Form
    {
        public FrmDoktorPaneli()
        {
            InitializeComponent();
        }

        SqlBaglanti sqlBaglanti = new SqlBaglanti();

        private void FrmDoktorPaneli_Load(object sender, EventArgs e)
        {
            //DOKTORLARI DATAGRİD'E AKTARMA
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select *From Tbl_Doktorlar", sqlBaglanti.Baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            //BRANŞLARI ÇEKME
            SqlCommand komut2 = new SqlCommand("Select BransAd from Tbl_Branslar", sqlBaglanti.Baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmb_Brans.Items.Add(dr2[0]);
            }
            sqlBaglanti.Baglanti().Close();
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            //DOKTOR EKLEME
            SqlCommand komut = new SqlCommand("Insert into Tbl_Doktorlar (DoktorAd,DoktorSoyad,DoktorBrans,DoktorTC,DoktorSifre) values (@a1,@a2,@a3,@a4,@a5)", sqlBaglanti.Baglanti());
            komut.Parameters.AddWithValue("@a1", txt_Ad.Text);
            komut.Parameters.AddWithValue("@a2", txt_Soyad.Text);
            komut.Parameters.AddWithValue("@a3", cmb_Brans.Text);
            komut.Parameters.AddWithValue("@a4", mskTxt_TC.Text);
            komut.Parameters.AddWithValue("@a5", txt_Sifre.Text);
            komut.ExecuteNonQuery();
            sqlBaglanti.Baglanti().Close();
            MessageBox.Show("Doktor Kayıt Edilmiştir", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);


            //BRANŞLARI ÇEKME
            SqlCommand komut2 = new SqlCommand("Select BransAd from Tbl_Branslar", sqlBaglanti.Baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmb_Brans.Items.Add(dr2[0]);
            }
            sqlBaglanti.Baglanti().Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txt_Ad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txt_Soyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            cmb_Brans.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            mskTxt_TC.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txt_Sifre.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from Tbl_Doktorlar where DoktorTC=@a1", sqlBaglanti.Baglanti());
            komut.Parameters.AddWithValue("@a1", mskTxt_TC.Text);
            komut.ExecuteNonQuery();
            sqlBaglanti.Baglanti().Close();
            MessageBox.Show("Doktor Kaydı Silinmiştir", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Tbl_Doktorlar set DoktorAd=@a1, DoktorSoyad=@a2, DoktorBrans=@a3, DoktorTC=@a4, DoktorSifre=@a5", sqlBaglanti.Baglanti());
            komut.Parameters.AddWithValue("@a1", txt_Ad.Text);
            komut.Parameters.AddWithValue("@a2", txt_Soyad.Text);
            komut.Parameters.AddWithValue("@a3", cmb_Brans.Text);
            komut.Parameters.AddWithValue("@a4", mskTxt_TC.Text);
            komut.Parameters.AddWithValue("@a5", txt_Sifre.Text);
            komut.ExecuteNonQuery();
            sqlBaglanti.Baglanti().Close();
            MessageBox.Show("Kayıt Güncellenmiştir", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
