﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.9040
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.CompactFramework.Design.Data, Version 2.0.50727.9040.
// 
namespace KoctasWM_Project.WS_Koli {
    using System.Diagnostics;
    using System.Web.Services;
    using System.ComponentModel;
    using System.Web.Services.Protocols;
    using System;
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    // CODEGEN: The optional WSDL extension element 'Policy' from namespace 'http://schemas.xmlsoap.org/ws/2004/09/policy' was not handled.
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="Z_KT_WM_KOLI_DETAY", Namespace="urn:sap-com:document:sap:soap:functions:mc-style")]
    public partial class Z_KT_WM_KOLI_DETAY : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        /// <remarks/>
        public Z_KT_WM_KOLI_DETAY() {
            this.Url = "http://kterpdev.koctas.com.tr:8000/sap/bc/srt/rfc/sap/z_kt_wm_koli_detay/500/z_kt" +
                "_wm_koli_detay/z_kt_wm_koli_detay";
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:sap-com:document:sap:soap:functions:mc-style:Z_KT_WM_KOLI_DETAY:ZKtWmKoliDeta" +
            "yRequest", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Bare)]
        [return: System.Xml.Serialization.XmlElementAttribute("ZKtWmKoliDetayResponse", Namespace="urn:sap-com:document:sap:soap:functions:mc-style")]
        public ZKtWmKoliDetayResponse ZKtWmKoliDetay([System.Xml.Serialization.XmlElementAttribute("ZKtWmKoliDetay", Namespace="urn:sap-com:document:sap:soap:functions:mc-style")] ZKtWmKoliDetay ZKtWmKoliDetay1) {
            object[] results = this.Invoke("ZKtWmKoliDetay", new object[] {
                        ZKtWmKoliDetay1});
            return ((ZKtWmKoliDetayResponse)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginZKtWmKoliDetay(ZKtWmKoliDetay ZKtWmKoliDetay1, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("ZKtWmKoliDetay", new object[] {
                        ZKtWmKoliDetay1}, callback, asyncState);
        }
        
        /// <remarks/>
        public ZKtWmKoliDetayResponse EndZKtWmKoliDetay(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((ZKtWmKoliDetayResponse)(results[0]));
        }
    }
    
    /// <remarks/>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:sap-com:document:sap:soap:functions:mc-style")]
    public partial class ZKtWmKoliDetay {
        
        private string ivKoliNoField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string IvKoliNo {
            get {
                return this.ivKoliNoField;
            }
            set {
                this.ivKoliNoField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:sap-com:document:sap:soap:functions:mc-style")]
    public partial class ZktWmReturn {
        
        private string msgtyField;
        
        private string msgidField;
        
        private string msgnoField;
        
        private string messageField;
        
        private string msgv1Field;
        
        private string msgv2Field;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Msgty {
            get {
                return this.msgtyField;
            }
            set {
                this.msgtyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Msgid {
            get {
                return this.msgidField;
            }
            set {
                this.msgidField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Msgno {
            get {
                return this.msgnoField;
            }
            set {
                this.msgnoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Message {
            get {
                return this.messageField;
            }
            set {
                this.messageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Msgv1 {
            get {
                return this.msgv1Field;
            }
            set {
                this.msgv1Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Msgv2 {
            get {
                return this.msgv2Field;
            }
            set {
                this.msgv2Field = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:sap-com:document:sap:soap:functions:mc-style")]
    public partial class ZKtWmKoliDetayResponse {
        
        private ZktWmReturn[] esResponseField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public ZktWmReturn[] EsResponse {
            get {
                return this.esResponseField;
            }
            set {
                this.esResponseField = value;
            }
        }
    }
}
