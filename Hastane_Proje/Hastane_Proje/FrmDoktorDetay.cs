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
    public partial class FrmDoktorDetay : Form
    {
        public FrmDoktorDetay()
        {
            InitializeComponent();
        }

        public string doktorTC;
        SqlBaglanti sqlBaglanti = new SqlBaglanti();

        private void FrmDoktorDetay_Load(object sender, EventArgs e)
        {
            lbl_TC.Text = doktorTC;
            //AD SOYAD YAZDIRMA
            SqlCommand komut = new SqlCommand("Select DoktorAd,DoktorSoyad from Tbl_Doktorlar where doktorTC=@k1",sqlBaglanti.Baglanti());
            komut.Parameters.AddWithValue("@k1", lbl_TC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lbl_AdSoyad.Text = dr[0] + " " + dr[1];
            }
            sqlBaglanti.Baglanti().Close();

            //DOKTORA AİT RANDEVULARI GETİRME
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select *From Tbl_Randevular where RandevuDoktor='"+lbl_AdSoyad.Text+"'", sqlBaglanti.Baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void btn_BilgileriDuzenle_Click(object sender, EventArgs e)
        {
            FrmDoktorBilgiDuzenle fr = new FrmDoktorBilgiDuzenle();
            fr.tc = lbl_TC.Text;
            fr.Show();
        }

        private void btn_Duyurular_Click(object sender, EventArgs e)
        {
            FrmDuyurular frm = new FrmDuyurular();
            frm.Show();
        }

        private void btn_Cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            richTxt_HastaSikayetBilgisi.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
        }
    }
}
