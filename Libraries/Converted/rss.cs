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
namespace Aliencube.FeedSchemata.Rss {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.rssboard.org/rss-specification")]
    [System.Xml.Serialization.XmlRootAttribute("rss", Namespace="http://www.rssboard.org/rss-specification", IsNullable=false)]
    public partial class Rss {
        
        private Channel channelField;
        
        private decimal versionField;
        
        private System.Xml.XmlAttribute[] anyAttrField;
        
        public Rss() {
            this.versionField = ((decimal)(2.0m));
        }
        
        /// <remarks/>
        public Channel channel {
            get {
                return this.channelField;
            }
            set {
                this.channelField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal version {
            get {
                return this.versionField;
            }
            set {
                this.versionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyAttributeAttribute()]
        public System.Xml.XmlAttribute[] AnyAttr {
            get {
                return this.anyAttrField;
            }
            set {
                this.anyAttrField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.rssboard.org/rss-specification")]
    public partial class Channel {
        
        private object[] itemsField;
        
        private ItemsChoiceType2[] itemsElementNameField;
        
        private Item[] itemField;
        
        private System.Xml.XmlAttribute[] anyAttrField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("category", typeof(Category))]
        [System.Xml.Serialization.XmlElementAttribute("cloud", typeof(Cloud))]
        [System.Xml.Serialization.XmlElementAttribute("copyright", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("description", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("docs", typeof(string), DataType="anyURI")]
        [System.Xml.Serialization.XmlElementAttribute("generator", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("image", typeof(Image))]
        [System.Xml.Serialization.XmlElementAttribute("language", typeof(string), DataType="language")]
        [System.Xml.Serialization.XmlElementAttribute("lastBuildDate", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("link", typeof(string), DataType="anyURI")]
        [System.Xml.Serialization.XmlElementAttribute("managingEditor", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("pubDate", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("rating", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("skipDays", typeof(SkipDaysList))]
        [System.Xml.Serialization.XmlElementAttribute("skipHours", typeof(SkipHoursList))]
        [System.Xml.Serialization.XmlElementAttribute("textInput", typeof(TextInput))]
        [System.Xml.Serialization.XmlElementAttribute("title", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("ttl", typeof(string), DataType="nonNegativeInteger")]
        [System.Xml.Serialization.XmlElementAttribute("webMaster", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public object[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType2[] ItemsElementName {
            get {
                return this.itemsElementNameField;
            }
            set {
                this.itemsElementNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("item")]
        public Item[] item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyAttributeAttribute()]
        public System.Xml.XmlAttribute[] AnyAttr {
            get {
                return this.anyAttrField;
            }
            set {
                this.anyAttrField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.rssboard.org/rss-specification")]
    public partial class Category {
        
        private string domainField;
        
        private string valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string domain {
            get {
                return this.domainField;
            }
            set {
                this.domainField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.rssboard.org/rss-specification")]
    public partial class Source {
        
        private string urlField;
        
        private string valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string url {
            get {
                return this.urlField;
            }
            set {
                this.urlField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.rssboard.org/rss-specification")]
    public partial class Guid {
        
        private bool isPermaLinkField;
        
        private string valueField;
        
        public Guid() {
            this.isPermaLinkField = true;
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool isPermaLink {
            get {
                return this.isPermaLinkField;
            }
            set {
                this.isPermaLinkField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.rssboard.org/rss-specification")]
    public partial class Enclosure {
        
        private string urlField;
        
        private string lengthField;
        
        private string typeField;
        
        private string valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string url {
            get {
                return this.urlField;
            }
            set {
                this.urlField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        public string length {
            get {
                return this.lengthField;
            }
            set {
                this.lengthField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.rssboard.org/rss-specification")]
    public partial class Item {
        
        private object[] itemsField;
        
        private ItemsChoiceType3[] itemsElementNameField;
        
        private System.Xml.XmlAttribute[] anyAttrField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("author", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("category", typeof(Category))]
        [System.Xml.Serialization.XmlElementAttribute("comments", typeof(string), DataType="anyURI")]
        [System.Xml.Serialization.XmlElementAttribute("description", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("enclosure", typeof(Enclosure))]
        [System.Xml.Serialization.XmlElementAttribute("guid", typeof(Guid))]
        [System.Xml.Serialization.XmlElementAttribute("link", typeof(string), DataType="anyURI")]
        [System.Xml.Serialization.XmlElementAttribute("pubDate", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("source", typeof(Source))]
        [System.Xml.Serialization.XmlElementAttribute("title", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public object[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType3[] ItemsElementName {
            get {
                return this.itemsElementNameField;
            }
            set {
                this.itemsElementNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyAttributeAttribute()]
        public System.Xml.XmlAttribute[] AnyAttr {
            get {
                return this.anyAttrField;
            }
            set {
                this.anyAttrField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.rssboard.org/rss-specification", IncludeInSchema=false)]
    public enum ItemsChoiceType3 {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("##any:")]
        Item,
        
        /// <remarks/>
        author,
        
        /// <remarks/>
        category,
        
        /// <remarks/>
        comments,
        
        /// <remarks/>
        description,
        
        /// <remarks/>
        enclosure,
        
        /// <remarks/>
        guid,
        
        /// <remarks/>
        link,
        
        /// <remarks/>
        pubDate,
        
        /// <remarks/>
        source,
        
        /// <remarks/>
        title,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.rssboard.org/rss-specification")]
    public partial class SkipDaysList {
        
        private SkipDay[] dayField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("day")]
        public SkipDay[] day {
            get {
                return this.dayField;
            }
            set {
                this.dayField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.rssboard.org/rss-specification")]
    public enum SkipDay {
        
        /// <remarks/>
        Monday,
        
        /// <remarks/>
        Tuesday,
        
        /// <remarks/>
        Wednesday,
        
        /// <remarks/>
        Thursday,
        
        /// <remarks/>
        Friday,
        
        /// <remarks/>
        Saturday,
        
        /// <remarks/>
        Sunday,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.rssboard.org/rss-specification")]
    public partial class SkipHoursList {
        
        private string[] hourField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("hour", DataType="nonNegativeInteger")]
        public string[] hour {
            get {
                return this.hourField;
            }
            set {
                this.hourField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.rssboard.org/rss-specification")]
    public partial class TextInput {
        
        private string[] itemsField;
        
        private ItemsChoiceType1[] itemsElementNameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("description", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("link", typeof(string), DataType="anyURI")]
        [System.Xml.Serialization.XmlElementAttribute("name", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("title", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public string[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType1[] ItemsElementName {
            get {
                return this.itemsElementNameField;
            }
            set {
                this.itemsElementNameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.rssboard.org/rss-specification", IncludeInSchema=false)]
    public enum ItemsChoiceType1 {
        
        /// <remarks/>
        description,
        
        /// <remarks/>
        link,
        
        /// <remarks/>
        name,
        
        /// <remarks/>
        title,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.rssboard.org/rss-specification")]
    public partial class Image {
        
        private string[] itemsField;
        
        private ItemsChoiceType[] itemsElementNameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("description", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("height", typeof(string), DataType="positiveInteger")]
        [System.Xml.Serialization.XmlElementAttribute("link", typeof(string), DataType="anyURI")]
        [System.Xml.Serialization.XmlElementAttribute("title", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("url", typeof(string), DataType="anyURI")]
        [System.Xml.Serialization.XmlElementAttribute("width", typeof(string), DataType="positiveInteger")]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public string[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType[] ItemsElementName {
            get {
                return this.itemsElementNameField;
            }
            set {
                this.itemsElementNameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.rssboard.org/rss-specification", IncludeInSchema=false)]
    public enum ItemsChoiceType {
        
        /// <remarks/>
        description,
        
        /// <remarks/>
        height,
        
        /// <remarks/>
        link,
        
        /// <remarks/>
        title,
        
        /// <remarks/>
        url,
        
        /// <remarks/>
        width,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.rssboard.org/rss-specification")]
    public partial class Cloud {
        
        private string domainField;
        
        private string portField;
        
        private string pathField;
        
        private string registerProcedureField;
        
        private CloudProtocol protocolField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string domain {
            get {
                return this.domainField;
            }
            set {
                this.domainField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
        public string port {
            get {
                return this.portField;
            }
            set {
                this.portField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string path {
            get {
                return this.pathField;
            }
            set {
                this.pathField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string registerProcedure {
            get {
                return this.registerProcedureField;
            }
            set {
                this.registerProcedureField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public CloudProtocol protocol {
            get {
                return this.protocolField;
            }
            set {
                this.protocolField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.rssboard.org/rss-specification")]
    public enum CloudProtocol {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("xml-rpc")]
        xmlrpc,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("http-post")]
        httppost,
        
        /// <remarks/>
        soap,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.rssboard.org/rss-specification", IncludeInSchema=false)]
    public enum ItemsChoiceType2 {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("##any:")]
        Item,
        
        /// <remarks/>
        category,
        
        /// <remarks/>
        cloud,
        
        /// <remarks/>
        copyright,
        
        /// <remarks/>
        description,
        
        /// <remarks/>
        docs,
        
        /// <remarks/>
        generator,
        
        /// <remarks/>
        image,
        
        /// <remarks/>
        language,
        
        /// <remarks/>
        lastBuildDate,
        
        /// <remarks/>
        link,
        
        /// <remarks/>
        managingEditor,
        
        /// <remarks/>
        pubDate,
        
        /// <remarks/>
        rating,
        
        /// <remarks/>
        skipDays,
        
        /// <remarks/>
        skipHours,
        
        /// <remarks/>
        textInput,
        
        /// <remarks/>
        title,
        
        /// <remarks/>
        ttl,
        
        /// <remarks/>
        webMaster,
    }
}
