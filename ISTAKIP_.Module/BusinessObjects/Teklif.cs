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
    [XafDisplayName("Teklif Oluştur")]
    //[ImageName("BO_Contact")]
    //[DefaultProperty("DisplayMemberNameForLookupEditorsOfThisType")]
    //[DefaultListViewOptions(MasterDetailMode.ListViewOnly, false, NewItemRowPosition.None)]
    //[Persistent("DatabaseTableName")]
    // Specify more UI options using a declarative approach (https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument112701).
    public class Teklif : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public Teklif(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }


        DateTime kayitTarihi;
        Musteriler musteriler;
        Enums.Asamalar asamalar;
        int teklifDegeri;
        string aciklamaBilgisi;
        string baslikBilgisi;

        [RuleRequiredField(DefaultContexts.Save)]
        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        [XafDisplayName("Başlık")]
        public string BaslikBilgisi
        {
            get => baslikBilgisi;
            set => SetPropertyValue(nameof(BaslikBilgisi), ref baslikBilgisi, value);
        }


        [XafDisplayName("Teklif Tarih")]
        public DateTime KayitTarihi
        {
            get => kayitTarihi;
            set => SetPropertyValue(nameof(KayitTarihi), ref kayitTarihi, value);
        }


        [XafDisplayName("Açıklama")]
        [Size(300)]
        public string AciklamaBilgisi
        {
            get => aciklamaBilgisi;
            set => SetPropertyValue(nameof(AciklamaBilgisi), ref aciklamaBilgisi, value);
        }


        [XafDisplayName("Teklif Değeri")]
        public int TeklifDegeri
        {
            get => teklifDegeri;
            set => SetPropertyValue(nameof(TeklifDegeri), ref teklifDegeri, value);
        }





        [XafDisplayName("Müşteri")]
        public Musteriler Musteriler
        {
            get => musteriler;
            set => SetPropertyValue(nameof(Musteriler), ref musteriler, value);
        }





        [XafDisplayName("Aşama")]
        public Enums.Asamalar Asamalar
        {
            get => asamalar;
            set => SetPropertyValue(nameof(Asamalar), ref asamalar, value);
        }




    }
}