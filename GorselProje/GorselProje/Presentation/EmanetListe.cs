using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GorselProje.Presentation
{
    public partial class EmanetListe : Form
    {
        //EmanetListe'miz bütün emanetleri gösterecek olan formumuz.
        //Buraya üç yoldan gelmek mümkün: Admin, öğrenci, kitap
        //Adminden gelindiyse her işlem yapılabilir
        //Öğrenciden gelindiyse sadece öğrenci üzerinden emanet bilgileri görüntülenebilir veya eklenebilir.
        //Kitaptan gelindiyse sadece kitap üzerinden emanet bilgileri görüntülenebilir veya eklenebilir.

        //Verilerin tutulacağı DataTable nesnesi
        DataTable Veriler;

        //Eğer seçili bir öğrenci veya kitap yok ise -1
        int gNo = -1;
        bool ogrDurum = false; //Eğer öğrenciden gelindiyse true, kitaptan gelindiyse false

        public EmanetListe()
        {
            InitializeComponent();
            //Boş geliyorsa admindendir, No = -1
            gNo = -1;
        }

        public EmanetListe(int gecerliNo, bool ogrMi)
        {
            InitializeComponent();

            //Eğer parametreli geliyorsa ya öğrenci ya da kitaptır.
            if (ogrMi) //Eğer öğrenciyse
            {
                //Varsayılan sorguyu no'ya eşit olarak tanımlayalım.
                Business.Emanet.DefaultKosul = " AND e.ogrenciNo = " + gecerliNo.ToString();
                tb_ogrAra.Visible = false;  //Öğrenciden gelmişse öğrenci aranamaz.
                btn_ogrAra.Visible = false;
                gNo = gecerliNo;            //Geçerli no statik olarak sisteme geçildi
                ogrDurum = ogrMi;           //Geçerli öğrenci/kitap belirteci sisteme geçildi
            }
            else //Eğer kitapsa
            {
                //Varsayılan sorguyu no'ya eşit olarak tanımlayalım.
                Business.Emanet.DefaultKosul = " AND e.kitapNo = " + gecerliNo.ToString();
                tb_kitapAra.Visible = false;//Kitaptan gelmişse kitap aranamaz.
                btn_kitapAra.Visible = false;
                gNo = gecerliNo;            //Geçerli no statik olarak sisteme geçildi
                ogrDurum = ogrMi;           //Geçerli öğrenci/kitap belirteci sisteme geçildi
            }
        }

        //Emanet listesini güncelleyebilmek için
        //Öğrenci/kitaptan gelmişse bu durum Business kısmından halledilecek, burada ekstra bir şey yok
        private void ListeGuncelle()
        {
            dgv_emanetler.Rows.Clear();                 //DataGridView temizle
            foreach (DataRow row in Veriler.Rows)       //Veriyi oku, DGV'ye ekle
            {
                dgv_emanetler.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5]);

                //Tarihlerine bakalım, satırı boyamak için.
                DateTime Bugun = DateTime.Today;        //Bugünün tarihini alalım, aradaki farkı hesaplamak için
                DateTime SatirIade = Convert.ToDateTime(row[4]);//İade ile aradaki fark bulunacak
                bool Teslim = Convert.ToBoolean(row[5]);//Teslim edildi mi belirteci
                if (!Teslim)                            //Eğer hala teslim/iade edilmemişse
                {
                    if (SatirIade < Bugun)              //Eğer iadede geç kalınmışsa
                    {                                   //Kırmızıya boya
                        dgv_emanetler.Rows[dgv_emanetler.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Red;
                    }
                    else                                //Geç kalınmamışsa
                    {
                        Bugun = Bugun.AddDays(2);       //Bugüne iki gün ekle
                        if (SatirIade <= Bugun)         //Eğer iki gün sonra geç kalınacaksa
                        {                               //Sarıya boya
                            dgv_emanetler.Rows[dgv_emanetler.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Yellow;
                        }
                        else                            //Daha süresi varsa
                        {                               //Yeşile boya
                            dgv_emanetler.Rows[dgv_emanetler.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Green;
                        }
                    }
                }
                else                                    //Eğer teslim edilmişse
                {                                       //Maviye boya
                    dgv_emanetler.Rows[dgv_emanetler.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Blue;
                }
            }
        }

        //Aşağıdaki altı fonksiyon, TextBox PlaceHolder'ı için bulunmakta.
        //Placeholder, textbox boş iken textbox'a ne yazılabileceğini belirtmek için bulunmakta.

        //Emaneti no'ya göre arama TextBox'ı Focus kazandığında
        private void tb_noAra_Enter(object sender, EventArgs e)
        {
            if (tb_noAra.Text == "Emanet No Ara...")    //Eğer varsayılan yazı ise
            {
                tb_noAra.Text = "";                     //Yazı kaybolsun
                tb_noAra.ForeColor = Color.Black;       //Yazı rengi siyah olsun
            }
        }

        //Emaneti no'ya göre arama TextBox'ı Focus kaybettiğinde
        private void tb_noAra_Leave(object sender, EventArgs e)
        {
            if (tb_noAra.Text == "")                    //Eğer textbox boş ise
            {
                tb_noAra.Text = "Emanet No Ara...";     //Varsayılan yazıyı yerleştir(Placeholder)
                tb_noAra.ForeColor = Color.DarkGray;    //Yazıyı gri yap
            }
        }

        //Emaneti öğrenci no'ya veya adına göre arama TextBox'ı Focus kazandığında
        private void tb_ogrAra_Enter(object sender, EventArgs e)
        {
            if (tb_ogrAra.Text == "Öğrenci No veya Ad-Soyad Ara...")//Eğer varsayılan yazı ise
            {
                tb_ogrAra.Text = "";                    //Yazı kaybolsun
                tb_ogrAra.ForeColor = Color.Black;      //Yazı rengi siyah olsun
            }
        }

        //Emaneti öğrenci no'ya veya adına göre arama TextBox'ı Focus kaybettiğinde
        private void tb_ogrAra_Leave(object sender, EventArgs e)
        {
            if (tb_ogrAra.Text == "")                   //Eğer textbox boş ise
            {
                tb_ogrAra.Text = "Öğrenci No veya Ad-Soyad Ara...";//Varsayılan yazıyı yerleştir(Placeholder)
                tb_ogrAra.ForeColor = Color.DarkGray;   //Yazıyı gri yap
            }
        }

        //Emaneti kitap adına veya no'suna göre arama TextBox'ı Focus kazandığında
        private void tb_kitapAra_Enter(object sender, EventArgs e)
        {
            if (tb_kitapAra.Text == "Kitap No veya Ad ile Ara...")//Eğer varsayılan yazı ise
            {
                tb_kitapAra.Text = "";                  //Yazı kaybolsun
                tb_kitapAra.ForeColor = Color.Black;    //Yazı rengi siyah olsun
            }
        }

        //Emaneti kitap no'suna veya adına göre arama TextBox'ı Focus kaybettiğinde
        private void tb_kitapAra_Leave(object sender, EventArgs e)
        {
            if (tb_kitapAra.Text == "")                 //Eğer textbox boş ise
            {
                tb_kitapAra.Text = "Kitap No veya Ad ile Ara...";//Varsayılan yazıyı yerleştir(Placeholder)
                tb_kitapAra.ForeColor = Color.DarkGray; //Yazıyı gri yap
            }
        }

        //Form yüklendiğinde/Açıldığında
        private void EmanetListe_Load(object sender, EventArgs e)
        {
            //Butonlarımız ikon türü olduğu için açıklayıcı tooltip'lere ihtiyacımız var
            toolTip.SetToolTip(btn_emanetEkle, "Emanet Ekle");//Gerekli nesneye yazdığımız Tooltip'i ekle
            toolTip.SetToolTip(btn_emanetIade, "Seçili Emaneti İade Et");
            toolTip.SetToolTip(btn_noAra, "Emanet Numarasına Göre Ara");
            toolTip.SetToolTip(btn_ogrAra, "Öğrenci Bilgisine Göre Ara (No, Ad, Soyad)");
            toolTip.SetToolTip(btn_kitapAra, "Kitap Bilgisine Göre Ara (No, Ad)");
            toolTip.SetToolTip(btn_grafik, "Kitap Grafiğini Aç");

            //Burada PlaceHolder için yazı ve renk yerleştirmesi yapıyoruz Textbox'larımıza
            tb_noAra.ForeColor = Color.DarkGray;
            tb_ogrAra.ForeColor = Color.DarkGray;
            tb_kitapAra.ForeColor = Color.DarkGray;

            Veriler = Business.Emanet.EmanetListele();  //Öncelikle öğrenci listesini veritabanından çek
            ListeGuncelle();                            //Sonra DataGridView'i güncelle
        }

        // Eğer emanet numarasına göre listede arama yapacaksak, bu butona tıklıyoruz
        private void btn_noAra_Click(object sender, EventArgs e)
        {   //Bu işlemde birkaç sebepten dolayı hata verebilir, try kullanalım
            try
            {
                int test = Convert.ToInt32(tb_noAra.Text);                  //Önce sayıya çevir, sayı mı değil mi bakmak için
                Veriler = Business.Emanet.EmanetListeleEmn(tb_noAra.Text);  //EmanetListeleEmn fonksiyonuna sayıyı gönder
                ListeGuncelle();                                            //Listeyi güncelle
            }
            catch (Exception err)                   //Eğer gönderdiği metin bir sayıya dönüştürülemezse
            {                                       //Bu yazı boş ise veya Placeholder yazısı DEĞİL ise
                if (tb_noAra.Text != "" && tb_noAra.Text != "Emanet No Ara...")
                {                                   //Hata ver. Metin aratılamaz.
                    MessageBox.Show("Lütfen no ile aramaya bir sayı giriniz veya boş bırakınız!");
                }
                else                                //Eğer Placeholder veya boş ise, bütün listeyi döndür.
                {
                    Veriler = Business.Emanet.EmanetListele();
                    ListeGuncelle();//Ve elbet güncelle
                }
            }
        }

        // Eğer öğrenci numarasına veya ad soyadına göre listede arama yapacaksak, bu butona tıklıyoruz
        private void btn_ogrAra_Click(object sender, EventArgs e)
        {   //Sayı mı yazı mı anlamak için try catch
            try
            {
                int test = Convert.ToInt32(tb_ogrAra.Text);         //Yazı ise hata verecek ve catch'e atacak
                //EmanetListeleOgr'ye numarayı ve numara belirtecini yolla(true)
                Veriler = Business.Emanet.EmanetListeleOgr(tb_ogrAra.Text, true); 
                ListeGuncelle();                                    //Ve listeyi güncelle
            }
            catch (Exception err)                                   //Eğer yazı ise
            {                                                       //Ve eğer bu yazı boş veya placeholder DEĞİL ise
                if (tb_ogrAra.Text != "" && tb_ogrAra.Text != "Öğrenci No veya Ad-Soyad Ara...")
                {                                                   //Yazıyı, yazı belirteciyle listelemeye yolla
                    Veriler = Business.Emanet.EmanetListeleOgr(tb_ogrAra.Text, false);
                    ListeGuncelle();                                //Ve listele
                }
                else                                                //Yazı placeholder veya boş ise
                {
                    Veriler = Business.Emanet.EmanetListele();      //Öyleyse hepsini getir
                    ListeGuncelle();                                //Ve listele
                }
            }
        }

        // Eğer kitap numarasına veya adına göre listede arama yapacaksak, bu butona tıklıyoruz
        private void btn_kitapAra_Click(object sender, EventArgs e)
        {
            try                                                     
            {
                int test = Convert.ToInt32(tb_kitapAra.Text);       //Yazı ise hata verecek ve catch'e atacak
                //EmanetListeleOgr'ye numarayı ve numara belirtecini yolla(true)
                Veriler = Business.Emanet.EmanetListeleKtp(tb_kitapAra.Text, true);
                ListeGuncelle();                                    //Ve listeyi güncelle
            }
            catch (Exception err)                                   //Eğer yazı ise
            {                                                       //Ve eğer bu yazı boş veya placeholder DEĞİL ise
                if (tb_kitapAra.Text != "" && tb_kitapAra.Text != "Kitap No veya Ad ile Ara...")
                {                                                   //Yazıyı, yazı belirteciyle listelemeye yolla
                    Veriler = Business.Emanet.EmanetListeleKtp(tb_kitapAra.Text, false);
                    ListeGuncelle();                                //Ve listele
                }
                else                                                //Yazı placeholder veya boş ise
                {
                    Veriler = Business.Emanet.EmanetListele();      //Öyleyse hepsini getir
                    ListeGuncelle();                                //Ve listele
                }
            }
        }

        //Eğer emanet eklemek istersek bu butona tıklıyoruz.
        private void btn_emanetEkle_Click(object sender, EventArgs e)
        {
            //Emanet ekleme ekranına gerekli numara(Yoksa -1) ve öğrenci/kitap belirtecini yolluyoruz
            Presentation.EmanetPencere emanetEkle = new Presentation.EmanetPencere(gNo, ogrDurum);

            
            DialogResult Sonuc = emanetEkle.ShowDialog();       //Pencereden yanıt alabilmek için ShowDialog kullanıyoruz
            if (Sonuc == DialogResult.OK)                       //Eğer OK yanıtı alırsak
            {
                Veriler = Business.Emanet.EmanetListele();      //Emaneti listeliyoruz
                ListeGuncelle();
            }
        }

        //Emanet iade etmek istersek bu butona tıklıyoruz
        private void btn_emanetIade_Click(object sender, EventArgs e)
        {
            if (dgv_emanetler.SelectedCells.Count == 1)                 //Gerçekten bir hücre mi seçili?
            {
                int RowIndex = dgv_emanetler.SelectedCells[0].RowIndex; //Seçili hücrenin satır index'ini bul
                int emanetNo = (int)dgv_emanetler.Rows[RowIndex].Cells[0].Value;//Index'in 0. sütununu bul, emanet no için
                int Borc = Business.Emanet.BorcHesapla(emanetNo);       //Borç hesaplama, iade öncesi borcu göstermek için
                DialogResult Sonuc;                                     //Pencereyi göstereceğiz ama if içinde olmayacağı için önce sonucu tanımlayalım
                if (Borc == 0)  //Eğer borç 0 ise iade mesajı
                {               //Onaylarsa Yes dönecek, değilse No
                    Sonuc = MessageBox.Show("Bu kitabı şimdi iade ederseniz hesabınıza borç eklenmeyecektir. Kitabı iade etmek ister misiniz?", "İade Et", MessageBoxButtons.YesNo);
                }
                else            //Eğer borç 1 veya daha fazla ise iade mesajı
                {               //Onaylarsa Yes dönecek, değilse No
                    Sonuc = MessageBox.Show("Bu kitabı şimdi iade ederseniz hesabınıza eklenecek borç miktarı: " + Borc +  ". Kitabı iade etmek ister misiniz?", "İade Et", MessageBoxButtons.YesNo);
                }

                if (Sonuc == DialogResult.Yes) //Onaylandı mı?
                {
                    Business.Emanet.EmanetIade(emanetNo, Borc); //Öyleyse borcu ve emanet numarasını iade için Business'a gönder

                    Veriler = Business.Emanet.EmanetListele();  //Ve listele
                    ListeGuncelle();
                }
            }
            else
            {
                MessageBox.Show("Lütfen sadece bir tane hücre seçiniz!");   //Yeterli hücre seçilmezse
            }
        }

        //Burada ekstra olarak kitapların grafiği gösterilebilecek. Bunun için gerekli buton işlemi.
        private void btn_grafik_Click(object sender, EventArgs e)
        {
            Presentation.Grafik a = new Presentation.Grafik();
            //Grafik verileri statik tutmakta ve sadece açılışta güncellenmekte
            //Bu yüzden ShowDialog yaparak arkadan verilerin değişmemesini sağlamak daha güvenli
            a.ShowDialog();
        }
    }
}
