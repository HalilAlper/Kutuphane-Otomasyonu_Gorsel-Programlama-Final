
namespace GorselProje.Presentation
{
    partial class inputBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inputBox));
            this.tb_Giris = new System.Windows.Forms.TextBox();
            this.lbl_Mesaj = new System.Windows.Forms.Label();
            this.btn_islem = new System.Windows.Forms.Button();
            this.btn_iptal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_Giris
            // 
            this.tb_Giris.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_Giris.Location = new System.Drawing.Point(12, 48);
            this.tb_Giris.Name = "tb_Giris";
            this.tb_Giris.Size = new System.Drawing.Size(217, 29);
            this.tb_Giris.TabIndex = 0;
            // 
            // lbl_Mesaj
            // 
            this.lbl_Mesaj.AutoSize = true;
            this.lbl_Mesaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Mesaj.Location = new System.Drawing.Point(12, 9);
            this.lbl_Mesaj.Name = "lbl_Mesaj";
            this.lbl_Mesaj.Size = new System.Drawing.Size(51, 20);
            this.lbl_Mesaj.TabIndex = 1;
            this.lbl_Mesaj.Text = "Mesaj";
            // 
            // btn_islem
            // 
            this.btn_islem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_islem.Location = new System.Drawing.Point(235, 48);
            this.btn_islem.Name = "btn_islem";
            this.btn_islem.Size = new System.Drawing.Size(81, 29);
            this.btn_islem.TabIndex = 2;
            this.btn_islem.Text = "İşlem";
            this.btn_islem.UseVisualStyleBackColor = true;
            this.btn_islem.Click += new System.EventHandler(this.btn_islem_Click);
            // 
            // btn_iptal
            // 
            this.btn_iptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_iptal.Location = new System.Drawing.Point(235, 83);
            this.btn_iptal.Name = "btn_iptal";
            this.btn_iptal.Size = new System.Drawing.Size(81, 29);
            this.btn_iptal.TabIndex = 3;
            this.btn_iptal.Text = "İptal";
            this.btn_iptal.UseVisualStyleBackColor = true;
            this.btn_iptal.Click += new System.EventHandler(this.btn_iptal_Click);
            // 
            // inputBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(328, 119);
            this.Controls.Add(this.btn_iptal);
            this.Controls.Add(this.btn_islem);
            this.Controls.Add(this.lbl_Mesaj);
            this.Controls.Add(this.tb_Giris);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "inputBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "inputBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Giris;
        private System.Windows.Forms.Label lbl_Mesaj;
        private System.Windows.Forms.Button btn_islem;
        private System.Windows.Forms.Button btn_iptal;
    }
}