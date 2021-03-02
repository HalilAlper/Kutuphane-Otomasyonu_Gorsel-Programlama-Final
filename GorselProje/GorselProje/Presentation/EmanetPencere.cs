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
    //Bu penceremiz emanet eklemek için. O kadar. Güncelleme yok.
    public partial class EmanetPencere : Form
    {
        Business.Emanet Emn;//Gerekli emaneti tutmak için

        //Yapıcı fonksiyon. Eğer:
        //gNo == -1 ise Admin panelinden açılmıştır. Normal eklemek.
        //gNo != -1 ve ogrDurum == true ise öğrenci panelinden açılmıştır. Öğrenciye emanet eklemek
        //gNo != -1 ve ogrDurum == false ise kitap panelinden açılmıştır. Kitabı emanet etmek
        public EmanetPencere(int gNo, bool ogrDurum)
        {
            InitializeComponent();

            DataTable Ogrenciler = Business.Emanet.OgrenciListele();    //Hemen öğrenci adlarını alıyor
            foreach (DataRow row in Ogrenciler.Rows)                    //Ve her satırı gezerek
            {
                cb_ogrenci.Items.Add(row[1]);                           //ComboBox'ımıza ekliyoruz.
            }

            DataTable Kitaplar = Business.Emanet.KitapListele();        //Hemen kitap adlarını alıyor
            foreach (DataRow row in Kitaplar.Rows)                      //Ve her satırı gezerek
            {
                cb_kitap.Items.Add(row[1]);                             //ComboBox'ımıza ekliyoruz
            }   

            if (gNo != -1) //Eğer admin panelinden AÇILMAMIŞSA
            {

                int Index = Business.Emanet.IndexGetir(gNo, ogrDurum);  //Belirtece göre index getir
                if (ogrDurum)                                           //Eğer belirteç öğrenciye yönelik ise
                {
                    if (Index != -1)                                    //Ve Index bulunmuş ise
                    {
                        cb_ogrenci.SelectedIndex = Index;               //Öğrenci ComboBox'ını seçilmiş öğrenci yap
                        cb_ogrenci.Enabled = false;                     //Ve seçimi engelle
                    }
                    else
                    {
                        MessageBox.Show("Seçili öğrenci için Index bulunamadı!");//Index bulunamadıysa hata ver
                        this.Close();                                   //Ve eklemeyi engelle
                    }
                }
                else                                                    //Eğer belirteç kitaba yönelik ise
                {
                    if (Index != -1)                                    //Ve Index bulunmuş ise
                    {
                        cb_kitap.SelectedIndex = Index;                 //Öğrenci ComboBox'ını seçilmiş öğrenci yap
                        cb_kitap.Enabled = false;                       //Ve seçimi engelle
                    }
                    else
                    {
                        MessageBox.Show("Seçili kitap için Index bulunamadı!");//Index bulunamadıysa hata ver
                        this.Close();                                   //Ve eklemeyi engelle
                    }
                }
            }
        }

        //Pencere yüklendiğinde
        private void EmanetPencere_Load(object sender, EventArgs e)
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
            No.Location = new Point(400, -160); //Yazı konumu
            No.Size = new Size(45, 400);        //Yazı boyutu, aşağıdaki de font
            No.Font = new Font(FontFamily.GenericSansSerif, 14, FontStyle.Bold);
            No.NewText = "Yeni Emanet Girişi";  //Sadece emanet girişi olduğu için yazıyı belirle

            dtp_emanetTarih.Value = DateTime.Today;//Teslim tarihi varsayılanı: Bugün
            dtp_iadeTarih.Value = DateTime.Today.AddDays(7);//İade tarihi varsayılanı: Bir hafta sonra
        }

        //Eklemek için buton
        private void btn_islem_Click(object sender, EventArgs e)
        {
            //Gerekli parametreleri Dictionary'mize dolduralım.
            Dictionary<string, object> Param = new Dictionary<string, object>(); //Birden fazla türde veri alabilmesi için object
            Param.Add("ogrenciadsoyad", cb_ogrenci.Text); //Bütün parametreler
            Param.Add("ogrenciindex", cb_ogrenci.SelectedIndex); //Index'e göre öğrenci no için
            Param.Add("kitapAd", cb_kitap.Text);
            Param.Add("kitapindex", cb_kitap.SelectedIndex); //Index'e göre kitap no için
            Param.Add("emanetTarih", dtp_emanetTarih.Value);
            Param.Add("iadeTarih", dtp_iadeTarih.Value);
            Param.Add("teslim", rb_evet.Checked);

            Emn = Business.Emanet.EmanetEkle(Param);    //Emanet ekle komutumuz parametrelerle çağırılıyor.

            if (Emn != null)                            //Başarılı şekilde eklendiyse
            {
                this.DialogResult = DialogResult.OK;    //OK döndür ve kapat
                this.Close();
            }
        }
    }
}
