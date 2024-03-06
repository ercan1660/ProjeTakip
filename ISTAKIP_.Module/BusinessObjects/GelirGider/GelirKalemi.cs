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
    [XafDisplayName("Gelir Kalemi Girişi")]
  
    public class GelirKalemi : BaseObject
    { 

        public GelirKalemi(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }




        int code;
        string name;

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        [XafDisplayName("Gelir Kalemi")]
        public string Name
        {
            get => name;
            set => SetPropertyValue(nameof(Name), ref name, value);
        }

        [XafDisplayName("Gelir Kodu")]
        public int Code
        {
            get => code;
            set => SetPropertyValue(nameof(Code), ref code, value);
        }





        
        //[Association("GelirGider.GelirEkle-GelirKalemis")]
        //public GelirGider.GelirEkle GelirEkle
        //{
        //    get => gelirEkle;
        //    set => SetPropertyValue(nameof(GelirEkle), ref gelirEkle, value);
        //}


    }
}