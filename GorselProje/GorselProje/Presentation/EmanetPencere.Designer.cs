
namespace GorselProje.Presentation
{
    partial class EmanetPencere
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmanetPencere));
            this.dtp_emanetTarih = new System.Windows.Forms.DateTimePicker();
            this.cb_ogrenci = new System.Windows.Forms.ComboBox();
            this.btn_islem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_kitap = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_iadeTarih = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rb_evet = new System.Windows.Forms.RadioButton();
            this.rb_hayir = new System.Windows.Forms.RadioButton();
            this.gb_teslim = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gb_teslim.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtp_emanetTarih
            // 
            this.dtp_emanetTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtp_emanetTarih.Location = new System.Drawing.Point(146, 82);
            this.dtp_emanetTarih.Name = "dtp_emanetTarih";
            this.dtp_emanetTarih.Size = new System.Drawing.Size(245, 29);
            this.dtp_emanetTarih.TabIndex = 3;
            this.dtp_emanetTarih.Value = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            // 
            // cb_ogrenci
            // 
            this.cb_ogrenci.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cb_ogrenci.FormattingEnabled = true;
            this.cb_ogrenci.Location = new System.Drawing.Point(146, 6);
            this.cb_ogrenci.Name = "cb_ogrenci";
            this.cb_ogrenci.Size = new System.Drawing.Size(245, 32);
            this.cb_ogrenci.TabIndex = 1;
            // 
            // btn_islem
            // 
            this.btn_islem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_islem.Location = new System.Drawing.Point(12, 210);
            this.btn_islem.Name = "btn_islem";
            this.btn_islem.Size = new System.Drawing.Size(379, 29);
            this.btn_islem.TabIndex = 7;
            this.btn_islem.Text = "EKLE";
            this.btn_islem.UseVisualStyleBackColor = true;
            this.btn_islem.Click += new System.EventHandler(this.btn_islem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 24);
            this.label1.TabIndex = 33;
            this.label1.Text = "Öğrenci:";
            // 
            // cb_kitap
            // 
            this.cb_kitap.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cb_kitap.FormattingEnabled = true;
            this.cb_kitap.Location = new System.Drawing.Point(146, 44);
            this.cb_kitap.Name = "cb_kitap";
            this.cb_kitap.Size = new System.Drawing.Size(245, 32);
            this.cb_kitap.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 24);
            this.label2.TabIndex = 49;
            this.label2.Text = "Kitap:";
            // 
            // dtp_iadeTarih
            // 
            this.dtp_iadeTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtp_iadeTarih.Location = new System.Drawing.Point(146, 117);
            this.dtp_iadeTarih.Name = "dtp_iadeTarih";
            this.dtp_iadeTarih.Size = new System.Drawing.Size(245, 29);
            this.dtp_iadeTarih.TabIndex = 4;
            this.dtp_iadeTarih.Value = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 24);
            this.label3.TabIndex = 51;
            this.label3.Text = "Teslim Tarihi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 24);
            this.label4.TabIndex = 52;
            this.label4.Text = "İade Tarihi:";
            // 
            // rb_evet
            // 
            this.rb_evet.AutoSize = true;
            this.rb_evet.Location = new System.Drawing.Point(6, 19);
            this.rb_evet.Name = "rb_evet";
            this.rb_evet.Size = new System.Drawing.Size(47, 17);
            this.rb_evet.TabIndex = 5;
            this.rb_evet.TabStop = true;
            this.rb_evet.Text = "Evet";
            this.rb_evet.UseVisualStyleBackColor = true;
            // 
            // rb_hayir
            // 
            this.rb_hayir.AutoSize = true;
            this.rb_hayir.Checked = true;
            this.rb_hayir.Location = new System.Drawing.Point(97, 19);
            this.rb_hayir.Name = "rb_hayir";
            this.rb_hayir.Size = new System.Drawing.Size(49, 17);
            this.rb_hayir.TabIndex = 6;
            this.rb_hayir.TabStop = true;
            this.rb_hayir.Text = "Hayır";
            this.rb_hayir.UseVisualStyleBackColor = true;
            // 
            // gb_teslim
            // 
            this.gb_teslim.Controls.Add(this.rb_evet);
            this.gb_teslim.Controls.Add(this.rb_hayir);
            this.gb_teslim.Location = new System.Drawing.Point(146, 152);
            this.gb_teslim.Name = "gb_teslim";
            this.gb_teslim.Size = new System.Drawing.Size(245, 52);
            this.gb_teslim.TabIndex = 55;
            this.gb_teslim.TabStop = false;
            this.gb_teslim.Text = "İade edildi mi?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(12, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 24);
            this.label5.TabIndex = 56;
            this.label5.Text = "Teslim:";
            // 
            // EmanetPencere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(433, 245);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.gb_teslim);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtp_iadeTarih);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_kitap);
            this.Controls.Add(this.dtp_emanetTarih);
            this.Controls.Add(this.cb_ogrenci);
            this.Controls.Add(this.btn_islem);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EmanetPencere";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emanet Ekle";
            this.Load += new System.EventHandler(this.EmanetPencere_Load);
            this.gb_teslim.ResumeLayout(false);
            this.gb_teslim.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtp_emanetTarih;
        private System.Windows.Forms.ComboBox cb_ogrenci;
        private System.Windows.Forms.Button btn_islem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_kitap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_iadeTarih;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rb_evet;
        private System.Windows.Forms.RadioButton rb_hayir;
        private System.Windows.Forms.GroupBox gb_teslim;
        private System.Windows.Forms.Label label5;
    }
}