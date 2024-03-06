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
    //[ImageName("BO_Contact")]
    //[DefaultProperty("DisplayMemberNameForLookupEditorsOfThisType")]
    //[DefaultListViewOptions(MasterDetailMode.ListViewOnly, false, NewItemRowPosition.None)]
    //[Persistent("DatabaseTableName")]
    // Specify more UI options using a declarative approach (https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument112701).
    public class CalisanPersonel : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public CalisanPersonel(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }
       

        YeniProje yeniProje;
        DateTime dogumTarihi;
        string motherName;
        string fatherName;
        string adres;
        string telefon;
        string sicilNO;
        string departman;
        string adSoyad;

        [RuleRequiredField(DefaultContexts.Save)]
        [XafDisplayName("Personel Ad Soyad")]
        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string AdSoyad
        {
            get => adSoyad;
            set => SetPropertyValue(nameof(AdSoyad), ref adSoyad, value);
        }


        [XafDisplayName("Doğum Tarihi")]
        public DateTime DogumTarihi
        {
            get => dogumTarihi;
            set => SetPropertyValue(nameof(DogumTarihi), ref dogumTarihi, value);
        }



        [XafDisplayName("Telefon"), ToolTip("Telefon Numarası")]
        [RuleRequiredField(DefaultContexts.Save)]
        [ModelDefault("EditMask", "(000)-000-00-00"), Index(0), VisibleInListView(false)]
        public string Telefon
        {
            get => telefon;
            set => SetPropertyValue(nameof(Telefon), ref telefon, value);
        }



        [XafDisplayName("Departman")]
        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Departman
        {
            get => departman;
            set => SetPropertyValue(nameof(Departman), ref departman, value);
        }


        [XafDisplayName("Sicil No")]
        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string SicilNO
        {
            get => sicilNO;
            set => SetPropertyValue(nameof(SicilNO), ref sicilNO, value);
        }





        [XafDisplayName("Adres")]
        [Size(300)]
        public string Adres
        {
            get => adres;
            set => SetPropertyValue(nameof(Adres), ref adres, value);
        }




        [XafDisplayName("Personel Resmi"), ToolTip("Personel Resmi")]
        [ImageEditor]
        public Byte[] MemberPhoto { get; set; }




        [Size(30)]
        [XafDisplayName("Baba Adı")]
        public string FatherName

        {
            get => fatherName;
            set => SetPropertyValue(nameof(FatherName), ref fatherName, value);
        }


        [Size(30)]
        [XafDisplayName("Anne Adı")]
        public string MotherName
        {
            get => motherName;
            set => SetPropertyValue(nameof(MotherName), ref motherName, value);
        }


        [Association("YeniProje-CalisanPersonel")]
        public YeniProje YeniProje
        {
            get => yeniProje;
            set => SetPropertyValue(nameof(YeniProje), ref yeniProje, value);
        }


    }
}