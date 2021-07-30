
namespace Hastane_Proje
{
    partial class FrmGirisler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGirisler));
            this.btn_HastaGiris = new System.Windows.Forms.Button();
            this.btn_SekreterGiris = new System.Windows.Forms.Button();
            this.btn_DoktorGiris = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_HastaGiris
            // 
            this.btn_HastaGiris.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_HastaGiris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_HastaGiris.BackgroundImage")));
            this.btn_HastaGiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_HastaGiris.Location = new System.Drawing.Point(12, 12);
            this.btn_HastaGiris.Name = "btn_HastaGiris";
            this.btn_HastaGiris.Size = new System.Drawing.Size(141, 110);
            this.btn_HastaGiris.TabIndex = 0;
            this.btn_HastaGiris.UseVisualStyleBackColor = false;
            this.btn_HastaGiris.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_SekreterGiris
            // 
            this.btn_SekreterGiris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_SekreterGiris.BackgroundImage")));
            this.btn_SekreterGiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_SekreterGiris.Location = new System.Drawing.Point(386, 12);
            this.btn_SekreterGiris.Name = "btn_SekreterGiris";
            this.btn_SekreterGiris.Size = new System.Drawing.Size(141, 110);
            this.btn_SekreterGiris.TabIndex = 1;
            this.btn_SekreterGiris.UseVisualStyleBackColor = true;
            this.btn_SekreterGiris.Click += new System.EventHandler(this.btn_SekreterGiris_Click);
            // 
            // btn_DoktorGiris
            // 
            this.btn_DoktorGiris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_DoktorGiris.BackgroundImage")));
            this.btn_DoktorGiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_DoktorGiris.Location = new System.Drawing.Point(199, 12);
            this.btn_DoktorGiris.Name = "btn_DoktorGiris";
            this.btn_DoktorGiris.Size = new System.Drawing.Size(141, 110);
            this.btn_DoktorGiris.TabIndex = 2;
            this.btn_DoktorGiris.UseVisualStyleBackColor = true;
            this.btn_DoktorGiris.Click += new System.EventHandler(this.btn_DoktorGiris_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(240, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Doktor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hasta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(420, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sekreter";
            // 
            // FrmGirisler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(541, 164);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_DoktorGiris);
            this.Controls.Add(this.btn_SekreterGiris);
            this.Controls.Add(this.btn_HastaGiris);
            this.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "FrmGirisler";
            this.Text = "Hastane Giriş";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_HastaGiris;
        private System.Windows.Forms.Button btn_SekreterGiris;
        private System.Windows.Forms.Button btn_DoktorGiris;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

