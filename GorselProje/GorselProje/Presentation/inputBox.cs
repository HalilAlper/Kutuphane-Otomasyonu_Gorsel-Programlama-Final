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
    public partial class inputBox : Form
    {
        //InputBox gerektiğinde içine değer girebilmem için tasarladığım bir form
        //Ama sadece borç ödeme ve iade telafi için kullandım
        //Formdan geriye değer döndürmek için bilinmeyenler:
        public int ReturnDegerInt;
        public double ReturnDegerDouble;
        public string ReturnDegerString;

        //Hangi tipte değer dönecek:
        private string ReturnTip;
        public inputBox(string Baslik, string Mesaj, string ButonYazi, string Tip)
        {
            InitializeComponent();

            //Bu formun bir başlığı, mesajı, buton yazısı ve Return tipi var
            //Bunları da formu oluştururken belirtiyoruz, aynı MessageBox gibi
            //Buradaki fark bunu oluşturmamız gerektiği, .Show gibi statik bir fonksiyon değil
            this.Text = Baslik;
            lbl_Mesaj.Text = Mesaj;
            btn_islem.Text = ButonYazi;
            ReturnTip = Tip;
        }

        //İşlem tuşu istenilen tipte veriyi göndermeye çalışır.
        private void btn_islem_Click(object sender, EventArgs e)
        {
            try //Bu tamamen giriş amaçlı olduğu için istenmeyen veriyi uzak tutmak gerek elbet.
            {   //O yüzden zibilyon tane şart ile türe göre geri dönderme yapıp kapatıyoruz pencereyi
                if (ReturnTip == "String")
                {
                    ReturnDegerString = tb_Giris.Text;
                }
                else if (ReturnTip == "Double")
                {
                    ReturnDegerDouble = Convert.ToDouble(tb_Giris.Text);
                }
                else if (ReturnTip == "Int")
                {
                    ReturnDegerInt = Convert.ToInt32(tb_Giris.Text);
                }
                //OK olarak işaretliyoruz ki sorun çıkmadan yaptığımızı bilsin bir önceki pencere
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch
            {//Cık cık cık. Niye sayı yerine adını soyadını girersin ki :(
                MessageBox.Show("Hatalı Giriş!");
            }
        }

        private void btn_iptal_Click(object sender, EventArgs e)
        {   //İptal edilmişse gerek yok kapa gitsin. OK diyelim ki hata vermesin.
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
