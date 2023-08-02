using pys.Context;
using pys.Entity;
using System;
using System.Data.SQLite;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace pys
{
    public partial class KisiOlustur : Form
    {
        private AnaSayfa ana;
        private Kisi kisi;

        public KisiOlustur(AnaSayfa anaSayfa, Kisi kisi)
        {
            InitializeComponent();
            ana = anaSayfa;
            this.kisi = kisi;
        }

        String TarihiDuzelt(string tarih)
        {
            //tarih = dtpKayitTarihi.Value.ToShortDateString().Replace(".", "/").Replace(" 00:00:00", "");
            int index = tarih.IndexOf("/");
            if (index == 1) tarih = "0" + tarih;
            return tarih;
        }

        private void btnKisiOlustur_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tbAdi.Text)
                || String.IsNullOrWhiteSpace(tbSoyadi.Text) 
                || String.IsNullOrWhiteSpace(tbEposta.Text) 
                || String.IsNullOrWhiteSpace(mtbTelefon.Text) 
                || String.IsNullOrWhiteSpace(mtbDogumTarihi.Text) 
                || String.IsNullOrWhiteSpace(rtbAdres.Text) 
                ||(rbKadin.Checked == false && rbErkek.Checked == false))
            {
                if (kisi != null)
                {
                    MessageBox.Show("Lütfen bütün bilgileri giriniz.", "Kişi Güncelleme Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Lütfen bütün bilgileri giriniz.", "Kişi Oluşturma Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else
            {
                string cinsiyet = rbKadin.Checked == true ? "Kadın" : "Erkek"; //hangi radiobutton'un seçili olduğunu belirlemek için.
                MyContext veritabani = new MyContext();

                if (kisi != null) //gelen form boş değilse kişi güncelleme yapılıyor.
                {
                    Kisi kisi_ = veritabani.Kisiler.FirstOrDefault(k => k.ID == kisi.ID);
                    kisi_.adi = tbAdi.Text;
                    kisi_.soyadi = tbSoyadi.Text;
                    kisi_.cinsiyet = cinsiyet;
                    kisi_.eposta = tbEposta.Text;
                    kisi_.telefon = mtbTelefon.Text;
                    kisi_.dogumTarihi = DateTime.ParseExact(TarihiDuzelt(mtbDogumTarihi.Text.Replace(".", "/")),
                                        "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    kisi_.adres = rtbAdres.Text;
                    kisi_.isTecrubesi = double.Parse(nudIsTecrubesi.Text);
                }
                else
                {
                    veritabani.Kisiler.Add(new Kisi
                    {
                        adi = tbAdi.Text,
                        soyadi = tbSoyadi.Text,
                        cinsiyet = cinsiyet,
                        eposta = tbEposta.Text,
                        telefon = mtbTelefon.Text,
                        dogumTarihi = DateTime.ParseExact(TarihiDuzelt(mtbDogumTarihi.Text.Replace(".", "/").Replace(" 00:00:00", "")),
                                        "dd/MM/yyyy", CultureInfo.InvariantCulture),
                        adres = rtbAdres.Text,
                        isTecrubesi = double.Parse(nudIsTecrubesi.Text),
                    });
                    
                }

                veritabani.SaveChanges();

                ana.GetKisiler();

                if (kisi != null) //Success mesajı için kontrol.
                {
                    MessageBox.Show("Kişi başarıyla güncellendi.", "Kişi Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Kişi başarıyla oluşturuldu.", "Kişi Oluşturma", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.Close(); //KisiOlustur veya Güncelle formlarını kapatmak için.
            }
        }

        private void KisiOlustur_Load(object sender, EventArgs e)
        {
            if (kisi != null) //gelen form boş değilse açılan formdaki bilgiler dolduruluyor.
            {
                //Aşağıdaki kodlar vize projesine aittir.

                tbAdi.Text = kisi.adi;
                tbSoyadi.Text = kisi.soyadi;
                if (kisi.cinsiyet == "Kadın")
                {
                    rbKadin.Checked = true;
                }
                else
                {
                    rbErkek.Checked = true;
                }
                tbEposta.Text = kisi.eposta;
                mtbTelefon.Text = kisi.telefon;
                mtbDogumTarihi.Text = kisi.dogumTarihi.ToShortDateString();
                rtbAdres.Text = kisi.adres;
                nudIsTecrubesi.Value = (decimal)kisi.isTecrubesi;
                btnKisiOlustur.Text = "GÜNCELLE";
                Text = "Kişi Güncelle";
            }
        }
    }
}
