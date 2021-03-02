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
    public partial class KitapListe : Form
    {
        DataTable Veriler;
        public KitapListe()
        {
            InitializeComponent();
        }

        //Kitap listesini DataGridView'da güncellemek istediğimizde
        private void ListeGuncelle()
        {
            dgv_kitaplar.Rows.Clear();              //Önce DGV'yi temizliyoruz
            foreach (DataRow row in Veriler.Rows)   //Sonra gelen Veriler DataTable'ını okuyor ve
            {                                       //Her bir satıra denk gelecek veriyi DGV'ye ekliyoruz.
                dgv_kitaplar.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7]);
            }
        }

        //Aşağıdaki dört fonksiyon, TextBox PlaceHolder'ı için bulunmakta.
        //Placeholder, textbox boş iken textbox'a ne yazılabileceğini belirtmek için bulunmakta.

        //Kitap no'ya göre arama TextBox'ı Focus kazandığında
        private void tb_noAra_Enter(object sender, EventArgs e)
        {
            if (tb_noAra.Text == "Kitap No Ara...") //Eğer varsayılan yazı ise
            {
                tb_noAra.Text = "";                 //Yazı kaybolsun
                tb_noAra.ForeColor = Color.Black;   //Yazı rengi siyah olsun
            }
        }

        //Kitap no'ya göre arama TextBox'ı Focus kaybettiğinde
        private void tb_noAra_Leave(object sender, EventArgs e)
        {
            if (tb_noAra.Text == "")                //Eğer textbox boş ise
            {
                tb_noAra.Text = "Kitap No Ara...";  //Varsayılan yazıyı yerleştir(Placeholder)
                tb_noAra.ForeColor = Color.DarkGray;//Yazıyı gri yap
            }
        }

        //Kitap adına göre arama TextBox'ı Focus kazandığında
        private void tb_adAra_Enter(object sender, EventArgs e)
        {
            if (tb_adAra.Text == "Ada Göre Ara...") //Eğer varsayılan yazı ise
            {
                tb_adAra.Text = "";                 //Yazı kaybolsun
                tb_adAra.ForeColor = Color.Black;   //Yazı rengi siyah olsun
            }
        }

        //Kitap adına göre arama TextBox'ı Focus kaybettiğinde
        private void tb_adAra_Leave(object sender, EventArgs e)
        {
            if (tb_adAra.Text == "")                //Eğer textbox boş ise
            {
                tb_adAra.Text = "Ada Göre Ara...";  //Varsayılan yazıyı yerleştir(Placeholder)
                tb_adAra.ForeColor = Color.DarkGray;//Yazıyı gri yap
            }
        }

        //Form yüklendiğinde/Açıldığında
        private void KitapListe_Load(object sender, EventArgs e)
        {
            //Butonlarımız ikon türü olduğu için açıklayıcı tooltip'lere ihtiyacımız var
            toolTip.SetToolTip(btn_kitapEkle, "Kitap Ekle");//Gerekli nesneye yazdığımız Tooltip'i ekle
            toolTip.SetToolTip(btn_kitapSil, "Seçili Kitabı Sil");
            toolTip.SetToolTip(btn_kitapDuzenle, "Seçili Kitabı Düzenle");
            toolTip.SetToolTip(btn_kitapEmanet, "Seçili Kitaba Ait Emanetleri Gör");
            toolTip.SetToolTip(btn_noAra, "Kitap Numarasına Göre Ara");
            toolTip.SetToolTip(btn_adAra, "Kitap Adına Göre Ara");
            toolTip.SetToolTip(btn_grafik, "Kitap Grafiğini Aç");

            //Burada PlaceHolder için yazı ve renk yerleştirmesi yapıyoruz Textbox'larımıza
            tb_noAra.Text = "Kitap No Ara...";
            tb_noAra.ForeColor = Color.DarkGray;
            tb_adAra.Text = "Ada Göre Ara...";
            tb_adAra.ForeColor = Color.DarkGray;

            Veriler = Business.Kitap.KitapListele();    //Öncelikle kitap listesini veritabanından çek
            ListeGuncelle();                            //Sonra DataGridView'i güncelle
        }

        // Eğer kitap numarasına göre listede arama yapacaksak, bu butona tıklıyoruz
        private void btn_noAra_Click(object sender, EventArgs e)
        {
            //Bu işlemde birkaç sebepten dolayı hata verebilir, try kullanalım
            try
            {
                int test = Convert.ToInt32(tb_noAra.Text);                  //Önce sayıya çevir, sayı mı değil mi bakmak için
                Veriler = Business.Kitap.KitapListele(tb_noAra.Text, true); //KitapListele fonksiyonuna sayıyı ve sayı girişi belirtecini gönder
                ListeGuncelle();                                            //Listeyi güncelle
            }
            catch (Exception err)   //Eğer gönderdiği metin bir sayıya dönüştürülemezse
            {                       //Bu yazı boş ise veya Placeholder yazısı DEĞİL ise
                if (tb_noAra.Text != "" && tb_noAra.Text != "Kitap No Ara...")
                {                   //Hata ver. Metin aratılamaz.
                    MessageBox.Show("Lütfen no ile aramaya bir sayı giriniz veya boş bırakınız!");
                }
                else                //Eğer Placeholder veya boş ise, bütün listeyi döndür.
                {
                    Veriler = Business.Kitap.KitapListele();
                    ListeGuncelle();//Ve elbet güncelle
                }
            }
        }

        //Eğer ad ile arama tetiklenmişse ya hepsini döndür ya da gerekli ismi
        private void btn_adAra_Click(object sender, EventArgs e)
        {
            //Eğer Placeholder veya boş değil ise arama işlemini gerçekleştir.
            if (tb_adAra.Text != "" && tb_adAra.Text != "Ada Göre Ara..." )
            {
                Veriler = Business.Kitap.KitapListele(tb_adAra.Text, false);
            }
            else
            {                   //Eğer Placeholder veya boş ise, bütün listeyi döndür.
                Veriler = Business.Kitap.KitapListele();
            }
            
            ListeGuncelle();    //Güncellemeyi unutma.
        }

        //Eğer kitap eklemek istersek bu butona tıklıyoruz.
        private void btn_kitapEkle_Click(object sender, EventArgs e)
        {
            //Yeni kitap penceresi gerekli bütün bilgileri alacak, ekleme emrini gönderecek ve
            //Ve işlem bittiğinde listeyi güncelletecek
            Presentation.KitapPencere kitapEkle = new Presentation.KitapPencere();  //Pencereyi oluştur
            DialogResult Sonuc = kitapEkle.ShowDialog();    //Geriye veri döndürmek için dialog olarak aç
            if (Sonuc == DialogResult.OK)                   //Eğer gelen veri OK ise öğrenci eklenmiş veya başka bir işlem tamam demektir.
            {
                Veriler = Business.Kitap.KitapListele();    //Listeleme işlemi
                ListeGuncelle();
            }
        }

        //Eğer kitap güncellemek istersek bu butona tıklıyoruz.
        private void btn_kitapDuzenle_Click(object sender, EventArgs e)
        {
            if (dgv_kitaplar.SelectedCells.Count == 1)  //Kullanıcının seçim sayısına bakıyoruz. Tek bir hücre seçmeli.
            {
                int RowIndex = dgv_kitaplar.SelectedCells[0].RowIndex;          //Seçili hücrenin Index'i. O satırı almak için.
                int kitapNo = (int)dgv_kitaplar.Rows[RowIndex].Cells[0].Value;  //Aldığımız index satırının 0. hücresi öğrenci no'yu tutar. Onu alalım.
                Presentation.KitapPencere kitapGuncelle = new Presentation.KitapPencere(kitapNo);//Güncelleme pencere oluşturma. Kitap no göndermemiz yeterli

                DialogResult Sonuc = kitapGuncelle.ShowDialog();                //Arka pencerede işlem yapamaması için Dialog olarak
                Veriler = Business.Kitap.KitapListele();                        //Kitap listele, eğer güncellenmişse diye
                ListeGuncelle();
            }
            else //Eğer sadece bir hücre seçilmemişse hata ver
            {
                MessageBox.Show("Lütfen sadece bir tane hücre seçiniz!");
            }
        }

        //Seçili kitabı silme işlemi
        private void btn_kitapSil_Click(object sender, EventArgs e)
        {
            if (dgv_kitaplar.SelectedCells.Count == 1)                          //Gerçekten bir hücre mi seçili?
            {
                int RowIndex = dgv_kitaplar.SelectedCells[0].RowIndex;          //Seçili gücrenin satır index'ini bul
                int kitapNo = (int)dgv_kitaplar.Rows[RowIndex].Cells[0].Value;  //Index'in 0. sütununu bul, kitap no için
                //Burada Evet/Hayır seçenekli bir MessageBox gönderiyoruz, eğer silmek istiyorsa Evet'i seçecek.
                DialogResult Sonuc = MessageBox.Show("Bu kitabı silmek istediğinize emin misiniz?", "Sil", MessageBoxButtons.YesNo);

                //Eğer evet'i seçmişse
                if (Sonuc == DialogResult.Yes)
                {
                    Business.Kitap.KitapSil(kitapNo);       //Kitap sil seçeneğini çalıştır

                    Veriler = Business.Kitap.KitapListele();//Listeyi güncelle
                    ListeGuncelle();
                }
            }
            else//Eğer sadece bir hücre seçilmemişse hata ver
            {
                MessageBox.Show("Lütfen sadece bir tane hücre seçiniz!");
            }
        }

        //Seçili kitaba ait emanetleri gösterme butonu
        private void btn_kitapEmanet_Click(object sender, EventArgs e)
        {
            if (dgv_kitaplar.SelectedCells.Count == 1)                      //Gerçekten bir hücre mi seçili?
            {
                int RowIndex = dgv_kitaplar.SelectedCells[0].RowIndex;      //Seçili hücrenin satır index'ini bul
                int ktpNo = (int)dgv_kitaplar.Rows[RowIndex].Cells[0].Value;//Index'in 0. sütununu bul, kitap no için
                //Burada emanet listesini kitap numarası ile çağırıyoruz. Böylece sadece seçili kitap için işlemler yapabileceğiz.
                Presentation.EmanetListe emanetListele = new Presentation.EmanetListe(ktpNo, false);
                DialogResult Sonuc = emanetListele.ShowDialog();            //Emanet listesi kapanmadan burada işlem yapmaması için ShowDialog

                Veriler = Business.Kitap.KitapListele();                    //Vee listele
                ListeGuncelle();
            }
            else
            {//Eğer sadece bir hücre seçilmemişse hata ver
                MessageBox.Show("Lütfen sadece bir tane hücre seçiniz!");
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
