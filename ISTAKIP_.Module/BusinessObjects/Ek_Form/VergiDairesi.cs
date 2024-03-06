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
    [XafDisplayName("Fatura Bilgileri")]
    //[ImageName("BO_Contact")]
    //[DefaultProperty("DisplayMemberNameForLookupEditorsOfThisType")]
    //[DefaultListViewOptions(MasterDetailMode.ListViewOnly, false, NewItemRowPosition.None)]
    //[Persistent("DatabaseTableName")]
    // Specify more UI options using a declarative approach (https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument112701).
    public class VergiDairesi : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public VergiDairesi(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }


        Musteriler musteriler;
        string vergiNumarasi;
        string vergiAdresi;
        string vergiDairesi;

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        [XafDisplayName("Vergi Dairesi")]
        public string vVergiDairesi
        {
            get => vergiDairesi;
            set => SetPropertyValue(nameof(vVergiDairesi), ref vergiDairesi, value);
        }



        [XafDisplayName("Adres")]
        [Size(250)]
        public string VergiAdresi
        {
            get => vergiAdresi;
            set => SetPropertyValue(nameof(VergiAdresi), ref vergiAdresi, value);
        }



        [Size(88)]
        [XafDisplayName("Vergi Numarası")]
        public string VergiNumarasi
        {
            get => vergiNumarasi;
            set => SetPropertyValue(nameof(VergiNumarasi), ref vergiNumarasi, value);
        }



        [Association("Musteriler-VergiDairesi")]
        public Musteriler Musteriler
        {
            get => musteriler;
            set => SetPropertyValue(nameof(Musteriler), ref musteriler, value);
        }


    }
}