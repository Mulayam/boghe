﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3615
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by xsd, Version=2.0.50727.3038.
// 
namespace BogheXdm.Generated.oma.pres_rules {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:oma:xml:prs:pub-rules")]
    [System.Xml.Serialization.XmlRootAttribute("pub-handling", Namespace="urn:oma:xml:prs:pub-rules", IsNullable=false)]
    public enum pubhandling {
        
        /// <remarks/>
        block,
        
        /// <remarks/>
        allow,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:oma:xml:prs:pub-rules")]
    [System.Xml.Serialization.XmlRootAttribute("perm-handling", Namespace="urn:oma:xml:prs:pub-rules", IsNullable=false)]
    public enum permhandling {
        
        /// <remarks/>
        block,
        
        /// <remarks/>
        allow,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:oma:xml:prs:pub-rules")]
    [System.Xml.Serialization.XmlRootAttribute("allow-all-attributes", Namespace="urn:oma:xml:prs:pub-rules", IsNullable=false)]
    public partial class allowallattributes {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:oma:xml:prs:pub-rules")]
    [System.Xml.Serialization.XmlRootAttribute("allow-unknown-attribute", Namespace="urn:oma:xml:prs:pub-rules", IsNullable=false)]
    public partial class allowunknownattribute {
        
        private string nameField;
        
        private string nsField;
        
        private bool valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ns {
            get {
                return this.nsField;
            }
            set {
                this.nsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public bool Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
}
