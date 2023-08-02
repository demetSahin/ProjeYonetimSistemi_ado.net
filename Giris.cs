using pys.Context;
using pys.Entity;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace pys
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        private void Giris_Load(object sender, EventArgs e)
        {
            if (!File.Exists("MyDatabase.sqlite"))
            {
                SQLiteConnection.CreateFile("MyDatabase.sqlite"); //MyDatabase isimli veritabanı dosyası oluşturuluyor.

                //Giris isimli tablo oluşturulması için SQLite komut texti. 
                string sqlGiris = @"CREATE TABLE Giris ( 
                               KullaniciAdi     TEXT      NOT NULL,
                               Parola           TEXT       NOT NULL
                            );";

                //SQLite dosyası ile program arasında bağlantı kurulması için.
                SQLiteConnection con = new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;");

                con.Open(); //bağlantı açılması için.

                /*SQLite komutu oluşturulması için.
                Yukarıdaki sqlGiris stringi ve bağlantı nesnesi argüman olarak constructor'a gönderiliyor.*/
                SQLiteCommand cmd = new SQLiteCommand(sqlGiris, con);

                cmd.ExecuteNonQuery(); //Komut çalıştırılıyor.Giris isimli tablo oluşturuldu.

                //Burdan sonraki kodlar, oluşturulan tabloya kayıt eklemek için.
                cmd = new SQLiteCommand
                {
                    Connection = con,
                    CommandText = "insert into Giris (KullaniciAdi, Parola) values ('admin','12345')"
                };
                cmd.ExecuteNonQuery();
                cmd.CommandText = "insert into Giris (KullaniciAdi, Parola) values ('asistan','54321')";
                cmd.ExecuteNonQuery();

                con.Close();//bağlantının kapatılması için.
            }

            //DB'leri oluşturmak için MyContext sınıfından bir DB nesnesi yaratılır. 
            
            MyContext veritabani = new MyContext();

            if (!veritabani.Database.Exists()) //EF veritabanı mevcut değilse oluşturulur. Mevcutsa yenisi oluşturulmaz.
            {
                //veritabani.Database.Create();

                //5 adet kişi veritabanına ekleniyor :
                Kisi CanYuksel = new Kisi
                {
                    ID = 1,
                    adi = "Can",
                    soyadi = "Yüksel",
                    cinsiyet = "Erkek",
                    eposta = "can@gmail.com",
                    telefon = "2322345678",
                    dogumTarihi = DateTime.ParseExact("24/12/1994",
                    "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    adres = "İzmir",
                    isTecrubesi = 6,
                };
                veritabani.Kisiler.Add(CanYuksel); //Can Yüksel Kisiler tablosuna eklendi.
                veritabani.SaveChanges();

                Kisi SedaBadem = new Kisi
                {
                    ID = 2,
                    adi = "Seda",
                    soyadi = "Badem",
                    cinsiyet = "Kadın",
                    eposta = "seda@outlook.com",
                    telefon = "2327654321",
                    dogumTarihi = DateTime.ParseExact("03/04/1988",
                    "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    adres = "İstanbul",
                    isTecrubesi = 10,
                };
                veritabani.Kisiler.Add(SedaBadem);
                veritabani.SaveChanges();

                Kisi YaprakCinar = new Kisi
                {
                    ID = 3,
                    adi = "Yaprak",
                    soyadi = "Çınar",
                    cinsiyet = "Kadın",
                    eposta = "yaprak@gmail.com",
                    telefon = "2325098765",
                    dogumTarihi = DateTime.ParseExact("14/10/1995", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    adres = "Londra",
                    isTecrubesi = 5,
                };
                veritabani.Kisiler.Add(YaprakCinar);
                veritabani.SaveChanges();

                Kisi UrsulaLeGuin = new Kisi
                {
                    ID = 4,
                    adi = "Ursula",
                    soyadi = "LeGuin",
                    cinsiyet = "Kadın",
                    eposta = "ursula@gmail.com",
                    telefon = "2328973410",
                    dogumTarihi = DateTime.ParseExact("21/10/1979", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    adres = "Kaliforniya,ABD",
                    isTecrubesi = 50,
                };
                veritabani.Kisiler.Add(UrsulaLeGuin);
                veritabani.SaveChanges();

                Kisi HalideEdip = new Kisi
                {
                    ID = 5,
                    adi = "Halide",
                    soyadi = "Edip",
                    cinsiyet = "Kadın",
                    eposta = "halide@gmail.com",
                    telefon = "2322349021",
                    dogumTarihi = DateTime.ParseExact("13/10/1902", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    adres = "Bursa",
                    isTecrubesi = 15,
                };
                veritabani.Kisiler.Add(HalideEdip);
                veritabani.SaveChanges();

                ProjeEkibi ProjeEkibi1 = new ProjeEkibi { 
                    ID = 1,
                    projeEkibi = new List<Kisi> { CanYuksel, SedaBadem, HalideEdip }
                };
                veritabani.Ekipler.Add(ProjeEkibi1);  //ProjeEkibi1 Ekipler tablosuna eklendi.
                veritabani.SaveChanges();

                ProjeEkibi ProjeEkibi2 = new ProjeEkibi
                {
                    ID = 2,
                    projeEkibi = new List<Kisi> { YaprakCinar, SedaBadem, UrsulaLeGuin }
                };
                veritabani.Ekipler.Add(ProjeEkibi2);
                veritabani.SaveChanges();

                ProjeEkibi ProjeEkibi3 = new ProjeEkibi
                {
                    ID = 3,
                    projeEkibi = new List<Kisi> { CanYuksel, YaprakCinar, HalideEdip }
                };
                veritabani.Ekipler.Add(ProjeEkibi3);
                veritabani.SaveChanges();

                ProjeEkibi ProjeEkibi4 = new ProjeEkibi
                {
                    ID = 4,
                    projeEkibi = new List<Kisi> { SedaBadem, UrsulaLeGuin, HalideEdip }
                };
                veritabani.Ekipler.Add(ProjeEkibi4);
                veritabani.SaveChanges();

                ProjeEkibi ProjeEkibi5 = new ProjeEkibi
                {
                    ID = 5,
                    projeEkibi = new List<Kisi> { YaprakCinar, UrsulaLeGuin, HalideEdip }
                };
                veritabani.Ekipler.Add(ProjeEkibi5);
                veritabani.SaveChanges();

                Proje Proje1 = new Proje
                {
                    ID = 1,
                    projeAdi = "Proje1",
                    stratejikEtki = "Yüksek",
                    projeNo = "PRJ1",
                    projeYurutucusu = YaprakCinar,
                    amac = "Yeni ürün tasarımı",
                    problemTanimi = "Düşük maliyet",
                    kapsam = "İç pazar",
                    kayitTarihi = DateTime.ParseExact("12/08/2022", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    projeBaslangici = DateTime.ParseExact("19/08/2022", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    projeBitisi = DateTime.ParseExact("29/12/2022", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    tahminiBaslangic = DateTime.ParseExact("19/08/2022", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    tahminiBitis = DateTime.ParseExact("22/12/2022", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    projeDurumu = Durum.DevamEdiyor,
                    parasalGetiri = 50000,
                    getiriTipi = GetiriTipi.Aylik,
                    projeEkibi = ProjeEkibi4,
                    document = "",
                    projeTipi = ProjeTipi.KOSGEB,
                    kmTaslari = "Gereksinim Belirlenmesi, Görev dağılımı, Araştırma, İmplementasyon, Demo, Test",
                };
                veritabani.Projeler.Add(Proje1);   //Proje1 Projeler tablosuna eklendi.
                veritabani.SaveChanges();

                Proje Proje2 = new Proje
                {
                    ID = 2,
                    projeAdi = "Proje2",
                    stratejikEtki = "Düşük",
                    projeNo = "PRJ2",
                    projeYurutucusu = CanYuksel,
                    amac = "Arge",
                    problemTanimi = "Kalite yükseltme",
                    kapsam = "Dış pazar",
                    kayitTarihi = DateTime.ParseExact("18/06/2022", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    projeBaslangici = DateTime.ParseExact("20/06/2022", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    projeBitisi = DateTime.ParseExact("24/06/2022", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    tahminiBaslangic = DateTime.ParseExact("19/08/2022", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    tahminiBitis = DateTime.ParseExact("25/11/2022", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    projeDurumu = Durum.DevamEdiyor,
                    parasalGetiri = 5000,
                    getiriTipi = GetiriTipi.Yillik,
                    projeEkibi = ProjeEkibi5,
                    document = "",
                    projeTipi = ProjeTipi.Tubitak,
                    kmTaslari = "Yurtdışı müşterileriyle görüşülmesi, Piyasa araştırması, Gereksinim belirlenmesi, İmplementasyon, Demo, Test",
                };
                veritabani.Projeler.Add(Proje2);
                veritabani.SaveChanges();

                //int[] projeEkibi_3 = new int[2];
                //projeEkibi_3[0] = 1;
                //projeEkibi_3[1] = 3;

                //string[] document_3 = new string[1];

                //string[] kmTaslari_3 = new string[3];
                //kmTaslari_3[0] = "Yabancı ülkelerdeki işçilik maliyetlerinin araştırılması";
                //kmTaslari_3[1] = "Uygun ülkenin seçilmesi";
                //kmTaslari_3[2] = "Fabrika sayısının artırılması";

                Proje Proje3 = new Proje
                {
                    ID = 3,
                    projeAdi = "Proje3",
                    stratejikEtki = "Yüksek",
                    projeNo = "PRJ3",
                    projeYurutucusu = SedaBadem,
                    amac = "Düşük lojistik giderleri",
                    problemTanimi = "Fabrika sayıları",
                    kapsam = "Dünya çapında",
                    kayitTarihi = DateTime.ParseExact("18/06/2022", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    projeBaslangici = DateTime.ParseExact("20/06/2022", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    projeBitisi = DateTime.ParseExact("24/06/2022", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    tahminiBaslangic = DateTime.ParseExact("19/08/2022", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    tahminiBitis = DateTime.ParseExact("25/11/2022", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    projeDurumu = Durum.DevamEdiyor,
                    parasalGetiri = 5000,
                    getiriTipi = GetiriTipi.Gunluk,
                    projeEkibi = ProjeEkibi3,
                    document = "",
                    projeTipi = ProjeTipi.Yurtdisi,
                    kmTaslari = "Yabancı ülkelerdeki işçilik maliyetlerinin araştırılması,Uygun ülkenin seçilmesi,Fabrika sayısının artırılması",
                };
                veritabani.Projeler.Add(Proje3);
                veritabani.SaveChanges();

                //Proje Proje4 = new Proje
                //{
                //    ID = 4,
                //    projeAdi = "Proje4",
                //    stratejikEtki = "Yüksek",
                //    projeNo = "PRJ3",
                //    projeYurutucusu = SedaBadem,
                //    amac = "Düşük lojistik giderleri",
                //    problemTanimi = "Fabrika sayıları",
                //    kapsam = "Dünya çapında",
                //    kayitTarihi = DateTime.ParseExact("18/06/2022", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                //    projeBaslangici = DateTime.ParseExact("20/06/2022", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                //    projeBitisi = DateTime.ParseExact("24/06/2022", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                //    tahminiBaslangic = DateTime.ParseExact("19/08/2022", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                //    tahminiBitis = DateTime.ParseExact("25/11/2022", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                //    projeDurumu = Durum.DevamEdiyor,
                //    parasalGetiri = 5000,
                //    getiriTipi = GetiriTipi.Gunluk,
                //    projeEkibi = ProjeEkibi3,
                //    document = "",
                //    projeTipi = ProjeTipi.Yurtdisi,
                //    kmTaslari = "Yabancı ülkelerdeki işçilik maliyetlerinin araştırılması,Uygun ülkenin seçilmesi,Fabrika sayısının artırılması",
                //};
                //veritabani.Projeler.Add(Proje4);
                //veritabani.SaveChanges();
            }


        }

        private void ButtonGiris_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tbGirisKullaniciAdi.Text) && 
                String.IsNullOrWhiteSpace(tbGirisParola.Text))
            {
                MessageBox.Show("Lütfen kullanıcı adını ve parolayı giriniz.", "Giriş Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.IsNullOrWhiteSpace(tbGirisKullaniciAdi.Text))
            {
                MessageBox.Show("Lütfen kullanıcı adını giriniz.", "Giriş Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else if (String.IsNullOrWhiteSpace(tbGirisParola.Text))
            {
                MessageBox.Show("Lütfen parolayı giriniz.", "Giriş Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                SQLiteConnection con = new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;");
                SQLiteCommand cmd = new SQLiteCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "select * from Giris where KullaniciAdi='" + tbGirisKullaniciAdi.Text + "' and Parola='" + tbGirisParola.Text + "'";
                cmd.ExecuteNonQuery();
                SQLiteDataReader reader = cmd.ExecuteReader(); //Veritabanından kayıt okunuyor mu kontrolü için. 
                if (reader.Read() == true)
                {
                    reader.Close(); //Veritabanının başka bir form üzerinden yeniden erişilebilir olması için.
                    this.Hide(); //Girilen kullanıcı adı ve parola eşleştiğinde Girişi formunu kapatmak için.
                    AnaSayfa anaSayfa = new AnaSayfa();
                    anaSayfa.Show();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı ya da şifre yanlış. Lütfen yeniden deneyiniz.", "Giriş Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Giris_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0); //Sistemi kapatmak için.
        }
    }
}
