using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GorselProje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Butonlar ikon olduğu için, anlaşılmaması durumunda gösterilecek ToolTip'ler
            toolTip.SetToolTip(btn_ogrenciler, "Öğrencileri göster");
            toolTip.SetToolTip(btn_kitaplar, "Kitapları göster");
            toolTip.SetToolTip(btn_emanet, "Emanet listesini aç");
        }

        private void btn_ogrenciler_Click(object sender, EventArgs e)
        {
            //Öğrencilerin listesini ve işlemlerini göstermek için gerekli pencere açılımı
            Presentation.OgrenciListe F = new Presentation.OgrenciListe();
            F.ShowDialog();
            //ShowDialog çünkü arkadan başka bir işlem yapmasını istemiyorum kullanıcının.
        }

        private void btn_kitaplar_Click(object sender, EventArgs e)
        {
            //Kitapların listesini ve işlemlerini göstermek için gerekli pencere açılımı
            Presentation.KitapListe F = new Presentation.KitapListe();
            F.ShowDialog();
            //ShowDialog çünkü arkadan başka bir işlem yapmasını istemiyorum kullanıcının.
        }

        private void btn_emanet_Click(object sender, EventArgs e)
        {
            //Emanetleri ADMIN OLARAK göstermek ve işlem yapmak için gerekli pencere açılımı
            //Buradaki DefaultKosul'un mantığının Business.Emanet sınıfında anlatımı mevcut. Satır: 59 - 80
            Business.Emanet.DefaultKosul = "";
            Presentation.EmanetListe F = new Presentation.EmanetListe();
            F.ShowDialog();
            //ShowDialog çünkü arkadan başka bir işlem yapmasını istemiyorum kullanıcının.
        }
    }
}
