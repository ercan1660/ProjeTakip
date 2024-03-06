using DevExpress.ExpressApp.DC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISTAKIP_.Module.BusinessObjects.Enums
{
    public enum Asamalar
    {

        [XafDisplayName("Bekliyor")]
        Bekliyor,
        [XafDisplayName("Görüşüldü")]
        Gorusuldu,
        [XafDisplayName("Teklif Verildi")]
        TeklifVerildi,
        [XafDisplayName("Sipariş Alındı")]
        SiparisAlindi,
        [XafDisplayName("Gönderildi")]
        Gonderildi,
        [XafDisplayName("Ödeme Alındı")]
        odemealindi,
        [XafDisplayName("Taslak")]
        Taslak
    }
}
