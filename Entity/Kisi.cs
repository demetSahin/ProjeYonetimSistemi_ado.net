using System;

namespace pys.Entity
{
    public class Kisi //Kişi sınıfı. 
    {
        public int ID { get; set; } //EF tarafından otomatik olarak primary key olarak atanır.
        public string adi { get; set; }
        public string soyadi { get; set; }
        public string cinsiyet { get; set; }
        public string eposta { get; set; }
        public string telefon { get; set; }
        public DateTime dogumTarihi { get; set; }
        public string adres { get; set; }
        public double isTecrubesi { get; set; }
    }
}


