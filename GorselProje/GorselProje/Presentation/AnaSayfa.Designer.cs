
namespace GorselProje
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl_Hosgeldin = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btn_emanet = new System.Windows.Forms.Button();
            this.btn_kitaplar = new System.Windows.Forms.Button();
            this.btn_ogrenciler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Hosgeldin
            // 
            this.lbl_Hosgeldin.AutoSize = true;
            this.lbl_Hosgeldin.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Hosgeldin.Location = new System.Drawing.Point(12, 9);
            this.lbl_Hosgeldin.Name = "lbl_Hosgeldin";
            this.lbl_Hosgeldin.Size = new System.Drawing.Size(228, 28);
            this.lbl_Hosgeldin.TabIndex = 2;
            this.lbl_Hosgeldin.Text = "Hoş geldiniz ADMIN";
            // 
            // toolTip
            // 
            this.toolTip.AutomaticDelay = 100;
            this.toolTip.AutoPopDelay = 5000;
            this.toolTip.InitialDelay = 100;
            this.toolTip.ReshowDelay = 20;
            // 
            // btn_emanet
            // 
            this.btn_emanet.Image = global::GorselProje.Properties.Resources.emanet;
            this.btn_emanet.Location = new System.Drawing.Point(424, 48);
            this.btn_emanet.Name = "btn_emanet";
            this.btn_emanet.Size = new System.Drawing.Size(200, 200);
            this.btn_emanet.TabIndex = 3;
            this.btn_emanet.UseVisualStyleBackColor = true;
            this.btn_emanet.Click += new System.EventHandler(this.btn_emanet_Click);
            // 
            // btn_kitaplar
            // 
            this.btn_kitaplar.Image = global::GorselProje.Properties.Resources.kitap;
            this.btn_kitaplar.Location = new System.Drawing.Point(218, 48);
            this.btn_kitaplar.Name = "btn_kitaplar";
            this.btn_kitaplar.Size = new System.Drawing.Size(200, 200);
            this.btn_kitaplar.TabIndex = 1;
            this.btn_kitaplar.UseVisualStyleBackColor = true;
            this.btn_kitaplar.Click += new System.EventHandler(this.btn_kitaplar_Click);
            // 
            // btn_ogrenciler
            // 
            this.btn_ogrenciler.Image = global::GorselProje.Properties.Resources.uyeler;
            this.btn_ogrenciler.Location = new System.Drawing.Point(12, 48);
            this.btn_ogrenciler.Name = "btn_ogrenciler";
            this.btn_ogrenciler.Size = new System.Drawing.Size(200, 200);
            this.btn_ogrenciler.TabIndex = 0;
            this.btn_ogrenciler.UseVisualStyleBackColor = true;
            this.btn_ogrenciler.Click += new System.EventHandler(this.btn_ogrenciler_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(635, 259);
            this.Controls.Add(this.btn_emanet);
            this.Controls.Add(this.lbl_Hosgeldin);
            this.Controls.Add(this.btn_kitaplar);
            this.Controls.Add(this.btn_ogrenciler);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Sayfa - Kütüphane Otomasyonu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ogrenciler;
        private System.Windows.Forms.Button btn_kitaplar;
        private System.Windows.Forms.Label lbl_Hosgeldin;
        private System.Windows.Forms.Button btn_emanet;
        private System.Windows.Forms.ToolTip toolTip;
    }
}

