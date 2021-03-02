
namespace GorselProje.Presentation
{
    partial class OgrenciListe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OgrenciListe));
            this.dgv_ogrenciler = new System.Windows.Forms.DataGridView();
            this.ogrenciNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gecIade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.tb_noAra = new System.Windows.Forms.TextBox();
            this.tb_adSoyadAra = new System.Windows.Forms.TextBox();
            this.btn_ogrenciEmanet = new System.Windows.Forms.Button();
            this.btn_adSoyadAra = new System.Windows.Forms.Button();
            this.btn_noAra = new System.Windows.Forms.Button();
            this.btn_ogrenciDuzenle = new System.Windows.Forms.Button();
            this.btn_ogrenciSil = new System.Windows.Forms.Button();
            this.btn_ogrenciEkle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ogrenciler)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_ogrenciler
            // 
            this.dgv_ogrenciler.AllowUserToAddRows = false;
            this.dgv_ogrenciler.AllowUserToDeleteRows = false;
            this.dgv_ogrenciler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ogrenciler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ogrenciNo,
            this.ad,
            this.soyad,
            this.borc,
            this.gecIade});
            this.dgv_ogrenciler.Location = new System.Drawing.Point(12, 12);
            this.dgv_ogrenciler.Name = "dgv_ogrenciler";
            this.dgv_ogrenciler.ReadOnly = true;
            this.dgv_ogrenciler.Size = new System.Drawing.Size(818, 263);
            this.dgv_ogrenciler.TabIndex = 0;
            // 
            // ogrenciNo
            // 
            this.ogrenciNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ogrenciNo.FillWeight = 50F;
            this.ogrenciNo.HeaderText = "Öğrenci No";
            this.ogrenciNo.Name = "ogrenciNo";
            this.ogrenciNo.ReadOnly = true;
            this.ogrenciNo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ad
            // 
            this.ad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ad.FillWeight = 200F;
            this.ad.HeaderText = "Ad";
            this.ad.Name = "ad";
            this.ad.ReadOnly = true;
            // 
            // soyad
            // 
            this.soyad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.soyad.FillWeight = 200F;
            this.soyad.HeaderText = "Soyad";
            this.soyad.Name = "soyad";
            this.soyad.ReadOnly = true;
            // 
            // borc
            // 
            this.borc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.borc.FillWeight = 150F;
            this.borc.HeaderText = "Borç";
            this.borc.Name = "borc";
            this.borc.ReadOnly = true;
            // 
            // gecIade
            // 
            this.gecIade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gecIade.HeaderText = "Geç İade Sayısı";
            this.gecIade.Name = "gecIade";
            this.gecIade.ReadOnly = true;
            // 
            // toolTip
            // 
            this.toolTip.AutomaticDelay = 100;
            this.toolTip.AutoPopDelay = 5000;
            this.toolTip.InitialDelay = 100;
            this.toolTip.ReshowDelay = 20;
            // 
            // tb_noAra
            // 
            this.tb_noAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_noAra.Location = new System.Drawing.Point(12, 488);
            this.tb_noAra.Name = "tb_noAra";
            this.tb_noAra.Size = new System.Drawing.Size(200, 29);
            this.tb_noAra.TabIndex = 4;
            this.tb_noAra.Text = "Öğrenci No Ara...";
            this.tb_noAra.Enter += new System.EventHandler(this.tb_noAra_Enter);
            this.tb_noAra.Leave += new System.EventHandler(this.tb_noAra_Leave);
            // 
            // tb_adSoyadAra
            // 
            this.tb_adSoyadAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_adSoyadAra.Location = new System.Drawing.Point(630, 488);
            this.tb_adSoyadAra.Name = "tb_adSoyadAra";
            this.tb_adSoyadAra.Size = new System.Drawing.Size(200, 29);
            this.tb_adSoyadAra.TabIndex = 6;
            this.tb_adSoyadAra.Text = "Ad Soyad Ara...";
            this.tb_adSoyadAra.Enter += new System.EventHandler(this.tb_adSoyadAra_Enter);
            this.tb_adSoyadAra.Leave += new System.EventHandler(this.tb_adSoyadAra_Leave);
            // 
            // btn_ogrenciEmanet
            // 
            this.btn_ogrenciEmanet.BackgroundImage = global::GorselProje.Properties.Resources.emanet;
            this.btn_ogrenciEmanet.Location = new System.Drawing.Point(630, 281);
            this.btn_ogrenciEmanet.Name = "btn_ogrenciEmanet";
            this.btn_ogrenciEmanet.Size = new System.Drawing.Size(200, 200);
            this.btn_ogrenciEmanet.TabIndex = 8;
            this.btn_ogrenciEmanet.UseVisualStyleBackColor = true;
            this.btn_ogrenciEmanet.Click += new System.EventHandler(this.btn_ogrenciEmanet_Click);
            // 
            // btn_adSoyadAra
            // 
            this.btn_adSoyadAra.BackgroundImage = global::GorselProje.Properties.Resources.buyutec;
            this.btn_adSoyadAra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_adSoyadAra.Location = new System.Drawing.Point(595, 488);
            this.btn_adSoyadAra.Name = "btn_adSoyadAra";
            this.btn_adSoyadAra.Size = new System.Drawing.Size(29, 29);
            this.btn_adSoyadAra.TabIndex = 7;
            this.btn_adSoyadAra.UseVisualStyleBackColor = true;
            this.btn_adSoyadAra.Click += new System.EventHandler(this.btn_adSoyadAra_Click);
            // 
            // btn_noAra
            // 
            this.btn_noAra.BackgroundImage = global::GorselProje.Properties.Resources.buyutec;
            this.btn_noAra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_noAra.Location = new System.Drawing.Point(218, 488);
            this.btn_noAra.Name = "btn_noAra";
            this.btn_noAra.Size = new System.Drawing.Size(29, 29);
            this.btn_noAra.TabIndex = 5;
            this.btn_noAra.UseVisualStyleBackColor = true;
            this.btn_noAra.Click += new System.EventHandler(this.btn_noAra_Click);
            // 
            // btn_ogrenciDuzenle
            // 
            this.btn_ogrenciDuzenle.BackgroundImage = global::GorselProje.Properties.Resources.uyeduzenle;
            this.btn_ogrenciDuzenle.Location = new System.Drawing.Point(424, 281);
            this.btn_ogrenciDuzenle.Name = "btn_ogrenciDuzenle";
            this.btn_ogrenciDuzenle.Size = new System.Drawing.Size(200, 200);
            this.btn_ogrenciDuzenle.TabIndex = 3;
            this.btn_ogrenciDuzenle.UseVisualStyleBackColor = true;
            this.btn_ogrenciDuzenle.Click += new System.EventHandler(this.btn_ogrenciDuzenle_Click);
            // 
            // btn_ogrenciSil
            // 
            this.btn_ogrenciSil.BackgroundImage = global::GorselProje.Properties.Resources.uyesil;
            this.btn_ogrenciSil.Location = new System.Drawing.Point(218, 281);
            this.btn_ogrenciSil.Name = "btn_ogrenciSil";
            this.btn_ogrenciSil.Size = new System.Drawing.Size(200, 200);
            this.btn_ogrenciSil.TabIndex = 2;
            this.btn_ogrenciSil.UseVisualStyleBackColor = true;
            this.btn_ogrenciSil.Click += new System.EventHandler(this.btn_ogrenciSil_Click);
            // 
            // btn_ogrenciEkle
            // 
            this.btn_ogrenciEkle.BackgroundImage = global::GorselProje.Properties.Resources.yeniuye;
            this.btn_ogrenciEkle.Location = new System.Drawing.Point(12, 281);
            this.btn_ogrenciEkle.Name = "btn_ogrenciEkle";
            this.btn_ogrenciEkle.Size = new System.Drawing.Size(200, 200);
            this.btn_ogrenciEkle.TabIndex = 1;
            this.btn_ogrenciEkle.UseVisualStyleBackColor = true;
            this.btn_ogrenciEkle.Click += new System.EventHandler(this.btn_ogrenciEkle_Click);
            // 
            // OgrenciListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(840, 524);
            this.Controls.Add(this.btn_ogrenciEmanet);
            this.Controls.Add(this.btn_adSoyadAra);
            this.Controls.Add(this.tb_adSoyadAra);
            this.Controls.Add(this.btn_noAra);
            this.Controls.Add(this.tb_noAra);
            this.Controls.Add(this.btn_ogrenciDuzenle);
            this.Controls.Add(this.btn_ogrenciSil);
            this.Controls.Add(this.btn_ogrenciEkle);
            this.Controls.Add(this.dgv_ogrenciler);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OgrenciListe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğrenciler";
            this.Load += new System.EventHandler(this.OgrenciListe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ogrenciler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_ogrenciler;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn borc;
        private System.Windows.Forms.DataGridViewTextBoxColumn gecIade;
        private System.Windows.Forms.Button btn_ogrenciEkle;
        private System.Windows.Forms.Button btn_ogrenciDuzenle;
        private System.Windows.Forms.Button btn_ogrenciSil;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.TextBox tb_noAra;
        private System.Windows.Forms.Button btn_noAra;
        private System.Windows.Forms.Button btn_adSoyadAra;
        private System.Windows.Forms.TextBox tb_adSoyadAra;
        private System.Windows.Forms.Button btn_ogrenciEmanet;
    }
}