﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18051
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by xsd, Version=4.0.30319.17929.
// 
namespace Aliencube.FeedSchemata.Extensions {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://purl.org/rss/1.0/modules/content/")]
    [System.Xml.Serialization.XmlRootAttribute("content", Namespace="http://purl.org/rss/1.0/modules/content/", IsNullable=false)]
    public partial class Content {
        
        private string encodedField;
        
        /// <remarks/>
        public string encoded {
            get {
                return this.encodedField;
            }
            set {
                this.encodedField = value;
            }
        }
    }
}
