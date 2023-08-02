using pys.Context;
using pys.Entity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace pys
{
    public partial class AnaSayfa : Form
    {
        bool btnLinq1KisilerClicked = false;
        bool btnLinq2KisilerClicked = false;
        bool btnLinq3KisilerClicked = false;
        bool btnLinq1ProjelerClicked = false;
        bool btnLinq2ProjelerClicked = false;
        bool btnLinq3ProjelerClicked = false;

        
        public AnaSayfa()
        {
            InitializeComponent();
        }

        public void GetKisiler() //Veritabanından kişi verilerini alarak datagridview'a yükleyen metot.
        {
            MyContext kisiVeritabani = new MyContext();
            dgvKisiler.DataSource = kisiVeritabani.Kisiler.ToList();

            GetStatus(); //Değişikliklerden sonra anasayfadaki statusstrip'i güncellemek için.
        }

        void GetTreeView() //Anasayfanın sağındaki treeview nesnesini dolduruyor.
        {
            treeView1.Nodes.Clear(); //Mevcut treeview'ın verilerini siliyor (veri tekrarı olmaması için).

            using (MyContext projeVeritabani = new MyContext())
            {
                var items = from i in projeVeritabani.Projeler
                            select i;

                TreeNode treeNode = new TreeNode("Projeler");
                treeView1.Nodes.Add(treeNode);

                foreach (var item in items)
                {
                    TreeNode node = new TreeNode("ID: " + item.ID.ToString());
                    node.Nodes.Add(item.projeAdi);
                    node.Nodes.Add(item.stratejikEtki);
                    node.Nodes.Add(item.projeNo);
                    //node.Nodes.Add(item.projeYurutucusu);
                    node.Nodes.Add(item.amac);
                    node.Nodes.Add(item.problemTanimi);
                    node.Nodes.Add(item.kapsam);
                    node.Nodes.Add(item.kayitTarihi.ToShortDateString());
                    node.Nodes.Add(item.projeBaslangici.ToShortDateString());
                    node.Nodes.Add(item.projeBitisi.ToShortDateString());
                    node.Nodes.Add(item.tahminiBaslangic.ToShortDateString());
                    node.Nodes.Add(item.tahminiBitis.ToShortDateString());
                    node.Nodes.Add(item.projeDurumu.ToString());
                    node.Nodes.Add(item.parasalGetiri.ToString());
                    node.Nodes.Add(item.getiriTipi.ToString());
                    //node.Nodes.Add(item.projeEkibi.ToString());
                    node.Nodes.Add(item.document);
                    node.Nodes.Add(item.projeTipi.ToString());

                    //Virgülden parçalara ayırarark km taşları dizisi için 2. bir treeview daha oluşturdum. 
                    if (item.kmTaslari != null)
                    {
                        if (item.kmTaslari.Contains(","))
                        {
                            string[] kmTaslari = item.kmTaslari.Split(',');
                            TreeNode nodekm = new TreeNode("Kilometre Taşları");
                            for (int j = 0; j < kmTaslari.Length; j++)
                            {
                                nodekm.Nodes.Add(kmTaslari[j].ToString());
                            }
                            node.Nodes.Add(nodekm); //İçteki treeview'ı dıştaki treeview'a eklemek için.
                        }
                        else
                        {
                            node.Nodes.Add(item.kmTaslari.ToString());
                        }
                    }
                    else
                    {
                        node.Nodes.Add(" ");
                    }
                    treeView1.Nodes.Add(node);
                }
            }
        }

        public void GetProjeler() //Veritabanından proje verilerini alarak datagridview'a yükleyen metot.
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;" +
                    "Initial Catalog=pys.Context.MyContext;Integrated Security=True");
                con.Open();
                
                SqlDataAdapter dataAdapter = new SqlDataAdapter(
                    "select * from dbo.Projes", con);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                dgvProjeler.DataSource = dataSet.Tables[0].DefaultView;
                
                con.Close();
            }
            catch (Exception)
            {

                Console.WriteLine("Veritabanına bağlanırken hata meydana geldi.");
            }

            GetTreeView();

            GetStatus(); //Değişikliklerden sonra anasayfadaki statusstrip'i güncellemek için. 

            Check(); // Tamamlandi olarak belirtilen proje olup olmadığının kontrolü için
        }

        public void GetStatus() //Anasayfanın sol altındaki statusstrip'in kodu.
        {
            
            toolStripStatusLabel1.Text = (dgvProjeler.RowCount-1).ToString() +
                " adet proje, " + dgvKisiler.RowCount.ToString() + " adet kişi kayıtlıdır.";
        }

        public void GetPhoneNumbers() //ADO NET ile
        {

                SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;" +
                    "Initial Catalog=pys.Context.MyContext;Integrated Security=True");//Dosya yolundaki server'a bağlanmak için.
                con.Open(); 
                SqlDataAdapter dataAdapter = new SqlDataAdapter(
                    "select ID, adi, soyadi, telefon from dbo.Kisis", con); //Kisi tablosundan bilgileri çekmek için.
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                dgvPhoneNumbers1.DataSource = dataSet.Tables[0].DefaultView;
                con.Close();
        }

        public void Check() 
        {
            try 
            {
                int dgvLength = dgvProjeler.Rows.Count;
                for (int i = 0; i< dgvLength; i++)
                {
                    if (dgvProjeler.Rows[i].Cells[12].Value != null)
                    {
                        
                        if (dgvProjeler.Rows[i].Cells[12].Value.ToString().Equals("3") ||
                            dgvProjeler.Rows[i].Cells[12].Value.ToString().Equals("Tamamlandi"))
                        {
                            MyContext veritabani = new MyContext();
                            Kisi mailAtilacakKisi = veritabani.Kisiler.FirstOrDefault(k => k.ID == int.Parse(dgvProjeler.Rows[i].Cells[12].Value.ToString()));
                            SendMail(mailAtilacakKisi);
                        }
                    }

                }
                
            }
            catch (Exception)
            {
                Console.WriteLine("Formatting error.");
            }
        }

        public void SendMail(Kisi kisi) //ADO NET ile
        {
            Console.WriteLine(kisi.adi + " " + kisi.soyadi + "adlı kişinin yürüttüğü proje tamamlandı.");   
        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {
            GetProjeler();//Veritabanından proje verilerini alarak datagridview'a yükleyen metot.

            GetKisiler();//Veritabanından kişi verilerini alarak datagridview'a yükleyen metot.

            GetPhoneNumbers();

            Check();
        }

        private void BtnProjeEkle_Click(object sender, EventArgs e)
        {
            ProjeOlustur projeEkle = new ProjeOlustur(this, null);
            projeEkle.ShowDialog();
        }

        private void BtnKisiEkle_Click(object sender, EventArgs e)
        {
            KisiOlustur kisiOlustur = new KisiOlustur(this, null);
            kisiOlustur.ShowDialog();
        }

        private void ÇıkışYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Giris giris = new Giris();
            giris.Show();
        }

        private void AnaSayfa_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Giris giris = new Giris();
            giris.Show();
        }

        private void BtnKisiSil_Click(object sender, EventArgs e)
        {
            if(dgvKisiler.CurrentCell == null) //Kişi seçili değilse
            {
                MessageBox.Show("Lütfen silmeyi istediğiniz kişiyi seçiniz.", "Kişi Silme Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else //kişi seçili ise...
            {
                int satirNo = dgvKisiler.CurrentCell.RowIndex; //seçili olan satırın indisi bulunuyor.
                int id = int.Parse(dgvKisiler.Rows[satirNo].Cells[0].Value.ToString());
                String kisiAdiSoyadi = dgvKisiler.Rows[satirNo].Cells[1].Value.ToString() + " " + dgvKisiler.Rows[satirNo].Cells[2].Value.ToString();
                DialogResult sonuc = MessageBox.Show(kisiAdiSoyadi + " adlı kişiyi silmek istediğinizden emin misiniz?", "Kişi Silme Onayı", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
                if (sonuc == DialogResult.OK)
                {
                    try
                    {
                        MyContext veritabani = new MyContext();
                        Kisi kisi = veritabani.Kisiler.FirstOrDefault(k => k.ID == id);
                        veritabani.Kisiler.Remove(kisi);
                        veritabani.SaveChanges();

                        GetKisiler(); //Kişi silme işleminden sonra kişiler veritabanını ve dolayısıyla datagridview'ı yeni baştan oluşturmak için.
                    }
                    catch (Exception)
                    {
                        MessageBox.Show(kisiAdiSoyadi + " adlı kişi mevcut bir projede görev aldığı için silinemiyor!", "Kişi Silme Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void BtnKisiGuncelle_Click(object sender, EventArgs e) 
        {
            if (dgvKisiler.CurrentCell == null)
            {
                MessageBox.Show("Lütfen güncellemeyi istediğiniz kişiyi seçiniz.", "Kişi Güncelleme Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int satirNo = dgvKisiler.CurrentCell.RowIndex; //seçili olan satırın indisi bulunuyor.
                int id = int.Parse(dgvKisiler.Rows[satirNo].Cells[0].Value.ToString());

                MyContext veritabani = new MyContext();
                Kisi kisi = veritabani.Kisiler.FirstOrDefault(k => k.ID == id);

                KisiOlustur kisiOlustur = new KisiOlustur(this, kisi);//Oluşturulan kişi KisiOlustur formuna yollandı.
                kisiOlustur.ShowDialog();
            }
        }

        private void BtnProjeSil_Click(object sender, EventArgs e) 
        {
            if (dgvProjeler.CurrentCell == null)//Proje seçili değilse
            {
                MessageBox.Show("Lütfen silmeyi istediğiniz projeyi seçiniz.", "Proje Silme Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else//Proje seçili ise
            {
                int satirNo = dgvProjeler.CurrentCell.RowIndex; //seçili olan satırın indisi bulunuyor.
                int id = int.Parse(dgvProjeler.Rows[satirNo].Cells[0].Value.ToString());
                String projeAdi = dgvProjeler.Rows[satirNo].Cells[1].Value.ToString();

                DialogResult sonuc = MessageBox.Show(projeAdi + " projesini silmek istediğinizden emin misiniz?", "Proje Silme Onayı", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
                if (sonuc == DialogResult.OK)
                {
                    MyContext veritabani = new MyContext();
                    Proje proje = veritabani.Projeler.FirstOrDefault(k => k.ID == id);
                    veritabani.Projeler.Remove(proje);
                    veritabani.SaveChanges();

                    GetProjeler(); //Proje silme işleminden sonra projeler veritabanını ve dolayısıyla treeview'ı yeni baştan oluşturmak için.
                }
            }
        }

        private void DgvProjeler_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)  //Projenin satır arkaplanını kırmızı yapmak için
        {
            try //Tarihin formatında bir hata varsa yakalamak için.
            {
                if (dgvProjeler.Rows[e.RowIndex].Cells[9].Value != null)
                {
                    if (DateTime.ParseExact(dgvProjeler.Rows[e.RowIndex].Cells[9].Value.ToString().Replace(".", "/").Replace(" 00:00:00", ""), "dd/MM/yyyy", CultureInfo.InvariantCulture).CompareTo(DateTime.Now) < 0)
                    {
                        dgvProjeler.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;//Proje bitiş tarihinde bitmemişse kırmızı görünecek.
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("CellFormatting error.");
            }
        }

        private void BtnProjeGuncelle_Click(object sender, EventArgs e) 
        {
            if (dgvProjeler.CurrentCell == null)
            {
                MessageBox.Show("Lütfen güncellemeyi istediğiniz projeyi seçiniz.", "Proje Güncelleme Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int satirNo = dgvProjeler.CurrentCell.RowIndex; //seçili olan satırın indisi bulunuyor.
                int id = int.Parse(dgvProjeler.Rows[satirNo].Cells[0].Value.ToString());

                MyContext veritabani = new MyContext();
                Proje proje = veritabani.Projeler.FirstOrDefault(k => k.ID == id);

                ProjeOlustur projeOlustur = new ProjeOlustur(this, proje);
                projeOlustur.ShowDialog();
            }

        }

        private void HakkindaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Windows Programlama Dersi\nVize Projesi", "Hakkında", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnLinq1Kisiler_Click(object sender, EventArgs e)
        {

        }

        private void BtnLinq2Kisiler_Click(object sender, EventArgs e)
        {

        }

        private void BtnLinq3Kisiler_Click(object sender, EventArgs e)
        {

        }

        private void BtnLinq1Projeler_Click(object sender, EventArgs e)
        {
            if(btnLinq1ProjelerClicked == false) 
            {
                btnLinq1ProjelerClicked = true;
                btnLinq1Projeler.FlatStyle = FlatStyle.Popup;

                /*LINQ1
                Yöneticisi Yaprak Çınar olan (Where) projeleri seçer (Select), 
                önce proje başlangıç tarihlerine göre sıralar (OrderBy),
                ardından proje bitiş tarihine göre sıralar (ThenBy),
                listeler (ToList) ve bunlar içinden süresi geçenleri seçer (FirstorDefault) */
                
                MyContext projeVeritabani = new MyContext();
                var items = (from i in projeVeritabani.Projeler //Query Syntax 
                             where i.projeYurutucusu.ID == 3 //"Yaprak Çınar" //Query Syntax 
                             select i) //Query Syntax 
                            .OrderBy(p => p.projeBaslangici) //Method Syntax
                            .ThenBy(p => p.projeBitisi) //Method Syntax
                            .ToList(); //Method Syntax
                Proje proje = items.FirstOrDefault(p => p.projeBitisi < DateTime.Now);

                //Where(num => num % 2 == 0).OrderBy(n => n)
                //Console.WriteLine(items.projeAdi);

                dgvProjeler.DataSource = items.ToList();
            }
            else
            {
                btnLinq1ProjelerClicked = false;
                btnLinq2ProjelerClicked = false;
                btnLinq3ProjelerClicked = false;
                btnLinq1Projeler.FlatStyle = FlatStyle.System;

                GetProjeler();
            }
            btnLinq2Projeler.FlatStyle = FlatStyle.System;
            btnLinq3Projeler.FlatStyle = FlatStyle.System;
        }

        private void BtnLinq2Projeler_Click(object sender, EventArgs e)
        {
            if (btnLinq2ProjelerClicked == false)
            {
                btnLinq2ProjelerClicked = true;
                btnLinq2Projeler.FlatStyle = FlatStyle.Popup;

                //LINQ2
                /* Stratejik etkisi düşük ve parasal getirisi 50000'den küçük olan (Where)
                projeleri seçer ve proje durumunu "Tamamlandi" olarak değiştirir(Select), 
                ardından önce parasal getirilerine göre büyükten küçüğe sıralar (OrderBy),
                ardından proje bitiş tarihine göre sıralar (ThenBy),
                listeler (ToList) ve bunlar içinden süresi geçenleri seçer (FirstorDefault) */

                MyContext projeVeritabani = new MyContext();
                var items = projeVeritabani.Projeler.  //Tümüyle method syntax ile yapıldı.
                    Where(p => p.stratejikEtki == "Düşük" && p.parasalGetiri < 50000).AsEnumerable() // "A Lambda Expression With A Statement Body
                                                                                                     // Cannot Be Converted To An Expression Tree"
                                                                                                     // hatası aldığım için AsEnumerable() ekledim.
                    .Select(p => { p.projeDurumu = Durum.Tamamlandi; return p; }) // AsEnumerable() eklenmeden bu Select işlemi yapılamıyor.
                    .OrderBy(p => p.parasalGetiri)
                    .ThenBy(p => p.projeBitisi)
                    .ToList(); //Method Syntax
                Proje proje = items.FirstOrDefault(p => p.projeBitisi < DateTime.Now);

                //Where(num => num % 2 == 0).OrderBy(n => n)
                //Console.WriteLine(items.projeAdi);

                dgvProjeler.DataSource = items.ToList();

            }
            else
            {
                btnLinq1ProjelerClicked = false;
                btnLinq2ProjelerClicked = false;
                btnLinq3ProjelerClicked = false;
                btnLinq2Projeler.FlatStyle = FlatStyle.System;

                GetProjeler();
            }
            btnLinq1Projeler.FlatStyle = FlatStyle.System;
            btnLinq3Projeler.FlatStyle = FlatStyle.System;
        }

        private void BtnLinq3Projeler_Click(object sender, EventArgs e)
        {
            if (btnLinq3ProjelerClicked == false)
            {
                btnLinq3ProjelerClicked = true;
                btnLinq3Projeler.FlatStyle = FlatStyle.Popup;


                /* LINQ3
                İçerisinde Ursula LeGuin'in olduğu proje ekiplerini ID'lerine göre sırala. */


                MyContext projeVeritabani = new MyContext();
                var items = (from i in projeVeritabani.Ekipler //Query Syntax 
                             where i.projeEkibi.Contains(projeVeritabani.Kisiler.FirstOrDefault(p => p.ID == 4)) //"Ursula LeGuin" //Query Syntax 
                             select i) //Query Syntax 
                            .OrderBy(g => g.ID) //Method Syntax
                            .ToList(); //Method Syntax

                dgvProjeler.DataSource = items.ToList(); //datagridview'da göstermek için.
            }
            else
            {
                btnLinq1ProjelerClicked = false;
                btnLinq2ProjelerClicked = false;
                btnLinq3ProjelerClicked = false;
                btnLinq3Projeler.FlatStyle = FlatStyle.System;

                GetProjeler();
            }
            btnLinq2Projeler.FlatStyle = FlatStyle.System;
            btnLinq1Projeler.FlatStyle = FlatStyle.System;
        }

        private void btnLinq1Projeler_MouseHover(object sender, EventArgs e)
        {
            Controls_Tooltip("LINQ 1", "Yöneticisi Yaprak Çınar olan (Where) projeleri seçer (Select), " +
                "\nönce proje başlangıç tarihlerine göre sıralar (OrderBy), " +
                "\nardından proje bitiş tarihine göre sıralar (ThenBy), listeler (ToList)", btnLinq1Projeler);
        }

        private void btnLinq2Projeler_MouseHover(object sender, EventArgs e)
        {
            Controls_Tooltip("LINQ 2", "Stratejik etkisi düşük ve parasal getirisi 50000'den küçük olan (Where), " +
                "\nprojeleri seçer ve proje durumunu \"Ertelendi\" olarak değiştirir(Select), " +
                "\nardından önce parasal getirilerine göre büyükten küçüğe sıralar (OrderBy)" +
                "\nardından proje bitiş tarihine göre sıralar (ThenBy), listeler (ToList)", btnLinq2Projeler);
        }

        private void btnLinq3Projeler_MouseHover(object sender, EventArgs e)
        {
            Controls_Tooltip("LINQ 3", "İçerisinde Ursula LeGuin'in olduğu proje ekiplerini " +
                "\nID'lerine göre sırala.", btnLinq3Projeler);
        }

        ToolTip Controls_Tooltip(string baslik, string aciklama, Control cntrl)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.Active = true; // Görünsün mü?
            toolTip.ToolTipTitle = baslik; // Çıkacak Mesajın Başlığı
            toolTip.ToolTipIcon = ToolTipIcon.Info; // Çıkacak Mesajda yer alacak ıkon
            toolTip.UseFading = true; // Silinerek kaybolma ve yavaşça görünme
            toolTip.UseAnimation = true; // Animasyonlu açılış
            toolTip.IsBalloon = true; // Baloncuk şekli mi dikdörtgen mi?
            toolTip.ShowAlways = true; // her zaman göster
            toolTip.AutoPopDelay = 20000; // Mesajın açık kalma süresi
            toolTip.ReshowDelay = 3000; // Mause çekildikten kaç ms sonra kaybolsun
            toolTip.InitialDelay = 1000; // Mesajın açılma süresi
            toolTip.BackColor = Color.Red; // arka plan rengi
            toolTip.ForeColor = Color.White; // yazı rengi
            toolTip.SetToolTip(cntrl, aciklama); // Hangi kontrolde görünsün
            return toolTip;
        }
    }
}
