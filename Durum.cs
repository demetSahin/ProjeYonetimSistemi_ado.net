using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pys
{
    public enum Durum //Proje durumu, ProjeOlustur formunda kullanmak için yaratılan enum sınıfı
    {
        [Description("Seçiniz")] //ComboBox'ta görünecek açıklama
        Seciniz, //Enum değeri

        [Description("Onay Bekliyor")]
        OnayBekliyor,

        [Description("Devam Ediyor")]
        DevamEdiyor,

        [Description("Tamamlandı")]
        Tamamlandi,
        
        [Description("İptal Edildi")] 
        IptalEdildi,

        [Description("Ertelendi")] 
        Ertelendi
    }
}
