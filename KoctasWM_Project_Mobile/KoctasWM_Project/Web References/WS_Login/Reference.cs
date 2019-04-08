﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.8669
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.CompactFramework.Design.Data, Version 2.0.50727.8669.
// 
namespace KoctasWM_Project.WS_Login {
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
    [System.Web.Services.WebServiceBindingAttribute(Name="ZKT_WM_WS_LOGIN", Namespace="urn:sap-com:document:sap:rfc:functions")]
    public partial class ZKT_WM_WS_LOGIN : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        /// <remarks/>
        public ZKT_WM_WS_LOGIN() {
            this.Url = "http://kterpdev.koctas.com.tr:8000/sap/bc/srt/rfc/sap/zkt_wm_ws_login/500/zkt_wm_" +
                "ws_login/zkt_wm_ws_login";
            this.Timeout = 300000;    // Gökhanın isteği üzerine timeout, 5 dk ya çıkartıldı.
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:sap-com:document:sap:rfc:functions:zkt_wm_ws_login:ZKT_WM_LOGINRequest", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Bare)]
        [return: System.Xml.Serialization.XmlElementAttribute("ZKT_WM_LOGINResponse", Namespace="urn:sap-com:document:sap:rfc:functions")]
        public ZKT_WM_LOGINResponse ZKT_WM_LOGIN([System.Xml.Serialization.XmlElementAttribute("ZKT_WM_LOGIN", Namespace="urn:sap-com:document:sap:rfc:functions")] ZKT_WM_LOGIN ZKT_WM_LOGIN1) {
            object[] results = this.Invoke("ZKT_WM_LOGIN", new object[] {
                        ZKT_WM_LOGIN1});
            return ((ZKT_WM_LOGINResponse)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginZKT_WM_LOGIN(ZKT_WM_LOGIN ZKT_WM_LOGIN1, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("ZKT_WM_LOGIN", new object[] {
                        ZKT_WM_LOGIN1}, callback, asyncState);
        }
        
        /// <remarks/>
        public ZKT_WM_LOGINResponse EndZKT_WM_LOGIN(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((ZKT_WM_LOGINResponse)(results[0]));
        }
    }
    
    /// <remarks/>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:sap-com:document:sap:rfc:functions")]
    public partial class ZKT_WM_LOGIN {
        
        private string i_USERField;
        
        private ZKMOBIL_RETURN[] t_RETURNField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string I_USER {
            get {
                return this.i_USERField;
            }
            set {
                this.i_USERField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public ZKMOBIL_RETURN[] T_RETURN {
            get {
                return this.t_RETURNField;
            }
            set {
                this.t_RETURNField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:sap-com:document:sap:rfc:functions")]
    public partial class ZKMOBIL_RETURN {
        
        private string rC_CODEField;
        
        private string rC_TEXTField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string RC_CODE {
            get {
                return this.rC_CODEField;
            }
            set {
                this.rC_CODEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string RC_TEXT {
            get {
                return this.rC_TEXTField;
            }
            set {
                this.rC_TEXTField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:sap-com:document:sap:rfc:functions")]
    public partial class ZKT_WM_LOGINResponse {
        
        private string e_MAGNETField;
        
        private System.DateTime e_SAATField;
        
        private string e_TARIHField;
        
        private string e_WERKSField;
        
        private ZKMOBIL_RETURN[] t_RETURNField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string E_MAGNET {
            get {
                return this.e_MAGNETField;
            }
            set {
                this.e_MAGNETField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="time")]
        public System.DateTime E_SAAT {
            get {
                return this.e_SAATField;
            }
            set {
                this.e_SAATField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string E_TARIH {
            get {
                return this.e_TARIHField;
            }
            set {
                this.e_TARIHField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string E_WERKS {
            get {
                return this.e_WERKSField;
            }
            set {
                this.e_WERKSField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public ZKMOBIL_RETURN[] T_RETURN {
            get {
                return this.t_RETURNField;
            }
            set {
                this.t_RETURNField = value;
            }
        }
    }
}
