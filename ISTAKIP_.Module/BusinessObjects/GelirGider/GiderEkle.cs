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

namespace ETUFADS.Module.BusinessObjects.GelirGider
{
    [DefaultClassOptions]
    [XafDisplayName("Gider Ekle")]
    //[ImageName("BO_Contact")]
    //[DefaultProperty("DisplayMemberNameForLookupEditorsOfThisType")]
    //[DefaultListViewOptions(MasterDetailMode.ListViewOnly, false, NewItemRowPosition.None)]
    //[Persistent("DatabaseTableName")]
    // Specify more UI options using a declarative approach (https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument112701).
    public class GiderEkle : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public GiderEkle(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }



        DateTime faturaRegisterTime;
        DateTime registerDateTime;
        FileData makbuzDekont;
        string faturaNo;
        string aciklamaBilgisi;
        GelirGider.GiderKalemi giderKalemi;
        int giderTutari;




        [XafDisplayName("İşlem Tarihi")]
        public DateTime RegisterDateTime
        {
            get => registerDateTime;
            set => SetPropertyValue(nameof(RegisterDateTime), ref registerDateTime, value);
        }



        [XafDisplayName("Fatura Tarihi")]
        public DateTime FaturaRegisterTime
        {
            get => faturaRegisterTime;
            set => SetPropertyValue(nameof(FaturaRegisterTime), ref faturaRegisterTime, value);
        }

        [XafDisplayName("Gider Tutarı")]
        public int GiderTutari
        {
            get => giderTutari;
            set => SetPropertyValue(nameof(GiderTutari), ref giderTutari, value);
        }


        [XafDisplayName("Gider Kalemi")]
        public GelirGider.GiderKalemi GiderKalemi
        {
            get => giderKalemi;
            set => SetPropertyValue(nameof(GiderKalemi), ref giderKalemi, value);
        }




        [Size(350)]
        [XafDisplayName("Açıklama")]
        public string AciklamaBilgisi
        {
            get => aciklamaBilgisi;
            set => SetPropertyValue(nameof(AciklamaBilgisi), ref aciklamaBilgisi, value);
        }



        [Size(50)]
        [XafDisplayName("Fatura No")]
        public string FaturaNo
        {
            get => faturaNo;
            set => SetPropertyValue(nameof(FaturaNo), ref faturaNo, value);
        }


        [XafDisplayName("Makbuz/Dekont Belgesi")]
        public FileData MakbuzDekont
        {
            get => makbuzDekont;
            set => SetPropertyValue(nameof(MakbuzDekont), ref makbuzDekont, value);
        }






    }
}