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
    [XafDisplayName("Müşteri Bağlantıları")]
    //[ImageName("BO_Contact")]
    //[DefaultProperty("DisplayMemberNameForLookupEditorsOfThisType")]
    //[DefaultListViewOptions(MasterDetailMode.ListViewOnly, false, NewItemRowPosition.None)]
    //[Persistent("DatabaseTableName")]
    // Specify more UI options using a declarative approach (https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument112701).
    public class Baglantilar : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public Baglantilar(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }




        Musteriler musteriler;
        string emailBilgisi;
        string telefon;
        string gorevBilgisi;
        string adSoyad;

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string AdSoyad
        {
            get => adSoyad;
            set => SetPropertyValue(nameof(AdSoyad), ref adSoyad, value);
        }


        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string GorevBilgisi
        {
            get => gorevBilgisi;
            set => SetPropertyValue(nameof(GorevBilgisi), ref gorevBilgisi, value);
        }




        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Telefon
        {
            get => telefon;
            set => SetPropertyValue(nameof(Telefon), ref telefon, value);
        }



        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string EmailBilgisi
        {
            get => emailBilgisi;
            set => SetPropertyValue(nameof(EmailBilgisi), ref emailBilgisi, value);
        }


        [Association("Musteriler-Baglantilar")]
        public Musteriler Musteriler
        {
            get => musteriler;
            set => SetPropertyValue(nameof(Musteriler), ref musteriler, value);
        }

    }
}