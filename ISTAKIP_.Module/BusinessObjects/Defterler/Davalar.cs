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
   // [ImageName("BO_Position")]
    [XafDisplayName("Dava Genel Bilgileri")]
    //[DefaultProperty("DisplayMemberNameForLookupEditorsOfThisType")]
    //[DefaultListViewOptions(MasterDetailMode.ListViewOnly, false, NewItemRowPosition.None)]
    //[Persistent("DatabaseTableName")]
    // Specify more UI options using a declarative approach (https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument112701).
    public class Davalar : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public Davalar(Session session)
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



        string davaninMahkemesi;
        string mailAdresi;
        string ısAdresi;
        string cepTelefonu;
        string davaciYazilmaAdresi;
        FileData davaEkb;
        FileData davaEka;
        bool davaPasif;
        bool davaAktif;
        string aciklamasi;
        string sendikaAdi;
        string sendikaMiktar;
        string gonderilenMiktar;
        string davaAvukati;
        string davaEsasNo;
        DateTime davaREgister;
        string davaliBilgisi;
        string culkesi;
        string kobusu;
        string davaci;

        [Size(80)]
        [XafDisplayName("Davacı")]
        public string Davaci
        {
            get => davaci;
            set => SetPropertyValue(nameof(Davaci), ref davaci, value);
        }



        [Size(80)]
        [XafDisplayName("Konusu")]
        public string Kobusu
        {
            get => kobusu;
            set => SetPropertyValue(nameof(Kobusu), ref kobusu, value);
        }



        [Size(80)]
        [XafDisplayName("İl")]
        public string Culkesi
        {
            get => culkesi;
            set => SetPropertyValue(nameof(Culkesi), ref culkesi, value);
        }

        ///Şubesi
        ///
        //[XafDisplayName("Şubesi")]
        //public SubeEkle SubeEkle
        //{
        //    get => subeEkle;
        //    set => SetPropertyValue(nameof(SubeEkle), ref subeEkle, value);
        //}



        [Size(80)]
        [XafDisplayName("Davalı")]
        public string DavaliBilgisi
        {
            get => davaliBilgisi;
            set => SetPropertyValue(nameof(DavaliBilgisi), ref davaliBilgisi, value);
        }


        [XafDisplayName("Davanın Açıldığı Tarih")]
        public DateTime DavaREgister
        {
            get => davaREgister;
            set => SetPropertyValue(nameof(DavaREgister), ref davaREgister, value);
        }

        
        [Size(80)]
        [XafDisplayName("Davanın Açıldığı Mahkeme")]
        public string DavaninMahkemesi
        {
            get => davaninMahkemesi;
            set => SetPropertyValue(nameof(DavaninMahkemesi), ref davaninMahkemesi, value);
        }


        [Size(80)]
        [XafDisplayName("Dava Esas No")]
        public string DavaEsasNo
        {
            get => davaEsasNo;
            set => SetPropertyValue(nameof(DavaEsasNo), ref davaEsasNo, value);
        }

        [XafDisplayName("Davayı Açan Avukat")]

        [Size(80)]
        public string DavaAvukati
        {
            get => davaAvukati;
            set => SetPropertyValue(nameof(DavaAvukati), ref davaAvukati, value);
        }



        [Size(80)]
        [XafDisplayName("Davacının Gönderdiği Miktar")]
        public string GonderilenMiktar
        {
            get => gonderilenMiktar;
            set => SetPropertyValue(nameof(GonderilenMiktar), ref gonderilenMiktar, value);
        }


        [Size(80)]
        [XafDisplayName("Sendikanın Gönderdiği Miktar")]
        public string SendikaMiktar
        {
            get => sendikaMiktar;
            set => SetPropertyValue(nameof(SendikaMiktar), ref sendikaMiktar, value);
        }



        [Size(80)]
        [XafDisplayName("Masrafın Sendika Karşılığı")]
        public string SendikaAdi
        {
            get => sendikaAdi;
            set => SetPropertyValue(nameof(SendikaAdi), ref sendikaAdi, value);
        }


        [Size(350)]
        [XafDisplayName("Açıklaması")]
        public string Aciklamasi
        {
            get => aciklamasi;
            set => SetPropertyValue(nameof(Aciklamasi), ref aciklamasi, value);
        }

        [XafDisplayName("Dava Devam Ediyor")]
        public bool DavaAktif

        {
            get => davaAktif;
            set => SetPropertyValue(nameof(DavaAktif), ref davaAktif, value);
        }



        [XafDisplayName("Dava Bitti")]
        public bool DavaPasif
        {
            get => davaPasif;
            set => SetPropertyValue(nameof(DavaPasif), ref davaPasif, value);
        }

        [XafDisplayName("Dava Ek Dosyası -1")]
        public FileData DavaEka
        {
            get => davaEka;
            set => SetPropertyValue(nameof(DavaEka), ref davaEka, value);
        }

        [XafDisplayName("Dava Ek Dosyası -2")]
        public FileData DavaEkb
        {
            get => davaEkb;
            set => SetPropertyValue(nameof(DavaEkb), ref davaEkb, value);
        }


        [Size(200)]
        [XafDisplayName("Yazışma Adresi")]
        public string DavaciYazilmaAdresi
        {
            get => davaciYazilmaAdresi;
            set => SetPropertyValue(nameof(DavaciYazilmaAdresi), ref davaciYazilmaAdresi, value);
        }


        [ModelDefault("EditMask", "(000)-000-00-00"), Index(0), VisibleInListView(false)]
        public string CepTelefonu
        {
            get => cepTelefonu;
            set => SetPropertyValue(nameof(CepTelefonu), ref cepTelefonu, value);
        }


        [Size(200)]
        [XafDisplayName("İş Adresi")]
        public string IsAdresi
        {
            get => ısAdresi;
            set => SetPropertyValue(nameof(IsAdresi), ref ısAdresi, value);
        }


        [Size(50)]
        [XafDisplayName("Mail Adresi")]
        public string MailAdresi
        {
            get => mailAdresi;
            set => SetPropertyValue(nameof(MailAdresi), ref mailAdresi, value);
        }


    }
}