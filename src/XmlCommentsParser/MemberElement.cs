using System.Collections.Generic;
using System.Xml.Serialization;

namespace XmlCommentsParser
{
    public class MemberElement
    {
        [XmlAttribute(AttributeName = "name")] 
        public string Name { get; set; }

        [XmlElement(ElementName = "example")]
        public ExampleElement Example { get; set; }

        [XmlElement(ElementName= "exception", IsNullable=true, Type = typeof(ExceptionElement))]
        public ExceptionElement[] Exceptions { get; set; }

        [XmlElement(ElementName = "summary")]
        public SummaryElement Summary { get; set; }

        [XmlElement(ElementName = "remarks")]
        public string Remarks { get; set; }

        [XmlElement(ElementName = "returns")]
        public ReturnsElement Returns { get; set; }

        [XmlElement(ElementName= "param", IsNullable=true, Type = typeof(ParameterElement))]
        public ParameterElement[] Parameters { get; set; }

        [XmlElement(ElementName= "typeparam", IsNullable=true, Type = typeof(ParameterElement))]
        public ParameterElement[] TypeParameters { get; set; }

        [XmlElement(ElementName = "value")]
        public ValueElement Value { get; set; }
    }
}