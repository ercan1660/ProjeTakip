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
    [XafDisplayName("Demirbaş Girişi")]
    [ImageName("BO_Contact")]
    //[DefaultProperty("DisplayMemberNameForLookupEditorsOfThisType")]
    //[DefaultListViewOptions(MasterDetailMode.ListViewOnly, false, NewItemRowPosition.None)]
    //[Persistent("DatabaseTableName")]
    // Specify more UI options using a declarative approach (https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument112701).
    public class Demirbas : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        public Demirbas(Session session)
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



        FileData garantiBelgesi;
        string alisFirmaTelefon;
        string detailsAciklamalar;
        string kayitDusmaKararNo;
        DateTime kayitDusRegister;
        string sonDurumu;
        string edinmeSekli;
        DateTime garantiRegister;
        string alisFaturaNo;
        int kDVDeger;
        int netDeger;
        string alisKararNo;
        string alisYapanFirmaAdi;
        string verildigiYer;
        int demirbasTOplamDegeri;
        DateTime demirbasRegister;
        int demirbasAlisFiyat;
        int demirbasMiktar;
        string demirbasCinsi;
        string demirbasKod;

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        [XafDisplayName("Demirbaş Kodu")]
        public string DemirbasKod
        {
            get => demirbasKod;
            set => SetPropertyValue(nameof(DemirbasKod), ref demirbasKod, value);
        }




        [Size(50)]
        [XafDisplayName("Cinsi, Şekli Vasıfları")]
        public string DemirbasCinsi
        {
            get => demirbasCinsi;
            set => SetPropertyValue(nameof(DemirbasCinsi), ref demirbasCinsi, value);
        }


        [XafDisplayName("Miktar")]
        public int DemirbasMiktar
        {
            get => demirbasMiktar;
            set => SetPropertyValue(nameof(DemirbasMiktar), ref demirbasMiktar, value);
        }

        [XafDisplayName("Alış Fiyatı")]
        public int DemirbasAlisFiyat
        {
            get => demirbasAlisFiyat;
            set => SetPropertyValue(nameof(DemirbasAlisFiyat), ref demirbasAlisFiyat, value);
        }



        [XafDisplayName("Alış Tarihi")]
        public DateTime DemirbasRegister
        {
            get => demirbasRegister;
            set => SetPropertyValue(nameof(DemirbasRegister), ref demirbasRegister, value);
        }



        [XafDisplayName("Toplam Değeri")]
        public int DemirbasTOplamDegeri
        {
            get => demirbasTOplamDegeri;
            set => SetPropertyValue(nameof(DemirbasTOplamDegeri), ref demirbasTOplamDegeri, value);
        }




        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        [XafDisplayName("Verildiği Yer")]
        public string VerildigiYer
        {
            get => verildigiYer;
            set => SetPropertyValue(nameof(VerildigiYer), ref verildigiYer, value);
        }



        [Size(80)]
        [XafDisplayName("Alış Yapan Firma Adı")]
        public string AlisYapanFirmaAdi
        {
            get => alisYapanFirmaAdi;
            set => SetPropertyValue(nameof(AlisYapanFirmaAdi), ref alisYapanFirmaAdi, value);
        }



        [XafDisplayName("Alış Yapan Firma Telefonu")]
        [ModelDefault("EditMask", "(000)-000-00-00"), Index(0), VisibleInListView(false)]
        public string AlisFirmaTelefon
        {
            get => alisFirmaTelefon;
            set => SetPropertyValue(nameof(AlisFirmaTelefon), ref alisFirmaTelefon, value);
        }

        [Size(90)]
        [XafDisplayName("Alış Karar No")]
        public string AlisKararNo
        {
            get => alisKararNo;
            set => SetPropertyValue(nameof(AlisKararNo), ref alisKararNo, value);
        }


        [XafDisplayName("Net Değer")]
        public int NetDeger
        {
            get => netDeger;
            set => SetPropertyValue(nameof(NetDeger), ref netDeger, value);
        }

        [XafDisplayName("KDV Değer")]
        public int KDVDeger
        {
            get => kDVDeger;
            set => SetPropertyValue(nameof(KDVDeger), ref kDVDeger, value);
        }


        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        [XafDisplayName("Alış Fatura No")]
        public string AlisFaturaNo
        {
            get => alisFaturaNo;
            set => SetPropertyValue(nameof(AlisFaturaNo), ref alisFaturaNo, value);
        }


        [XafDisplayName("Garanti Bitiş Tarihi")]
        public DateTime GarantiRegister
        {
            get => garantiRegister;
            set => SetPropertyValue(nameof(GarantiRegister), ref garantiRegister, value);
        }


        [Size(80)]
        [XafDisplayName("Edinme Şekli")]
        public string EdinmeSekli
        {
            get => edinmeSekli;
            set => SetPropertyValue(nameof(EdinmeSekli), ref edinmeSekli, value);
        }



        [Size(90)]
        [XafDisplayName("Son Durumu")]
        public string SonDurumu
        {
            get => sonDurumu;
            set => SetPropertyValue(nameof(SonDurumu), ref sonDurumu, value);
        }


        [XafDisplayName("Kayıt Düşme Karar Tarihi")]
        public DateTime KayitDusRegister
        {
            get => kayitDusRegister;
            set => SetPropertyValue(nameof(KayitDusRegister), ref kayitDusRegister, value);
        }



        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        [XafDisplayName("Kayıt Düşme Karar No")]
        public string KayitDusmaKararNo
        {
            get => kayitDusmaKararNo;
            set => SetPropertyValue(nameof(KayitDusmaKararNo), ref kayitDusmaKararNo, value);
        }



        [Size(350)]
        [XafDisplayName("Açıklama")]
        public string DetailsAciklamalar
        {
            get => detailsAciklamalar;
            set => SetPropertyValue(nameof(DetailsAciklamalar), ref detailsAciklamalar, value);
        }


     


        [XafDisplayName("Demirbaş Resmi"), ToolTip("Demirbaş Resmi")]
        [ImageEditor]
        public Byte[] DemirbasPhoto { get; set; }



        [XafDisplayName("Garanti Belgesi")]
        public FileData GarantiBelgesi
        {
            get => garantiBelgesi;
            set => SetPropertyValue(nameof(GarantiBelgesi), ref garantiBelgesi, value);
        }


    }
}