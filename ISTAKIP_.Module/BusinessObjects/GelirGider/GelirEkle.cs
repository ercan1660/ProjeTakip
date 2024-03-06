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
    [XafDisplayName("Gelir Bilgileri")]
    //[ImageName("BO_Contact")]
    //[DefaultProperty("DisplayMemberNameForLookupEditorsOfThisType")]
    //[DefaultListViewOptions(MasterDetailMode.ListViewOnly, false, NewItemRowPosition.None)]
    //[Persistent("DatabaseTableName")]
    // Specify more UI options using a declarative approach (https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument112701).
    public class GelirEkle : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public GelirEkle(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }


        DateTime registerDate;
        string aciklamaBilgisi;
        string odemeyiYapan;
        int gelirTutari;


        [XafDisplayName("Gelir Tutarı")]

        public int GelirTutari
        {
            get => gelirTutari;
            set => SetPropertyValue(nameof(GelirTutari), ref gelirTutari, value);
        }


        [Size(50)]
        [RuleRequiredField(DefaultContexts.Save)]
        [XafDisplayName("Ödemeyi Yapan")]
        public string OdemeyiYapan
        {
            get => odemeyiYapan;
            set => SetPropertyValue(nameof(OdemeyiYapan), ref odemeyiYapan, value);
        }



        [Size(250)]
        [XafDisplayName("Açıklama")]
        [RuleRequiredField(DefaultContexts.Save)]
        public string AciklamaBilgisi
        {
            get => aciklamaBilgisi;
            set => SetPropertyValue(nameof(AciklamaBilgisi), ref aciklamaBilgisi, value);
        }


        [XafDisplayName("Tarih")]
        public DateTime RegisterDate
        {
            get => registerDate;
            set => SetPropertyValue(nameof(RegisterDate), ref registerDate, value);
        }


        //[XafDisplayName("Özel Notlar")]
        //[Association("NewMember-AciklamaDetaylari"), DevExpress.Xpo.Aggregated]
        //public XPCollection<MemberNotlar> AciklamaDetaylari
        //{
        //    get
        //    {
        //        return GetCollection<MemberNotlar>(nameof(AciklamaDetaylari));
        //    }
        //}





    }
}
