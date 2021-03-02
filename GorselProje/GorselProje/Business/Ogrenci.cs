using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; //Bütün form işlemleri için gerekli olan bir kütüphanenin burada pek işi yok, ancak biz MessageBox için ekledik.
using System.Data.OleDb;    //OleDbCommand kullanımı için ekledik

//YAPIMDA HİÇBİR BUSINESS NESNESİ, SATIR KİMLİK SÜTUNU HARİCİNDE
//VERİTABANINDAKİ SÜTUNLARA DENK GELEN ÖĞE KULLANMAK ZORUNDA DEĞİLDİR

namespace GorselProje.Business
{
    /*
    Öğrenci nesnesi:
        Öğrencilere ait gerekli verileri tutar.
        Bütün değiştirilebilir öğeleri private'dır.
        Her private öğenin verisinin alınabilmesi için public bir öğe tanımlanmıştır, ve bu bir get fonksiyona sahiptir.
        Direkt satırı ilgilendiren metodlar hariç bütün metodlar statik tanımlandı.
    */
    class Ogrenci
    {
        //Nesnemizin doğru çalışabilmesi için gerekli özellikler
        private int ogrenciNo { get; set; }     //Satır kimlik sütunu
        private string ad { get; set; }
        private string soyad { get; set; }
        private int borc { get; set; }
        private int gecIade { get; set; }
        
        //Üstteki private özellikler için Get fonksiyonları, ama özellik biçiminde.
        //Aradaki fark, baş harflerinin büyük oluşu. Bütün uygulamamızda bu şekilde mevcuttur.
        public int OgrenciNo
        {
            get { return ogrenciNo; }
        }
        public string Ad
        {
            get { return ad; }
        }
        public string Soyad
        {
            get { return soyad; }
        }
        public int Borc
        {
            get { return borc; }
        }
        public int GecIade
        {
            get { return gecIade; }
        }

        //Gerekli parametreler ve yapıcı fonksiyon ile nesne oluşturma.
        //Parametreler aşağıda OgrenciEkle veya diğer başvuran metodlar tarafından kontrol edilmektedir.
        public Ogrenci(Dictionary<string, object> Param)
        {
            try //Bütün private özelliklerin tanımlamasının bu fonksiyonda nesne oluşturulurken yapılması gerekiyor
            {
                //Her bir parametrenin özelliklere atanmadan önce gerekli türlere dönüştürülmeleri gerek
                ogrenciNo = (int)Param["ogrenciNo"];
                ad = (string)Param["ad"];
                soyad = (string)Param["soyad"];
                borc = Convert.ToInt32(Param["borc"].ToString());
                gecIade = Convert.ToInt32(Param["gecIade"].ToString());
            }
            catch (Exception e) //Yanlış veri gönderimi sadece veritabanına manuel veri eklenirse olur. Yine de kontrol şart!
            {
                MessageBox.Show("Yanlış veri gönderimi! Ogrenci nesnesi oluşturulamadı! Hata: " + e.ToString());
            }
        }

        public static DataTable OgrenciListele()            //Bütün öğrencilerin listelenmesi için.
        {
            string Sorgu = "Select * From Ogrenci Where silindi = false";//Sorgu, ORM şartları için Business'te üretildi
            //Ayrıca hiçbir öğrenci silinmez, sadece veritabanında gözükmez. O yüzden silindi = false olanları aratıyoruz.
            OleDbCommand Komut = new OleDbCommand(Sorgu);   //Sorgudan komut üretildi, OleDbCommand nesnesiyle
            return DataAccess.Database.SelectSorgu(Komut);  //DataAccess katmanından Select sorgusu çağırıldı ve gelen veri direkt geri döndürüldü.
        }

        //Oldu da belirli özelliklere sahip öğrencileri listelemek istedik
        //Mesela belirli bir numaraya veya ada soyada sahip öğrencileri
        public static DataTable OgrenciListele(string ParamStr, bool isNo) //isNo, gelenin öğrenci numarası olup olmadığını belirtiyor
        {
            if (ParamStr != "") //Eğer gelen parametre boş değilse...
            {
                string Sorgu = "Select * From Ogrenci Where silindi = false"; //Önce varsayılan bir sorgu belirliyoruz.
                if (isNo)                               //Sonra bu parametrenin numara olup olmadığına bakıyoruz
                {
                    //Şayet numara ise...
                    Sorgu += " And ogrenciNo = @ogrenciNo";       //Varsayılan sorgunun sonuna gerekli şartı ekliyoruz.

                    //Komutumuzu oluşturuyor, AddWithValue ile gerekli parametreleri ekliyoruz.
                    //Burada AddWithValue bize temizlenmiş veritabanı girişleri sağlıyor.
                    OleDbCommand Komut = new OleDbCommand(Sorgu);   
                    Komut.Parameters.AddWithValue("@ogrenciNo", Convert.ToInt32(ParamStr));

                    //Son olarak, DataAccess katmanından Select sorgusu çağırıldı ve gelen veri direkt geri döndürüldü.
                    return DataAccess.Database.SelectSorgu(Komut);
                }
                else
                {
                    //Şayet numara değilse, gelen parametre ad veya soyaddır.
                    Sorgu += " And (ad & ' ' & soyad) Like @parametre";     //Ad ve soyadlar arasında Like komutu ile bir arama yapıyoruz.
                    //Like komutu, iki metin arasındaki benzerlikleri arar.

                    OleDbCommand Komut = new OleDbCommand(Sorgu);           //Komutumuzu oluşturuyoruz

                    //Parametremize, Like komutuna uyum sağlaması için sağına ve soluna yüzde işareti koyuyoruz.
                    //Yüzde işaretleri, metinin neresine konmuşsa oradan metnin devam edebileceğini işaret eder.
                    ParamStr = "%" + ParamStr + "%";                        
                    Komut.Parameters.AddWithValue("@parametre", ParamStr); //Parametremizi temizlenmiş şekilde komutumuza giriyoruz.

                    //Son olarak, DataAccess katmanından Select sorgusu çağırıldı ve gelen veri direkt geri döndürüldü.
                    return DataAccess.Database.SelectSorgu(Komut);
                }
            }
            else    //Oldu da boş parametre geldi...
            {
                return OgrenciListele(); //Bütün öğrencileri döndür.
            }
        }

        //Öğrencileri silebilmek içindir.
        //Bu görev için sadece satır kimlik sütunu verisi kullanılabilir.
        public static void OgrenciSil(int ogrNo)
        {
            //Öğrenciyi silmek basit bir işlem olabilir
            //Ancak öğrenci silinmeden önce bütün borcunu ödemeli ve bütün kitaplarını iade etmelidir.
            //Bu sebeple önce bütün emanetleri kontrol edecek, sonra borcu kontrol edeceğiz.
            //Ayrıca emanet verilerini kaybetmemek için öğrenciyi sadece silinmiş olarak göstereceğiz, veritabanında kayıtlı olacak ancak gözükmeyecek.
            string Sorgu = "Select emanetNo From Emanet Where ogrenciNo = @ogrenciNo"; //Öğrenciye ait emanetleri getirme sorgusu
            OleDbCommand Komut = new OleDbCommand(Sorgu);                       //Komutumuzu oluşturuyoruz
            Komut.Parameters.AddWithValue("@ogrenciNo", ogrNo);                 //Parametrelerimizi ekliyor
            DataTable Veri = DataAccess.Database.SelectSorgu(Komut);            //Veritabanını çağırıyoruz.
            if (Veri.Rows.Count > 0)                                            //Eğer herhangi bir emanet mevcutsa...
            {                                                                   //Hatayı veriyoruz.
                MessageBox.Show("Öğrencinin bütün emanetleri ödenmeden kaydının silinmesi mümkün değildir!");
                return;
            }

            Ogrenci Silinecek = OgrenciAl(ogrNo.ToString());                    //Silinecek öğrenci verisini oluşturalım
            if (Silinecek.Borc > 0)                                             //Eğer borç mevcutsa
            {                                                                   //Hatayı veriyoruz.
                MessageBox.Show("Öğrencinin borcu ödenmeden kaydının silinmesi mümkün değildir!");
                return;
            }

            //Öğrencinin silinmesi için bir engel yok.
            //Ancak eğer öğrenci silersek emanet verisi kaybederiz. Bu sebeple öğrencinin "silindi" verisini aktive ediyoruz.
            Sorgu = "Update Ogrenci Set silindi = true Where ogrenciNo = @ogrenciNo";//Silindi olarak göstermek için gerekli komut
            Komut = new OleDbCommand(Sorgu);                                    //Komutumuzu oluşturuyor,
            Komut.Parameters.AddWithValue("@ogrenciNo", ogrNo);                 //Parametrelerimizi ekliyor
            int SatirSayi = DataAccess.Database.UpdateSorgu(Komut);             //Veritabanını güncellemesi için çağırıyoruz.
            //Gelecekte bu öğrenci, listeleme işlemlerinde görülemeyecek ancak veritabanında kaydı olacak.
        }

        public static Ogrenci OgrenciAl(string ParamStr) //Öğrenci alma işlemi
        {
            //Öğrenci 'alma', tek bir öğrenciyi veritabanından çekmeye verilen isim.
            //Sorgumuzda gerekli ogrenciNo'yu vererek öğrencinin bütün bilgilerini isteyecek, parametreleri girecek ve göndereceğiz.
            string Sorgu = "Select * From Ogrenci Where ogrenciNo = @ogrenciNo";
            OleDbCommand Komut = new OleDbCommand(Sorgu);
            Komut.Parameters.AddWithValue("@ogrenciNo", Convert.ToInt32(ParamStr));
            //Geldiğinde ise Veriler adlı DataTable nesnemize yerleştireceğiz.
            DataTable Veriler = DataAccess.Database.SelectSorgu(Komut);

            //Nesne oluşturmak için gerekli Parametre
            Dictionary<string, object> Param = new Dictionary<string, object>();

            foreach (DataRow row in Veriler.Rows) //Zaten tek satır var. Hepsinin içine bak
            {//Olur da birden fazla satır gelmişse (Saçma bir şekilde, çünkü aynı ogrenciNo'ya sahip iki öğrenci olamaz.)
             //O zaman sonuncusunu yerleştir
                Param.Add("ogrenciNo", (int)row[0]);
                Param.Add("ad", row[1].ToString());
                Param.Add("soyad", row[2].ToString());
                Param.Add("borc", Convert.ToInt32(row[3].ToString()));
                Param.Add("gecIade", Convert.ToInt32(row[4].ToString()));
             //Gerekli tiplerle elbette
            }
            return new Ogrenci(Param); //Nesneyi yapıcı fonksiyonla oluştur ve isteyen kısma gönder.
        }

        //Veritabanına öğrenci eklemek için. Eklenen öğrenciyi ihtiyaç duyulur diye nesne olarak geri döndürür.
        public static Ogrenci OgrenciEkle(Dictionary<string, object> Param)
        {
            //Öğrenci ekleme işlemi önce gelen veriyi kontrol eder;
            //Bu kontrol metnin uzunluğunu, borç ve geç iade verisini kontrol eder.
            //Herhangi bir hata bulunursa return null; satırı ile boş geri dönüş sağlanır.

            //Kontrol
            if (Param["ad"].ToString().Length < 3)
            {
                MessageBox.Show("Ad çok kısa (En az üç). Öğrenci oluşturulmadı.");
                return null;
            }
            if (Param["soyad"].ToString().Length < 3)
            {
                MessageBox.Show("Soyad çok kısa (En az üç). Öğrenci oluşturulmadı.");
                return null;
            }
            try
            {
                if (Convert.ToInt32(Param["borc"].ToString()) < 0)
                {
                    MessageBox.Show("Borç kısmı 0'dan küçük olamaz. Öğrenci oluşturulmadı.");
                    return null;
                }
                if (Convert.ToInt32(Param["gecIade"].ToString()) < 0)
                {
                    MessageBox.Show("Geç İade edilenler kısmı 0'dan küçük olamaz. Öğrenci oluşturulmadı.");
                    return null;
                }
            }
            catch (Exception e) //Eğer borc ve gecIade kısımları sayıya dönüştürülememişse hata ver.
            {
                MessageBox.Show("Sayı kısımları boş geçilemez veya yazı yazılamaz. Lütfen en azından sıfır (0) giriniz. Öğrenci oluşturulmadı.");
                return null;
            }

            //Eğer kontrol bir hata yakalamamışsa devam et.
            //Giriş
            //Sorgumuzu klasik parametre girişi ile oluşturduk.
            string Sorgu = "Insert Into Ogrenci (ad, soyad, borc, gecIade) Values" +
                "(@ad, @soyad, @borc, @gecIade)";
            OleDbCommand Komut = new OleDbCommand(Sorgu);   //Komutumuzu oluşturduk ve parametrelerimiz aşağıda ekledik.
            Komut.Parameters.AddWithValue("@ad", Param["ad"].ToString());
            Komut.Parameters.AddWithValue("@soyad", Param["soyad"].ToString());
            Komut.Parameters.AddWithValue("@borc", Convert.ToInt32(Param["borc"].ToString()));
            Komut.Parameters.AddWithValue("@gecIade", Convert.ToInt32(Param["gecIade"].ToString()));

            //InsertSorgu metodumuz bize satır kimlik sütun verisini geri gönderecek, eğer ekleme başarılı ise.
            int Output = DataAccess.Database.InsertSorgu(Komut);
            Param.Add("ogrenciNo", Output); //Bu satır kimlik sütun verisini parametrelere ekle

            //Bu veriyle yeni bir nesne oluştur ve geri döndür.
            return new Ogrenci(Param);
        }

        //Güncellenen satır sayısı göndermeli öğrenci güncelleme fonksiyonu
        //Bu güncelleme sadece ad ve soyadı günceller. Borç ödeme ve iade işlemleri için ayrı fonksiyonlar bulunur.
        public static int OgrenciGuncelle(Dictionary<string, object> Param)
        {
            //Öğrenci güncelleme işlemi önce gelen veriyi kontrol eder;
            //Bu kontrol metnin uzunluğunu, borç ve geç iade verisini kontrol eder.
            //Herhangi bir hata bulunursa return -1; satırı ile blok veri geri dönüşü sağlanır.

            //Kontrol
            if (Param["ad"].ToString().Length < 3)
            {
                MessageBox.Show("Ad çok kısa (En az üç). Öğrenci oluşturulmadı.");
                return -1;
            }
            if (Param["soyad"].ToString().Length < 3)
            {
                MessageBox.Show("Soyad çok kısa (En az üç). Öğrenci oluşturulmadı.");
                return -1;
            }
            try
            {
                if (Convert.ToInt32(Param["borc"].ToString()) < 0)
                {
                    MessageBox.Show("Borç kısmı 0'dan küçük olamaz. Öğrenci oluşturulmadı.");
                    return -1;
                }
                if (Convert.ToInt32(Param["gecIade"].ToString()) < 0)
                {
                    MessageBox.Show("Geç İade edilenler kısmı 0'dan küçük olamaz. Öğrenci oluşturulmadı.");
                    return -1;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Sayı kısımları boş geçilemez veya yazı yazılamaz. Lütfen en azından sıfır (0) giriniz. Öğrenci oluşturulmadı.");
                return -1;
            }

            //Eğer kontrol bir hata yakalamamışsa devam et.
            //Giriş
            //Sorgumuzu klasik parametre girişi ile oluşturduk.
            string Sorgu = "Update Ogrenci Set " +
                "ad = @ad, " +
                "soyad = @soyad " +
                "Where ogrenciNo = @ogrenciNo";
            OleDbCommand Komut = new OleDbCommand(Sorgu); //Komutumuzu oluşturduk ve parametrelerimiz aşağıda ekledik.
            Komut.Parameters.AddWithValue("@ad", Param["ad"].ToString());
            Komut.Parameters.AddWithValue("@soyad", Param["soyad"].ToString());
            Komut.Parameters.AddWithValue("@ogrenciNo", Convert.ToInt32(Param["ogrenciNo"].ToString()));

            //UpdateSorgu bize güncellenmiş satır sayısını gönderir. Onu geri döndürdük.
            int SatirSayi = DataAccess.Database.UpdateSorgu(Komut);
            return SatirSayi;
        }

        //Borç ödeme işlemi için özel fonksiyon, direkt güncellemeye sıkıntı çıkarmasın diye.
        //Bu, normal bir metod. Statiklerin aksine çalışması için Ogrenci nesnesini gerektirir.
        public bool BorcOde(int OdeMiktar)
        {
            //Önce ödenecek miktarın doğru aralıkta olup olmadığına bakıyoruz.
            if (OdeMiktar > 0 && OdeMiktar <= Borc)
            {
                borc = (Borc - OdeMiktar);                              //Borcu nesnemizde güncelliyoruz.
                string Sorgu = "Update Ogrenci Set borc = @borc Where ogrenciNo = @ogrenciNo";
                OleDbCommand Komut = new OleDbCommand(Sorgu);           //Sorgu, komut, parametre işlemi
                Komut.Parameters.AddWithValue("@borc", Convert.ToInt32(Borc.ToString()));
                Komut.Parameters.AddWithValue("@ogrenciNo", Convert.ToInt32(OgrenciNo.ToString()));

                //Güncelleyelim.
                int SatirSayi = DataAccess.Database.UpdateSorgu(Komut);
                //Eğer bir satır güncellenmişse doğru çalışıyor. Değilse... Geçmiş olsun.
                if (SatirSayi == 1)
                {
                    return true;
                }
                else if (SatirSayi == 0)
                {
                    MessageBox.Show("Kritik bir hata oluştu! Hiçbir satır değiştirilemedi!");
                }
                else
                {
                    MessageBox.Show("Program olarak nasıl becerdiğimiz ile ilgili hiçbir fikrim olmasa da az önce birden fazla satır değiştirdik. Keşbiş olsun. KENDİME NOT: Bu yazıyı görüyorsan çok iyi bir yazılımcı olamayacağının altını çizmek isterim Halil.");
                }
                return false;
            }
            else
            {
                return false;
            }
        }

        //İade telafi işlemi için özel fonksiyon, direkt güncellemeye sıkıntı çıkarmasın diye.
        //Bu, normal bir metod. Statiklerin aksine çalışması için Ogrenci nesnesini gerektirir.
        public bool TelafiEt(int TelafiMiktar)
        {
            //Önce telafi edilecek miktarın doğru aralıkta olup olmadığına bakıyoruz.
            if (TelafiMiktar > 0 && TelafiMiktar <= gecIade)
            {
                gecIade = (GecIade - TelafiMiktar);                 //gecIade'yi nesnemizde güncelliyoruz.
                string Sorgu = "Update Ogrenci Set gecIade = @gecIade Where ogrenciNo = @ogrenciNo";
                OleDbCommand Komut = new OleDbCommand(Sorgu);       //Sorgu, komut, parametre işlemi
                Komut.Parameters.AddWithValue("@gecIade", Convert.ToInt32(GecIade.ToString()));
                Komut.Parameters.AddWithValue("@ogrenciNo", Convert.ToInt32(OgrenciNo.ToString()));

                //Güncelleyelim...
                int SatirSayi = DataAccess.Database.UpdateSorgu(Komut);
                //Eğer bir satır güncellenmişse doğru çalışıyor. Değilse... Geçmiş olsun.
                if (SatirSayi == 1)
                {
                    return true;
                }
                else if (SatirSayi == 0)
                {
                    MessageBox.Show("Kritik bir hata oluştu! Hiçbir satır değiştirilemedi!");
                }
                else
                {
                    MessageBox.Show("Program olarak nasıl becerdiğimiz ile ilgili hiçbir fikrim olmasa da az önce birden fazla satır değiştirdik. Keşbiş olsun. KENDİME NOT: Bu yazıyı görüyorsan çok iyi bir yazılımcı olamayacağının altını çizmek isterim Halil.");
                }
                return false; //Hatalı durumlarda...
            }
            else
            {
                return false;
            }
        }
    }
}
