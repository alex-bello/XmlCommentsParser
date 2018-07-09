using System.Collections.Generic;
using System.Xml.Serialization;

namespace TestXml.XmlCodeComments
{
    public class XmlCodeCommentMember
    {
        [XmlAttribute(AttributeName = "name")] 
        public string Name { get; set; }

        [XmlElement(ElementName = "example")]
        public XmlCodeCommentExample Example { get; set; }

        [XmlElement(ElementName= "exception", IsNullable=true, Type = typeof(XmlCodeCommentException))]
        public XmlCodeCommentException[] Exceptions { get; set; }

        [XmlElement(ElementName = "summary")]
        public XmlCodeCommentSummary Summary { get; set; }

        [XmlElement(ElementName = "remarks")]
        public string Remarks { get; set; }

        [XmlElement(ElementName = "returns")]
        public XmlCodeCommentReturns Returns { get; set; }

        [XmlElement(ElementName= "param", IsNullable=true, Type = typeof(XmlCodeCommentParameter))]
        public XmlCodeCommentParameter[] Parameters { get; set; }

        [XmlElement(ElementName= "typeparam", IsNullable=true, Type = typeof(XmlCodeCommentParameter))]
        public XmlCodeCommentParameter[] TypeParameters { get; set; }

        [XmlElement(ElementName = "value")]
        public XmlCodeCommentValue Value { get; set; }
    }
}