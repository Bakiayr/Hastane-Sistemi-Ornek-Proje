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
    public partial class FrmDoktorGiris : Form
    {
        public FrmDoktorGiris()
        {
            InitializeComponent();
        }

        SqlBaglanti sqlBaglanti = new SqlBaglanti();

        private void btn_GirisYap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select *from Tbl_Doktorlar where doktortc=@d1 and doktorsifre=@d2", sqlBaglanti.Baglanti());
            komut.Parameters.AddWithValue("@d1", maskedtxt_TC.Text);
            komut.Parameters.AddWithValue("@d2", txt_Sifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmDoktorDetay fr = new FrmDoktorDetay();
                fr.doktorTC = maskedtxt_TC.Text;
                fr.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Hatalı TC veya Şifre Girdiniz!!");

            sqlBaglanti.Baglanti().Close();
        }
    }
}
