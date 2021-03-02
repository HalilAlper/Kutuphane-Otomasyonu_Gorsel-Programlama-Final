using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph; //Grafik kütüphanesi

namespace GorselProje.Presentation
{
    public partial class Grafik : Form
    {
        //Her kitaba ait adet ve emanet sayısı bilgileri
        DataTable adetler;
        DataTable emanetler;

        public Grafik()
        {
            InitializeComponent();
        }

        //Grafiği her yinelememiz gerektiğinde(Her bir kitap ekle-çıkar işleminde) kullandığımız fonksiyon
        //İçeriye yinelemek istediğimiz ZedGraphControl nesnesi parametre gidiyor.
        private void GrafikYinele(ZedGraphControl zgc)
        {
            //Kaç kitabın grafiği gösterilecekse o kadarlık diziler lazım
            int toplamGoster = lb_gosterilen.Items.Count;
            string[] kitapAdlar = new string[toplamGoster];     //Kitapların adları
            double[] y1 = new double[toplamGoster];             //İlk bar, yeşil, mevcut kitap sayısı
            double[] y2 = new double[toplamGoster];             //İkinci bar, kırmızı, emanetteki kitaplar

            for (int i = 0; i < lb_gosterilen.Items.Count; i++) //Gösterilen kitaplar için:
            {
                kitapAdlar[i] = lb_gosterilen.Items[i].ToString();//Kitap adlarını diziye aktar
                for (int j = 0; j < adetler.Rows.Count; j++)    //Adetler sonucunda bir gezinti
                {
                    if (adetler.Rows[j][0].ToString() == kitapAdlar[i]) //Eğer kitap adına ait adet bulunmuşsa
                    {                                                   //Adedi ilk bar dizisine ekle
                        y1[i] = Convert.ToInt32(adetler.Rows[j][1].ToString());
                    }
                }
                for (int j = 0; j < emanetler.Rows.Count; j++)  //Emanetler sonucunda bir gezinti
                {
                    if (emanetler.Rows[j][0].ToString() == kitapAdlar[i])//Eğer kitap adına ait emanet sayısı
                    {
                        y2[i] = Convert.ToInt32(emanetler.Rows[j][1].ToString());//Sayıyı ikinci bar dizisine ekle
                    }
                }
                
                
            }
            //GraphPane grafiği çizeceğimiz nesne
            GraphPane gp = new GraphPane();

            //Grafiğin TextLabel'larını değiştiriyoruz, böylece kitap adları grafiğin yanında gözükecek
            gp.YAxis.Scale.TextLabels = kitapAdlar;

            //Grafiğin doğru görüntülenebilmesi için bazı değer atamaları
            gp.XAxis.MajorGrid.IsZeroLine = true;   //Orijin çizgisi görünümü
            gp.XAxis.MajorGrid.IsVisible = true;    //Grid çizgileri
            gp.YAxis.Type = AxisType.Text;          //Yazı tipi eksen
            gp.BarSettings.Base = BarBase.Y;        //Barlar Y ekseni üzerinden çıksın, çünkü öyle istiyorum.

            gp.YAxis.Scale.IsReverse = true;        //Grafiğin ters oluşu. True çünkü sıralama böyle doğru
            gp.BarSettings.Type = BarType.Stack;    //Barlar üst üste istiflensin
            BarItem b1 = gp.AddBar("Adet", y1, null, Color.Green); //Barları oluştur
            BarItem b2 = gp.AddBar("Emanet", y2, null, Color.Red); 

            zgc.GraphPane = gp; //GraphPane'i ZedGraphControl'a ata
            zgc.AxisChange();   //ZGC'nin görünümünü düzelt
        }

        private void Grafik_Load(object sender, EventArgs e)
        {
            //Grafik yüklendiğinde bütün adet ve emanet bilgisi alınacak
            adetler = Business.Kitap.AdetListele();
            emanetler = Business.Emanet.EmanetToplam();

            //Bütün kitap adları Listbox'umuza eklenecek. Gösterilene. En başta hepsi gözükecek
            for (int i = 0; i < adetler.Rows.Count; i++)
            {
                lb_gosterilen.Items.Add(adetler.Rows[i][0].ToString()); //ListBox'a ekle
            }
            GrafikYinele(zgc_kitaplar); //Grafiği en başta çiz
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            //Saklananlardan gösterilenlere ekle
            int Secili = lb_saklanan.SelectedIndex; //Index bul
            if (Secili != -1)                       //Eğer biri seçili ise
            {                                       //Gösterilen'e ekle Saklanan'dan sil
                lb_gosterilen.Items.Add(lb_saklanan.SelectedItem.ToString());
                lb_saklanan.Items.RemoveAt(Secili);
                GrafikYinele(zgc_kitaplar);         //Sonra da grafiği yenile
                zgc_kitaplar.Refresh();             //ZGC'yi yenilemeyi unutma
            }
        }

        private void btn_cikar_Click(object sender, EventArgs e)
        {   //Gösterilenlerden saklananlara ekle
            int Secili = lb_gosterilen.SelectedIndex;//Index bul
            if (Secili != -1)                       //Eğer biri seçili ise
            {                                       //Saklanan'a ekle Gösterilen'den sil
                lb_saklanan.Items.Add(lb_gosterilen.SelectedItem.ToString());
                lb_gosterilen.Items.RemoveAt(Secili);
                GrafikYinele(zgc_kitaplar);         //Sonra da grafiği yenile
                zgc_kitaplar.Refresh();             //ZGC'yi yenilemeyi unutma
            }
        }
    }
}
