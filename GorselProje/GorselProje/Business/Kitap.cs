using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; //Bütün form işlemleri için gerekli, ancak biz MessageBox için ekledik.
using System.Data;          //DataSet vb. için...
using System.Data.OleDb;    //OleDbCommand kullanımı için ekledik

//YAPIMDA HİÇBİR BUSINESS NESNESİ, SATIR KİMLİK SÜTUNU HARİCİNDE
//VERİTABANINDAKİ SÜTUNLARA DENK GELEN ÖĞE KULLANMAK ZORUNDA DEĞİLDİR

namespace GorselProje.Business
{
    /*
    Kitap nesnesi:
        Kitaplara ait gerekli verileri tutar.
        Bütün değiştirilebilir öğeleri private'dır.
        Her private öğenin verisinin alınabilmesi için public bir öğe tanımlanmıştır, ve bu bir get fonksiyona sahiptir.
        Direkt satırı ilgilendiren metodlar hariç bütün metodlar statik tanımlandı.
    */
    class Kitap
    {
        //Nesnemizin doğru çalışabilmesi için gerekli özellikler
        private int kitapNo { get; set; } //Satır kimlik sütunu
        private string kitapAd { get; set; }
        private string yazar { get; set; }
        private string yayinevi { get; set; }
        private string turAd { get; set; }
        private int sayfaSayisi { get; set; }
        private DateTime basimTarih { get; set; }
        private int adet { get; set; }

        //Üstteki private özellikler için Get fonksiyonları, ama özellik biçiminde.
        //Aradaki fark, baş harflerinin büyük oluşu. Bütün uygulamamızda bu şekilde mevcuttur.
        public int KitapNo{ get { return kitapNo; } }
        public string KitapAd { get { return kitapAd; } }
        public string Yazar { get { return yazar; } }
        public string Yayinevi { get { return yayinevi; } }
        public string TurAd { get { return turAd; } }
        public int SayfaSayisi { get { return sayfaSayisi; } }
        public DateTime BasimTarih { get { return basimTarih; } }
        public int Adet { get { return adet; } }

        //Gerekli parametreler ve yapıcı fonksiyon ile nesne oluşturma.
        //Parametreler aşağıda KitapEkle veya diğer başvuran metodlar tarafından kontrol edilmektedir.
        public Kitap(Dictionary<string, object> Param)
        {
            try //Bütün private özelliklerin tanımlamasının bu fonksiyonda nesne oluşturulurken yapılması gerekiyor
            {   //Her bir parametrenin özelliklere atanmadan önce gerekli türlere dönüştürülmeleri gerek
                kitapNo = (int)Param["kitapNo"];
                kitapAd = Param["kitapAd"].ToString();
                yazar = Param["yazar"].ToString();
                yayinevi = Param["yayinevi"].ToString();
                turAd = Param["turAd"].ToString();
                sayfaSayisi = Convert.ToInt32(Param["sayfaSayisi"].ToString());
                basimTarih = Convert.ToDateTime(Param["basimTarih"].ToString());
                adet = Convert.ToInt32(Param["adet"].ToString());
            }
            catch (Exception e)//Yanlış veri gönderimi sadece veritabanına manuel veri eklenirse olur. Yine de kontrol şart!
            {
                MessageBox.Show("Yanlış veri gönderimi! Kitap nesnesi oluşturulamadı! Hata: " + e.ToString());
            }
        }

        public static DataTable KitapListele()              //Bütün kitapların listelenmesi için (Silinmemiş olanlar)
        {                                                   //Ayrıca burada şöyle bir ayrımımız mevcut:
                                                            //Tür no'ları kullanıcıya bir işlev sağlamaz. Tür adlarına ihtiyaç duyacakları için gerekli şekilde tür adları gönderilecek.
            string Sorgu = "Select k.kitapNo, k.kitapAd, k.yazar, k.yayinevi, t.turAd, k.sayfaSayisi, k.basimTarih, k.adet From Kitap as k, Tur as t Where k.turNo = t.turNo And silindi = false";
            OleDbCommand Komut = new OleDbCommand(Sorgu);   //Sorgumuz bütün kitap türlerini ve özelliklerini getirecek, komutu oluşturalım
            return DataAccess.Database.SelectSorgu(Komut);  //Ve çalıştırıp gelen DataTable'ı döndürelim.
        }

        //Oldu da belirli özelliklere sahip kitapları listelemek istedik
        //Mesela belirli bir numaraya veya ada sahip kitapları
        public static DataTable KitapListele(string ParamStr, bool isNo)//isNo, gelenin kitap numarası olup olmadığını belirtiyor
        {
            if (ParamStr != "") //Eğer gelen parametre boş değilse...
            {                   //Önce varsayılan bir sorgu belirliyoruz.
                string Sorgu = "Select k.kitapNo, k.kitapAd, k.yazar, k.yayinevi, t.turAd, k.sayfaSayisi, k.basimTarih, k.adet From Kitap as k, Tur as t Where k.turNo = t.turNo And silindi = false";
                if (isNo)       //Sonra bu parametrenin numara olup olmadığına bakıyoruz
                {               //Şayet numara ise...
                    Sorgu += " AND kitapNo = @kitapNo"; //Varsayılan sorgunun sonuna gerekli şartı ekliyoruz.
                    //Komutumuzu oluşturuyor, AddWithValue ile gerekli parametreleri ekliyoruz.
                    //Burada AddWithValue bize temizlenmiş veritabanı girişleri sağlıyor.
                    OleDbCommand Komut = new OleDbCommand(Sorgu);
                    Komut.Parameters.AddWithValue("@kitapNo", Convert.ToInt32(ParamStr));

                    //Son olarak, DataAccess katmanından Select sorgusu çağırıldı ve gelen veri direkt geri döndürüldü.
                    return DataAccess.Database.SelectSorgu(Komut);
                }
                else
                {   //Şayet numara değilse, gelen parametre kitap adıdır.
                    Sorgu += " AND kitapAd Like @kitapAd";          //Adlar arasında Like komutu ile bir arama yapıyoruz.
                    //Like komutu, iki metin arasındaki benzerlikleri arar.

                    OleDbCommand Komut = new OleDbCommand(Sorgu);   //Komutumuzu oluşturuyoruz

                    //Parametremize, Like komutuna uyum sağlaması için sağına ve soluna yüzde işareti koyuyoruz.
                    //Yüzde işaretleri, metinin neresine konmuşsa oradan metnin devam edebileceğini işaret eder.
                    ParamStr = "%" + ParamStr + "%";
                    Komut.Parameters.AddWithValue("@kitapAd", ParamStr); //Parametremizi temizlenmiş şekilde komutumuza giriyoruz.

                    //Son olarak, DataAccess katmanından Select sorgusu çağırıldı ve gelen veri direkt geri döndürüldü.
                    return DataAccess.Database.SelectSorgu(Komut);
                }
            }
            else    //Oldu da boş parametre geldi...
            {
                return KitapListele();  //Bütün kitapları döndür.
            }
        }

        //Kitapları silebilmek içindir.
        //Bu görev için sadece satır kimlik sütunu verisi kullanılabilir.
        public static void KitapSil(int kitapNo)
        {
            //Kitapları silmek basit bir işlem olabilir
            //Ancak kitap silinmeden önce bu kitaba ait bütün emanetler için iade işlemi yapılmalıdır.
            //Bu sebeple önce bütün emanetleri kontrol edeceğiz.
            //Ayrıca emanet verilerini kaybetmemek için kitabı sadece silinmiş olarak göstereceğiz, veritabanında kayıtlı olacak ancak gözükmeyecek.
            string Sorgu = "Select emanetNo From Emanet Where kitapNo = @kitapNo"; //Kitaba ait emanetleri getirme sorgusu
            OleDbCommand Komut = new OleDbCommand(Sorgu);                       //Komutumuzu oluşturuyoruz
            Komut.Parameters.AddWithValue("@kitapNo", kitapNo);                 //Parametrelerimizi ekliyor
            DataTable Veri = DataAccess.Database.SelectSorgu(Komut);            //Veritabanını çağırıyoruz.
            if (Veri.Rows.Count > 0)                                            //Eğer herhangi bir emanet mevcutsa...
            {                                                                   //Hatayı veriyoruz.
                MessageBox.Show("Kitaba ait bütün emanetler iade edilmeden kaydının silinmesi mümkün değildir!");
                return;
            }

            //Kitabın silinmesi için bir engel yok.
            //Ancak eğer kitabı silersek emanet verisi kaybederiz. Bu sebeple kitabın "silindi" verisini aktive ediyoruz.
            Sorgu = "Update Kitap Set silindi = true Where kitapNo = @kitapNo"; //Silindi olarak göstermek için gerekli komut
            Komut = new OleDbCommand(Sorgu);                                    //Komutumuzu oluşturuyor,
            Komut.Parameters.AddWithValue("@ogrenciNo", kitapNo);               //Parametrelerimizi ekliyor
            int SatirSayi = DataAccess.Database.UpdateSorgu(Komut);             //Veritabanını güncellemesi için çağırıyoruz.
            //Gelecekte bu kitap, listeleme işlemlerinde görülemeyecek ancak veritabanında kaydı olacak.
        }

        public static Kitap KitapAl(string ParamStr)//Kitap alma işlemi
        {
            //Kitap 'alma', tek bir kitabı veritabanından çekmeye verilen isim.
            //Sorgumuzda gerekli kitapNo'yu vererek kitabın bütün bilgilerini isteyecek, parametreleri girecek ve göndereceğiz.
            string Sorgu = "Select k.kitapNo, k.kitapAd, k.yazar, k.yayinevi, t.turAd, k.sayfaSayisi, k.basimTarih, k.adet From Kitap as k, Tur as t Where k.turNo = t.turNo AND kitapNo = @kitapNo";
            OleDbCommand Komut = new OleDbCommand(Sorgu);
            Komut.Parameters.AddWithValue("@kitapNo", Convert.ToInt32(ParamStr));
            //Geldiğinde ise Veriler adlı DataTable nesnemize yerleştireceğiz.
            DataTable Veriler = DataAccess.Database.SelectSorgu(Komut);

            //Nesne oluşturmak için gerekli Parametre
            Dictionary<string, object> Param = new Dictionary<string, object>();

            foreach (DataRow row in Veriler.Rows) //Zaten tek satır var. Hepsinin içine bak
            {//Olur da birden fazla satır gelmişse (Saçma bir şekilde, çünkü aynı kitapNo'ya sahip iki kitap olamaz.)
             //O zaman sonuncusunu yerleştir
                Param.Add("kitapNo", (int)row[0]);
                Param.Add("kitapAd", row[1].ToString());
                Param.Add("yazar", row[2].ToString());
                Param.Add("yayinevi", row[3].ToString());
                Param.Add("turAd", row[4].ToString());
                Param.Add("sayfaSayisi", Convert.ToInt32(row[5].ToString()));
                Param.Add("basimTarih", Convert.ToDateTime(row[6].ToString()));
                Param.Add("adet", Convert.ToInt32(row[7].ToString()));
                //Gerekli tiplerle elbette
            }
            return new Kitap(Param);//Nesneyi yapıcı fonksiyonla oluştur ve isteyen kısma gönder.
        }

        //Veritabanına kitap eklemek için. Eklenen kitabı ihtiyaç duyulur diye nesne olarak geri döndürür.
        public static Kitap KitapEkle(Dictionary<string, object> Param)
        {
            //Kitap ekleme işlemi önce gelen veriyi kontrol eder;
            //Bu kontrol metnin uzunluğunu, sayfa sayısı ve adet verisini kontrol eder.
            //Herhangi bir hata bulunursa return null; satırı ile boş geri dönüş sağlanır.

            //Kontrol
            if (Param["kitapAd"].ToString().Length < 3)
            {
                MessageBox.Show("Kitap adı çok kısa (En az üç). Kitap oluşturulmadı.");
                return null;
            }
            if (Param["yazar"].ToString().Length < 3)
            {
                MessageBox.Show("Yazar adı çok kısa (En az üç). Kitap oluşturulmadı.");
                return null;
            }
            if (Param["yayinevi"].ToString().Length < 3)
            {
                MessageBox.Show("Yayınevi adı çok kısa (En az üç). Kitap oluşturulmadı.");
                return null;
            }
            try
            {
                if (Convert.ToInt32(Param["sayfaSayisi"].ToString()) < 0)
                {
                    MessageBox.Show("Sayfa sayısı kısmı 0'dan küçük olamaz. Kitap oluşturulmadı.");
                    return null;
                }
                if (Convert.ToInt32(Param["adet"].ToString()) < 0)
                {
                    MessageBox.Show("Adet kısmı 0'dan küçük olamaz. Kitap oluşturulmadı.");
                    return null;
                }
            }
            catch (Exception e)//Eğer sayfaSayisi ve adet kısımları sayıya dönüştürülememişse hata ver.
            {
                MessageBox.Show("Sayı kısımları boş geçilemez veya yazı yazılamaz. Lütfen kurallara uygun giriş yapınız. Kitap oluşturulmadı.");
                return null;
            }

            //Eğer kontrol bir hata yakalamamışsa devam et.
            //Giriş
            //Sorgumuzu klasik parametre girişi ile oluşturduk.
            string Sorgu = "Insert Into Kitap (kitapAd, yazar, yayinevi, turNo, sayfaSayisi, basimTarih, adet) Values" +
                "(@kitapAd, @yazar, @yayinevi, @turNo, @sayfaSayisi, @basimTarih, @adet)";
            OleDbCommand Komut = new OleDbCommand(Sorgu);//Komutumuzu oluşturduk ve parametrelerimiz aşağıda ekledik.
            Komut.Parameters.AddWithValue("@kitapAd", Param["kitapAd"].ToString());
            Komut.Parameters.AddWithValue("@yazar", Param["yazar"].ToString());
            Komut.Parameters.AddWithValue("@yayinevi", Param["yayinevi"].ToString());
            Komut.Parameters.AddWithValue("@turNo", Param["turNo"].ToString());
            Komut.Parameters.AddWithValue("@sayfaSayisi", Param["sayfaSayisi"].ToString());
            Komut.Parameters.AddWithValue("@basimTarih", Param["basimTarih"].ToString());
            Komut.Parameters.AddWithValue("@adet", Param["adet"].ToString());

            //InsertSorgu metodumuz bize satır kimlik sütun verisini geri gönderecek, eğer ekleme başarılı ise.
            int Output = DataAccess.Database.InsertSorgu(Komut);
            Param.Add("kitapNo", Output);//Bu satır kimlik sütun verisini parametrelere ekle

            //Bu veriyle yeni bir nesne oluştur ve geri döndür.
            return new Kitap(Param);
        }

        //Güncellenen satır sayısı göndermeli kitap güncelleme fonksiyonu
        //Bu fonksiyon bütün kitap verilerini güncelleyebilmektedir.
        public static int KitapGuncelle(Dictionary<string, object> Param)
        {
            //Kitap ekleme işlemi önce gelen veriyi kontrol eder;
            //Bu kontrol metnin uzunluğunu, sayfa sayısı ve adet verisini kontrol eder.
            //Herhangi bir hata bulunursa return null; satırı ile boş geri dönüş sağlanır.

            //Kontrol
            if (Param["kitapAd"].ToString().Length < 3)
            {
                MessageBox.Show("Kitap adı çok kısa (En az üç). Kitap oluşturulmadı.");
                return -1;
            }
            if (Param["yazar"].ToString().Length < 3)
            {
                MessageBox.Show("Yazar adı çok kısa (En az üç). Kitap oluşturulmadı.");
                return -1;
            }
            if (Param["yayinevi"].ToString().Length < 3)
            {
                MessageBox.Show("Yayınevi adı çok kısa (En az üç). Kitap oluşturulmadı.");
                return -1;
            }
            try
            {
                if (Convert.ToInt32(Param["sayfaSayisi"].ToString()) < 0)
                {
                    MessageBox.Show("Sayfa sayısı kısmı 0'dan küçük olamaz. Kitap oluşturulmadı.");
                    return -1;
                }
                if (Convert.ToInt32(Param["adet"].ToString()) < 0)
                {
                    MessageBox.Show("Adet kısmı 0'dan küçük olamaz. Kitap oluşturulmadı.");
                    return -1;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Sayı kısımları boş geçilemez veya yazı yazılamaz. Lütfen kurallara uygun giriş yapınız. Kitap oluşturulmadı.");
                return -1;
            }

            //Eğer kontrol bir hata yakalamamışsa devam et.
            //Giriş
            //Sorgumuzu klasik parametre girişi ile oluşturduk.
            string Sorgu = "Update Kitap Set " +
                "kitapAd = @kitapAd, " +
                "yazar = @yazar, " +
                "yayinevi = @yayinevi, " +
                "turNo = @turNo, " +
                "sayfaSayisi = @sayfaSayisi, " +
                "basimTarih = @basimTarih, " +
                "adet = @adet " +
                "Where kitapNo = @kitapNo";
            OleDbCommand Komut = new OleDbCommand(Sorgu); //Komutumuzu oluşturduk ve parametrelerimiz aşağıda ekledik.
            Komut.Parameters.AddWithValue("@kitapAd", Param["kitapAd"].ToString());
            Komut.Parameters.AddWithValue("@yazar", Param["yazar"].ToString());
            Komut.Parameters.AddWithValue("@yayinevi", Param["yayinevi"].ToString());
            Komut.Parameters.AddWithValue("@turNo", Param["turNo"].ToString());
            Komut.Parameters.AddWithValue("@sayfaSayisi", Param["sayfaSayisi"].ToString());
            Komut.Parameters.AddWithValue("@basimTarih", Param["basimTarih"].ToString());
            Komut.Parameters.AddWithValue("@adet", Param["adet"].ToString());
            Komut.Parameters.AddWithValue("@kitapNo", Param["kitapNo"].ToString());

            //UpdateSorgu bize güncellenmiş satır sayısını gönderir. Onu geri döndürdük.
            int SatirSayi = DataAccess.Database.UpdateSorgu(Komut);
            return SatirSayi;
        }

        //Kitap türlerinin listelenebilmesi için gerekli fonksiyon
        public static DataTable TurListe()
        {
            //Sorguyu oluştur, komutu çalıştır ve gelen veriyi geri döndür
            string Sorgu = "Select * From Tur";
            OleDbCommand Komut = new OleDbCommand(Sorgu);
            return DataAccess.Database.SelectSorgu(Komut);
        }

        //Kitap adetleri lazım olduğunda listelenebilmesi için
        public static DataTable AdetListele()
        {
            //Sorguyu oluştur, komutu çalıştır ve gelen veriyi geri döndür
            string Sorgu = "Select kitapAd, adet From Kitap";
            OleDbCommand Komut = new OleDbCommand(Sorgu);
            return DataAccess.Database.SelectSorgu(Komut);
        }
    }
}
