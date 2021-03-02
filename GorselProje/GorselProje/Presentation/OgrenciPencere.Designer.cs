
namespace GorselProje.Presentation
{
    partial class OgrenciPencere
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OgrenciPencere));
            this.label1 = new System.Windows.Forms.Label();
            this.tb_ad = new System.Windows.Forms.TextBox();
            this.tb_soyad = new System.Windows.Forms.TextBox();
            this.tb_borc = new System.Windows.Forms.TextBox();
            this.btn_ode = new System.Windows.Forms.Button();
            this.tb_gecIade = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_telafi = new System.Windows.Forms.Button();
            this.btn_islem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad:";
            // 
            // tb_ad
            // 
            this.tb_ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_ad.Location = new System.Drawing.Point(146, 12);
            this.tb_ad.Name = "tb_ad";
            this.tb_ad.Size = new System.Drawing.Size(178, 29);
            this.tb_ad.TabIndex = 1;
            // 
            // tb_soyad
            // 
            this.tb_soyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_soyad.Location = new System.Drawing.Point(146, 47);
            this.tb_soyad.Name = "tb_soyad";
            this.tb_soyad.Size = new System.Drawing.Size(178, 29);
            this.tb_soyad.TabIndex = 2;
            // 
            // tb_borc
            // 
            this.tb_borc.Enabled = false;
            this.tb_borc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_borc.Location = new System.Drawing.Point(146, 82);
            this.tb_borc.Name = "tb_borc";
            this.tb_borc.Size = new System.Drawing.Size(86, 29);
            this.tb_borc.TabIndex = 3;
            // 
            // btn_ode
            // 
            this.btn_ode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ode.Location = new System.Drawing.Point(238, 83);
            this.btn_ode.Name = "btn_ode";
            this.btn_ode.Size = new System.Drawing.Size(86, 29);
            this.btn_ode.TabIndex = 4;
            this.btn_ode.Text = "Öde";
            this.btn_ode.UseVisualStyleBackColor = true;
            this.btn_ode.Click += new System.EventHandler(this.btn_ode_Click);
            // 
            // tb_gecIade
            // 
            this.tb_gecIade.Enabled = false;
            this.tb_gecIade.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_gecIade.Location = new System.Drawing.Point(146, 117);
            this.tb_gecIade.Name = "tb_gecIade";
            this.tb_gecIade.Size = new System.Drawing.Size(86, 29);
            this.tb_gecIade.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Borç:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Geç İade:";
            // 
            // btn_telafi
            // 
            this.btn_telafi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_telafi.Location = new System.Drawing.Point(238, 118);
            this.btn_telafi.Name = "btn_telafi";
            this.btn_telafi.Size = new System.Drawing.Size(86, 29);
            this.btn_telafi.TabIndex = 9;
            this.btn_telafi.Text = "Telafi";
            this.btn_telafi.UseVisualStyleBackColor = true;
            this.btn_telafi.Click += new System.EventHandler(this.btn_telafi_Click);
            // 
            // btn_islem
            // 
            this.btn_islem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_islem.Location = new System.Drawing.Point(16, 153);
            this.btn_islem.Name = "btn_islem";
            this.btn_islem.Size = new System.Drawing.Size(308, 29);
            this.btn_islem.TabIndex = 10;
            this.btn_islem.Text = "EKLE";
            this.btn_islem.UseVisualStyleBackColor = true;
            this.btn_islem.Click += new System.EventHandler(this.btn_islem_Click);
            // 
            // OgrenciPencere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(375, 194);
            this.Controls.Add(this.btn_islem);
            this.Controls.Add(this.btn_telafi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_gecIade);
            this.Controls.Add(this.btn_ode);
            this.Controls.Add(this.tb_borc);
            this.Controls.Add(this.tb_soyad);
            this.Controls.Add(this.tb_ad);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OgrenciPencere";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğrenci Test";
            this.Load += new System.EventHandler(this.OgrenciPencere_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_ad;
        private System.Windows.Forms.TextBox tb_soyad;
        private System.Windows.Forms.TextBox tb_borc;
        private System.Windows.Forms.Button btn_ode;
        private System.Windows.Forms.TextBox tb_gecIade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_telafi;
        private System.Windows.Forms.Button btn_islem;
    }
}