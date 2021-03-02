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
    //Bu penceremiz kitap eklemek veya güncellemek için
    public partial class KitapPencere : Form
    {
        //Form güncellemek için açılmışsa kitapNo ve Ktp gerekli verileri içerecek.
        //Eğer eklemek için açılmışsa kitapNo = -1, Ktp ise null.
        int kitapNo;
        Business.Kitap Ktp;

        //Yapıcı fonksiyon. Kitap ekleme işlemi için parametresiz yapıcı
        public KitapPencere()
        {
            InitializeComponent();

            //Eğer öğrenci ekleniyorsa kitapNo -1 olmalı, ve form text'ini değiştiriyoruz.
            kitapNo = -1;
            this.Text = "Kitap Ekle";

            //Kitap Türlerini Al, bizim ihtiyacımız tür adları, no'yu sadece program bilecek. Business'e işlendi
            DataTable Turler = Business.Kitap.TurListe();
            //CheckBox'a ekle, her bir satırı
            foreach (DataRow row in Turler.Rows)
            {
                cb_turAd.Items.Add(row[1]);
            }
        }

        //Eğer kitap güncelliyorsak yapıcı fonksiyona ktpNo gelir
        public KitapPencere(int ktpNo)
        {
            InitializeComponent();
            //Eğer ktpNo varsa Kitap da olmalı. Business sınıfından verilen kitap numarasına ait kitabı nesne olarak çek
            Ktp = Business.Kitap.KitapAl(ktpNo.ToString());

            //Kitap Türlerini Al
            DataTable Turler = Business.Kitap.TurListe();
            //Hepsini checkbox'a ekle. Index'ler getirilirken Business'a işlendi
            foreach (DataRow row in Turler.Rows)
            {
                cb_turAd.Items.Add(row[1]);
            }

            //Güncelleme her bir veriyi değiştirebilir. Var olan kitabın her verisini forma doldur.
            kitapNo = ktpNo;
            tb_kitapAd.Text = Ktp.KitapAd;
            tb_yazar.Text = Ktp.Yazar;
            tb_yayinevi.Text = Ktp.Yayinevi;
            cb_turAd.SelectedIndex = cb_turAd.FindStringExact(Ktp.TurAd);
            tb_sayfaSayisi.Text = Ktp.SayfaSayisi.ToString();
            dtp_basimTarih.Value = Ktp.BasimTarih;
            tb_adet.Text = Ktp.Adet.ToString();

            //Buton ve form yazılarını unutmayalım.
            btn_islem.Text = "GÜNCELLE";
            this.Text = "Kitap Güncelle";
        }

        private void KitapPencere_Load(object sender, EventArgs e)
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
            No.Location = new Point(400, -130); //Yazı konumu
            No.Size = new Size(45, 400);        //Yazı boyutu, aşağıdaki de font
            No.Font = new Font(FontFamily.GenericSansSerif, 14, FontStyle.Bold);
            if (kitapNo != -1)                  //Eğer kitapNo = -1 değil ise
            {
                No.NewText = "Kitap No: " + kitapNo.ToString();
                this.Text = "Kitap Güncelle";
            }
            else                                //Eğer kitapNo var ise
            {                                   //Yeni kitap ekleniyordur. VerticalLabel'ı bu yönde yaz
                No.NewText = "Yeni Kitap";
                this.Text = "Yeni Kitap";
            }

            No.Parent = this;                   //Label'ımızın ebeveynini form yap
        }

        //Bu da güncelleme veya ekleme işlemi için buton
        private void btn_islem_Click(object sender, EventArgs e)
        {
            if (kitapNo == -1) //Ekleme, eğer kitap yoksa yeni kitap eklemek içindir
            {
                //Gerekli parametreleri Dictionary'mize dolduralım.
                Dictionary<string, object> Param = new Dictionary<string, object>();    //Birden fazla türde veri alabilmesi için object
                Param.Add("kitapAd", tb_kitapAd.Text); //Bütün parametreler
                Param.Add("yazar", tb_yazar.Text);
                Param.Add("yayinevi", tb_yayinevi.Text);
                Param.Add("turNo", cb_turAd.SelectedIndex + 1);
                Param.Add("turAd", cb_turAd.SelectedIndex + 1); //Nesne oluşturmak için gerekli
                Param.Add("sayfaSayisi", tb_sayfaSayisi.Text);
                Param.Add("basimTarih", dtp_basimTarih.Value);
                Param.Add("adet", tb_adet.Text);

                Ktp = Business.Kitap.KitapEkle(Param);          //Kitap ekle komutumuz parametrelerle çağırılıyor.

                if (Ktp != null)                                //Eğer başarıyla eklenmişse dolu bir nesne geliyor. Nesne boş değilse:
                {
                    this.DialogResult = DialogResult.OK;        //OK yanıtı bir önceki forma verilerek pencere kapatılıyor
                    this.Close();
                }
            }
            else //Güncelleme, eğer kitap no -1 değilse kitap noya ait kitap güncellenecek
            {   //Gerekli parametreleri Dictionary'mize dolduralım.
                Dictionary<string, object> Param = new Dictionary<string, object>(); //Birden fazla türde veri alabilmesi için object
                Param.Add("kitapNo", kitapNo); //Bütün parametreler
                Param.Add("kitapAd", tb_kitapAd.Text);
                Param.Add("yazar", tb_yazar.Text);
                Param.Add("yayinevi", tb_yayinevi.Text);
                Param.Add("turNo", cb_turAd.SelectedIndex + 1);
                Param.Add("sayfaSayisi", tb_sayfaSayisi.Text);
                Param.Add("basimTarih", dtp_basimTarih.Value);
                Param.Add("adet", tb_adet.Text);

                //Güncelleme olduğu için değiştirilen satır sayısını döndürecek. Tek bir satırın dönmesi gerek.
                int Satir = Business.Kitap.KitapGuncelle(Param);//Eğer tek satır değilse hatayı Business'te veriyor.
                if (Satir == 1)
                {
                    this.DialogResult = DialogResult.OK; //Eğer tek bir satır değişmişse onayla ve kapat
                    this.Close();
                }
            }
        }
    }
}
