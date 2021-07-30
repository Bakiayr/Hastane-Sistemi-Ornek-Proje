
namespace Hastane_Proje
{
    partial class FrmHastaDetay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHastaDetay));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_TC = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_AdSoyad = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_RandevuID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLbl_BilgileriDuzenle = new System.Windows.Forms.LinkLabel();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbBox_Doktor = new System.Windows.Forms.ComboBox();
            this.richTxt_Sikayet = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_RandevuAl = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbBox_Brans = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView_RandevuGecmisi = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView_AktifRandevular = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_RandevuGecmisi)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AktifRandevular)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(50, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC No:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lbl_TC);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lbl_AdSoyad);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 164);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hasta Bilgisi";
            // 
            // lbl_TC
            // 
            this.lbl_TC.AutoSize = true;
            this.lbl_TC.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_TC.Location = new System.Drawing.Point(114, 47);
            this.lbl_TC.Name = "lbl_TC";
            this.lbl_TC.Size = new System.Drawing.Size(120, 23);
            this.lbl_TC.TabIndex = 5;
            this.lbl_TC.Text = "00000000000";
            this.lbl_TC.Click += new System.EventHandler(this.lbl_TC_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(25, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ad Soyad:";
            // 
            // lbl_AdSoyad
            // 
            this.lbl_AdSoyad.AutoSize = true;
            this.lbl_AdSoyad.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_AdSoyad.Location = new System.Drawing.Point(114, 85);
            this.lbl_AdSoyad.Name = "lbl_AdSoyad";
            this.lbl_AdSoyad.Size = new System.Drawing.Size(100, 23);
            this.lbl_AdSoyad.TabIndex = 3;
            this.lbl_AdSoyad.Text = "Null       Null";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_RandevuID);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.linkLbl_BilgileriDuzenle);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.cmbBox_Doktor);
            this.groupBox2.Controls.Add(this.richTxt_Sikayet);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.btn_RandevuAl);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cmbBox_Brans);
            this.groupBox2.Location = new System.Drawing.Point(12, 182);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(291, 338);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Randevu Paneli";
            // 
            // txt_RandevuID
            // 
            this.txt_RandevuID.Enabled = false;
            this.txt_RandevuID.Location = new System.Drawing.Point(97, 30);
            this.txt_RandevuID.Name = "txt_RandevuID";
            this.txt_RandevuID.Size = new System.Drawing.Size(172, 31);
            this.txt_RandevuID.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "ID:";
            // 
            // linkLbl_BilgileriDuzenle
            // 
            this.linkLbl_BilgileriDuzenle.AutoSize = true;
            this.linkLbl_BilgileriDuzenle.Location = new System.Drawing.Point(6, 312);
            this.linkLbl_BilgileriDuzenle.Name = "linkLbl_BilgileriDuzenle";
            this.linkLbl_BilgileriDuzenle.Size = new System.Drawing.Size(133, 23);
            this.linkLbl_BilgileriDuzenle.TabIndex = 9;
            this.linkLbl_BilgileriDuzenle.TabStop = true;
            this.linkLbl_BilgileriDuzenle.Text = "Bilgileri Düzenle";
            this.linkLbl_BilgileriDuzenle.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLbl_BilgileriDuzenle_LinkClicked);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 23);
            this.label8.TabIndex = 8;
            this.label8.Text = "Şikayet:";
            // 
            // cmbBox_Doktor
            // 
            this.cmbBox_Doktor.FormattingEnabled = true;
            this.cmbBox_Doktor.Location = new System.Drawing.Point(97, 111);
            this.cmbBox_Doktor.Name = "cmbBox_Doktor";
            this.cmbBox_Doktor.Size = new System.Drawing.Size(172, 31);
            this.cmbBox_Doktor.TabIndex = 2;
            this.cmbBox_Doktor.SelectedIndexChanged += new System.EventHandler(this.cmbBox_Doktor_SelectedIndexChanged);
            // 
            // richTxt_Sikayet
            // 
            this.richTxt_Sikayet.Location = new System.Drawing.Point(97, 148);
            this.richTxt_Sikayet.Name = "richTxt_Sikayet";
            this.richTxt_Sikayet.Size = new System.Drawing.Size(172, 118);
            this.richTxt_Sikayet.TabIndex = 3;
            this.richTxt_Sikayet.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "Doktor:";
            // 
            // btn_RandevuAl
            // 
            this.btn_RandevuAl.Location = new System.Drawing.Point(97, 272);
            this.btn_RandevuAl.Name = "btn_RandevuAl";
            this.btn_RandevuAl.Size = new System.Drawing.Size(172, 31);
            this.btn_RandevuAl.TabIndex = 4;
            this.btn_RandevuAl.Text = "Randevu Al";
            this.btn_RandevuAl.UseVisualStyleBackColor = true;
            this.btn_RandevuAl.Click += new System.EventHandler(this.btn_RandevuAl_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Branş:";
            // 
            // cmbBox_Brans
            // 
            this.cmbBox_Brans.FormattingEnabled = true;
            this.cmbBox_Brans.Location = new System.Drawing.Point(97, 69);
            this.cmbBox_Brans.Name = "cmbBox_Brans";
            this.cmbBox_Brans.Size = new System.Drawing.Size(172, 31);
            this.cmbBox_Brans.TabIndex = 1;
            this.cmbBox_Brans.SelectedIndexChanged += new System.EventHandler(this.cmbBox_Brans_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView_RandevuGecmisi);
            this.groupBox3.Location = new System.Drawing.Point(309, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(643, 272);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Randevu Geçmişi";
            // 
            // dataGridView_RandevuGecmisi
            // 
            this.dataGridView_RandevuGecmisi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_RandevuGecmisi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_RandevuGecmisi.Location = new System.Drawing.Point(3, 27);
            this.dataGridView_RandevuGecmisi.Name = "dataGridView_RandevuGecmisi";
            this.dataGridView_RandevuGecmisi.Size = new System.Drawing.Size(637, 242);
            this.dataGridView_RandevuGecmisi.TabIndex = 0;
            this.dataGridView_RandevuGecmisi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_RandevuGecmisi_CellContentClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView_AktifRandevular);
            this.groupBox4.Location = new System.Drawing.Point(309, 290);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(643, 230);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Aktif Randevular";
            // 
            // dataGridView_AktifRandevular
            // 
            this.dataGridView_AktifRandevular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_AktifRandevular.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_AktifRandevular.Location = new System.Drawing.Point(3, 27);
            this.dataGridView_AktifRandevular.Name = "dataGridView_AktifRandevular";
            this.dataGridView_AktifRandevular.Size = new System.Drawing.Size(637, 200);
            this.dataGridView_AktifRandevular.TabIndex = 0;
            this.dataGridView_AktifRandevular.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_AktifRandevular_CellClick);
            // 
            // FrmHastaDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(959, 528);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmHastaDetay";
            this.Text = "Hasta Detay";
            this.Load += new System.EventHandler(this.FrmHastaDetay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_RandevuGecmisi)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AktifRandevular)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_TC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_AdSoyad;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbBox_Doktor;
        private System.Windows.Forms.RichTextBox richTxt_Sikayet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_RandevuAl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbBox_Brans;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView_RandevuGecmisi;
        private System.Windows.Forms.DataGridView dataGridView_AktifRandevular;
        private System.Windows.Forms.LinkLabel linkLbl_BilgileriDuzenle;
        private System.Windows.Forms.TextBox txt_RandevuID;
        private System.Windows.Forms.Label label3;
    }
}