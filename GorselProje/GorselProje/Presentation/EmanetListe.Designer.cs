
namespace GorselProje.Presentation
{
    partial class EmanetListe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmanetListe));
            this.dgv_emanetler = new System.Windows.Forms.DataGridView();
            this.emanetNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adsoyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emanetTarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iadeTarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teslim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tb_ogrAra = new System.Windows.Forms.TextBox();
            this.tb_noAra = new System.Windows.Forms.TextBox();
            this.tb_kitapAra = new System.Windows.Forms.TextBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btn_grafik = new System.Windows.Forms.Button();
            this.btn_kitapAra = new System.Windows.Forms.Button();
            this.btn_ogrAra = new System.Windows.Forms.Button();
            this.btn_noAra = new System.Windows.Forms.Button();
            this.btn_emanetIade = new System.Windows.Forms.Button();
            this.btn_emanetEkle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_emanetler)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_emanetler
            // 
            this.dgv_emanetler.AllowUserToAddRows = false;
            this.dgv_emanetler.AllowUserToDeleteRows = false;
            this.dgv_emanetler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_emanetler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.emanetNo,
            this.adsoyad,
            this.kitapAd,
            this.emanetTarih,
            this.iadeTarih,
            this.teslim});
            this.dgv_emanetler.Location = new System.Drawing.Point(12, 12);
            this.dgv_emanetler.Name = "dgv_emanetler";
            this.dgv_emanetler.ReadOnly = true;
            this.dgv_emanetler.Size = new System.Drawing.Size(818, 263);
            this.dgv_emanetler.TabIndex = 2;
            // 
            // emanetNo
            // 
            this.emanetNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.emanetNo.FillWeight = 50F;
            this.emanetNo.HeaderText = "Emanet No";
            this.emanetNo.Name = "emanetNo";
            this.emanetNo.ReadOnly = true;
            // 
            // adsoyad
            // 
            this.adsoyad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.adsoyad.FillWeight = 200F;
            this.adsoyad.HeaderText = "Öğrenci Ad Soyad";
            this.adsoyad.Name = "adsoyad";
            this.adsoyad.ReadOnly = true;
            // 
            // kitapAd
            // 
            this.kitapAd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.kitapAd.FillWeight = 150F;
            this.kitapAd.HeaderText = "Kitap Adı";
            this.kitapAd.Name = "kitapAd";
            this.kitapAd.ReadOnly = true;
            // 
            // emanetTarih
            // 
            this.emanetTarih.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.emanetTarih.HeaderText = "Emanet Tarihi";
            this.emanetTarih.Name = "emanetTarih";
            this.emanetTarih.ReadOnly = true;
            // 
            // iadeTarih
            // 
            this.iadeTarih.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.iadeTarih.HeaderText = "İade Tarihi";
            this.iadeTarih.Name = "iadeTarih";
            this.iadeTarih.ReadOnly = true;
            // 
            // teslim
            // 
            this.teslim.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.teslim.FillWeight = 75F;
            this.teslim.HeaderText = "Teslim";
            this.teslim.Name = "teslim";
            this.teslim.ReadOnly = true;
            // 
            // tb_ogrAra
            // 
            this.tb_ogrAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_ogrAra.Location = new System.Drawing.Point(218, 316);
            this.tb_ogrAra.Name = "tb_ogrAra";
            this.tb_ogrAra.Size = new System.Drawing.Size(369, 29);
            this.tb_ogrAra.TabIndex = 22;
            this.tb_ogrAra.Text = "Öğrenci No veya Ad-Soyad Ara...";
            this.tb_ogrAra.Enter += new System.EventHandler(this.tb_ogrAra_Enter);
            this.tb_ogrAra.Leave += new System.EventHandler(this.tb_ogrAra_Leave);
            // 
            // tb_noAra
            // 
            this.tb_noAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_noAra.Location = new System.Drawing.Point(218, 281);
            this.tb_noAra.Name = "tb_noAra";
            this.tb_noAra.Size = new System.Drawing.Size(369, 29);
            this.tb_noAra.TabIndex = 20;
            this.tb_noAra.Text = "Emanet No Ara...";
            this.tb_noAra.Enter += new System.EventHandler(this.tb_noAra_Enter);
            this.tb_noAra.Leave += new System.EventHandler(this.tb_noAra_Leave);
            // 
            // tb_kitapAra
            // 
            this.tb_kitapAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_kitapAra.Location = new System.Drawing.Point(218, 351);
            this.tb_kitapAra.Name = "tb_kitapAra";
            this.tb_kitapAra.Size = new System.Drawing.Size(369, 29);
            this.tb_kitapAra.TabIndex = 24;
            this.tb_kitapAra.Text = "Kitap No veya Ad ile Ara...";
            this.tb_kitapAra.Enter += new System.EventHandler(this.tb_kitapAra_Enter);
            this.tb_kitapAra.Leave += new System.EventHandler(this.tb_kitapAra_Leave);
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
            this.btn_grafik.Location = new System.Drawing.Point(218, 386);
            this.btn_grafik.Name = "btn_grafik";
            this.btn_grafik.Size = new System.Drawing.Size(95, 95);
            this.btn_grafik.TabIndex = 26;
            this.btn_grafik.UseVisualStyleBackColor = true;
            this.btn_grafik.Click += new System.EventHandler(this.btn_grafik_Click);
            // 
            // btn_kitapAra
            // 
            this.btn_kitapAra.BackgroundImage = global::GorselProje.Properties.Resources.buyutec;
            this.btn_kitapAra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_kitapAra.Location = new System.Drawing.Point(593, 351);
            this.btn_kitapAra.Name = "btn_kitapAra";
            this.btn_kitapAra.Size = new System.Drawing.Size(29, 29);
            this.btn_kitapAra.TabIndex = 25;
            this.btn_kitapAra.UseVisualStyleBackColor = true;
            this.btn_kitapAra.Click += new System.EventHandler(this.btn_kitapAra_Click);
            // 
            // btn_ogrAra
            // 
            this.btn_ogrAra.BackgroundImage = global::GorselProje.Properties.Resources.buyutec;
            this.btn_ogrAra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ogrAra.Location = new System.Drawing.Point(593, 316);
            this.btn_ogrAra.Name = "btn_ogrAra";
            this.btn_ogrAra.Size = new System.Drawing.Size(29, 29);
            this.btn_ogrAra.TabIndex = 23;
            this.btn_ogrAra.UseVisualStyleBackColor = true;
            this.btn_ogrAra.Click += new System.EventHandler(this.btn_ogrAra_Click);
            // 
            // btn_noAra
            // 
            this.btn_noAra.BackgroundImage = global::GorselProje.Properties.Resources.buyutec;
            this.btn_noAra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_noAra.Location = new System.Drawing.Point(593, 281);
            this.btn_noAra.Name = "btn_noAra";
            this.btn_noAra.Size = new System.Drawing.Size(29, 29);
            this.btn_noAra.TabIndex = 21;
            this.btn_noAra.UseVisualStyleBackColor = true;
            this.btn_noAra.Click += new System.EventHandler(this.btn_noAra_Click);
            // 
            // btn_emanetIade
            // 
            this.btn_emanetIade.BackgroundImage = global::GorselProje.Properties.Resources.emanetiade;
            this.btn_emanetIade.Location = new System.Drawing.Point(628, 281);
            this.btn_emanetIade.Name = "btn_emanetIade";
            this.btn_emanetIade.Size = new System.Drawing.Size(200, 200);
            this.btn_emanetIade.TabIndex = 18;
            this.btn_emanetIade.UseVisualStyleBackColor = true;
            this.btn_emanetIade.Click += new System.EventHandler(this.btn_emanetIade_Click);
            // 
            // btn_emanetEkle
            // 
            this.btn_emanetEkle.BackgroundImage = global::GorselProje.Properties.Resources.emanetekle;
            this.btn_emanetEkle.Location = new System.Drawing.Point(12, 281);
            this.btn_emanetEkle.Name = "btn_emanetEkle";
            this.btn_emanetEkle.Size = new System.Drawing.Size(200, 200);
            this.btn_emanetEkle.TabIndex = 17;
            this.btn_emanetEkle.UseVisualStyleBackColor = true;
            this.btn_emanetEkle.Click += new System.EventHandler(this.btn_emanetEkle_Click);
            // 
            // EmanetListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(840, 493);
            this.Controls.Add(this.btn_grafik);
            this.Controls.Add(this.btn_kitapAra);
            this.Controls.Add(this.tb_kitapAra);
            this.Controls.Add(this.btn_ogrAra);
            this.Controls.Add(this.tb_ogrAra);
            this.Controls.Add(this.btn_noAra);
            this.Controls.Add(this.tb_noAra);
            this.Controls.Add(this.btn_emanetIade);
            this.Controls.Add(this.btn_emanetEkle);
            this.Controls.Add(this.dgv_emanetler);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EmanetListe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emanetler";
            this.Load += new System.EventHandler(this.EmanetListe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_emanetler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_emanetler;
        private System.Windows.Forms.DataGridViewTextBoxColumn emanetNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn adsoyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn emanetTarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn iadeTarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn teslim;
        private System.Windows.Forms.Button btn_ogrAra;
        private System.Windows.Forms.TextBox tb_ogrAra;
        private System.Windows.Forms.Button btn_noAra;
        private System.Windows.Forms.TextBox tb_noAra;
        private System.Windows.Forms.Button btn_emanetIade;
        private System.Windows.Forms.Button btn_emanetEkle;
        private System.Windows.Forms.TextBox tb_kitapAra;
        private System.Windows.Forms.Button btn_kitapAra;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button btn_grafik;
    }
}