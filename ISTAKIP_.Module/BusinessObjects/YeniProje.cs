using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace ISTAKIP_.Module.BusinessObjects
{
    [DefaultClassOptions]
    [XafDisplayName("Yeni Proje Ekle")]
 

    //[ImageName("BO_Contact")]
    //[DefaultProperty("DisplayMemberNameForLookupEditorsOfThisType")]
    //[DefaultListViewOptions(MasterDetailMode.ListViewOnly, false, NewItemRowPosition.None)]
    //[Persistent("DatabaseTableName")]
    // Specify more UI options using a declarative approach (https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument112701).
    public class YeniProje : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public YeniProje(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }



        FileData projeSozlesmesi;
        bool pazarGunu;
        bool cumartesi;
        bool cuma;
        bool persembe;
        bool carsamba;
        bool sali;
        bool pazartesi;
        DateTime bitisTarihi;
        bool genelProje;
        bool gizliProje;
        Musteriler musteriler;
        string projeAd;
        DateTime kayitTarihi;

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string ProjeAd
        {
            get => projeAd;
            set => SetPropertyValue(nameof(ProjeAd), ref projeAd, value);
        }


        [XafDisplayName("Müşteri")]
     
        public Musteriler Musteriler
        {
            get => musteriler;
            set => SetPropertyValue(nameof(Musteriler), ref musteriler, value);
        }

        [XafDisplayName("Gizli Proje")]
        public bool GizliProje
        {
            get => gizliProje;
            set => SetPropertyValue(nameof(GizliProje), ref gizliProje, value);
        }


        [XafDisplayName("Normal Proje")]
        public bool GenelProje
        {
            get => genelProje;
            set => SetPropertyValue(nameof(GenelProje), ref genelProje, value);
        }


        [XafDisplayName("Proje Sözleşmesi")]
        public FileData ProjeSozlesmesi
        {
            get => projeSozlesmesi;
            set => SetPropertyValue(nameof(ProjeSozlesmesi), ref projeSozlesmesi, value);
        }


        [XafDisplayName("Başlangıç Tarihi")]
        public DateTime KayitTarihi
        {
            get => kayitTarihi;
            set => SetPropertyValue(nameof(KayitTarihi), ref kayitTarihi, value);
        }



        [XafDisplayName("Bitiş Tarihi")]
        public DateTime BitisTarihi
        {
            get => bitisTarihi;
            set => SetPropertyValue(nameof(BitisTarihi), ref bitisTarihi, value);
        }


        [XafDisplayName("Pazartesi")]
        public bool Pazartesi
        {
            get => pazartesi;
            set => SetPropertyValue(nameof(Pazartesi), ref pazartesi, value);
        }

        [XafDisplayName("Salı")]
        public bool Sali
        {
            get => sali;
            set => SetPropertyValue(nameof(Sali), ref sali, value);
        }

        [XafDisplayName("Çarşamba")]
        public bool Carsamba
        {
            get => carsamba;
            set => SetPropertyValue(nameof(Carsamba), ref carsamba, value);
        }


        [XafDisplayName("Perşembe")]
        public bool Persembe
        {
            get => persembe;
            set => SetPropertyValue(nameof(Persembe), ref persembe, value);
        }

        [XafDisplayName("Cuma")]
        public bool Cuma
        {
            get => cuma;
            set => SetPropertyValue(nameof(Cuma), ref cuma, value);
        }


        [XafDisplayName("Cumartesi")]
        public bool Cumartesi
        {
            get => cumartesi;
            set => SetPropertyValue(nameof(Cumartesi), ref cumartesi, value);
        }


        [XafDisplayName("Pazar")]
        public bool PazarGunu
        {
            get => pazarGunu;
            set => SetPropertyValue(nameof(PazarGunu), ref pazarGunu, value);
        }



        [XafDisplayName("Projede Görev Alacak Personeller")]

        [Association("YeniProje-CalisanPersonel"),DevExpress.Xpo.Aggregated]
        public XPCollection<CalisanPersonel>  CalisanPersonel
            {
            get
            {
                return GetCollection<CalisanPersonel>(nameof(CalisanPersonel));
            }
        }


        [XafDisplayName("Projeye Destek Veren Kurumlar")]
        [Association("YeniProje-ProjeyeDahilFirmalar"), DevExpress.Xpo.Aggregated]
        public XPCollection<Musteriler> ProjeyeDahilFirmalar
        {
            get
            {
                return GetCollection<Musteriler>(nameof(ProjeyeDahilFirmalar));
            }
        }


        [XafDisplayName("İçerik Not Ekle")]
        [Association("YeniProje-EkFormDetay"), DevExpress.Xpo.Aggregated]
        public XPCollection<Ek_Form.EkDetaylar> EkFormDetay
        {
            get
            {
                return GetCollection<Ek_Form.EkDetaylar>(nameof(EkFormDetay));
            }
        }




    }
}