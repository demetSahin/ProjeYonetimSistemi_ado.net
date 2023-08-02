using pys.Context;
using pys.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pys
{
    public partial class ProjeOlustur : Form
    {
        private AnaSayfa ana;
        private Proje proje;

        public ProjeOlustur(AnaSayfa anaSayfa, Proje proje)
        {
            InitializeComponent();
            ana = anaSayfa;
            this.proje = proje;

            //Proje durumu stringlerini, Durum enum sınıfından combobox'a yüklemek için
            cbProjeDurumu.DataSource = Enum.GetValues(typeof(Durum)).Cast<Enum>()
                .Select(value => new
                {
                    (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()),
                    typeof(DescriptionAttribute)) as DescriptionAttribute).Description,
                    value
                })
                .OrderBy(item => item.value)
                .ToList();

            //Getiri tipi stringlerini, GetiriTipi enum sınıfından combobox'a yüklemek için
            cbGetiriTipi.DataSource = Enum.GetValues(typeof(GetiriTipi)).Cast<Enum>()
                .Select(value => new
                {
                    (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()),
                    typeof(DescriptionAttribute)) as DescriptionAttribute).Description,
                    value
                })
                .OrderBy(item => item.value)
                .ToList();

            //Proje tipi stringlerini, ProjeTipi enum sınıfından combobox'a yüklemek için
            cbProjeTipi.DataSource = Enum.GetValues(typeof(ProjeTipi)).Cast<Enum>()
                .Select(value => new
                {
                    (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()),
                    typeof(DescriptionAttribute)) as DescriptionAttribute).Description,
                    value
                })
                .OrderBy(item => item.value)
                .ToList();

            if (this.proje != null)
            {
                //Aşağıdaki kodlar vize projesine aittir.

                tbProjeAdi.Text = proje.projeAdi;
                tbStratejikEtki.Text = proje.stratejikEtki;
                tbProjeNo.Text = proje.projeNo;
                //cbProjeYurutucusu.Text = proje.projeYurutucusu.adi;
                tbAmac.Text = proje.amac;
                tbProblemTanimi.Text = proje.problemTanimi;
                tbKapsam.Text = proje.kapsam;
                dtpKayitTarihi.Text = proje.kayitTarihi.ToShortDateString();
                dtpProjeBaslangici.Text = proje.projeBaslangici.ToShortDateString();
                dtpProjeBitisi.Text = proje.projeBitisi.ToShortDateString();
                dtpTahminiBaslangic.Text = proje.tahminiBaslangic.ToShortDateString();
                dtpTahminiBitis.Text = proje.tahminiBitis.ToShortDateString();
                tbParasalGetiri.Text = proje.parasalGetiri.ToString();
                buttonProjeEkle.Text = "GÜNCELLE";
                Text = "Proje Güncelle";

                cbProjeDurumu.Text = proje.projeDurumu.ToString();
                cbGetiriTipi.Text = proje.getiriTipi.ToString();
                cbProjeTipi.Text = proje.projeTipi.ToString();
            }
        }

        public void GetEkip() //CheckedListBox'a proje ekibini doldurmak için
        {
            MyContext kisiVeritabani = new MyContext();
            var items = from item in kisiVeritabani.Kisiler select item.adi + " " + item.soyadi;
            clbKisiler.Items.AddRange(items.ToArray());
            cbProjeYurutucusu.Items.AddRange(items.ToArray());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnKmTasiEkle_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tbKmTasiEkle.Text)) //textbox boş veya boşluk karakterinden oluşuyorsa
            {
                MessageBox.Show("Lütfen kilometre taşı bilgisini giriniz.", "Kilometre Taşı Ekleme Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                lbKmTaslari.Items.Add(tbKmTasiEkle.Text);//textbox'a girilen km taşı değerini listbox'a ekler.
                tbKmTasiEkle.Clear();//ekledikten sonra yeni kelime yazılabilsin diye textbox'taki metni temizliyor.
            }
        }

        private void btnKmTasiCikar_Click(object sender, EventArgs e)
        {
            if (lbKmTaslari.SelectedItem == null)
            {
                MessageBox.Show("Lütfen silinecek kilometre taşını seçiniz.", "Kilometre Taşı Silme Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                lbKmTaslari.Items.RemoveAt(lbKmTaslari.SelectedIndex); //Seçilen satırı belirleyip listbox'tan siliyor.                               
            }
        }

        private void btnDokumanEkle_Click(object sender, EventArgs e)
        {

        }

        private void btnProjeEkibiEkle_Click(object sender, EventArgs e)
        {
            KisiEkle kisiEkle = new KisiEkle();
            kisiEkle.ShowDialog();
        }

        String TarihiDuzelt(string tarih)
        {
            //tarih = dtpKayitTarihi.Value.ToShortDateString().Replace(".", "/").Replace(" 00:00:00", "");
            int index = tarih.IndexOf("/");
            if (index == 1) tarih = "0" + tarih;
            return tarih;
        }

        private void buttonProjeEkle_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tbProjeAdi.Text) || String.IsNullOrWhiteSpace(tbStratejikEtki.Text) ||
                String.IsNullOrWhiteSpace(tbProjeNo.Text) || String.IsNullOrWhiteSpace(cbProjeYurutucusu.Text) ||
                String.IsNullOrWhiteSpace(tbAmac.Text) || String.IsNullOrWhiteSpace(tbProblemTanimi.Text) ||
                String.IsNullOrWhiteSpace(tbKapsam.Text) || cbProjeDurumu.Text =="Seçiniz" ||
                String.IsNullOrWhiteSpace(tbParasalGetiri.Text) || cbGetiriTipi.Text == "Seçiniz" ||
                cbProjeTipi.Text == "Seçiniz" )
            {
                if (proje != null)
                {
                    MessageBox.Show("Lütfen bütün bilgileri giriniz.", "Proje Güncelleme Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Lütfen bütün bilgileri giriniz.", "Proje Oluşturma Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else
            {
                MyContext veritabani = new MyContext();

                if (proje != null) //gelen form boş değilse kişi güncelleme yapılıyor.
                {
                    
                    
                    Console.WriteLine();
                    Proje proje_ = veritabani.Projeler.FirstOrDefault(p => p.ID == proje.ID);
                    proje_.projeAdi = tbProjeAdi.Text;
                    proje_.stratejikEtki = tbStratejikEtki.Text;
                    proje_.projeNo = tbProjeNo.Text;
                    proje_.projeYurutucusu = veritabani.Kisiler.FirstOrDefault(p => p.adi.Contains(cbProjeYurutucusu.Text));
                    proje_.amac = tbAmac.Text;
                    proje_.problemTanimi = tbProblemTanimi.Text;
                    proje_.kapsam = tbKapsam.Text;
                    proje_.kayitTarihi = DateTime.ParseExact(TarihiDuzelt(dtpKayitTarihi.Value.ToShortDateString().Replace(".", "/").Replace(" 00:00:00", "")), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    proje_.projeBaslangici = DateTime.ParseExact(TarihiDuzelt(dtpProjeBaslangici.Value.ToShortDateString().Replace(".", "/").Replace(" 00:00:00", "")), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    proje_.projeBitisi = DateTime.ParseExact(TarihiDuzelt(dtpProjeBitisi.Value.ToShortDateString().Replace(".", "/").Replace(" 00:00:00", "")), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    proje_.tahminiBaslangic = DateTime.ParseExact(TarihiDuzelt(dtpTahminiBaslangic.Value.ToShortDateString().Replace(".", "/").Replace(" 00:00:00", "")), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    proje_.tahminiBitis = DateTime.ParseExact(TarihiDuzelt(dtpTahminiBitis.Value.ToShortDateString().Replace(".", "/").Replace(" 00:00:00", "")), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    proje_.projeDurumu = (Durum)Enum.Parse(typeof(Durum), cbProjeDurumu.SelectedValue.ToString());
                    proje_.parasalGetiri = double.Parse(tbParasalGetiri.Text);
                    proje_.getiriTipi = (GetiriTipi)Enum.Parse(typeof(GetiriTipi), cbGetiriTipi.SelectedValue.ToString()); 
                    //proje_.projeEkibi = clbKisiler.Text;
                    proje_.document = lbProjeDokumanlari.Text;
                    proje_.projeTipi = (ProjeTipi)Enum.Parse(typeof(ProjeTipi), cbProjeTipi.SelectedValue.ToString());
                    proje_.kmTaslari = lbKmTaslari.Text;
                }
                else
                {
                    ProjeEkibi ProjeEkibi = veritabani.Ekipler.FirstOrDefault(p => p.ID ==4);
                    Kisi yurutucu = veritabani.Kisiler.FirstOrDefault(p => cbProjeYurutucusu.Text.Contains(p.adi));
                    Console.WriteLine("yurutucu.ID : " + yurutucu.ID.ToString());
                    veritabani.Projeler.Add(new Proje
                    {
                        projeAdi = tbProjeAdi.Text.ToString(),
                        stratejikEtki = tbStratejikEtki.Text.ToString(),
                        projeNo = tbProjeNo.Text.ToString(),
                        projeYurutucusu = yurutucu,
                        amac = tbAmac.Text.ToString(),
                        problemTanimi = tbProblemTanimi.Text.ToString(),
                        kapsam = tbKapsam.Text.ToString(),
                        kayitTarihi = DateTime.ParseExact(TarihiDuzelt(dtpKayitTarihi.Value.ToShortDateString().Replace(".", "/").Replace(" 00:00:00", "")), "dd/MM/yyyy", CultureInfo.InvariantCulture),
                        projeBaslangici = DateTime.ParseExact(TarihiDuzelt(dtpProjeBaslangici.Value.ToShortDateString().Replace(".", "/").Replace(" 00:00:00", "")), "dd/MM/yyyy", CultureInfo.InvariantCulture),
                        projeBitisi = DateTime.ParseExact(TarihiDuzelt(dtpProjeBitisi.Value.ToShortDateString().Replace(".", "/").Replace(" 00:00:00", "")), "dd/MM/yyyy", CultureInfo.InvariantCulture),
                        tahminiBaslangic = DateTime.ParseExact(TarihiDuzelt(dtpTahminiBaslangic.Value.ToShortDateString().Replace(".", "/").Replace(" 00:00:00", "")), "dd/MM/yyyy", CultureInfo.InvariantCulture),
                        tahminiBitis = DateTime.ParseExact(TarihiDuzelt(dtpTahminiBitis.Value.ToShortDateString().Replace(".", "/").Replace(" 00:00:00", "")), "dd/MM/yyyy", CultureInfo.InvariantCulture),
                        projeDurumu = (Durum)Enum.Parse(typeof(Durum), cbProjeDurumu.SelectedValue.ToString()),
                        parasalGetiri = double.Parse(tbParasalGetiri.Text.ToString()),
                        getiriTipi = (GetiriTipi)Enum.Parse(typeof(GetiriTipi), cbGetiriTipi.SelectedValue.ToString()),
                        projeEkibi = ProjeEkibi,
                        document = lbProjeDokumanlari.Text.ToString(),
                        projeTipi = (ProjeTipi)Enum.Parse(typeof(ProjeTipi), cbProjeTipi.SelectedValue.ToString()),
                        kmTaslari = lbKmTaslari.Text.ToList().ToString(),
                    });
                }
                veritabani.SaveChanges();

                ana.GetProjeler();

                if (proje != null) //Success mesajı için kontrol.
                {
                    MessageBox.Show("Proje başarıyla güncellendi.", "Proje Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Proje başarıyla oluşturuldu.", "Proje Oluşturma", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.Close(); //Bu formu kapat.
            }
        }

        private void ProjeOlustur_Load(object sender, EventArgs e)
        {
            GetEkip();//checkedlistbox'ı doldurmak için metot otomatik çalışıyor.
            Console.WriteLine("dtpKayitTarihi.Value.ToShortDateString() : " + dtpKayitTarihi.Value.ToShortDateString());
            Console.WriteLine("dtpKayitTarihi.Value.ToShortDateString() Replace : " + dtpKayitTarihi.Value.ToShortDateString().Replace(".", "/"));

        }
    }
}
