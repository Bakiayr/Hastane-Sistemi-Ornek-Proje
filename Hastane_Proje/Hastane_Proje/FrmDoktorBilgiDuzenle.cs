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
    public partial class FrmDoktorBilgiDuzenle : Form
    {
        public FrmDoktorBilgiDuzenle()
        {
            InitializeComponent();
        }

        public string tc;
        SqlBaglanti sqlBaglanti = new SqlBaglanti();

        private void FrmDoktorBilgiDuzenle_Load(object sender, EventArgs e)
        {
            mskTxt_TC.Text = tc;
            SqlCommand komut = new SqlCommand("Select *from Tbl_Doktorlar where DoktorTC=@a1", sqlBaglanti.Baglanti());
            komut.Parameters.AddWithValue("@a1", mskTxt_TC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txt_Ad.Text = dr[1].ToString();
                txt_Soyad.Text = dr[2].ToString();
                cmbBox_Brans.Text = dr[3].ToString();
                txt_Sifre.Text = dr[5].ToString();
            }
            sqlBaglanti.Baglanti().Close();
        }

        private void btn_BilgileriGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Tbl_Doktorlar set DoktorAd=@d1,DoktorSoyad=@d2,DoktorBrans=@d3,DoktorSifre=@d4 where doktorTC=@d5", sqlBaglanti.Baglanti());
            komut.Parameters.AddWithValue("@d1", txt_Ad.Text);
            komut.Parameters.AddWithValue("@d2", txt_Soyad.Text);
            komut.Parameters.AddWithValue("@d3", cmbBox_Brans.Text);
            komut.Parameters.AddWithValue("@d4", txt_Sifre.Text);
            komut.Parameters.AddWithValue("@d5", mskTxt_TC.Text);
            komut.ExecuteNonQuery();
            sqlBaglanti.Baglanti().Close();
            MessageBox.Show("Bilgileriniz Güncellenmiştir!");
        }
    }
}
