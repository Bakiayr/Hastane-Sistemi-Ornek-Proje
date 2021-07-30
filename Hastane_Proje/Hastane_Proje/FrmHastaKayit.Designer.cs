
namespace Hastane_Proje
{
    partial class HastaKayıt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HastaKayıt));
            this.mskTxt_TC = new System.Windows.Forms.MaskedTextBox();
            this.txt_Sifre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Soyad = new System.Windows.Forms.TextBox();
            this.txt_Ad = new System.Windows.Forms.TextBox();
            this.mskTxt_TelNo = new System.Windows.Forms.MaskedTextBox();
            this.cmbBox_Cinsiyet = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_KayitOl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mskTxt_TC
            // 
            this.mskTxt_TC.Location = new System.Drawing.Point(133, 97);
            this.mskTxt_TC.Mask = "00000000000";
            this.mskTxt_TC.Name = "mskTxt_TC";
            this.mskTxt_TC.Size = new System.Drawing.Size(145, 31);
            this.mskTxt_TC.TabIndex = 3;
            this.mskTxt_TC.ValidatingType = typeof(int);
            // 
            // txt_Sifre
            // 
            this.txt_Sifre.Location = new System.Drawing.Point(133, 171);
            this.txt_Sifre.Name = "txt_Sifre";
            this.txt_Sifre.Size = new System.Drawing.Size(145, 31);
            this.txt_Sifre.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Şifre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "TC Kimlik No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Soyad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ad:";
            // 
            // txt_Soyad
            // 
            this.txt_Soyad.Location = new System.Drawing.Point(133, 60);
            this.txt_Soyad.Name = "txt_Soyad";
            this.txt_Soyad.Size = new System.Drawing.Size(145, 31);
            this.txt_Soyad.TabIndex = 2;
            // 
            // txt_Ad
            // 
            this.txt_Ad.Location = new System.Drawing.Point(133, 23);
            this.txt_Ad.Name = "txt_Ad";
            this.txt_Ad.Size = new System.Drawing.Size(145, 31);
            this.txt_Ad.TabIndex = 1;
            // 
            // mskTxt_TelNo
            // 
            this.mskTxt_TelNo.Location = new System.Drawing.Point(133, 134);
            this.mskTxt_TelNo.Mask = "(999) 000-0000";
            this.mskTxt_TelNo.Name = "mskTxt_TelNo";
            this.mskTxt_TelNo.Size = new System.Drawing.Size(145, 31);
            this.mskTxt_TelNo.TabIndex = 4;
            // 
            // cmbBox_Cinsiyet
            // 
            this.cmbBox_Cinsiyet.FormattingEnabled = true;
            this.cmbBox_Cinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cmbBox_Cinsiyet.Location = new System.Drawing.Point(133, 209);
            this.cmbBox_Cinsiyet.Name = "cmbBox_Cinsiyet";
            this.cmbBox_Cinsiyet.Size = new System.Drawing.Size(145, 31);
            this.cmbBox_Cinsiyet.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 23);
            this.label5.TabIndex = 15;
            this.label5.Text = "Cinsiyet:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 17;
            this.label7.Text = "Telefon No:";
            // 
            // btn_KayitOl
            // 
            this.btn_KayitOl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_KayitOl.Location = new System.Drawing.Point(133, 257);
            this.btn_KayitOl.Name = "btn_KayitOl";
            this.btn_KayitOl.Size = new System.Drawing.Size(145, 33);
            this.btn_KayitOl.TabIndex = 7;
            this.btn_KayitOl.Text = "Kayıt Ol";
            this.btn_KayitOl.UseVisualStyleBackColor = false;
            this.btn_KayitOl.Click += new System.EventHandler(this.btn_KayitOl_Click);
            // 
            // HastaKayıt
            // 
            this.AcceptButton = this.btn_KayitOl;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(342, 317);
            this.Controls.Add(this.btn_KayitOl);
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
            this.Name = "HastaKayıt";
            this.Text = "FrmHastaKayit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mskTxt_TC;
        private System.Windows.Forms.TextBox txt_Sifre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Soyad;
        private System.Windows.Forms.TextBox txt_Ad;
        private System.Windows.Forms.MaskedTextBox mskTxt_TelNo;
        private System.Windows.Forms.ComboBox cmbBox_Cinsiyet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_KayitOl;
    }
}