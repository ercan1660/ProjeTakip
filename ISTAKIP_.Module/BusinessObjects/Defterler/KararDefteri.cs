﻿using DevExpress.Data.Filtering;
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
using DevExpress.XtraRichEdit;
using DevExpress.XtraRichEdit.API.Native;
using System.Drawing;
using System.Diagnostics;
using DevExpress.ExpressApp.Editors;




namespace ETUFADS.Module.BusinessObjects.Defterler
{
    [DefaultClassOptions]
   // [ImageName("BO_Contact")]
    [DefaultProperty("DisplayMemberNameForLookupEditorsOfThisType")]
    [DefaultListViewOptions(MasterDetailMode.ListViewOnly, false, NewItemRowPosition.None)]
    //[Persistent("DatabaseTableName")]
    // Specify more UI options using a declarative approach (https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument112701).
    public class KararDefteri : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public KararDefteri(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }
       


        string gunderm;
        string konu;
        DateTime toplantiRegister;
        DateTime kararRegister;
        string siraNo;
        string kararNO;


        static void Main(string[] args)
        {
            string fileName = "Test.docx";
            using (var wordProcessor = new RichEditDocumentServer())
            {
                Document doc = wordProcessor.Document;
                doc.AppendText("This document is generated by Word Processing Document API");
                CharacterProperties cp =
                    doc.BeginUpdateCharacters(doc.Paragraphs[0].Range);
                cp.ForeColor = Color.FromArgb(0x83, 0x92, 0x96);
                cp.Italic = true;
                doc.EndUpdateCharacters(cp);

                ParagraphProperties pp =
                    doc.BeginUpdateParagraphs(doc.Paragraphs[0].Range);
                pp.Alignment = ParagraphAlignment.Right;
                doc.EndUpdateParagraphs(pp);
                wordProcessor.SaveDocument(fileName, DocumentFormat.OpenXml);
            }
            Process.Start(fileName);
        }



        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        [XafDisplayName("Karar No")]
        public string KararNO
        {
            get => kararNO;
            set => SetPropertyValue(nameof(KararNO), ref kararNO, value);
        }

        [XafDisplayName("Sıra No")]
        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string SiraNo
        {
            get => siraNo;
            set => SetPropertyValue(nameof(SiraNo), ref siraNo, value);
        }

        [XafDisplayName("Karar Tarihi")]
        public DateTime KararRegister
        {
            get => kararRegister;
            set => SetPropertyValue(nameof(KararRegister), ref kararRegister, value);
        }

        [XafDisplayName("Toplantı Tarihi")]
        public DateTime ToplantiRegister
        {
            get => toplantiRegister;
            set => SetPropertyValue(nameof(ToplantiRegister), ref toplantiRegister, value);
        }



        [Size(100)]
        [RuleRequiredField("Konu Belirtiniz", DefaultContexts.Save)]
        [XafDisplayName("Konu")]
        public string Konu
        {
            get => konu;
            set => SetPropertyValue(nameof(Konu), ref konu, value);
        }


        [Size(100)]
        [XafDisplayName("Gündem")]
        public string Gunderm
        {
            get => gunderm;
            set => SetPropertyValue(nameof(Gunderm), ref gunderm, value);
        }




        private string text;
        [XafDisplayName("Karar İçeriği")]
        [Size(SizeAttribute.Unlimited)]
        [EditorAlias(EditorAliases.RichTextPropertyEditor)]
        public string Text
        {
            get { return text; }
            set { SetPropertyValue(nameof(Text), ref text, value); }
        }



     




   
    }




}