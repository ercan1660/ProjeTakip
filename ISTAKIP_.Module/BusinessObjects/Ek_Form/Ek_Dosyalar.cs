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
    //[ImageName("BO_Contact")]
    //[DefaultProperty("DisplayMemberNameForLookupEditorsOfThisType")]
    //[DefaultListViewOptions(MasterDetailMode.ListViewOnly, false, NewItemRowPosition.None)]
    //[Persistent("DatabaseTableName")]
    // Specify more UI options using a declarative approach (https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument112701).
    public class Ek_Dosyalar : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public Ek_Dosyalar(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }

        Musteriler musteriler;
        FileData digerEkDosya;
        FileData sabikaKaydi;
        FileData kimlikBelgesi;


        [XafDisplayName("Kimlik Belgesi")]
        public FileData KimlikBelgesi
        {
            get => kimlikBelgesi;
            set => SetPropertyValue(nameof(KimlikBelgesi), ref kimlikBelgesi, value);
        }


        [XafDisplayName("Sabıka Kaydı")]
        public FileData SabikaKaydi
        {
            get => sabikaKaydi;
            set => SetPropertyValue(nameof(SabikaKaydi), ref sabikaKaydi, value);
        }


        [XafDisplayName("Diğer Ek")]
        public FileData DigerEkDosya
        {
            get => digerEkDosya;
            set => SetPropertyValue(nameof(DigerEkDosya), ref digerEkDosya, value);
        }



        [Association("Musteriler-EkDosyalarBelgesi")]
        public Musteriler Musteriler
        {
            get => musteriler;
            set => SetPropertyValue(nameof(Musteriler), ref musteriler, value);
        }


    }
}