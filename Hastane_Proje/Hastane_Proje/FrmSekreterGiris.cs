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
    public partial class FrmSekreterGiris : Form
    {
        public FrmSekreterGiris()
        {
            InitializeComponent();
        }

        SqlBaglanti sqlBaglanti = new SqlBaglanti();

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_GirisYap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select *From Tbl_Sekreter where SekreterTC=@a1 and SekreterSifre=@a2", sqlBaglanti.Baglanti());
            komut.Parameters.AddWithValue("@a1", maskedtxt_TC.Text);
            komut.Parameters.AddWithValue("@a2", txt_Sifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmSekreterDetay frmSekreter = new FrmSekreterDetay();
                frmSekreter.sekreterTC = maskedtxt_TC.Text;
                frmSekreter.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Hatalı TC veya Şifre Girdiniz!");

            sqlBaglanti.Baglanti().Close();
        }
    }
}
