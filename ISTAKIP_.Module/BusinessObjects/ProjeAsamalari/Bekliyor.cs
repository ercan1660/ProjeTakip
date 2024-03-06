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
using System.Drawing;
using System.Linq;
using System.Text;

namespace ISTAKIP_.Module.BusinessObjects.ProjeAsamalari
{
    [DefaultClassOptions]
    //[ImageName("BO_Contact")]
    //[DefaultProperty("DisplayMemberNameForLookupEditorsOfThisType")]
    //[DefaultListViewOptions(MasterDetailMode.ListViewOnly, false, NewItemRowPosition.None)]
    //[Persistent("DatabaseTableName")]
    // Specify more UI options using a declarative approach (https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument112701).
    public class Bekliyor : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public Bekliyor(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }



        string etiketler;
        DateTime bitisTarihi;
        DateTime baslangicTarihi;
        string aciklama;
        string ad;

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Ad
        {
            get => ad;
            set => SetPropertyValue(nameof(Ad), ref ad, value);
        }



        [Size(300)]
        public string Aciklama
        {
            get => aciklama;
            set => SetPropertyValue(nameof(Aciklama), ref aciklama, value);
        }


        public DateTime BaslangicTarihi
        {
            get => baslangicTarihi;
            set => SetPropertyValue(nameof(BaslangicTarihi), ref baslangicTarihi, value);
        }


        public DateTime BitisTarihi
        {
            get => bitisTarihi;
            set => SetPropertyValue(nameof(BitisTarihi), ref bitisTarihi, value);
        }


        
        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Etiketler
        {
            get => etiketler;
            set => SetPropertyValue(nameof(Etiketler), ref etiketler, value);
        }

        [XafDisplayName("Öncelik")]
        [Persistent("Color")]
        private Int32 color;
        [NonPersistent]
        public Color Color
        {
            get { return Color.FromArgb(color); }
            set
            {
                color = value.ToArgb();
                OnChanged(nameof(Color));
            }
        }




    }
}