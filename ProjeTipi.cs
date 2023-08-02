using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pys
{
    public enum ProjeTipi //Proje tipi, ProjeOlustur formunda kullanmak için yaratılan enum sınıfı
    {
        [Description("Seçiniz")]//ComboBox'ta görünecek açıklama
        Seciniz,//Enum değeri

        [Description("Yurtdışı")]
        Yurtdisi,

        [Description("Tübitak")]
        Tubitak,

        [Description("Kobi")]
        Kobi,

        [Description("KOSGEB")]
        KOSGEB,

        [Description("KÖİ")]
        KOI,
        //Kamu-Özel İşbirliği
    }
}
