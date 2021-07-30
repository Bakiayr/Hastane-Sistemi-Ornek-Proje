
namespace Hastane_Proje
{
    partial class FrmHastaGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHastaGiris));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Sifre = new System.Windows.Forms.TextBox();
            this.maskedtxt_TC = new System.Windows.Forms.MaskedTextBox();
            this.linklbl_UyeOl = new System.Windows.Forms.LinkLabel();
            this.btn_GirisYap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC Kimlik No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Harlow Solid Italic", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(93, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(238, 34);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hasta Giriş Sistemi";
            // 
            // txt_Sifre
            // 
            this.txt_Sifre.Location = new System.Drawing.Point(151, 111);
            this.txt_Sifre.Name = "txt_Sifre";
            this.txt_Sifre.PasswordChar = '*';
            this.txt_Sifre.Size = new System.Drawing.Size(145, 31);
            this.txt_Sifre.TabIndex = 2;
            // 
            // maskedtxt_TC
            // 
            this.maskedtxt_TC.Location = new System.Drawing.Point(151, 58);
            this.maskedtxt_TC.Mask = "00000000000";
            this.maskedtxt_TC.Name = "maskedtxt_TC";
            this.maskedtxt_TC.Size = new System.Drawing.Size(145, 31);
            this.maskedtxt_TC.TabIndex = 1;
            this.maskedtxt_TC.ValidatingType = typeof(int);
            // 
            // linklbl_UyeOl
            // 
            this.linklbl_UyeOl.AutoSize = true;
            this.linklbl_UyeOl.Location = new System.Drawing.Point(321, 114);
            this.linklbl_UyeOl.Name = "linklbl_UyeOl";
            this.linklbl_UyeOl.Size = new System.Drawing.Size(62, 23);
            this.linklbl_UyeOl.TabIndex = 3;
            this.linklbl_UyeOl.TabStop = true;
            this.linklbl_UyeOl.Text = "Üye Ol";
            this.linklbl_UyeOl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_UyeOl_LinkClicked);
            // 
            // btn_GirisYap
            // 
            this.btn_GirisYap.Location = new System.Drawing.Point(151, 159);
            this.btn_GirisYap.Name = "btn_GirisYap";
            this.btn_GirisYap.Size = new System.Drawing.Size(145, 35);
            this.btn_GirisYap.TabIndex = 4;
            this.btn_GirisYap.Text = "Giriş Yap";
            this.btn_GirisYap.UseVisualStyleBackColor = true;
            this.btn_GirisYap.Click += new System.EventHandler(this.btn_GirisYap_Click);
            // 
            // FrmHastaGiris
            // 
            this.AcceptButton = this.btn_GirisYap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(416, 230);
            this.Controls.Add(this.btn_GirisYap);
            this.Controls.Add(this.linklbl_UyeOl);
            this.Controls.Add(this.maskedtxt_TC);
            this.Controls.Add(this.txt_Sifre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FrmHastaGiris";
            this.Text = "HastaGirişi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Sifre;
        private System.Windows.Forms.MaskedTextBox maskedtxt_TC;
        private System.Windows.Forms.LinkLabel linklbl_UyeOl;
        private System.Windows.Forms.Button btn_GirisYap;
    }
}