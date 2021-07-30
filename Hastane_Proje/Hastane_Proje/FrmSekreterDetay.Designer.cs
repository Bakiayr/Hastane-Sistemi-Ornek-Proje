
namespace Hastane_Proje
{
    partial class FrmSekreterDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSekreterDetay));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_TC = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_AdSoyad = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_DuyuruOlustur = new System.Windows.Forms.Button();
            this.richTxt_Duyuru = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBox_Durum = new System.Windows.Forms.CheckBox();
            this.btn_Kaydet = new System.Windows.Forms.Button();
            this.mskTxt_TC = new System.Windows.Forms.MaskedTextBox();
            this.cmbBox_Doktor = new System.Windows.Forms.ComboBox();
            this.cmbBox_Brans = new System.Windows.Forms.ComboBox();
            this.mskTxt_Saat = new System.Windows.Forms.MaskedTextBox();
            this.mskTxt_Tarih = new System.Windows.Forms.MaskedTextBox();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView_Branslar = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dataGridView_Doktorlar = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btn_BransPaneli = new System.Windows.Forms.Button();
            this.btn_RandevuListe = new System.Windows.Forms.Button();
            this.btn_DoktorPaneli = new System.Windows.Forms.Button();
            this.btn_Duyurular = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Branslar)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Doktorlar)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lbl_TC);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lbl_AdSoyad);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(291, 139);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sekreter Bilgisi";
            // 
            // lbl_TC
            // 
            this.lbl_TC.AutoSize = true;
            this.lbl_TC.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_TC.Location = new System.Drawing.Point(128, 47);
            this.lbl_TC.Name = "lbl_TC";
            this.lbl_TC.Size = new System.Drawing.Size(120, 23);
            this.lbl_TC.TabIndex = 5;
            this.lbl_TC.Text = "00000000000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(24, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ad Soyad:";
            // 
            // lbl_AdSoyad
            // 
            this.lbl_AdSoyad.AutoSize = true;
            this.lbl_AdSoyad.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_AdSoyad.Location = new System.Drawing.Point(128, 85);
            this.lbl_AdSoyad.Name = "lbl_AdSoyad";
            this.lbl_AdSoyad.Size = new System.Drawing.Size(100, 23);
            this.lbl_AdSoyad.TabIndex = 3;
            this.lbl_AdSoyad.Text = "Null       Null";
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_DuyuruOlustur);
            this.groupBox2.Controls.Add(this.richTxt_Duyuru);
            this.groupBox2.Location = new System.Drawing.Point(12, 157);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(291, 213);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Duyuru Oluştur";
            // 
            // btn_DuyuruOlustur
            // 
            this.btn_DuyuruOlustur.Location = new System.Drawing.Point(54, 173);
            this.btn_DuyuruOlustur.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_DuyuruOlustur.Name = "btn_DuyuruOlustur";
            this.btn_DuyuruOlustur.Size = new System.Drawing.Size(180, 34);
            this.btn_DuyuruOlustur.TabIndex = 1;
            this.btn_DuyuruOlustur.Text = "Oluştur";
            this.btn_DuyuruOlustur.UseVisualStyleBackColor = true;
            this.btn_DuyuruOlustur.Click += new System.EventHandler(this.btn_DuyuruOlustur_Click);
            // 
            // richTxt_Duyuru
            // 
            this.richTxt_Duyuru.Location = new System.Drawing.Point(6, 30);
            this.richTxt_Duyuru.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTxt_Duyuru.Name = "richTxt_Duyuru";
            this.richTxt_Duyuru.Size = new System.Drawing.Size(278, 137);
            this.richTxt_Duyuru.TabIndex = 0;
            this.richTxt_Duyuru.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBox_Durum);
            this.groupBox3.Controls.Add(this.btn_Kaydet);
            this.groupBox3.Controls.Add(this.mskTxt_TC);
            this.groupBox3.Controls.Add(this.cmbBox_Doktor);
            this.groupBox3.Controls.Add(this.cmbBox_Brans);
            this.groupBox3.Controls.Add(this.mskTxt_Saat);
            this.groupBox3.Controls.Add(this.mskTxt_Tarih);
            this.groupBox3.Controls.Add(this.txt_ID);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(309, 12);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(318, 358);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Randevu Paneli";
            // 
            // checkBox_Durum
            // 
            this.checkBox_Durum.AutoSize = true;
            this.checkBox_Durum.Location = new System.Drawing.Point(101, 259);
            this.checkBox_Durum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox_Durum.Name = "checkBox_Durum";
            this.checkBox_Durum.Size = new System.Drawing.Size(84, 27);
            this.checkBox_Durum.TabIndex = 12;
            this.checkBox_Durum.Text = "Durum";
            this.checkBox_Durum.UseVisualStyleBackColor = true;
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.Location = new System.Drawing.Point(58, 290);
            this.btn_Kaydet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.Size = new System.Drawing.Size(198, 30);
            this.btn_Kaydet.TabIndex = 14;
            this.btn_Kaydet.Text = "Kaydet";
            this.btn_Kaydet.UseVisualStyleBackColor = true;
            this.btn_Kaydet.Click += new System.EventHandler(this.btn_Kaydet_Click);
            // 
            // mskTxt_TC
            // 
            this.mskTxt_TC.Location = new System.Drawing.Point(82, 219);
            this.mskTxt_TC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mskTxt_TC.Mask = "00000000000";
            this.mskTxt_TC.Name = "mskTxt_TC";
            this.mskTxt_TC.Size = new System.Drawing.Size(164, 31);
            this.mskTxt_TC.TabIndex = 11;
            this.mskTxt_TC.ValidatingType = typeof(int);
            // 
            // cmbBox_Doktor
            // 
            this.cmbBox_Doktor.FormattingEnabled = true;
            this.cmbBox_Doktor.Location = new System.Drawing.Point(83, 182);
            this.cmbBox_Doktor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbBox_Doktor.Name = "cmbBox_Doktor";
            this.cmbBox_Doktor.Size = new System.Drawing.Size(164, 31);
            this.cmbBox_Doktor.TabIndex = 10;
//            this.cmbBox_Doktor.SelectedIndexChanged += new System.EventHandler(this.cmbBox_Doktor_SelectedIndexChanged);
            // 
            // cmbBox_Brans
            // 
            this.cmbBox_Brans.FormattingEnabled = true;
            this.cmbBox_Brans.Location = new System.Drawing.Point(83, 145);
            this.cmbBox_Brans.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbBox_Brans.Name = "cmbBox_Brans";
            this.cmbBox_Brans.Size = new System.Drawing.Size(164, 31);
            this.cmbBox_Brans.TabIndex = 9;
            this.cmbBox_Brans.SelectedIndexChanged += new System.EventHandler(this.cmbBox_Brans_SelectedIndexChanged);
            // 
            // mskTxt_Saat
            // 
            this.mskTxt_Saat.Location = new System.Drawing.Point(83, 107);
            this.mskTxt_Saat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mskTxt_Saat.Mask = "00:00";
            this.mskTxt_Saat.Name = "mskTxt_Saat";
            this.mskTxt_Saat.Size = new System.Drawing.Size(164, 31);
            this.mskTxt_Saat.TabIndex = 8;
            this.mskTxt_Saat.ValidatingType = typeof(System.DateTime);
            // 
            // mskTxt_Tarih
            // 
            this.mskTxt_Tarih.Location = new System.Drawing.Point(83, 70);
            this.mskTxt_Tarih.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mskTxt_Tarih.Mask = "00/00/0000";
            this.mskTxt_Tarih.Name = "mskTxt_Tarih";
            this.mskTxt_Tarih.Size = new System.Drawing.Size(164, 31);
            this.mskTxt_Tarih.TabIndex = 7;
            this.mskTxt_Tarih.ValidatingType = typeof(System.DateTime);
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(83, 33);
            this.txt_ID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(164, 31);
            this.txt_ID.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(40, 222);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 23);
            this.label9.TabIndex = 5;
            this.label9.Text = "TC:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 23);
            this.label7.TabIndex = 3;
            this.label7.Text = "Doktor:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 23);
            this.label6.TabIndex = 2;
            this.label6.Text = "Branş:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tarih:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Saat:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView_Branslar);
            this.groupBox4.Location = new System.Drawing.Point(633, 12);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(359, 225);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Branşlar";
            // 
            // dataGridView_Branslar
            // 
            this.dataGridView_Branslar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Branslar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Branslar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Branslar.Location = new System.Drawing.Point(3, 26);
            this.dataGridView_Branslar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView_Branslar.Name = "dataGridView_Branslar";
            this.dataGridView_Branslar.Size = new System.Drawing.Size(353, 197);
            this.dataGridView_Branslar.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dataGridView_Doktorlar);
            this.groupBox5.Location = new System.Drawing.Point(633, 240);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Size = new System.Drawing.Size(359, 230);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Doktorlar";
            // 
            // dataGridView_Doktorlar
            // 
            this.dataGridView_Doktorlar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Doktorlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Doktorlar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Doktorlar.Location = new System.Drawing.Point(3, 26);
            this.dataGridView_Doktorlar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView_Doktorlar.Name = "dataGridView_Doktorlar";
            this.dataGridView_Doktorlar.Size = new System.Drawing.Size(353, 202);
            this.dataGridView_Doktorlar.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btn_Duyurular);
            this.groupBox6.Controls.Add(this.btn_BransPaneli);
            this.groupBox6.Controls.Add(this.btn_RandevuListe);
            this.groupBox6.Controls.Add(this.btn_DoktorPaneli);
            this.groupBox6.Location = new System.Drawing.Point(12, 376);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox6.Size = new System.Drawing.Size(614, 94);
            this.groupBox6.TabIndex = 8;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Hızlı Erişim";
            // 
            // btn_BransPaneli
            // 
            this.btn_BransPaneli.Location = new System.Drawing.Point(170, 39);
            this.btn_BransPaneli.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_BransPaneli.Name = "btn_BransPaneli";
            this.btn_BransPaneli.Size = new System.Drawing.Size(139, 33);
            this.btn_BransPaneli.TabIndex = 2;
            this.btn_BransPaneli.Text = "Branş Paneli";
            this.btn_BransPaneli.UseVisualStyleBackColor = true;
            this.btn_BransPaneli.Click += new System.EventHandler(this.btn_BransPaneli_Click);
            // 
            // btn_RandevuListe
            // 
            this.btn_RandevuListe.Location = new System.Drawing.Point(315, 39);
            this.btn_RandevuListe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_RandevuListe.Name = "btn_RandevuListe";
            this.btn_RandevuListe.Size = new System.Drawing.Size(139, 33);
            this.btn_RandevuListe.TabIndex = 1;
            this.btn_RandevuListe.Text = "Randevu Liste";
            this.btn_RandevuListe.UseVisualStyleBackColor = true;
            this.btn_RandevuListe.Click += new System.EventHandler(this.btn_RandevuListe_Click);
            // 
            // btn_DoktorPaneli
            // 
            this.btn_DoktorPaneli.Location = new System.Drawing.Point(25, 39);
            this.btn_DoktorPaneli.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_DoktorPaneli.Name = "btn_DoktorPaneli";
            this.btn_DoktorPaneli.Size = new System.Drawing.Size(139, 33);
            this.btn_DoktorPaneli.TabIndex = 0;
            this.btn_DoktorPaneli.Text = "Doktor Paneli";
            this.btn_DoktorPaneli.UseVisualStyleBackColor = true;
            this.btn_DoktorPaneli.Click += new System.EventHandler(this.btn_DoktorPaneli_Click);
            // 
            // btn_Duyurular
            // 
            this.btn_Duyurular.Location = new System.Drawing.Point(460, 39);
            this.btn_Duyurular.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Duyurular.Name = "btn_Duyurular";
            this.btn_Duyurular.Size = new System.Drawing.Size(139, 33);
            this.btn_Duyurular.TabIndex = 3;
            this.btn_Duyurular.Text = "Duyurular";
            this.btn_Duyurular.UseVisualStyleBackColor = true;
            this.btn_Duyurular.Click += new System.EventHandler(this.btn_Duyurular_Click);
            // 
            // FrmSekreterDetay
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1004, 481);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmSekreterDetay";
            this.Text = "Sekreter Detay";
            this.Load += new System.EventHandler(this.FrmSekreterDetay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Branslar)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Doktorlar)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_TC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_AdSoyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_DuyuruOlustur;
        private System.Windows.Forms.RichTextBox richTxt_Duyuru;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkBox_Durum;
        private System.Windows.Forms.Button btn_Kaydet;
        private System.Windows.Forms.MaskedTextBox mskTxt_TC;
        private System.Windows.Forms.ComboBox cmbBox_Doktor;
        private System.Windows.Forms.ComboBox cmbBox_Brans;
        private System.Windows.Forms.MaskedTextBox mskTxt_Saat;
        private System.Windows.Forms.MaskedTextBox mskTxt_Tarih;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView_Branslar;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dataGridView_Doktorlar;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btn_BransPaneli;
        private System.Windows.Forms.Button btn_RandevuListe;
        private System.Windows.Forms.Button btn_DoktorPaneli;
        private System.Windows.Forms.Button btn_Duyurular;
    }
}