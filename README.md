Görsel Programlama Proje Ödevi

Ad: Halil Alper

Soyad: YALÇIN

No: 172120008

Öğretim Türü: İkinci Öğretim

Konu: Kütüphane Otomasyon

Ders: BMT303 – Görsel Programlama

Eğitmen: Dr. Öğr. Üyesi Serdar BİROĞUL

[*Açıklama* 4](#açıklama)

[*İhtiyaçlar* 4](#ihtiyaçlar)

[*Aşamalar:* 5](#aşamalar)

[*Proje Planlama* 5](#proje-planlama)

[*Proje Tasarımı* 6](#proje-tasarımı)

[*Veritabanı* 6](#veritabanı)

[*Dizin Tasarımı ve Katmanlı Mimari*
7](#dizin-tasarımı-ve-katmanlı-mimari)

[*Nesne Tasarımı* 8](#nesne-tasarımı)

[*Görsel Tasarım* 11](#görsel-tasarım)

[*Gerçekleme / Geliştirme* 12](#gerçekleme-geliştirme)

[*Veritabanı* 12](#veritabanı-1)

[*Proje Dosyası Oluşturma ve Düzenleme*
14](#proje-dosyası-oluşturma-ve-düzenleme)

[*Form Tasarımları* 16](#form-tasarımları)

[*Kodlamaya Geçiş* 22](#kodlamaya-geçiş)

[*Data Access* 22](#data-access)

[*Database.cs* 23](#database.cs)

[*Business* 25](#business)

[*Ogrenci.cs* 26](#ogrenci.cs)

[*Kitap.cs* 35](#kitap.cs)

[*Emanet.cs* 43](#emanet.cs)

[*Extra* 55](#extra)

[*VerticalLabel.cs* 55](#verticallabel.cs)

[*Presentation* 56](#presentation)

[*AnaSayfa.cs* 57](#anasayfa.cs)

[*OgrenciListe.cs* 58](#ogrenciliste.cs)

[*Bilinmeyenler* 58](#bilinmeyenler)

[*Olaylar harici fonksiyonlar* 58](#olaylar-harici-fonksiyonlar)

[*Olay bağlı fonksiyonlar* 59](#olay-bağlı-fonksiyonlar)

[*OgrenciPencere.cs* 65](#ogrencipencere.cs)

[*Bilinmeyenler* 65](#bilinmeyenler-1)

[*Yapıcı fonksiyonlar* 66](#yapıcı-fonksiyonlar)

[*Olay bağlı fonksiyonlar* 67](#olay-bağlı-fonksiyonlar-1)

[*KitapListe.cs* 70](#kitapliste.cs)

[*Bilinmeyenler* 70](#bilinmeyenler-2)

[*Olaylar harici fonksiyonlar* 70](#olaylar-harici-fonksiyonlar-1)

[*Olay bağlı fonksiyonlar* 71](#olay-bağlı-fonksiyonlar-2)

[*KitapPencere.cs* 77](#kitappencere.cs)

[*Bilinmeyenler* 77](#bilinmeyenler-3)

[*Yapıcı Fonksiyonlar* 77](#yapıcı-fonksiyonlar-1)

[*Olay Bağlı Fonksiyonlar* 78](#olay-bağlı-fonksiyonlar-3)

[*EmanetListe.cs* 80](#emanetliste.cs)

[*Bilinmeyenler ve Açıklama* 80](#bilinmeyenler-ve-açıklama)

[*Yapıcı Fonksiyonlar* 80](#yapıcı-fonksiyonlar-2)

[*Olay Harici Fonksiyonlar* 81](#olay-harici-fonksiyonlar)

[*Olay Bağlı Fonksiyonlar* 82](#olay-bağlı-fonksiyonlar-4)

[*EmanetPencere.cs* 89](#emanetpencere.cs)

[*Bilinmeyenler* 89](#bilinmeyenler-4)

[*Yapıcı Fonksiyonlar* 89](#yapıcı-fonksiyonlar-3)

[*Olay Bağlı Fonksiyonlar* 90](#olay-bağlı-fonksiyonlar-5)

[*inputBox.cs* 92](#inputbox.cs)

[*Bilinmeyenler ve Açıklama* 92](#bilinmeyenler-ve-açıklama-1)

[*Yapıcı Fonksiyon* 92](#yapıcı-fonksiyon)

[*Olay Bağlı Fonksiyonlar* 92](#olay-bağlı-fonksiyonlar-6)

[*Grafik.cs* 93](#grafik.cs)

[*Ek Kütüphaneler* 93](#ek-kütüphaneler)

[*Bilinmeyenler* 93](#bilinmeyenler-5)

[*Olay Harici Fonksiyonlar* 93](#olay-harici-fonksiyonlar-1)

[*Olay Bağlı Fonksiyonlar* 95](#olay-bağlı-fonksiyonlar-7)

[*SONUÇ* 97](#sonuç)

Açıklama
========

Merhaba. Bu proje dosyası size, Dr. Öğr. Üyesi Serdar Biroğul tarafından
BMT303 – Görsel Programlama dersi için verilen proje ödevi için, kendi
tasarladığım ve yazdığım Kütüphane Otomasyonunu sunacak. Projem
planlama, tasarım ve gerçekleme adlı üç farklı aşamadan geçerek
çalışmaya hazır hale gelecek. Dosyadaki her bir sayfa, programı
gerçeklemede yapılması gerekenleri size adım adım anlatacak.

Bu proje dosyamı okuyan, hem hatalarımı görmemi sağlayan hem de benim
anlatımımla bu projeyi gerçekleyecek herkese şimdiden teşekkür ederim.

İhtiyaçlar
==========

Projeyi gerçekleyebilmek için birkaç uygulama ve dosyaya ihtiyaç
duyacaksınız. Bunları projeye başlamadan önce indirip bildiğiniz bir
dizinde aynı klasör içinde tutmanız proje anında sizin performansınızı
kaybetmeden ilerlemenizi sağlayacaktır. Bu dosyanın sunduğu proje için
gereklilikler şunlardır:

-   Visual Studio (2019 öneriyorum);

    -   Community Edition’ı herkes için ücretsiz olan çok güçlü
        bir IDE’dir.

    -   Installer’ından istediğiniz iş yüklerini kurabilirsiniz ancak
        bize bu proje için gereken **Evrensel Windows Platformu
        geliştirme** olacaktır.

-   ZedGraph (En güncel versiyon);

    -   Projemizde gerekli olacak grafikleri yapmaya yarayan kütüphane.

    -   [*https://sourceforge.net/projects/zedgraph/files*](https://sourceforge.net/projects/zedgraph/files)

-   Access (2007 veya üstü)

    -   Farklı yollardan yasal olarak ücretsiz edinebileceğiniz
        versiyonları bulunmaktadır. Özellikle eğer bir öğrenciyseniz
        okulunuzun sağladığı imkanlara bakmanızı öneririm. Bir firmaya
        bağlı çalışıyorsanız firmanızın size bu programı sağlayıp
        sağlamadığını öğrenebilirsiniz.

-   Kendi projenizde kullanmak isteyebileceğiniz tasarım dosya ve
    programları, görselleri

Aşamalar:
=========

Proje Planlama
--------------

> Proje planlama aşamamız normal projelerden farklı olarak zaten hazırda
> bulunan bir ödev üzerindeki görevler yardımıyla oluşturulacak. Bu
> görevler projenin ve programın temel unsurlarını oluşturmakta. Bunlar
> madde olarak sayacak olursak:

1.  Programın katmanlı mimari yapıda yapılması

2.  Öğrenci ve Kitap için kayıt ekleme, güncelleme ve silme olması

3.  Öğrenciye verilen kitap emanetlerinin sıralanması, eklenmesi,
    düzenlenmesi ve bu kapsamda:

    a.  Bu listeye ayrı ayrı hem öğrencilerden hem kitaplardan
        ulaşılabilmesi

    b.  Her öğrencinin listesine kolaylıkla ulaşabilme

    c.  Emanetin teslim tarihine göre teslime kalan sürenin listede
        renkli bir şekilde gösterilmesi

    d.  Bunların tarihsel düzeyde gerçekleşmesi

4.  Her bir kitap için ayrı bilgiye ulaşabilmek ve bu kapsamda:

    a.  Kitapların emanet alınan ve verilen tarihleri ve alan kişilerin
        gözükmesi

    b.  Kitap geciktirmenin cezasının öğrencilere her geçen günün borç
        olarak yansıtılması

5.  Bütün kitap ve emanet sayılarının bir grafik olarak gösterilebilmesi
    ve bu kapsamda:

    a.  **ZedGraph** kütüphanesinin eklenilmesi ve kullanılması

6.  Uygulamanın diğer bilgisayarlarda kurulabilmesi ve kolaylıkla
    kullanılabilmesi

7.  Uygulamadaki verilerin tutulabilmesi için bir **Access**
    veritabanının oluşturulması

> Sağlanmalıdır.
>
> Bunlara ayriyeten veritabanının **Access** üzerinden sağlanması ve
> ayrı bir kurulum istememesi gerekmektedir.

Proje Tasarımı
--------------

> Bu kısımda projenin her bir dalının tasarımı belirlenecektir. Bu
> tasarım görsellikten ziyade yapım aşaması olacaktır.

### Veritabanı

> Doğru bir veritabanı tasarımı bir projenin vazgeçilmezidir. Bu
> kapsamda bize proje tasarım işinde düşen, programımızın her ihtiyacını
> karşılayan ancak bu ihtiyacın dışında fuzuli işlemlere kaçmayan bir
> veritabanı tasarlamaktır.
>
> Veritabanımız üç ana ve bir yardımcı tablo içerecektir. Bunlar
> sırasıyla:

-   Öğrenci (Ogrenci): Kitap emaneti almak için kayıt olan
    bütün öğrenciler.

-   Kitap (Kitap): Kütüphanede bulunan bütün kitaplar.

-   Emanet (Emanet): Bütün öğrenci-kitap emanet işlemleri.

-   Tür (Tur): Kitap türleri.

> Tablolarıdır. Bu tabloların tasarımı ise, **Access** veritabanı
> tasarım şemasına göre oluşturulduğunda şu şekildedir:

1.  Ogrenci

    a.  ogrenciNo: Otomatik Tamsayı

    b.  ad: Kısa Metin

    c.  soyad: Kısa Metin

    d.  borc: Tamsayı

    e.  gecIade: Tamsayı

    f.  silindi: Evet/Hayır

2.  Kitap

    a.  kitapNo: Otomatik Tamsayı

    b.  kitapAd: Kısa Metin

    c.  yazar: Kısa Metin

    d.  yayinevi: Kısa Metin

    e.  turNo: Tamsayı

    f.  sayfaSayisi: Tamsayı

    g.  basimTarih: Tarih/Saat

    h.  adet: Tamsayı

    i.  silindi: Evet/Hayır

3.  Emanet

    a.  emanetNo: Otomatik Tamsayı

    b.  ogrenciNo: Tamsayı

    c.  kitapNo: Tamsayı

    d.  emanetTarih: Tarih/Saat

    e.  iadeTarih: Tarih/Saat

    f.  teslim: Evet/Hayır

4.  Tur

    a.  turno: Otomatik Tamsayı

    b.  turAd: Kısa Metin

> Veritabanımız **Access** üzerinden tasarlanıp müsait bir dosyaya
> kaydedilmelidir. Dizini çok yakında değiştirilecektir. Proje dosyası
> farklı olacağı için orada daha uygun çalışması için oraya
> taşınacaktır.
>
> Hiçbir veri, kayıp olmaması için silinmeyecektir. “Silinen” veriler
> silindi olarak işaretlenip veritabanında tutulacak ve kullanıcıya
> emanet kayıtları hariç gösterilmeyecektir.

### Dizin Tasarımı ve Katmanlı Mimari

> Projenin her bir kısmının planlı programlı ve düzgün bir şekilde
> ilerleyebilmesi için her kısmının katmanlı mimari ile tasarlanması ve
> bu yönde programlanması gerekmektedir. Bu noktada benim yaptığım
> tasarım, her katmanın ayrı bir klasör olarak var olmasıdır. Dizin
> tasarımımı şu şekilde yaptım:
> ![](media/image1.png){width="2.2721861329833772in" height="2.125in"}
>
> Burada üç ana ve bir yan katmanımız bulunmaktadır. Bu katmanlar:

-   DataAccess: Bütün sorgu girdi çıktılarının geçeceği veritabanı
    erişiminin sağlandığı yer

-   Business: Bütün gerekli nesnelerin var olduğu, gerekli veri girişi
    ve çıkışı kontrollerinin sağlandığı ve aynı zamanda ORM kısmının
    gerçekleştiği katmandır.

-   Presentation: Projenin çoğunlukla görsel kısmıdır. Genelde sadece
    gelen veriyi Business’a göndermek veya veritabanındaki veriyi
    göstermekle görevlidir.

-   Extra: Ekstra nesnelerimiz ve görevlerimiz için bulunmaktadır.

### Nesne Tasarımı

> Katmanlı mimarimiz, dizinlerimiz ve veritabanımız hazır olduğuna göre
> bunlara göre nesnelerimizi oluşturabilmemiz gerekmektedir. Bize üç ana
> nesne gerekir ve bunlar tahmin edebileceğiniz üzere veritabanındaki üç
> ana tablonun nesneleridir.

-   Ogrenci nesnesi:

    -   Bu nesne öğrencilerin ogrenciNo, ad, soyad, borc ve gecIade
        özelliklerini tutmalıdır.

    -   Tutulan özellikler private olmalı, sadece metod
        izniyle değiştirilebilmelidir.

    -   Özellik okumada sorun olmayacağı için her bir private özellik
        için get fonksiyonu bulunan bir public özellik tanımlanmalıdır.

    -   Bu nesne Ogrenci ile ilgili tüm statik veya statik olmayan
        metodları tutmak ve çalıştırmakla yükümlüdür. Bu, şu şekilde
        gerçekleşir:

        -   Eğer bir metod bütün tabloya veya bir kısmına erişim
            gerektiriyorsa bu metod statiktir.

        -   Eğer bir metod sadece ve sadece özel bir satıra etki
            edecekse bu metod normal olabilir, ancak olmak
            zorunda değildir. Programın bütünlüğü asıl hedeftir.

    -   Bu nesne Ogrenci tablosuna gelen bütün veri girişlerini kontrol
        eder, sorgularını yazar, komutlarını ORM şartı ile hazırlar ve
        veri trafiğini kontrol eder.

-   Kitap nesnesi:

    -   Bu nesne kitapların kitapNo, kitapAd, yazar, yayinevi, turAd,
        sayfaSayisi, basimTarih ve adet özelliklerini tutmalıdır.

    -   Tutulan özellikler private olmalı, sadece metod
        izniyle değiştirilebilmelidir.

    -   Özellik okumada sorun olmayacağı için her bir private özellik
        için get fonksiyonu bulunan bir public özellik tanımlanmalıdır.

    -   Bu nesne Kitap ile ilgili tüm statik veya statik olmayan
        metodları tutmak ve çalıştırmakla yükümlüdür. Bu, şu şekilde
        gerçekleşir:

        -   Eğer bir metod bütün tabloya veya bir kısmına erişim
            gerektiriyorsa bu metod statiktir.

        -   Eğer bir metod sadece ve sadece özel bir satıra etki
            edecekse bu metod normal olabilir, ancak olmak
            zorunda değildir. Programın bütünlüğü asıl hedeftir.

    -   Bu nesne Kitap tablosuna gelen bütün veri girişlerini kontrol
        eder, sorgularını yazar, komutlarını ORM şartı ile hazırlar ve
        veri trafiğini kontrol eder.

    -   Bu nesne aynı zamanda Tur tablosuyla iletişim kurmakla
        yükümlüdür çünkü kitap türlerine en çok burada
        ihtiyaç duyulmaktadır.

    -   Bu nesne aynı zamanda bazı özel fonksiyonlara sahiptir (Örn.
        AdetListele). Bu fonksiyonlar programın farklı aşamaları
        için (Örn. Grafik) ihtiyaç duyulmaktadır.

-   Emanet nesnesi:

    -   Bu nesne emanetlerin emanetNo, ogrenciNo, kitapNo, emanetTarih,
        iadeTarih ve teslim özelliklerini tutmalıdır.

    -   Tutulan özellikler private olmalı, sadece metod
        izniyle değiştirilebilmelidir.

    -   Özellik okumada sorun olmayacağı için her bir private özellik
        için get fonksiyonu bulunan bir public özellik tanımlanmalıdır.

    -   Bu nesne Emanet ile ilgili tüm statik veya statik olmayan
        metodları tutmak ve çalıştırmakla yükümlüdür. Bu, şu şekilde
        gerçekleşir:

        -   Eğer bir metod bütün tabloya veya bir kısmına erişim
            gerektiriyorsa bu metod statiktir.

        -   Eğer bir metod sadece ve sadece özel bir satıra etki
            edecekse bu metod normal olabilir, ancak olmak
            zorunda değildir. Programın bütünlüğü asıl hedeftir.

    -   Bu nesne Emanet tablosuna gelen bütün veri girişlerini kontrol
        eder, sorgularını yazar, komutlarını ORM şartı ile hazırlar ve
        veri trafiğini kontrol eder.

    -   Bu nesne sadece Emanet pencerelerinden değil aynı zamanda
        Ogrenci ve Kitap pencerelerinden de gösterim isteği alabilmekte
        ve bunun trafiğini kontrol etmekte yükümlü olabilir. Çünkü her
        nesnenin Emanet’e bağlantısının rahat bir şekilde görülebilmesi
        lazımdır, proje planına göre.

    -   Bu nesne ek olarak birkaç statik veri içermelidir. Bunlar,
        karmaşık tasarım mimarisinde her bir verinin doğru şekilde
        tutulduğundan emin olmak içindir. Bu meseleyle ilgili yorum
        satırları yeterince açık yazılmıştır ve ek bilgi gerçekleme
        sırasında da verilecektir.

    -   Bu nesne emanet iade meselelerinden de mesul olduğundan
        BorcHesapla gibi bazı özel fonksiyonlar içermektedir.

    -   Bu fonksiyon aynı zamanda grafik için toplam kitap adını ve
        emanet sayısını alacak EmanetToplam fonksiyonunu tutar.

### Görsel Tasarım

> Her ne kadar benim favorim olmasa da görsel tasarım, kullanıcının
> ilgisini çekmek, ona kullanım kolaylığı sağlamak ve istediklerini
> vermek açısından oldukça önemlidir. Bu sebeple her projeye doğru
> tasarlanmış bir görsel tasarım gerekmektedir. Burada, tasarımı
> yaparken izleyeceğimiz stratejiyi belirteceğim.

-   Erişilebilirlik. Kullanıcının 17 tane formun arasında en son nereye
    tıklamıştım diye kafasının karışmasını istemiyoruz. İstediği yere
    birkaç buton uzaklıkta olmalı.

-   Sadelik. Yukarıdaki sebepten aynı şekilde kullanıcı baktığı
    formu anlamalı. Tasarım, yeterli görsel ve yazıyla desteklenmeli.

-   Kolaylık. Kullanıcı yapmak istediği işlem için bir sürü veri girmek
    zorunda kalmamalı veya bu verileri belirli formata sokmak
    zorunda kalmamalı. Eğer mümkünse seçim kolaylığı veya otomatik işlem
    kolaylığı sağlanmalı.

-   Miktar. Az formla fazla işlem çoğunlukla iyidir.

-   Performans. Tasarım, bilgisayarı 2000 yapımı Dell marka bir
    bilgisayara dönüştürmemeli.

> Bu konular göz önünde alındığında proje yapımı aşamasında şunlara
> karar verdim:

-   Ana formların olabildiğince büyük ve ikona sahip butonlarının olması
    yapılabilecek ana işlemlerin görünümünü kolaylaştıracaktır. İkon
    tasarımım kötü olabileceğinden butonların Tooltip’lere sahip
    olmaları en iyisi.

-   Veri girişi ihtiyacı derinleştiğinde görsel zenginlik yerine
    erişilebilirlik ve anlaşılabilirlik en iyisi olduğundan veri ekleme
    ve güncelleme kısımları sade ve ekstra tasarımdan uzak olmalı.

-   Her bir işlem kısmının ayrı bir rengi olması kullanıcının nerede
    olduğunu ona hatırlatacaktır.

-   Kullanım sırasında oluşabilecek hataların kullanıcıya en hızlı
    şekilde belirtilebilmesi gerekmektedir.

> Ve bu kapsamlarda, proje gerçeklemeye geçebiliriz.

Gerçekleme / Geliştirme
-----------------------

### Veritabanı

> Öncelikle veritabanımızdan başlayalım.
>
> Access -&gt; Boş Veritabanı -&gt; Oluştur -&gt; Tablo -&gt; Kaydet
> -&gt; Tablo Adı Gir -&gt; Sağ tık -&gt; Tasarım Görünümü -&gt;
> Sütunları Ekle

  -----------------------------------------------------------------------------------------------------------------------------------------------------------------------
  Görsel 1:                                                                           Görsel 2:
                                                                                      
  ![](media/image2.png){width="2.843238188976378in" height="2.3953772965879265in"}    ![](media/image3.png){width="2.34375in" height="2.2765463692038495in"}
  ----------------------------------------------------------------------------------- -----------------------------------------------------------------------------------
  Görsel 3:                                                                           Görsel 5:
                                                                                      
  ![](media/image4.png){width="2.6875in" height="0.8333333333333334in"}               ![](media/image5.png){width="3.1246237970253716in" height="2.0104166666666665in"}

  Görsel 4:                                                                           
                                                                                      
  ![](media/image6.png){width="2.8958333333333335in" height="1.2916666666666667in"}   

  Görsel 6:                                                                           Görsel 7:
                                                                                      
  ![](media/image7.png){width="3.2704636920384953in" height="1.4583333333333333in"}   ![](media/image8.png){width="2.3854166666666665in" height="1.4694444444444446in"}
  -----------------------------------------------------------------------------------------------------------------------------------------------------------------------

> Bütün tablolarımızı bu şekilde oluşturmamız gerekli.

![](media/image9.png){width="3.1979166666666665in"
height="1.3990890201224846in"}![](media/image10.png){width="2.375in"
height="1.3870002187226598in"}![](media/image11.png){width="2.247632327209099in"
height="1.0520833333333333in"}![](media/image12.png){width="3.8958333333333335in"
height="0.9868066491688539in"}

Bu veritabanımızı uygun bir yere kaydetmemiz gerek. Ben şimdilik
masaüstüne kaydediyorum. Adı GorselProje olarak. Uzantımız .accdb
olacak.![](media/image13.png){width="6.291666666666667in"
height="2.7916666666666665in"}

Veritabanımız hazır.

### Proje Dosyası Oluşturma ve Düzenleme

Şimdi Visual Studio IDE’mizden bir **C\# Windows Forms Uygulaması (.NET
Framework)** uygulaması açalım. Bu uygulamayı projenizi rahat bir
şekilde yönetebileceğiniz bir konuma yerleştirin. Bu klasöre giriş ve
çıkışlarınız başlarda sık olacak. Projenize anlaşılır bir isim vermenizi
öneririm.

![](media/image14.png){width="6.291666666666667in"
height="4.96875in"}Ben bu işlem için C: dizinimde **“GorselProje”**
adında bir klasör oluşturdum, projemi aynı adda tanımladım ve projemi
onun içine açtım.

Sonrasında yapmamız gereken işlem gerekli dosya ve klasörleri gerekli
kısımlara yerleştirmek olacak. Katmanlı mimari klasör düzenimizi bu
başlığın en son görevi olarak halledeceğiz, önce eklemek istediğimiz
harici kütüphaneleri halletmeliyiz.

Hatırlarsanız dosyamızın en başında bir **ZedGraph.dll** dosyası
indirmiştik. Oluşturduğumuz projemizin çözüm dosyamızın
**(PROJEADI.sln)** olduğu dizine gelelim ve orada **Dependencies**
adında bir klasör açalım. **ZedGraph.dll** dosyamızı oraya taşıyalım.

Şimdi daha öncesinde kaydettiğimiz veritabanı dosyamızı bin -&gt; Debug
klasörüne taşıyalım.

Hazır elimiz değmişken hızlıca bütün görsellerimizi proje klasörümüzün
içindeki

bin -&gt; Debug kısmına klasör halinde taşıyalım.

![](media/image15.png){width="3.3020833333333335in"
height="1.8125in"}![](media/image16.png){width="4.829166666666667in"
height="2.3229166666666665in"}![](media/image17.png){width="3.2083333333333335in"
height="2.3506944444444446in"}

Devamında bu dosyalarımızı projemize tanımlamamız gerekecek. Sırasıyla
aşağıdaki işlemleri yapalım:

-   **Visual Studio** penceresinde projenizi açın ve **Çözüm
    Gezgini**’ni bulun. Eğer açık değilse Görünüm sekmesinden veya
    Ctrl + Alt + L kısayolu ile açın.

-   **Başvurular**’a sağ tıklayın ve oradan **Başvuru
    Ekle**’ye tıklayın. Bu karşınıza **Başvuru Yöneticisi** diyalog
    penceresini açacak.

-   Gözat’a tıklayın.

-   Açılan pencereden proje klasörünüze gidin ve oradan
    **Dependencies**’e girin.

-   **ZedGraph.dll**’yi ve **ZedGraph.resources.dll**’i seçin ve
    “**Ekle**” butonuna tıklayın.

-   **Başvuru Yöneticisi**’nden yeni eklediğiniz başvuruların seçili
    olduğuna emin olun, değilse seçin ve Tamam’a tıklayın.

> Şimdi ise eklediğimiz başvurunun nesnelerine ulaşmamız gerekmekte.
> Bunun için:

-   **Visual Studio** penceresinde **Araç Kutusu**’nu bulun. Eğer açık
    değilse Görünüm sekmesinden veya Ctrl + Alt + X kısayolu ile açın.

-   Burada boş bir yere sağ tıklayın ve **Öğeleri Seç**’e tıklayın. İlk
    açılışta bir süre öğelerin yüklenmesini bekleyeceksiniz.

-   Açılan listede **ZedGraphControl’ü** bulun ve işaretleyin.
    Tamam’a tıklayın.

Artık **ZedGraphControl** nesnesini projemizde rahatlıkla
kullanabiliriz. Şimdi katmanlı mimarimize gelelim.

**Çözüm Gezgini**’nde projenize sağ tıklayın ve Yeni Klasör’ü seçin.
Adını değiştirin. Aşağıdaki her bir maddedeki klasörü projenize ekleyin:

-   Business

-   DataAccess

-   Presentation

-   Extra (Normalde katmanlı mimari’de katı olarak gerekli değil ancak
    sonradan ekleyeceğimiz sınıflar için kullanıyorum.)

Normal şartlar altında bu katmanlardan her biri farklı bir projedir,
çünkü her birini farklı bir cihaz veya sunucu çalıştırabilir. Ancak şu
anki durumumuzda tek bir projeyi tek bir cihaz üzerinden
çalıştırmaktayız, bu sebeple her biri bir klasör olabilir. Bu depolama
alanında artı yönde bir etki oluşturacaktır.

Proje klasörümüz hazır. Asıl işe geçebiliriz…

### Form Tasarımları

Hazırladığımız kütüphane otomasyonu bir Windows Forms uygulaması, bu
sebeple formlarımızın tasarımlarını hazırlamamız gerekmekte. Diğer
formları hazırlamadan önce en başta açılmış formumuzu Presentation
klasörüne atmanızı öneririm. Adını AnaSayfa yapalım. Karşımıza bir uyarı
gelecek, onu kabul edelim, böylece iç kodları da bu değişikliğimize göre
değişecektir.

Sırasıyla aşağıdaki formları Presentation klasörümüze oluşturalım:

-   AnaSayfa

-   OgrenciListe

-   OgrenciPencere

-   KitapListe

-   KitapPencere

-   EmanetListe

-   EmanetPencere

-   inputBox

-   Grafik

Formlarımızın tasarımlarından bahsedeyim. Formlarımız kendini
açıklayabilen, kullanımı kolay ve hızlı olmalı. Ben bu sebeple, aşağıda
görsellerini görebileceğiniz formlarımı şu şekilde tasarladım:

-   AnaSayfa: Sadece büyük ikonlu butonlar, açıklayıcı ToolTip’ler ve
    “Hoş Geldiniz” harici yazı yok. “toolTip” adında bir
    ToolTip içeriyor.

-   Liste Formları: Bu formlar tablolarımızı görüntüleyeceğinden her
    birine birer DataGridView girişi yaptım. İkonlu büyük butonlar
    burada hızlı yönelim için mevcut, ayrıca listede gerekli aramaları
    yapmak için gözle rahat görülebilir TextBox’larımız ve arama
    butonlarımız mevcut. Ayriyeten, Kitap ve Emanet liste formlarında
    grafiği görüntüleyebilecek bir Grafik butonu ekledim. “toolTip”
    adında bir ToolTip içeriyor.

-   Pencere Formları: Bu formlar, veritabanımıza eklemek veya oradaki
    güncellemek istediğimiz veriler için mevcut. Tek görevleri bu olsa
    da tam takır detaylı bir veri akışı olacağı için bu formlarımız
    görselli tasarımdan uzak, TextBox, Label ve diğer giriş kontrol
    nesnelerinden oluşmakta.

-   inputBox Formu: Bu formumuz sonrasında açıklayacağım bir veri
    girişi formu. Tek Label, TextBox ve iki buton (İşlem ve
    İptal şeklinde) yeterli gördüm. Ekstra görsellik
    kullanıcıyı yavaşlatacaktır.

-   Grafik formu: Bu formumuzda kitapların adet ve emanet sayılarını
    karşılaştıracağımız için, grafiği gösterdiğimizi ZedGraphControl
    nesnemiz haricinde grafikte gösterilen ve saklanan kitapları
    listeleyen iki ListBox, ekleme-çıkarma işlemi yapan iki
    buton mevcut. Buradaki görsel tasarımımız grafiğin kendisi.

> Formlarınıza ek görselleri bu aşamada ekleyebilirsiniz.
>
> Şahs-ı münhasır form görüntülerim(Fazla büyük olanlar Runtime’da
> çekildi):
>
> Anasayfa:
>
> ![](media/image18.png){width="5.395833333333333in"
> height="2.447778871391076in"}
>
> OgrenciListe:
>
> ![](media/image19.png){width="6.291666666666667in"
> height="4.166666666666667in"}
>
> OgrenciPencere:
>
> ![](media/image20.png){width="4.010416666666667in"
> height="2.3854166666666665in"}
>
> KitapListe:
>
> ![](media/image21.png){width="6.291666666666667in" height="3.71875in"}
>
> KitapPencere:
>
> ![](media/image22.png){width="4.635416666666667in"
> height="3.4583333333333335in"}
>
> EmanetListe:
>
> ![](media/image23.png){width="6.291666666666667in"
> height="3.8958333333333335in"}
>
> EmanetPencere:
>
> ![](media/image24.png){width="4.59375in"
> height="2.8958333333333335in"}
>
> inputBox:
>
> ![](media/image25.png){width="3.53125in"
> height="1.6041666666666667in"}
>
> Grafik:
>
> ![](media/image26.png){width="6.302083333333333in" height="3.625in"}
>
> Formlarımızı oluşturduğumuza göre kodlamaya giriş yapabiliriz.

### Kodlamaya Geçiş

Formlarımızın tasarımı hazır, ancak form kodlarını en son yazacağız.
İlerleyeceğimiz yol DataAccess -&gt; Business -&gt; Presentation
şeklinde olacak ve bu sayede minimum hata ile ilerleyişimizi sürdürmeye
çalışacağız.

#### Data Access

DataAccess katmanımız, bize veritabanımızla aramızda bir bağ görevi
görecek. İşlevi, kendisine Business katmanından gelen komutları
çalıştırıp gerekli bilgiyi geri göndermek olacak.

##### Database.cs

DataAccess katmanımızı oluşturmak için bir sınıf açmakla başlayalım.
DataAccess klasöründe Database.cs adında bir sınıf oluşturalım.

Bu sınıfın ana gerekli kütüphanelerini girerek başlayalım en başa. Zaten
ekli olan kütüphanelere dokunmadan şu iki kütüphaneyi ekleyin:

Kodumuza statik bir OleDbConnection bağlantısı ekleyerek başlayalım.
Yerel bağlantı yolunu gösterelim. Veritabanımız \~\\bin\\Debug yolunda
olduğu için sadece adı yeterli olacaktır veri kaynağı kısmında.

Şimdi fonksiyonlarımıza geçelim. Fonksiyonlarımız hakkında bilmemiz
gereken birkaç şey:

Select, yani listeleme ve getirme komut çalıştırıcımızdan başlayalım.
Yazdığımız çoğu satırın açıklaması kodumuzda mevcut. Burada fonksiyon
tipimiz DataTable çünkü veri tablosu döndürüyor komut. Ayrıca kullanması
kolay bir nesne.

Artık tek bir parametre ile Select sorgularını gerçekleştirmek ve
listelemek çok kolay! Yavaşça diğer fonksiyonlarımıza geçelim. Update:

Satır kimlik sütun bilgisini döndüren Insert:

Ve tabii ki Delete. Projemde silme işlemine ihtiyaç duymadım çünkü sahip
olduğum tabloların hepsi, içinden verinin silinmesini istemediğim Emanet
tablosuna bağlı. Ancak eğer siz projeyi kendi yönünüzde değiştirmek
isterseniz burada silme işlemini de uygulayalım.

Database sınıfımız bu kadardı. Hatta bu Database katmanımızın da sonu.
Nesneleri tanımlayıp kontrol aşamasını yazacağımız Business katmanına
geçebiliriz.

#### Business

Business katmanımız, sunum ile veritabanı aramızda bir köprü görevi
görür. Sunum katmanından gelen veriye çoğunlukla güvenilmez ve bu
yüzden, sunum cihazında yapılmaması gereken kontroller burada yapılır.
Doğruluğu sağlanan bilgiler işlenir ve eğer ihtiyaç varsa DataAccess
katmanı ile bağlantı sağlanarak veritabanı ile iletişime geçilir.

Burada üç farklı nesnemiz mevcut, ve her biri de ana tablolarımızın
nesneleri. Bu ana tabloları daha önceden dosyamızın veritabanı kısmında
anlatmıştım.

##### Ogrenci.cs

Bu ana nesnelerden Ogrenci ile başlayalım. Ogrenci nesnemiz, bu
tablodaki öğrencileri nesne olarak tutabilecek ve öğrencilerle ilgili
çoğu işlemi yapabilecek. Gelgelelim bu nesne olarak tutma, programın
ihtiyacı dahilinde ilerleyecek, dolayısıyla nesne property’lerimiz
veritabanındaki satırlara direkt olarak bağlı olmak zorunda değil.

Business klasöründe bir Ogrenci.cs dosyası oluşturarak başlayalım.
Kütüphanelere ek olarak şunları ekleyelim:

Kaynak kodunu tekrardan inceleyeceklere ek not:

Class’ımızın hemen öncesinde namespace içine class tanımımızı yapalım.
Bu, kodu sonrasında okurken bize veya başkalarına rahatlık sağlayacak.

Özelliklerimizden başlayalım. Burada özelliklerimiz ana halde private
şeklinde, get ve set mevcut ancak sadece class için geçiyor private
olduğu için. Bu sebeple her bir özellik için sadece get metodu olan ayrı
bir özellik açıyoruz, ufak bir isim değişikliği ile.

Şimdi bu özellikleri atamaya geçelim. Bu özellikler sadece sınıf içinden
atanabildiği için bir yapıcı fonksiyon, nesne tanımlarken çok işimize
yarayacaktır. Gerekli parametrelerle bir yapıcı fonksiyon tanımlayalım.
Parametreleri Dictionary&lt;string, object&gt; şeklinde alalım, bu
sayede yapıcı fonksiyon parametrelerini esnek bir şekilde
kullanabiliriz. Bu, Dictionary&lt;&gt; nesnesini son kullanışımız
olmayacak.

Yapıcı fonksiyonumuz:

Şimdi ana metodlarımıza gelelim. Bu metodlar, diğer sınıflarda da
yapacağımız gibi statik olacak çoğunluğu. Sadece belirli bir satırı
ilgilendiren metodları normal metod olarak hazırlayacağız, o da belirli
zamanlarda. Herkesi listeleme fonksiyonumuzdan başlayalım:

Şimdi filtreli bir listeleme fonksiyonu yazalım.

Öğrencileri silmek, daha doğrusu silinmiş olarak göstermek de önemli.
Burada sadece silindi verisini true yaparız ancak öncesinde borcunun
veya emanet aldığı kitabın olmadığından emin oluruz.

Eğer tek bir öğrenciyi getirmek istersek diye, Ogrenci nesnesi getiren
bir fonksiyon yazıyoruz.

Veritabanına öğrenci eklemek, isteyeceğiz. Buradaki işlemlere dikkat
etmenizi öneririm.

Öğrencilerimiz, yönetici tarafından güncellenebilir olmalı. Adları ve
soyadları. Borç ve geçiade güncellemeleri ayrı bir metod çünkü ayrı
onay, giriş ve işlem gerektirir. Burada da eklemedeki gibi bir kontrol
aşaması var.

Öğrencilerin edinebildiği borçlar ödenebilir, ayrıca özel durumlarda,
mesela toplu kitap bağışlarında belki de geciktirdiği kitaplar telafi
edilebilir, böylece eğer okul, geç iadelerde bir ceza sistemi
uyguluyorsa bu cezalar, iyi işlemlerle telafi edilebilir. Bu sebepten
borç ödeme ve telafi etme ayrı ve özel fonksiyonlar.

Ve böylelikle Ogrenci.cs’mizi bitirmiş oluyoruz.

##### Kitap.cs

Kitap sınıfımız veritabanımızdaki kayıtlı kitapların işlemlerini yapmaya
yarayacak. Onların veri giriş ve veri çekişi, listelenmesi, giriş
kontrolleri vb. ile görevli. Genel olarak baktığımızda bütün
sınıflarımız benzer, Kitap da dahil. Bu yüzden Ogrenci.cs sınıfında
yaptığımız Business katmanı ile ilgili açıklamalar burası için de
geçerli.

Kütüphanelerimizden ve baş açıklamamızdan başlayalım. Her zamanki gibi,
VAR OLAN KÜTÜPHANELERİN ÜZERİNE kütüphane eklemesi yapıyoruz.

Ana sınıf açıklamamız:

Özelliklerimiz ve get fonksiyonlarımız, bunun kodunu yazmadan önce şuna
tekrardan açıklık getirmek isterim. Biz sadece ihtiyacımız olan verileri
tutuyoruz. Kitap tablosu turAd değil turNo tutar, ancak Kitap.cs nesnesi
daha kolay ulaşım için turAd tutmaktadır.

Yapıcı fonksiyonumuz. Ogrenci.cs sınıfında yaptığımız açıklamalar
geçerli.

Şimdi genel kitap listeleme fonksiyonumuz.

Şimdi de filtreliler:

Silme fonksiyonumuz. Neredeyse her silme fonksiyonumuz bir hayli
görkemli, birden fazla iş falan. Havalı ya…

Veritabanından tek bir kitap getirme işlemi:

Listeleme fonksiyonlarımız bitti, şimdi eklemede sıra.

Güncelleme fonksiyonumuz. Aynı kurallar mevcut.

Veritabanımıza kitap eklerken türlerine ada göre ihtiyaç duyuyoruz. Bu
sebeple tür listeleme fonksiyonumuz mevcut.

Adet listesi ise grafik için lazım.

Ve Kitap.cs sınıfımızı burada bitirebiliriz. Sırada son sınıfımız olan
Emanet.cs var.

##### Emanet.cs

Emanet sınıfımız, öğrencilerimizin aldığı emanetleri tutan bir tablo
olan Emanet tablosuna gelen giriş çıkış ve kontrol işlemlerini yönetmek
ve köprü görevi görmekle görevli. Emanet sınıfımız aynı zamanda grafik
için gerekli birkaç fonksiyona da sahip olacak. Diğer olaylar için diğer
sınıflardaki açıklamalar geçerli.

Kütüphane EKLEYEREK başlayalım. Var olan kütüphaneleri silmeyelim.

Başlangıcı atalım ve özellikleri ekleyelim.

Emanet.cs olarak adlandırdığımız sınıf ilginç bir sınıf. Birçok farklı
görevi mevcut, sadece kendisiyle ilgilenen beyaz taraklı buğu aynalı bir
prens değil anlayacağınız. Kodun yorum satırlarında detaylıca yaptığım
açıklamalarla, nereye neden ekstra statik özellikleri eklediğimi
görebilirsiniz, çünkü bu özelliklerden daha fazlasına ihtiyacımız var.

Şimdi Emanet formunun gelelim ASIL özelliğine. Birden fazla taraftan
çağırılabilme. Bunu zaten birkaç fonksiyonda uyarlayacağız ancak asıl
önemli olan bu uyarlamada hızlı ve dinamik olabilmekte. Bunun için bir
string’e ihtiyaç duydum. Basit bir string.

Yapıcı fonksiyonumuzdan devam edelim. Bu seferkinin yapıcı fonksiyon
konusunda diğerlerinden bir farkı yok. Asıl olay formlarda başlıyor.

Burada önceden açıkladığımız listeleme olayı için fonksiyonumuz. Gelen
bütün öğrenci ve kitap tam listelerini öğrenci numarası sırasına göre
tutmak için bu fonksiyona gönderiyoruz ilk.

Şimdi emanet eklemek için gereken protokolü yazalım.

Artık asıl fonksiyonlarımıza dönebiliriz. Burada da asıl
fonksiyonlarımızda çeşitlilik var, ancak bazı işlemlerimiz olmadığından
(Mesela emanetlerin genel bilgileri güncellenemez) kod sayısı neredeyse
eşit. Aşağıdan başlayalım.

Tam listeleme fonksiyonumuz,

Şimdi belirli bir numaraya sahip emanetleri döndürelim. Bu aslında diğer
sınıflardaki Al fonksiyonlarımıza benzer, ancak sadece veri getiren
türü. Çünkü bizim burada Emanet nesnesine ihtiyacımız yok, o yüzden
sadece sıralama çeşidini kullandık.

Emanet formumuz öğrenci no’ya veya ada göre arama yeteneğine sahip
olacak, bunun için ise doğru çalışır bir Business katmanı fonksiyonuna
ihtiyaç duyar, gerekli şartları gözden geçiren, girişi okuyan ve buna
göre veri dönütü yapan. Öğrenciye göre arama için gereken fonksiyonumuzu
yazalım.

Benzer fonksiyon kitap arama için de geçerli olacak.

Şimdi eklemede sıra

Vay canına, bu uzundu. İade işlemimizle devam edelim.

Tam bir sayfa kod. İade işlemi bir hayli zorladı, ancak en azından
elimizde tam takır çalışan bir kod var!

Emanet eklerken öğrenci ve kitap adları tam liste ihtiyacımız olacak.
Kullanıcı bu liste içerisinden seçecek. Öğrenci no yazmak yerine buradan
seçmek çok daha mantıklı gibime geldi.

İade sırasında borcun kullanıcıya bildirilmesi gerek. Bunun için de borç
hesaplamak gerek.

Buraya kadar mükemmel bir iş çıkardık. Programın tamamen kullanıcı dostu
olması için elimizden geldiğince anlaşılabilir bilgiler sağlayan bir kod
yazdık. Gelgelelim kullanıcının anlaşılabilir bilgi alması demek,
programın kendi anladığı dili kullanıcının diline, kullanıcının anladığı
dili kendi diline çevirmesi demek. İşte bu çevirmeyi yapan
fonksiyonlardan biri.

Son fonksiyonumuz grafik için gerekli bir fonksiyon. Her bir kitabın
toplamda kaç tane iade edilmemiş emanete dahil olduğunu bulan sorgu.

Emanet.cs sınıfımızı burada bitirerek Business katmanının kapitalizmin
zirvesinde durduğu beyaz yakalı rejimine bir son vererek işçi sınıfını
asıl eğlendiren Presentation katmanına- Ehem… Business katmanımız bitti.
Presentation katmanımıza giriş yapacağız, ancak ondan önce orada
kullanacağım bir sınıf için Extra katmanında çok ufacık bir gezintiye
çıkalım.

#### Extra

Extra katmanım benim VerticalLabel.cs adında kullandığım, yan bir
şekilde yazı yazmaya yarayan sınıfı içinde bulundurduğum katman. Bu kodu
dış bir kaynaktan aldım, gerekli açıklamaya sahip değilim o yüzden kodun
satırları için. Siz daha fazla bu şekilde sınıf oluşturmak ve/veya
kullanmak isterseniz bu katman tam yeri. Hemen sınıfımızı oluşturalım ve
dış kaynaktan aldığımız kodu yapıştıralım.

##### VerticalLabel.cs

#### Presentation

Presentation katmanımız uygulamamızın kalbi sayılamaz, ancak çok rahat
derimiz falan olabilir. Veya ne bileyim, ayağımızdaki Adidas marka
ayakkabı veya üstümüzdeki F50 ceket falan…

Presentation katmanı yukarıda yaptığım tanımdan anlayacağınız kadarıyla
kullanıcıya tasarımımızın sunumunu yaptığımız, görüntüyü oluşturduğumuz
kısım. Burada dönen işlem çoğu zaman sadece görüntüyle bağdaştırılabilir
işlemler olur. Şart-koşul’u minimumda tutmak ve veritabanı bağlantısını
ASLA yapmamak gerek.

Presentation katmanımız diğer katmanlarımızdan farklı ilerleyecek çünkü
burada yoğun oranda Control nesnesi kullanımı var ve bu nesnelerin
Olayları (Event) mevcut. Bu olayları fonksiyonlardan önce belirteceğim,
ancak öncesinde bir olay ile fonksiyon nasıl açılır onu göstereceğim.

-   Özellikler penceresini bulun veya F4 kısayolu ile açın.

-   Herhangi bir Control nesnesini seçin.

-   Olaylar kısmını açmak için Özellikler penceresinden yıldırım
    ikonuna tıklayın.

-   Fonksiyonunu oluşturmak istediğiniz olayın değerine çift
    tıklayın![](media/image93.png){width="3.03125in"
    height="2.7708333333333335in"}

Bundan sonraki kısımda fonksiyonları gerekli olaylara bağlarken veya
olaylardan fonksiyon oluştururken şu şekilde göstereceğim:

NesneAdı\_OlayAdı

Ayrıca bütün formları var olan kodların üzerine ekleme yaparak
düzenleyeceğiz. Eğer bir form kodu ekstra bir bilinmeyen gerektiriyorsa
bunu özel olarak belirteceğim.

##### AnaSayfa.cs

*Form1\_Load*

Form yüklendiğinde bazı nesnelere toolTip verilir.

btn\_ogrenciler\_Click

btn\_kitaplar\_Click

btn\_emanet\_Click

##### OgrenciListe.cs

###### Bilinmeyenler

###### Olaylar harici fonksiyonlar

###### Olay bağlı fonksiyonlar

tb\_noAra\_Enter

tb\_noAra\_Leave

tb\_adSoyadAra\_Enter

tb\_adSoyadAra\_Leave

OgrenciListe\_Load

btn\_noAra\_Click

btn\_adSoyadAra\_Click

btn\_ogrenciEkle\_Click

btn\_ogrenciDuzenle\_Click

btn\_ogrenciSil\_Click

btn\_ogrenciEmanet\_Click

##### OgrenciPencere.cs

###### Bilinmeyenler

###### Yapıcı fonksiyonlar

###### 

###### 

###### 

###### 

###### 

###### 

###### 

###### 

###### 

###### 

###### 

###### 

###### Olay bağlı fonksiyonlar

OgrenciPencere\_Load

btn\_ode\_Click

btn\_telafi\_Click

btn\_islem\_Click

##### KitapListe.cs

###### Bilinmeyenler

###### Olaylar harici fonksiyonlar

###### 

###### 

###### 

###### 

###### 

###### 

###### 

###### 

###### 

###### 

###### 

###### 

###### Olay bağlı fonksiyonlar

tb\_noAra\_Enter

tb\_noAra\_Leave

tb\_adAra\_Enter

tb\_adAra\_Leave

KitapListe \_Load

btn\_noAra\_Click

btn\_adAra\_Click

btn\_kitapEkle\_Click

btn\_kitapDuzenle\_Click

btn\_kitapSil\_Click

btn\_kitapEmanet\_Click

btn\_grafik\_Click

##### KitapPencere.cs

###### Bilinmeyenler

###### Yapıcı Fonksiyonlar

###### Olay Bağlı Fonksiyonlar

KitapPencere\_Load

Btn\_islem\_Click

##### EmanetListe.cs

###### Bilinmeyenler ve Açıklama

###### Yapıcı Fonksiyonlar

###### Olay Harici Fonksiyonlar

###### Olay Bağlı Fonksiyonlar

tb\_noAra\_Enter

tb\_noAra\_Leave

tb\_ogrAra\_Enter

tb\_ogrAra\_Leave

tb\_kitapAra\_Enter

tb\_kitapAra\_Leave

EmanetListe\_Load

btn\_noAra\_Click

btn\_ogrAra\_Click

btn\_kitapAra\_Click

btn\_emanetEkle\_Click

btn\_emanetIade\_Click

btn\_grafik\_Click

##### EmanetPencere.cs

###### Bilinmeyenler

###### Yapıcı Fonksiyonlar

###### Olay Bağlı Fonksiyonlar

EmanetPencere\_Load

btn\_islem\_Click

##### inputBox.cs

###### Bilinmeyenler ve Açıklama

###### Yapıcı Fonksiyon

###### Olay Bağlı Fonksiyonlar

btn\_islem\_Click

btn\_iptal\_Click

##### Grafik.cs

###### Ek Kütüphaneler

###### Bilinmeyenler

###### Olay Harici Fonksiyonlar

###### Olay Bağlı Fonksiyonlar

Grafik\_Load

btn\_ekle\_Click

btn\_cikar\_Click

SONUÇ
=====

Birkaç haftadır üzerinde çalıştığım bu projemin bütün aşamalarını
başarılı bir şekilde bitirmekteyim ve şu an son cümlelerimi yazıyorum.
Bu yoğun sürecin verdiği yorgunlukla projeyi bitirmiş olmanın gururunu
birlikte yaşıyor, sevinçle uykusuzluğun karışımını başımda hissediyorum.
Umarım bu dosya ve proje, göndereceğim herkese bu projeyi yaparken benim
öğrendiklerimi öğrenmeleri için güzel bir fırsat tanır.

Buraya kadar bana destek çıkan herkese teşekkür eder, bu projeyi okumuş,
indirmiş kişilere ve aynı zamanda Serdar Biroğul hocama bu öğretici
ödevi için saygılarımı sunarım.

Halil Alper YALÇIN
