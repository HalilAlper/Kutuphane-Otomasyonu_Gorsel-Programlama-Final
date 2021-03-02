
namespace GorselProje.Presentation
{
    partial class Grafik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Grafik));
            this.zgc_kitaplar = new ZedGraph.ZedGraphControl();
            this.lb_saklanan = new System.Windows.Forms.ListBox();
            this.lb_gosterilen = new System.Windows.Forms.ListBox();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_cikar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // zgc_kitaplar
            // 
            this.zgc_kitaplar.Location = new System.Drawing.Point(0, 0);
            this.zgc_kitaplar.Name = "zgc_kitaplar";
            this.zgc_kitaplar.ScrollGrace = 0D;
            this.zgc_kitaplar.ScrollMaxX = 0D;
            this.zgc_kitaplar.ScrollMaxY = 0D;
            this.zgc_kitaplar.ScrollMaxY2 = 0D;
            this.zgc_kitaplar.ScrollMinX = 0D;
            this.zgc_kitaplar.ScrollMinY = 0D;
            this.zgc_kitaplar.ScrollMinY2 = 0D;
            this.zgc_kitaplar.Size = new System.Drawing.Size(496, 369);
            this.zgc_kitaplar.TabIndex = 0;
            // 
            // lb_saklanan
            // 
            this.lb_saklanan.FormattingEnabled = true;
            this.lb_saklanan.Location = new System.Drawing.Point(502, 25);
            this.lb_saklanan.Name = "lb_saklanan";
            this.lb_saklanan.Size = new System.Drawing.Size(181, 134);
            this.lb_saklanan.TabIndex = 1;
            // 
            // lb_gosterilen
            // 
            this.lb_gosterilen.FormattingEnabled = true;
            this.lb_gosterilen.Location = new System.Drawing.Point(502, 186);
            this.lb_gosterilen.Name = "lb_gosterilen";
            this.lb_gosterilen.Size = new System.Drawing.Size(181, 134);
            this.lb_gosterilen.TabIndex = 2;
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(565, 162);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(57, 21);
            this.btn_ekle.TabIndex = 3;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(502, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Saklanan:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(502, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Gösterilen:";
            // 
            // btn_cikar
            // 
            this.btn_cikar.Location = new System.Drawing.Point(626, 162);
            this.btn_cikar.Name = "btn_cikar";
            this.btn_cikar.Size = new System.Drawing.Size(57, 21);
            this.btn_cikar.TabIndex = 6;
            this.btn_cikar.Text = "Çıkar";
            this.btn_cikar.UseVisualStyleBackColor = true;
            this.btn_cikar.Click += new System.EventHandler(this.btn_cikar_Click);
            // 
            // Grafik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(689, 367);
            this.Controls.Add(this.btn_cikar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.lb_gosterilen);
            this.Controls.Add(this.lb_saklanan);
            this.Controls.Add(this.zgc_kitaplar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Grafik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grafik";
            this.Load += new System.EventHandler(this.Grafik_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ZedGraph.ZedGraphControl zgc_kitaplar;
        private System.Windows.Forms.ListBox lb_saklanan;
        private System.Windows.Forms.ListBox lb_gosterilen;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_cikar;
    }
}