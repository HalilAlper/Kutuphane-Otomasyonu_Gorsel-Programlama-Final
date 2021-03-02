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
    public partial class OgrenciListe : Form
    {
        DataTable Veriler;
        public OgrenciListe()
        {
            InitializeComponent();
        }

        //Öğrenci listesini DataGridView'da güncellemek istediğimizde
        private void ListeGuncelle()
        {
            dgv_ogrenciler.Rows.Clear();            //Önce DGV'yi temizliyoruz
            foreach (DataRow row in Veriler.Rows)   //Sonra gelen Veriler DataTable'ını okuyor ve
            {                                       //Her bir satıra denk gelecek veriyi DGV'ye ekliyoruz.
                dgv_ogrenciler.Rows.Add(row[0], row[1], row[2], row[3], row[4]);
            }
        }

        //Aşağıdaki dört fonksiyon, TextBox PlaceHolder'ı için bulunmakta.
        //Placeholder, textbox boş iken textbox'a ne yazılabileceğini belirtmek için bulunmakta.

        //Öğrenciyi no'ya göre arama TextBox'ı Focus kazandığında
        private void tb_noAra_Enter(object sender, EventArgs e)
        {
            if (tb_noAra.Text == "Öğrenci No Ara...")   //Eğer varsayılan yazı ise
            {
                tb_noAra.Text = "";                     //Yazı kaybolsun
                tb_noAra.ForeColor = Color.Black;       //Yazı rengi siyah olsun
            }
        }

        //Öğrenciyi no'ya göre arama TextBox'ı Focus kaybettiğinde
        private void tb_noAra_Leave(object sender, EventArgs e)
        {
            if (tb_noAra.Text == "")                    //Eğer textbox boş ise
            {
                tb_noAra.Text = "Öğrenci No Ara...";    //Varsayılan yazıyı yerleştir(Placeholder)
                tb_noAra.ForeColor = Color.DarkGray;    //Yazıyı gri yap
            }
        }

        //Öğrenciyi ada soyada göre arama TextBox'ı Focus kazandığında
        private void tb_adSoyadAra_Enter(object sender, EventArgs e)
        {
            if (tb_adSoyadAra.Text == "Ad Soyad Ara...")//Eğer varsayılan yazı ise
            {
                tb_adSoyadAra.Text = "";                //Yazı kaybolsun
                tb_adSoyadAra.ForeColor = Color.Black;  //Yazı rengi siyah olsun
            }
        }

        //Öğrenciyi ada soyada göre arama TextBox'ı Focus kaybettiğinde
        private void tb_adSoyadAra_Leave(object sender, EventArgs e)
        {
            if (tb_adSoyadAra.Text == "")               //Eğer textbox boş ise
            {
                tb_adSoyadAra.Text = "Ad Soyad Ara..."; //Varsayılan yazıyı yerleştir(Placeholder)
                tb_adSoyadAra.ForeColor = Color.DarkGray;//Yazıyı gri yap
            }
        }

        //Form yüklendiğinde/Açıldığında
        private void OgrenciListe_Load(object sender, EventArgs e)
        {
            //Butonlarımız ikon türü olduğu için açıklayıcı tooltip'lere ihtiyacımız var
            toolTip.SetToolTip(btn_ogrenciEkle, "Öğrenci Ekle"); //Gerekli nesneye yazdığımız Tooltip'i ekle
            toolTip.SetToolTip(btn_ogrenciSil, "Seçili Öğrenciyi Sil");
            toolTip.SetToolTip(btn_ogrenciDuzenle, "Seçili Öğrenciyi Düzenle");
            toolTip.SetToolTip(btn_ogrenciEmanet, "Seçili Öğrenciye Ait Emanetleri Gör");
            toolTip.SetToolTip(btn_noAra, "Öğrenci Numarasına Göre Ara");
            toolTip.SetToolTip(btn_adSoyadAra, "Öğrenci Ad Soyadına Göre Ara");

            //Burada PlaceHolder için yazı ve renk yerleştirmesi yapıyoruz Textbox'larımıza
            tb_noAra.Text = "Öğrenci No Ara...";
            tb_noAra.ForeColor = Color.DarkGray;
            tb_adSoyadAra.Text = "Ad Soyad Ara...";
            tb_adSoyadAra.ForeColor = Color.DarkGray;

            
            Veriler = Business.Ogrenci.OgrenciListele();    //Öncelikle öğrenci listesini veritabanından çek
            ListeGuncelle();                                //Sonra DataGridView'i güncelle
        }

        // Eğer öğrenci numarasına göre listede arama yapacaksak, bu butona tıklıyoruz
        private void btn_noAra_Click(object sender, EventArgs e)
        {
            //Bu işlemde birkaç sebepten dolayı hata verebilir, try kullanalım
            try
            {
                int test = Convert.ToInt32(tb_noAra.Text);                      //Önce sayıya çevir, sayı mı değil mi bakmak için
                Veriler = Business.Ogrenci.OgrenciListele(tb_noAra.Text, true); //OgrenciListele fonksiyonuna sayıyı ve sayı girişi belirtecini gönder
                ListeGuncelle();                                                //Listeyi güncelle
            }
            catch (Exception err)   //Eğer gönderdiği metin bir sayıya dönüştürülemezse
            {                       //Bu yazı boş ise veya Placeholder yazısı DEĞİL ise
                if (tb_noAra.Text != "" && tb_noAra.Text != "Öğrenci No Ara...")
                {                   //Hata ver. Metin aratılamaz.
                    MessageBox.Show("Lütfen no ile aramaya bir sayı giriniz veya boş bırakınız!");
                }
                else                //Eğer Placeholder veya boş ise, bütün listeyi döndür.
                {
                    Veriler = Business.Ogrenci.OgrenciListele();
                    ListeGuncelle();//Ve elbet güncelle
                }
            }
        }

        //Eğer ad soyad ile arama tetiklenmişse ya hepsini döndür ya da gerekli ismi
        private void btn_adSoyadAra_Click(object sender, EventArgs e)
        {
            //Eğer Placeholder veya boş değil ise arama işlemini gerçekleştir.
            if (tb_adSoyadAra.Text != "" && tb_adSoyadAra.Text != "Ad Soyad Ara...")
            {
                Veriler = Business.Ogrenci.OgrenciListele(tb_adSoyadAra.Text, false);
            }
            else                    //Eğer Placeholder veya boş ise, bütün listeyi döndür.
            {
                Veriler = Business.Ogrenci.OgrenciListele();
            }
            
            ListeGuncelle();        //Güncellemeyi unutma.
        }

        //Eğer öğrenci eklemek istersek bu butona tıklıyoruz.
        private void btn_ogrenciEkle_Click(object sender, EventArgs e)
        {
            //Yeni öğrenci penceresi gerekli bütün bilgileri alacak, ekleme emrini gönderecek ve
            //Ve işlem bittiğinde listeyi güncelletecek
            Presentation.OgrenciPencere ogrenciEkle = new Presentation.OgrenciPencere(); //Pencereyi oluştur
            DialogResult Sonuc = ogrenciEkle.ShowDialog(); //Geriye veri döndürmek için dialog olarak aç
            if (Sonuc == DialogResult.OK) //Eğer gelen veri OK ise öğrenci eklenmiş veya başka bir işlem tamam demektir.
            {
                Veriler = Business.Ogrenci.OgrenciListele(); //Listeleme işlemi
                ListeGuncelle();
            }
        }

        //Eğer öğrenci güncellemek istersek bu butona tıklıyoruz.
        private void btn_ogrenciDuzenle_Click(object sender, EventArgs e)
        {
            if (dgv_ogrenciler.SelectedCells.Count == 1) //Kullanıcının seçim sayısına bakıyoruz. Tek bir hücre seçmeli.
            {
                int RowIndex = dgv_ogrenciler.SelectedCells[0].RowIndex;        //Seçili hücrenin Index'i. O satırı almak için.
                int ogrNo = (int)dgv_ogrenciler.Rows[RowIndex].Cells[0].Value;  //Aldığımız index satırının 0. hücresi öğrenci no'yu tutar. Onu alalım.
                Presentation.OgrenciPencere ogrenciGuncelle = new Presentation.OgrenciPencere(ogrNo);//Güncelleme pencere oluşturma. Öğrenci no göndermemiz yeterli

                DialogResult Sonuc = ogrenciGuncelle.ShowDialog();              //Arka pencerede işlem yapamaması için Dialog olarak
                Veriler = Business.Ogrenci.OgrenciListele();                    //Öğrencileri listele, eğer güncellenmişse diye
                ListeGuncelle();
            }
            else //Eğer sadece bir hücre seçilmemişse hata ver
            {
                MessageBox.Show("Lütfen sadece bir tane hücre seçiniz!");
            }
        }

        //Seçili öğrenciyi silme işlemi
        private void btn_ogrenciSil_Click(object sender, EventArgs e)
        {
            if (dgv_ogrenciler.SelectedCells.Count == 1)                        //Gerçekten bir hücre mi seçili?
            {
                int RowIndex = dgv_ogrenciler.SelectedCells[0].RowIndex;        //Seçili hücrenin satır index'ini bul
                int ogrNo = (int)dgv_ogrenciler.Rows[RowIndex].Cells[0].Value;  //Index'in 0. sütununu bul, öğrenci no için
                //Burada Evet/Hayır seçenekli bir MessageBox gönderiyoruz, eğer silmek istiyorsa Evet'i seçecek.
                DialogResult Sonuc = MessageBox.Show("Öğrenciyi silmek istediğinize emin misiniz?", "Sil", MessageBoxButtons.YesNo);

                //Eğer evet'i seçmişse
                if (Sonuc == DialogResult.Yes)
                {
                    Business.Ogrenci.OgrenciSil(ogrNo); //Öğrenci sil seçeneğini çalıştır

                    Veriler = Business.Ogrenci.OgrenciListele(); //Listeyi güncelle
                    ListeGuncelle();
                }
            }
            else//Eğer sadece bir hücre seçilmemişse hata ver
            {
                MessageBox.Show("Lütfen sadece bir tane hücre seçiniz!");
            }
        }

        //Seçili öğrenciye ait emanetleri gösterme butonu
        private void btn_ogrenciEmanet_Click(object sender, EventArgs e)
        {
            if (dgv_ogrenciler.SelectedCells.Count == 1)                        //Gerçekten bir hücre mi seçili?
            {
                int RowIndex = dgv_ogrenciler.SelectedCells[0].RowIndex;        //Seçili hücrenin satır index'ini bul
                int ogrNo = (int)dgv_ogrenciler.Rows[RowIndex].Cells[0].Value;  //Index'in 0. sütununu bul, öğrenci no için
                //Burada emanet listesini öğrenci numarası ile çağırıyoruz. Böylece sadece seçili öğrenci için işlemler yapabileceğiz.
                Presentation.EmanetListe emanetListele = new Presentation.EmanetListe(ogrNo, true);
                DialogResult Sonuc = emanetListele.ShowDialog();                //Emanet listesi kapanmadan burada işlem yapmaması için ShowDialog

                Veriler = Business.Ogrenci.OgrenciListele();                    //Vee listele
                ListeGuncelle();
            }
            else
            {//Eğer sadece bir hücre seçilmemişse hata ver
                MessageBox.Show("Lütfen sadece bir tane hücre seçiniz!");
            }
        }
    }
}
