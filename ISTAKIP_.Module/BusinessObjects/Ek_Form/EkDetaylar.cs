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

namespace ISTAKIP_.Module.BusinessObjects.Ek_Form
{
    [DefaultClassOptions]
    [XafDisplayName("Ek Detay Ekle")]
    //[ImageName("BO_Contact")]
    //[DefaultProperty("DisplayMemberNameForLookupEditorsOfThisType")]
    //[DefaultListViewOptions(MasterDetailMode.ListViewOnly, false, NewItemRowPosition.None)]
    //[Persistent("DatabaseTableName")]
    // Specify more UI options using a declarative approach (https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument112701).
    public class EkDetaylar : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public EkDetaylar(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }



        YeniProje yeniProje;
        CalisanPersonel calisanPersonel;
        Musteriler musteriler;
        string aciklama;
        string baslik;
        DateTime eklenmeTarihi;


        [XafDisplayName("İşlem Tarihi")]
        public DateTime EklenmeTarihi
        {
            get => eklenmeTarihi;
            set => SetPropertyValue(nameof(EklenmeTarihi), ref eklenmeTarihi, value);
        }


        [XafDisplayName("Başlık")]
        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Baslik
        {
            get => baslik;
            set => SetPropertyValue(nameof(Baslik), ref baslik, value);
        }


        [XafDisplayName("Açıklama")]
        [Size(300)]
        public string Aciklama
        {
            get => aciklama;
            set => SetPropertyValue(nameof(Aciklama), ref aciklama, value);
        }

        [XafDisplayName("Var ise ilgili Müşteri")]
        public Musteriler Musteriler
        {
            get => musteriler;
            set => SetPropertyValue(nameof(Musteriler), ref musteriler, value);
        }

        [XafDisplayName("Var ise ilgili Personel")]
        public CalisanPersonel CalisanPersonel
        {
            get => calisanPersonel;
            set => SetPropertyValue(nameof(CalisanPersonel), ref calisanPersonel, value);
        }


        [Association("YeniProje-EkFormDetay")]
        public YeniProje YeniProje
        {
            get => yeniProje;
            set => SetPropertyValue(nameof(YeniProje), ref yeniProje, value);
        }


    }
}