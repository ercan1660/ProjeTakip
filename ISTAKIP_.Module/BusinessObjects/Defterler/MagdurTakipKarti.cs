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

namespace ETUFADS.Module.BusinessObjects.Defterler
{
    [DefaultClassOptions]
    [XafDisplayName("Mağdur Takip Kartı")]
    //[ImageName("BO_Contact")]
    //[DefaultProperty("DisplayMemberNameForLookupEditorsOfThisType")]
    //[DefaultListViewOptions(MasterDetailMode.ListViewOnly, false, NewItemRowPosition.None)]
    //[Persistent("DatabaseTableName")]
    // Specify more UI options using a declarative approach (https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument112701).
    public class MagdurTakipKarti : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public MagdurTakipKarti(Session session)
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


        string dernekCevabi;
        FileData propertyName;
        string dernektentalbi;
        string netice;
        string telefonYakini;
        string yakinlikDerecesi;
        string basvuruAdSoyad;
        string referansiKim;
        string telefon;
        string adress;
        string userName;

        [Size(90)]
        [XafDisplayName("Mağdur Ad Soyad")]
        public string UserName
        {
            get => userName;
            set => SetPropertyValue(nameof(UserName), ref userName, value);
        }


        [Size(200)]
        [XafDisplayName("Mağdur Adres")]
        public string Adress
        {
            get => adress;
            set => SetPropertyValue(nameof(Adress), ref adress, value);
        }



        [RuleRequiredField(DefaultContexts.Save)]
        [ModelDefault("EditMask", "(000)-000-00-00"), Index(0), VisibleInListView(false)]
        [XafDisplayName("Mağdur Telefon")]
        public string Telefon
        {
            get => telefon;
            set => SetPropertyValue(nameof(Telefon), ref telefon, value);
        }


        [XafDisplayName("Mağdur Ek Dosya")]
        public FileData PropertyName
        {
            get => propertyName;
            set => SetPropertyValue(nameof(PropertyName), ref propertyName, value);
        }


        [Size(90)]
        [XafDisplayName("Mağdur Referansı")]
        public string ReferansiKim
        {
            get => referansiKim;
            set => SetPropertyValue(nameof(ReferansiKim), ref referansiKim, value);
        }

        [XafDisplayName("Mağdur Adına Başvuru Yapan")]

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string BasvuruAdSoyad
        {
            get => basvuruAdSoyad;
            set => SetPropertyValue(nameof(BasvuruAdSoyad), ref basvuruAdSoyad, value);
        }

        [XafDisplayName("Yakınlık Derecesi")]
        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string YakinlikDerecesi
        {
            get => yakinlikDerecesi;
            set => SetPropertyValue(nameof(YakinlikDerecesi), ref yakinlikDerecesi, value);
        }

        [RuleRequiredField(DefaultContexts.Save)]
        [ModelDefault("EditMask", "(000)-000-00-00"), Index(0), VisibleInListView(false)]
        [XafDisplayName("Referans Telefonu")]
        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string TelefonYakini
        {
            get => telefonYakini;
            set => SetPropertyValue(nameof(TelefonYakini), ref telefonYakini, value);
        }



        [XafDisplayName("Dernekten Talebi")]
        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Dernektentalbi
        {
            get => dernektentalbi;
            set => SetPropertyValue(nameof(Dernektentalbi), ref dernektentalbi, value);
        }


      
        
        [Size(90)]
        [XafDisplayName("DernekCevabi")]
        public string DernekCevabi
        {
            get => dernekCevabi;
            set => SetPropertyValue(nameof(DernekCevabi), ref dernekCevabi, value);
        }


        [XafDisplayName("Dernek/Kurum Tarafından Yapılan İşlemler")]
        [Association("MagdurTakipKarti-MagdurAltCevaps"),DevExpress.Xpo.Aggregated]
        public XPCollection<MagdurAltCevap> Magdurcevap
        {
            get
            {
                return GetCollection<MagdurAltCevap>(nameof(Magdurcevap));
            }
        }



    }
}