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
    //Bu penceremiz öğrenci eklemek veya güncellemek için
    public partial class OgrenciPencere : Form
    {
        //Form güncellemek için açılmışsa ogrNo ve Ogr gerekli verileri içerecek.
        //Eğer eklemek için açılmışsa ogrNo = -1, Ogr ise null.
        int ogrNo;
        Business.Ogrenci Ogr;

        //Yapıcı fonksiyon. Öğrenci ekleme işlemi için parametresiz yapıcı
        public OgrenciPencere()
        {
            InitializeComponent();

            //Ekleme sırasında ödeme ve telafi işlemleri yapılamayacağı için butonları görünmez yapıyoruz.
            //Ve adı geçen textbox'ların boyutunu güncelleyip değiştirilebilir (Enabled = true) yapıyoruz.
            btn_ode.Visible = false;
            btn_telafi.Visible = false;
            tb_borc.Size = tb_ad.Size;
            tb_gecIade.Size = tb_ad.Size;
            tb_borc.Enabled = true;
            tb_gecIade.Enabled = true;

            ogrNo = -1;                 //Çünkü ekliyoruz
            this.Text = "Öğrenci Ekle"; //Form text'i
        }

        //Eğer öğrenci güncelliyorsak yapıcı fonksiyona ogrenciNo gelir
        public OgrenciPencere(int ogrenciNo)
        {
            InitializeComponent();
            //Eğer ogrNo varsa Ogr de olmalı. Business sınıfından verilen öğrenci numarasına ait öğrenciyi nesne olarak çek
            Ogr = Business.Ogrenci.OgrenciAl(ogrenciNo.ToString());

            //Güncelleme sırasında sadece ad ve soyad yazarak güncellenecek.
            //Borç ödeme ve telafi işlemleri butona tıklanarak ve gerekli inputBox'tan girilerek yapılıyor
            //Bu sebeple borc ve gecIade textBox'ları varsayılan olarak (Enabled = false) olarak kalıyor
            //Yine de her veri görünürlük amaçlı forma dolduruluyor.
            ogrNo = Ogr.OgrenciNo;
            tb_ad.Text = Ogr.Ad;
            tb_soyad.Text = Ogr.Soyad;
            tb_borc.Text = Ogr.Borc.ToString();
            tb_gecIade.Text = Ogr.GecIade.ToString();

            //Buton adını değiştirelim. Varsayılan: "EKLE" idi
            btn_islem.Text = "GÜNCELLE";
            this.Text = "Öğrenci Güncelle"; //Vee form text'i elbette
        }

        private void OgrenciPencere_Load(object sender, EventArgs e)
        {
            //Pencere yüklendiğinde bir VerticalLabel oluşturuyoruz. Bu farklı açılarda Label için.
            //Bu label'ın sadece OnPaint fonksiyonu değiştiriliyor ve yazının farklı biçimde boyanması sağlanıyor.
            //Yani nesne gerçekten döndürülmüyor. Bu sebeple bazı özellikleri normalden farklı olarak manuel atayacağız.
            VerticalLabel No = new VerticalLabel();
            //Nesneyi istediğimiz özelliklerde düzenliyoruz.
            No.Text = "";                       //Yazıyı metodla yazacağız, o yüzden boş
            No.AutoSize = false;                //Yazı döndürülebildiğinden boyutu biz belirleyeceğiz.
            No.ForeColor = Color.Beige;         //Yazı rengi
            No.RotateAngle = 90;                //Yazı açısı
            No.Location = new Point(330, -190); //Yazı konumu
            No.Size = new Size(45, 400);        //Yazı boyutu, aşağıdaki de font
            No.Font = new Font(FontFamily.GenericSansSerif, 14, FontStyle.Bold);
            if (ogrNo != -1)                    //Eğer ogrNo = -1 değil ise
            {                                   
                No.NewText = "Öğrenci No: " + ogrNo.ToString();
                this.Text = "Öğrenci Güncelle";
            }
            else                                //Eğer ogrNo var ise
            {                                   //Yeni öğrenci ekleniyordur. VerticalLabel'ı bu yönde yaz
                No.NewText = "Yeni Öğrenci";
                this.Text = "Yeni Öğrenci";
            }
            
            No.Parent = this;                   //Label'ımızın ebeveynini form yap
        }
        
        //Ödeme butonu, borcu ödemek için
        private void btn_ode_Click(object sender, EventArgs e)
        {
            if (Ogr.Borc == 0) //Eğer borç sıfır ise ödenecek borcu olmadığı söylenmelidir.
            {
                MessageBox.Show("Ödenecek borç bulunmamaktadır!");
            }
            else                                                    //Eğer borcu var ise
            {                                                       //Önce inputBox'tan bir veri girişi al
                Presentation.inputBox Giris = new Presentation.inputBox("Borç Öde", "Lütfen Ödenecek Miktarı Giriniz:", "Öde", "Int");
                var Sonuc = Giris.ShowDialog();                     //Sonucu almak için ShowDialog
                if (Sonuc == DialogResult.OK)                       //Eğer öde denmişse
                {
                    int Deger = Giris.ReturnDegerInt;               //Geriye dönen değeri hesaplayalım
                    bool OdemeSonuc = Ogr.BorcOde(Deger);           //Ödemeyi yapmak için istek gönderelim
                    if (OdemeSonuc)                                 //Başarıyla ödenmişse
                    {
                        MessageBox.Show("Borç başarıyla ödendi!");  //Gerekli mesajı verelim
                        tb_borc.Text = Ogr.Borc.ToString();         //Ve textbox'ta güncelleyelim
                    }
                    else                                            //Ödenememişse
                    {                                               //Hata mesaşını gösterelim
                        MessageBox.Show("Lütfen girişi gerekli aralıkta gerçekleştiriniz (1 - Borç Miktarı).");
                    }
                }
            }
        }

        //Geç verilmiş kitapların telafisi bir şekilde yapılabilirse diye telafi etme
        private void btn_telafi_Click(object sender, EventArgs e)
        {
            //Olay borçtakine çok benzer
            if (Ogr.GecIade == 0)   //Eğer telafi edilecek geç iade yoksa
            {                       //Hata mesajı ver
                MessageBox.Show("Telafi edilecek kitap bulunmamaktadır!");
            }
            else
            {                        //Aksi halde telafi edilecek kitap sayısını iste
                Presentation.inputBox Giris = new Presentation.inputBox("Geç Kitap Telafisi", "Lütfen telafi edilecek miktarı giriniz:", "Telafi", "Int");
                var Sonuc = Giris.ShowDialog(); //Sonucu inputBox'tan almak için ShowDialog
                if (Sonuc == DialogResult.OK)   //Eğer onay verilmişse
                {                               //Gelen değer alınır ve TelafiEt metoduna değer gönderilir.
                    int Deger = Giris.ReturnDegerInt;
                    bool TelafiSonuc = Ogr.TelafiEt(Deger);
                                                //Eğer telafi edilebilmişse
                    if (TelafiSonuc)
                    {                           //Onay mesajı verilir ve gerekli textbox düzeltilir
                        MessageBox.Show("Başarıyla telafi işlemi yapıldı!");
                        tb_gecIade.Text = Ogr.GecIade.ToString();
                    }
                    else                        //Telafi edilememişse uyarı mesajı verilir. Bu durumda giriş yanlıştır.
                    {
                        MessageBox.Show("Lütfen girişi gerekli aralıkta gerçekleştiriniz (1 - Geciktirilmiş Kitap Miktarı).");
                    }
                }
            }
        }

        //Bu da güncelleme veya ekleme işlemi için buton
        private void btn_islem_Click(object sender, EventArgs e)
        {
            if (ogrNo == -1) //Ekleme, eğer öğrenci yoksa yeni öğrenci eklemek içindir
            {
                //Gerekli parametreleri Dictionary'mize dolduralım.
                Dictionary<string, object> Param = new Dictionary<string, object>(); //Birden fazla türde veri alabilmesi için object
                Param.Add("ad", tb_ad.Text); //Bütün parametreler
                Param.Add("soyad", tb_soyad.Text);
                Param.Add("borc", tb_borc.Text);
                Param.Add("gecIade", tb_gecIade.Text);

                Ogr = Business.Ogrenci.OgrenciEkle(Param);  //Öğrenci ekle komutumuz parametrelerle çağırılıyor.

                if (Ogr != null)                            //Eğer başarıyla eklenmişse dolu bir nesne geliyor. Nesne boş değilse:
                {
                    this.DialogResult = DialogResult.OK;    //OK yanıtı bir önceki forma verilerek pencere kapatılıyor
                    this.Close();
                }
            }
            else //Güncelleme, eğer öğrenci no -1 değilse öğrenci noya ait öğrenci güncellenecek
            {   //Gerekli parametreleri Dictionary'mize dolduralım.
                Dictionary<string, object> Param = new Dictionary<string, object>(); //Birden fazla türde veri alabilmesi için object
                Param.Add("ogrenciNo", ogrNo.ToString()); //Bütün parametreler
                Param.Add("ad", tb_ad.Text);
                Param.Add("soyad", tb_soyad.Text);
                Param.Add("borc", tb_borc.Text);
                Param.Add("gecIade", tb_gecIade.Text);

                //Güncelleme olduğu için değiştirilen satır sayısını döndürecek. Tek bir satırın dönmesi gerek.
                int Satir = Business.Ogrenci.OgrenciGuncelle(Param); //Eğer tek satır değilse hatayı Business'te veriyor.
                if (Satir == 1)
                {
                    this.DialogResult = DialogResult.OK; //Eğer tek bir satır değişmişse onayla ve kapat
                    this.Close();
                }
            }
        }
    }
}
