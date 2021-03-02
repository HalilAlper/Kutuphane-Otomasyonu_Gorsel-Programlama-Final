
namespace GorselProje.Presentation
{
    partial class KitapListe
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KitapListe));
            this.dgv_kitaplar = new System.Windows.Forms.DataGridView();
            this.kitapNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yazar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yayinevi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sayfaSayisi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.basimTarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_kitapEmanet = new System.Windows.Forms.Button();
            this.btn_adAra = new System.Windows.Forms.Button();
            this.tb_adAra = new System.Windows.Forms.TextBox();
            this.btn_noAra = new System.Windows.Forms.Button();
            this.tb_noAra = new System.Windows.Forms.TextBox();
            this.btn_kitapDuzenle = new System.Windows.Forms.Button();
            this.btn_kitapSil = new System.Windows.Forms.Button();
            this.btn_kitapEkle = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btn_grafik = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_kitaplar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_kitaplar
            // 
            this.dgv_kitaplar.AllowUserToAddRows = false;
            this.dgv_kitaplar.AllowUserToDeleteRows = false;
            this.dgv_kitaplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_kitaplar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kitapNo,
            this.kitapAd,
            this.yazar,
            this.yayinevi,
            this.turAd,
            this.sayfaSayisi,
            this.basimTarih,
            this.adet});
            this.dgv_kitaplar.Location = new System.Drawing.Point(10, 12);
            this.dgv_kitaplar.Name = "dgv_kitaplar";
            this.dgv_kitaplar.ReadOnly = true;
            this.dgv_kitaplar.Size = new System.Drawing.Size(818, 263);
            this.dgv_kitaplar.TabIndex = 1;
            // 
            // kitapNo
            // 
            this.kitapNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.kitapNo.FillWeight = 50F;
            this.kitapNo.HeaderText = "Kitap No";
            this.kitapNo.Name = "kitapNo";
            this.kitapNo.ReadOnly = true;
            // 
            // kitapAd
            // 
            this.kitapAd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.kitapAd.FillWeight = 150F;
            this.kitapAd.HeaderText = "Kitap Adı";
            this.kitapAd.Name = "kitapAd";
            this.kitapAd.ReadOnly = true;
            // 
            // yazar
            // 
            this.yazar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.yazar.HeaderText = "Yazar";
            this.yazar.Name = "yazar";
            this.yazar.ReadOnly = true;
            // 
            // yayinevi
            // 
            this.yayinevi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.yayinevi.HeaderText = "Yayınevi";
            this.yayinevi.Name = "yayinevi";
            this.yayinevi.ReadOnly = true;
            // 
            // turAd
            // 
            this.turAd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.turAd.HeaderText = "Tür";
            this.turAd.Name = "turAd";
            this.turAd.ReadOnly = true;
            // 
            // sayfaSayisi
            // 
            this.sayfaSayisi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sayfaSayisi.FillWeight = 50F;
            this.sayfaSayisi.HeaderText = "Sayfa Sayısı";
            this.sayfaSayisi.Name = "sayfaSayisi";
            this.sayfaSayisi.ReadOnly = true;
            // 
            // basimTarih
            // 
            this.basimTarih.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.basimTarih.HeaderText = "Basım Tarihi";
            this.basimTarih.Name = "basimTarih";
            this.basimTarih.ReadOnly = true;
            // 
            // adet
            // 
            this.adet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.adet.FillWeight = 50F;
            this.adet.HeaderText = "Adet";
            this.adet.Name = "adet";
            this.adet.ReadOnly = true;
            // 
            // btn_kitapEmanet
            // 
            this.btn_kitapEmanet.BackgroundImage = global::GorselProje.Properties.Resources.emanet;
            this.btn_kitapEmanet.Location = new System.Drawing.Point(628, 281);
            this.btn_kitapEmanet.Name = "btn_kitapEmanet";
            this.btn_kitapEmanet.Size = new System.Drawing.Size(200, 200);
            this.btn_kitapEmanet.TabIndex = 16;
            this.btn_kitapEmanet.UseVisualStyleBackColor = true;
            this.btn_kitapEmanet.Click += new System.EventHandler(this.btn_kitapEmanet_Click);
            // 
            // btn_adAra
            // 
            this.btn_adAra.BackgroundImage = global::GorselProje.Properties.Resources.buyutec;
            this.btn_adAra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_adAra.Location = new System.Drawing.Point(593, 488);
            this.btn_adAra.Name = "btn_adAra";
            this.btn_adAra.Size = new System.Drawing.Size(29, 29);
            this.btn_adAra.TabIndex = 15;
            this.btn_adAra.UseVisualStyleBackColor = true;
            this.btn_adAra.Click += new System.EventHandler(this.btn_adAra_Click);
            // 
            // tb_adAra
            // 
            this.tb_adAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_adAra.Location = new System.Drawing.Point(628, 488);
            this.tb_adAra.Name = "tb_adAra";
            this.tb_adAra.Size = new System.Drawing.Size(200, 29);
            this.tb_adAra.TabIndex = 14;
            this.tb_adAra.Text = "Ada Göre Ara...";
            this.tb_adAra.Enter += new System.EventHandler(this.tb_adAra_Enter);
            this.tb_adAra.Leave += new System.EventHandler(this.tb_adAra_Leave);
            // 
            // btn_noAra
            // 
            this.btn_noAra.BackgroundImage = global::GorselProje.Properties.Resources.buyutec;
            this.btn_noAra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_noAra.Location = new System.Drawing.Point(216, 488);
            this.btn_noAra.Name = "btn_noAra";
            this.btn_noAra.Size = new System.Drawing.Size(29, 29);
            this.btn_noAra.TabIndex = 13;
            this.btn_noAra.UseVisualStyleBackColor = true;
            this.btn_noAra.Click += new System.EventHandler(this.btn_noAra_Click);
            // 
            // tb_noAra
            // 
            this.tb_noAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_noAra.Location = new System.Drawing.Point(10, 488);
            this.tb_noAra.Name = "tb_noAra";
            this.tb_noAra.Size = new System.Drawing.Size(200, 29);
            this.tb_noAra.TabIndex = 12;
            this.tb_noAra.Text = "Kitap No Ara...";
            this.tb_noAra.Enter += new System.EventHandler(this.tb_noAra_Enter);
            this.tb_noAra.Leave += new System.EventHandler(this.tb_noAra_Leave);
            // 
            // btn_kitapDuzenle
            // 
            this.btn_kitapDuzenle.BackgroundImage = global::GorselProje.Properties.Resources.kitapduzenle;
            this.btn_kitapDuzenle.Location = new System.Drawing.Point(422, 281);
            this.btn_kitapDuzenle.Name = "btn_kitapDuzenle";
            this.btn_kitapDuzenle.Size = new System.Drawing.Size(200, 200);
            this.btn_kitapDuzenle.TabIndex = 11;
            this.btn_kitapDuzenle.UseVisualStyleBackColor = true;
            this.btn_kitapDuzenle.Click += new System.EventHandler(this.btn_kitapDuzenle_Click);
            // 
            // btn_kitapSil
            // 
            this.btn_kitapSil.BackgroundImage = global::GorselProje.Properties.Resources.kitapsil;
            this.btn_kitapSil.Location = new System.Drawing.Point(216, 281);
            this.btn_kitapSil.Name = "btn_kitapSil";
            this.btn_kitapSil.Size = new System.Drawing.Size(200, 200);
            this.btn_kitapSil.TabIndex = 10;
            this.btn_kitapSil.UseVisualStyleBackColor = true;
            this.btn_kitapSil.Click += new System.EventHandler(this.btn_kitapSil_Click);
            // 
            // btn_kitapEkle
            // 
            this.btn_kitapEkle.BackgroundImage = global::GorselProje.Properties.Resources.yenikitap;
            this.btn_kitapEkle.Location = new System.Drawing.Point(10, 281);
            this.btn_kitapEkle.Name = "btn_kitapEkle";
            this.btn_kitapEkle.Size = new System.Drawing.Size(200, 200);
            this.btn_kitapEkle.TabIndex = 9;
            this.btn_kitapEkle.UseVisualStyleBackColor = true;
            this.btn_kitapEkle.Click += new System.EventHandler(this.btn_kitapEkle_Click);
            // 
            // toolTip
            // 
            this.toolTip.AutomaticDelay = 100;
            this.toolTip.AutoPopDelay = 5000;
            this.toolTip.InitialDelay = 100;
            this.toolTip.ReshowDelay = 20;
            // 
            // btn_grafik
            // 
            this.btn_grafik.BackgroundImage = global::GorselProje.Properties.Resources.grafik;
            this.btn_grafik.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_grafik.Location = new System.Drawing.Point(834, 12);
            this.btn_grafik.Name = "btn_grafik";
            this.btn_grafik.Size = new System.Drawing.Size(95, 95);
            this.btn_grafik.TabIndex = 27;
            this.btn_grafik.UseVisualStyleBackColor = true;
            this.btn_grafik.Click += new System.EventHandler(this.btn_grafik_Click);
            // 
            // KitapListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.ClientSize = new System.Drawing.Size(935, 524);
            this.Controls.Add(this.btn_grafik);
            this.Controls.Add(this.btn_kitapEmanet);
            this.Controls.Add(this.btn_adAra);
            this.Controls.Add(this.tb_adAra);
            this.Controls.Add(this.btn_noAra);
            this.Controls.Add(this.tb_noAra);
            this.Controls.Add(this.btn_kitapDuzenle);
            this.Controls.Add(this.btn_kitapSil);
            this.Controls.Add(this.btn_kitapEkle);
            this.Controls.Add(this.dgv_kitaplar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KitapListe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitaplar";
            this.Load += new System.EventHandler(this.KitapListe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_kitaplar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_kitaplar;
        private System.Windows.Forms.Button btn_kitapEmanet;
        private System.Windows.Forms.Button btn_adAra;
        private System.Windows.Forms.TextBox tb_adAra;
        private System.Windows.Forms.Button btn_noAra;
        private System.Windows.Forms.TextBox tb_noAra;
        private System.Windows.Forms.Button btn_kitapDuzenle;
        private System.Windows.Forms.Button btn_kitapSil;
        private System.Windows.Forms.Button btn_kitapEkle;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn yazar;
        private System.Windows.Forms.DataGridViewTextBoxColumn yayinevi;
        private System.Windows.Forms.DataGridViewTextBoxColumn turAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn sayfaSayisi;
        private System.Windows.Forms.DataGridViewTextBoxColumn basimTarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn adet;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button btn_grafik;
    }
}