using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pys
{
    public enum GetiriTipi //Getiri tipi, ProjeOlustur formunda kullanmak için yaratılan enum sınıfı
    {
        [Description("Seçiniz")]//ComboBox'ta görünecek açıklama
        Seciniz,//Enum değeri

        [Description("Günlük")]
        Gunluk,

        [Description("Aylık")]
        Aylik,

        [Description("Yıllık")]
        Yillik,
    }
}
