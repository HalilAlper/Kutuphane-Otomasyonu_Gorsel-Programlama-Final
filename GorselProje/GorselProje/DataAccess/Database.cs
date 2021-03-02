using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;    //OleDbConnection, OleDbCommand gibi veritabanı nesneleri
using System.Data;          //DataSet, DataTable gibi veri nesneleri

namespace GorselProje.DataAccess
{
    class Database
    {
        //Gerekli bağlantı nesnesini, OleDbConnection nesnesine bir bağlantı yolu sağlayarak oluşturuyoruz
        static OleDbConnection VeriBag = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=GorselProje.accdb");

        //Fonksiyonlarımızın her biri bir OleDbCommand parametresi alıyor.
        //Bu parametre, bir komut. Business katmanımızda oluşturulup içine parametre dolduruluyor

        //Gerekli listeleme/okuma işlemlerimiz için. Okunan veriyi geri döndürür.
        public static DataTable SelectSorgu(OleDbCommand Komut)
        {
            VeriBag.Open();                             //Bağlantı aç
            Komut.Connection = VeriBag;                 //Gelen komuta bağlantı ata
            DataTable Veri = new DataTable();           //Veritabanından gelen listeyi aktaracağımız nesne
            OleDbDataReader Okuyucu;                    //Veritabanını okuyacak nesne

            //ExecuteReader ile Select sorgularıyla istediğimiz bir liste edinebiliyoruz.
            Okuyucu = Komut.ExecuteReader();    
            Veri.Load(Okuyucu);                         //Okuyucu nesnemizin içindeki bilgiyi DataTable'ımıza aktarıyoruz
            VeriBag.Close();                            //Bağlantı kapat
            return Veri;                                //İstenilen veriyi döndür
        }

        //Gerekli güncelleme işlemlerimiz için. Değiştirilen satır sayısını döndürür.
        public static int UpdateSorgu(OleDbCommand Komut)
        {
            VeriBag.Open();                             //Bağlantıyı aç
            Komut.Connection = VeriBag;                 //Gelen komuta bağlantı ata

            //ExecuteNonQuery ile Update ve Delete sorgularını çalıştırabilir, kaç satırın değiştirildiğini görebiliriz.
            int GeriDon = Komut.ExecuteNonQuery();  
            VeriBag.Close();                            //Bağlantı kapat
            return GeriDon;                             //İstenilen veriyi döndür
        }

        //Gerekli ekleme işlemlerimiz için. Eklenen satırın kimlik sütun verisini döndürür.
        public static int InsertSorgu(OleDbCommand Komut)
        {
            VeriBag.Open();                             //Bağlantı aç
            Komut.Connection = VeriBag;                 //Gelen komuta bağlantı ata

            //Update sorgumuzun içerisinde yaptığımız tanımın aksine burada gelen veriyi karşılamak amaçlı aldık.
            int GeriDon = Komut.ExecuteNonQuery();      //Ekleme işlemimiz, veritabanına

            //Eklenen satırın kimlik sütun verisini bulmalıyız. Bu birçok farklı şekilde ihtiyacımız olabilecek bir veri.
            //Bunu bizzat OUTPUT SQL komutu ile denedim ancak görünüşe bakılırsa Access desteklemiyor.
            string Sorgu = "Select @@Identity";         //En son eklenen verinin kimlik sütun verisini bulmaya yarayan sorgu
            Komut = new OleDbCommand(Sorgu, VeriBag);   //Yeni komut oluşturalım, bağlantı ile

            //ExecuteScalar metodu bize sorgu sonucu oluşan tablonun İLK satırının İLK sütununu getirir.
            GeriDon = (int)Komut.ExecuteScalar();
            VeriBag.Close();                            //Bağlantı kapat
            return GeriDon;                             //Satır kimlik sütun verisini geri döndür.
        }

        //Gerekli silme işlemlerimiz için
        public static void DeleteSorgu(OleDbCommand Komut)
        {
            VeriBag.Open();                             //Bağlantı aç
            Komut.Connection = VeriBag;                 //Gelen komuta bağlantı ata

            //ExecuteNonQuery ile Update ve Delete sorgularını çalıştırabilir, kaç satırın değiştirildiğini görebiliriz.
            int GeriDon = Komut.ExecuteNonQuery();      
            VeriBag.Close();                            //Bağlantı kapat
        }
    }
}
