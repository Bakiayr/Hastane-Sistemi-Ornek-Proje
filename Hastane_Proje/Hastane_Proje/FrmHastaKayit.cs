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
    public partial class HastaKayıt : Form
    {
        public HastaKayıt()
        {
            InitializeComponent();
        }

        SqlBaglanti sqlBaglanti = new SqlBaglanti();

        private void btn_KayitOl_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Insert into Tbl_Hastalar (HastaAd,HastaSoyad,HastaTC,HastaTelefon,HastaSifre,HastaCinsiyet) values (@p1,@p2,@p3,@p4,@p5,@p6)", sqlBaglanti.Baglanti());
            komut.Parameters.AddWithValue("@p1", txt_Ad.Text);
            komut.Parameters.AddWithValue("@p2", txt_Soyad.Text);
            komut.Parameters.AddWithValue("@p3", mskTxt_TC.Text);
            komut.Parameters.AddWithValue("@p4", mskTxt_TelNo.Text);
            komut.Parameters.AddWithValue("@p5", txt_Sifre.Text);
            komut.Parameters.AddWithValue("@p6", cmbBox_Cinsiyet.Text);
            komut.ExecuteNonQuery();
            sqlBaglanti.Baglanti().Close();
            MessageBox.Show("Kaydınız Başarıyla Gerçekleştirmiştir!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
