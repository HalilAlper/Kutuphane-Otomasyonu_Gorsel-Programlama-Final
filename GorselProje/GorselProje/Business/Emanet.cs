using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; //Bütün form işlemleri için gerekli, ancak biz MessageBox için ekledik.
using System.Data;          //DataTable kullanımı için
using System.Data.OleDb;    //OleDbCommand kullanımı için ekledik

//YAPIMDA HİÇBİR BUSINESS NESNESİ, SATIR KİMLİK SÜTUNU HARİCİNDE
//VERİTABANINDAKİ SÜTUNLARA DENK GELEN ÖĞE KULLANMAK ZORUNDA DEĞİLDİR

namespace GorselProje.Business
{
    /*
    Emanet nesnesi:
        Emanetlere ait gerekli verileri tutar.
        Bütün değiştirilebilir öğeleri private'dır.
        Her private öğenin verisinin alınabilmesi için public bir öğe tanımlanmıştır, ve bu bir get fonksiyona sahiptir.
        Direkt satırı ilgilendiren metodlar hariç bütün metodlar statik tanımlandı.
    */
    class Emanet
    {
        //Nesnemizin doğru çalışabilmesi için gerekli özellikler
        private int emanetNo { get; set; }          //Satır kimlik sütunu
        private int ogrenciNo { get; set; }
        private int kitapNo { get; set; }
        private DateTime emanetTarih { get; set; }
        private DateTime iadeTarih { get; set; }
        private bool teslim { get; set; }

        //Üstteki private özellikler için Get fonksiyonları, ama özellik biçiminde.
        //Aradaki fark, baş harflerinin büyük oluşu. Bütün uygulamamızda bu şekilde mevcuttur.
        public int EmanetNo { get { return emanetNo; } }
        public int OgrenciNo { get { return ogrenciNo; } }
        public int KitapNo { get { return kitapNo; } }
        public DateTime EmanetTarih { get { return emanetTarih; } }
        public DateTime IadeTarih { get { return iadeTarih; } }
        public bool Teslim { get { return teslim; } }
        //Yorum satırlarını yazarken fark ettim, yüksek satır sayılarından o kadar sıkılmışım ki bu fonksiyonları büzütmüşüm...

        /*
         *İşte işlerin biraz daha ilginçleştiği o güzel kısım...
         *Emanet verilerinin her biri bir öğrenci no ve kitap no tutar.
         *Gelgelelim bunu Presentation katmanına sunmamız imkansızdır çünkü kullanıcı bununla ilgilenmez.
         *Ona adlar gereklidir.
         *Ancak işlemlerimizi kolaylaştırmak için bizim no'lara ihtiyacımız vardır.
         *İşte bu yüzden bütün bu no'ları tutacak statik özelliklerimizi burada oluşturuyoruz.
         */
        private static Dictionary<int, int> EmnOgr { get; set; } = new Dictionary<int, int>(); //Emanet no'lara ait öğrenci no
        private static Dictionary<int, int> EmnKtp { get; set; } = new Dictionary<int, int>(); //Emanet no'lara ait kitap no

        //Emanet eklerken de bizim kullanıcıya ADLARI göstermemiz gereklidir.
        //Bu adlar sırasıyla birer no'ya sahiptir.
        //Bu no'lar bu dizilerde tutulur, veritabanından alındıklarında.
        private static int[] OgrAdlar { get; set; }
        private static int[] KtpAdlar { get; set; }

        //Emanet formu birden fazla form tarafından açılabilir.
        //Eğer admin panelinden açılırsa:
        //  Bütün emanetler görülebilir olmalı
        //  Herkese her kitap emanet edilebilmeli
        //  Bu emanetler aranabilmelidir.

        //Ancak öğrenci kısmından girildiğinde:
        //  Sadece öğrenciye ait emanetler görüntülenmeli
        //  Sadece öğrenciye emanet eklenebilmelidir.
        //  Başka öğrenciler aratılmamalıdır.

        //Ve kitap kısmından girildiğinde:
        //  Sadece kitaba ait emanetler görüntülenmeli
        //  Sadece seçili kitap emanet olarak eklenebilmelidir.
        //  Başka kitaplar aratılmamalıdır.
        //  Grafik bir istisnadır.

        //Üstteki sebeplerden dolayı DefaultKosul'umuz var.
        //Varsayılan bir koşul, her listeleme sorgusuna eklenen.
        //Eğer admin panelinden açılırsa boş.
        //Öğrenci panelinden açılırsa gerekli öğrencinin ogrenciNo'sunu Where sorgusu olarak tutar
        //Kitap panelinden açılırsa gerekli kitabın kitapNo'sunu Where sorgusu olarak tutar
        public static string DefaultKosul { get; set; } = "";

        public Emanet(Dictionary<string, object> Param)
        {
            try //Bütün private özelliklerin tanımlamasının bu fonksiyonda nesne oluşturulurken yapılması gerekiyor
            {   //Her bir parametrenin özelliklere atanmadan önce gerekli türlere dönüştürülmeleri gerek
                emanetNo = (int)Param["emanetNo"];
                ogrenciNo = Convert.ToInt32(Param["ogrenciNo"].ToString());
                kitapNo = Convert.ToInt32(Param["kitapNo"].ToString());
                emanetTarih = Convert.ToDateTime(Param["emanetTarih"].ToString());
                iadeTarih = Convert.ToDateTime(Param["iadeTarih"].ToString());
                teslim = Convert.ToBoolean(Param["teslim"].ToString());
            }
            catch (Exception e)//Yanlış veri gönderimi sadece veritabanına manuel veri eklenirse olur. Yine de kontrol şart!
            {
                MessageBox.Show("Yanlış veri gönderimi! Kitap nesnesi oluşturulamadı! Hata: " + e.ToString());
            }
        }

        //Yukarıda yazdığım sebeplerden ötürü bu fonksiyonumuz var.
        //Bu fonksiyon herhangi bir veri listelendiğinde gerekli statik özelliklere veri atayan fonksiyondur.
        //Çoğu Select sorgusu buradan geçer ve kitapNo ve ogrenciNo'lar gerekli yerlere aktarılır.
        private static DataTable ListelemeProtokol(OleDbCommand Komut)
        {
            //Sonuçlar burada toplanır
            DataTable Sonuclar = DataAccess.Database.SelectSorgu(Komut);

            //Önce gerekli Dictionary'ler temizlenir
            EmnOgr.Clear();
            EmnKtp.Clear();
            //Sonra dictionary'ler gelen verilerle tekrar doldurulur.
            foreach (DataRow row in Sonuclar.Rows)
            {
                EmnOgr.Add((int)row[0], (int)row[6]);
                EmnKtp.Add((int)row[0], (int)row[7]);
            }

            //Ve sonuçlar sadece okunduktan sonra el değmeden istenilen yere geri döndürülür.
            return Sonuclar;
        }

        //Emanet ekleneceği zaman açılış seçeneklerini yukarıda yazmıştık.
        //Bu sebepten ötürü, sadece öğrenci ad soyadı veya kitap adı gözükeceği için
        //Gerekli index numarasıyla öğrenci veya kitap noyu bulmayı kolaylaştırmak için bu fonksiyon var
        //Ekleme sırasında kullanıcı öğrenci ve kitap adını seçecek
        //Bu fonksiyon ise index ile noyu bulabilmesi adına programın, index sırasıyla no'ları kaydedecek
        private static DataTable EmanetPencereProtokol(OleDbCommand Komut, bool Ogr) // Ya Ogr, ya da Ktp
        {
            //Komutumuz çalıştırılıyor.
            DataTable Sonuclar = DataAccess.Database.SelectSorgu(Komut);
            if (Ogr)    //Eğer öğrenci ise
            {           //Gerekli öğrenci listesi okunup bütün öğrenci no'ları index sırasına göre kaydoluyor
                OgrAdlar = new int[Sonuclar.Rows.Count];
                for (int i = 0; i < Sonuclar.Rows.Count; i++)
                {
                        //Tek tek, diziye kaydediliyor.
                    DataRow row = Sonuclar.Rows[i];
                    OgrAdlar[i] = (int)row[0];
                }
            }
            else        //Eğer Kitap ise
            {           //Gerekli kitap listesi okunup bütün kitap no'ları index sırasına göre kaydoluyor
                KtpAdlar = new int[Sonuclar.Rows.Count];
                for (int i = 0; i < Sonuclar.Rows.Count; i++)
                {
                        //Tek tek, diziye kaydediliyor.
                    DataRow row = Sonuclar.Rows[i];
                    KtpAdlar[i] = (int)row[0];
                }
            }

            //Sonuçlar(Öğrenci listesi veya kitap listesi) geri döndürülüyor.
            return Sonuclar;
        }

        //Bütün emanetlerin listelenmesi için (Yukarıda yazdığımız DefaultKosul şartı ile)
        public static DataTable EmanetListele()
        {
            //Emanetler tabloya düzgün bir şekilde yerleştirilebilmek için öğrenci ad soyad ve kitap adı ile çağırılıyor.
            string Sorgu = "Select e.emanetNo, (o.ad & ' ' & o.soyad) as adsoyad, k.kitapAd, e.emanetTarih, e.iadeTarih, e.teslim, e.ogrenciNo, e.kitapNo From Emanet as e, Ogrenci as o, Kitap as k Where e.OgrenciNo = o.ogrenciNo AND e.kitapNo = k.kitapNo";
            Sorgu = Sorgu + DefaultKosul;                   //DefaultKosul sorguya dahil ediliyor.
            OleDbCommand Komut = new OleDbCommand(Sorgu);   //Komut çalıştırılmak üzere gönderiliyor.
            //Gelen liste, ListelemeProtokol'e gönderiliyor. Okunup geri istenilen yere döndürülüyor.
            return ListelemeProtokol(Komut);                
        }

        //Oldu da belirli özelliklere sahip emanetleri listelemek istedik
        //Mesela:
        //  Belirli bir no'ya sahip emanetleri
        public static DataTable EmanetListeleEmn(string ParamStr) //Sadece emanet adı aratılabilir bu fonksiyonda
        {
            if (ParamStr != "")//Eğer gelen parametre boş değilse...
            {
                //Gerekli sorgu yazılıyor ve DefaultKosul ekleniyor
                string Sorgu = "Select e.emanetNo, (o.ad & ' ' & o.soyad) as adsoyad, k.kitapAd, e.emanetTarih, e.iadeTarih, e.teslim, e.ogrenciNo, e.kitapNo From Emanet as e, Ogrenci as o, Kitap as k Where e.OgrenciNo = o.ogrenciNo AND e.kitapNo = k.kitapNo";
                Sorgu = Sorgu + DefaultKosul;

                Sorgu += " AND e.emanetNo = @emanetNo";         //Sorguya gerekli emanet no arama sorgusu giriliyor
                OleDbCommand Komut = new OleDbCommand(Sorgu);   //Komut üretimi ve parametre girişi
                Komut.Parameters.AddWithValue("@emanetNo", Convert.ToInt32(ParamStr));
                return ListelemeProtokol(Komut);                //Listeleme protokolü ve geri gönderme
            }
            else
            {
                return EmanetListele();
            }
        }

        //Oldu da belirli özelliklere sahip emanetleri listelemek istedik
        //Mesela:
        //  Belirli bir ogrenciNo'ya veya öğrenci adına ait emanetleri
        public static DataTable EmanetListeleOgr(string ParamStr, bool isNo)
        {
            if (ParamStr != "")//Eğer gelen parametre boş değilse...
            {
                //Gerekli sorgu yazılıyor ve DefaultKosul ekleniyor
                string Sorgu = "Select e.emanetNo, (o.ad & ' ' & o.soyad) as adsoyad, k.kitapAd, e.emanetTarih, e.iadeTarih, e.teslim, e.ogrenciNo, e.kitapNo From Emanet as e, Ogrenci as o, Kitap as k Where e.OgrenciNo = o.ogrenciNo AND e.kitapNo = k.kitapNo";
                Sorgu = Sorgu + DefaultKosul;
                if (isNo)   //Eğer gelen arama biçimi bir sayı ise
                {           //Sorguya gerekli ogrenciNo arama sorgusu giriliyor
                    Sorgu += " AND e.ogrenciNo = @ogrenciNo";
                    OleDbCommand Komut = new OleDbCommand(Sorgu);   //Komut nesnesi üretimi, parametre girişi
                    Komut.Parameters.AddWithValue("@ogrenciNo", Convert.ToInt32(ParamStr));
                    return ListelemeProtokol(Komut);                //Listeleme protokolü ve geri gönderme
                }
                else
                {           //Sayı araması değil ise gerekli olan veri adSoyad şeklinde aratılıyor
                    Sorgu += " AND (o.ad & ' ' & o.soyad) LIKE @adsoyad";
                    OleDbCommand Komut = new OleDbCommand(Sorgu);   //Komut nesnesi üretimi, parametre girişi
                    ParamStr = "%" + ParamStr + "%";                //LIKE komutu için yüzdeler, sağdan ve soldan metin devam edebilir
                    Komut.Parameters.AddWithValue("@adsoyad", ParamStr);
                    return ListelemeProtokol(Komut);                //Listeleme protokolü ve geri gönderme
                }
            }
            else
            {//Parametre boş ise normal liste yolla
                return EmanetListele();
            }
        }

        //Oldu da belirli özelliklere sahip emanetleri listelemek istedik
        //Mesela:
        //  Belirli bir kitapNo'ya veya kitap adına ait emanetleri
        public static DataTable EmanetListeleKtp(string ParamStr, bool isNo)
        {
            if (ParamStr != "") //Eğer gelen parametre boş değilse...
            {                   //Gerekli sorgu yazılıyor ve DefaultKosul ekleniyor
                string Sorgu = "Select e.emanetNo, (o.ad & ' ' & o.soyad) as adsoyad, k.kitapAd, e.emanetTarih, e.iadeTarih, e.teslim, e.ogrenciNo, e.kitapNo From Emanet as e, Ogrenci as o, Kitap as k Where e.OgrenciNo = o.ogrenciNo AND e.kitapNo = k.kitapNo";
                Sorgu = Sorgu + DefaultKosul;
                if (isNo)       //Eğer gelen arama biçimi bir sayı ise
                {               //Sorguya gerekli kitapNo arama sorgusu giriliyor
                    Sorgu += " AND e.kitapNo = @kitapNo";
                    OleDbCommand Komut = new OleDbCommand(Sorgu);   //Komut nesnesi üretimi, parametre girişi
                    Komut.Parameters.AddWithValue("@ogrenciNo", Convert.ToInt32(ParamStr));
                    return ListelemeProtokol(Komut);                //Listeleme protokolü ve geri gönderme
                }
                else
                {               //Sayı araması değil ise gerekli olan veri ad şeklinde aratılıyor
                    Sorgu += " AND k.kitapAd LIKE @kitapAd";
                    OleDbCommand Komut = new OleDbCommand(Sorgu);   //Komut nesnesi üretimi, parametre girişi
                    ParamStr = "%" + ParamStr + "%";                //LIKE komutu için yüzdeler, sağdan ve soldan metin devam edebilir
                    Komut.Parameters.AddWithValue("@kitapAd", ParamStr);
                    return ListelemeProtokol(Komut);                //Listeleme protokolü ve geri gönderme
                }
            }
            else
            {//Parametre boş ise normal liste yolla
                return EmanetListele();
            }
        }

        //Veritabanına emanet eklemek için. Eklenen emaneti ihtiyaç duyulur diye nesne olarak geri döndürür.
        public static Emanet EmanetEkle(Dictionary<string, object> Param)
        {
            //Öğrenci ekleme işlemi önce gelen veriyi kontrol eder;
            //Bu kontrol metnin uzunluğunu, borç ve geç iade verisini kontrol eder.
            //Herhangi bir hata bulunursa return null; satırı ile boş geri dönüş sağlanır.

            //Kontrol
            if (Param["ogrenciadsoyad"].ToString().Length < 3)
            {
                MessageBox.Show("Öğrenci seçimi yapılmamış!");
                return null;
            }
            if (Param["kitapAd"].ToString().Length < 3)
            {
                MessageBox.Show("Kitap seçimi yapılmamış!");
                return null;
            }
            if (Convert.ToDateTime(Param["emanetTarih"].ToString()) >= DateTime.Now)
            {
                MessageBox.Show("Teslim randevusu yapılamaz! Lütfen bugünden önce bir tarih giriniz!");
                return null;
            }
            if (Convert.ToDateTime(Param["iadeTarih"].ToString()) <= DateTime.Now)
            {
                MessageBox.Show("Öğrenci önceden sisteme girilmeden verilmiş kitap için borçlu gösterilemez! Lütfen iade tarihini bugün veya daha sonraki bir tarih olarak girin!");
                return null;
            }

            //Index'lerden gerekli değerleri bulmak (EmanetPencereProtokol sağ olsun) 
            int ogrNo = OgrAdlar[Convert.ToInt32(Param["ogrenciindex"])];
            int ktpNo = KtpAdlar[Convert.ToInt32(Param["kitapindex"])];
            Param.Add("ogrenciNo", ogrNo); //Nesne oluşturmak için
            Param.Add("kitapNo", ktpNo); //Nesne oluşturmak için

            //Önce adet, çünkü emanet verildiğinde adet sayısı azalır
            //Gerekli sorguyla adedi bir azaltıyoruz.
            string Sorgu = "Update Kitap Set " +
                    "adet = adet - 1 " +
                    "Where kitapNo = @kitapNo";
            OleDbCommand Komut = new OleDbCommand(Sorgu);
            Komut.Parameters.AddWithValue("@kitapNo", ktpNo);
            int SatirSayi = DataAccess.Database.UpdateSorgu(Komut);

            //Sonra Giriş
            //Bütün giriş bilgileri önceden kontrol edildi, sorgu yazımı ve komut oluşturma sonrası
            //Tek tek parametreler ekleniyorlar
            Sorgu = "Insert Into Emanet (ogrenciNo, kitapNo, emanetTarih, iadeTarih, teslim) Values" +
                "(@ogrenciNo, @kitapNo, @emanetTarih, @iadeTarih, @teslim)";
            Komut = new OleDbCommand(Sorgu);
            Komut.Parameters.AddWithValue("@ogrenciNo", ogrNo);
            Komut.Parameters.AddWithValue("@kitapNo", ktpNo);
            Komut.Parameters.AddWithValue("@emanetTarih", Param["emanetTarih"].ToString());
            Komut.Parameters.AddWithValue("@iadeTarih", Param["iadeTarih"].ToString());
            Komut.Parameters.AddWithValue("@teslim", Convert.ToBoolean(Param["teslim"]));

            //InsertSorgu ile ekleyelim
            int Output = DataAccess.Database.InsertSorgu(Komut);
            Param.Add("emanetNo", Output); //Identity'i geri almayı unutmayalım

            return new Emanet(Param); //Ve bununla nesne oluşturup geri döndürelim
        }

        //Just like the simulations!
        //Diğer nesnelerimizde yaptığımız gibi "Silme" işlemimiz, birçok faktör ele alınarak
        public static int EmanetIade(int emanetNo, int Borc)
        {
            //Birçok kez kullanacağız, hazır tutalım
            string Sorgu;
            OleDbCommand Komut;
            int SatirSayi;

            //Her şeyden önce öğrenciNo ve kitapNo
            //Bu verilere ihtiyacımız var.
            int ogrNo, ktpNo;
            Sorgu = "Select ogrenciNo, kitapNo From Emanet Where emanetNo = @emanetNo";
            Komut = new OleDbCommand(Sorgu);
            Komut.Parameters.AddWithValue("@emanetNo", emanetNo);
            //Sonuçları alalım
            DataTable Sonuclar = DataAccess.Database.SelectSorgu(Komut);

            //Sonuçları aldıktan sonra gerekli bilinmeyenlere yerleştirmemiz gerek. Sonra kullanacağız.
            ogrNo = Convert.ToInt32(Sonuclar.Rows[0][0].ToString());
            ktpNo = Convert.ToInt32(Sonuclar.Rows[0][1].ToString());

            //Sonra Borç, eğer gecikmişse borcu olacaktır. Bu zaten BorcHesapla fonksiyonu ile hesaplandı
            if (Borc != 0)
            {
                //Eğer borcu arttıysa aynı zamanda geç iade etmiştir. GecIade +1
                //Ve aynı zamanda borç da ekliyoruz
                Sorgu = "Update Ogrenci Set " +
                    "borc = borc + @borc, " +
                    "gecIade = gecIade + 1 " +
                    "Where ogrenciNo = @ogrenciNo";
                Komut = new OleDbCommand(Sorgu);
                Komut.Parameters.AddWithValue("@borc", Borc);
                Komut.Parameters.AddWithValue("@ogrenciNo", ogrNo);
                //Komutumuzu gerçekleyelim
                SatirSayi = DataAccess.Database.UpdateSorgu(Komut);

            }

            //Sonra adet, iade edildiğinde kitabın adedi bir artar.
            Sorgu = "Update Kitap Set " +
                    "adet = adet + 1 " +
                    "Where kitapNo = @kitapNo";
            Komut = new OleDbCommand(Sorgu);
            Komut.Parameters.AddWithValue("@kitapNo", ktpNo);
            SatirSayi = DataAccess.Database.UpdateSorgu(Komut);

            //En son olarak teslim, artık emanetin teslim durumunu değiştirebiliriz.
            Sorgu = "Update Emanet Set " +
                "teslim = true " +
                "Where emanetNo = @emanetNo";
            Komut = new OleDbCommand(Sorgu);
            Komut.Parameters.AddWithValue("@emanetNo", emanetNo);
            //Ve böylece, bitirelim. Satır değişimi sayısını geri döndürüyoruz.
            return DataAccess.Database.UpdateSorgu(Komut);
        }

        //Bütün öğrencilerin ad soyadları. EmanetEkle penceresi için. Buradan geçme sebebi index'e kaydedilmesi.
        public static DataTable OgrenciListele()
        {
            string Sorgu = "Select ogrenciNo, (ad & ' ' & soyad) as adsoyad From Ogrenci Where silindi = false Order By (ad & ' ' & soyad) ASC";
            OleDbCommand Komut = new OleDbCommand(Sorgu);
            return EmanetPencereProtokol(Komut, true); //Bu fonksiyonla index'e kaydediliyorlar.
        }

        //Bütün kitapların adları. EmanetEkle penceresi için. Buradan geçme sebebi index'e kaydedilmesi.
        public static DataTable KitapListele()
        {
            string Sorgu = "Select kitapNo, (kitapAd & ' (' & adet & ')') as kitapAd From Kitap Where adet > 0 And silindi = false Order By (kitapAd & ' (' & adet & ')') ASC";
            OleDbCommand Komut = new OleDbCommand(Sorgu);
            return EmanetPencereProtokol(Komut, false);//Bu fonksiyonla index'e kaydediliyorlar.
        }

        //Borcun önceden kullanıcıya bildirilmesi(İade sırasında), sonrasında sisteme eklenmesi için
        public static int BorcHesapla(int emanetNo)
        {
            //Öncelikle iadeTarih'i döndürecek bir sorgu yazıyoruz ve çalıştırıyoruz.
            string Sorgu = "Select iadeTarih From Emanet Where emanetNo = @emanetNo";
            OleDbCommand Komut = new OleDbCommand(Sorgu);
            Komut.Parameters.AddWithValue("@emanetNo", emanetNo);
            DataTable Tarih = DataAccess.Database.SelectSorgu(Komut);

            //Bugünü ve iadeTarih'i bilinmeyene alıyoruz.
            DateTime IadeTarih = Convert.ToDateTime(Tarih.Rows[0][0]);
            DateTime Bugun = DateTime.Today;

            //Aradaki farka bakıyoruz. Bugün daha küçükse henüz gecikmemiştir.
            if (Bugun < IadeTarih)
            {
                return 0;
            }
            else
            {//Bugün büyükse gecikmiştir. Geçen gün sayısını alıyoruz ve borç olarak döndürüyoruz.
                return (Bugun - IadeTarih).Days;
            }
        }

        //Daha öncesinde dizilere konulmuş no'lar arasında arama yapıp gerekli no'ya ait index'i döndürmek
        public static int IndexGetir(int gNo, bool ogrDurum)
        {
            int Index = -1; //Eğer bulunamamışsa -1 döndürsün
            if (ogrDurum) //Eğer öğrenci arıyorsak
            {
                for (int i = 0; i < OgrAdlar.Length; i++) //Bütün öğrenci no'ları arasında ara
                {
                    if (OgrAdlar[i] == gNo) //Bulduysan
                    {
                        Index = i; //Index'i döndür
                    }
                }
            }
            else //Eğer kitap arıyorsak
            {
                for (int i = 0; i < KtpAdlar.Length; i++)//Bütün kitap no'ları arasında ara
                {
                    if (KtpAdlar[i] == gNo)//Bulduysan
                    {
                        Index = i;//Index'i döndür
                    }
                }
            }
            return Index;
        }

        //Bu sorgu biraz beynimi yakan bir sorguydu, burada yaptığımız şey:
        //  Kitap adlarını ve onlarla birlikte o kitabın kaç kez emanet edildiğini VE henüz iade edilmediğini...
        //  Listeleyen sorgu...............İşkence........
        //  Ha bide bu sorgu grafik içindi. Kırmızı satırlar. Yaşasın.
        public static DataTable EmanetToplam()
        {
            string Sorgu = "SELECT k.kitapAd, COUNT(e.kitapNo) as Toplam " +
                            "FROM Kitap as k " +
                            "LEFT JOIN Emanet as e ON k.kitapNo = e.kitapNo " +
                            "WHERE e.teslim = false " +
                            "GROUP BY k.kitapAd";
            OleDbCommand Komut = new OleDbCommand(Sorgu);
            return DataAccess.Database.SelectSorgu(Komut);
        }
    }
}