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
    public partial class FrmHastaGiris : Form
    {
        public FrmHastaGiris()
        {
            InitializeComponent();
        }

        SqlBaglanti sqlBaglanti = new SqlBaglanti();

        private void linklbl_UyeOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HastaKayıt frm = new HastaKayıt();
            frm.Show();
        }

        private void btn_GirisYap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Tbl_Hastalar where HastaTC=@a1 and HastaSifre=@a2", sqlBaglanti.Baglanti());
            komut.Parameters.AddWithValue("@a1", maskedtxt_TC.Text);
            komut.Parameters.AddWithValue("@a2", txt_Sifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmHastaDetay frm = new FrmHastaDetay();
                frm.tc = maskedtxt_TC.Text;
                frm.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Hatalı TC veya Şifre Girdiniz!!");

            sqlBaglanti.Baglanti().Close();
        }
    }
}
