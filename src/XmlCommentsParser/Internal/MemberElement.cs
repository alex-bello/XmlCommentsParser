using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

namespace XmlCommentsParser
{
    public class MemberXmlElement
    {
        [XmlAttribute(AttributeName = "name")] 
        public string Name { get; set; }

        [XmlAnyElement("example")]
        public XmlElement Example { get; set; }

        [XmlElement(ElementName= "exception", IsNullable=true, Type = typeof(ExceptionElement))]
        public ExceptionElement[] Exceptions { get; set; }

        [XmlAnyElement("summary")]
        public XmlElement Summary { get; set; }

        [XmlAnyElement("remarks")]
        public XmlElement Remarks { get; set; }

        [XmlAnyElement("returns")]
        public XmlElement Returns { get; set; }

        [XmlElement(ElementName= "param", IsNullable=true, Type = typeof(ParameterElement))]
        public ParameterElement[] Parameters { get; set; }

        [XmlElement(ElementName= "typeparam", IsNullable=true, Type = typeof(ParameterElement))]
        public ParameterElement[] TypeParameters { get; set; }

        [XmlAnyElement("value")]
        public XmlElement Value { get; set; }
    }
}