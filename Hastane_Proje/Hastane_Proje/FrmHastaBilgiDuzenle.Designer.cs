
namespace Hastane_Proje
{
    partial class FrmHastaBilgiDuzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHastaBilgiDuzenle));
            this.btn_BilgileriGuncelle = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbBox_Cinsiyet = new System.Windows.Forms.ComboBox();
            this.mskTxt_TelNo = new System.Windows.Forms.MaskedTextBox();
            this.txt_Ad = new System.Windows.Forms.TextBox();
            this.txt_Soyad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mskTxt_TC = new System.Windows.Forms.MaskedTextBox();
            this.txt_Sifre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_BilgileriGuncelle
            // 
            this.btn_BilgileriGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_BilgileriGuncelle.Location = new System.Drawing.Point(140, 235);
            this.btn_BilgileriGuncelle.Name = "btn_BilgileriGuncelle";
            this.btn_BilgileriGuncelle.Size = new System.Drawing.Size(145, 41);
            this.btn_BilgileriGuncelle.TabIndex = 7;
            this.btn_BilgileriGuncelle.Text = "Bilgileri Güncelle";
            this.btn_BilgileriGuncelle.UseVisualStyleBackColor = false;
            this.btn_BilgileriGuncelle.Click += new System.EventHandler(this.btn_BilgileriGuncelle_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 30;
            this.label7.Text = "Telefon No:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 23);
            this.label5.TabIndex = 29;
            this.label5.Text = "Cinsiyet:";
            // 
            // cmbBox_Cinsiyet
            // 
            this.cmbBox_Cinsiyet.FormattingEnabled = true;
            this.cmbBox_Cinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cmbBox_Cinsiyet.Location = new System.Drawing.Point(140, 198);
            this.cmbBox_Cinsiyet.Name = "cmbBox_Cinsiyet";
            this.cmbBox_Cinsiyet.Size = new System.Drawing.Size(145, 31);
            this.cmbBox_Cinsiyet.TabIndex = 6;
            // 
            // mskTxt_TelNo
            // 
            this.mskTxt_TelNo.Location = new System.Drawing.Point(140, 123);
            this.mskTxt_TelNo.Mask = "(999) 000-0000";
            this.mskTxt_TelNo.Name = "mskTxt_TelNo";
            this.mskTxt_TelNo.Size = new System.Drawing.Size(145, 31);
            this.mskTxt_TelNo.TabIndex = 4;
            // 
            // txt_Ad
            // 
            this.txt_Ad.Location = new System.Drawing.Point(140, 12);
            this.txt_Ad.Name = "txt_Ad";
            this.txt_Ad.Size = new System.Drawing.Size(145, 31);
            this.txt_Ad.TabIndex = 1;
            // 
            // txt_Soyad
            // 
            this.txt_Soyad.Location = new System.Drawing.Point(140, 49);
            this.txt_Soyad.Name = "txt_Soyad";
            this.txt_Soyad.Size = new System.Drawing.Size(145, 31);
            this.txt_Soyad.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(97, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 23);
            this.label4.TabIndex = 24;
            this.label4.Text = "Ad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 23);
            this.label3.TabIndex = 23;
            this.label3.Text = "Soyad:";
            // 
            // mskTxt_TC
            // 
            this.mskTxt_TC.Location = new System.Drawing.Point(140, 86);
            this.mskTxt_TC.Mask = "00000000000";
            this.mskTxt_TC.Name = "mskTxt_TC";
            this.mskTxt_TC.Size = new System.Drawing.Size(145, 31);
            this.mskTxt_TC.TabIndex = 3;
            this.mskTxt_TC.ValidatingType = typeof(int);
            // 
            // txt_Sifre
            // 
            this.txt_Sifre.Location = new System.Drawing.Point(140, 160);
            this.txt_Sifre.Name = "txt_Sifre";
            this.txt_Sifre.Size = new System.Drawing.Size(145, 31);
            this.txt_Sifre.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 23);
            this.label2.TabIndex = 20;
            this.label2.Text = "Şifre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 23);
            this.label1.TabIndex = 19;
            this.label1.Text = "TC Kimlik No:";
            // 
            // FrmHastaBilgiDuzenle
            // 
            this.AcceptButton = this.btn_BilgileriGuncelle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(358, 324);
            this.Controls.Add(this.btn_BilgileriGuncelle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbBox_Cinsiyet);
            this.Controls.Add(this.mskTxt_TelNo);
            this.Controls.Add(this.txt_Ad);
            this.Controls.Add(this.txt_Soyad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mskTxt_TC);
            this.Controls.Add(this.txt_Sifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FrmHastaBilgiDuzenle";
            this.Text = "Bilgi Güncelleme";
            this.Load += new System.EventHandler(this.FrmHastaBilgiDuzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_BilgileriGuncelle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbBox_Cinsiyet;
        private System.Windows.Forms.MaskedTextBox mskTxt_TelNo;
        private System.Windows.Forms.TextBox txt_Ad;
        private System.Windows.Forms.TextBox txt_Soyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mskTxt_TC;
        private System.Windows.Forms.TextBox txt_Sifre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}