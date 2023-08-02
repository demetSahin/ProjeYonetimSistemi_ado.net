using System;
using System.Data.SQLite;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace pys
{
    public partial class KisiEkle : Form
    {
        public KisiEkle()
        {
            InitializeComponent();
            GetKisiler();
        }

        public void GetKisiler()
        {
            using (SQLiteConnection con = new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;"))
            {
                using (SQLiteDataAdapter sda = new SQLiteDataAdapter("Select Adi || ' ' || Soyadi as AdiSoyadi from Kisiler", con))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    clbKisiler.DataSource = dt.DefaultView;
                    clbKisiler.ValueMember = "AdiSoyadi";
                    clbKisiler.DisplayMember = "AdiSoyadi";
                }
            }
        }

        private void btnYeniKisiOlustur_Click(object sender, EventArgs e)
        {
            //KisiOlustur kisiOlustur = new KisiOlustur(new AnaSayfa(), null);
            //kisiOlustur.ShowDialog();
        }

        private void clbKisiler_Format(object sender, ListControlConvertEventArgs e)
        {
            
        }
    }
}
