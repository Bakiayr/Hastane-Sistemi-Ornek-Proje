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
    public partial class FrmHastaBilgiDuzenle : Form
    {
        public FrmHastaBilgiDuzenle()
        {
            InitializeComponent();
        }
        public string TCNo;
        SqlBaglanti sqlBaglanti = new SqlBaglanti();
        private void FrmHastaBilgiDuzenle_Load(object sender, EventArgs e)
        {
            mskTxt_TC.Text = TCNo;
            SqlCommand komut = new SqlCommand("Select *From Tbl_Hastalar where HastaTc=@p1", sqlBaglanti.Baglanti());
            komut.Parameters.AddWithValue("@p1", mskTxt_TC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txt_Ad.Text = dr[1].ToString();
                txt_Soyad.Text = dr[2].ToString();
                mskTxt_TelNo.Text = dr[4].ToString();
                txt_Sifre.Text = dr[5].ToString();
                cmbBox_Cinsiyet.Text = dr[6].ToString();
            }
            sqlBaglanti.Baglanti().Close();
        }

        private void btn_BilgileriGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("Update Tbl_Hastalar set HastaAd=@a1,HastaSoyad=@a2,HastaTelefon=@a3,Hastasifre=@a4,hastacinsiyet=@a5 where HastaTC=@a6", sqlBaglanti.Baglanti());
            komut2.Parameters.AddWithValue("@a1", txt_Ad.Text);
            komut2.Parameters.AddWithValue("@a2", txt_Soyad.Text);
            komut2.Parameters.AddWithValue("@a3", mskTxt_TelNo.Text);
            komut2.Parameters.AddWithValue("@a4", txt_Sifre.Text);
            komut2.Parameters.AddWithValue("@a5", cmbBox_Cinsiyet.Text);
            komut2.Parameters.AddWithValue("@a6", mskTxt_TC.Text);
            komut2.ExecuteNonQuery();
            sqlBaglanti.Baglanti().Close();
            MessageBox.Show("Kaydınız Güncellenmiştir!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
        }
    }
}
