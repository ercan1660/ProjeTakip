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
    [XafDisplayName("Yeni Müşteri Kaydı")]
  //  [XafDefaultProperty("AdSoyad")]


    //[ImageName("BO_Contact")]
    //[DefaultProperty("DisplayMemberNameForLookupEditorsOfThisType")]
    //[DefaultListViewOptions(MasterDetailMode.ListViewOnly, false, NewItemRowPosition.None)]
    //[Persistent("DatabaseTableName")]
    // Specify more UI options using a declarative approach (https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument112701).
    public class Musteriler : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public Musteriler(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }
        //private string _PersistentProperty;
        //[XafDisplayName("My display name"), ToolTip("My hint message")]
        //[ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)]
        //[Persistent("DatabaseColumnName"), RuleRequiredField(DefaultContexts.Save)]
        //public string PersistentProperty {
        //    get { return _PersistentProperty; }
        //    set { SetPropertyValue(nameof(PersistentProperty), ref _PersistentProperty, value); }
        //}

        //[Action(Caption = "My UI Action", ConfirmationMessage = "Are you sure?", ImageName = "Attention", AutoCommit = true)]
        //public void ActionMethod() {
        //    // Trigger a custom business logic for the current record in the UI (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112619.aspx).
        //    this.PersistentProperty = "Paid";
        //}




        YeniProje yeniProje;
        string musteriAdresBilgisi;
        string email;
        string telefon;
        string kisaAdBilgisi;
        string adSoyad;


       // [PersistentAlias("Concat([adSoyad])")]
     //   public string adSoyad => (string)EvaluateAlias("adSoyad");




        [XafDisplayName("Tam Ad (ÖRN: ABC BİLİŞİM LTD. ŞTİ.)")]
        [RuleRequiredField(DefaultContexts.Save)]
        [Size(50)]
        public string AdSoyad
        {
            get => adSoyad;
            set => SetPropertyValue(nameof(AdSoyad), ref adSoyad, value);
        }




        [Size(20)]
        [XafDisplayName("Kısa Ad (ÖRN: ABC)")]
        public string KisaAdBilgisi
        {
            get => kisaAdBilgisi;
            set => SetPropertyValue(nameof(KisaAdBilgisi), ref kisaAdBilgisi, value);
        }



        [XafDisplayName("Telefon"), ToolTip("Telefon Numarası")]
        [RuleRequiredField(DefaultContexts.Save)]
        [ModelDefault("EditMask", "(000)-000-00-00"), Index(0), VisibleInListView(false)]
        public string Telefon
        {
            get => telefon;
            set => SetPropertyValue(nameof(Telefon), ref telefon, value);
        }






        [XafDisplayName("E-POSTA")]
        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Email
        {
            get => email;
            set => SetPropertyValue(nameof(Email), ref email, value);
        }


        [XafDisplayName("FİRMA ADRESİ")]
        [Size(300)]
        public string MusteriAdresBilgisi
        {
            get => musteriAdresBilgisi;
            set => SetPropertyValue(nameof(MusteriAdresBilgisi), ref musteriAdresBilgisi, value);
        }




        [XafDisplayName("Fatura Bilgileri")]
        [Association("Musteriler-VergiDairesi"), DevExpress.Xpo.Aggregated]
        public XPCollection<Ek_Form.VergiDairesi> VergiDairesi
        {
            get
            {
                return GetCollection<Ek_Form.VergiDairesi>(nameof(VergiDairesi));
            }
        }




        [XafDisplayName("Bağlantılar")]
        [Association("Musteriler-Baglantilar"), DevExpress.Xpo.Aggregated]
        public XPCollection<Ek_Form.Baglantilar> Baglantilar
        {
            get
            {
                return GetCollection<Ek_Form.Baglantilar>(nameof(Baglantilar));
            }
        }



        [XafDisplayName("Ek Dosyalar")]
        [Association("Musteriler-EkDosyalarBelgesi"), DevExpress.Xpo.Aggregated]
        public XPCollection<Ek_Form.Ek_Dosyalar> EkDosyalarBelgesi
        {
            get
            {
                return GetCollection<Ek_Form.Ek_Dosyalar>(nameof(EkDosyalarBelgesi));
            }
        }

        [Association("YeniProje-ProjeyeDahilFirmalar")]
        public YeniProje YeniProje
        {
            get => yeniProje;
            set => SetPropertyValue(nameof(YeniProje), ref yeniProje, value);
        }


    }
}