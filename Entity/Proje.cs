using System;

namespace pys.Entity
{
    public class Proje
    {
        public int ID { get; set; } //EF tarafından otomatik olarak primary key olarak atanır.
        public string projeAdi { get; set; }
        public string stratejikEtki { get; set; }
        public string projeNo { get; set; }

        //Foreign Key
        public Kisi projeYurutucusu { get; set; } //P. yürütücüsü Kisi sınıfından türetilmiş nesne.
        public string amac { get; set; }
        public string problemTanimi { get; set; }
        public string kapsam { get; set; }
        public DateTime kayitTarihi { get; set; }
        public DateTime projeBaslangici { get; set; }
        public DateTime projeBitisi { get; set; }
        public DateTime tahminiBaslangic { get; set; }
        public DateTime tahminiBitis { get; set; }
        public Durum projeDurumu { get; set; }
        public double parasalGetiri { get; set; }
        public GetiriTipi getiriTipi { get; set; }

        //Foreign Key
        public ProjeEkibi projeEkibi { get; set; } //P. ekibi; ProjeEkibi sınıfından türetilmiş nesne.
        public string document { get; set; }
        public ProjeTipi projeTipi { get; set; }
        public string kmTaslari { get; set; }

    }
}
